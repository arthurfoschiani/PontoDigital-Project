#pragma checksum "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "134761ed6f7cea3c4a53b3c08b105d0e15cd17ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DashBoard/Index.cshtml", typeof(AspNetCore.Views_DashBoard_Index))]
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
#line 1 "D:\Projeto-Final\Ponto Digital\Views\_ViewImports.cshtml"
using Ponto_Digital;

#line default
#line hidden
#line 2 "D:\Projeto-Final\Ponto Digital\Views\_ViewImports.cshtml"
using Ponto_Digital.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"134761ed6f7cea3c4a53b3c08b105d0e15cd17ad", @"/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa2546c2e69693715ef3310f7b6936c7e7ed6ed5", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ponto_Digital.ViewModel.DepoimentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
  
    var User = (string) ViewData["User"];
    var tipo = (string) ViewData["Tipo"];

#line default
#line hidden
            BeginContext(147, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ac84bb9fbceb41ba9bd1853c685c7709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 365, true);
            WriteLiteral(@"
<h2>Quantidade de...</h2>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Usuários Cadastrados</th>
            <th scope=""col"">Depoimentos</th>
            <th scope=""col"">Depoimentos aprovados</th>
            <th scope=""col"">Depoimentos reprovados</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
            EndContext();
            BeginContext(563, 17, false);
#line 20 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(Model.NumUsuarios);

#line default
#line hidden
            EndContext();
            BeginContext(580, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(604, 20, false);
#line 21 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(Model.NumDepoimentos);

#line default
#line hidden
            EndContext();
            BeginContext(624, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(648, 29, false);
#line 22 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(Model.NumDepoimentosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(677, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(701, 30, false);
#line 23 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(Model.NumDepoimentosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(731, 486, true);
            WriteLiteral(@"</td>
        </tr>
    </tbody>
</table>
<h2>Lista de Usuários Cadastrados</h2>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nome Completo</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Senha</th>
            <th scope=""col"">Plano</th>
            <th scope=""col"">Data de Nascimento</th>
            <th scope=""col"">Tipo de Usuario</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 41 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
         foreach (var item in Model.UltimosUsuarios)
        {

#line default
#line hidden
            BeginContext(1282, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1321, 7, false);
#line 44 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1356, 9, false);
#line 45 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1365, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1393, 10, false);
#line 46 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1403, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1431, 10, false);
#line 47 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(1441, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1469, 15, false);
#line 48 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.Plano.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1484, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1512, 39, false);
#line 49 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1551, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1579, 16, false);
#line 50 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
               Write(item.TipoUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1632, 370, true);
            WriteLiteral(@"    </tbody>
</table>
<h2>Lista de Depoimentos</h2>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nome Usuario</th>
            <th scope=""col"">Data da publicação</th>
            <th scope=""col"">Depoimento</th>
            <th scope=""col"">Status</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 67 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
         foreach (var item in Model.UltimosDepoimentos)
        {   

#line default
#line hidden
            BeginContext(2073, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(2104, 7, false);
#line 70 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2111, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2135, 16, false);
#line 71 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(item.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(2151, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2175, 22, false);
#line 72 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(item.HorarioPublicacao);

#line default
#line hidden
            EndContext();
            BeginContext(2197, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2221, 15, false);
#line 73 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(item.Depoimento);

#line default
#line hidden
            EndContext();
            BeginContext(2236, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2260, 11, false);
#line 74 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2271, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "D:\Projeto-Final\Ponto Digital\Views\DashBoard\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2304, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ponto_Digital.ViewModel.DepoimentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591