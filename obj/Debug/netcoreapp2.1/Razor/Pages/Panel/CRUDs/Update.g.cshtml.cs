#pragma checksum "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3daeacc45df2fe9e0ace96b8a1cbb38df657f7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resource.Pages.Panel.CRUDs.Pages_Panel_CRUDs_Update), @"mvc.1.0.razor-page", @"/Pages/Panel/CRUDs/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Panel/CRUDs/Update.cshtml", typeof(Resource.Pages.Panel.CRUDs.Pages_Panel_CRUDs_Update), null)]
namespace Resource.Pages.Panel.CRUDs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\_ViewImports.cshtml"
using Resource;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3daeacc45df2fe9e0ace96b8a1cbb38df657f7f9", @"/Pages/Panel/CRUDs/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca23d17f6e58d1ac1546124dbdddc2970fd6b90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_CRUDs_Update : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/panel/index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Pages/Panel/_themeLayout.cshtml";

#line default
#line hidden
            BeginContext(147, 179, true);
            WriteLiteral("\r\n<h2>Update</h2>\r\n\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"card \">\r\n        <div class=\"card-header\">Edit or Update</div>\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(326, 2141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667853a167ac4092aa0bfa8db7a97653", async() => {
                BeginContext(346, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                 for (int i = 0; i < Model.Row[0].Item3.Count(); i++)
                {

#line default
#line hidden
                BeginContext(438, 269, true);
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""form-row"">
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <label class=""control-label"">");
                EndContext();
                BeginContext(708, 21, false);
#line 22 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                                            Write(Model.Row[0].Item3[i]);

#line default
#line hidden
                EndContext();
                BeginContext(729, 114, true);
                WriteLiteral("</label>\r\n                                    <input type=\"text\" name=\"Model.Row[0].Item3[i]\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 843, "\"", 873, 1);
#line 23 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
WriteAttributeValue("", 851, Model.Row[0].Item2[i], 851, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(874, 189, true);
                WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"form-group\">\r\n");
                EndContext();
#line 28 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                     if ((i + 1) < Model.Row[0].Item3.Count())
                                    {
                                        i++;

#line default
#line hidden
                BeginContext(1228, 69, true);
                WriteLiteral("                                        <label class=\"control-label\">");
                EndContext();
                BeginContext(1298, 21, false);
#line 31 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                                                Write(Model.Row[0].Item3[i]);

#line default
#line hidden
                EndContext();
                BeginContext(1319, 118, true);
                WriteLiteral("</label>\r\n                                        <input type=\"text\" name=\"Model.Row[0].Item3[i]\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1437, "\"", 1467, 1);
#line 32 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
WriteAttributeValue("", 1445, Model.Row[0].Item2[i], 1445, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1468, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 33 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1510, 186, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"form-group\">\r\n");
                EndContext();
#line 38 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                     if ((i + 1) < Model.Row[0].Item3.Count())
                                    {
                                        i++;

#line default
#line hidden
                BeginContext(1861, 69, true);
                WriteLiteral("                                        <label class=\"control-label\">");
                EndContext();
                BeginContext(1931, 21, false);
#line 41 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                                                Write(Model.Row[0].Item3[i]);

#line default
#line hidden
                EndContext();
                BeginContext(1952, 118, true);
                WriteLiteral("</label>\r\n                                        <input type=\"text\" name=\"Model.Row[0].Item3[i]\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2070, "\"", 2100, 1);
#line 42 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
WriteAttributeValue("", 2078, Model.Row[0].Item2[i], 2078, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2101, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 43 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2143, 136, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 48 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                }

#line default
#line hidden
                BeginContext(2298, 162, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2467, 73, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(2540, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ad989ecb74b47ce90ad13ff7bbba2d7", async() => {
                BeginContext(2585, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("/Panel/Tables/");
#line 59 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Update.cshtml"
                               WriteLiteral(Model.TablePath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2601, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(2624, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18307408983747ae9baf320793fdcae0", async() => {
                BeginContext(2651, 13, true);
                WriteLiteral("Back to Panel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2668, 40, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resource.Pages.Panel.CRUDs.UpdateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CRUDs.UpdateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CRUDs.UpdateModel>)PageContext?.ViewData;
        public Resource.Pages.Panel.CRUDs.UpdateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
