#pragma checksum "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5f639f99351d48923e644570ae39b0b542fcd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Summary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Summary/Default.cshtml")]
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
#line 1 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a5f639f99351d48923e644570ae39b0b542fcd7", @"/Views/Shared/Components/Summary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a1c0f57ef05a603fac9e43d1c0fd8ed8fcf383", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Summary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (ViewData.ModelState.ErrorCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding-top: 15px;\"></div>\r\n");
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\" style=\"padding-top: 20px\">Opa! Algo deu errado :(</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a5f639f99351d48923e644570ae39b0b542fcd74376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Sucesso))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding-top: 15px\"></div>\r\n");
            WriteLiteral("    <div id=\"msg_box\" class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h3 id=\"msgRetorno\">");
#nullable restore
#line 20 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
                       Write(ViewBag.Sucesso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 22 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
}


#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Sucesso"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding-top: 15px\"></div>\r\n");
            WriteLiteral("    <div id=\"msg_box\" class=\"alert alert-success\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">×</button>\r\n        <h4 id=\"msgRetorno\">");
#nullable restore
#line 31 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
                       Write(Html.Raw(TempData["Sucesso"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n");
#nullable restore
#line 33 "D:\Repositórios Visual Studio 2019\Desenvolvedor.io\MinhaAppMvcCompleta\src\DevIO.App\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
