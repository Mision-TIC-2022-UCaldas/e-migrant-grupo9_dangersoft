#pragma checksum "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018dcc27c1289ef88749a7fad77435cbd31f31d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrants.App.Frontend.Pages.Migrante.Pages_Migrante_Details), @"mvc.1.0.razor-page", @"/Pages/Migrante/Details.cshtml")]
namespace E_Migrants.App.Frontend.Pages.Migrante
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
#line 1 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\_ViewImports.cshtml"
using E_Migrants.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018dcc27c1289ef88749a7fad77435cbd31f31d8", @"/Pages/Migrante/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fcced4a1ecaedcf3c9f12ae470f19dd9b703ef7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrante_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2><b>Detalles del Migrante : ");
#nullable restore
#line 4 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                          Write(Model.Migrante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </b></h2><br>
<table>
    <tr>
        <th class=""tr"">Id</th>
        <th class=""tr"">Nombre</th>
        <th class=""tr"">Apellidos </th>
        <th class=""tr"">Tipo Documento</th>
        <th class=""tr"">Numero Documento</th>
        <th class=""tr"">Pais de Origen</th>
        <th class=""tr"">Fecha de Nacimiento</th>
        <th class=""tr"">Email</th>
        <th class=""tr"">Tel??fono</th>
        <th class=""tr"">Direccion Actual</th>
        <th class=""tr"">Ciudad</th>
        <th class=""tr"">Situacion Laboral</th>
    </tr>
    <tr class=""datos"">
        <td class=""td""> ");
#nullable restore
#line 21 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                   Write(Model.Migrante.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\">");
#nullable restore
#line 23 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\"> ");
#nullable restore
#line 25 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                   Write(Model.Migrante.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\">");
#nullable restore
#line 27 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.TipoDocumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\"> ");
#nullable restore
#line 29 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                   Write(Model.Migrante.NumeroDocumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\">");
#nullable restore
#line 31 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.PaisdeOrigen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"td\"> ");
#nullable restore
#line 32 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                   Write(Model.Migrante.FechaDeNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\">");
#nullable restore
#line 34 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\"> ");
#nullable restore
#line 36 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                   Write(Model.Migrante.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td class=\"td\">");
#nullable restore
#line 38 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.DireccionActual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"td\">");
#nullable restore
#line 39 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td class=\"td\">");
#nullable restore
#line 40 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                  Write(Model.Migrante.SituacionLaboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n</table><br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018dcc27c1289ef88749a7fad77435cbd31f31d89655", async() => {
                WriteLiteral(" <b> Migrantes</b> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018dcc27c1289ef88749a7fad77435cbd31f31d810904", async() => {
                WriteLiteral("<i class=\"fas fa-edit fa-lg\" aria-hidden=\"true\" style=\"color: black;\"> </i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MigranteID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\Details.cshtml"
                                                                 WriteLiteral(Model.Migrante.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MigranteID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MigranteID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MigranteID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Migrants.App.Frontend.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrants.App.Frontend.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrants.App.Frontend.Pages.DetailsModel>)PageContext?.ViewData;
        public E_Migrants.App.Frontend.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
