#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b392d68367c7e727b76492bb4832fa7b7dc8aa6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallets_WalletPSBTReady), @"mvc.1.0.view", @"/Views/Wallets/WalletPSBTReady.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wallets/WalletPSBTReady.cshtml", typeof(AspNetCore.Views_Wallets_WalletPSBTReady))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer;

#line default
#line hidden
#line 3 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Views;

#line default
#line hidden
#line 4 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models;

#line default
#line hidden
#line 5 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.InvoicingModels;

#line default
#line hidden
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.ManageViewModels;

#line default
#line hidden
#line 8 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.StoreViewModels;

#line default
#line hidden
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\_ViewImports.cshtml"
using BTCPayServer.Views.Wallets;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\_ViewImports.cshtml"
using BTCPayServer.Models.WalletViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b392d68367c7e727b76492bb4832fa7b7dc8aa6f", @"/Views/Wallets/WalletPSBTReady.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded28c9c4aa4680a79c38bc0250cd2d03019ed1b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f20312169b30a46841d2ebefe3784562bcba56", @"/Views/Wallets/_ViewImports.cshtml")]
    public class Views_Wallets_WalletPSBTReady : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalletPSBTReadyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WalletPSBTReady", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
  
    Layout = "../Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(82, 40, true);
            WriteLiteral("<section>\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
         if (Model.GlobalError != null)
        {

#line default
#line hidden
            BeginContext(174, 241, true);
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible\" role=\"alert\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                <span>");
            EndContext();
            BeginContext(416, 17, false);
#line 11 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                 Write(Model.GlobalError);

#line default
#line hidden
            EndContext();
            BeginContext(433, 35, true);
            WriteLiteral("</span><br />\r\n            </div>\r\n");
            EndContext();
#line 13 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
        }

