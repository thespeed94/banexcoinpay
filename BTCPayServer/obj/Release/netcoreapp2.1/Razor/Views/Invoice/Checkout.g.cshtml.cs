#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d0f4bafd86edfab74245d970f4e961b3999ad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Checkout), @"mvc.1.0.view", @"/Views/Invoice/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Checkout.cshtml", typeof(AspNetCore.Views_Invoice_Checkout))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\_ViewImports.cshtml"
using BTCPayServer.Services.Invoices;

#line default
#line hidden
#line 3 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 4 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d0f4bafd86edfab74245d970f4e961b3999ad8", @"/Views/Invoice/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5213ff0c5a2def479a48eadb1e89f022778c0651", @"/Views/Invoice/_ViewImports.cshtml")]
    public class Views_Invoice_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "wwwroot/bundles/checkout-bundle.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "wwwroot/bundles/checkout-bundle.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Checkout-Body", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cmblang reverse invisible"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("changeLanguage($(this).val())"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::BundlerMinifier.TagHelpers.BundleTagHelper __BundlerMinifier_TagHelpers_BundleTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(197, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(220, 951, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c0d1b4b7fc8454c9c0dbb62e5d8c3d1", async() => {
                BeginContext(226, 254, true);
                WriteLiteral("\n    <meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\n    <META NAME=\"robots\" CONTENT=\"noindex,nofollow\">\n    <title>");
                EndContext();
                BeginContext(481, 15, false);
#line 17 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
      Write(Model.HtmlTitle);

#line default
#line hidden
                EndContext();
                BeginContext(496, 14, true);
                WriteLiteral("</title>\n\n    ");
                EndContext();
                BeginContext(510, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84f5c75c15d940e39e3afb90507fbadd", async() => {
                }
                );
                __BundlerMinifier_TagHelpers_BundleTagHelper = CreateTagHelper<global::BundlerMinifier.TagHelpers.BundleTagHelper>();
                __tagHelperExecutionContext.Add(__BundlerMinifier_TagHelpers_BundleTagHelper);
                __BundlerMinifier_TagHelpers_BundleTagHelper.BundleName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(567, 61, true);
                WriteLiteral("\n\n    <script type=\"text/javascript\">\n        var srvModel = ");
                EndContext();
                BeginContext(629, 31, false);
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
                  Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
                EndContext();
                BeginContext(660, 21, true);
                WriteLiteral(";\n    </script>\n\n    ");
                EndContext();
                BeginContext(681, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b0ae1267af0457ea11dc5ae5dde88d6", async() => {
                }
                );
                __BundlerMinifier_TagHelpers_BundleTagHelper = CreateTagHelper<global::BundlerMinifier.TagHelpers.BundleTagHelper>();
                __tagHelperExecutionContext.Add(__BundlerMinifier_TagHelpers_BundleTagHelper);
                __BundlerMinifier_TagHelpers_BundleTagHelper.BundleName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(737, 73, true);
                WriteLiteral("\n    <script>vex.defaultOptions.className = \'vex-theme-btcpay\'</script>\n\n");
                EndContext();
#line 28 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
     if (Model.CustomCSSLink != null)
    {

#line default
#line hidden
                BeginContext(854, 13, true);
                WriteLiteral("        <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 867, "\"", 894, 1);
#line 30 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
WriteAttributeValue("", 874, Model.CustomCSSLink, 874, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(895, 21, true);
                WriteLiteral(" rel=\"stylesheet\" />\n");
                EndContext();
#line 31 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
    }

#line default
#line hidden
                BeginContext(922, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 33 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
     if (Model.IsModal)
    {

#line default
#line hidden
                BeginContext(953, 205, true);
                WriteLiteral("        <style type=\"text/css\">\n            body {\n                background: rgba(55, 58, 60, 0.4);\n            }\n\n            .close-icon {\n                display: flex;\n            }\n        </style>\n");
                EndContext();
#line 44 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(1171, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1172, 5609, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf247f9917c40feb0f8d8ff037b37ac", async() => {
                BeginContext(1178, 350, true);
                WriteLiteral(@"
    <noscript>
        <center style=""padding: 2em"">
            <h2>Javascript está actualmente desactivado en tu navegador.</h2>
            <h5>Por favor, active Javascript y actualice esta página para la mejor experiencia.</h5>

            <p>O bien, haga clic a continuación para continuar con nuestra factura solo en HTML.</p>

            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1528, "\"", 1572, 2);
                WriteAttributeValue("", 1535, "/invoice-noscript?id=", 1535, 21, true);
#line 54 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
WriteAttributeValue("", 1556, Model.InvoiceId, 1556, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1573, 846, true);
                WriteLiteral(@" style=""text-decoration: underline; color: blue"">
                Continuar a la factura deshabilitada de javascript &gt;
            </a>
        </center>
    </noscript>

    <!--[if lte IE 8]>
    <center style=""padding: 2em"">
      <form action=""/invoice-noscript"" method=""GET"">
        <button style=""text-decoration: underline; color: blue"">Continue to legacy browser compatible invoice page
        </button>
      </form>
    </center>
    <![endif]-->

    <invoice>
        <div class=""no-bounce"" id=""checkoutCtrl"" v-cloak>
            <div class=""modal page"">
                <div class=""modal-dialog open opened enter-purchaser-email"" role=""document"">
                    <div class=""modal-content long"">
                        <div class=""content"">
                            <div class=""invoice"">
                                ");
                EndContext();
                BeginContext(2419, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c80a4c3d7a740aa80fa806ccc792d40", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2451, 167, true);
                WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n\n                    <div style=\"margin-top: 10px; text-align: center;\">\n");
                EndContext();
                BeginContext(2789, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(2814, 334, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f45b0eae5547458e43ae204142e8a4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 86 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DefaultLang);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 89 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = langService.GetLanguages().Select((language) => new SelectListItem(language.DisplayName,language.Code, false));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3148, 1360, true);
                WriteLiteral(@"

                        <script>
                            var languageSelectorPrettyDropdown;
                            $(function () {
                                // REVIEW: don't use initDropdown method but rather directly initialize select whenever you are using it
                                $(""#DefaultLang"").val(startingLanguage);
                                languageSelectorPrettyDropdown = initDropdown(""#DefaultLang"");
                            });

                            function initDropdown(selector) {
                                return $(selector).prettyDropdown({
                                    classic: false,
                                    height: 32,
                                    reverse: true,
                                    hoverIntent: 5000
                                });
                            }
                        </script>
                    </div>
                    <div style=""margin-top: 10px; text-align: center;"" class=""for");
                WriteLiteral(@"m-text small text-muted"">
                        <span>Impulsado por <a target=""_blank"" href=""https://github.com/btcpayserver/btcpayserver"">BANEXCOINPAY Server</a></span>
                    </div>
                </div>
            </div>
        </div>
    </invoice>
    <script type=""text/javascript"">
    var availableLanguages = ");
                EndContext();
                BeginContext(4509, 88, false);
#line 117 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
                        Write(Html.Raw(Json.Serialize(langService.GetLanguages().Select((language) => language.Code))));

#line default
#line hidden
                EndContext();
                BeginContext(4597, 31, true);
                WriteLiteral(";;\n    var storeDefaultLang = \"");
                EndContext();
                BeginContext(4629, 17, false);
#line 118 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
                       Write(Model.DefaultLang);

#line default
#line hidden
                EndContext();
                BeginContext(4646, 227, true);
                WriteLiteral("\";\n    var fallbackLanguage = \"en\";\n    startingLanguage = computeStartingLanguage();\n      // initialization\n    i18next\n        .use(window.i18nextXHRBackend)\n        .init({\n            backend: {\n                loadPath: \'");
                EndContext();
                BeginContext(4875, 14, false);
#line 126 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Checkout.cshtml"
                       Write(Model.RootPath);

#line default
#line hidden
                EndContext();
                BeginContext(4890, 1884, true);
                WriteLiteral(@"locales/{{lng}}.json'
            },
            lng: startingLanguage,
            fallbackLng: fallbackLanguage,
            nsSeparator: false,
            keySeparator: false
        });

    function computeStartingLanguage() {
        if (urlParams.lang && isLanguageAvailable(urlParams.lang)) {
            return urlParams.lang;
        }
        else if (isLanguageAvailable(storeDefaultLang)) {
            return storeDefaultLang;
        } else {
            return fallbackLanguage;
        }
    }

    function changeLanguage(lang) {
        if (isLanguageAvailable(lang)) {
            i18next.changeLanguage(lang);
        }
    }

    function isLanguageAvailable(languageCode) {
        return availableLanguages.indexOf(languageCode) >= 0;
    }

    const i18n = new VueI18next(i18next);

    // TODO: Move all logic from core.js to Vue controller
    Vue.config.ignoredElements = [
        'line-items',
        'low-fee-timeline',
        // Ignoring custom HTML5 elements, eg: bp-spinner
        /^bp");
                WriteLiteral(@"-/
    ];

    var checkoutCtrl = new Vue({
        i18n: i18n,
        el: '#checkoutCtrl',
        components: {
            qrcode: VueQrcode,
            changelly: ChangellyComponent,
            coinswitch: CoinSwitchComponent
        },
        data: {
            srvModel: srvModel,
            lndModel: null,
            scanDisplayQr: """",
            expiringSoon: false,
            isModal: srvModel.isModal,
            lightningAmountInSatoshi: srvModel.lightningAmountInSatoshi,
            selectedThirdPartyProcessor: """"
        },
        computed: {
            coinswitchAmountDue: function() {
                return this.srvModel.coinSwitchAmountMarkupPercentage
                    ? (1 + (this.srvModel.coinSwitchAmountMarkupPercentage / 100))
                    : this.srvModel.btcDue;
            }
        }
    });
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(6781, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BTCPayServer.Services.LanguageService langService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
