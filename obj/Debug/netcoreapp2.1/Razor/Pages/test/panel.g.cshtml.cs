#pragma checksum "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3226c971c8405895a5e59c590aec324fa81b20e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resource.Pages.test.Pages_test_panel), @"mvc.1.0.razor-page", @"/Pages/test/panel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/test/panel.cshtml", typeof(Resource.Pages.test.Pages_test_panel), null)]
namespace Resource.Pages.test
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3226c971c8405895a5e59c590aec324fa81b20e", @"/Pages/test/panel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca23d17f6e58d1ac1546124dbdddc2970fd6b90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_test_panel : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
  
    ViewData["Title"] = "panel";
    Layout = "~/Pages/test/Themetest.cshtml";

#line default
#line hidden
            BeginContext(134, 4544, true);
            WriteLiteral(@"
<h2>panel</h2>

<div id=""content-wrapper"">

    <div class=""container-fluid"">
        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#"">Dashboard</a>
            </li>
            <li class=""breadcrumb-item active"">Overview</li>
        </ol>
        <!-- Icon Cards-->
        <div class=""row"">
            <div class=""col-xl-3 col-sm-6 mb-3"">
                <div class=""card text-white bg-primary o-hidden h-100"">
                    <div class=""card-body"">
                        <div class=""card-body-icon"">
                            <i class=""fas fa-fw fa-comments""></i>
                        </div>
                        <div class=""mr-5"">26 New Messages!</div>
                    </div>
                    <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                        <span class=""float-left"">View Details</span>
                        <span class=""float-right"">
                    ");
            WriteLiteral(@"        <i class=""fas fa-angle-right""></i>
                        </span>
                    </a>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 mb-3"">
                <div class=""card text-white bg-warning o-hidden h-100"">
                    <div class=""card-body"">
                        <div class=""card-body-icon"">
                            <i class=""fas fa-fw fa-list""></i>
                        </div>
                        <div class=""mr-5"">11 New Tasks!</div>
                    </div>
                    <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                        <span class=""float-left"">View Details</span>
                        <span class=""float-right"">
                            <i class=""fas fa-angle-right""></i>
                        </span>
                    </a>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 mb-3"">
                <div class=""card text-white bg");
            WriteLiteral(@"-success o-hidden h-100"">
                    <div class=""card-body"">
                        <div class=""card-body-icon"">
                            <i class=""fas fa-fw fa-shopping-cart""></i>
                        </div>
                        <div class=""mr-5"">123 New Orders!</div>
                    </div>
                    <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                        <span class=""float-left"">View Details</span>
                        <span class=""float-right"">
                            <i class=""fas fa-angle-right""></i>
                        </span>
                    </a>
                </div>
            </div>
            <div class=""col-xl-3 col-sm-6 mb-3"">
                <div class=""card text-white bg-danger o-hidden h-100"">
                    <div class=""card-body"">
                        <div class=""card-body-icon"">
                            <i class=""fas fa-fw fa-life-ring""></i>
                        </div>
       ");
            WriteLiteral(@"                 <div class=""mr-5"">13 New Tickets!</div>
                    </div>
                    <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                        <span class=""float-left"">View Details</span>
                        <span class=""float-right"">
                            <i class=""fas fa-angle-right""></i>
                        </span>
                    </a>
                </div>
            </div>
        </div>
        <!-- Area Chart Example-->
        <div class=""card mb-3"">
            <div class=""card-header"">
                <i class=""fas fa-chart-area""></i>
                Area Chart Example
            </div>
            <div class=""card-body"">
                <canvas id=""myAreaChart"" width=""100%"" height=""30""></canvas>
            </div>
            <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
        </div>
        <!-- DataTables Example -->
        <div class=""card mb-3"">
            <div class=");
            WriteLiteral(@"""card-header"">
                <i class=""fas fa-table""></i>
                Data Table Example
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">

                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(4679, 58, false);
#line 111 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].CustomerID));

#line default
#line hidden
            EndContext();
            BeginContext(4737, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(4853, 60, false);
#line 114 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(4913, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(5029, 54, false);
#line 117 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].Adress));

#line default
#line hidden
            EndContext();
            BeginContext(5083, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(5199, 60, false);
#line 120 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].PostalAdress));

#line default
#line hidden
            EndContext();
            BeginContext(5259, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(5375, 56, false);
#line 123 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].PostalNr));

#line default
#line hidden
            EndContext();
            BeginContext(5431, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(5547, 53, false);
#line 126 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].Phone));

#line default
#line hidden
            EndContext();
            BeginContext(5600, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(5716, 53, false);
#line 129 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                               Write(Html.DisplayNameFor(model => model.Customer[0].OrgNr));

#line default
#line hidden
            EndContext();
            BeginContext(5769, 186, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 135 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                             foreach (var item in Model.Customer)
                            {

#line default
#line hidden
            BeginContext(6053, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(6174, 45, false);
#line 139 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CustomerID));

#line default
#line hidden
            EndContext();
            BeginContext(6219, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(6347, 47, false);
#line 142 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(6394, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(6522, 41, false);
#line 145 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(6563, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(6691, 47, false);
#line 148 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PostalAdress));

#line default
#line hidden
            EndContext();
            BeginContext(6738, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(6866, 43, false);
#line 151 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PostalNr));

#line default
#line hidden
            EndContext();
            BeginContext(6909, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(7037, 40, false);
#line 154 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(7077, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(7205, 40, false);
#line 157 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.OrgNr));

#line default
#line hidden
            EndContext();
            BeginContext(7245, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(7372, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcc16a804e284562870e91cf312d96cf", async() => {
                BeginContext(7425, 4, true);
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
#line 160 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                                               WriteLiteral(item.CustomerID);

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
            BeginContext(7433, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(7477, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed347e16413b4226816ea8206ae1685a", async() => {
                BeginContext(7533, 7, true);
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
#line 161 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                                                  WriteLiteral(item.CustomerID);

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
            BeginContext(7544, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(7588, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcdff4b1ba30441cadc4c17f611fa34b", async() => {
                BeginContext(7643, 6, true);
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
#line 162 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                                                                 WriteLiteral(item.CustomerID);

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
            BeginContext(7653, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 165 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\test\panel.cshtml"
                            }

#line default
#line hidden
            BeginContext(7768, 233, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer small text-muted\">Updated yesterday at 11:59 PM</div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resource.Pages.test.panelModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.test.panelModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.test.panelModel>)PageContext?.ViewData;
        public Resource.Pages.test.panelModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
