#pragma checksum "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "240f6034ff6427621f5a346480d7f3834765bb04e29c9868709a2ae357b8965f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PartialGiris), @"mvc.1.0.view", @"/Views/Home/PartialGiris.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"240f6034ff6427621f5a346480d7f3834765bb04e29c9868709a2ae357b8965f", @"/Views/Home/PartialGiris.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"05a68cace96c85dba20bf7e54ba47cb71153b103f611c332a278dab695be9df4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PartialGiris : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""slider"" style=""background-image:url('~/Tema/web/images/Ben.jpg')"">
    <div class=""callbacks_container"">
        <ul class=""rslides callbacks callbacks1"" id=""slider4"">
            <li>
                <div class=""w3layouts-banner-top"">
                    <div class=""banner-dott"">
                        <div class=""container"">
");
#nullable restore
#line 9 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
                             foreach (var item in (List<GallerySiteProject.Models.TblGiris>)ViewBag.TBLGİRİS)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"padding\">\r\n                                    <div class=\"agileits-banner-info\">\r\n                                        <p>");
#nullable restore
#line 13 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
                                      Write(item.GirisAdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <h2 class=\"second\">");
#nullable restore
#line 14 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
                                                      Write(item.GirisAciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    </div>\r\n                                    <ul class=\"social text-center mt-sm-5 mt-3\">\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 944, "\"", 973, 1);
#nullable restore
#line 17 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
WriteAttributeValue("", 951, item.GirisFacebookURL, 951, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\" aria-hidden=\"true\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1113, 1);
#nullable restore
#line 18 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
WriteAttributeValue("", 1091, item.GirisLinkedinURL, 1091, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1231, 1);
#nullable restore
#line 19 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
WriteAttributeValue("", 1213, item.GirisMailURL, 1213, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-google-plus\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1324, "\"", 1354, 1);
#nullable restore
#line 20 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
WriteAttributeValue("", 1331, item.GirisInstagramURL, 1331, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\" aria-hidden=\"true\"></i></a></li>\r\n                                    </ul>\r\n                                </div>\r\n");
#nullable restore
#line 23 "C:\Users\pc\Desktop\E-Commerce\GallerySiteProject\GallerySiteProject\Views\Home\PartialGiris.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"clearfix\"></div>\r\n</div>");
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
