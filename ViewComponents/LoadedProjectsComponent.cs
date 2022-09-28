namespace Platform.ViewComponents
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Platform.DatabaseHandlers.Contexts;
    using Platform.DataHandlers;
    using Platform.DataHandlers.Interfaces;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;

    public class LoadedProjectsViewComponent : ViewComponent
    {
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;
 
        public LoadedProjectsViewComponent(DatabaseContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }

        public IViewComponentResult Invoke(int projectId)
        {
              var projects = new List<Projects>();
             using(var context = new UsersContext(Context,Configuration))
                projects =  context.GetUserProjects(UserId);
            using(var context = new DatabaseController(Context,Configuration))
            {
                var current = projects.FirstOrDefault(x=>x.Id == projectId);
                ViewData["Projects"] = projects;
                ViewData["SelectedIndex"] = projects.IndexOf(current);
     
            }
           
            return View();
        }
    }
}