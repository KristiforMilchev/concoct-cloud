namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    [ViewComponent(Name = "DocumentationNavigation")]
    public class DocumentationNavigationViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;
 
        public DocumentationNavigationViewComponent(RokonoControlContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }
        public IViewComponentResult Invoke(int id)
        {
            ViewData["ProjectId"] = id;

            using(var context = new UsersContext(Context,Configuration))
            {
                ViewData["UserRights"] = context.GetUserRights(UserId,id);
            }
            return View("/Views/Shared/Components/Documentation/DocumentationNavigation/Default.cshtml");
        }
    }
}