#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Survey/CreateNewSurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cbb5c9ac9a3a2983db1bad7713894ae2cdac5d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_CreateNewSurvey), @"mvc.1.0.view", @"/Views/Survey/CreateNewSurvey.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cbb5c9ac9a3a2983db1bad7713894ae2cdac5d2", @"/Views/Survey/CreateNewSurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_CreateNewSurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Survey/CreateNewSurvey.cshtml"
  
    ViewData["Title"] = "Survey Management Panel";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var ProjectId = ViewData["ProjectId"] as int?;
    var bindingComponents = ViewData["BuildingBlocks"] as List<SurveyComponent>; 
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <style>
    .ChipTag{
    background: red;
    border-radius: 15px;
    padding: 4px;
    color: white;
 }
 .ChipTag:hover{
    cursor: move;
    background: red;
    border-radius: 15px;
    padding: 4px;
    color: white;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
 }
 </style>


<div class=""row  card-layout"">
    <div class=""col-md-12"">
        <!-- Basic Card Layout  -->
        <div tabindex=""0"" class=""e-card"" id=""basic_card"" >
            <div class=""e-card-header"">

            </div>
            <div class=""e-card-content"">
                <div class=""row"" style=""margin-left:10%;margin-right:10%"">
");
#nullable restore
#line 35 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Survey/CreateNewSurvey.cshtml"
                     foreach (var component in bindingComponents)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"ChipTag\" draggable=\"true\" ondragstart=\"drag(event)\"");
            BeginWriteAttribute("id", "  id=\"", 1045, "\"", 1068, 2);
            WriteAttributeValue("", 1051, "Tag_", 1051, 4, true);
#nullable restore
#line 37 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Survey/CreateNewSurvey.cshtml"
WriteAttributeValue("", 1055, component.Id, 1055, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Survey/CreateNewSurvey.cshtml"
                                                                                                                Write(component.PlatformName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 38 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Survey/CreateNewSurvey.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>

        </div>
    </div>
</div>
<div class=""row card-layout"" style=""height: 80vh;"">
    <div class=""col-md-12"">
        <div tabindex=""1"" class=""e-card"" id=""basic_card"" style=""height: 80vh;"">
            <div class=""e-card-header"">

            </div>
            <div class=""e-card-content""  style=""height: 100%;margin-left:10%; margin-right:10%;""  ondrop=""drop(event)"" ondragover=""allowDrop(event)"">
                <div class=""row"">
                    <div class=""col-md-8"" id=""Content"">

                    </div>
                    <div class=""col-md-4"" id=""Settings"">
                        
                    </div>
                </div>
            </div>

        </div>
    </div>
</div>



<script>
var ActivePage = 1;
var draggableId;
function drag(ev)
{ 
    draggableId = ev.originalTarget.attributes.id;
} 

function drop(args)
{
    console.log(draggableId.nodeValue);

    $.get(""/Survey/GetProjectSurveyElement?element=""+draggableId.nodeValue,function(dat");
            WriteLiteral(@"a) {
        $(""#Content"").append(data);
    });

    $.get(""/Survey/GetProjectSurveyElementSetting?element=""+draggableId.nodeValue+"";""+ActivePage,function(data) {
        $(""#Settings"").html("""");
        $(""#Settings"").append(data);
    });
}
function allowDrop(args)
{
    args.preventDefault();
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
