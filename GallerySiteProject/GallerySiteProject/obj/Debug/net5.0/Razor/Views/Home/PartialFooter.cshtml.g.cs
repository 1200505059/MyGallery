#pragma checksum "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f8b3c22b1e938dd3df3c77063fd1b0ecacd4e7dd5b0e79cfa64f72013f986fc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialFooter), @"mvc.1.0.view", @"/Views/Home/PartialFooter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f8b3c22b1e938dd3df3c77063fd1b0ecacd4e7dd5b0e79cfa64f72013f986fc2", @"/Views/Home/PartialFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"05a68cace96c85dba20bf7e54ba47cb71153b103f611c332a278dab695be9df4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PartialFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .social-icons {
        list-style: none;
        padding: 0;
        margin: 0;
        display: flex;
        justify-content: center;
        align-items: center;
    }

        .social-icons li {
            margin: 0 10px;
        }

        .social-icons a {
            font-size: 2rem; /* Icon boyutunu büyütmek için */
            color: #000; /* İkon rengi, isteğe bağlı */
            text-decoration: none;
            display: flex; /* Flexbox kullanarak simgeleri ortala */
            justify-content: center; /* Simgeleri yatayda ortala */
            align-items: center; /* Simgeleri dikeyde ortala */
        }

            .social-icons a:hover {
                color: #007bff; /* Hover efekti, isteğe bağlı */
            }

    .footer-grid-left {
        display: flex;
        justify-content: center;
    }
</style>

");
#nullable restore
#line 34 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml"
 foreach (var item in (List<GallerySiteProject.Models.TblGiris>)ViewBag.TBLGİRİS)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <footer class=""py-5"">
        <div class=""container py-md-3"">
            <div class=""row footer-grids justify-content-center"">
                <div class=""col-lg-4 footer-grid-left mb-lg-0 mb-4"">
                    <div class=""social mb-4"">
                        <ul class=""social-icons"">
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1311, "\"", 1340, 1);
#nullable restore
#line 42 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml"
WriteAttributeValue("", 1318, item.GirisFacebookURL, 1318, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\" aria-hidden=\"true\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1468, 1);
#nullable restore
#line 43 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml"
WriteAttributeValue("", 1446, item.GirisLinkedinURL, 1446, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1574, 1);
#nullable restore
#line 44 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml"
WriteAttributeValue("", 1556, item.GirisMailURL, 1556, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-google-plus\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1685, 1);
#nullable restore
#line 45 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml"
WriteAttributeValue("", 1662, item.GirisInstagramURL, 1662, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\" aria-hidden=\"true\"></i></a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n");
#nullable restore
#line 52 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialFooter.cshtml"
}

#line default
#line hidden
#nullable disable
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