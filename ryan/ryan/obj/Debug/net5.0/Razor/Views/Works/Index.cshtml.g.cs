#pragma checksum "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcd6bfb3a4401d87388e5c371cc413bae48c4649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Works_Index), @"mvc.1.0.view", @"/Views/Works/Index.cshtml")]
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
#line 1 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\_ViewImports.cshtml"
using ryan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\_ViewImports.cshtml"
using ryan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\_ViewImports.cshtml"
using ryan.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\_ViewImports.cshtml"
using ryan.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd6bfb3a4401d87388e5c371cc413bae48c4649", @"/Views/Works/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3733b0b973ecc7a3abc7f0c8da36cbd744a1ed92", @"/Views/_ViewImports.cshtml")]
    public class Views_Works_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Works>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--
				Card - Works
			-->
			<div class=""card-inner animated active"" id=""works-card"">
				<div class=""card-wrap"">

					<!--
						Works
					-->
					<div class=""content works"">

						<!-- title -->
						<div class=""title"">Recent Works</div>");
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t<!-- content -->\r\n\t\t\t\t\t\t<div class=\"row grid-items border-line-v\">\r\n");
#nullable restore
#line 44 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
                             foreach (var item in Model)
						   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t   <!-- work item design -->\r\n\t\t\t\t\t\t\t<div class=\"col col-d-6 col-t-6 col-m-12 grid-item design border-line-h\">\r\n\t\t\t\t\t\t\t\t<div class=\"box-item\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"image\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#popup-2\" class=\"has-popup-media\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcd6bfb3a4401d87388e5c371cc413bae48c46494978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1569, "~/images/works/", 1569, 15, true);
#nullable restore
#line 51 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
AddHtmlAttributeValue("", 1584, item.ImagePath, 1584, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"info\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"ion ion-images\"></span>\r\n\t\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"desc\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#popup-2\" class=\"name has-popup-media\">");
#nullable restore
#line 58 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"category\">");
#nullable restore
#line 59 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
                                                         Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div id=\"popup-2\" class=\"popup-box mfp-fade mfp-hide\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"content\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"image\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcd6bfb3a4401d87388e5c371cc413bae48c46497714", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2069, "~/images/works/", 2069, 15, true);
#nullable restore
#line 64 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
AddHtmlAttributeValue("", 2084, item.ImagePath, 2084, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"desc\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"post-box\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<h1>");
#nullable restore
#line 68 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
                                                   Write(item.Head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"blog-detail\">");
#nullable restore
#line 69 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
                                                                        Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"blog-content\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 72 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2436, "\"", 2452, 1);
#nullable restore
#line 75 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
WriteAttributeValue("", 2443, item.Url, 2443, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"button\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"text\">View Project</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span class=\"arrow\"></span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 85 "C:\Users\CalenLoki\source\repos\ryan-folder\ryan\ryan\Views\Works\Index.cshtml"
						   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"clear\"></div>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Works>> Html { get; private set; }
    }
}
#pragma warning restore 1591
