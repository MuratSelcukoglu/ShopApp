#pragma checksum "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231979a4630b3cfd8a7ad9b8b422e1f7323606b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryEdit), @"mvc.1.0.view", @"/Views/Admin/CategoryEdit.cshtml")]
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
#nullable restore
#line 2 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231979a4630b3cfd8a7ad9b8b422e1f7323606b1", @"/Views/Admin/CategoryEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0448ff91bbeb32e122bd1a436e2c638f1ede08", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletefromcategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"h3\">Edit Category</h1>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b17838", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b18108", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 8 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 315, "\"", 340, 1);
#nullable restore
#line 9 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 323, Model.CategoryId, 323, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b110260", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 11 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "231979a4630b3cfd8a7ad9b8b422e1f7323606b111899", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 13 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b113488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 14 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b115242", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "231979a4630b3cfd8a7ad9b8b422e1f7323606b116880", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 20 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b118468", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 21 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-10 offset-sm-2"">
                    <button type=""submit"" class=""btn btn-primary"">Save Category</button>
                </div>
            </div>
            <div id=""products"">

");
#nullable restore
#line 32 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                 for (int i = 0; i < Model.Products.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1437, "\"", 1466, 3);
                WriteAttributeValue("", 1444, "Products[", 1444, 9, true);
#nullable restore
#line 34 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1453, i, 1453, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1455, "].productId", 1455, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1467, "\"", 1504, 1);
#nullable restore
#line 34 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1475, Model.Products[@i].ProductId, 1475, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1548, "\"", 1576, 3);
                WriteAttributeValue("", 1555, "Products[", 1555, 9, true);
#nullable restore
#line 35 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1564, i, 1564, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1566, "].ImageUrl", 1566, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1577, "\"", 1613, 1);
#nullable restore
#line 35 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1585, Model.Products[@i].ImageUrl, 1585, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1657, "\"", 1681, 3);
                WriteAttributeValue("", 1664, "Products[", 1664, 9, true);
#nullable restore
#line 36 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1673, i, 1673, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1675, "].Name", 1675, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1682, "\"", 1714, 1);
#nullable restore
#line 36 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1690, Model.Products[@i].Name, 1690, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1758, "\"", 1783, 3);
                WriteAttributeValue("", 1765, "Products[", 1765, 9, true);
#nullable restore
#line 37 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1774, i, 1774, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1776, "].Price", 1776, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1784, "\"", 1817, 1);
#nullable restore
#line 37 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1792, Model.Products[@i].Price, 1792, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1861, "\"", 1891, 3);
                WriteAttributeValue("", 1868, "Products[", 1868, 9, true);
#nullable restore
#line 38 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1877, i, 1877, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1879, "].IsApproved", 1879, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1892, "\"", 1941, 1);
#nullable restore
#line 38 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 1900, Model.Products[@i].IsApproved.ToString(), 1900, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 39 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-8"">
        <div class=""row"">
            <div class=""col-md-12"">

                <table class=""table table-bordered table-sm"">
                    <thead>
                        <tr>
                            <td style=""width: 30px;"">Id</td>
                            <td style=""width: 100px;"">Image</td>
                            <td>Name</td>
                            <td style=""width: 20px;"">Price</td>
                            <td style=""width: 20px;"">Onaylı</td>
                            <td style=""width: 170px;""></td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 59 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                         if (Model.Products.Count > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                             foreach (var item in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 64 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "231979a4630b3cfd8a7ad9b8b422e1f7323606b128745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3013, "~/img/", 3013, 6, true);
#nullable restore
#line 65 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
AddHtmlAttributeValue("", 3019, item.ImageUrl, 3019, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n");
#nullable restore
#line 70 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                         if (item.IsApproved)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 73 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 77 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3782, "\"", 3820, 2);
            WriteAttributeValue("", 3789, "/admin/products/", 3789, 16, true);
#nullable restore
#line 80 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 3805, item.ProductId, 3805, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231979a4630b3cfd8a7ad9b8b422e1f7323606b132627", async() => {
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4071, "\"", 4094, 1);
#nullable restore
#line 82 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4079, item.ProductId, 4079, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 4180, "\"", 4205, 1);
#nullable restore
#line 83 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
WriteAttributeValue("", 4188, Model.CategoryId, 4188, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 89 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-warning\">\r\n                                <h3>No Products</h3>\r\n                            </div>\r\n");
#nullable restore
#line 96 "C:\Users\MURAT\Desktop\shopapp\shopapp.webui\Views\Admin\CategoryEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"/modules/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n<script src=\"/modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js\"></script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591