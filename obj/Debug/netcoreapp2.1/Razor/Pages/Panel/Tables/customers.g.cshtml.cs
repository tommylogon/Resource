#pragma checksum "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6703528586abb5b1da4bdd005ee3006db29a90e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resource.Pages.Panel.Tables.Pages_Panel_Tables_customers), @"mvc.1.0.razor-page", @"/Pages/Panel/Tables/customers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Panel/Tables/customers.cshtml", typeof(Resource.Pages.Panel.Tables.Pages_Panel_Tables_customers), null)]
namespace Resource.Pages.Panel.Tables
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6703528586abb5b1da4bdd005ee3006db29a90e", @"/Pages/Panel/Tables/customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca23d17f6e58d1ac1546124dbdddc2970fd6b90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_Tables_customers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
  
    ViewData["Title"] = "customers";
    Layout = "~/Pages/Panel/_themeLayout.cshtml";

#line default
#line hidden
            BeginContext(147, 697, true);
            WriteLiteral(@"
<h2>customers</h2>

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
                <table class=""table table-bordered"" id=""CustomerTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
");
            EndContext();
#line 31 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                             foreach (string name in Model.Row[0].Item3)
                            {

#line default
#line hidden
            BeginContext(949, 74, true);
            WriteLiteral("                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1024, 30, false);
#line 34 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                               Write(Html.DisplayFor(model => name));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 41, true);
            WriteLiteral("\r\n                                </th>\r\n");
            EndContext();
#line 36 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                            }

#line default
#line hidden
            BeginContext(1126, 227, true);
            WriteLiteral("                            <th>\r\n                                CRUD\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tfoot>\r\n                        <tr>\r\n");
            EndContext();
#line 44 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                             foreach (string name in Model.Row[0].Item3)
                            {

#line default
#line hidden
            BeginContext(1458, 74, true);
            WriteLiteral("                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1533, 30, false);
#line 47 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                               Write(Html.DisplayFor(model => name));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 41, true);
            WriteLiteral("\r\n                                </th>\r\n");
            EndContext();
#line 49 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                            }

#line default
#line hidden
            BeginContext(1635, 197, true);
            WriteLiteral("                            <th>\r\n                                CRUD\r\n                            </th>\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
            EndContext();
#line 56 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                         foreach (var item in Model.Row)
                        {

#line default
#line hidden
            BeginContext(1917, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 59 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                                 foreach (var subitem in item.Item2)
                                {

#line default
#line hidden
            BeginContext(2056, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2139, 37, false);
#line 62 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                                   Write(Html.DisplayFor(modelItem => subitem));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 64 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                                }

#line default
#line hidden
            BeginContext(2256, 74, true);
            WriteLiteral("                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2330, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6affe380ebe45ca94502496e90d10b7", async() => {
                BeginContext(2403, 4, true);
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
#line 66 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
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
            BeginContext(2411, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2451, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c535e296f7294ee69b577197678e48b9", async() => {
                BeginContext(2527, 7, true);
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
#line 67 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
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
            BeginContext(2538, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(2578, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a56316a98146678156c877f25790b8", async() => {
                BeginContext(2653, 6, true);
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
#line 68 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
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
            BeginContext(2663, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Tables\customers.cshtml"
                        }

#line default
#line hidden
            BeginContext(2766, 197, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resource.Pages.Panel.CustomersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CustomersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.CustomersModel>)PageContext?.ViewData;
        public Resource.Pages.Panel.CustomersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591