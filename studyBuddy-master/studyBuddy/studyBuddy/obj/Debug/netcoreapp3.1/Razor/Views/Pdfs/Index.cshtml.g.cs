#pragma checksum "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ac659240fa48964dee6ae5a29fe2247f580338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdfs_Index), @"mvc.1.0.view", @"/Views/Pdfs/Index.cshtml")]
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
#line 1 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\_ViewImports.cshtml"
using studyBuddy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\_ViewImports.cshtml"
using studyBuddy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ac659240fa48964dee6ae5a29fe2247f580338", @"/Views/Pdfs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843f3de005438f5de24500e030f25366af4a7218", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdfs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<studyBuddy.Models.Pdf>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-left:30px;margin-top:15px\">Arşiv indir</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("</p>\r\n<table class=\"table\" style=\"background-color: lightcoral; border:3px outset black; border-radius:2px 2px;margin-left:30px\" >\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ResimYolu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Term));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ResimYolu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Term.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
            WriteLiteral("\r\n\r\n            <td class=\"col-sm-10\">\r\n\r\n                <b>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65ac659240fa48964dee6ae5a29fe2247f5803387475", async() => {
                WriteLiteral("\r\n                        İndir\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1437, "~/resimler/", 1437, 11, true);
#nullable restore
#line 55 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
AddHtmlAttributeValue("", 1448, Html.DisplayFor(modelItem => item.ResimYolu), 1448, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </b>\r\n\r\n</td>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
             if (User.Identity.IsAuthenticated && User.Identity.Name == "admin@gmail.com")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n\r\n            <b> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65ac659240fa48964dee6ae5a29fe2247f5803389534", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</b>\r\n        </td>\r\n");
#nullable restore
#line 69 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\Muharrem\Desktop\Cet322Final\studyBuddy\studyBuddy-master\studyBuddy\studyBuddy\Views\Pdfs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<studyBuddy.Models.Pdf>> Html { get; private set; }
    }
}
#pragma warning restore 1591
