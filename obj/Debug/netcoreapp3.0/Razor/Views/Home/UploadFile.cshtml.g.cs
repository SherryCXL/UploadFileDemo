#pragma checksum "C:\SherryChen\ASP.NET Core\CaseDemo\MVC\MVCDemo3_0\Demo2\Views\Home\UploadFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d36caeeaa76ab92280e11fe57700375ba732678"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UploadFile), @"mvc.1.0.view", @"/Views/Home/UploadFile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d36caeeaa76ab92280e11fe57700375ba732678", @"/Views/Home/UploadFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a340f1bdf4c43f11f91e35b4122951b857fcac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UploadFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\SherryChen\ASP.NET Core\CaseDemo\MVC\MVCDemo3_0\Demo2\Views\Home\UploadFile.cshtml"
  
    ViewData["Title"] = "UploadFile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>UploadFile</h1>\r\n\r\n<th hidden><span id=\"m-aloc-freq\">34</span></th>\r\n<div class=\"input-group\">\r\n    <input type=\"file\" class=\"form-control\" id=\"selectedFile\" name=\"selectedFile\" ");
            WriteLiteral(@">
    <span class=""input-group-btn"">
        <input type=""button"" class=""btn btn-secondary"" value=""Seleciona..."" onclick=""document.getElementById('selectedFile').click();"" />
        <button type=""button"" id=""btnSalvar"" class=""btn btn-primary"">
            UPLOAD ARQUIVO
        </button>
    </span>
</div> 

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    $('#btnSalvar').click(function () {
        debugger;
        var filename = $('input[type=file]').val().split('\\').pop();
            var model = {
                ParentId: $('#m-aloc-freq').text(),
                Imagem:$(""#selectedFile"").val(),
                filename: filename
            };

            try {
                $.ajax({
                    type: 'POST',
                    accepts: ""application/json"",
                    url: ""/v1/ApiPrestador/Upload2"",
                    data: JSON.stringify(model),
                    contentType: ""application/json;"",
                    success: function (data) {
                        console.info(data);
                        alert(""Upload efetuado com sucesso!"");
                        location.reload(true);


                    }
                });
            } catch (e) {
                console.error(e.message);
            }

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