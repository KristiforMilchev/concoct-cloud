
namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;

    public class RelateWorkItemViewComponent : ViewComponent
    {
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;

        public RelateWorkItemViewComponent(DatabaseContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(IncomingIdRequest ids)
        {
            ViewData["WorkItemId"] = ids.Id;
            ViewData["ProjectsId"] = ids.WorkItemType;
            return View();
        }
    }
}