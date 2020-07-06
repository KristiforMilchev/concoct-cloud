#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8aa255dac110245c50af31e3b1bc16a0ec7ca65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backlogs_Index), @"mvc.1.0.view", @"/Views/Backlogs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8aa255dac110245c50af31e3b1bc16a0ec7ca65", @"/Views/Backlogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Backlogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\n");
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
  
    ViewData["Title"] = "Backlog";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["ProjectId"] as int?;
    var BoardId = ViewData["BoardId"] as int?;
    var CurrentIteration = ViewData["Iteration"] as int?;
    var Phase  = ViewData["Phase"] as string;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<link href=\"https://cdn.quilljs.com/1.3.6/quill.snow.css\" rel=\"stylesheet\">\n\n<!-- Main Quill library -->\n<script src=\"//cdn.quilljs.com/1.3.6/quill.js\"></script>\n<script src=\"//cdn.quilljs.com/1.3.6/quill.min.js\"></script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8aa255dac110245c50af31e3b1bc16a0ec7ca654914", async() => {
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

<style>
    #main-text{
        height: 90vh;
    }
    .fa-bug:before{
        font-family: ""e-icons"" !important;
        content: '\e191';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-cog:before{
        font-family: ""e-icons"" !important;
        content: '\e679';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-tasks:before{
        font-family: ""e-icons"" !important;
        content: '\e728';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-vial:before{
        font-family: ""e-icons"" !important;
        content: '\e664';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-crown:before{
        font-family: ""e-icons"" !important;
        content: '\e824';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-exclamation-triangle:before{
        font-family: ""e-icons"" !important;
        content: '\e74c';
        color: #1f818c;
        width: 30px;
    ");
            WriteLiteral(@"    height: 30px;
    }
    .fa-user-circle:before{
        font-family: ""e-icons"" !important;
        content: '\e193';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }

</style>


<!-- end of sidebar element -->
<!-- main-content declaration -->
 
        <div id=""spinner"">
            <div id=""loader""></div>
        </div>
        <div id=""Content"" hidden>
            <div class=""row"" style=""margin:0px;"">
                <div class=""col-md-12"">
                    <div class=""main-card mb-3 card"">
                        <div class=""card-body"">
                            <h5 class=""card-title text-center"">Select a project</h5>
                            <div class=""row"" style=""margin-left:10px;"">

                                <div class=""btn-group dropdown-split-primary"">
                                    <button type=""button"" id=""iconbtn"" class=""btn btn-primary"">New Work Item</button>




                                    <button id=""QueryBtn"">Open In Query</button>
      ");
            WriteLiteral(@"                              <button id=""ImportWorkItemBtn"" onclick=""ImportNewWorkItems()""></i>Import Work Items</button>
                                    <button id=""ExportWorkItemBtn"">Export Work Items</button>
                                    <button Id=""RecycleBtn"" onclick=""DeleteWorkItems()"">Recycle Work Items</button>
                                     ");
#nullable restore
#line 99 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
                                Write(await Component.InvokeAsync("IterationDropdown", new IncomingIdRequest{
                                        ProjectId = @result.Value,
                                        Id = @CurrentIteration.Value,
                                        Phase = "Backlogs/Index"
                                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                                </div>
                                <div class=""control-section"" style=""height:97vh;"">
                                    <div class=""content-wrapper"">
                                        <div id=""TreeGrid""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

             <div id=""exportDialog"">
                <div class=""row"">
                    <button id=""importWorkItemsBtn"" style=""width: 100%;"" onclick=""ImportItems()"">Import Items</button>
                </div>
                <div class=""row"" style=""padding:2%;"">
                    <div class=""position-relative form-group"" style=""width:100%;height:300px;"" ><label for=""exportContent""");
            BeginWriteAttribute("class", "  class=\"", 4181, "\"", 4190, 0);
            EndWriteAttribute();
            WriteLiteral(@">Manual Creation Script</label><div name=""exportContent"" id=""exportContent""  style=""max-height: 400px;""  class=""form-control""></div></div>
                </div>
                
            </div>
 
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8aa255dac110245c50af31e3b1bc16a0ec7ca6510845", async() => {
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
    <script type=""text/x-jsrender"" id=""empTemplate"">
        <div>
            <div class=""empimg"">
                <span class=""e-userimg"">
                </span>
            </div>
            <span id=""Emptext"">${Employees}</span>
        </div>
    </script>

    <script>

    var exportDialog;
    var exportContent;

    var selectedRows = [];
    var ProjectId = ");
#nullable restore
#line 149 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
               Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    var  boardId = ");
#nullable restore
#line 150 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
              Write(BoardId);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    function OpenWorkItem(id)\n    {\n        console.log(id);\n    }\n    $( document ).ready(function()\n    {\n         exportContent = new Quill(\'#exportContent\', {\n            theme: \'snow\',\n            height: \'300px\'\n        });\n        var id = ");
#nullable restore
#line 161 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
            Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n        var dto = {\n            \"id\": id,\n            \"WorkItemType\":0,\n            \"Phase\" : \"");
#nullable restore
#line 166 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
                  Write(Phase);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n            \"ProjectId\" : ");
#nullable restore
#line 167 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
                     Write(CurrentIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Backlogs/GetWorkItems',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                InitiliazeGrid(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
        exportDialog = new ej.popups.Dialog({
            width: '600px',
            header: 'Project Backup',
            isModal: true,
            animationSettings: { effect: 'None' },
            visible: false,
            open: ExportDialogOpen,
            close: ExportDialogClose
        });
        exportDialog.appendTo('#exportDialog');
        exportDialog.hide();

    });
    function ExportDialogOpen()
    {
        document.getElementById('exportDialog').style.display = 'block';
    }
    function ExportDialogClose()
    {
        docume");
            WriteLiteral(@"nt.getElementById('exportDialog').style.display = 'none';

    }
    ej.base.enableRipple(true);
    var queryBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    queryBtn.appendTo('#QueryBtn');
    var importWorkItemBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    importWorkItemBtn.appendTo('#ImportWorkItemBtn');
    var exportWorkItemBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    exportWorkItemBtn.appendTo('#ExportWorkItemBtn');
    var recycleBtn = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
    recycleBtn.appendTo('#RecycleBtn');

    // DropDownButton items declaration
    var items = [
        {
            text: 'Epic',
            iconCss: 'e-icons e-epic',

            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+5+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href
        },
        {
            text: 'Feature',
            iconCss: 'e-icons e-Feature',

 ");
            WriteLiteral(@"           url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+2+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href
        },
        {
            text: 'User Story',
            iconCss: 'e-icons e-Story',
             url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+7+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href

        },
        {
            text: 'Task',
            iconCss: 'e-icons e-Task',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+3+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href

        },
        {
            text: 'Bug',
            iconCss: 'e-icons e-Bug',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+1+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href
        },
        {
            text: 'Issue',
            iconCss: 'e-icons e-Issue',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&work");
            WriteLiteral(@"ItemType=""+6+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href

        },
        {
            text: 'Test',
            iconCss: 'e-icons e-Test',
            url:""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+4+""&boardId=""+boardId+""&parentId=0&returnUrl=""+window.location.href
         }

        ];

    var btnObj = new ej.splitbuttons.DropDownButton({ items: items, iconCss: 'e-ddb-icons e-profile',cssClass: 'e-outline', select:WorkItemListClicked });
    btnObj.appendTo('#iconbtn');

    function WorkItemListClicked(args)
    {
        console.log(args);
        var url = args.properties.url;
        window.location.href = url;
       // console.log(args);
    }

    function InitiliazeGrid(data )
    {
        console.log(data);


        var treeGridObj = new ej.treegrid.TreeGrid({
            dataSource: data,
            allowSelection: true,
            allowFiltering: true,
            allowSorting: true,
            toolbar: ['Search'],
            recordDoubleCl");
            WriteLiteral(@"ick: EditWorkItem,
            rowSelected: RowSelected,
            rowDeselected: RowDeselected,
            enableVirtualization: true,
            filterSettings: { type: 'Menu' },
            queryCellInfo: customiseCell,
            selectionSettings: { persistSelection: true, type: ""Multiple"" },
            enableHover: false,
            allowPaging: true,
            pageSettings: { pageSize: 20 },
            height:'650px',
            columns: [
                { type: ""checkbox"", field: """", allowFiltering: false, allowSorting: false, width: '20' , textAlign: 'center'},
                { field: 'workItemType.TypeName', headerText: 'Type', width: '10',customAttributes: {class: ""workItemIcon""}, textAlign: 'center' },
                { field: 'title', headerText: 'Title', width: 125 },
                { field: 'description', headerText: 'Description', width: 180 },
                { field: 'assignedTo', headerText: 'AssignedTo', width: 110 },
            ]
        });

        treeGridObj.appendTo('#");
            WriteLiteral(@"TreeGrid');
        ShowContent();


    }

    function customiseCell(args) {
        console.log(args);
        if (args.column.headerText === 'Type' ){
            args.cell.setAttribute('class', args.data.workItemIcon);
        } 
    }
    
    function CreateNewWorkItem(id){
        ProjectId = ");
#nullable restore
#line 316 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
               Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n        boardId = ");
#nullable restore
#line 317 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
             Write(BoardId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+id+""&boardId=""+boardId+""&returnUrl=""+window.location.href;
    }
    function WorkItemSelected(args){
        console.log(args);
    }

    function EditWorkItem(args)
    {
        console.log(args);
        window.location.href = ""/Dashboard/EditWorkItem?projectId=");
#nullable restore
#line 327 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Backlogs/Index.cshtml"
                                                             Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&&workItem=""+args.rowData.id+""&returnUrl=""+window.location.href;
    }
    function load(args) {
        this.parentDetails.parentKeyFieldValue = this.parentDetails.parentRowData['id'];
    }
    function RowSelected(args)
    {
        console.log(args);
        selectedRows.push(args.data);
    }

    function RowDeselected(args)
    {
        console.log(args.data);
        var index = selectedRows.indexOf(args.data[0]);
        if (index > -1) {
            selectedRows.splice(index, 1);
        }
        console.log(selectedRows);

    }
    function DeleteWorkItems()
    {
        console.log(selectedRows);
        var incomingSprintDTO =
        {
            ""Items"":  selectedRows
        }



        $.ajax({
            type: 'POST',
            url: '/Backlogs/ItemsRemoved',
            data: JSON.stringify(incomingSprintDTO),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function(response) {
               window.location.href = wind");
            WriteLiteral(@"ow.location;
            },
            error: function(xhr, status, error) {
                console.log(error);
            }
        });
    }

    function ImportNewWorkItems()
    {
        exportDialog.show();
    }

    function ImportItems()
    {
        var incomingSprintDTO =
        {
            ""Data"":  $(""#exportContent"").children()[0].innerHTML
        }

        $.ajax({
            type: 'POST',
            url: '/Boards/ImportWorkItems',
            data: JSON.stringify(incomingSprintDTO),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function(response) {
        //       window.location.href = window.location;
            },
            error: function(xhr, status, error) {
                console.log(error);
            }
        });
    }
    </script>


");
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
