namespace Platform.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Platform.DatabaseHandlers.Contexts;
    using Platform.DataHandlers;
    using Platform.DataHandlers.Interfaces;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;
    public class DocumentationController : Controller
    {
        DatabaseContext Context;
        IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;
        public DocumentationController(DatabaseContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }


        public IActionResult Index(int Id)
        {
            ViewData["ProjectId"] = Id;
            if(UserId == 0)
            {
                var canView = default(bool);
                using (var context = new DocumentationContext(Context, Configuration))
                    canView = context.CheckDocumentationPublicAccess(Id);
                if(!canView)
                    return View("Error");
            }
            using(var context = new UsersContext(Context,Configuration))
                ViewData["UserRights"] = context.GetUserRights(UserId,Id);
            
            return View();
        }

        public IActionResult Organization(string Id)
        {
            var projectId = default(int);
            using (var context = new DatabaseController(Context, Configuration))
                projectId = context.GetProjectByOrganization(Id);

            if(projectId == 0)
                return View("Error");

            ViewData["ProjectId"] = projectId;

            if (UserId == 0)
            {
                var canView = default(bool);
                using (var context = new DocumentationContext(Context, Configuration))
                    canView = context.CheckDocumentationPublicAccess(projectId);
                if (!canView)
                    return View("Error");
            }
            using (var context = new UsersContext(Context, Configuration))
                ViewData["UserRights"] = context.GetUserRights(UserId, projectId);

            return View("~/Views/Documentation/Index.cshtml");
        }

        [HttpPost]
        public List<OutgoingChatItem> GetNavigation([FromBody] IncomingIdRequest request)
        {
            var result = new List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                result = GetNavigation(request, context);
            }
            return result;
        }

        [HttpPost]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> AddNewCategory([FromBody] IncomingIdRequest request)
        {
          
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.AddNewDocumentationCategory(request);
                result = GetNavigation(request, context);
            }
            return result;
        }


        [HttpPost]
        public List<dynamic> GetProjectDocumentation([FromBody] IncomingIdRequest request)
        {

            var eResult = new List<dynamic>();
            var result = new List<OutgoingChatItem>();

            using (var context = new DocumentationContext(Context, Configuration))
            {
                var getDocumentationidByKey = context.GetProjectIdByDocumentationKey(request.Phase);
                if(getDocumentationidByKey == 0)
                {
                    dynamic errorModel = new System.Dynamic.ExpandoObject();
                    errorModel.Error = "Not authorized exception, please check your API key!";
                    eResult.Add(errorModel);
                    return eResult;
                }

                result = GetNavigation(request, context);

                result.ForEach(x =>
                {
                    dynamic cResult = new System.Dynamic.ExpandoObject();
                    var vResult = new List<dynamic>();

                    cResult.CategoryName = x.NodeText;
                    cResult.ParentId = "";

                    x.NodeChild.ForEach(y =>
                    {
                        var bResult = new System.Dynamic.ExpandoObject();
                        var getPage = context.GetDocumentationPage(y.InternalId);
                        vResult.Add(bResult);
                    });
                    cResult.PageContents = vResult;
                    eResult.Add(cResult);
                });

            }
            return eResult;
        }


        [HttpPost]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> AddNewCategoryField([FromBody] IncomingIdRequest request)
        {
          
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.AddNewDocumentationCategoryField(request);
                result = GetNavigation(request, context);
            }
            return result;
        }

        [HttpPost]
 //        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> AddNewPage([FromBody] AssociatedDocumentationCategoryPage request)
        {
          
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.AddNewDocumentationpage(request);
            }
            return result;
        }
        [HttpPost]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> EditPage([FromBody] AssociatedDocumentationCategoryPage request)
        {
          
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.UpdateDocumentationPage(request);
            }
            return result;
        }

        private static List<OutgoingChatItem> GetNavigation(IncomingIdRequest request, DocumentationContext context)
        {
            return context.GetDocumentationNavigation(request.ProjectId);
        }
        [HttpPost]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> DeletePage([FromBody] IncomingIdRequest request)
        {
          
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.DeleteDocumentationPage(request.Id);
            }
            return result;
        }
        [HttpPost]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> DeleteCategoryField([FromBody] IncomingIdRequest request)
        {
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.DeleteCategoryField(request.Id);
            }
            return result;
        }
        [HttpPost]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public List<OutgoingChatItem> DeleteCategory([FromBody] IncomingIdRequest request)
        {
            var result = new  List<OutgoingChatItem>();
 
            using(var context = new DocumentationContext(Context, Configuration))
            {
                context.DeleteCategory(request.Id);
            }
            return result;
        }
        [HttpGet]
 //        [ValidateAntiForgeryToken]
        public IActionResult DocumentationPage(int id, int projectId) 
        {
            return ViewComponent("DocumentationPage", new IncomingIdRequest{
                Id = id,
                ProjectId = projectId
            });
         }
        [HttpGet]
        [Authorize (Roles = "ChatAdministrator")]
//        [ValidateAntiForgeryToken]
        public IActionResult GetPageModal(int id, int category, int projectId) 
        {
            return ViewComponent("DocumentationPageHandler", new IncomingIdRequest{
                 Id = id,
                 UserId = category,
                 ProjectId = projectId
            });
        }
        [HttpGet]
         public IActionResult GetBreadcrum(int id, int projectId) 
        {
            return ViewComponent("DocumentationBreadcrum", new IncomingIdRequest{
                Id = id,
                ProjectId = projectId
            });
         }

    }
}