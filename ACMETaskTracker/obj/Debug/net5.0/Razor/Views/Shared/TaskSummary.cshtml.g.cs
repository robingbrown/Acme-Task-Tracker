#pragma checksum "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0567277627bb0356374031b248ba8ea665105fe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TaskSummary), @"mvc.1.0.view", @"/Views/Shared/TaskSummary.cshtml")]
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
#line 1 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\_ViewImports.cshtml"
using ACMETaskTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\_ViewImports.cshtml"
using ACMETaskTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\_ViewImports.cshtml"
using ACMETaskTracker.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\_ViewImports.cshtml"
using ACMETaskTracker.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567277627bb0356374031b248ba8ea665105fe3", @"/Views/Shared/TaskSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20fc8da1d1facadaf0fd51f0d3d2ac68918c9c94", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TaskSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AcmeTask>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- PARTIAL VIEW for  Task-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0567277627bb0356374031b248ba8ea665105fe34811", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0567277627bb0356374031b248ba8ea665105fe35073", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TaskID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"card card-outline-primary m-1 p-1\">\r\n        <div class=\"bg-faded p-1\">\r\n            <h4>\r\n                ");
#nullable restore
#line 8 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
           Write(Model.DateandTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 8 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
                                Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                    <small>");
#nullable restore
#line 10 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
                      Write(Model.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                </span>\r\n            </h4>\r\n        </div>\r\n        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 549, "\"", 604, 1);
#nullable restore
#line 14 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
WriteAttributeValue("", 557, ViewContext.HttpContext.Request.PathAndQuery(), 557, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"card-text p-1\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
       Write(Model.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </span>
        <div class=""d-grid gap-2 d-md-flex justify-content-md-end"">
            <button type=""submit"" class=""btn btn-success btn-sm pull-right"">
                Delete
            </button>
            <button type=""submit"" class=""btn btn-warning btn-sm pull-right"">
                Done
            </button>
            <button type=""submit"" class=""btn btn-danger btn-sm pull-right"">
                Update
            </button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 3 "C:\Users\Robin\Source\Repos\robingbrown\Acme-Task-Tracker\ACMETaskTracker\Views\Shared\TaskSummary.cshtml"
AddHtmlAttributeValue("", 59, Model.TaskID, 59, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcmeTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
