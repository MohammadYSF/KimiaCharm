#pragma checksum "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc317ddf5a1b74b8f4fc4605de8dada81996a5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProductsByCategoryID), @"mvc.1.0.view", @"/Views/Product/ShowProductsByCategoryID.cshtml")]
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
#line 1 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\_ViewImports.cshtml"
using KimiaCharm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\_ViewImports.cshtml"
using KimiaCharm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\_ViewImports.cshtml"
using DataLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc317ddf5a1b74b8f4fc4605de8dada81996a5b", @"/Views/Product/ShowProductsByCategoryID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00fe87962dac3e71cf20e9d17e68ede7b5825363", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProductsByCategoryID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark mt-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Single", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
  
    ViewData["Title"] = Model.First().Category.Name;
    ViewData["h1"] = "دسته بندی " + Model.First().Category.Name;
    ViewData["h1Description"] = Model.Count() + " کالا در دسته بندی " + ViewData["Title"] + " قرار  دارد";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center\">\r\n\r\n");
#nullable restore
#line 9 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
     foreach (Product item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col mb-5\">\r\n            <div class=\"card h-100\">\r\n                <!-- Product image-->\r\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 613, 2);
            WriteAttributeValue("", 561, "/img/productImages/450x300/", 561, 27, true);
#nullable restore
#line 14 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
WriteAttributeValue("", 588, item.HorizontalImageName, 588, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 614, "\"", 630, 1);
#nullable restore
#line 14 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
WriteAttributeValue("", 620, item.Name, 620, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <!-- Product details-->\r\n                <div class=\"card-body p-4\">\r\n                    <div class=\"text-center\">\r\n                        <!-- Product name-->\r\n                        <h5 class=\"fw-bolder\">");
#nullable restore
#line 19 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <!-- Product price-->\r\n                        ");
#nullable restore
#line 21 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                    </div>\r\n                </div>\r\n                <!-- Product actions-->\r\n                <div class=\"card-footer p-4 pt-0 border-top-0 bg-transparent\">\r\n                    <div class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc317ddf5a1b74b8f4fc4605de8dada81996a5b7124", async() => {
                WriteLiteral("جزئیات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"
                                                                          WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Product\ShowProductsByCategoryID.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
