#pragma checksum "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebf905282289f9a3c58a5685051bee8a26c9b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Controller2_SimpleBinding), @"mvc.1.0.view", @"/Views/Controller2/SimpleBinding.cshtml")]
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
#line 1 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\_ViewImports.cshtml"
using Lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\_ViewImports.cshtml"
using Lab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebf905282289f9a3c58a5685051bee8a26c9b83", @"/Views/Controller2/SimpleBinding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd9d6898af3ee645766c02769f00bd7edd74cd52", @"/Views/_ViewImports.cshtml")]
    public class Views_Controller2_SimpleBinding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab2.Models.Model1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
  
    ViewData["Title"] = "SimpleBinding";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SimpleBinding</h1>\r\n\r\n");
#nullable restore
#line 11 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 14 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.LabelFor(m => m.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.TextBoxFor(m => m.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.ValidationMessageFor(m => m.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 19 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 24 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.LabelFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.TextBoxFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 26 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
   Write(Html.ValidationMessageFor(m => m.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 29 "G:\BscCsit\sem6\NCC\assignments\Lab2\Views\Controller2\SimpleBinding.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab2.Models.Model1> Html { get; private set; }
    }
}
#pragma warning restore 1591
