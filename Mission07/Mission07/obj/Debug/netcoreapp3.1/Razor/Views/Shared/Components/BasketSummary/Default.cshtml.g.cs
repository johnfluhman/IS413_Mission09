#pragma checksum "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/Shared/Components/BasketSummary/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11361f3f4b7cf1d9c9c1858381e4f33a739202e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mission07.Views.Shared.Components.BasketSummary.Views_Shared_Components_BasketSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BasketSummary/Default.cshtml")]
namespace Mission07.Views.Shared.Components.BasketSummary
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
#line 2 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/_ViewImports.cshtml"
using Mission07.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/_ViewImports.cshtml"
using Mission07.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/_ViewImports.cshtml"
using Mission07.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11361f3f4b7cf1d9c9c1858381e4f33a739202e1", @"/Views/Shared/Components/BasketSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a07ae17c10cb4250c82a3eeb8393680ad9752897", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BasketSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Basket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary navbar-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n<div");
            BeginWriteAttribute("class", " class=\"", 25, "\"", 33, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 7 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/Shared/Components/BasketSummary/Default.cshtml"
     if (Model.Items.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <small class=\"navbar-text\">\n            <b>Your cart:</b>\n            ");
#nullable restore
#line 11 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/Shared/Components/BasketSummary/Default.cshtml"
       Write(Model.Items.Sum(x => x.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" item(s)\n            ");
#nullable restore
#line 12 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/Shared/Components/BasketSummary/Default.cshtml"
       Write(Model.CalculateTotal().ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </small>\n");
#nullable restore
#line 14 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/Shared/Components/BasketSummary/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11361f3f4b7cf1d9c9c1858381e4f33a739202e15775", async() => {
                WriteLiteral("\n        <i class=\"fa fa-shopping-cart\"></i>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "/Users/johnfluhman/Documents/GitHub/IS413_Mission09/Mission07/Mission07/Views/Shared/Components/BasketSummary/Default.cshtml"
                WriteLiteral(ViewContext.HttpContext.Request.PathAndQuery());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Basket> Html { get; private set; }
    }
}
#pragma warning restore 1591
