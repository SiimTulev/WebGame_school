#pragma checksum "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154f9ea4cc64355f243af0c177d87ffcebe36885"
// <auto-generated/>
#pragma warning disable 1591
namespace WebGame.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 5 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
using WebGame.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game/MainGameRazor/{error}/{player1Id}/{player2Id}/{worldId}/{accountCheck}")]
    public partial class MainGameRazor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "OverallStats");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 11 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
      
        if (IsWinner != true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "            ");
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "class", "ReadyLBL");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 15 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                  
                    if (you.Contains("NOT"))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                        ");
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "NOT");
            __builder.AddContent(10, 
#nullable restore
#line 18 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                           you

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(11, " ");
            __builder.AddMarkupContent(12, "<a class=\"white\">-|-</a>\r\n");
#nullable restore
#line 19 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, 
#nullable restore
#line 22 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                         you

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddMarkupContent(15, "<a class=\"white\">-|-</a>\r\n");
#nullable restore
#line 23 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                    }
                    if (enemy.Contains("NOT"))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                        ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "NOT");
            __builder.AddContent(19, 
#nullable restore
#line 26 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                           enemy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 27 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                         enemy

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 30 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                              
                    }
                

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "buttons");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "content-3d Ready");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "btn-3d green");
            __builder.AddAttribute(32, "href", "/Game/PlayerReady/" + (
#nullable restore
#line 38 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                     towers[0].WorldId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Ready");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "content-3d CancelArmyMovement");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "btn-3d red");
            __builder.AddAttribute(41, "href", "/Game/CancelArmyMovement/" + (
#nullable restore
#line 44 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                          towers[0].WorldId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 44 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                             playerIdWhoClicks

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 44 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                towers[0].Player1Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 44 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                                     towers[0].Player2Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Movements");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 48 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.AddMarkupContent(47, "<h2>WINNER</h2>\r\n            ");
            __builder.OpenElement(48, "h1");
            __builder.AddContent(49, 
#nullable restore
#line 52 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                 Winner

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.AddMarkupContent(51, "<h2>WINNER</h2>\r\n");
#nullable restore
#line 54 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
        }
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "Stats1");
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "class", "PlayerNames btn btn-primary");
            __builder.AddAttribute(58, "href", "/Game/Profile/" + (
#nullable restore
#line 60 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                YourId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, 
#nullable restore
#line 60 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                         YourName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    VS\r\n    ");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "class", "PlayerNames btn btn-primary");
            __builder.AddAttribute(63, "href", "/Game/Profile/" + (
#nullable restore
#line 62 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                EnemyId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, 
#nullable restore
#line 62 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                          EnemyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    <br>\r\n");
#nullable restore
#line 64 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
      
        if (error != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "            ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "alert alert-danger Error");
            __builder.AddAttribute(69, "role", "alert");
            __builder.AddContent(70, "  ");
            __builder.AddContent(71, 
#nullable restore
#line 67 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                  error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 68 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
        }
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n<br>\r\n<br>\r\n\r\n\r\n");
            __builder.OpenElement(74, "div");
            __builder.AddMarkupContent(75, "\r\n\r\n");
#nullable restore
#line 79 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
      
        int counter = 0;
        string towerOwnerColor = "";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
     foreach (var item in towers)
    {
        counter++;
        string box = "box" + counter;
        if (item.Owner == playerIdWhoClicks)
        {
            towerOwnerColor = "friendly";
        }
        else if (item.Owner == 0)
        {
            towerOwnerColor = "empty";
        }
        else
        {
            towerOwnerColor = "enemy";
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", (
#nullable restore
#line 99 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                     box

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 99 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                          towerOwnerColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "h5");
            __builder.AddContent(81, " ");
            __builder.AddContent(82, 
#nullable restore
#line 100 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                  item.TowerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\r\n            ");
            __builder.OpenElement(84, "a");
            __builder.AddAttribute(85, "class", "btn btn-danger");
            __builder.AddAttribute(86, "href", "/Game/CreateArmyMission/" + (
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                     item.WorldId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                   item.Owner

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                               item.Player1Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                               item.Player2Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                               item.TowerId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 102 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                                             playerIdWhoClicks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(87, "Move");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 103 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
              
                int TowerLvl;
                int Defence;
                int costs;


                if (item.Owner == @playerIdWhoClicks)
                {
                    TowerLvl = item.TowerLvl;
                    Defence = (item.TowerLvl) * 5;
                    costs = (item.TowerLvl + 1) * 100;


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "                    <br>\r\n                    ");
            __builder.OpenElement(90, "span");
            __builder.AddContent(91, "Size: ");
            __builder.OpenElement(92, "a");
            __builder.AddAttribute(93, "style", "font-size:20px; color:red;");
            __builder.AddContent(94, " ");
            __builder.AddContent(95, 
#nullable restore
#line 116 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                        item.Attack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.AddContent(97, "                    ");
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "class", "btn btn-success");
            __builder.AddAttribute(100, "href", "Game/UpgradeTower/" + (
#nullable restore
#line 119 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                        item.TowerId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 119 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                      loggedInAccountId

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 119 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                         item.Owner

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 119 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                     item.Player1Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 119 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                                     item.Player2Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 119 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                                                                                     item.WorldId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(101, "Upgrade tower");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
            __builder.AddMarkupContent(103, "                    <br>\r\n                    ");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                            e => ShowMessage2(e,TowerLvl, @Defence,@costs)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(106, 
#nullable restore
#line 122 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                                                                                              item.TowerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 123 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"

                }
                //<button @onmousemove="@(e => ShowMessage2(e,TowerLvl, @Defence,@costs))">2</button>

            

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 130 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
            __builder.OpenElement(111, "a");
            __builder.AddAttribute(112, "class", "btn btn-warning cord");
            __builder.AddMarkupContent(113, "\r\n    Tower level: ");
            __builder.AddContent(114, 
#nullable restore
#line 133 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                  towerLvl

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(115, "\r\n    Tower Defence: ");
            __builder.AddContent(116, 
#nullable restore
#line 134 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                    defence

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(117, "\r\n    Tower Costs: ");
            __builder.AddContent(118, 
#nullable restore
#line 135 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
                  costs

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, "\r\n    <br>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(121, "style");
            __builder.AddMarkupContent(122, "\r\n\r\n     .towerMenu {\r\n        position: absolute;\r\n        left: ");
            __builder.AddContent(123, 
#nullable restore
#line 199 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
               x

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(124, ";\r\n        top: ");
            __builder.AddContent(125, 
#nullable restore
#line 200 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
              y

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(126, ";\r\n        width: 50px;\r\n        height: 100px;\r\n        }\r\n\r\n .cord {\r\n        position: absolute;\r\n        left: ");
            __builder.AddContent(127, 
#nullable restore
#line 207 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
               x

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(128, ";\r\n        top: ");
            __builder.AddContent(129, 
#nullable restore
#line 208 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
              y

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(130, ";\r\n        width: 50px;\r\n        height: 50px;\r\n        }\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(132, "<style>\r\n\r\n    .upgrade {\r\n        font-size: 17px;\r\n    }\r\n\r\n    .buttons {\r\n        margin-left: 200px;\r\n        text-align: center;\r\n        margin-top: -15px;\r\n    }\r\n\r\n    .Ready {\r\n        width: 50%;\r\n        height: 0px;\r\n    }\r\n\r\n    .CancelArmyMovement {\r\n        width: 120%;\r\n        height: 0px; /* Siis tulevad mängija nimed üksteise kõrvale*/\r\n    }\r\n\r\n    @media (max-width:991px) {\r\n        .Ready {\r\n            width: 30%;\r\n        }\r\n\r\n        .CancelArmyMovement {\r\n            width: 130%;\r\n        }\r\n    }\r\n\r\n    @media (max-width: 767px) {\r\n        .Ready {\r\n            width: 10%;\r\n        }\r\n\r\n        .CancelArmyMovement {\r\n            width: 200%;\r\n        }\r\n    }\r\n\r\n\r\n    .btn-container, .container {\r\n        background-color: white;\r\n        border-radius: 4px;\r\n        margin-bottom: 40px;\r\n    }\r\n\r\n    .btn-3d {\r\n        position: relative;\r\n        display: inline-block;\r\n        font-size: 22px;\r\n        padding: 20px 60px;\r\n        color: white;\r\n        margin: 20px 10px 10px;\r\n        border-radius: 6px;\r\n        text-align: center;\r\n        transition: top .01s linear;\r\n        text-shadow: 0 1px 0 rgba(0,0,0,0.15);\r\n    }\r\n\r\n        .btn-3d.green:hover {\r\n            background-color: #87a86f;\r\n        }\r\n\r\n    .color .green {\r\n        background: #82c8a0;\r\n    }\r\n\r\n\r\n    .btn-3d:active {\r\n        top: 9px;\r\n    }\r\n\r\n\r\n    .btn-3d.green {\r\n        background-color: #82c8a0;\r\n        box-shadow: 0 0 0 1px #82c8a0 inset, 0 0 0 2px rgba(255,255,255,0.15) inset, 0 8px 0 0 rgba(126, 194, 155, .7), 0 8px 0 1px rgba(0,0,0,.4), 0 8px 8px 1px rgba(0,0,0,0.5);\r\n    }\r\n\r\n        .btn-3d.green:active {\r\n            box-shadow: 0 0 0 1px #82c8a0 inset, 0 0 0 2px rgba(255,255,255,0.15) inset, 0 0 0 1px rgba(0,0,0,0.4);\r\n        }\r\n\r\n    .btn.green {\r\n        box-shadow: 0px 4px 0px #87a86f;\r\n    }\r\n\r\n        .btn.green:active {\r\n            box-shadow: 0 0 #87a86f;\r\n            background-color: #87a86f;\r\n        }\r\n\r\n    .btn.green, .btn-two.green {\r\n        background-color: #9abf7f;\r\n    }\r\n\r\n    .btn-gradient.green {\r\n        background: rgba(130,200,160,1);\r\n        background: -moz-linear-gradient(top, rgba(130,200,160,1) 0%, rgba(130,199,158,1) 100%);\r\n        background: -webkit-gradient(left top, left bottom, color-stop(0%, rgba(130,200,160,1)), color-stop(100%, rgba(130,199,158,1)));\r\n        background: -webkit-linear-gradient(top, rgba(130,200,160,1) 0%, rgba(130,199,158,1) 100%);\r\n        background: -o-linear-gradient(top, rgba(130,200,160,1) 0%, rgba(130,199,158,1) 100%);\r\n        background: -ms-linear-gradient(top, rgba(130,200,160,1) 0%, rgba(130,199,158,1) 100%);\r\n        background: linear-gradient(to bottom, rgba(130,200,160,1) 0%, rgba(124, 185, 149, 1) 100%);\r\n        filter: progid:DXImageTransform.Microsoft.gradient( startColorstr=\'#82c8a0\', endColorstr=\'#82c79e\', GradientType=0 );\r\n    }\r\n\r\n        .btn-gradient.green:active {\r\n            background: #72B08E;\r\n        }\r\n\r\n    .btn.red, .btn-two.red {\r\n        background-color: #fa5a5a;\r\n    }\r\n\r\n    .btn-3d.red:hover {\r\n        background-color: #ff4c4b;\r\n    }\r\n\r\n    .btn-3d.red {\r\n        background-color: #e74c3c;\r\n        box-shadow: 0 0 0 1px #c63702 inset, 0 0 0 2px rgba(255,255,255,0.15) inset, 0 8px 0 0 #C24032, 0 8px 0 1px rgba(0,0,0,0.4), 0 8px 8px 1px rgba(0,0,0,0.5);\r\n    }\r\n\r\n        .btn-3d.red:active {\r\n            box-shadow: 0 0 0 1px #c63702 inset, 0 0 0 2px rgba(255,255,255,0.15) inset, 0 0 0 1px rgba(0,0,0,0.4);\r\n        }\r\n\r\n    .btn.red {\r\n        box-shadow: 0px 4px 0px #E04342;\r\n    }\r\n\r\n        .btn.red:active {\r\n            box-shadow: 0 0 #ff4c4b;\r\n            background-color: #ff4c4b;\r\n        }\r\n\r\n\r\n    .Error {\r\n        top: 20px;\r\n        font-size: 20px;\r\n        left: 0px;\r\n        margin-right: 160px;\r\n    }\r\n\r\n    .PlayerNames {\r\n        font-size: 35px;\r\n        color: mediumspringgreen;\r\n        background-color: black;\r\n        z-index: 1;\r\n    }\r\n\r\n    .Stats1 {\r\n        font-size: 30px;\r\n        left: 5%;\r\n        right: 70%;\r\n        top: 30px;\r\n        position: fixed;\r\n        z-index: 1;\r\n    }\r\n\r\n    @media (max-width:1588px) {\r\n        .Stats1 {\r\n            font-size: 20px;\r\n            margin-left: -1%;\r\n        }\r\n    }\r\n\r\n\r\n\r\n    body {\r\n        font-size: 100%;\r\n    }\r\n\r\n    .ReadyLBL {\r\n        font-size: 30px;\r\n        color: chartreuse;\r\n        background-color: black;\r\n        top: 50px;\r\n        left: 60%;\r\n        position: fixed;\r\n        z-index: 1;\r\n    }\r\n\r\n    @media (max-width:1588px) {\r\n        .ReadyLBL {\r\n            font-size: 23px;\r\n            top: 52px;\r\n        }\r\n    }\r\n\r\n    @media (max-width:1180px) {\r\n        .ReadyLBL {\r\n            font-size: 20px;\r\n            top: 52px;\r\n        }\r\n    }\r\n\r\n    @media (max-width:976px) {\r\n        .ReadyLBL {\r\n            font-size: 20px;\r\n        }\r\n    }\r\n\r\n    .NOT {\r\n        color: red;\r\n    }\r\n\r\n    .white {\r\n        color: white !important;\r\n    }\r\n\r\n    .OverallStats {\r\n        left: 26%;\r\n    }\r\n\r\n    .ReadyBTN {\r\n        font-size: 40px;\r\n        color: green;\r\n        margin-right: 7%;\r\n    }\r\n\r\n    .CancelArmyMovementBTN {\r\n        font-size: 40px;\r\n        color: red;\r\n    }\r\n\r\n\r\n    * {\r\n        box-sizing: border-box;\r\n    }\r\n\r\n    .wrapper {\r\n        border: 2px solid #f76707;\r\n        border-radius: 50px;\r\n        background-color: #fff4e6;\r\n        display: grid;\r\n        grid-template-columns: repeat(8, 185px); /* 12.5%*/\r\n        grid-template-rows: repeat(3, 260px); /* 225*/\r\n        width: 1480px; /*90%*/\r\n        position: absolute;\r\n        left: 50%;\r\n        top: 577px;\r\n        transform: translate(-50%, -50%);\r\n    }\r\n\r\n        .wrapper > .friendly {\r\n            border: 2px solid #ffa94d;\r\n            border-radius: 10px;\r\n            background-color: lightgreen;\r\n            padding: 1em;\r\n            color: black;\r\n        }\r\n\r\n        .wrapper > .enemy {\r\n            border: 2px solid #ffa94d;\r\n            border-radius: 10px;\r\n            background-color: lightcoral;\r\n            padding: 1em;\r\n            color: black;\r\n        }\r\n\r\n        .wrapper > .empty {\r\n            border: 2px solid #ffa94d;\r\n            border-radius: 10px;\r\n            background-color: grey;\r\n            padding: 1em;\r\n            color: black;\r\n        }\r\n\r\n\r\n    .box1 {\r\n        grid-column-start: 1;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box2 {\r\n        grid-column-start: 2;\r\n        grid-row-start: 0;\r\n    }\r\n\r\n    .box3 {\r\n        grid-column-start: 2;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box4 {\r\n        grid-column-start: 2;\r\n        grid-row-start: 3;\r\n    }\r\n\r\n    .box5 {\r\n        grid-column-start: 3;\r\n        grid-row-start: 1;\r\n    }\r\n\r\n    .box6 {\r\n        grid-column-start: 3;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box7 {\r\n        grid-column-start: 3;\r\n        grid-row-start: 3;\r\n    }\r\n\r\n    .box8 {\r\n        grid-column-start: 4;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box9 {\r\n        grid-column-start: 5;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box10 {\r\n        grid-column-start: 6;\r\n        grid-row-start: 1;\r\n    }\r\n\r\n    .box11 {\r\n        grid-column-start: 6;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box12 {\r\n        grid-column-start: 6;\r\n        grid-row-start: 3;\r\n    }\r\n\r\n    .box13 {\r\n        grid-column-start: 7;\r\n        grid-row-start: 1;\r\n    }\r\n\r\n    .box14 {\r\n        grid-column-start: 7;\r\n        grid-row-start: 2;\r\n    }\r\n\r\n    .box15 {\r\n        grid-column-start: 7;\r\n        grid-row-start: 3;\r\n    }\r\n\r\n    .box16 {\r\n        grid-column-start: 8;\r\n        grid-row-start: 2;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 214 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_15_error_fixed\Components\MainGameRazor.razor"
       

    private string cord;
    private int towerLvl;
    private int defence;
    private int costs;

    private string x;
    private string y;

    private void ShowMessage2(MouseEventArgs e, int TowerLvl, int Defence, int Costs)
    {
        x = Convert.ToString(e.ClientX) + "px";
        y = Convert.ToString(e.ClientY + 10) + "px";
        towerLvl = TowerLvl;
        defence = Defence;
        costs = Costs;
    }


    [Parameter]
    public int YourId { get; set; } // POLE VEEL KUTSUTUD

    [Parameter]
    public string YourName { get; set; } // POLE VEEL KUTSUTUD

    [Parameter]
    public int EnemyId { get; set; } // POLE VEEL KUTSUTUD

    [Parameter]
    public string EnemyName { get; set; } // POLE VEEL KUTSUTUD

    [Parameter]
    public string Winner { get; set; } // POLE VEEL KUTSUTUD



    [Parameter]
    public bool IsWinner { get; set; }

    [Parameter]
    public string you { get; set; }

    [Parameter]
    public string enemy { get; set; }

    [Parameter]
    public List<WebGame.ViewModel.TowerViewModel> towers { get; set; }

    [Parameter]
    public string error { get; set; }


    [Parameter]
    public int playerIdWhoClicks { get; set; }

    [Parameter]
    public int loggedInAccountId { get; set; }

    [Parameter]
    public int? test1 { get; set; }
    protected override void OnInitialized()
    {
        test1 = test1 ?? 0;
        //if (test1 != null)
        //{
        //    test1 = test1;
        //}
        //else
        //{
        //    test1 = 0;
        //}

        //base.OnInitialized();
    }


    private testModel[] testmodel_;


    protected override async Task OnInitializedAsync()
    {

        //testmodel_ = await TestService.test2(DateTime.Now);
        //testmodel_ = await ForecastService.test2(DateTime.Now);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TestService TestService { get; set; }
    }
}
#pragma warning restore 1591
