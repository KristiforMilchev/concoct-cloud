
namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Platform.DataHandlers;
    using Platform.DataHandlers.Interfaces;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;

    public class NotificationPanelViewComponent : ViewComponent
    {
        
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;
 
        public NotificationPanelViewComponent(DatabaseContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }
        public IViewComponentResult Invoke(int projectId)
        {
            using(var context = new DatabaseController(Context,Configuration))
            {
                ViewData["UserId"] = UserId;
            }
            return View();
        }
        
    }
}