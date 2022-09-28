
namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    
    public class ModuleDisabledWarningViewComponent : ViewComponent 
    {
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;

        public ModuleDisabledWarningViewComponent(DatabaseContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(int projectId)
        { 
            
            return View();
        }
    }
}