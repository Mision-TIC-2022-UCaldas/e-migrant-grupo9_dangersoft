#pragma checksum "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d51e5124793dbf8cc312302bd7a8820e5979384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(E_Migrants.App.Frontend.Pages.Migrante.Pages_Migrante_List), @"mvc.1.0.razor-page", @"/Pages/Migrante/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d51e5124793dbf8cc312302bd7a8820e5979384", @"/Pages/Migrante/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fcced4a1ecaedcf3c9f12ae470f19dd9b703ef7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrante_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./FormMigrante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h1>Listado Migrantes</h1>
<table>
    <tr>
        <th class=""tr"">Nombre</th>
        <th class=""tr"">Apellidos </th>
        <th class=""tr"">Numero Documento</th>
        <th class=""tr"">Pais de Origen</th>
        <th class=""tr"">Email</th>
        <th class=""tr"">Ciudad</th>
        <th class=""tr"">Situacion Laboral</th>
    </tr>
");
#nullable restore
#line 16 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
     foreach (var Migrante in Model.Migrante)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"datos\">\r\n            <td class=\"td\">");
#nullable restore
#line 19 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">");
#nullable restore
#line 20 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">");
#nullable restore
#line 21 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.NumeroDocumento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">");
#nullable restore
#line 22 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.PaisdeOrigen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">");
#nullable restore
#line 23 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">");
#nullable restore
#line 24 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"td\">");
#nullable restore
#line 25 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                      Write(Migrante.SituacionLaboral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td class=\"botones\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d51e5124793dbf8cc312302bd7a8820e59793847927", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle fa-lg\" aria-hidden=\"true\"></i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MigranteID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                                                                                    WriteLiteral(Migrante.Id);

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
            WriteLiteral("\r\n            </td>\r\n            <td class=\"botones\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d51e5124793dbf8cc312302bd7a8820e597938410483", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-trash-alt fa-lg\" aria-hidden=\"true\" style=\"color: white;\"> </i>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MigranteID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
                                                                                   WriteLiteral(Migrante.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Asus\Documents\Hackaton\Dangersoft\e-migrant-grupo9_dangersoft\E-Migrants\E-Migrants.App\E-Migrants.App.Frontend\Pages\Migrante\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table><br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d51e5124793dbf8cc312302bd7a8820e597938413313", async() => {
                WriteLiteral("<b>registrar Migrante</b> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Migrants.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrants.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Migrants.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public E_Migrants.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
