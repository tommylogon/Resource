#pragma checksum "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b6a67e5a0f8b88563875950baa4549abe4079e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Resource.Pages.Panel.Customers.Pages_Panel_Customers_Index), @"mvc.1.0.razor-page", @"/Pages/Panel/Customers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Panel/Customers/Index.cshtml", typeof(Resource.Pages.Panel.Customers.Pages_Panel_Customers_Index), null)]
namespace Resource.Pages.Panel.Customers
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6a67e5a0f8b88563875950baa4549abe4079e9", @"/Pages/Panel/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca23d17f6e58d1ac1546124dbdddc2970fd6b90", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Panel_Customers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "/pages/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(175, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "502d4a393b4843b0bc2723733f0099ee", async() => {
                BeginContext(196, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(303, 58, false);
#line 18 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CustomerNo));

#line default
#line hidden
            EndContext();
            BeginContext(361, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(417, 58, false);
#line 21 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].SearchName));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 60, false);
#line 24 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(591, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(649, 52, false);
#line 28 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Http));

#line default
#line hidden
            EndContext();
            BeginContext(701, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(757, 62, false);
#line 31 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].OrganizationNo));

#line default
#line hidden
            EndContext();
            BeginContext(819, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(875, 58, false);
#line 34 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Sortgroup1));

#line default
#line hidden
            EndContext();
            BeginContext(933, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(991, 59, false);
#line 38 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1108, 57, false);
#line 42 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].PriceList));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1221, 62, false);
#line 45 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].OpenForInvoice));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1339, 60, false);
#line 48 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CalculateVat));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1455, 55, false);
#line 51 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].ObjDate));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1566, 56, false);
#line 54 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Username));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1678, 65, false);
#line 57 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].GenerateRemainder));

#line default
#line hidden
            EndContext();
            BeginContext(1743, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1799, 65, false);
#line 60 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CalculateInterest));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1920, 54, false);
#line 63 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Status));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2030, 59, false);
#line 66 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Information));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2145, 58, false);
#line 69 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].InvoiceFee));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 142, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Manage</th>\r\n        </tr>\r\n    </thead>\r\n    <tfoot>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2346, 58, false);
#line 78 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CustomerNo));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2460, 58, false);
#line 81 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].SearchName));

#line default
#line hidden
            EndContext();
            BeginContext(2518, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2574, 60, false);
#line 84 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(2634, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2692, 52, false);
#line 88 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Http));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2800, 62, false);
#line 91 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].OrganizationNo));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2918, 58, false);
#line 94 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Sortgroup1));

#line default
#line hidden
            EndContext();
            BeginContext(2976, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3034, 59, false);
#line 98 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(3093, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3151, 57, false);
#line 102 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].PriceList));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3264, 62, false);
#line 105 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].OpenForInvoice));

#line default
#line hidden
            EndContext();
            BeginContext(3326, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3382, 60, false);
#line 108 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CalculateVat));

#line default
#line hidden
            EndContext();
            BeginContext(3442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3498, 55, false);
#line 111 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].ObjDate));

#line default
#line hidden
            EndContext();
            BeginContext(3553, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3609, 56, false);
#line 114 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Username));

#line default
#line hidden
            EndContext();
            BeginContext(3665, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3721, 65, false);
#line 117 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].GenerateRemainder));

#line default
#line hidden
            EndContext();
            BeginContext(3786, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3842, 65, false);
#line 120 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].CalculateInterest));

#line default
#line hidden
            EndContext();
            BeginContext(3907, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3963, 54, false);
#line 123 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Status));

#line default
#line hidden
            EndContext();
            BeginContext(4017, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4073, 59, false);
#line 126 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].Information));

#line default
#line hidden
            EndContext();
            BeginContext(4132, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(4188, 58, false);
#line 129 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer[0].InvoiceFee));

#line default
#line hidden
            EndContext();
            BeginContext(4246, 94, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Manage</th>\r\n        </tr>\r\n    </tfoot>\r\n    <tbody>\r\n");
            EndContext();
#line 136 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
         foreach (var item in Model.Customer)
        {

#line default
#line hidden
            BeginContext(4398, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4459, 45, false);
#line 140 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerNo));

#line default
#line hidden
            EndContext();
            BeginContext(4504, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4572, 45, false);
#line 143 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SearchName));

#line default
#line hidden
            EndContext();
            BeginContext(4617, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4685, 47, false);
#line 146 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(4732, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4802, 39, false);
#line 150 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Http));

#line default
#line hidden
            EndContext();
            BeginContext(4841, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(4909, 49, false);
#line 153 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrganizationNo));

#line default
#line hidden
            EndContext();
            BeginContext(4958, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5028, 46, false);
#line 157 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreditLimit));

#line default
#line hidden
            EndContext();
            BeginContext(5074, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5142, 48, false);
#line 160 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FixedDiscount));

#line default
#line hidden
            EndContext();
            BeginContext(5190, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5260, 44, false);
#line 164 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PriceList));

#line default
#line hidden
            EndContext();
            BeginContext(5304, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5372, 49, false);
#line 167 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OpenForInvoice));

#line default
#line hidden
            EndContext();
            BeginContext(5421, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5489, 47, false);
#line 170 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CalculateVat));

#line default
#line hidden
            EndContext();
            BeginContext(5536, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5604, 42, false);
#line 173 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ObjDate));

#line default
#line hidden
            EndContext();
            BeginContext(5646, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5714, 43, false);
#line 176 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(5757, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5825, 52, false);
#line 179 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GenerateRemainder));

#line default
#line hidden
            EndContext();
            BeginContext(5877, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5945, 52, false);
#line 182 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CalculateInterest));

#line default
#line hidden
            EndContext();
            BeginContext(5997, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6067, 41, false);
#line 186 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(6108, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6176, 46, false);
#line 189 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Information));

#line default
#line hidden
            EndContext();
            BeginContext(6222, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6290, 45, false);
#line 192 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.InvoiceFee));

#line default
#line hidden
            EndContext();
            BeginContext(6335, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6405, 40, false);
#line 196 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(6445, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6512, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b8abda0ab0e4d549c175ac3f5a6c0e0", async() => {
                BeginContext(6560, 4, true);
                WriteLiteral("Edit");
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
#line 199 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
                                           WriteLiteral(item.ObjNo);

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
            BeginContext(6568, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(6592, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c141356004f4483b9a004c208b1dfe25", async() => {
                BeginContext(6643, 7, true);
                WriteLiteral("Details");
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
#line 200 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
                                              WriteLiteral(item.ObjNo);

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
            BeginContext(6654, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(6678, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1175bee247b41d99462de70900daece", async() => {
                BeginContext(6728, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 201 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
                                             WriteLiteral(item.ObjNo);

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
            BeginContext(6738, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 204 "C:\Users\Tommy\source\repos\Resource\Resource\Pages\Panel\Customers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(6793, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resource.Pages.Panel.Customers.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.Customers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Resource.Pages.Panel.Customers.IndexModel>)PageContext?.ViewData;
        public Resource.Pages.Panel.Customers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
