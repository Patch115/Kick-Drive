#pragma checksum "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Supervisores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9647bb1a3d386fd73c9fa881c37f6698c2f440ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KICKDRIVE.Pages.CRUDS.Pages_CRUDS_Supervisores), @"mvc.1.0.razor-page", @"/Pages/CRUDS/Supervisores.cshtml")]
namespace KICKDRIVE.Pages.CRUDS
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9647bb1a3d386fd73c9fa881c37f6698c2f440ba", @"/Pages/CRUDS/Supervisores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d674930805fb7016d7670fd2d64807892ec0b46", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CRUDS_Supervisores : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\perzd\3D Objects\ASP.NET\PROYECTO FINAL\KICKDRIVE\KICKDRIVE\Pages\CRUDS\Supervisores.cshtml"
  
    ViewData["Title"] = "Supervisores";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <h1>Kik Drive</h1>
    <h4 class=""text-center"">Kik Drive Mejorando el Gestionamineto</h4>
    <h5 class=""text-center"">Registrar Supervisores</h5>
    <div class=""containerCard"">
        <div class=""containercd"">

            <Content ID=""Content3"" ContentPlaceHolderID=""MainContent"" runat=""server"">
                <table>
                    <tr>
                        <td>
                            ID:
                        </td>
                        <td>
                            <TextBox ID=""txtName"" runat=""server"" required=""true""></TextBox>
                        </td>
                        <th>
                            <div class=""form-group"">
                                <input type=""text"" />
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            Nombre:
                        </td>
                        <td>
   ");
            WriteLiteral(@"                         <TextBox ID=""txtEmail"" runat=""server"" required=""true"" type=""Email""></TextBox>
                        </td>
                        <th>
                            <div class=""form-group"">
                                <input type=""text"" />
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            Apellido Paterno:
                        </td>
                        <td>
                            <TextBox ID=""txtPassword"" runat=""server"" required=""true"" type=""Password""></TextBox>
                        </td>
                        <th>
                            <div class=""form-group"">
                                <input type=""text"" />
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            Apellido Materno:
            ");
            WriteLiteral(@"            </td>
                        <td>
                            <TextBox ID=""txtConfirmPassword"" runat=""server"" required=""true"" type=""Password""></TextBox>
                        </td>
                        <th>
                            <div class=""form-group"">
                                <input type=""text"" />
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>
                            Usuario:
                        </td>
                        <td>
                            <TextBox ID=""txtAddress"" runat=""server"" required=""true"" TextMode=""MultiLine""></TextBox>
                        </td>
                        <th>
                            <div class=""form-group"">
                                <input type=""text"" />
                            </div>
                        </th>
                    </tr>
                    <tr>
                        <td>");
            WriteLiteral(@"
                            Contraseña:
                        </td>
                        <td>
                            <TextBox ID=""txtAddress"" runat=""server"" required=""true"" TextMode=""MultiLine""></TextBox>
                        </td>
                        <th>
                            <div class=""form-group"">
                                <input type=""text"" />
                            </div>
                        </th>
                    </tr>


                </table>
            </Content>
            <div class=""container"">

                <a class=""btn btn-primary"" href=""#"" role=""button"">Agregar</a>


                <a class=""btn btn-primary"" href=""#"" role=""button"">Eliminar</a>


                <a class=""btn btn-primary"" href=""#"" role=""button"">Actualizar</a>


                <a class=""btn btn-primary"" href=""#"" role=""button"">Consultar</a>

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KICKDRIVE.Pages.CRUDS.SupervisoresModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KICKDRIVE.Pages.CRUDS.SupervisoresModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KICKDRIVE.Pages.CRUDS.SupervisoresModel>)PageContext?.ViewData;
        public KICKDRIVE.Pages.CRUDS.SupervisoresModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
