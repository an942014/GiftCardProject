#pragma checksum "D:\SVN\GiftCardProject\source\aspnet-core\GiftCard.Web\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e332b2d18c27c3959fb87a6cc85d0184f10ff750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_Layout.cshtml", typeof(AspNetCore.Views__Layout))]
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
#line 1 "D:\SVN\GiftCardProject\source\aspnet-core\GiftCard.Web\Views\_ViewImports.cshtml"
using GiftCard.Web;

#line default
#line hidden
#line 2 "D:\SVN\GiftCardProject\source\aspnet-core\GiftCard.Web\Views\_ViewImports.cshtml"
using GiftCard.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e332b2d18c27c3959fb87a6cc85d0184f10ff750", @"/Views/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd3ec79b863da14353b62dbe3d300cf7fa55229", @"/Views/_ViewImports.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(8, 1214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332b2d18c27c3959fb87a6cc85d0184f10ff7503306", async() => {
                BeginContext(14, 153, true);
                WriteLiteral("\r\n    <title>Hello</title>\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=9\">\r\n    <link href=\"/favicon.ico\" rel=\"shortcut icon\" type=\"image/ico\">\r\n");
                EndContext();
                BeginContext(605, 540, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""http://www.w3cschool.cc/try/jeasyui/themes/default/easyui.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""http://www.w3cschool.cc/try/jeasyui/themes/icon.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""http://www.w3cschool.cc/try/jeasyui/demo/demo.css"">
    <script type=""text/javascript"" src=""http://code.jquery.com/jquery-1.6.min.js""></script>
    <script type=""text/javascript"" src=""http://www.w3cschool.cc/try/jeasyui/jquery.easyui.min.js""></script>
    
    
    ");
                EndContext();
                BeginContext(1146, 30, false);
#line 19 "D:\SVN\GiftCardProject\source\aspnet-core\GiftCard.Web\Views\_Layout.cshtml"
Write(RenderSection("Header", false));

#line default
#line hidden
                EndContext();
                BeginContext(1176, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1183, 30, false);
#line 20 "D:\SVN\GiftCardProject\source\aspnet-core\GiftCard.Web\Views\_Layout.cshtml"
Write(RenderSection("Script", false));

#line default
#line hidden
                EndContext();
                BeginContext(1213, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            BeginContext(1222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1224, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e332b2d18c27c3959fb87a6cc85d0184f10ff7506048", async() => {
                BeginContext(1230, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1237, 12, false);
#line 23 "D:\SVN\GiftCardProject\source\aspnet-core\GiftCard.Web\Views\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1249, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(1258, 100, true);
            WriteLiteral("\r\n</html>\r\n<iframe id=\"topLayout_rawframe\" style=\"display:none;\" name=\"topLayout_rawframe\"></iframe>");
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
