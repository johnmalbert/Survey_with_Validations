#pragma checksum "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c56679e8395f93fcd87c3ab1d27fe03693ee39bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Survey), @"mvc.1.0.view", @"/Views/Home/Survey.cshtml")]
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
#line 1 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\_ViewImports.cshtml"
using Dojo_Survey_Validations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
using Dojo_Survey_Validations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c56679e8395f93fcd87c3ab1d27fe03693ee39bf", @"/Views/Home/Survey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c884b670fdb328e594b54279446d5c98ab3e728d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Survey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c56679e8395f93fcd87c3ab1d27fe03693ee39bf3358", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css""
        integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    <title>Dojo Survey</title>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c56679e8395f93fcd87c3ab1d27fe03693ee39bf4762", async() => {
                WriteLiteral("\r\n    <div class=\"container p-5\">\r\n        <h1 style=\"text-align: center;\">Results</h1>            \r\n        <h1>Name: <span> ");
#nullable restore
#line 17 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h1>\r\n        <h2>Dojo Location: <span> ");
#nullable restore
#line 18 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
                             Write(Model.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h2>\r\n        <h2>Favorite Language: <span> ");
#nullable restore
#line 19 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
                                 Write(Model.Lang);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h2>\r\n        <h2>Comment: \r\n");
#nullable restore
#line 21 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
         if(@Model.Comment == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>No Comment</span>\r\n");
#nullable restore
#line 24 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>");
#nullable restore
#line 27 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
             Write(Model.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> \r\n");
#nullable restore
#line 28 "C:\Users\johnm\Documents\Coding_Dojo\C#\Assignments\MVC\Dojo_Survey_Validations\Views\Home\Survey.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </h2>\r\n    </div>\r\n    <div class=\"col text-center mt-5\">\r\n        <a href=\"/\"><button class=\"btn btn-primary mt-3\">Retake Survey</button></a>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
