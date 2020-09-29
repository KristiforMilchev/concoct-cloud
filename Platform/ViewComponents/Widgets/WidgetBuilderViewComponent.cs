namespace Platform.ViewComponents.Widgets
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    [ViewComponent(Name = "WidgetBuilder")]
    public class WidgetBuilderViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public WidgetBuilderViewComponent(RokonoControlContext context, IConfiguration config)
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