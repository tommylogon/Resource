#pragma checksum "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7db04a1bd84d1d8afbc82ed2f2157baa8c6713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resource.Pages.Panel.CRUDs.Pages_Panel_CRUDs_Create), @"mvc.1.0.razor-page", @"/Pages/Panel/CRUDs/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Panel/CRUDs/Create.cshtml", typeof(Resource.Pages.Panel.CRUDs.Pages_Panel_CRUDs_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7db04a1bd84d1d8afbc82ed2f2157baa8c6713", @"/Pages/Panel/CRUDs/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca23d17f6e58d1ac1546124dbdddc2970fd6b90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_CRUDs_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Panel/_themeLayout.cshtml";

#line default
#line hidden
            BeginContext(147, 171, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"card \">\r\n        <div class=\"card-header\">Edit or Update</div>\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(318, 2141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8de560486df4a7ca42b49edea464310", async() => {
                BeginContext(338, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 15 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                 for (int i = 0; i < Model.Row[0].Item3.Count(); i++)
                {

#line default
#line hidden
                BeginContext(430, 269, true);
                WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""form-row"">
                            <div class=""col-md-4"">
                                <div class=""form-group"">
                                    <label class=""control-label"">");
                EndContext();
                BeginContext(700, 21, false);
#line 21 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                                            Write(Model.Row[0].Item3[i]);

#line default
#line hidden
                EndContext();
                BeginContext(721, 114, true);
                WriteLiteral("</label>\r\n                                    <input type=\"text\" name=\"Model.Row[0].Item3[i]\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 835, "\"", 865, 1);
#line 22 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
WriteAttributeValue("", 843, Model.Row[0].Item2[i], 843, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(866, 189, true);
                WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"form-group\">\r\n");
                EndContext();
#line 27 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                     if ((i + 1) < Model.Row[0].Item3.Count())
                                    {
                                        i++;

#line default
#line hidden
                BeginContext(1220, 69, true);
                WriteLiteral("                                        <label class=\"control-label\">");
                EndContext();
                BeginContext(1290, 21, false);
#line 30 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                                                Write(Model.Row[0].Item3[i]);

#line default
#line hidden
                EndContext();
                BeginContext(1311, 118, true);
                WriteLiteral("</label>\r\n                                        <input type=\"text\" name=\"Model.Row[0].Item3[i]\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1429, "\"", 1459, 1);
#line 31 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
WriteAttributeValue("", 1437, Model.Row[0].Item2[i], 1437, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1460, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 32 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1502, 186, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"form-group\">\r\n");
                EndContext();
#line 37 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                     if ((i + 1) < Model.Row[0].Item3.Count())
                                    {
                                        i++;

#line default
#line hidden
                BeginContext(1853, 69, true);
                WriteLiteral("                                        <label class=\"control-label\">");
                EndContext();
                BeginContext(1923, 21, false);
#line 40 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                                                Write(Model.Row[0].Item3[i]);

#line default
#line hidden
                EndContext();
                BeginContext(1944, 118, true);
                WriteLiteral("</label>\r\n                                        <input type=\"text\" name=\"Model.Row[0].Item3[i]\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2062, "\"", 2092, 1);
#line 41 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
WriteAttributeValue("", 2070, Model.Row[0].Item2[i], 2070, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2093, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 42 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2135, 136, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 47 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
                }

#line default
#line hidden
                BeginContext(2290, 162, true);
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
            BeginContext(2459, 73, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(2532, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16873c36254845babe468e402ecf9288", async() => {
                BeginContext(2577, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("/Panel/Tables/");
#line 58 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Create.cshtml"
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
            BeginContext(2593, 23, true);
            WriteLiteral("</li>\r\n            <li>");
            EndContext();
            BeginContext(2616, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19b49f7d077145d284a86ae0b9d55730", async() => {
                BeginContext(2643, 13, true);
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
            BeginContext(2660, 40, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resource.Pages.Panel.CRUDs.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CRUDs.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CRUDs.CreateModel>)PageContext?.ViewData;
        public Resource.Pages.Panel.CRUDs.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
