#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b937266e04de2e7a0bc55354ead24cbdb425638f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChatComponents_GetTagProperties_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b937266e04de2e7a0bc55354ead24cbdb425638f", @"/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChatComponents_GetTagProperties_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
  
    var Tag = ViewData["Tag"]  as ChatRoomRights;
    var CallingOption = ViewData["FormOption"] as int?;
    var ChatRoom = ViewData["ChatRoom"] as int?;
    var ProjectId = ViewData["ProjectId"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
.ChipTag{
    border-radius: 15px;
    padding: 4px;
  }
 .ChipTag:hover{
    border-radius: 15px;
    padding: 4px;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
 }

</style>
<div class=""row"">
    <input id=""TagNameInput"" onkeyup=""TagNameInputUpdated()"" />
</div>
<div class=""row"">
    <div id=""picker"" class=""col-md-6"">
        <h4 style=""text-align: center;"">Foreground Color</h4>
        <input id=""Fp"" type=""color"">
    </div>
    <div id=""picker"" class=""col-md-6"">
        <h4 style=""text-align: center;"">Background Color</h4>
        <input id=""Bp"" type=""color"">
    </div>
</div>
<div class=""row"" style=""text-align: center;"">
    <h4>Preview</h4>
");
#nullable restore
#line 35 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
     if(Tag != null) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"ChipTag\"");
            BeginWriteAttribute("style", "  style=\"", 935, "\"", 1000, 5);
            WriteAttributeValue("", 944, "background-color:", 944, 17, true);
#nullable restore
#line 37 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
WriteAttributeValue(" ", 961, Tag.Background, 962, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 977, ";", 977, 1, true);
            WriteAttributeValue(" ", 978, "color:", 979, 7, true);
#nullable restore
#line 37 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
WriteAttributeValue("", 985, Tag.Foreground, 985, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Tag\"> ");
#nullable restore
#line 37 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
                                                                                                     Write(Tag.RightName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"ChipCloseBtn\" ></span></span>\n");
#nullable restore
#line 38 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"ChipTag\"  style=\"background-color: red; color:white\" id=\"Tag\"> Example Tag <span class=\"ChipCloseBtn\" ></span></span>\n");
#nullable restore
#line 42 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""row"" style=""display: block ruby; padding:2%;""> 
    <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;text-align: center; "" onclick=""SaveTagItemChanges()"">Save</button>
    <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 50%;text-align: center;"" onclick=""CancelTagItemChanges()"">Cancel</button>
</div>

<script>

    var method;
    var Foreground;
    var Background;
    var Option = """);
#nullable restore
#line 55 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
             Write(CallingOption);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
    if(Option === ""1"")
    {
        method = ""TagUpdate"";
    }   
    else
    {
        method = ""TagSave"";
    }
    var TagNameInput = new ej.inputs.TextBox({
        placeholder: ""Name your badge"",
        floatLabelType: 'Auto'
    });
    TagNameInput.appendTo('#TagNameInput');

    var defaultObj = new ej.inputs.ColorPicker({
        mode: 'Picker',
        modeSwitcher: false,
        inline: true,
        showButtons: false,
        change: ChangeFp
    });
    defaultObj.appendTo('#Fp');

    var Bp = new ej.inputs.ColorPicker({
        mode: 'Picker',
        modeSwitcher: false,
        inline: true,
        showButtons: false,
        change: ChangeBp
    });
    Bp.appendTo('#Bp');

    function SaveTagItemChanges()
    {
        var dto = {
            ""Id"": ");
#nullable restore
#line 91 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
             Write(Tag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            \"Foreground\" : Foreground,\n            \"Background\" : Background,\n            \"RightName\" : $(\"#TagNameInput\").val(),\n            \"ProjectId\" : ");
#nullable restore
#line 95 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
                     Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            \"ChatRoomId\" : ");
#nullable restore
#line 96 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
                      Write(ChatRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        }

        $.ajax({
                type: 'POST',
                url: '/Chat/'+method,
                data: JSON.stringify(dto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                
                success: function (response) {
                    $(""#LoadedChatRoomSetting"").html("""");
                    $(""#LoadedChatRoomSetting"").load(""/Chat/GetChatRoomSettings?chatRoom=""+");
#nullable restore
#line 108 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
                                                                                      Write(ChatRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\"&&id=\"+");
#nullable restore
#line 108 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/GetTagProperties/Default.cshtml"
                                                                                                        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
        });
    }    

    function CancelTagItemChanges()
    {
        $(""#TagSettingProperties"").html("""");
    }

    function ChangeFp(args)
    {
        Foreground = args.value;
        $('#Tag').css('color', args.value);
    }
    function ChangeBp(args)
    {
        Background = args.value;
        $('#Tag').css('background-color', args.value);
    }
    function TagNameInputUpdated()
    {
        $(""#Tag"").html($(""#TagNameInput"").val());
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
