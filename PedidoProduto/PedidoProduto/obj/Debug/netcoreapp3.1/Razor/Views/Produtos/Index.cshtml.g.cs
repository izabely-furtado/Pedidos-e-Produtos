#pragma checksum "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f8509afc8ae9726228fd716aeb9f7159df0c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Index), @"mvc.1.0.view", @"/Views/Produtos/Index.cshtml")]
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
#line 1 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\_ViewImports.cshtml"
using PedidoProduto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\_ViewImports.cshtml"
using PedidoProduto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f8509afc8ae9726228fd716aeb9f7159df0c05", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d11f99e6f0d248db5f68650ab50322b6cb524c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"form-group\">\r\n            <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 132, "\"", 137, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Digite o nome"" />
            <small>Mensagem de erro.</small>
        </div>
    </div>
    <div class=""col-md-4"">
        <button type=""submit""
                class=""btn btn-default btn-theme-orange btn-block btn-outline"">
            Pesquisar
        </button>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">


        <!-- Tabelas -->

        <div class=""tabelas table-responsive"">
            <table class=""table table-striped table-bordered"">
                <tbody>
                    <tr>
                        <th>#</th>
                        <th>Nome</th>
                        <th>Ações</th>
                    </tr>
                    <tr>
                        <th scope=""row"">1</th>
                        <td>Izabely Almeida Furtado Corrêa</td>
                        <td>1</td>
                    </tr>
                    <tr>
                        <th scope=""row"">2</th>
                        <td>Izabely Almeida Furtado ");
            WriteLiteral(@"Corrêa</td>
                        <td>1</td>
                    </tr>
                    <tr>
                        <th scope=""row"">3</th>
                        <td>Izabely Almeida Furtado Corrêa</td>
                        <td>1</td>
                    </tr>
                </tbody>
            </table>
        </div>


        <!-- Paginação -->

        <div class=""paginacao centered"">
            <nav>
                <ul class=""pagination"">
                    <li class=""nav-icon"">
                        <a href=""#"" aria-label=""Anterior"">
                            <i class=""material-icons md-18"">first_page</i>
                        </a>
                    </li>
                    <li class=""nav-icon"">
                        <a href=""#"" aria-label=""Anterior"">
                            <i class=""material-icons md-18"">chevron_left</i>
                        </a>
                    </li>
                    <li><a href=""#"">48</a></li>
                    <li");
            WriteLiteral(@"><a href=""#"">49</a></li>
                    <li class=""active""><a href=""#"">50</a></li>
                    <li><a href=""#"">51</a></li>
                    <li><a href=""#"">52</a></li>
                    <li class=""nav-icon"">
                        <a href=""#"" aria-label=""Próximo"">
                            <i class=""material-icons md-18"">chevron_right</i>
                        </a>
                    </li>
                    <li class=""nav-icon"">
                        <a href=""#"" aria-label=""Próximo"">
                            <i class=""material-icons md-18"">last_page</i>
                        </a>
                    </li>
                </ul>
            </nav>
        </div>

    </div>
</div>


<div class=""row"">
    <div class=""col-md-12"">
        <button type=""submit"" class=""btn btn-default btn-theme-orange"">Enviar</button>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
