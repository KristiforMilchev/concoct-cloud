#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7df9bb18b2433d234f44bc7434b0cdec01cb4a9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ProjectDetails), @"mvc.1.0.view", @"/Views/Dashboard/ProjectDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7df9bb18b2433d234f44bc7434b0cdec01cb4a9d", @"/Views/Dashboard/ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ProjectDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var UserDashboard  =  ViewData["SavedWidgets"] as UserDashboards;
    var ProjectId = ViewData["ProjectId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7df9bb18b2433d234f44bc7434b0cdec01cb4a9d4221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  <!-- end of sidebar element -->
  
<div class=""control-section"">
    <div style=""padding:5px;text-align: right;"">
        <button   class=""btn btn-primary e-control e-btn e-lib e-outline e-primary""  onclick=""OpenWidgetModal()"" >Add Widget</button>
    </div>
    
    <div id=""defaultLayout"">
");
#nullable restore
#line 16 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
         if(@UserDashboard != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
             if(@UserDashboard.UserDashboardItem != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                 foreach (var widget in @UserDashboard.UserDashboardItem)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("id", " id=\"", 774, "\"", 795, 1);
#nullable restore
#line 22 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
WriteAttributeValue("", 779, widget.ItemName, 779, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"e-panel\" data-row=\"");
#nullable restore
#line 22 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                                                    Write(widget.DataRow);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-col=\"");
#nullable restore
#line 22 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                                                                               Write(widget.DataCol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sizeX=\"");
#nullable restore
#line 22 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                                                                                                            Write(widget.DataSizeX);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-sizeY=\"");
#nullable restore
#line 22 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                                                                                                                                           Write(widget.DataSizeY);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                        <span id=\"close\" class=\"e-template-icon e-clear-icon\"></span>\n                        <div class=\"e-panel-container\">\n                            if(");
#nullable restore
#line 25 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                          Write(widget.AssociatedUserDashboardItemComponent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" != null)\n                            {\n");
#nullable restore
#line 27 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                 foreach (var widgetBuildingBlock in @widget.AssociatedUserDashboardItemComponent)
                                {
                                    if(@widgetBuildingBlock.ItemComponentNavigation.ColumnNumber  != default(int))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div");
            BeginWriteAttribute("class", " class=\"", 1533, "\"", 1605, 2);
            WriteAttributeValue("", 1541, "col-md-", 1541, 7, true);
#nullable restore
#line 31 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
WriteAttributeValue("", 1548, widgetBuildingBlock.ItemComponentNavigation.ColumnNumber, 1548, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        \n                                            if(");
#nullable restore
#line 33 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                          Write(widgetBuildingBlock.ItemComponentNavigation.IsRow.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == 1)\n                                            {\n                                                <div class=\"row\">\n                                                    ");
#nullable restore
#line 36 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                               Write(await Component.InvokeAsync("@widgetBuildingBlock.ComponentName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                </div>\n                                            }\n                                            else\n                                            {\n                                                ");
#nullable restore
#line 41 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                           Write(await Component.InvokeAsync("@widgetBuildingBlock.ComponentName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            }\n                                        </div>\n");
#nullable restore
#line 44 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            }\n                        </div>\n                    </div>   \n");
#nullable restore
#line 49 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
    </div>
    <div id=""headerTemplate"">
        <span id=""close"" class=""e-template-icon e-clear-icon""></span>
    </div>
    <div id=""content""></div>
</div>
<div id=""action-description"">
    <p>
        The following sample demonstrates the default functionalities of the DashboardLayout component. Click the <code>Add Panel</code> button to add panels dynamically to the dashboard layout.
    </p>
</div>

<div id=""description"">
    <p>
        The DashboardLayout component provides the capability to arrange, <a href=""https://ej2.syncfusion.com/javascript/documentation/api/dashboard-layout#allowresizing"" target=""_blank"">resize</a> and 
        reorder the panels within the dashboard layout.
    </p>

</div>

   <div id=""dialogIterations"" style=""margin-left: 70%;"">
        <div id=""ModalContent"">
            
        </div>
        <div  class=""row"">
            <div id=""Rowbtn"">
                <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 100%;"" onclick=""CloseModal(");
            WriteLiteral(@")"">Cancel</button>
            </div>
            <div id=""Rowbtns"" style=""display: ruby;"">
                <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""SaveNewIterationSettings()"">Confirm</button>
                <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""CloseModal()"">Cancel</button>

            </div>
        </div>

    </div>

<style>
    #defaultLayout {
        padding: 10px;
    }
    
    .e-dashboardlayout.e-control .e-panel:hover span {
        display: block;
    }
    
    #defaultLayout .e-panel .e-panel-container .text-align {
        vertical-align: middle;
        font-weight: 600;
        font-size: 20px;
        text-align: center;
    }
    
    .e-template-icon {
        padding: 10px;
        float: right;
        display: none;
    }
    
    .e-clear-icon::before {
        content: '\e100';
        font-size: 12px;
        font-family: 'ej-icon';
    }

    ");
            WriteLiteral(@"@font-face {
        font-family: 'ej-icon';
        src:
        url(data:application/x-font-ttf;charset=utf-8;base64,AAEAAAAKAIAAAwAgT1MvMjdtQ/IAAAEoAAAAVmNtYXDhEOFVAAABiAAAADZnbHlmq8jV4gAAAcgAAAFQaGVhZBSREIsAAADQAAAANmhoZWEIUAQDAAAArAAAACRobXR4CAAAAAAAAYAAAAAIbG9jYQCoAAAAAAHAAAAABm1heHABDQCUAAABCAAAACBuYW1lWD3y/QAAAxgAAAIlcG9zdMl9cHoAAAVAAAAALwABAAAEAAAAAFwEAAAAAAAD8wABAAAAAAAAAAAAAAAAAAAAAgABAAAAAQAAjGeuW18PPPUACwQAAAAAANi/5c0AAAAA2L/lzQAAAAAD8wP0AAAACAACAAAAAAAAAAEAAAACAIgAAQAAAAAAAgAAAAoACgAAAP8AAAAAAAAAAQQAAZAABQAAAokCzAAAAI8CiQLMAAAB6wAyAQgAAAIABQMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAUGZFZABA4QDhAAQAAAAAXAQAAAAAAAABAAAAAAAABAAAAAQAAAAAAAACAAAAAwAAABQAAwABAAAAFAAEACIAAAAEAAQAAQAA4QD//wAA4QD//wAAAAEABAAAAAEAAAAAAAAAqAAAAAEAAAAAA/MD9ACHAAAJAi8GKwEPDR0BHwYJAQ8GHQEfDTsBPwYJAR8GOwE/Di8HCQE/Bj0BLw0rAQ8FA3T+jP6MBQYHBgcHCAcHBwcHBwYGBgUFAwMDAgEBAgMDAwUFAXT+jAUFAwMDAgEBAgMDAwUFBgYGBwcHBwcHBwgGBwYHBQF0AXQFBgcGBwcIBwcHBwcHBgYGBQQEAwMBAQEBAQEDAwQEBf6MAXQFBQMDAwIBAQIDAwMFBQYGBgcHBwcHBwgHBwYHBgPe/owBdAUFAwMDAgEBAgMDAwUFBgYGB");
            WriteLiteral(@"wcHBwcHCAcGBwYHBf6M/owFBwYHBgcIBwcHBwcHBgYGBQUDBAICAQECAgQDBQUBdP6MBQUDBAICAQECAgQDBQUGBgYHBwcHBwcIBwYHBgcFAXQBdAYGBgcHBwcHBwcHBwcGBgYFBQMEAgIBAQIDAwMFAAAAEgDeAAEAAAAAAAAAAQAAAAEAAAAAAAEABwABAAEAAAAAAAIABwAIAAEAAAAAAAMABwAPAAEAAAAAAAQABwAWAAEAAAAAAAUACwAdAAEAAAAAAAYABwAoAAEAAAAAAAoALAAvAAEAAAAAAAsAEgBbAAMAAQQJAAAAAgBtAAMAAQQJAAEADgBvAAMAAQQJAAIADgB9AAMAAQQJAAMADgCLAAMAAQQJAAQADgCZAAMAAQQJAAUAFgCnAAMAAQQJAAYADgC9AAMAAQQJAAoAWADLAAMAAQQJAAsAJAEjIGVqLWljb25SZWd1bGFyZWotaWNvbmVqLWljb25WZXJzaW9uIDEuMGVqLWljb25Gb250IGdlbmVyYXRlZCB1c2luZyBTeW5jZnVzaW9uIE1ldHJvIFN0dWRpb3d3dy5zeW5jZnVzaW9uLmNvbQAgAGUAagAtAGkAYwBvAG4AUgBlAGcAdQBsAGEAcgBlAGoALQBpAGMAbwBuAGUAagAtAGkAYwBvAG4AVgBlAHIAcwBpAG8AbgAgADEALgAwAGUAagAtAGkAYwBvAG4ARgBvAG4AdAAgAGcAZQBuAGUAcgBhAHQAZQBkACAAdQBzAGkAbgBnACAAUwB5AG4AYwBmAHUAcwBpAG8AbgAgAE0AZQB0AHIAbwAgAFMAdAB1AGQAaQBvAHcAdwB3AC4AcwB5AG4AYwBmAHUAcwBpAG8AbgAuAGMAbwBtAAAAAAIAAAAAAAAACgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgECAQMABWNsb3NlAAAA) format('truetype');
        font-weight: normal;
        font-style: no");
            WriteLiteral(@"rmal;
    }
    
    .text-align {
        line-height: 160px;
    }
    
    .e-clear-icon {
        position: absolute;
        right: 0;
        cursor: pointer;
    }
    
    .sb-demo-section .container-fluid {
        background: #E5E5E5;
    }
</style>

<script>
$(""#Rowbtns"").hide();
  var dialogIterations = new ej.popups.Dialog({
                width: '30vh',
                header: 'Pick  your widget',
                isModal: true,
                animationSettings: { effect: 'None' },
                visible: false,
                open: dialogOpen,
                close: dialogClose
            });
        dialogIterations.appendTo('#dialogIterations');

 var dashboard = new ej.layouts.DashboardLayout({
        cellSpacing: [10, 10],
        columns: 5,
        allowResizing: true,
    });
dashboard.appendTo('#defaultLayout');
var dashboardObject = document.getElementById('defaultLayout').ej2_instances[0];
var count = 8;

function AddNewDashboardPanel(generatedId)
{
    var panel = [{
        'id");
            WriteLiteral(@"': count.toString() + '_layout', 'sizeX': 1, 'sizeY': 1, 'row': 0, 'col': 0,
        content: '<span id=""close"" class=""e-template-icon e-clear-icon""></span><div class=""text-align"">' + count.toString() + '</div>'
    }];
    dashboardObject.addPanel(panel[0]);
    var closeIcon = document.getElementById(count.toString() + '_layout').querySelector('.e-clear-icon');
    closeIcon.addEventListener('click', onCloseIconHandler);
    count = count + 1;
}

function onCloseIconHandler(event) {
    if (event.target.offsetParent) {
        dashboardObject.removePanel(event.target.offsetParent.id);
    }

}
var closeElement = document.querySelectorAll('.e-clear-icon');
for (var i = 0; i < closeElement.length; i++) {
    closeElement[i].addEventListener('click', onCloseIconHandler);
}



    function dialogOpen()
    {
        document.getElementById('dialogIterations').style.display = 'block';
    }

    function dialogClose()
    {
        document.getElementById('dialogIterations').style.display = 'none';
    }

    fu");
            WriteLiteral(@"nction CloseModal()
    {
        $(""#Rowbtns"").hide();
        $(""#Rowbtn"").show();
        dialogIterations.hide();
    }

    function OpenWidgetModal()
    {
        dialogIterations.show();
        $(""#ModalContent"").load(""/Accounts/GetWidgets?projectId=");
#nullable restore
#line 208 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
                                                           Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n    }\n\n</script>");
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
