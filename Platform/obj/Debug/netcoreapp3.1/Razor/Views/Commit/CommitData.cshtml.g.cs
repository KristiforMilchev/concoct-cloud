#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/CommitData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc58c1c4de040cbb2ebc4b5b1c39ab581233aa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commit_CommitData), @"mvc.1.0.view", @"/Views/Commit/CommitData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc58c1c4de040cbb2ebc4b5b1c39ab581233aa2", @"/Views/Commit/CommitData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Commit_CommitData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/dist/ej2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/CommitData.cshtml"
  
    ViewData["Title"] = "Commits";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var commitKey = ViewData["CommitKey"];
    var BranchId = ViewData["BranchId"];
    var ProjectId = ViewData["PrijectId"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0dc58c1c4de040cbb2ebc4b5b1c39ab581233aa24545", async() => {
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
        <!-- main-content declaration -->
   
<div class=""row"">
    <div class=""col-md-3"">
        <div class=""main-card mb-3 card"">
            <div class=""control-section"">
                <div class=""content-wrapper"">
                    <div id=""tree""style=""height:80vh; width:300px"" ></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-9"">
        <div id=""container"" style=""width:89vh;height:100%;border:1px solid grey""></div>
    </div>
</div>
 
 <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfS");
            WriteLiteral("DF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6\" crossorigin=\"anonymous\"></script>\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc58c1c4de040cbb2ebc4b5b1c39ab581233aa26832", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

 
<script>
var editor;
require.config({ paths: { 'vs': '/Syncfusion/node_modules/monaco-editor/min/vs' }});
	require(['vs/editor/editor.main'], function() {
	    editor = monaco.editor.create(document.getElementById('container'), {
			value: [
				 ""Console.WriteLine(\""Works\"")""
			].join('\n'),
			language: 'csharp'
		});
	});

    
    var BindingData ;
    $( document ).ready(function() 
    {
        $.ajax({
            type: 'GET',
            url: '/Commit/GetCommitFiles?commitId=");
#nullable restore
#line 51 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/CommitData.cshtml"
                                             Write(commitKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&projectId=");
#nullable restore
#line 51 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/CommitData.cshtml"
                                                                   Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                LoadCommitHirarchy(response);
            },
            error: function (xhr, status, error) {
    
            }
        });
     
    });

    function LoadCommitHirarchy(data)
    {
        BindingData = data;
        var treeObj = new ej.navigations.TreeView({
            fields: { dataSource: data, id: 'id', text: 'name', child: 'subChild', value: 1 },
            nodeSelected: ItemSelected
        });
        treeObj.appendTo('#tree');
            
    }
    
    function ItemSelected(args)
    {
        console.log(args.nodeData.id);
        BindingData.forEach(function(cData) {
            console.log(cData );
            if(cData.id === args.nodeData.id)
                ShowSelectedFile(cData);
            else
            {
                if(cData.subChild !== null)
                {
                    cData.");
            WriteLiteral(@"subChild.forEach(function(bData){
                        console.log(bData);
                        if(bData.id === args.nodeData.id)
                            ShowSelectedFile(bData);
                    });
                }
            }
        });
    }

    function ShowSelectedFile(file)
    {
        $(""#container"").html("""");
           $.ajax({
            type: 'GET',
            url: '/Commit/GetCommitFileData?fileId='+file.itemId+""&branch=");
#nullable restore
#line 102 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Commit/CommitData.cshtml"
                                                                     Write(BranchId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                editor = monaco.editor.create(document.getElementById('container'), {
                    value:  response.data,
                    language:  response.languageType
                });
             
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
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
