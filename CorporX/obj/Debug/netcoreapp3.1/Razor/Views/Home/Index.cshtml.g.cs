#pragma checksum "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ffa339b8f61e6c419b276d9f2786f1b2811957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ffa339b8f61e6c419b276d9f2786f1b2811957", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4121f77ed861cc4ec2fa7e78e642edd65516555", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TeamTwo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CallToAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!--body content wrap start-->\r\n<div class=\"main\">\r\n\r\n    <!--hero section start-->\r\n    <section class=\"hero-equal-height pt-165 pb-100 gradient-overly-right-light\"");
            BeginWriteAttribute("style", " style=\"", 192, "\"", 273, 8);
            WriteAttributeValue("", 200, "background:", 200, 11, true);
            WriteAttributeValue(" ", 211, "url(\'", 212, 6, true);
#nullable restore
#line 8 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
WriteAttributeValue("", 217, Model.HomeHeader.Photo, 217, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 240, "\')no-repeat", 240, 11, true);
            WriteAttributeValue(" ", 251, "center", 252, 7, true);
            WriteAttributeValue(" ", 258, "center", 259, 7, true);
            WriteAttributeValue(" ", 265, "/", 266, 2, true);
            WriteAttributeValue(" ", 267, "cover", 268, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-7 col-lg-6\">\r\n                    <div class=\"hero-slider-content\">\r\n                        <span class=\"text-uppercase\">");