#line default
#line hidden
            BeginContext(479, 191, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <h2 class=\"section-heading\">Revisión de la transacción</h2>\r\n                <hr class=\"primary\">\r\n");
            EndContext();
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                 if (Model.CanCalculateBalance)
                {

#line default
#line hidden
            BeginContext(738, 95, true);
            WriteLiteral("                    <p>\r\n                        Si emite esta transacción, su saldo cambiará: ");
            EndContext();
#line 21 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                                       if (Model.Positive)
                        {

#line default
#line hidden
            BeginContext(882, 55, true);
            WriteLiteral("                            <span style=\"color:green;\">");
            EndContext();
            BeginContext(938, 19, false);
#line 23 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                  Write(Model.BalanceChange);

#line default
#line hidden
            EndContext();
            BeginContext(957, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 24 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1050, 53, true);
            WriteLiteral("                            <span style=\"color:red;\">");
            EndContext();
            BeginContext(1104, 19, false);
#line 27 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                Write(Model.BalanceChange);

#line default
#line hidden
            EndContext();
            BeginContext(1123, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 28 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                        }

#line default
#line hidden
            BeginContext(1157, 48, true);
            WriteLiteral(", quieres continuar?\r\n                    </p>\r\n");
            EndContext();
#line 30 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1265, 127, true);
            WriteLiteral("                    <p>Este PSBT ya está finalizado. No podemos detectar correctamente qué entrada o salida te pertenece.</p>\r\n");
            EndContext();
#line 34 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                }

#line default
#line hidden
            BeginContext(1411, 630, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 text-center""></div>
            <div class=""col-lg-6 text-center"">
                <table class=""table table-sm table-responsive-lg"">
                    <thead class=""thead-inverse"">
                        <tr>
                            <th style=""text-align:left"" class=""col-md-auto"">
                                Destino
                            </th>
                            <th style=""text-align:right"">Cantidad</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 50 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                         foreach (var destination in Model.Destinations)
                        {

#line default
#line hidden
            BeginContext(2142, 94, true);
            WriteLiteral("                            <tr>\r\n                                <td style=\"text-align:left\">");
            EndContext();
            BeginContext(2237, 23, false);
#line 53 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                       Write(destination.Destination);

#line default
#line hidden
            EndContext();
            BeginContext(2260, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 54 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                 if (destination.Positive)
                                {

#line default
#line hidden
            BeginContext(2362, 79, true);
            WriteLiteral("                                    <td style=\"text-align:right; color:green;\">");
            EndContext();
            BeginContext(2442, 19, false);
#line 56 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                                          Write(destination.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(2461, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 57 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2576, 77, true);
            WriteLiteral("                                    <td style=\"text-align:right; color:red;\">");
            EndContext();
            BeginContext(2654, 19, false);
#line 60 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                                        Write(destination.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(2673, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 61 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                }

#line default
#line hidden
            BeginContext(2715, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                        }

#line default
#line hidden
            BeginContext(2777, 146, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-lg-3 text-center\"></div>\r\n        </div>\r\n");
            EndContext();
#line 69 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
         if (Model.FeeRate != null)
        {

#line default
#line hidden
            BeginContext(2971, 206, true);
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-lg-3 text-center\"></div>\r\n                <div class=\"col-lg-6 text-right\">\r\n                    <p class=\"text-muted\">Tasa de transacción: <b>");
            EndContext();
            BeginContext(3178, 13, false);
#line 74 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                             Write(Model.FeeRate);

#line default
#line hidden
            EndContext();
            BeginContext(3191, 112, true);
            WriteLiteral("</b></p>\r\n                </div>\r\n                <div class=\"col-lg-3 text-center\"></div>\r\n            </div>\r\n");
            EndContext();
#line 78 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
        }

#line default
#line hidden
            BeginContext(3314, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 79 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
         if (Model.Errors != null)
        {

#line default
#line hidden
            BeginContext(3361, 978, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <h4>Errores</h4>
                    <p>
                        Este PSBT no puede ser finalizado para su transmisión. Por favor revisa los errores..
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-3 text-center""></div>
                <div class=""col-lg-6 text-center"">
                    <table class=""table table-sm table-responsive-lg"">
                        <thead class=""thead-inverse"">
                            <tr>
                                <th style=""text-align:left"" class=""col-md-1"">
                                    Índice de entrada
                                </th>
                                <th style=""text-align:right"">Error</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 102 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                             foreach (var err in Model.Errors)
                            {

#line default
#line hidden
            BeginContext(4434, 102, true);
            WriteLiteral("                                <tr>\r\n                                    <td style=\"text-align:left\">");
            EndContext();
            BeginContext(4537, 9, false);
#line 105 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                           Write(err.Index);

#line default
#line hidden
            EndContext();
            BeginContext(4546, 124, true);
            WriteLiteral("</td>\r\n                                    <td style=\"text-align:right; color:red;\"><span class=\"fa fa-exclamation-triangle\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 4670, "\"", 4688, 1);
#line 106 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
WriteAttributeValue("", 4678, err.Error, 4678, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4689, 54, true);
            WriteLiteral("></span></td>\r\n                                </tr>\r\n");
            EndContext();
#line 108 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                            }

#line default
#line hidden
            BeginContext(4774, 166, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <div class=\"col-lg-3 text-center\"></div>\r\n            </div>\r\n");
            EndContext();
#line 114 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
        }

#line default
#line hidden
            BeginContext(4951, 92, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                ");
            EndContext();
            BeginContext(5043, 641, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e3b581b174b4a62815a37d72aa05763", async() => {
                BeginContext(5092, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5114, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94808c7ae6c142c4a3e72fb4eca45ec6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 118 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PSBT);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5152, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5174, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f87208881dd14d99b2a723dbd8397990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 119 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SigningKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5218, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(5240, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07e50f1609a549919e85dcb6c92b77bd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 120 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SigningKeyPath);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5288, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 121 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                     if (Model.Errors == null)
                    {

#line default
#line hidden
                BeginContext(5361, 144, true);
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\" name=\"command\" value=\"broadcast\">Transmitirlo</button> <span> or </span>\r\n");
                EndContext();
#line 124 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                    }

#line default
#line hidden
                BeginContext(5528, 149, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-secondary\" name=\"command\" value=\"analyze-psbt\">Exportar cómo PSBT</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5684, 62, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalletPSBTReadyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
