#pragma checksum "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d50a05f01d34a196380c99fb07577cce349cd83d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 31 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
using KimiaCharm.Compontents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50a05f01d34a196380c99fb07577cce349cd83d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00fe87962dac3e71cf20e9d17e68ede7b5825363", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"fa\" dir=\"rtl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a05f01d34a196380c99fb07577cce349cd83d4671", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 189, "\"", 231, 1);
#nullable restore
#line 6 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 199, ViewData["DescriptionMetaData"], 199, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 260, "\"", 297, 1);
#nullable restore
#line 7 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 270, ViewData["AuthorMetaData"], 270, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <title>");
#nullable restore
#line 8 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.rtl.min.css"" integrity=""sha384-gXt9imSW0VcJVHezoNQsP+TNrjYXoGcrqBZJpry9zJt8PCQjobwmhMGaDHTASo9N"" crossorigin=""anonymous"">        <!-- Core theme CSS (includes Bootstrap)-->
    <link href=""/css/styles.css"" rel=""stylesheet"" />
    <link href=""https://cdn.jsdelivr.net/gh/rastikerdar/vazir-font@v30.1.0/dist/font-face.css"" rel=""stylesheet"" type=""text/css"" />
    <link rel=""stylesheet"" href=""/css/site.css"" />
    <link rel=""icon"" type=""image/x-icon"" href=""/assets/favicon.ico"" />
    <!--Font awesome link-->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" integrity=""sha512-9usAa10IRO0HhonpyAIVpjrylPvoDwiPUiKdWk5t3PyolY1cOd4DSE0Ga+ri4AuTroPR5aQvXU9xC6qOPnzFeg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a05f01d34a196380c99fb07577cce349cd83d7762", async() => {
                WriteLiteral(@"
    <!-- Navigation-->
    <!-- Navigation-->
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""container px-4 px-lg-5"">
            <a class=""navbar-brand"" href=""#!"">کیمیاچرم</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation""><span class=""navbar-toggler-icon""></span></button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0 ms-lg-4"">
                    <li class=""nav-item""><a");
                BeginWriteAttribute("href", " href=\"", 1923, "\"", 1930, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\"><i class=\"fa-brands fa-instagram\"></i></a></li>\r\n                    <li class=\"nav-item\"><a");
                BeginWriteAttribute("href", " href=\"", 2041, "\"", 2048, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link""><i class=""fa-solid fa-paper-plane""></i></a></li>

                    <li class=""nav-item""><a class=""nav-link active"" aria-current=""page"" href=""#!"">خانه</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""#!"">درباره</a></li>
");
                WriteLiteral("                    ");
#nullable restore
#line 32 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
               Write(await Component.InvokeAsync("ShowCategories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </ul>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a05f01d34a196380c99fb07577cce349cd83d9802", async() => {
                    WriteLiteral(@"
                    <button class=""btn btn-outline-dark"" type=""submit"">
                        <i class=""bi-cart-fill me-1""></i>
                        سبد خرید
                        <span class=""badge bg-dark text-white ms-1 rounded-pill"">0</span>
                    </button>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    <!-- Header-->\r\n    <header class=\"bg-dark py-5\">\r\n        <div class=\"container px-4 px-lg-5 my-5\">\r\n            <div class=\"text-center text-white\">\r\n                <h1 class=\"display-4 fw-bolder\">");
#nullable restore
#line 48 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
                                           Write(ViewData["h1"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <p class=\"lead fw-normal text-white-50 mb-0\">");
#nullable restore
#line 49 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
                                                        Write(ViewData["h1Description"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <section class=\"py-5\">\r\n        <div class=\"container px-4 px-lg-5 mt-5\">\r\n            ");
#nullable restore
#line 55 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </section>

    <footer class=""py-5 bg-dark"">
        <div class=""container""><p class=""text-center text-white"">کپی رایت &copy; کیمیاچرم 1400</p></div>
    </footer>
    <!-- Bootstrap core JS-->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>
    <!-- Core theme JS-->
    <script src=""/js/scripts.js""></script>
    <!--Font awesome JS-->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/js/all.min.js"" integrity=""sha512-yFjZbTYRCJodnuyGlsKamNE/LlEaEAxSUDe5+u61mV8zzqJVFOH7TnULE2/PP/l5vKWpUNnF4VGVkXh3MjgLsg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""/lib/jquery/dist/jquery.min.js""></script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a05f01d34a196380c99fb07577cce349cd83d13536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 70 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 71 "K:\projects\KimiaCharm\KimiaCharm\KimiaCharm\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
