#pragma checksum "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Shared\Components\FooterComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6bf054fab76b8dafcb880a32a096851eb08a86b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FooterComponent/Default.cshtml")]
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
#line 1 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\_ViewImports.cshtml"
using CorporX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\_ViewImports.cshtml"
using CorporX.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6bf054fab76b8dafcb880a32a096851eb08a86b", @"/Views/Shared/Components/FooterComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4121f77ed861cc4ec2fa7e78e642edd65516555", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CorporX.Models.Home.Setting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<li class=\"d-flex align-items-center py-2\"><span class=\"fas fa-map-marker-alt mr-2\"></span> ");
#nullable restore
#line 4 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                                       Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n<li class=\"d-flex align-items-center py-2\"><span class=\"fas fa-envelope mr-2\"></span> ");
#nullable restore
#line 5 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                                 Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n<li class=\"d-flex align-items-center py-2\"><span class=\"fas fa-phone-alt mr-2\"></span> ");
#nullable restore
#line 6 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Shared\Components\FooterComponent\Default.cshtml"
                                                                                  Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CorporX.Models.Home.Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591
