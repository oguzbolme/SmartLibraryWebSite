#pragma checksum "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d703d0645b5f260f2924be1e825ae33b44be384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ShowBooks), @"mvc.1.0.view", @"/Views/Book/ShowBooks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/ShowBooks.cshtml", typeof(AspNetCore.Views_Book_ShowBooks))]
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
#line 1 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\_ViewImports.cshtml"
using LibraryProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d703d0645b5f260f2924be1e825ae33b44be384", @"/Views/Book/ShowBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca04e658dbd9e9d8224f87a475406fe1a7e81cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ShowBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MultipleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "author", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:20px;padding:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-container w3-light-grey w3-round font-style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
  
    ViewData["Title"] = "ShowBooks";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(118, 134, true);
            WriteLiteral("\r\n<style>\r\n    .font-style {\r\n        font-family: sans-serif;\r\n        font-weight: bold;\r\n        color: black;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(252, 570, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2518fddaff8451b80546ff48748869f", async() => {
                BeginContext(407, 63, true);
                WriteLiteral("\r\n    <select class=\"w3-select\" name=\"type\" required>\r\n        ");
                EndContext();
                BeginContext(470, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7084785466f34484994b85e3d63ec1cb", async() => {
                    BeginContext(492, 5, true);
                    WriteLiteral("Title");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(506, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(516, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60ef4f03f1314dc58a738bbdba9f504f", async() => {
                    BeginContext(539, 6, true);
                    WriteLiteral("Author");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(554, 261, true);
                WriteLiteral(@"
    </select>
    <input style=""margin-top:10px;"" class=""w3-input w3-border"" type=""text"" placeholder=""Search Title or Author ..."" name=""input"" required>
    <button type=""submit"" style=""margin-top:10px;"" class=""w3-button w3-block w3-black"">Search</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(822, 58, true);
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center;\">Search Results</h1>\r\n\r\n");
            EndContext();
#line 26 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
 foreach (var book in Model.Books)
{

#line default
#line hidden
            BeginContext(919, 176, true);
            WriteLiteral("    <div class=\"card mb-3\" style=\"max-width: 55%; margin:auto; cursor:pointer;\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-4\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1095, "\"", 1115, 1);
#line 31 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
WriteAttributeValue("", 1101, book.imageURL, 1101, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1116, 170, true);
            WriteLiteral(" class=\"card-img\" alt=\"...\">\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                <div class=\"card-body\">\r\n                    <h2 class=\"card-title\">");
            EndContext();
            BeginContext(1287, 9, false);
#line 35 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
                                      Write(book.name);

#line default
#line hidden
            EndContext();
            BeginContext(1296, 48, true);
            WriteLiteral("</h2>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(1345, 16, false);
#line 36 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
                                    Write(book.description);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 73, true);
            WriteLiteral("</p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(1435, 17, false);
#line 37 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
                                                              Write(Model.author.name);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1454, 20, false);
#line 37 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
                                                                                 Write(Model.author.surname);

#line default
#line hidden
            EndContext();
            BeginContext(1474, 86, true);
            WriteLiteral("</small></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 42 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBooks.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultipleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
