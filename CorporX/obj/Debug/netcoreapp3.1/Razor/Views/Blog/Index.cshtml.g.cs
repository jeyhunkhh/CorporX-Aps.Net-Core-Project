#pragma checksum "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "293751dc968678d448b579064556a8b698261df8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293751dc968678d448b579064556a8b698261df8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4121f77ed861cc4ec2fa7e78e642edd65516555", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Breadcrumb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--body content wrap start-->\r\n<div class=\"main\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "293751dc968678d448b579064556a8b698261df84534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.BreadcrumbViewModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!--blog section start-->
    <section class=""our-blog-section ptb-100 gray-light-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""section-heading mb-5"">
                        <h2>Our Latest News</h2>
                        <p class=""lead"">
                            Enthusiastically drive revolutionary opportunities before emerging leadership. Phosfluorescently cultivate emerging alignments time methods of empowerment.
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 20 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                 foreach (var item in Model.HomeBlogItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-4"">
                        <div class=""single-blog-card card border-0 shadow-sm"">
                            <div class=""blog-img"">
                                <a href=""#""><span class=""category position-absolute"">");
#nullable restore
#line 25 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                                                                Write(item.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                                <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1229, "\"", 1246, 1);
#nullable restore
#line 26 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1235, item.Photo, 1235, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top position-relative img-fluid\" alt=\"blog\"></a>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <h3 class=\"h5 mb-2 card-title\"><a href=\"#\">");
#nullable restore
#line 29 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 30 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                                Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                            <div class=""card-footer border-0 d-flex align-items-center justify-content-between"">
                                <div class=""author-meta d-flex align-items-center"">
                                    <span class=""fa fa-user mr-2 p-3 bg-white rounded-circle border""></span>
                                    <div class=""author-content"">
                                        <a href=""#"" class=""d-block"">");
#nullable restore
#line 36 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                                               Write(item.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <small>");
#nullable restore
#line 37 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                          Write(item.AddDateTime.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    </div>
                                </div>
                                <div class=""author-like"">
                                    <a href=""#""><span class=""fa fa-share-alt""></span> 50</a>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 46 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>


            <!--pagination start-->
            <div class=""row"">
                <div class=""col-md-12"">
                    <nav class=""custom-pagination-nav mt-4"">
                        <ul class=""pagination justify-content-center"">
                            <li class=""page-item""><a class=""page-link"" href=""#""><span class=""ti-angle-left""></span></a></li>
");
#nullable restore
#line 56 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                             for (int i = 0; i < (decimal)ViewData["Pagecount"]; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "293751dc968678d448b579064556a8b698261df811505", async() => {
#nullable restore
#line 59 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-p", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                                                                                                    WriteLiteral(i+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["p"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-p", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["p"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 61 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Blog\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""page-item""><a class=""page-link"" href=""#""><span class=""ti-angle-right""></span></a></li>
                        </ul>
                    </nav>
                </div>
            </div>
            <!--pagination end-->

        </div>
    </section>
    <!--blog section end-->

</div>
<!--body content wrap end-->


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
