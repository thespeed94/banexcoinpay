#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76fbcc0e8e07a8a37de846fe28730ff97c36a5c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentRequest_ViewPaymentRequest), @"mvc.1.0.view", @"/Views/PaymentRequest/ViewPaymentRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PaymentRequest/ViewPaymentRequest.cshtml", typeof(AspNetCore.Views_PaymentRequest_ViewPaymentRequest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76fbcc0e8e07a8a37de846fe28730ff97c36a5c0", @"/Views/PaymentRequest/ViewPaymentRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    public class Views_PaymentRequest_ViewPaymentRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BTCPayServer.Models.PaymentRequestViewModels.ViewPaymentRequestViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "wwwroot/bundles/payment-request-bundle-1.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "wwwroot/bundles/payment-request-bundle-2.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modal/btcpay.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "wwwroot/bundles/payment-request-bundle.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-on:submit", new global::Microsoft.AspNetCore.Html.HtmlString("submitCustomAmountForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = null;

#line default
#line hidden
            BeginContext(251, 38, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html class=\"h-100\">\n");
            EndContext();
            BeginContext(289, 1145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87e569f2f92048d6baf9aaf219f3bc04", async() => {
                BeginContext(295, 12, true);
                WriteLiteral("\n    <title>");
                EndContext();
                BeginContext(308, 11, false);
#line 13 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
      Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(319, 181, true);
                WriteLiteral("</title>\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <meta name=\"apple-mobile-web-app-capable\" content=\"yes\">\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 500, "\"", 576, 1);
#line 17 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
WriteAttributeValue("", 507, Context.Request.GetRelativePathOrAbsolute(themeManager.BootstrapUri), 507, 69, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(577, 21, true);
                WriteLiteral(" rel=\"stylesheet\" />\n");
                EndContext();
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
     if (Model.CustomCSSLink != null)
    {

#line default
#line hidden
                BeginContext(642, 13, true);
                WriteLiteral("        <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 655, "\"", 682, 1);
#line 20 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
WriteAttributeValue("", 662, Model.CustomCSSLink, 662, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(683, 21, true);
                WriteLiteral(" rel=\"stylesheet\" />\n");
                EndContext();
#line 21 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
    }

#line default
#line hidden
                BeginContext(710, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
     if (!Context.Request.Query.ContainsKey("simple"))
    {

#line default
#line hidden
                BeginContext(771, 67, true);
                WriteLiteral("        <script type=\"text/javascript\">\n            var srvModel = ");
                EndContext();
                BeginContext(839, 31, false);
#line 25 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
                      Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
                EndContext();
                BeginContext(870, 28, true);
                WriteLiteral(";\n        </script>\n        ");
                EndContext();
                BeginContext(898, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e57c17930cde4959a3f902e9da3b89f5", async() => {
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
                BeginContext(970, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(979, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f62d15befef44dc9572a35657b3f140", async() => {
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
                BeginContext(1051, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(1156, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1164, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a7edd9e9c649d2a836ec222932bcd2", async() => {
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
                BeginContext(1205, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 31 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
    }

#line default
#line hidden
                BeginContext(1212, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1217, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("bundle", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c204897e84940fea7232d48efc7961a", async() => {
                }
                );
                __BundlerMinifier_TagHelpers_BundleTagHelper = CreateTagHelper<global::BundlerMinifier.TagHelpers.BundleTagHelper>();
                __tagHelperExecutionContext.Add(__BundlerMinifier_TagHelpers_BundleTagHelper);
                __BundlerMinifier_TagHelpers_BundleTagHelper.BundleName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1288, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 34 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
     if (!string.IsNullOrEmpty(Model.EmbeddedCSS))
    {

#line default
#line hidden
                BeginContext(1346, 28, true);
                WriteLiteral("        <style>\n            ");
                EndContext();
                BeginContext(1375, 27, false);
#line 37 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
       Write(Html.Raw(Model.EmbeddedCSS));

#line default
#line hidden
                EndContext();
                BeginContext(1402, 19, true);
                WriteLiteral(";\n        </style>\n");
                EndContext();
#line 39 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
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
            BeginContext(1434, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1435, 12519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca50202f22e4f9fbf8bc6a9792718b1", async() => {
                BeginContext(1441, 2, true);
                WriteLiteral("\n\n");
                EndContext();
                BeginContext(1443, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57028e402b6b470ca56ae223b1355744", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 43 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1496, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 44 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
 if (Context.Request.Query.ContainsKey("simple"))
{
    

#line default
#line hidden
                BeginContext(1554, 55, false);
#line 46 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
Write(await Html.PartialAsync("MinimalPaymentRequest", Model));

#line default
#line hidden
                EndContext();
#line 46 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
                                                            
}
else
{

#line default
#line hidden
                BeginContext(1619, 23, true);
                WriteLiteral("    <noscript>\n        ");
                EndContext();
                BeginContext(1643, 55, false);
#line 51 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
   Write(await Html.PartialAsync("MinimalPaymentRequest", Model));

#line default
#line hidden
                EndContext();
                BeginContext(1698, 17, true);
                WriteLiteral("\n    </noscript>\n");
                EndContext();
                BeginContext(1716, 7396, true);
                WriteLiteral(@"    <div class=""container"" id=""app"" v-cloak>
        <div class=""row w-100 p-0 m-0"" style=""height: 100vh"">
            <div class=""mx-auto my-auto w-100"">
                <div class=""card"">
                    <h1 class=""card-header"">
                        {{srvModel.title}}

                        <span class=""text-muted float-right text-center"">
                            <template v-if=""settled"">Settled</template>
                            <template v-else>
                                <template v-if=""ended"">Request Expired</template>
                                <template v-else-if=""endDiff"">Expires in {{endDiff}}</template>
                                <template v-else>{{srvModel.status}}</template>
                            </template>
                        </span>
                    </h1>
                    <div class=""card-body px-0 pt-0"">
                        <div class=""row mb-4"">
                            <div class=""col-sm-12 col-md-12 col-lg-6 "">
                        ");
                WriteLiteral(@"        <ul class=""w-100 list-group list-group-flush"">
                                    <li class=""list-group-item"">
                                        <div class=""d-flex justify-content-between"">
                                            <span class=""h2 text-muted"">Request amount:</span>
                                            <span class=""h2"">{{srvModel.amountFormatted}}</span>
                                        </div>
                                    </li>
                                    <li class=""list-group-item"">
                                        <div class=""d-flex justify-content-between"">
                                            <span class=""h2 text-muted"">Paid so far:</span>
                                            <span class=""h2"">{{srvModel.amountCollectedFormatted}}</span>
                                        </div>
                                    </li>
                                    <li class=""list-group-item"">
                                    ");
                WriteLiteral(@"    <div class=""d-flex justify-content-between"">
                                            <span class=""h2 text-muted"">Amount due:</span>
                                            <span class=""h2"">{{srvModel.amountDueFormatted}}</span>
                                        </div>
                                    </li>
                                </ul>
                                <div v-html=""srvModel.description"" class=""w-100 p-2""></div>

                            </div>
                            <div class=""col-sm-12 col-md-12  col-lg-6"">
                                <div class=""table-responsive"">
                                    <table class=""table border-top-0 "">
                                        <thead>
                                        <tr>
                                            <th class="" border-top-0"" scope=""col"">Invoice #</th>
                                            <th class="" border-top-0"">Price</th>
                                            <th cla");
                WriteLiteral(@"ss="" border-top-0"">Expiry</th>
                                            <th class="" border-top-0"">Status</th>
                                        </tr>
                                        </thead>
                                        <tbody>
                                        <tr v-if=""!srvModel.invoices || srvModel.invoices.length == 0"">
                                            <td colspan=""4"" class=""text-center"">No payments made yet</td>
                                        </tr>
                                        <template v-else v-for=""invoice of srvModel.invoices"" :key=""invoice.id"">
                                            <tr class=""bg-light"">
                                                <td scope=""row"">{{invoice.id}}</td>
                                                <td>{{invoice.amountFormatted}}</td>
                                                <td>{{moment(invoice.expiryDate).format('L HH:mm')}}</td>
                                                <td>{{invo");
                WriteLiteral(@"ice.status}}</td>
                                            </tr>
                                            <tr class=""bg-light"" v-if=""invoice.payments && invoice.payments.length > 0"">
                                                <td colspan=""4"" class="" px-2 py-1 border-top-0"">

                                                    <div class=""table-responsive"">
                                                        <table class=""table table-bordered"">
                                                            <tr>
                                                                <th class=""p-1"" style=""max-width: 300px"">Tx Id</th>
                                                                <th class=""p-1"">Payment Method</th>
                                                                <th class=""p-1"">Amount</th>
                                                                <th class=""p-1"">Link</th>
                                                            </tr>
                                ");
                WriteLiteral(@"                            <tr v-for=""payment of invoice.payments"">
                                                                <td class=""p-1 m-0 d-print-none d-block"" style=""max-width: 300px"">
                                                                    <div style=""width: 100%; overflow-x: auto; overflow-wrap: initial;"">{{payment.id}}</div>
                                                                </td>
                                                                <td class=""p-1 m-0 d-none d-print-table-cell"" style=""max-width: 150px;"">
                                                                    {{payment.id}}
                                                                </td>
                                                                <td class=""p-1"">{{formatPaymentMethod(payment.paymentMethod)}}</td>
                                                                <td class=""p-1"">{{payment.amount.noExponents()}}</td>
                                                         ");
                WriteLiteral(@"       <td class=""p-1 d-print-none"">
                                                                    <a v-if=""payment.link"" :href=""payment.link"" target=""_blank"">Link</a>
                                                                </td>
                                                                <td class=""p-1 d-none d-print-table-cell"" style=""max-width: 150px;"">
                                                                    {{payment.link}}
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
                                        </template>
                                        <tr v-if=""!ended && (srvModel.amountDue) > 0"" class=""d-print-none"">
                                      ");
                WriteLiteral("      <td colspan=\"4\" class=\"text-center\">\n\n                                                <template v-if=\"srvModel.allowCustomPaymentAmounts && !srvModel.anyPendingInvoice\">\n                                                    ");
                EndContext();
                BeginContext(9112, 2231, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b982dc068d4bb8b0ad672d619dfc60", async() => {
                    BeginContext(9155, 2181, true);
                    WriteLiteral(@"

                                                        <div class=""input-group m-auto"" style=""max-width: 250px"">
                                                            <input
                                                                :readonly=""!srvModel.allowCustomPaymentAmounts""
                                                                class=""form-control""
                                                                type=""number""
                                                                v-model=""customAmount""
                                                                :max=""srvModel.amountDue""
                                                                step=""any""
                                                                placeholder=""Amount""
                                                                required>
                                                            <div class=""input-group-append"">
                                                              ");
                    WriteLiteral(@"  <span class='input-group-text'>{{currency}}</span>
                                                                <button
                                                                    class=""btn btn-primary""
                                                                    v-bind:class=""{ 'btn-disabled': loading}""
                                                                    :disabled=""loading""
                                                                    type=""submit"">
                                                                    <div v-if=""loading"" class=""spinner-grow spinner-grow-sm"" role=""status"">
                                                                        <span class=""sr-only"">Loading...</span>
                                                                    </div>
                                                                    Pay now
                                                                </button>
                                                 ");
                    WriteLiteral("           </div>\n                                                        </div>\n                                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11343, 2602, true);
                WriteLiteral(@"
                                                </template>

                                                <template v-else>
                                                    <button class=""btn btn-primary btn-lg mt-1"" v-on:click=""pay(null)""
                                                            :disabled=""loading"">
                                                        <div v-if=""loading"" class=""spinner-grow spinner-grow-sm"" role=""status"">
                                                            <span class=""sr-only"">Loading...</span>
                                                        </div>

                                                        Pay now
                                                    </button>
                                                    <button class=""btn btn-secondary btn-lg mt-1"" 
                                                            v-if=""!srvModel.pendingInvoiceHasPayments"" 
                                                            v-on:click=""can");
                WriteLiteral(@"celPayment()""
                                                            :disabled=""loading"">
                                                        <div v-if=""loading"" class=""spinner-grow spinner-grow-sm"" role=""status"">
                                                            <span class=""sr-only"">Loading...</span>
                                                        </div>

                                                            Cancel current invoice</button>
                                                </template>
                                               
                                            </td>
                                        </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class=""card-footer text-muted d-flex justify-content-between"">

                        <");
                WriteLiteral(@"div >
                            <span v-on:click=""print"" class=""btn-link d-print-none"" style=""cursor: pointer""> <span class=""fa fa-print""></span> Print</span>
                            <span>Updated {{lastUpdated}}</span>
                        </div>
                        <div >
                            <span class=""text-muted"">Powered by </span><a href=""https://btcpayserver.org"" target=""_blank"">BTCPay Server</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
#line 226 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\PaymentRequest\ViewPaymentRequest.cshtml"
}

#line default
#line hidden
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
            BeginContext(13954, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BTCPayServer.HostedServices.CssThemeManager themeManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BTCPayServer.Models.PaymentRequestViewModels.ViewPaymentRequestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
