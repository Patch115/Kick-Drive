#pragma checksum "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7fdafc9b7a711b30cf7b0cad9d11b538cea8f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KICKDRIVE.Pages.CRUDS.Parada.Pages_CRUDS_Parada_Details), @"mvc.1.0.razor-page", @"/Pages/CRUDS/Parada/Details.cshtml")]
namespace KICKDRIVE.Pages.CRUDS.Parada
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
#line 1 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\_ViewImports.cshtml"
using KICKDRIVE;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7fdafc9b7a711b30cf7b0cad9d11b538cea8f7a", @"/Pages/CRUDS/Parada/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d674930805fb7016d7670fd2d64807892ec0b46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CRUDS_Parada_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Parada</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.Incidentes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.Incidentes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.Tipo_incidente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.Tipo_incidente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.Ruta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.Ruta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.CreateAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.CreateAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.UpdateAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.UpdateAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Parada.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
       Write(Html.DisplayFor(model => model.Parada.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7fdafc9b7a711b30cf7b0cad9d11b538cea8f7a9558", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Parada\Details.cshtml"
                           WriteLiteral(Model.Parada.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7fdafc9b7a711b30cf7b0cad9d11b538cea8f7a11728", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KICKDRIVE.Pages.CRUDS.Parada.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KICKDRIVE.Pages.CRUDS.Parada.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KICKDRIVE.Pages.CRUDS.Parada.DetailsModel>)PageContext?.ViewData;
        public KICKDRIVE.Pages.CRUDS.Parada.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
