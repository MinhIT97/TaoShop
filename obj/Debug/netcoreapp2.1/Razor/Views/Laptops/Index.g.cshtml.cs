#pragma checksum "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70bc564dd8815eb8379e72a3ee8f9671565fbdb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptops_Index), @"mvc.1.0.view", @"/Views/Laptops/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Laptops/Index.cshtml", typeof(AspNetCore.Views_Laptops_Index))]
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
#line 1 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\_ViewImports.cshtml"
using TaoShop;

#line default
#line hidden
#line 2 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\_ViewImports.cshtml"
using TaoShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70bc564dd8815eb8379e72a3ee8f9671565fbdb1", @"/Views/Laptops/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ffc85362799d4155542928807420ef397729ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Laptops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaoShop.Models.DB.Laptop>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(75, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "785c2404f3804abab93fb5a0152aecc4", async() => {
                BeginContext(110, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(206, 5072, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78b13b1a70dd4ad888157743e5083b14", async() => {
                BeginContext(212, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(223, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cac49270cd39481381e0f85aeb3fa41b", async() => {
                    BeginContext(246, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(260, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(353, 43, false);
#line 22 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(396, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(452, 41, false);
#line 25 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(493, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(549, 47, false);
#line 28 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(596, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(652, 41, false);
#line 31 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(693, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(749, 44, false);
#line 34 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(793, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(849, 40, false);
#line 37 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(889, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(945, 42, false);
#line 40 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(987, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1043, 41, false);
#line 43 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1084, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1140, 41, false);
#line 46 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1181, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1237, 42, false);
#line 49 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(1279, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1335, 38, false);
#line 52 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Os));

#line default
#line hidden
                EndContext();
                BeginContext(1373, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1429, 44, false);
#line 55 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(1473, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1529, 42, false);
#line 58 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(1571, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1627, 43, false);
#line 61 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(1670, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1726, 43, false);
#line 64 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(1769, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1825, 45, false);
#line 67 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(1870, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1926, 40, false);
#line 70 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(1966, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2022, 45, false);
#line 73 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(2067, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2123, 50, false);
#line 76 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(2173, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2229, 48, false);
#line 79 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(2277, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2333, 45, false);
#line 82 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(2378, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2434, 45, false);
#line 85 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(2479, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2535, 39, false);
#line 88 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cat));

#line default
#line hidden
                EndContext();
                BeginContext(2574, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 94 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(2692, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2741, 42, false);
#line 97 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(2783, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2839, 40, false);
#line 100 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(2879, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2935, 46, false);
#line 103 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2981, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3037, 40, false);
#line 106 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(3077, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3133, 43, false);
#line 109 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(3176, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3232, 39, false);
#line 112 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
                EndContext();
                BeginContext(3271, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3327, 41, false);
#line 115 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(3368, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3424, 40, false);
#line 118 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
                EndContext();
                BeginContext(3464, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3520, 40, false);
#line 121 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
                EndContext();
                BeginContext(3560, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3616, 41, false);
#line 124 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(3657, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3713, 37, false);
#line 127 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Os));

#line default
#line hidden
                EndContext();
                BeginContext(3750, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3806, 43, false);
#line 130 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(3849, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3905, 41, false);
#line 133 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(3946, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4002, 42, false);
#line 136 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(4044, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4100, 42, false);
#line 139 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(4142, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4198, 44, false);
#line 142 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(4242, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4298, 39, false);
#line 145 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(4337, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4393, 44, false);
#line 148 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(4437, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4493, 49, false);
#line 151 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(4542, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4598, 47, false);
#line 154 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(4645, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4701, 44, false);
#line 157 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(4745, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4801, 44, false);
#line 160 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(4845, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4901, 43, false);
#line 163 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cat.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4944, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4999, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39234095e20403b81bbb0143837780f", async() => {
                    BeginContext(5044, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 166 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
                                       WriteLiteral(item.Id);

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
                BeginContext(5052, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(5072, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4863afc8f4ee3af72ed2c27d07fe3", async() => {
                    BeginContext(5120, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 167 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
                                          WriteLiteral(item.Id);

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
                BeginContext(5131, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(5151, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7884faf6a30743329de9b2fbd33c97ce", async() => {
                    BeginContext(5198, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 168 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
                                         WriteLiteral(item.Id);

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
                BeginContext(5208, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 171 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Views\Laptops\Index.cshtml"
}

#line default
#line hidden
                BeginContext(5247, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            BeginContext(5278, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaoShop.Models.DB.Laptop>> Html { get; private set; }
    }
}
#pragma warning restore 1591
