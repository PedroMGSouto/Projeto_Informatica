#pragma checksum "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70da4faebba44f83ea63a9c58009654c33aded0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treinos_Details), @"mvc.1.0.view", @"/Views/Treinos/Details.cshtml")]
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
#line 1 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\_ViewImports.cshtml"
using Pmat_PI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\_ViewImports.cshtml"
using Pmat_PI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70da4faebba44f83ea63a9c58009654c33aded0", @"/Views/Treinos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b97d6517ca406d5cb3b460390988d76018843a24", @"/Views/_ViewImports.cshtml")]
    public class Views_Treinos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pmat_PI.Models.Treino>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Treino</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeProva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeProva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCriacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCriacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxEscolas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxEscolas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxTentJogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxTentJogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TempoTotalJogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TempoTotalJogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumNiveis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumNiveis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VidasPorNivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.VidasPorNivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumElemsEquipa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumElemsEquipa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calculadora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Calculadora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estilo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estilo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TreinoVisivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TreinoVisivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RefIdCicloEnsino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.RefIdCicloEnsino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Plataforma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Plataforma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdAuthorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdAuthorNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdCompeticaoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdCompeticaoNavigation.Etiqueta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70da4faebba44f83ea63a9c58009654c33aded014694", async() => {
                WriteLiteral("Edit");
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
#line 112 "C:\Pedro Souto\repos\Projeto_Informatica\Pmat-PI\Pmat-PI\Views\Treinos\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70da4faebba44f83ea63a9c58009654c33aded016844", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pmat_PI.Models.Treino> Html { get; private set; }
    }
}
#pragma warning restore 1591
