#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35001dd52713a1a5d45b711603e47babf84f0cd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BitpayTranslator), @"mvc.1.0.view", @"/Views/Home/BitpayTranslator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BitpayTranslator.cshtml", typeof(AspNetCore.Views_Home_BitpayTranslator))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer;

#line default
#line hidden
#line 3 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Views;

#line default
#line hidden
#line 4 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models;

#line default
#line hidden
#line 5 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.InvoicingModels;

#line default
#line hidden
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.ManageViewModels;

#line default
#line hidden
#line 8 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.StoreViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35001dd52713a1a5d45b711603e47babf84f0cd9", @"/Views/Home/BitpayTranslator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BitpayTranslator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BitpayTranslatorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qrcode.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 39, true);
            WriteLiteral("\n<section>\n    <div class=\"container\">\n");
            EndContext();
#line 5 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
         if (Model.Address != null)
        {

#line default
#line hidden
            BeginContext(118, 362, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <div class=""alert alert-success alert-dismissible"" role=""alert"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                        <p>You need to pay <b>");
            EndContext();
            BeginContext(481, 12, false);
#line 11 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
                                         Write(Model.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(493, 11, true);
            WriteLiteral("</b> to <b>");
            EndContext();
            BeginContext(505, 13, false);
#line 11 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
                                                                 Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(518, 112, true);
            WriteLiteral("</b></p>\n                        <div id=\"qrCode\"></div>\n                        <div id=\"qrCodeData\" data-url=\"");
            EndContext();
            BeginContext(631, 26, false);
#line 13 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
                                                  Write(Html.Raw(Model.BitcoinUri));

#line default
#line hidden
            EndContext();
            BeginContext(657, 119, true);
            WriteLiteral("\" style=\"margin-bottom:20px;\"></div>\n                        <p>\n                            <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 776, "\"", 800, 1);
#line 15 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
WriteAttributeValue("", 783, Model.BitcoinUri, 783, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(801, 193, true);
            WriteLiteral(">\n                                <span>Open in wallet</span>\n                            </a>\n                        </p>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
        }

#line default
#line hidden
            BeginContext(1004, 548, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <h2 class=""section-heading"">The Bitpay Translator</h2>
                <hr class=""primary"">
                <p>Bitpay is using a deprecated standard in their invoices that most wallets do not support. Use this tool to transform their invoices to a regular address/amount.</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 text-center"">&nbsp;</div>
            <div class=""col-lg-4 text-center"">
                ");
            EndContext();
            BeginContext(1552, 557, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cc1c2da6f6429fbc4da895ebfa12ab", async() => {
                BeginContext(1572, 70, true);
                WriteLiteral("\n                    <div class=\"form-group\">\n                        ");
                EndContext();
                BeginContext(1642, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02647ca9ac3b401b976a3f16b0ec2823", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 35 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BitpayLink);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1700, 26, true);
                WriteLiteral("*\n                        ");
                EndContext();
                BeginContext(1726, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef6a309155a94854ae24a0e63a946652", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 36 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BitpayLink);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1777, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1802, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d67ec22b5e243c2ab71c56e073aba75", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 37 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BitpayLink);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1867, 235, true);
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <button type=\"submit\" class=\"btn btn-secondary\" title=\"Continue\">Translate to address</button>\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2109, 117, true);
            WriteLiteral("\n            </div>\n            <div class=\"col-lg-4 text-center\">&nbsp;</div>\n        </div>\n    </div>\n</section>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2244, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2250, 52, false);
#line 50 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2302, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2307, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2e4a18e5374185bf72a8eba81613eb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2372, 128, true);
                WriteLiteral("\n    <script type=\"text/javascript\">\n        new QRCode(document.getElementById(\"qrCode\"),\n            {\n                text: \"");
                EndContext();
                BeginContext(2501, 26, false);
#line 55 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\BitpayTranslator.cshtml"
                  Write(Html.Raw(Model.BitcoinUri));

#line default
#line hidden
                EndContext();
                BeginContext(2527, 143, true);
                WriteLiteral("\",\n                width: 150,\n                height: 150\n            });\n        $(\"#qrCode > img\").css({ \"margin\": \"auto\" });\n    </script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BitpayTranslatorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
