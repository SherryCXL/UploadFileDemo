#pragma checksum "C:\SherryChen\ASP.NET Core\CaseDemo\MVC\MVCDemo3_0\Demo2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a1fb01a1a4998a1d8bf42d68c5fa2cf3f5ea8e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\SherryChen\ASP.NET Core\CaseDemo\MVC\MVCDemo3_0\Demo2\Views\_ViewImports.cshtml"
using Demo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SherryChen\ASP.NET Core\CaseDemo\MVC\MVCDemo3_0\Demo2\Views\_ViewImports.cshtml"
using Demo2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a1fb01a1a4998a1d8bf42d68c5fa2cf3f5ea8e9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a340f1bdf4c43f11f91e35b4122951b857fcac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\SherryChen\ASP.NET Core\CaseDemo\MVC\MVCDemo3_0\Demo2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<button id=""btnClick"">Click</button>
<div id=""showError"">

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $(""#btnClick"").click(function () {
        $.ajax({
            type: ""Get"",
            url: ""http://localhost:64826/api/Values/GetTestValue/1"",
            //url: ""http://localhost:64104/api/test/GetTestValue/1"",
            success: function () {
                alert(""Ok!"");
            },
            error: function (result) {
                $(""#showError"").html(result);
            }
        })
    });
    </script>
");
            }
            );
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
