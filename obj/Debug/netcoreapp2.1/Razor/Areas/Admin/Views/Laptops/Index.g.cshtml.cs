#pragma checksum "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061399f70427dde49b986b30bd6bf729c7e06837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Laptops_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Laptops/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Laptops/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Laptops_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"061399f70427dde49b986b30bd6bf729c7e06837", @"/Areas/Admin/Views/Laptops/Index.cshtml")]
    public class Areas_Admin_Views_Laptops_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaoShop.Models.DB.Laptop>>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(75, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d6bf15a4a214a2db055f50e7d19c38b", async() => {
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
            BeginContext(206, 5182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a64b6993b7c4d529fad20c13530c65f", async() => {
                BeginContext(212, 140, true);
                WriteLiteral("\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(353, 43, false);
#line 22 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(396, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(452, 41, false);
#line 25 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(493, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(549, 47, false);
#line 28 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(596, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(652, 41, false);
#line 31 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(693, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(749, 44, false);
#line 34 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(793, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(849, 40, false);
#line 37 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(889, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(945, 42, false);
#line 40 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(987, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1043, 41, false);
#line 43 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1084, 59, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1143, "\"", 1191, 1);
#line 46 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
WriteAttributeValue("", 1149, Html.DisplayNameFor(model => model.Image), 1149, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1192, 57, true);
                WriteLiteral("/>\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1250, 41, false);
#line 49 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1291, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1347, 42, false);
#line 52 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(1389, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1445, 38, false);
#line 55 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Os));

#line default
#line hidden
                EndContext();
                BeginContext(1483, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1539, 44, false);
#line 58 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(1583, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1639, 42, false);
#line 61 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(1681, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1737, 43, false);
#line 64 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(1780, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1836, 43, false);
#line 67 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(1879, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1935, 45, false);
#line 70 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(1980, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2036, 40, false);
#line 73 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(2076, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2132, 45, false);
#line 76 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(2177, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2233, 50, false);
#line 79 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(2283, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2339, 48, false);
#line 82 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(2387, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2443, 45, false);
#line 85 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(2488, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2544, 45, false);
#line 88 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(2589, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(2645, 39, false);
#line 91 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cat));

#line default
#line hidden
                EndContext();
                BeginContext(2684, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 97 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(2802, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2851, 42, false);
#line 100 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(2893, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2949, 40, false);
#line 103 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(2989, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3045, 46, false);
#line 106 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(3091, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3147, 40, false);
#line 109 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(3187, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3243, 43, false);
#line 112 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(3286, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3342, 39, false);
#line 115 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
                EndContext();
                BeginContext(3381, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3437, 41, false);
#line 118 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(3478, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3534, 40, false);
#line 121 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
                EndContext();
                BeginContext(3574, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3630, 40, false);
#line 124 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
                EndContext();
                BeginContext(3670, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3726, 41, false);
#line 127 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(3767, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3823, 37, false);
#line 130 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Os));

#line default
#line hidden
                EndContext();
                BeginContext(3860, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(3916, 43, false);
#line 133 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(3959, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4015, 41, false);
#line 136 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(4056, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4112, 42, false);
#line 139 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(4154, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4210, 42, false);
#line 142 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(4252, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4308, 44, false);
#line 145 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(4352, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4408, 39, false);
#line 148 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(4447, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4503, 44, false);
#line 151 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(4547, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4603, 49, false);
#line 154 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(4652, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4708, 47, false);
#line 157 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(4755, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4811, 44, false);
#line 160 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(4855, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(4911, 44, false);
#line 163 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(4955, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(5011, 43, false);
#line 166 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cat.Name));

#line default
#line hidden
                EndContext();
                BeginContext(5054, 75, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5129, "\"", 5152, 1);
#line 169 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
WriteAttributeValue("", 5144, item.Id, 5144, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5153, 52, true);
                WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5205, "\"", 5228, 1);
#line 170 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
WriteAttributeValue("", 5220, item.Id, 5220, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5229, 54, true);
                WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5283, "\"", 5306, 1);
#line 171 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
WriteAttributeValue("", 5298, item.Id, 5298, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5307, 47, true);
                WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 174 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Index.cshtml"
}

#line default
#line hidden
                BeginContext(5357, 24, true);
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
            BeginContext(5388, 11, true);
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
