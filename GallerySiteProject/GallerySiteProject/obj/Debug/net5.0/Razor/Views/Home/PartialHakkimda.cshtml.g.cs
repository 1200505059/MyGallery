#pragma checksum "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "033de032eb9b57837204ebbdb2fbd7387086000ff46e32e393b5785318af2ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialHakkimda), @"mvc.1.0.view", @"/Views/Home/PartialHakkimda.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\_ViewImports.cshtml"
using GallerySiteProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\_ViewImports.cshtml"
using GallerySiteProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"033de032eb9b57837204ebbdb2fbd7387086000ff46e32e393b5785318af2ca6", @"/Views/Home/PartialHakkimda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"05a68cace96c85dba20bf7e54ba47cb71153b103f611c332a278dab695be9df4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PartialHakkimda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid img-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .img-fixed {
        width: 100%;
        height: 100%;
        object-fit: cover;
    }

    .image-container {
        width: 300px; /* Sabit genişlik */
        height: 300px; /* Sabit yükseklik */
        border: 3px solid yellow;
        border-radius: 5%;
        overflow: hidden;
        margin: auto; /* Ortalamak için */
    }
</style>

<section class=""about py-5"" id=""hakkimda"">
    <div class=""container py-3"">
");
#nullable restore
#line 20 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml"
         foreach (var item in (List<GallerySiteProject.Models.TblHakkimda>)ViewBag.TBLHAKKIMDA)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row bottom-grids\">\r\n                <div class=\"col-lg-8 bottom-grid1\">\r\n                    <h3 class=\"mb-2\">");
#nullable restore
#line 24 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml"
                                Write(item.HakkimdaBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3>");
#nullable restore
#line 25 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml"
                   Write(item.HakkimdaGiris);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 26 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml"
                  Write(item.HakkimdaText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-6 col-sm-6 mt-lg-0 mt-5 text-center image-container\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "033de032eb9b57837204ebbdb2fbd7387086000ff46e32e393b5785318af2ca66017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 973, "~/Tema/web/images/", 973, 18, true);
#nullable restore
#line 29 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml"
AddHtmlAttributeValue("", 991, item.HakkimdaImageURL, 991, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <br />\r\n");
#nullable restore
#line 34 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialHakkimda.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591