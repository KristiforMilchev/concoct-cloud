namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;
    [ViewComponent(Name = "PublicDisscussionBoard")]

    public class PublicDisscussionBoardViewComponent : ViewComponent
    {
        private readonly RokonocontrolContext Context;
        private readonly IConfiguration Configuration;

        public PublicDisscussionBoardViewComponent(RokonocontrolContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(int projectId)
        {
            
            using(var context = new DatabaseController(Context,Configuration))
            {
                
            }
            ViewData["ProjectId"] = projectId;
            return View("/Views/Shared/Components/OutboundComponents/PublicDisscussionBoard/Default.cshtml");
        }
    }
}