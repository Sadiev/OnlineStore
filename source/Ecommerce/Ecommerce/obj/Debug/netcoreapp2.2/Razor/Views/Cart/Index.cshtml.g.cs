#pragma checksum "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e990a774a52ae5307b58914fd3482d9d3a9cd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#line 3 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Data;

#line default
#line hidden
#line 5 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e990a774a52ae5307b58914fd3482d9d3a9cd8", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffab0a037c79b901089eecb3531e7962ffc3fc6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("prewiew"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("138"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(68, 230, true);
            WriteLiteral("\r\n<div class=\"card shopping-cart\">\r\n    <div class=\"card-header bg-dark text-light\">\r\n        <i class=\"fa fa-shopping-cart\" aria-hidden=\"true\"></i>\r\n        Shipping cart\r\n        <a class=\"btn btn-outline-info btn-sm pull-right\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 298, "\"", 321, 1);
#line 10 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 305, Model.ReturnUrl, 305, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 103, true);
            WriteLiteral(">Continiu shopping</a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
            EndContext();
#line 14 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
            BeginContext(485, 150, true);
            WriteLiteral("            <!-- PRODUCT -->\r\n            <div class=\"row\">\r\n                <div class=\"col-12 col-sm-12 col-md-2 text-center\">\r\n                    ");
            EndContext();
            BeginContext(635, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "68e990a774a52ae5307b58914fd3482d9d3a9cd88511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 668, "~/img/700x400/", 668, 14, true);
#line 19 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 682, line.Product.ProductID, 682, 25, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 707, ".jpg", 707, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(751, 164, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-12 text-sm-center col-sm-12 text-md-left col-md-6\">\r\n                    <h4 class=\"product-name\"><strong>");
            EndContext();
            BeginContext(916, 24, false);
#line 22 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
                                                Write(line.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(940, 73, true);
            WriteLiteral("</strong></h4>\r\n                    <h4>\r\n                        <small>");
            EndContext();
            BeginContext(1014, 24, false);
#line 24 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
                          Write(line.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 285, true);
            WriteLiteral(@"</small>
                    </h4>
                </div>
                <div class=""col-12 col-sm-12 text-sm-center col-md-4 text-md-right row"">
                    <div class=""col-3 col-sm-3 col-md-6 text-md-right"" style=""padding-top: 5px"">
                        <h6><strong>");
            EndContext();
            BeginContext(1324, 32, false);
#line 29 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
                               Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 470, true);
            WriteLiteral(@"</strong></h6>
                    </div>
                    <div class=""col-4 col-sm-4 col-md-4"">
                        <div class=""quantity"">                  
                            <input type=""number"" step=""1"" max=""99"" min=""1"" value=""1"" title=""Qty""  class=""qty"" size=""4"">                          
                        </div>
                    </div>
                    <div class=""col-2 col-sm-2 col-md-2 text-right"">
                        ");
            EndContext();
            BeginContext(1826, 487, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68e990a774a52ae5307b58914fd3482d9d3a9cd812684", async() => {
                BeginContext(1874, 67, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ProductID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1941, "\"", 1972, 1);
#line 38 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1949, line.Product.ProductID, 1949, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1973, 70, true);
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2043, "\"", 2067, 1);
#line 39 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2051, Model.ReturnUrl, 2051, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2068, 238, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-outline-danger btn-xs\">\r\n                                <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                            </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2313, 152, true);
            WriteLiteral("\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <hr>\r\n            <!-- END PRODUCT -->\r\n");
            EndContext();
#line 50 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2476, 114, true);
            WriteLiteral("        </div>\r\n    <div class=\"card-footer\">\r\n        <div class=\"pull-right\" style=\"margin: 10px\">\r\n            ");
            EndContext();
            BeginContext(2590, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68e990a774a52ae5307b58914fd3482d9d3a9cd816342", async() => {
                BeginContext(2672, 8, true);
                WriteLiteral("Checkout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2684, 92, true);
            WriteLiteral("\r\n            <div class=\"pull-right\" style=\"margin: 5px\">\r\n                Total price: <b>");
            EndContext();
            BeginContext(2777, 44, false);
#line 56 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Cart\Index.cshtml"
                           Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 64, true);
            WriteLiteral("</b>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
