using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Platform.DatabaseHandlers.Contexts;
using Platform.Models;
using Rokono_Control.Models;

namespace Platform.ViewComponents.Widgets
{
    [ViewComponent(Name = "BurdownChartSettings")]
    public class BurndownChartSettingsViewComponent : ViewComponent
    {
        private readonly RokonocontrolContext Context;
        private readonly IConfiguration Configuration;

        public BurndownChartSettingsViewComponent(RokonocontrolContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(IncomingIdRequest request)
        {
            ViewData["ProjectId"] = request.ProjectId;
            ViewData["ViewComponentId"] = request.Id;
            ViewData["Dashboard"] = request.WorkItemType;
            using (var context = new UsersContext(Context, Configuration))
            {
                ViewData["Teams"] = context.GetPojectTeams(request.ProjectId);
            }
            using (var context = new WorkItemsContext(Context, Configuration))
                ViewData["WorkItemTypes"] = context.GetAllWorkItemTypes();

            ViewData["CountWItems"] = new List<OutgoingBindingCollection> { new OutgoingBindingCollection { Id = 1, Name = "Work Item Type" } };
            ViewData["BurndownOn"] = GetBundownOn();
            ViewData["SumWItems"] = GetSumWItems();
            ViewData["Backlog"] = GetBacklogTypes();
            return View("/Views/Shared/Components/Widgets/BurndownChartSettings/Default.cshtml");
        }

        private  List<OutgoingBindingCollection> GetBacklogTypes()
        {
            return new List<OutgoingBindingCollection>{
                new OutgoingBindingCollection{
                    Id = 1,
                    Name = "Stories"
                },
                new OutgoingBindingCollection{
                    Id = 2,
                    Name = "Features"
                },
                new OutgoingBindingCollection{
                    Id = 3,
                    Name = "Epics"
                }
            };
        }

        private List<OutgoingBindingCollection> GetSumWItems()
        {
            return new List<OutgoingBindingCollection>{
                new OutgoingBindingCollection{
                    Id= 1,
                    Name = "Priority"
                },
                new OutgoingBindingCollection{
                    Id = 2,
                    Name = "Stack Rank"
                },
                new OutgoingBindingCollection{
                    Id = 3,
                    Name = "Story Points"
                }
            };
        }

        private static List<OutgoingBindingCollection> GetBundownOn()
        {
            return new List<OutgoingBindingCollection>{ 
                new OutgoingBindingCollection{
                    Id = 1,
                    Name = "Count"
                },
                new OutgoingBindingCollection{
                    Id= 2,
                    Name = "Sum"
                }
            };
        }
    }
}