#nullable restore
#line 13 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                Write(Model.HomeHeader.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <h1>");
#nullable restore
#line 14 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeHeader.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"lead\">");
#nullable restore
#line 15 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                   Write(Model.HomeHeader.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        <div class=""action-btns mt-3"">
                            <a href=""#"" class=""btn secondary-solid-btn"">Get Start Now</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--hero section end-->
    <!--promo section start-->
    <section class=""promo-block ptb-100 mt--165 z-index position-relative"">
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 29 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                 foreach (var item in Model.HomePromo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4 col-lg-4"">
                        <div class=""single-promo-block promo-hover-bg-1 hover-image shadow-lg p-5 custom-radius white-bg"">
                            <div class=""promo-block-icon mb-3"">
                                <span");
            BeginWriteAttribute("class", " class=\"", 1501, "\"", 1541, 3);
#nullable restore
#line 34 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
WriteAttributeValue("", 1509, item.Icon, 1509, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1519, "icon-md", 1520, 8, true);
            WriteAttributeValue(" ", 1527, "color-primary", 1528, 14, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                            </div>\r\n                            <div class=\"promo-block-content\">\r\n                                <h5>");
#nullable restore
#line 37 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 38 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                              Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <!--promo section end-->
    <!--about us section start-->
    <section class=""about-us-section pb-100"">
        <div class=""container"">
            <div class=""row justify-content-between align-items-center"">
                <div class=""col-md-12 col-lg-6"">
                    <div class=""video-promo-content mb-md-4 mb-lg-0"">
                        <h2>");
#nullable restore
#line 53 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeAboutUs.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"lead\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeAboutUs.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <ul class=\"list-unstyled tech-feature-list\">\r\n\r\n");
#nullable restore
#line 59 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                             foreach (var item in Model.HomeAboutUs.Text.Split(","))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"py-1\">\r\n                                    <span class=\"ti-control-forward mr-2 color-secondary\"></span>\r\n                                    <strong>");
#nullable restore
#line 63 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                       Write(item.Split(" ")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 64 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                     foreach (var text in @item.Split(" ").Skip(1))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                    Write(text + " ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                     
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </li>\r\n");
#nullable restore
#line 69 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                        <div class=""action-btns mt-4"">
                            <a href=""#"" class=""btn primary-solid-btn mr-2"">View Our Services</a>
                            <a href=""#"" class=""btn outline-btn"">Contact Us</a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 col-lg-6"">
                    <div class=""image-wrap"">
                        <img src=""https://res.cloudinary.com/djsws5hil/image/upload/v1602055675/CorporX/about-img_balshm.jpg"" alt=""video"" class=""img-fluid rounded"">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--about us section end-->
    <!--services section start-->
    <section class=""services-section ptb-100 gray-light-bg"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-8"">
                    <div class=""section-heading text");
            WriteLiteral("-center mb-5\">\r\n                        <h2>");
#nullable restore
#line 92 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeServices.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"lead\">\r\n                            ");
#nullable restore
#line 94 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeServices.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5ffa339b8f61e6c419b276d9f2786f1b281195713947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 99 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ServicesDetails;

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
        </div>
    </section>
    <!--services section end-->
    <!--promo section start-->
    <section class=""promo-section gradient-bg ptb-100"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-9 col-lg-8"">
                    <div class=""app-business-content text-center text-white"">
                        <h2 class=""text-white"">Download Apps Managing Business</h2>
                        <p class=""lead"">
                            Building your Apps busines helps attract more potential clients.
                            Our integrated marketing team will work directly long-term high-impact convergence.
                        </p>

                        <div class=""action-btns mt-5"">
                            <ul class=""list-inline app-download-list"">
                                <li class=""list-inline-item"">
                                    <a href=""#"" class=""d-flex align-items-center border rounded""");
            WriteLiteral(@">
                                        <span class=""fab fa-windows icon-sm mr-3""></span>
                                        <div class=""download-text text-left"">
                                            <span>Download form</span>
                                            <h5 class=""mb-0"">Windows</h5>
                                        </div>
                                    </a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a href=""#"" class=""d-flex align-items-center border rounded"">
                                        <span class=""fab fa-apple icon-sm mr-3""></span>
                                        <div class=""download-text text-left"">
                                            <span>Download form</span>
                                            <h5 class=""mb-0"">App Store</h5>
                                        </div>
                                    </a>
      ");
            WriteLiteral(@"                          </li>
                                <li class=""list-inline-item"">
                                    <a href=""#"" class=""d-flex align-items-center border rounded"">
                                        <span class=""fab fa-google-play icon-sm mr-3""></span>
                                        <div class=""download-text text-left"">
                                            <span>Download form</span>
                                            <h5 class=""mb-0"">Google Play</h5>
                                        </div>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--promo section end-->
    <!--our work or portfolio section start-->
    <section class=""our-portfolio-section ptb-100"">
        <div class=""container"">
            <div class=""row justify-cont");
            WriteLiteral("ent-center\">\r\n                <div class=\"col-lg-8\">\r\n                    <div class=\"section-heading text-center mb-5\">\r\n                        <h2>");
#nullable restore
#line 158 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomePortfolio.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"lead\">\r\n                            ");
#nullable restore
#line 160 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomePortfolio.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5ffa339b8f61e6c419b276d9f2786f1b281195719643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 165 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ProjectDetails;

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
        </div>
    </section>
    <!--our work or portfolio section end-->
    <!--blog section start-->
    <section class=""our-blog-section ptb-100 gray-light-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""section-heading mb-5"">
                        <h2>");
#nullable restore
#line 175 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeBlog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"lead\">\r\n                            ");
#nullable restore
#line 177 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeBlog.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 183 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                 foreach (var item in Model.HomeBlogItem)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-4"">
                        <div class=""single-blog-card card border-0 shadow-sm"">
                            <div class=""blog-img"">
                                <a href=""#""><span class=""category position-absolute"">");
#nullable restore
#line 188 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                                                Write(item.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                                <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 9112, "\"", 9129, 1);
#nullable restore
#line 189 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
WriteAttributeValue("", 9118, item.Photo, 9118, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top position-relative img-fluid\" alt=\"blog\"></a>\r\n                            </div>\r\n                            <div class=\"card-body\">\r\n                                <h3 class=\"h5 mb-2 card-title\"><a href=\"#\">");
#nullable restore
#line 192 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 193 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
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
#line 199 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                               Write(item.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <small>");
#nullable restore
#line 200 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
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
#line 209 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <!--blog section end-->
    <!--testimonial section start-->
    <section class=""testimonial-section ptb-100"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-9 col-lg-8"">
                    <div class=""section-heading mb-5 text-center"">
                        <h2>");
#nullable restore
#line 220 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeTestimonial.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p class=\"lead\">\r\n                            ");
#nullable restore
#line 222 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                       Write(Model.HomeTestimonial);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 229 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                 foreach (var item in Model.HomeTestimonialItem)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"testimonial-single shadow-sm gray-light-bg rounded p-4\">\r\n                            <blockquote>\r\n                                ");
#nullable restore
#line 234 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                           Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </blockquote>
                            <div class=""client-img d-flex align-items-center justify-content-between pt-4"">
                                <div class=""d-flex align-items-center"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 11696, "\"", 11713, 1);
#nullable restore
#line 238 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
WriteAttributeValue("", 11702, item.Photo, 11702, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"client\" width=\"50\" class=\"img-fluid rounded-circle shadow-sm mr-3\" />\r\n                                    <div class=\"client-info\">\r\n                                        <h5 class=\"mb-0\">");
#nullable restore
#line 240 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                    Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <small class=\"mb-0\">");
#nullable restore
#line 241 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                                       Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"client-ratting\">\r\n                                    <ul class=\"list-inline client-ratting-list\">\r\n\r\n");
#nullable restore
#line 247 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                         for (int i = 0; i < item.Star; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"list-inline-item\"><span class=\"fas fa-star ratting-color\"></span></li>\r\n");
#nullable restore
#line 250 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 251 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                         for (int i = 0; i < (5 - item.Star); i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"list-inline-item\"><span class=\"fas fa-star\"></span></li>\r\n");
#nullable restore
#line 254 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                    <span class=""font-weight-bold"">5.0 <small class=""font-weight-lighter"">Out of 5</small></span>
                                </div>
                            </div>
                        </div>

                    </div>
");
#nullable restore
#line 263 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>

        </div>
    </section>
    <!--testimonial section end-->
    <!--team two section start-->
    <section class=""team-two-section ptb-100 gray-light-bg"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-8 col-lg-8"">
                    <div class=""section-heading text-center mb-5"">
                        <h2>Meet Our Lovely Team</h2>
                        <p class=""lead"">
                            Distinctively grow go forward manufactured products and optimal networks. Enthusiastically
                            disseminate user-centric outsourcing.
                        </p>
                    </div>
                </div>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5ffa339b8f61e6c419b276d9f2786f1b281195732588", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 285 "C:\Users\Ceyhun\Desktop\CorporX-Aps.Net-Core-Project\CorporX\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.TeamItems;

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
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n    <!--team two section end-->\r\n\r\n\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f5ffa339b8f61e6c419b276d9f2786f1b281195734263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n<!--body content wrap end-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
