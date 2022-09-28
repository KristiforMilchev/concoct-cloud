namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Platform.DatabaseHandlers.Contexts;
    using Rokono_Control.Models;

    public class ViewChangelogViewComponent : ViewComponent
    {
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;

        public ViewChangelogViewComponent(DatabaseContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(int changeLogId)
        {
            using(var context = new ChangelogContext(Context,Configuration))
                ViewData["ChangelogDetails"] = context.GetSpecificChangelog(changeLogId);
            return View();
        }
    }
}