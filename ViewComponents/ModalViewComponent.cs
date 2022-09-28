namespace Platform.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    public class ModalViewComponent : ViewComponent
    {
        private readonly DatabaseContext Context;
        private readonly IConfiguration Configuration;

        public ModalViewComponent(DatabaseContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(string childName)
        { 
            ViewData["RendeingComponent"] = childName;
            return View();
        }
    }
}