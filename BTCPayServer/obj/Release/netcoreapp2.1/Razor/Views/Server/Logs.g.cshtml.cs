#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711032347261dcd4fbc2472be017ca1d73bc99d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Server_Logs), @"mvc.1.0.view", @"/Views/Server/Logs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Server/Logs.cshtml", typeof(AspNetCore.Views_Server_Logs))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\_ViewImports.cshtml"
using BTCPayServer.Views.Server;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\_ViewImports.cshtml"
using BTCPayServer.Models.ServerViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711032347261dcd4fbc2472be017ca1d73bc99d4", @"/Views/Server/Logs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded28c9c4aa4680a79c38bc0250cd2d03019ed1b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adaa21f0befcd6f57c6801e61dac5e06e262d62c", @"/Views/Server/_ViewImports.cshtml")]
    public class Views_Server_Logs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BTCPayServer.Models.ServerViewModels.LogsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogsView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
  
    ViewData.SetActivePageAndTitle(ServerNavPages.Logs);

#line default
#line hidden
            BeginContext(124, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(131, 17, false);
#line 6 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(155, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c692b64de1de4c2aab555f25ae7e17ae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
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
            BeginContext(207, 33, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <ul>\r\n");
            EndContext();
#line 11 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
         foreach (var file in Model.LogFiles)
        {

#line default
#line hidden
            BeginContext(298, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(332, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e722fde5394de0bd56f675725a3f13", async() => {
                BeginContext(386, 9, false);
#line 14 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
                                                                Write(file.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-file", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
                                             WriteLiteral(file.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["file"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-file", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["file"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(399, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 16 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
        }

#line default
#line hidden
            BeginContext(431, 14, true);
            WriteLiteral("        <li>\r\n");
            EndContext();
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
             if (Model.LogFileOffset > 0)
            {

#line default
#line hidden
            BeginContext(503, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(519, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aa3b6af001840a29488d9e7eb2eab68", async() => {
                BeginContext(590, 2, true);
                WriteLiteral("<<");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-offset", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
                                                WriteLiteral(Model.LogFileOffset - 5);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["offset"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-offset", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["offset"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(596, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
            }

#line default
#line hidden
            BeginContext(613, 20, true);
            WriteLiteral("            Muestra ");
            EndContext();
            BeginContext(634, 19, false);
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
               Write(Model.LogFileOffset);

#line default
#line hidden
            EndContext();
            BeginContext(653, 4, true);
            WriteLiteral(" - (");
            EndContext();
            BeginContext(659, 40, false);
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
                                        Write(Model.LogFileOffset+Model.LogFiles.Count);

#line default
#line hidden
            EndContext();
            BeginContext(700, 5, true);
            WriteLiteral(") de ");
            EndContext();
            BeginContext(706, 18, false);
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
                                                                                       Write(Model.LogFileCount);

#line default
#line hidden
            EndContext();
            BeginContext(724, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
             if ((Model.LogFileOffset+ Model.LogFiles.Count) < Model.LogFileCount)
            {

#line default
#line hidden
            BeginContext(825, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(841, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "921c4517267446d9a7b1d236d53afd0a", async() => {
                BeginContext(931, 2, true);
                WriteLiteral(">>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-offset", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
                                                WriteLiteral(Model.LogFileOffset + Model.LogFiles.Count);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["offset"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-offset", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["offset"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(937, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
            }

#line default
#line hidden
            BeginContext(954, 26, true);
            WriteLiteral("        </li>\r\n    </ul>\r\n");
            EndContext();
#line 29 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
     if (!string.IsNullOrEmpty(Model.Log))
    {

#line default
#line hidden
            BeginContext(1031, 15, true);
            WriteLiteral("        <pre>\r\n");
            EndContext();
            BeginContext(1047, 9, false);
#line 32 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
Write(Model.Log);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 10, true);
            WriteLiteral("\r\n</pre>\r\n");
            EndContext();
#line 34 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
    }

#line default
#line hidden
            BeginContext(1073, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1103, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1110, 52, false);
#line 39 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Server\Logs.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1162, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BTCPayServer.Models.ServerViewModels.LogsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
