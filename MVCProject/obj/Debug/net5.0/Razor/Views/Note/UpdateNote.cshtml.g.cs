#pragma checksum "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab046086b8415686b7a229d9966a4518ecb8cda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_UpdateNote), @"mvc.1.0.view", @"/Views/Note/UpdateNote.cshtml")]
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
#line 1 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab046086b8415686b7a229d9966a4518ecb8cda", @"/Views/Note/UpdateNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f87f51910e1016d2b81c8d4107669623c21b1e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Note_UpdateNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
  
    var item = ViewBag.Note;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ab046086b8415686b7a229d9966a4518ecb8cda4103", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"hidden\" class=\"form-control\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 212, "\"", 228, 1);
#nullable restore
#line 8 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
WriteAttributeValue("", 220, item.Id, 220, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"id\" />\r\n        <input type=\"text\" class=\"form-control\" id=\"title\"");
                BeginWriteAttribute("value", " value=\"", 309, "\"", 328, 1);
#nullable restore
#line 9 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
WriteAttributeValue("", 317, item.Title, 317, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Title\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"text\" class=\"form-control\" id=\"subtitle\"");
                BeginWriteAttribute("value", " value=\"", 457, "\"", 479, 1);
#nullable restore
#line 12 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
WriteAttributeValue("", 465, item.Subtitle, 465, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Subtitle\" />\r\n    </div>\r\n    <div id=\"summernote\">\r\n\r\n    </div>\r\n    ");
#nullable restore
#line 17 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
Write(Html.DropDownList("Categories", null, "Please select a category!", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 19 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
Write(Html.DropDownList("Tags",null, "Please select a tag!", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <button type=\"button\" onclick=\"Update()\" class=\"btn btn-primary\">Update</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote.min.js\"></script>\r\n    <script>\r\n  $(document).ready(function() {\r\n  $(\'#summernote\').summernote();\r\n  $(\'#summernote\').summernote(\'insertText\',\'");
#nullable restore
#line 30 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
                                       Write(item.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n  $(\'#Categories\').val(");
#nullable restore
#line 31 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
                  Write(item.CategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n  $(\'#Tags\').val(");
#nullable restore
#line 32 "C:\Users\lenovo\source\repos\MVCProject\MVCProject\Views\Note\UpdateNote.cshtml"
            Write(item.TagId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@");
});

     function Update() {
        var id = document.getElementById(""id"");
        var title = document.getElementById(""title"");
        var subtitle = document.getElementById(""subtitle"");
        var content = $('#summernote').summernote('code');
        var category = document.getElementById(""Categories"");
        var tag = document.getElementById(""Tags"");
        var form = document.getElementById(""form"");

       var formData = new FormData(form);
        formData.append(""id"",id.value);
        formData.append(""title"", title.value);
        formData.append(""subtitle"", subtitle.value);
        formData.append(""content"", content);
        formData.append(""categoryid"",category.value);
        formData.append(""tagid"",tag.value);

        var url = '/Note/Update';

        fetch(url, {
                method: 'POST',
                body: formData
            }).then(res => res.json())
            .then(result => {
                alert(""YOUR NOTE IS SUCCESSFULLY UPDATED!"");
 ");
                WriteLiteral("           })\r\n    }\r\n\r\n    </script>\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
