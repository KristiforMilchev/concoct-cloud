namespace Platform.Controllers {
    using System.Collections.Generic;
    using System.Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;
    using Platform.DatabaseHandlers.Contexts;
    using Platform.DataHandlers;
    using Platform.DataHandlers.Interfaces;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;

    public class WidgetController : Controller {
        DatabaseContext Context;
        IConfiguration Configuration;
        AutherizationManager AutherizationManager { get; set; } 
        private int UserId { get; set; }

        public WidgetController (DatabaseContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor) {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager) autherizationManager;
            UserId = AutherizationManager.GetCurrentUser (UserId, httpContextAccessor.HttpContext.Request);
        }
        public IActionResult Index () {
            return View ();
        }

        public IActionResult Queries(int projectId)
        {
            ViewData["ProjectId"] = projectId;
            return View();
        }
          public IActionResult NewQuery(int projectId)
        {
            ViewData["ProjectId"] = projectId;
            return View();
        }
        [HttpGet]
        public IActionResult GetBindingOptions(int projectId, string phase) 
        {
            return ViewComponent("DataBinder", new IncomingIdRequest{
                ProjectId = projectId,
                Phase = phase
            });
        }
        [HttpGet]

        public IActionResult LoadWidget(int id, int queryId, int projectId, string height) 
        {
            var bindingControl = string.Empty;
            using(var context = new DatabaseController(Context,Configuration))
                bindingControl = context.GetPremadeName(id);
            return ViewComponent(bindingControl, new IncomingIdRequest{
                 Id = id,
                 UserId = queryId,
                 ProjectId = projectId,
                 Phase = height
            });
        }

        [HttpGet]
        public IActionResult LoadControl(string name) => ViewComponent(name);

        [HttpGet]

        public IActionResult LoadControlSettings(int id, int projectId, int dashboard) 
        {
            var bindingControl = string.Empty;
            using(var context = new DatabaseController(Context,Configuration))
                bindingControl = context.GetPremadeName(id);
            return ViewComponent($"{bindingControl}Settings", new IncomingIdRequest{
                 Id = id,
                 ProjectId = projectId,
                 WorkItemType = dashboard
            });
        }
        [HttpGet]
        public IActionResult LoadQueryBinder(int projectId, string control, string field ) 
        {
            return ViewComponent("QueryBuilder", new IncomingIdRequest{
                __RequestVerificationToken  = control,
                Phase = field,
                ProjectId = projectId
            });
        }
    

        [HttpPost]
        public List<BindingQueryProperty> GetQueryProperties([FromBody] IncomingIdRequest request)
        {
            var result = new List<BindingQueryProperty>();
            using(var context = new DatabaseController(Context,Configuration))
            {
                result = context.GetTableProperties(request.Phase);
            }
            return result;
        }
        [HttpPost]
        public PremadeWidgets AppendWidget([FromBody] IncomingIdRequest request)
        {
            var result = new PremadeWidgets();
            using(var context = new DatabaseController(Context,Configuration))
            {
                result = context.SaveWidgetToBoard(request);
            }
            return result;
        }

        [HttpPost]
        public string WidgetResized([FromBody] IncomingIdRequest request)
        {
            using(var context = new DatabaseController(Context,Configuration))
            {
                context.UpdateWidgetResized(request);
            }
            return "Ok";
         }

        
        [HttpPost]
        public DataTable GetQueryDataById([FromBody] IncomingIdRequest request)
        {
            var result = new DataTable();
            using(var context = new DatabaseController(Context,Configuration))
            {
                result = context.GetUserQueryData(UserId,request.Id);
            }
            return result;
        }

        [HttpPost]
        public int GetQueryData([FromBody] IncomingWidgetCreatorRequest request)
        {
            var result = default(int);
            using(var context = new DatabaseController(Context,Configuration))
            {
                result = context.AddUserQuery(request, UserId);
            }
            return result;
        }
        [HttpPost]
        public PremadeWidgets AppendBurndownChart([FromBody] IncomingBurndownChartSetting request)
        {
            var result = default(PremadeWidgets);
            using(var context = new DatabaseController(Context,Configuration))
            {
                
                result = context.SaveBurndownChart(new IncomingIdRequest{
                    WorkItemType = request.ViewComponentId,
                    ProjectId  = request.ProjectId,
                    Id = request.Dashboard,
                    Phase = JsonConvert.SerializeObject(request)
                }, UserId);
            }
            return result;
        }
        

        [HttpPost]
        public PremadeWidgets GetBurndownChart([FromBody] IncomingBurndownChartSetting request)
        {
            var result = default(PremadeWidgets);
            using(var context = new DatabaseController(Context,Configuration))
            {
                
                result = context.SaveBurndownChart(new IncomingIdRequest{
                    WorkItemType = request.ViewComponentId,
                    ProjectId  = request.ProjectId,
                    Id = request.Dashboard,
                    Phase = JsonConvert.SerializeObject(request)
                }, UserId);
            }
            return result;
        }

        [HttpPost]
        public object GetBurndownChartData([FromBody] IncomingBurndownChartSetting request)
        {
            var result = default(object);
            using(var context = new WidgetContext(Context,Configuration))
            {
                
                result = context.GetBurndownChartData(request);
            }
            return result;
        }
    }
}