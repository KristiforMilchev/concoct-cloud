#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72d331dd5b4143fbc4ec54800b2fdae6e2788763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_GetUserProfile), @"mvc.1.0.view", @"/Views/Accounts/GetUserProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d331dd5b4143fbc4ec54800b2fdae6e2788763", @"/Views/Accounts/GetUserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_GetUserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
  
    ViewData["Title"] = "User Account Settings";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var projectId = ViewData["ProjectId"] as int?;
    var UserRights = ViewData["UserRights"] as UserRights;
    var UserData = ViewData["UserData"] as UserAccounts;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
      .e-upload {
        width: 100%;
        position: relative;
        margin-top: 15px;
        float: none;
    }
    .e-upload .e-upload-actions {
        float: none;
        text-align: right;
    }
    .control_wrapper .e-upload .e-upload-drag-hover {
        margin: 0;
    }
    .row{
        padding: 1%;
    }
</style>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""row"">
             <img id=""UserImage"" src=""https://softsmart.co.za/wp-content/uploads/2018/06/image-not-found-1038x576.jpg"" style=""width:100%; height: 400px;""/>           
        </div>
        <div class=""row"">
            <div class=""control_wrapper"">
                <input type='file' id='fileupload' name='UploadFiles'/>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                    <input id=""userFName"" />
            </div>
            <div class=""col-md-6"">
                    <input id=""userLName"" />
            </div>
        </div>
          <div c");
            WriteLiteral(@"lass=""row"">
            <div class=""col-md-6"">
                    <input id=""userFGit"" />
            </div>
            <div class=""col-md-6"">
                    <input id=""userFEmail"" />
            </div>
        </div>
      
        <div class=""row"">
            <div class=""col-md-4"">
                <input id=""userFOldPass"" />
            </div>
            <div class=""col-md-4"">
                <input id=""userNewPass"" />
            </div>
            <div class=""col-md-4"">
                <input id=""userConfirm"" />
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""row"" style=""text-align: center;"">
            <h3>User Rights</h3>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                ");
#nullable restore
#line 73 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle", new IncomingIdRequest{
                    Id = @UserRights.ChatChannelsRule,
                    Phase = "ChatChannelsRule",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 81 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",  new IncomingIdRequest{
                    Id = @UserRights.Documentation.Value,
                    Phase = "Documentation",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 91 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle", new IncomingIdRequest{
                    Id = @UserRights.ManageIterations,
                    Phase = "ManageIterations",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 99 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle", new IncomingIdRequest{
                    Id = @UserRights.ManageUserdays,
                    Phase = "ManageUserdays",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 109 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.UpdateUserRights,
                    Phase = "UpdateUserRights",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 117 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.ViewOtherPeoplesWork,
                    Phase = "ViewOtherPeoplesWork",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 127 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.WorkItemRule,
                    Phase = "WorkItemRule",
                    ProjectId = @projectId.Value,
                    WorkItemType = 0
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <hr/>\n        <div class=\"row\" style=\"text-align: center;\">\n            <h3>Notification Settings</h3>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 141 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.UpdateUserRights,
                    Phase = "PersonalMessage",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 149 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.ViewOtherPeoplesWork,
                    Phase = "NewWorkItem",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 160 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.UpdateUserRights,
                    Phase = "UpdatedWorkItem",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 168 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.ViewOtherPeoplesWork,
                    Phase = "PublicFeedback",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 179 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.UpdateUserRights,
                    Phase = "PublicBugreport",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 187 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.ViewOtherPeoplesWork,
                    Phase = "PublicDiscussion",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 198 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.UpdateUserRights,
                    Phase = "ChatChannelMessage",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 206 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(await Component.InvokeAsync("UserRightToggle",new IncomingIdRequest{
                    Id = @UserRights.ViewOtherPeoplesWork,
                    Phase = "ChangelogGenerated",
                    ProjectId = @projectId.Value,
                    WorkItemType = 1
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""row"" style=""display: ruby;"">
        <button  class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""SaveUserSettings()"">
            Save Changes
        </button>
        <button  class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""ReturnBack()"">
            Cancel Changes
        </button>

</div>

<script>
    var CurrentUserImage;
    var dropElement = document.getElementsByClassName('control-fluid')[0];
    
    var uploadObj = new ej.inputs.Uploader({
        asyncSettings: {
            saveUrl: '/Uploader/Save',
            removeUrl: '/Uploader/Remove',

        },
        removing: onFileRemove,
        dropArea: dropElement,
        selected: ItemSelected

    });
    uploadObj.appendTo('#fileupload');
    var userFName = new ej.inputs.TextBox({
        placeholder: 'First Name',
        value: """);
#nullable restore
#line 244 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(UserData.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        floatLabelType: \'Auto\'\n    });\n    userFName.appendTo(\'#userFName\');\n    var userLName = new ej.inputs.TextBox({\n        placeholder: \'Last Name\',\n        value: \"");
#nullable restore
#line 250 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(UserData.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        floatLabelType: \'Auto\'\n    });\n    userLName.appendTo(\'#userLName\');\n\n    var userFGit = new ej.inputs.TextBox({\n        placeholder: \'Git Username\',\n        value : \"");
#nullable restore
#line 257 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
            Write(UserData.GitUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n        floatLabelType: \'Auto\'\n    });\n    userFGit.appendTo(\'#userFGit\');\n\n    var userFEmail = new ej.inputs.TextBox({\n        placeholder: \'Email address\',\n        value: \"");
#nullable restore
#line 264 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
           Write(UserData.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
        floatLabelType: 'Auto'
    });
    userFEmail.appendTo('#userFEmail');

    var userFOldPass = new ej.inputs.TextBox({
        placeholder: 'Current Password',
        floatLabelType: 'Auto'
    });
    userFOldPass.appendTo('#userFOldPass');

    var userNewPass = new ej.inputs.TextBox({
        placeholder: 'New Password',
        floatLabelType: 'Auto'
    });

    userNewPass.appendTo('#userNewPass');

    var userConfirm = new ej.inputs.TextBox({
        placeholder: 'Confirm Password',
        floatLabelType: 'Auto'
    });
    userConfirm.appendTo('#userConfirm');


    function ItemSelected(args) {
        console.log(args);
        CurrentUserImage = args.filesData[0].rawFile.name;
        document.getElementById('UserImage').src=window.location.origin + ""/Files/Uploads/""+ args.filesData[0].rawFile.name;
    }
    function onFileRemove(args) {
        document.getElementById('UserImage').src=""https://softsmart.co.za/wp-content/uploads/2018/06/image-not-found-1038x576.jpg"";

    }
     iewW");
            WriteLiteral("orkItems = 0;\n\n        \n\n    function SaveUserSettings()\n    {\n        var dto = {\n            \"projectId\" : ");
#nullable restore
#line 305 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
                     Write(projectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            ""FirstName"" :$(""#userFName"").val(),
            ""LastName"" :$(""#userLName"").val(),
            ""GitName"" : $(""#userFGit"").val(),
            ""Email"" : $(""#userFEmail"").val(),
            ""OldPassword"" : $(""#userFOldPass"").val(),
            ""NewPassword"" : $(""#userNewPass"").val(),
            ""SelectedImage"" : CurrentUserImage
        }
        if(ValidateInputs())
        {
            console.log(dto);
            $.ajax({
                type: 'POST',
                url: '/Changelog/ConfirmChangelog',
                data: JSON.stringify(dto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    alert(""Changelog generated!!!"");
                    window.location.href = ""/Changelog/ViewChangelogs?projectId=");
#nullable restore
#line 325 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Accounts/GetUserProfile.cshtml"
                                                                           Write(projectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
            });
        }
        else
            ShowAlert(""Error with some of your inputs!!!"");
    }


    function ValidateInputs()
    {
        if($(""#userFName"").val())
        {}
        else
        {
            ShowAlert(""Error, user first name can't be empty!"");
            return false;
        }

        if($(""#userLName"").val())
        {}
        else
        {
            ShowAlert(""Error, user last name can't be empty!"");
            return false;
        }

        if($(""#userFGit"").val())
        {}
        else
        {
            ShowAlert(""Error, git username can't be empty!"");
            return false;
        }
        if($(""#userFOldPass"").val())
        {}
        else
        {
            ShowAlert(""Error, old password can't be empty!"");
            return false;
        }
        
        if($(""#userNewPass"").val() === $(""#userConfirm"").val())
");
            WriteLiteral(@"        {}
        else
        {
            ShowAlert(""Error, new passowrd and confirm password should match!!!"");
            return false;
        }
        return true;
    }
    function ReturnBack()
    {
        window.location=document.referrer;
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
