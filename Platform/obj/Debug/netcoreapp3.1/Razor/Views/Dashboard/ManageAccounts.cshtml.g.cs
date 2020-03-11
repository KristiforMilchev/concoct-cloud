#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ManageAccounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b9dd9715277ede8176d6fd4cc10cf4bb759912f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ManageAccounts), @"mvc.1.0.view", @"/Views/Dashboard/ManageAccounts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b9dd9715277ede8176d6fd4cc10cf4bb759912f", @"/Views/Dashboard/ManageAccounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ManageAccounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ManageAccounts.cshtml"
  
    ViewData["Title"] = "New Work Item";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["UserAccounts"] as List<UserAccounts>;
    var ProjectId = ViewData["ProjectId"] as int?;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://cdn.syncfusion.com/ej2/ej2-base/styles/material.css"" rel=""stylesheet"" type=""text/css"" />
<link href=""https://cdn.syncfusion.com/ej2/ej2-layouts/styles/material.css"" rel=""stylesheet"" type=""text/css"" />
 
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body text-center"">
                    <div class=""row"">
                        <h3>User Account Managment</h3>
                    </div>
                    <div class=""row"">
                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 804, "\"", 877, 3);
            WriteAttributeValue("", 814, "CallUrl(\'/Accounts/ManageProjectMemebers?projectId=", 814, 51, true);
#nullable restore
#line 20 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ManageAccounts.cshtml"
WriteAttributeValue("", 865, ProjectId, 865, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 875, "\')", 875, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""AddNewMember"" style=""width: 100%;"" ><span class=""glyphicon glyphicon-file""></span> Add New User</button>
                    </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""control-section"">
                <div class=""content-wrapper"">
                    <div id=""Grid""></div>        
                </div>
            </div>
        </div>
 
<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>

 <script>
    $( document ).ready(function() 
    {
        var AddNewMember = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        AddNewMember.appendTo('#AddNewMember');
        $.ajax({
            type: 'GET',
            url: '/Authenication/GetManagmentUsers?projectId=");
#nullable restore
#line 43 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ManageAccounts.cshtml"
                                                        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                LoadAccounts(response);
            },
            error: function (xhr, status, error) {
    
            }
        });
        
    });

    function LoadAccounts(data){
        var grid = new ej.grids.Grid({
            dataSource: data,
            editSettings: { allowEditing: true, allowAdding: true, allowDeleting: true, allowEditOnDblClick: false },
            beginEdit : EditClicked,
            actionBegin: ActionComplete,
             columns: [
                { field: 'name', headerText: 'Name', width: 120, textAlign: 'Right' },
                { field: 'email', headerText: 'Email', width: 150 },
                { field: 'type', headerText: 'Account Type', width: 130, format: 'yMd', textAlign: 'Right' },
                { field: 'createdAt', headerText: 'Created At', width: 130, format: 'yMd', textAlign: 'Right' },
                { headerText: 'M");
            WriteLiteral(@"anage Records', width: 160,
                commands: 
                    [
                        { type: 'Edit', buttonOption: { iconCss: ' e-icons e-edit', cssClass: 'e-flat' }, click: EditClicked },
                        { type: 'Delete', buttonOption: { iconCss: 'e-icons e-delete', cssClass: 'e-flat' }, click: DeleteClicked },
   
                    ]
                }
            ]
        });
        grid.appendTo('#Grid');
    }
    function EditClicked(args){
        console.log(args);
        window.location.href=""/Dashboard/EditAccount?id=""+args.rowData.accountId+""&&projectId=""+");
#nullable restore
#line 81 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ManageAccounts.cshtml"
                                                                                           Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    }\n    function ActionComplete(args){\n        console.log(args);\n        if(args.requestType == \"delete\")\n        {\n            var dto = {\n                \"AccountId\" : args.data[0].accountId,\n                \"ProjectId\" : ");
#nullable restore
#line 89 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ManageAccounts.cshtml"
                         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            }
            $.ajax({
            type: 'POST',
                url: '/Accounts/DeleteProjectAccount',
                data: JSON.stringify(dto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    alert(""Records have been added!"");
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
            });
        }
    }

    function DeleteClicked()
    {
        
    }

    function CallUrl(url)
    {
        window.location.href=url;
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
