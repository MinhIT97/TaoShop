#pragma checksum "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "000d0906b55f7c79f25ace2c9f978c6e7404b832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Laptops_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Laptops/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Laptops/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Laptops_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000d0906b55f7c79f25ace2c9f978c6e7404b832", @"/Areas/Admin/Views/Laptops/Details.cshtml")]
    public class Areas_Admin_Views_Laptops_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaoShop.Models.DB.Laptop>
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
#line 3 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(62, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(91, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7465834f93a746529dfe5e228e641730", async() => {
                BeginContext(97, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            BeginContext(193, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(195, 4144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1881401d7cd46ce97fea8124d4c16f4", async() => {
                BeginContext(201, 102, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Laptop</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(304, 43, false);
#line 21 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(347, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(391, 39, false);
#line 24 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.NameLap));

#line default
#line hidden
                EndContext();
                BeginContext(430, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(474, 41, false);
#line 27 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(515, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(559, 37, false);
#line 30 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(596, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(640, 47, false);
#line 33 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(687, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(731, 43, false);
#line 36 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(774, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(818, 41, false);
#line 39 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(859, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(903, 37, false);
#line 42 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(940, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(984, 44, false);
#line 45 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(1028, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1072, 40, false);
#line 48 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(1112, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1156, 40, false);
#line 51 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(1196, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1240, 36, false);
#line 54 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(1276, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1320, 42, false);
#line 57 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(1362, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1406, 38, false);
#line 60 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
                EndContext();
                BeginContext(1444, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1488, 41, false);
#line 63 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1529, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1573, 37, false);
#line 66 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1610, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1654, 41, false);
#line 69 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1695, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1739, 37, false);
#line 72 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
                EndContext();
                BeginContext(1776, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1820, 42, false);
#line 75 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(1862, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1906, 38, false);
#line 78 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Memory));

#line default
#line hidden
                EndContext();
                BeginContext(1944, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1988, 38, false);
#line 81 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Os));

#line default
#line hidden
                EndContext();
                BeginContext(2026, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2070, 34, false);
#line 84 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Os));

#line default
#line hidden
                EndContext();
                BeginContext(2104, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2148, 44, false);
#line 87 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(2192, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2236, 40, false);
#line 90 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.CpuSpeed));

#line default
#line hidden
                EndContext();
                BeginContext(2276, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2320, 42, false);
#line 93 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(2362, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2406, 38, false);
#line 96 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Camera));

#line default
#line hidden
                EndContext();
                BeginContext(2444, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2488, 43, false);
#line 99 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(2531, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2575, 39, false);
#line 102 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Battery));

#line default
#line hidden
                EndContext();
                BeginContext(2614, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2658, 43, false);
#line 105 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(2701, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2745, 39, false);
#line 108 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Waranty));

#line default
#line hidden
                EndContext();
                BeginContext(2784, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2828, 45, false);
#line 111 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(2873, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2917, 41, false);
#line 114 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bluetooth));

#line default
#line hidden
                EndContext();
                BeginContext(2958, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3002, 40, false);
#line 117 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(3042, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3086, 36, false);
#line 120 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Wlan));

#line default
#line hidden
                EndContext();
                BeginContext(3122, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3166, 45, false);
#line 123 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(3211, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3255, 41, false);
#line 126 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalePrice));

#line default
#line hidden
                EndContext();
                BeginContext(3296, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3340, 50, false);
#line 129 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3390, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3434, 46, false);
#line 132 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3480, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3524, 48, false);
#line 135 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3572, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3616, 44, false);
#line 138 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(3660, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3704, 45, false);
#line 141 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(3749, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3793, 41, false);
#line 144 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(3834, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3878, 45, false);
#line 147 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(3923, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3967, 41, false);
#line 150 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedAt));

#line default
#line hidden
                EndContext();
                BeginContext(4008, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4052, 39, false);
#line 153 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cat));

#line default
#line hidden
                EndContext();
                BeginContext(4091, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4135, 40, false);
#line 156 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cat.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4175, 67, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4242, "\"", 4266, 1);
#line 161 "C:\Users\minh0\source\repos\TaoShop\TaoShop\Areas\Admin\Views\Laptops\Details.cshtml"
WriteAttributeValue("", 4257, Model.Id, 4257, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4267, 65, true);
                WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
            BeginContext(4339, 11, true);
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
