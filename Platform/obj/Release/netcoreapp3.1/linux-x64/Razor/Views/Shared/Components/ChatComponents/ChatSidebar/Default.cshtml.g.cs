#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85fb42c99f6018d8a691bc5ce14244dc85824174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChatComponents_ChatSidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85fb42c99f6018d8a691bc5ce14244dc85824174", @"/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChatComponents_ChatSidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ChatHandler.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;
    var Username =  ViewData["Username"] as string;
    var ActiveRoom = ViewData["GetDefaultActiveRoom"] as int?;
    var ProjectChatRights = ViewData["ProjectChatRights"] as List<ChatRoomRights>;
    var UserRights = ViewData["GetChatRights"]as UserRights;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .SideBarRow{
        text-align: center;
        width: 100%;
        padding: 2%;
        margin: 0;
    }
    .InlineFlex {
        display: inline-flex;
        width: 100%;
        margin: 0;
    }
</style>`

<!-- sidebar element declaration -->
<aside id=""sidebar-chatview"" style=""overflow-x:hidden;"">
    <div class=""main-menu"" style=""position: relative;"">
        <div class=""table-content"" style=""padding:0;height: 86vh;max-height: 86vh;"">
");
#nullable restore
#line 29 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
             if(@UserRights.ChatChannelsRule == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 100%;"" onclick=""OpenNewCategoryModal()"" id=""OpenNewCategoryModal"">Add new Category</button>
                </div>
");
#nullable restore
#line 34 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row SideBarRow\" style=\"text-align: center;\">\n                ");
#nullable restore
#line 36 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
           Write(await Component.InvokeAsync("SelectProject", @ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"row SideBarRow\" id=\"ChatNavigationHolder\">\n                ");
#nullable restore
#line 39 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
           Write(await Component.InvokeAsync("ChatNavigation", @ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

        </div>
        <div class=""row  UserDetailsPanel"" style=""padding: 0;margin: 0;"">
            <div class=""col-md-12"" style=""padding:0px;"">
                <!-- Basic Card Layout  -->
                <div tabindex=""0"" class=""e-card "" id=""basic_card"" style=""height: 68px; bottom: 0px;position: fixed;width: 100%;margin: 0px;padding: 0px;"">
                    <div class=""e-card-content"">
                        <div class=""col-md-6"">
                            <p style=""cursor: pointer;"">
                                ");
#nullable restore
#line 50 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
                           Write(Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                        
                        <div class=""col-md-2"">
                            <span class=""Microphone""></span>
                        </div>
                        <div class=""col-md-2"">
                            <span class=""HeadPhones""></span>
                        </div>
");
#nullable restore
#line 60 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
                         if(@UserRights.ChatChannelsRule == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-2\">\n                                <span class=\"SettingsIcon\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2543, "\"", 2592, 3);
            WriteAttributeValue("", 2553, "OpenProjectChatSettingsPage(", 2553, 28, true);
#nullable restore
#line 63 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
WriteAttributeValue("", 2581, ProjectId, 2581, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2591, ")", 2591, 1, true);
            EndWriteAttribute();
            WriteLiteral("></span>\n                            </div>\n");
#nullable restore
#line 65 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n\n            </div>\n        </div>\n\n    </div>\n</aside>\n\n<div class=\"main-content-chat\" id=\"main-chatwindow\" style=\"min-height: 92.142vh; top: -20px;\">\n    <div class=\"sidebar-content\">\n        ");
#nullable restore
#line 77 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
   Write(await Component.InvokeAsync("Notes", @ProjectId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"row\" id=\"MainChatContent\">\n            ");
#nullable restore
#line 80 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
       Write(await Component.InvokeAsync("ChatWIndow", new IncomingIdRequest{
                ProjectId = @ProjectId.Value,
                Id = @ActiveRoom.Value
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<div id=""ChatAddNewCategoryModal"">
    <div class=""row"">
            <input id=""InputNewChatCategory"" />
    </div>
    <div class=""row InlineFlex"">
        <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""SaveNewChatCategory()"">Submit</button>
        <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""CloseNewCategoryModal()"">Cancel</button>
    </div>

</div>



<div id=""ChatAddNewRoomModal"">
    <div class=""row"">
            <input id=""InputNewChatRoom"" />
    </div>
    <div class=""row InlineFlex"">
        <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""SaveNewChatRoom()"">Submit</button>
        <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;"" onclick=""CloseNewChatRoomModal()"">Cancel</button>
    </div>

</div>

<div id=""ChatAssignUserRights"">
    <div class=""row"" style");
            WriteLiteral("=\"padding: 15px;\">\n");
#nullable restore
#line 113 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
         foreach (var right in ProjectChatRights)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ChipTag\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4318, "\"", 4352, 3);
            WriteAttributeValue("", 4328, "AssignUserTag(", 4328, 14, true);
#nullable restore
#line 115 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
WriteAttributeValue("", 4342, right.Id, 4342, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4351, ")", 4351, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
                                                                Write(right.RightName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n");
#nullable restore
#line 116 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""row InlineFlex"">
        <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 100%;"" onclick=""CloseChatAssignRights()"">Close</button>
     </div>

</div>



<script>

var ActiveUser=
{
    ""Name"" : """);
#nullable restore
#line 130 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
         Write(Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n    \"ActiveRoom\" : ");
#nullable restore
#line 131 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
              Write(ActiveRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n    \"ProjectId\" : ");
#nullable restore
#line 132 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
             Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
};
var ActiveQueryUser;
var SelectedCategoryId;
var InputNewChatRoom = new ej.inputs.TextBox({
    placeholder: 'Channel name',
    floatLabelType: 'Auto'
});
InputNewChatRoom.appendTo('#InputNewChatRoom');
var InputNewChatCategory = new ej.inputs.TextBox({
    placeholder: 'Category Name',
    floatLabelType: 'Auto'
});
InputNewChatCategory.appendTo('#InputNewChatCategory');
var sidebarChat = new ej.navigations.Sidebar({
    width: '290px',
    target: '.main-content-chat',
    mediaQuery: '(min-width: 600px)',
});
sidebarChat.appendTo('#sidebar-chatview');
//end of Sidebar initialization
var ChatAddNewCategoryModal;


ChatAddNewCategoryModal = new ej.popups.Dialog({
    width: '600px',
    header: 'Name your new category',
    isModal: true,
    animationSettings: { effect: 'None' },
    visible: false,

 
});
ChatAddNewCategoryModal.appendTo('#ChatAddNewCategoryModal');

ChatAddNewCategoryModal.hide();


var ChatAddNewRoomModal;


ChatAddNewRoomModal = new ej.popups.Dialog({
    width: '600px',
    heade");
            WriteLiteral(@"r: 'Name your new room',
    isModal: true,
    animationSettings: { effect: 'None' },
    visible: false,
 
});
ChatAddNewRoomModal.appendTo('#ChatAddNewRoomModal');

ChatAddNewRoomModal.hide();



var ChatAssignUserRights;


ChatAssignUserRights = new ej.popups.Dialog({
    width: '600px',
    header: 'Assign User Right',
    isModal: true,
    animationSettings: { effect: 'None' },
    visible: false,
 
});
ChatAssignUserRights.appendTo('#ChatAssignUserRights');

ChatAssignUserRights.hide();

// Dialog will be closed, while clicking on overlay
function onChange(args) {
    if(args.checked) {
        ChatAddNewCategoryModal.overlayClick = function () {
            ChatAddNewCategoryModal.hide();
        };
        ChatAddNewCategoryModal.overlayClick = function () {
            ChatAddNewCategoryModal.hide();
        };
    }
    else {
        ChatAddNewRoomModal.overlayClick = function () {
            ChatAddNewRoomModal.show();
        };
        ChatAddNewRoomModal.overlayClick = function () {
        ");
            WriteLiteral(@"    ChatAddNewRoomModal.show();
        };
    }
}

function OpenNewCategoryModal(){
    ChatAddNewCategoryModal.show();
}
function CloseNewCategoryModal()
{
    ChatAddNewCategoryModal.hide();

}


function AddNewChannelModal(id)
{
    console.log(id);
    SelectedCategoryId = id;
    ChatAddNewRoomModal.show();
}
 

function CloseNewChatRoomModal()
{
        ChatAddNewRoomModal.hide();
}


function OpenChatAssignRights(id){
    ChatAssignUserRights.show();
    ActiveQueryUser =id;
}
function CloseChatAssignRights()
{
    ChatAssignUserRights.hide();

}


function SaveNewChatCategory()
{
    var messagesDto = {
        ""Id"": ");
#nullable restore
#line 260 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
        ""Phase"" : $(""#InputNewChatCategory"").val()
    }
    console.log(messagesDto);
    console.log($(""#InputNewChatCategory"").val());
    if($(""#InputNewChatCategory"").val())
    {

        $.ajax({
                type: 'POST',
                url: '/Chat/AddNewCategory',
                data: JSON.stringify(messagesDto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                
                success: function (response) {
                    InitializeChatItems(response);
                    ChatAddNewCategoryModal.hide();

                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
        });
    }
    else
        ShowAlert(""Input field Category Name must contain a value!!!"");

}


function SaveNewChatRoom()
{
    var messagesDto = {
        ""Id"": SelectedCategoryId,
        ""Phase"" : $(""#InputNewChatRoom"").val(),
        ""WorkItemType"": ");
#nullable restore
#line 296 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
                   Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    }
    if($(""#InputNewChatRoom"").val())
    {

        $.ajax({
                type: 'POST',
                url: '/Chat/AddNewChatRoom',
                data: JSON.stringify(messagesDto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                
                success: function (response) {
                    InitializeChatItems(response);
                    ChatAddNewRoomModal.hide();
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
        });
    }
    else
        ShowAlert(""Input field Channel Name must contain a value!!!"");
}
function AssignUserTag(Id)
{
     var messagesDto = {
         ""ProjectId"": ");
#nullable restore
#line 323 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
                 Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
         ""Id"": Id,
         ""UserId"": ActiveQueryUser,
         ""__RequestVerificationToken"" :gettoken()
    }

    $.ajax({
            type: 'POST',
            url: '/Chat/AssignUserTag',
            data: JSON.stringify(messagesDto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            
            success: function (response) {
                CloseChatAssignRights();
                $(""#ActiveTags"").append(""<span class=\""ChipTag\"">""+response.rightName+""<span onclick=\""DeletingTag(""+response.id+"")\"" class=\""ChipCloseBtn\"" ></span></span>"");
 
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
    });
    var dto = {
        ""Id"": ");
#nullable restore
#line 346 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatSidebar/Default.cshtml"
         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
        ""__RequestVerificationToken"" :gettoken()

     }

    $.ajax({
            type: 'POST',
            url: '/Chat/GetChatChannelsNavigation',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            
            success: function (response) {
               InitializeChatItems(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
    });
    
}
function SetRoomNewMessage(id)
{
    $( ""#ChatChannel_""+id ).addClass(""NewMessage"");
}

function OpenProjectChatSettingsPage(id)
{
    $(""#ChatElement"").html("""");
    $(""#ChatElement"").load(""/Chat/GetChatSettings?id=""+id);
}
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85fb42c99f6018d8a691bc5ce14244dc8582417420829", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            WriteAttributeValue("", 10719, "~/lib/", 10719, 6, true);
            WriteLiteral("@");
            WriteAttributeValue("", 10727, "aspnet/signalr/dist/browser/signalr.js", 10727, 38, true);
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85fb42c99f6018d8a691bc5ce14244dc8582417422281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
