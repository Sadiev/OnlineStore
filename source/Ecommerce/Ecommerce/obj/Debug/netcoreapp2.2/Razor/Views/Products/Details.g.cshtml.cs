#pragma checksum "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "221a98480a96ac5fb7c3ded31b7f3ecf1683d8f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"221a98480a96ac5fb7c3ded31b7f3ecf1683d8f5", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffab0a037c79b901089eecb3531e7962ffc3fc6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(59, 1954, true);
            WriteLiteral(@"
<!-- Navigation -->
<nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""#"">Start Bootstrap</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
            <ul class=""navbar-nav ml-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">
                        Home
                        <span class=""sr-only"">(current)</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">About</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Servic");
            WriteLiteral(@"es</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Contact</a>
                </li>
            </ul>
        </div>
    </div>
</nav>

<!-- Page Content -->
<div class=""container"">

    <div class=""row"">

        <div class=""col-lg-3"">
            <h1 class=""my-4"">Shop Name</h1>
            <div class=""list-group"">
                <a href=""#"" class=""list-group-item active"">Category 1</a>
                <a href=""#"" class=""list-group-item"">Category 2</a>
                <a href=""#"" class=""list-group-item"">Category 3</a>
            </div>
        </div>
        <!-- /.col-lg-3 -->

        <div class=""col-lg-9"">

            <div class=""card mt-4"">
                <img class=""card-img-top img-fluid"" src=""http://placehold.it/900x400"" alt="""">
                <div class=""card-body"">
                    <h3 class=""card-title"">");
            EndContext();
            BeginContext(2014, 17, false);
#line 55 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Products\Details.cshtml"
                                      Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2031, 31, true);
            WriteLiteral("</h3>\r\n                    <h4>");
            EndContext();
            BeginContext(2063, 11, false);
#line 56 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Products\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2074, 48, true);
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(2123, 17, false);
#line 57 "C:\Users\dilsh\source\repos\OnlineStore\source\Ecommerce\Ecommerce\Views\Products\Details.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2140, 1776, true);
            WriteLiteral(@"</p>
                    <span class=""text-warning"">&#9733; &#9733; &#9733; &#9733; &#9734;</span>
                    4.0 stars
                </div>
            </div>
            <!-- /.card -->

            <div class=""card card-outline-secondary my-4"">
                <div class=""card-header"">
                    Product Reviews
                </div>
                <div class=""card-body"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                    <small class=""text-muted"">Posted by Anonymous on 3/1/17</small>
                    <hr>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatib");
            WriteLiteral(@"us quae sint natus.</p>
                    <small class=""text-muted"">Posted by Anonymous on 3/1/17</small>
                    <hr>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                    <small class=""text-muted"">Posted by Anonymous on 3/1/17</small>
                    <hr>
                    <a href=""#"" class=""btn btn-success"">Leave a Review</a>
                </div>
            </div>
            <!-- /.card -->

        </div>
        <!-- /.col-lg-9 -->

    </div>

</div>
<!-- /.container -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
