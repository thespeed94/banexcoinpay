#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b524643b1358523a54c6a84e4b4624a1da800fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b524643b1358523a54c6a84e4b4624a1da800fd2", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/lock-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/qr-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/money-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/dglab.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/metaco.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/ibuki.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/mattermost.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/slack.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/twitter.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/github.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home Page";
    ViewBag.AlwaysShrinkNavBar = false;

#line default
#line hidden
            BeginContext(82, 1173, true);
            WriteLiteral(@"

<header class=""masthead"">
    <div class=""header-content"">
        <div class=""header-content-inner text-white"">
            <h1>Bienvenido a BANEXCOINPAY</h1>
            <hr />
            <p>BANEXCOINPAY es un servicio para comercios que deseen aceptar bitcoins en sus negocios.</p>
            <a style=""background-color: #ccc;color: #222;display:inline-block;text-align: center;white-space: nowrap;vertical-align: middle;user-select: none;line-height: 1.25;font-size: 1rem;text-decoration:none;font-weight: 700;    text-transform: uppercase;border: none;border-radius: 300px;padding: 15px 30px;"" href=""http://banexcoin.com/wordpress/"" target=""_blank"">SITIO OFICIAL</a>
        </div>
    </div>
</header>

<section id=""services"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <h2 class=""section-heading"">Un método de pago para Bitcoin</h2>
                <hr class=""primary"">
            </div>
        </div>
    </div>
    <div class=""contain");
            WriteLiteral("er\">\n        <div class=\"row\">\n            <div class=\"col-lg-4 col-md-6 text-center\">\n                <div class=\"service-box\">\n                    ");
            EndContext();
            BeginContext(1255, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e57f6109b5b44faae90edbdb8353ad2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1288, 362, true);
            WriteLiteral(@"
                    <h3 class=""text-dark"">Seguro</h3>
                    <p class=""text-muted"">El servidor de pago no necesita saber tus claves privadas, por lo que tu dinero no puede ser robado.</p>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 text-center"">
                <div class=""service-box"">
                    ");
            EndContext();
            BeginContext(1650, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f94e6400eeb4ade90f7b049ffb7ec72", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1681, 323, true);
            WriteLiteral(@"
                    <h3 class=""text-dark"">Fácil</h3>
                    <p class=""text-muted"">Una página de pago de Bitcoin fácil de usar para sus clientes.</p>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 text-center"">
                <div class=""service-box"">
                    ");
            EndContext();
            BeginContext(2004, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc32512e9baa485ea34978841c9674c6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2038, 1309, true);
            WriteLiteral(@"
                    <h3 class=""text-dark"">Visibilidad</h3>
                    <p class=""text-muted"">Gestione, genere informes y busque sus facturas fácilmente.</p>
                </div>
            </div>
        </div>
    </div>
</section>

<!--<div class=""call-to-action bg-dark text-white"">
    <div class=""container text-center"">
        <h2>Video tutorials</h2>
        <div class=""row"">
            <div class=""col-md-2 text-center"">
            </div>
            <div class=""col-md-8 text-center"">
                <a href=""https://www.youtube.com/channel/UCpG9WL6TJuoNfFVkaDMp9ug"" target=""_blank"">
                    <img src=""/img/youtube.png"" class=""img-fluid"" />
                </a>
            </div>
            <div class=""col-md-2 text-center"">
            </div>
        </div>
    </div>
</div>-->



<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 mx-auto text-center"">
                <h2 class=""section-heading"">Gracias especiales</h2>
             ");
            WriteLiteral(@"   <hr class=""primary"">
                <p>Gracias a los negocios que confiaron en nosotros.</p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 mr-auto text-center"">
                <a href=""https://www.dglab.com/en/"">
                    ");
            EndContext();
            BeginContext(3347, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71912cde626e4c27a1fc9d8504e033af", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3389, 271, true);
            WriteLiteral(@"
                </a>
                <p>
                    <a href=""https://www.dglab.com/en/"">DG Lab</a>
                </p>
            </div>
            <div class=""col-lg-4 ml-auto text-center"">
                <a href=""https://metaco.com/"">
                    ");
            EndContext();
            BeginContext(3660, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d1141430873434a97c08d9e52a0a199", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3703, 239, true);
            WriteLiteral("\n                </a>\n                <p><a href=\"https://metaco.com/\">Metaco</a></p>\n            </div>\n            <div class=\"col-lg-4 mr-auto text-center\">\n                <a href=\"https://ibukingdom.themedia.jp/\">\n                    ");
            EndContext();
            BeginContext(3942, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21c4c6ae0d5243a0bb2a3cdb3cc5e39d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3984, 1076, true);
            WriteLiteral(@"
                </a>
                <p>
                    <a href=""https://ibukingdom.themedia.jp/"">Designer</a>
                </p>
            </div>
        </div>
    </div>
</section>

<!--<div class=""call-to-action bg-dark text-white"">
    <div class=""container text-center"">
        <h2>Donate</h2>
        <p>Donation to this address will be reinvested into the development of this tool</p>
        <p><img src=""~/img/donation.jpg""></p>
        <p>3BpfdkF93GwFRWdrAN3SNsRAsi6d158YQi</p>
    </div>
</div>-->

<section id=""contact"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 mx-auto text-center"">
                <h2 class=""section-heading"">Mantengámonos en contacto!</h2>
                <hr class=""primary"">
                <p>
                    Ven y ponte en contacto con nosotros!
                </p>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 ml-auto text-center"">
                <a href=""https://chat.btcpa");
            WriteLiteral("yserver.org/\"  target=\"_blank\">\n                    ");
            EndContext();
            BeginContext(5060, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d1d6b927f3d49559f6f29914189a5f5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5107, 291, true);
            WriteLiteral(@"
                </a>
                <p><a href=""https://chat.btcpayserver.org/""  target=""_blank"">On Mattermost</a></p>
            </div>
            <div class=""col-lg-3 ml-auto text-center"">
                <a href=""https://slack.btcpayserver.org/""  target=""_blank"">
                    ");
            EndContext();
            BeginContext(5398, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e6f4885a6864e7ba06434970484aa0a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5440, 285, true);
            WriteLiteral(@"
                </a>
                <p><a href=""http://slack.forkbitpay.ninja/"" target=""_blank"">On Slack</a></p>
            </div>
            <div class=""col-lg-3 mr-auto text-center"">
                <a href=""https://twitter.com/BtcpayServer"" target=""_blank"">
                    ");
            EndContext();
            BeginContext(5725, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1ebc9a3e5f64bcc819c8502259f7f3e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5769, 339, true);
            WriteLiteral(@"
                </a>
                <p>
                    <a href=""https://twitter.com/BtcpayServer"" target=""_blank"">On Twitter</a>
                </p>
            </div>
            <div class=""col-lg-3 mr-auto text-center"">
                <a href=""https://github.com/btcpayserver/btcpayserver"" target=""_blank"">
                    ");
            EndContext();
            BeginContext(6108, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7314ab9362ca4a5d855792a0b77bea3d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6151, 224, true);
            WriteLiteral("\n                </a>\n                <p>\n                    <a href=\"https://github.com/btcpayserver/btcpayserver\" target=\"_blank\">On Github</a>\n                </p>\n            </div>\n        </div>\n    </div>\n</section>\n");
            EndContext();
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
