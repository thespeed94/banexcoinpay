#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d62a12e1c97dac26aab4838afb3ba5c629b011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Invoice), @"mvc.1.0.view", @"/Views/Invoice/Invoice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/Invoice.cshtml", typeof(AspNetCore.Views_Invoice_Invoice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d62a12e1c97dac26aab4838afb3ba5c629b011", @"/Views/Invoice/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5213ff0c5a2def479a48eadb1e89f022778c0651", @"/Views/Invoice/_ViewImports.cshtml")]
    public class Views_Invoice_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PosData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "InvoicePaymentsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
  
    ViewData["Title"] = "Factura " + Model.Id;

#line default
#line hidden
            DefineSection("HeaderContent", async() => {
                BeginContext(102, 53, true);
                WriteLiteral("\n    <META NAME=\"robots\" CONTENT=\"noindex,nofollow\">\n");
                EndContext();
            }
            );
            BeginContext(157, 273, true);
            WriteLiteral(@"
<style type=""text/css"">
    .linethrough {
        text-decoration: line-through;
    }

    .firstCol {
        width: 140px;
    }
</style>

<section>
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                ");
            EndContext();
            BeginContext(430, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3ea0f644585407a88aeca6894cb16e3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 24 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
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
            BeginContext(483, 154, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"row\">\n            <div class=\"col-lg-12 text-center\">\n                <h2 class=\"section-heading\">");
            EndContext();
            BeginContext(638, 17, false);
#line 30 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(655, 338, true);
            WriteLiteral(@"</h2>
                <hr class=""primary"">
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-6"">
                <h3>Información</h3>
                <table class=""table table-sm table-responsive-md"">
                    <tr>
                        <th>Tienda</th>
                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1016, 1);
#line 41 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
WriteAttributeValue("", 1000, Model.StoreLink, 1000, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1017, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1019, 15, false);
#line 41 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                                                  Write(Model.StoreName);

#line default
#line hidden
            EndContext();
            BeginContext(1034, 125, true);
            WriteLiteral("</a></td>\n                    </tr>\n                    <tr>\n                        <th>Id</th>\n                        <td>");
            EndContext();
            BeginContext(1160, 8, false);
#line 45 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 125, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Estado</th>\n                        <td>");
            EndContext();
            BeginContext(1294, 11, false);
#line 49 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.State);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 136, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Fecha de creación</th>\n                        <td>");
            EndContext();
            BeginContext(1442, 33, false);
#line 53 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.CreatedDate.ToBrowserDate());

#line default
#line hidden
            EndContext();
            BeginContext(1475, 137, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Fecha de caducidad</th>\n                        <td>");
            EndContext();
            BeginContext(1613, 36, false);
#line 57 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.ExpirationDate.ToBrowserDate());

#line default
#line hidden
            EndContext();
            BeginContext(1649, 137, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Fecha de monitoreo</th>\n                        <td>");
            EndContext();
            BeginContext(1787, 36, false);
#line 61 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.MonitoringDate.ToBrowserDate());

#line default
#line hidden
            EndContext();
            BeginContext(1823, 143, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Velocidad de transacción</th>\n                        <td>");
            EndContext();
            BeginContext(1967, 22, false);
#line 65 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.TransactionSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(1989, 139, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Email de reembolso</th>\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2128, "\"", 2160, 2);
            WriteAttributeValue("", 2135, "mailto:", 2135, 7, true);
#line 69 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
WriteAttributeValue("", 2142, Model.RefundEmail, 2142, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2161, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2163, 17, false);
#line 69 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                                                           Write(Model.RefundEmail);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 131, true);
            WriteLiteral("</a></td>\n                    </tr>\n                    <tr>\n                        <th>Order Id</th>\n                        <td>");
            EndContext();
            BeginContext(2312, 13, false);
#line 73 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(2325, 136, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Total fiat debido</th>\n                        <td>");
            EndContext();
            BeginContext(2462, 10, false);
#line 77 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.Fiat);

#line default
#line hidden
            EndContext();
            BeginContext(2472, 140, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Email de notificación</th>\n                        <td>");
            EndContext();
            BeginContext(2613, 23, false);
#line 81 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.NotificationEmail);

#line default
#line hidden
            EndContext();
            BeginContext(2636, 138, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>URL de notificación</th>\n                        <td>");
            EndContext();
            BeginContext(2775, 21, false);
#line 85 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.NotificationUrl);

#line default
#line hidden
            EndContext();
            BeginContext(2796, 138, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Redireccionar URL</th>\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2934, "\"", 2959, 1);
#line 89 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
WriteAttributeValue("", 2941, Model.RedirectUrl, 2941, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2960, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2962, 17, false);
#line 89 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                                                    Write(Model.RedirectUrl);

#line default
#line hidden
            EndContext();
            BeginContext(2979, 327, true);
            WriteLiteral(@"</a></td>
                    </tr>
                </table>
            </div>

            <div class=""col-md-6"">
                <h3>Información del comprador</h3>
                <table class=""table table-sm table-responsive-md"">
                    <tr>
                        <th>Nombre</th>
                        <td>");
            EndContext();
            BeginContext(3307, 32, false);
#line 99 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerName);

#line default
#line hidden
            EndContext();
            BeginContext(3339, 126, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Email</th>\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3465, "\"", 3513, 2);
            WriteAttributeValue("", 3472, "mailto:", 3472, 7, true);
#line 103 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
WriteAttributeValue("", 3479, Model.BuyerInformation.BuyerEmail, 3479, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3514, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3516, 33, false);
#line 103 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                                                                           Write(Model.BuyerInformation.BuyerEmail);

#line default
#line hidden
            EndContext();
            BeginContext(3549, 131, true);
            WriteLiteral("</a></td>\n                    </tr>\n                    <tr>\n                        <th>Teléfono</th>\n                        <td>");
            EndContext();
            BeginContext(3681, 33, false);
#line 107 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerPhone);

#line default
#line hidden
            EndContext();
            BeginContext(3714, 130, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Dirección 1</th>\n                        <td>");
            EndContext();
            BeginContext(3845, 36, false);
#line 111 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerAddress1);

#line default
#line hidden
            EndContext();
            BeginContext(3881, 130, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Dirección 2</th>\n                        <td>");
            EndContext();
            BeginContext(4012, 36, false);
#line 115 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerAddress2);

#line default
#line hidden
            EndContext();
            BeginContext(4048, 125, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Ciudad</th>\n                        <td>");
            EndContext();
            BeginContext(4174, 32, false);
#line 119 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerCity);

#line default
#line hidden
            EndContext();
            BeginContext(4206, 125, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Estado</th>\n                        <td>");
            EndContext();
            BeginContext(4332, 33, false);
#line 123 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerState);

#line default
#line hidden
            EndContext();
            BeginContext(4365, 123, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>País</th>\n                        <td>");
            EndContext();
            BeginContext(4489, 35, false);
#line 127 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerCountry);

#line default
#line hidden
            EndContext();
            BeginContext(4524, 122, true);
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Zip</th>\n                        <td>");
            EndContext();
            BeginContext(4647, 31, false);
#line 131 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                       Write(Model.BuyerInformation.BuyerZip);

#line default
#line hidden
            EndContext();
            BeginContext(4678, 57, true);
            WriteLiteral("</td>\n                    </tr>\n                </table>\n");
            EndContext();
#line 134 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                 if (Model.PosData.Count == 0)
                {

#line default
#line hidden
            BeginContext(4800, 241, true);
            WriteLiteral("                    <h3>Información del Producto</h3>\n                    <table class=\"table table-sm table-responsive-md\">\n                        <tr>\n                            <th>Código del objeto</th>\n                            <td>");
            EndContext();
            BeginContext(5042, 33, false);
#line 140 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.ProductInformation.ItemCode);

#line default
#line hidden
            EndContext();
            BeginContext(5075, 159, true);
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <th>Descripción del Artículo</th>\n                            <td>");
            EndContext();
            BeginContext(5235, 33, false);
#line 144 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.ProductInformation.ItemDesc);

#line default
#line hidden
            EndContext();
            BeginContext(5268, 141, true);
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <th>Precio</th>\n                            <td>");
            EndContext();
            BeginContext(5410, 10, false);
#line 148 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.Fiat);

#line default
#line hidden
            EndContext();
            BeginContext(5420, 152, true);
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <th>Impuesto incluido</th>\n                            <td>");
            EndContext();
            BeginContext(5573, 17, false);
#line 152 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.TaxIncluded);

#line default
#line hidden
            EndContext();
            BeginContext(5590, 65, true);
            WriteLiteral("</td>\n                        </tr>\n                    </table>\n");
            EndContext();
#line 155 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                }

#line default
#line hidden
            BeginContext(5673, 35, true);
            WriteLiteral("            </div>\n        </div>\n\n");
            EndContext();
#line 159 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
         if (Model.PosData.Count != 0)
        {

#line default
#line hidden
            BeginContext(5757, 310, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-6"">
                    <h3>Información del Producto</h3>
                    <table class=""table table-sm table-responsive-md"">
                        <tr>
                            <th>Código del objeto</th>
                            <td>");
            EndContext();
            BeginContext(6068, 33, false);
#line 167 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.ProductInformation.ItemCode);

#line default
#line hidden
            EndContext();
            BeginContext(6101, 159, true);
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <th>Descripción del Artículo</th>\n                            <td>");
            EndContext();
            BeginContext(6261, 33, false);
#line 171 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.ProductInformation.ItemDesc);

#line default
#line hidden
            EndContext();
            BeginContext(6294, 141, true);
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <th>Precio</th>\n                            <td>");
            EndContext();
            BeginContext(6436, 10, false);
#line 175 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.Fiat);

#line default
#line hidden
            EndContext();
            BeginContext(6446, 152, true);
            WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <th>Impuesto incluido</th>\n                            <td>");
            EndContext();
            BeginContext(6599, 17, false);
#line 179 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                           Write(Model.TaxIncluded);

#line default
#line hidden
            EndContext();
            BeginContext(6616, 201, true);
            WriteLiteral("</td>\n                        </tr>\n                    </table>\n                </div>\n                <div class=\"col-md-6\">\n                    <h3>Datos del punto de venta</h3>\n                    ");
            EndContext();
            BeginContext(6817, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "013d7f3610244d26973507e1926b8311", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 185 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.PosData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6866, 43, true);
            WriteLiteral("\n                </div>\n            </div>\n");
            EndContext();
#line 188 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
        }

#line default
#line hidden
            BeginContext(6919, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(6928, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d14ed5a74d04930835935f25706ab8b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 190 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6983, 418, true);
            WriteLiteral(@"

        <div class=""row"">
            <div class=""col-md-12"">
                <h3>Eventos</h3>
                <table class=""table table-sm table-responsive-md"">
                    <thead class=""thead-inverse"">
                        <tr>
                            <th>Fecha</th>
                            <th>Mensaje</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 203 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                         foreach (var evt in Model.Events)
                        {

#line default
#line hidden
            BeginContext(7486, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(7556, 29, false);
#line 206 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                               Write(evt.Timestamp.ToBrowserDate());

#line default
#line hidden
            EndContext();
            BeginContext(7585, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(7628, 11, false);
#line 207 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                               Write(evt.Message);

#line default
#line hidden
            EndContext();
            BeginContext(7639, 40, true);
            WriteLiteral("</td>\n                            </tr>\n");
            EndContext();
#line 209 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Invoice\Invoice.cshtml"
                        }

#line default
#line hidden
            BeginContext(7705, 110, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
