#pragma checksum "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f15a16f7bca30625aa542bfdd6837ed9d5e387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ShowBook), @"mvc.1.0.view", @"/Views/Book/ShowBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/ShowBook.cshtml", typeof(AspNetCore.Views_Book_ShowBook))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f15a16f7bca30625aa542bfdd6837ed9d5e387", @"/Views/Book/ShowBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca04e658dbd9e9d8224f87a475406fe1a7e81cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ShowBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MultipleViewModel>
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
#line 2 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
  
    ViewData["Title"] = "SearchBook";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 134, true);
            WriteLiteral("\r\n<style>\r\n    .font-style {\r\n        font-family: sans-serif;\r\n        font-weight: bold;\r\n        color: black;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(253, 570, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8edca8618d5e4e0d8e1cfee1c8984dfc", async() => {
                BeginContext(408, 63, true);
                WriteLiteral("\r\n    <select class=\"w3-select\" name=\"type\" required>\r\n        ");
                EndContext();
                BeginContext(471, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8bb195b9234e2792cedf044a6f73dc", async() => {
                    BeginContext(493, 5, true);
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
                BeginContext(507, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(517, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "522811334534477c88c820280c9819e1", async() => {
                    BeginContext(540, 6, true);
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
                BeginContext(555, 261, true);
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
            BeginContext(823, 221, true);
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center;\">Search Results</h1> \r\n\r\n<div id=\"bookCard\" class=\"card mb-3\" style=\"max-width: 55%; margin:auto; cursor:pointer;\">\r\n  <div class=\"row no-gutters\">\r\n    <div class=\"col-md-4\">\r\n      <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1044, "\"", 1070, 1);
#line 29 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
WriteAttributeValue("", 1050, Model.book.imageURL, 1050, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1071, 132, true);
            WriteLiteral(" class=\"card-img\" alt=\"...\">\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n      <div class=\"card-body\">\r\n        <h2 class=\"card-title\">");
            EndContext();
            BeginContext(1204, 15, false);
#line 33 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                          Write(Model.book.name);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 36, true);
            WriteLiteral("</h2>\r\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(1256, 22, false);
#line 34 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                        Write(Model.book.description);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 61, true);
            WriteLiteral("</p>\r\n        <p class=\"card-text\"><small class=\"text-muted\">");
            EndContext();
            BeginContext(1340, 17, false);
#line 35 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                  Write(Model.author.name);

#line default
#line hidden
            EndContext();
            BeginContext(1357, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1359, 20, false);
#line 35 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                                     Write(Model.author.surname);

#line default
#line hidden
            EndContext();
            BeginContext(1379, 269, true);
            WriteLiteral(@"</small></p>
      </div>
    </div>
  </div>
</div>

<div class=""w3-container"">
    <div id=""bookDetails"" class=""w3-modal"">
        <div class=""w3-modal-content w3-card-4 w3-animate-zoom"" style=""max-width:600px;"">

            <h1 style=""text-align:center;"">");
            EndContext();
            BeginContext(1649, 15, false);
#line 45 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                      Write(Model.book.name);

#line default
#line hidden
            EndContext();
            BeginContext(1664, 65, true);
            WriteLiteral("</h1>\r\n\r\n            <p style=\"text-align:center\">Category Name: ");
            EndContext();
            BeginContext(1730, 23, false);
#line 47 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                   Write(Model.book.categoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1753, 61, true);
            WriteLiteral("</p>\r\n            <p style=\"text-align:center\">Library Name: ");
            EndContext();
            BeginContext(1815, 18, false);
#line 48 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                  Write(Model.library.name);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 64, true);
            WriteLiteral("</p>\r\n            <p style=\"text-align:center\">Library Address: ");
            EndContext();
            BeginContext(1898, 21, false);
#line 49 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                     Write(Model.library.address);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 60, true);
            WriteLiteral("</p>\r\n            <p style=\"text-align:center\">Library Tel: ");
            EndContext();
            BeginContext(1980, 17, false);
#line 50 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                 Write(Model.library.tel);

#line default
#line hidden
            EndContext();
            BeginContext(1997, 63, true);
            WriteLiteral("</p>\r\n            <p style=\"text-align:center\">Library E-Mail: ");
            EndContext();
            BeginContext(2061, 19, false);
#line 51 "C:\Users\ozibuo\Desktop\Projects\AkıllıKütüphane\LibraryProject\LibraryProject\Views\Book\ShowBook.cshtml"
                                                    Write(Model.library.email);

#line default
#line hidden
            EndContext();
            BeginContext(2080, 498, true);
            WriteLiteral(@"</p>

            <div class=""w3-container w3-border-top w3-padding-16 w3-light-grey"">
                <button style=""width:100%;"" onclick=""document.getElementById('bookDetails').style.display='none'"" type=""button"" class=""w3-button w3-red"">Cancel</button>
            </div>

        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $(""#bookCard"").click(function () {
            $(""#bookDetails"").css(""display"", ""block"");
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultipleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
