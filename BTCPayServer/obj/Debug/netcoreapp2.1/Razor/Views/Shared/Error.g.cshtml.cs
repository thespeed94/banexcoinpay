#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18ce15a716dba77d4fd81e2e39d30bde110be69d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ce15a716dba77d4fd81e2e39d30bde110be69d", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(60, 26, true);
            WriteLiteral("\n<h1 class=\"text-danger\">\n");
            EndContext();
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
     if (!string.IsNullOrEmpty(Model.Error)) {

#line default
#line hidden
            BeginContext(133, 16, true);
            WriteLiteral("        <strong>");
            EndContext();
            BeginContext(150, 11, false);
#line 8 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
           Write(Model.Error);

#line default
#line hidden
            EndContext();
            BeginContext(161, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
#line 9 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(192, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(202, 7, true);
            WriteLiteral("Error.\n");
            EndContext();
#line 13 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
            BeginContext(215, 31, true);
            WriteLiteral("</h1>\n<h2 class=\"text-danger\">\n");
            EndContext();
#line 16 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
     if (!string.IsNullOrEmpty(Model.ErrorDescription)) {

#line default
#line hidden
            BeginContext(304, 15, true);
            WriteLiteral("        <small>");
            EndContext();
            BeginContext(320, 22, false);
#line 17 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
          Write(Model.ErrorDescription);

#line default
#line hidden
            EndContext();
            BeginContext(342, 9, true);
            WriteLiteral("</small>\n");
            EndContext();
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(372, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(382, 49, true);
            WriteLiteral("An error occurred while processing your request.\n");
            EndContext();
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
            BeginContext(437, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 25 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
 if(Model != null && Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(488, 51, true);
            WriteLiteral("    <p>\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(540, 15, false);
#line 28 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(555, 17, true);
            WriteLiteral("</code>\n    </p>\n");
            EndContext();
#line 30 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(574, 554, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
