#pragma checksum "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Shared\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4671ed4aced227ceebe09981297779cd85cc555c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NotFound), @"mvc.1.0.view", @"/Views/Shared/NotFound.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4671ed4aced227ceebe09981297779cd85cc555c", @"/Views/Shared/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c9e0ff5044c8d5e07eb25f0a6ad06b16e9cc2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Shared\NotFound.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>I guess something went wrong.</h1>\r\n<h3> By the way it was error <span class=\"error\">");
#nullable restore
#line 7 "C:\C#\WebGame_database\FileZillaLinuxGame\WebGame_school_AND_BLAZOR_20_Layout_in_the_middle\Views\Shared\NotFound.cshtml"
                                            Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"face\">._.</span> </h3>\r\n\r\n<style>\r\n    .error {\r\n        color: red;\r\n    }\r\n\r\n    .face {\r\n        color: white;\r\n    }\r\n</style>");
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
