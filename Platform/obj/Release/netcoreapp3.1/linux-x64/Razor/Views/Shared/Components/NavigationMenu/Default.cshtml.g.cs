#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b2e28004dc2b6bc2dd3aa5339a21a4dd0bb7cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavigationMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b2e28004dc2b6bc2dd3aa5339a21a4dd0bb7cb", @"/Views/Shared/Components/NavigationMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavigationMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"];
    var defaultIteration = ViewData["DefaultIteration"] as int?;
    var defaultDashboard = ViewData["DefaultDashboard"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"" style=""margin:0;"">
    <div>
        <ul id=""main-treeview"">
        </ul>
    </div>
</div>

<script>
      var URL = location.href.replace(location.search, '');
  //  document.getElementById('newTab').setAttribute('href', URL.split('#')[0] + 'sidebar/responsive-panel/index.html');
    data = [

        {
            nodeId: '01', nodeText: 'Dashboard', iconCss: 'icon-th icon',expanded: true,
            nodeChild: [
                { nodeId: '01-01', nodeText: 'Home', iconCss: 'icon-circle-thin icon', link:'/Dashboard/ProjectDashboard?id=");
#nullable restore
#line 23 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                       Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'01-02\', nodeText: \'Project Details\', iconCss: \'icon-circle-thin icon\', link:\'/Dashboard/ProjectDetails?projectId=");
#nullable restore
#line 24 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                       Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&dashboardId=");
#nullable restore
#line 24 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                                               Write(defaultDashboard);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },
            ]
        },
        {
            nodeId: '02', nodeText: 'Backlog', iconCss: 'icon-code icon',expanded: true,
            nodeChild: [
                { nodeId: '02-01', nodeText: 'Work Items', iconCss: 'icon-circle-thin icon', link: '/Backlogs/Index?projectId=");
#nullable restore
#line 30 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&boardId&&iteration=");
#nullable restore
#line 30 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                                        Write(defaultIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'02-02\', nodeText: \'Planning Boards\', iconCss: \'icon-circle-thin icon\', link: \'/Boards/Index?projectId=");
#nullable restore
#line 31 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                            Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'02-03\', nodeText: \'Backlog\', iconCss: \'icon-circle-thin icon\', link: \'/Boards/ProjectBacklog?projectId=");
#nullable restore
#line 32 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                             Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&workItemType=5&&iteration=");
#nullable restore
#line 32 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                                                   Write(defaultIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'02-04\', nodeText: \'Sprints\', iconCss: \'icon-circle-thin icon\', link: \'/Boards/Sprints?projectId=");
#nullable restore
#line 33 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                      Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&workItemType=7&&iteration=");
#nullable restore
#line 33 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                                            Write(defaultIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&person=0\' },\n                { nodeId: \'02-05\', nodeText: \'View Changelogs\', iconCss: \'icon-circle-thin icon\', link: \'/Changelog/ViewChangelogs?projectId=");
#nullable restore
#line 34 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'02-06\', nodeText: \'Queries\', iconCss: \'icon-circle-thin icon\', link: \'/Widget/Queries?projectId=");
#nullable restore
#line 35 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                      Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },

            ]
        },
         {
            nodeId: '03', nodeText: 'Administration', iconCss: 'icon-code icon',expanded: true,
            nodeChild: [
                { nodeId: '03-01', nodeText: 'Manage Accounts', iconCss: 'icon-circle-thin icon', link:'/Dashboard/ManageAccounts?id=");
#nullable restore
#line 42 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'03-02\', nodeText: \'Generate Changelog\', iconCss: \'icon-circle-thin icon\', link:\'/Dashboard/ChangelogGenerator?projectId=");
#nullable restore
#line 43 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                              Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'03-03\', nodeText: \'API Key Integations\', iconCss: \'icon-circle-thin icon\', link:\'/ApiKeySettings/ProjectApiKeys?projectId=");
#nullable restore
#line 44 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                                                Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' },\n                { nodeId: \'03-04\', nodeText: \'Documentation\', iconCss: \'icon-circle-thin icon\', link:\'/Documentation/Index?Id=");
#nullable restore
#line 45 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/NavigationMenu/Default.cshtml"
                                                                                                                         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' },

            ]
        },


    ];
    console.log(data);
    // TreeView  initialization
    var mainTreeView= new ej.navigations.TreeView({
        fields: 
        {
            dataSource: data,
            id: 'nodeId',
            text: 'nodeText',
            child: 'nodeChild'
        }
        ,nodeSelected: LinkSelected,
        expandOn: 'Click',
     });

    mainTreeView.appendTo('#main-treeview');

 
    function LinkSelected(args)
    {
");
            WriteLiteral("        data.forEach(element =>\n        {\n");
            WriteLiteral(@"            element.nodeChild.forEach(child =>
            {
               
                if(child.nodeId === args.nodeData.id)
                {
                    console.log(child.nodeId);
                    console.log(args.nodeData.id);
                    window.location.href = child.link;
                }
            });
        });

    // console.log(data.find(x => x.nodeChild.nodeId === args.nodeData.id));
    }

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
