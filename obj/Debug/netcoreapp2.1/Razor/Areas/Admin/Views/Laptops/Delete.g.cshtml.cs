#pragma checksum "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15b62e2cb52b2b224375b2051a82d9e71e408da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Laptops_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Laptops/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Laptops/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Laptops_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15b62e2cb52b2b224375b2051a82d9e71e408da3", @"/Areas/Admin/Views/Laptops/Delete.cshtml")]
    public class Areas_Admin_Views_Laptops_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaoShop.Models.DB.Laptop>
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(62, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(91, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7a55aa1209b400ea1b3a1ff525f4292", async() => {
                BeginContext(97, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
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
            BeginContext(192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(194, 4290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfbee9459d4a4017938caef61200de2b", async() => {
                BeginContext(200, 150, true);
                WriteLiteral("\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Laptop</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(351, 43, false);
#line 22 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(394, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(438, 39, false);
#line 25 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(477, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(521, 41, false);
#line 28 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(562, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(606, 37, false);
#line 31 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(643, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(687, 47, false);
#line 34 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(734, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(778, 43, false);
#line 37 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(821, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(865, 41, false);
#line 40 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(906, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(950, 37, false);
#line 43 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(987, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1031, 44, false);
#line 46 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(1075, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1119, 40, false);
#line 49 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(1159, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1203, 40, false);
#line 52 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1287, 36, false);
#line 55 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(1323, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1367, 42, false);
#line 58 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(1409, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1453, 38, false);
#line 61 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(1491, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1535, 41, false);
#line 64 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1576, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1620, 37, false);
#line 67 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1657, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1701, 41, false);
#line 70 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1742, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1786, 37, false);
#line 73 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1823, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1867, 42, false);
#line 76 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(1909, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1953, 38, false);
#line 79 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(1991, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2035, 38, false);
#line 82 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Os));

#line default
#line hidden
                EndContext();
                BeginContext(2073, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2117, 34, false);
#line 85 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Os));

#line default
#line hidden
                EndContext();
                BeginContext(2151, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2195, 44, false);
#line 88 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(2239, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2283, 40, false);
#line 91 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(2323, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2367, 42, false);
#line 94 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(2409, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2453, 38, false);
#line 97 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(2491, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2535, 43, false);
#line 100 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(2578, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2622, 39, false);
#line 103 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(2661, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2705, 43, false);
#line 106 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(2748, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2792, 39, false);
#line 109 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(2831, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2875, 45, false);
#line 112 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(2920, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2964, 41, false);
#line 115 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(3005, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3049, 40, false);
#line 118 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(3089, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3133, 36, false);
#line 121 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(3169, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3213, 45, false);
#line 124 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(3258, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3302, 41, false);
#line 127 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(3343, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3387, 50, false);
#line 130 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3437, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3481, 46, false);
#line 133 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3527, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3571, 48, false);
#line 136 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3619, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3663, 44, false);
#line 139 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3707, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3751, 45, false);
#line 142 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(3796, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3840, 41, false);
#line 145 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(3881, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3925, 45, false);
#line 148 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(3970, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4014, 41, false);
#line 151 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(4055, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4099, 39, false);
#line 154 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cat));

#line default
#line hidden
                EndContext();
                BeginContext(4138, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4182, 40, false);
#line 157 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cat.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4222, 255, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
            BeginContext(4484, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaoShop.Models.DB.Laptop> Html { get; private set; }
    }
}
#pragma warning restore 1591
