#pragma checksum "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f24e82a2a2da909d88d24da561be3146dc8dbc80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_CancelArmyMovement), @"mvc.1.0.view", @"/Views/Game/CancelArmyMovement.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\_ViewImports.cshtml"
using WebGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\_ViewImports.cshtml"
using WebGame.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24e82a2a2da909d88d24da561be3146dc8dbc80", @"/Views/Game/CancelArmyMovement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c9e0ff5044c8d5e07eb25f0a6ad06b16e9cc2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_CancelArmyMovement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebGame.Models.WebGame.AttDef>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelArmyMovement_", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MainGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
  
    ViewData["Title"] = "CancelArmyMovement";
    var towerNames = ViewBag.TowerNames;
    int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 14 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
Write(await Component.InvokeAsync("OverallStats", new { worldId = ViewBag.WorldId, playerId = ViewBag.PlayerIdWhoClicks }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n\r\n<h1 style=\"font-size:30px;\" class=\"btn btn-danger nav-link text-white\">Movements</h1>\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
  
    if (ViewBag.Empty == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"Empty\">You don\'t have any army to stop</h1>\r\n");
#nullable restore
#line 25 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Tower Name\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                   Write(Html.DisplayNameFor(model => model.RoundsToArrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 44 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                       Write(towerNames[counter]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RoundsToArrive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f24e82a2a2da909d88d24da561be3146dc8dbc809464", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-accountCheck", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                    WriteLiteral(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountCheck"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-accountCheck", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountCheck"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                                                                                 WriteLiteral(item.WorldId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-worldId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                                                                                                                 WriteLiteral(item.AttackerPlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["owner"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-owner", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["owner"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                                                                                                                                                              WriteLiteral(ViewBag.Player1Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player1Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                                                                                                                                                                                                       WriteLiteral(ViewBag.Player2Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player2Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                    counter++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f24e82a2a2da909d88d24da561be3146dc8dbc8017212", async() => {
                WriteLiteral("Back to map");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-player1Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                   WriteLiteral(ViewBag.Player1Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player1Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                            WriteLiteral(ViewBag.Player2Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player2Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                   WriteLiteral(ViewBag.WorldId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-worldId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
                                                                                                                                                                                             WriteLiteral(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountCheck"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-accountCheck", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountCheck"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Game\CancelArmyMovement.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .Empty {\r\n        color: red;\r\n    }\r\n\r\n    .btn-container, .container {\r\n        background-color: white;\r\n        border-radius: 4px;\r\n        margin-bottom: 40px;\r\n    }\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebGame.Models.WebGame.AttDef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
