namespace Platform.ViewComponents.Widgets
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;

    [ViewComponent(Name = "WidgetBuilder")]
    public class WidgetBuilderViewComponent : ViewComponent
    {
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;

        public WidgetBuilderViewComponent(DatabaseContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(IncomingIdRequest request)
        {
            ViewData["ProjectId"] = request.ProjectId;
            ViewData["DashboardId"] = request.Id;
            ViewData["ContainerId"] = request.WorkItemType;
         
            return View("/Views/Shared/Components/Widgets/WidgetBuilder/Default.cshtml");
        }
    }
}