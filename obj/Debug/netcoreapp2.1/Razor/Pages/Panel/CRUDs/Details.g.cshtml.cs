#pragma checksum "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70cfad467723596803f42bfd8479590906874b12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resource.Pages.Panel.CRUDs.Pages_Panel_CRUDs_Details), @"mvc.1.0.razor-page", @"/Pages/Panel/CRUDs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Panel/CRUDs/Details.cshtml", typeof(Resource.Pages.Panel.CRUDs.Pages_Panel_CRUDs_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70cfad467723596803f42bfd8479590906874b12", @"/Pages/Panel/CRUDs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca23d17f6e58d1ac1546124dbdddc2970fd6b90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_CRUDs_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Panel/_themeLayout.cshtml";

#line default
#line hidden
            BeginContext(149, 694, true);
            WriteLiteral(@"
<h2>Details</h2>

<div class=""container-fluid"">

    <!-- Breadcrumbs-->
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item"">
            <a href=""#"">Dashboard</a>
        </li>
        <li class=""breadcrumb-item active"">Tables</li>
    </ol>

    <!-- DataTables Example -->
    <div class=""card mb-3"">
        <div class=""card-header"">
            <i class=""fas fa-table""></i>
            Data Table Example
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""DetailsTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
");
            EndContext();
#line 31 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                             foreach (string name in Model.Row[0].Item3)
                            {

#line default
#line hidden
            BeginContext(948, 74, true);
            WriteLiteral("                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1023, 30, false);
#line 34 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                               Write(Html.DisplayFor(model => name));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 41, true);
            WriteLiteral("\r\n                                </th>\r\n");
            EndContext();
#line 36 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"

                            }

#line default
#line hidden
            BeginContext(1127, 227, true);
            WriteLiteral("                            <th>\r\n                                CRUD\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tfoot>\r\n                        <tr>\r\n");
            EndContext();
#line 45 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                             foreach (string name in Model.Row[0].Item3)
                            {

#line default
#line hidden
            BeginContext(1459, 74, true);
            WriteLiteral("                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1534, 30, false);
#line 48 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                               Write(Html.DisplayFor(model => name));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 41, true);
            WriteLiteral("\r\n                                </th>\r\n");
            EndContext();
#line 50 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                            }

#line default
#line hidden
            BeginContext(1636, 197, true);
            WriteLiteral("                            <th>\r\n                                CRUD\r\n                            </th>\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
            EndContext();
#line 57 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                         foreach (var item in Model.Row)
                        {

#line default
#line hidden
            BeginContext(1918, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 60 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                                 foreach (var subitem in item.Item2)
                                {

#line default
#line hidden
            BeginContext(2057, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2140, 37, false);
#line 63 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => subitem));

#line default
#line hidden
            EndContext();
            BeginContext(2177, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 65 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                                }

#line default
#line hidden
            BeginContext(2257, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2331, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf2b0348f38e4d718b887c078f6c66c3", async() => {
                BeginContext(2404, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                                                           WriteLiteral(item.Item2[Model.IndexOfCustomerID]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2412, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2452, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b04b8a53d4094eb3ae64957b4ced5f9b", async() => {
                BeginContext(2528, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                                                              WriteLiteral(item.Item2[Model.IndexOfCustomerID]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2539, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2579, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02e6f8b07fe347399fb769fd0284c54f", async() => {
                BeginContext(2654, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"
                                                             WriteLiteral(item.Item2[Model.IndexOfCustomerID]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2664, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 72 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\CRUDs\Details.cshtml"

                        }

#line default
#line hidden
            BeginContext(2769, 197, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        <div class=\"card-footer small text-muted\">Updated yesterday at 11:59 PM</div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resource.Pages.Panel.CRUDs.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CRUDs.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CRUDs.DetailsModel>)PageContext?.ViewData;
        public Resource.Pages.Panel.CRUDs.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591