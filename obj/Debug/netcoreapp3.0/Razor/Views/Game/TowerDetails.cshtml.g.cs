#pragma checksum "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9603e4a4a5fa0c3642f95b68bb9924bb73dc7bb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_TowerDetails), @"mvc.1.0.view", @"/Views/Game/TowerDetails.cshtml")]
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
#line 1 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\_ViewImports.cshtml"
using WebGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\_ViewImports.cshtml"
using WebGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9603e4a4a5fa0c3642f95b68bb9924bb73dc7bb9", @"/Views/Game/TowerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c9e0ff5044c8d5e07eb25f0a6ad06b16e9cc2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_TowerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebGame.Models.WebGame.Tower>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TowerEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
  
    ViewData["Title"] = "TowerDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 7 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
Write(await Component.InvokeAsync("OverallStats", new { worldId = ViewBag.WorldId, playerId = ViewBag.PlayerIdWhoClicks }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<h1>TowerDetails</h1>\r\n\r\n<div>\r\n    <h4>Tower</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Attack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Attack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Defence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayFor(model => model.Defence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.WorldId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
       Write(Html.DisplayFor(model => model.WorldId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9603e4a4a5fa0c3642f95b68bb9924bb73dc7bb98049", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_Blazor_SignalR_8_Doing_MainGame_in_blazor\WebGame_school_AND_BLAZOR_21_Tower_display\Views\Game\TowerDetails.cshtml"
                                WriteLiteral(Model.TowerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9603e4a4a5fa0c3642f95b68bb9924bb73dc7bb910287", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebGame.Models.WebGame.Tower> Html { get; private set; }
    }
}
#pragma warning restore 1591
