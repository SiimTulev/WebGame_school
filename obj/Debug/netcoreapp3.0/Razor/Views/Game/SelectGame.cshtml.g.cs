#pragma checksum "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a7161636167c6c6eb6307bc959363011b454a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_SelectGame), @"mvc.1.0.view", @"/Views/Game/SelectGame.cshtml")]
namespace AspNetCore
{
    #line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\_ViewImports.cshtml"
using WebGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\_ViewImports.cshtml"
using WebGame.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using WebGame.Models.WebGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using WebGame.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a7161636167c6c6eb6307bc959363011b454a5", @"/Views/Game/SelectGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c9e0ff5044c8d5e07eb25f0a6ad06b16e9cc2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_SelectGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebGame.Models.WebGame.World>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-error", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MainGameRazor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MainGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 13 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
  
    ViewData["Title"] = "SelectGame";
    var winners = ViewBag.WinnerNames;
    var player1Name = ViewBag.playerNames1;
    var player2Name = ViewBag.playerNames2;
    int counterOverall = 0;

    int counter = 0;

    var youReady = ViewBag.You;
    var enemyReady = ViewBag.Enemy;
    int counterReady = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
  
    if (ViewBag.Tutorial == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"tutorial\">To find a player to play with, click FIND GAME</h1>\r\n");
#nullable restore
#line 31 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
    }

    else if (User.Identity.IsAuthenticated) // If account is logged in
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 style=\"font-size:30px;\" class=\"btn btn-info nav-link text-white\">World selection</h1>\r\n        <table class=\"table\">\r\n            <tbody>\r\n");
#nullable restore
#line 38 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                 foreach (var item in Model)
                {

                    if (item.GameFinished == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"winner\">\r\n                            <td>\r\n                                <h5>Game has ended. Winner ");
#nullable restore
#line 45 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                      Write(winners[counter]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </td>\r\n                            <td>\r\n                                <h5> World: ");
#nullable restore
#line 48 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.WorldId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                        counter++;
                    }
                    else
                    {
                        if (item.Player2Id < 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <span class=\"pName\">");
#nullable restore
#line 58 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                           Write(player1Name[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VS ???\r\n                        </td>\r\n");
            WriteLiteral("                        <td>\r\n                            <h5 class=\"alert alert-dark \">Searching for an enemy player</h5>\r\n                        </td>\r\n");
#nullable restore
#line 64 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <span class=\"pName\">");
#nullable restore
#line 69 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                               Write(player1Name[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> VS <span class=\"pName\">");
#nullable restore
#line 69 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                          Write(player2Name[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                            </td>\r\n                            <td class=\"Ready\">\r\n");
#nullable restore
#line 72 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                  
                                    if (@youReady[counterOverall].Contains("NOT"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"alert alert-danger NOT\">");
#nullable restore
#line 75 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                        Write(youReady[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n");
#nullable restore
#line 76 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"alert alert-success\">\r\n                                            ");
#nullable restore
#line 80 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                       Write(youReady[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span><br />\r\n");
#nullable restore
#line 82 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                    }
                                    if (@enemyReady[counterOverall].Contains("NOT"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"alert alert-danger NOT\"> ");
#nullable restore
#line 85 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                         Write(enemyReady[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 86 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"alert alert-success\">");
#nullable restore
#line 89 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                     Write(enemyReady[counterOverall]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 90 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n                                <h5 class=\"worldNum\" style=\"margin-top:50px;\">World: ");
#nullable restore
#line 94 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.WorldId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </td>\r\n\r\n                            <td class=\"nav-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a7161636167c6c6eb6307bc959363011b454a516598", async() => {
                WriteLiteral("Join World");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-error", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["error"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-player1Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                             WriteLiteral(item.Player1Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player1Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                                                                   WriteLiteral(item.Player2Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player2Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                                                                                                       WriteLiteral(item.WorldId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-worldId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                                                                                                                                              WriteLiteral(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountCheck"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-accountCheck", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["accountCheck"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a7161636167c6c6eb6307bc959363011b454a522926", async() => {
                WriteLiteral("Join World MVC");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-player1Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                   WriteLiteral(item.Player1Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player1Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player1Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                                                         WriteLiteral(item.Player2Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-player2Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["player2Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                                                                                                                                                                                             WriteLiteral(item.WorldId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-worldId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["worldId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 105 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
                    }
                }
                counterOverall++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 111 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_14_everything_works\Views\Game\SelectGame.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .alert {
        display: inline-block;
    }

    .tutorial {
        color: red;
    }

    .NOT {
        color: red;
    }

    .Ready {
        color: green;
        font-size: 16px;
    }

    .pName {
        color: green;
        font-size: 25px;
    }

    .winner {
        background-color: red;
        color: greenyellow;
    }

    .searching {
        color: red;
    }

    .worldNum {
        color: green;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebGame.Models.WebGame.World>> Html { get; private set; }
    }
}
#pragma warning restore 1591
