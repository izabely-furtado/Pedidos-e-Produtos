#pragma checksum "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88bb4a58857cc5fca5f6868a50b0a86fc019fc0d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bb4a58857cc5fca5f6868a50b0a86fc019fc0d", @"/Views/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d11f99e6f0d248db5f68650ab50322b6cb524c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("material-icons btn btn-default btn-block btn-theme-orange"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-transform: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("material-icons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: 0px; background-color: transparent;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-8"">
        <div class=""form-group"">
            <input type=""text"" class=""form-control"" id=""pesquisar"" name=""pesquisar"" placeholder=""Digite o nome"" />
            <small>Mensagem de erro.</small>
        </div>
    </div>
    <div class=""col-md-3"">
        <button type=""submit"" value=""Index""
                class=""btn btn-default btn-theme-orange btn-block btn-outline"">
            Pesquisar
        </button>
    </div>
    <div class=""col-md-1"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88bb4a58857cc5fca5f6868a50b0a86fc019fc0d5796", async() => {
                WriteLiteral("add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n\r\n        <!-- Alerta Sucesso -->\r\n");
#nullable restore
#line 25 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
         if ((bool)ViewBag.existSucess)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-success alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <strong>Sucesso!</strong> Usar para mensagens de sucesso.
            </div>
");
#nullable restore
#line 31 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- Alerta Error -->\r\n");
#nullable restore
#line 34 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
         if ((bool)ViewBag.existError)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-danger alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <strong>Erro!</strong> ");
#nullable restore
#line 38 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                                  Write(ViewBag.msgError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 40 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Tabelas -->

        <div class=""tabelas table-responsive"">
            <table class=""table table-striped table-bordered"">
                <tbody>
                    <tr>
                        <th>#</th>
                        <th>Nome</th>
                        <th width=""10%"">Ações</th>
                    </tr>
");
#nullable restore
#line 51 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                     foreach (PedidoProduto.Entities.Produto item in (List<PedidoProduto.Entities.Produto>)ViewBag.produtos)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 54 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                           Write(item.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88bb4a58857cc5fca5f6868a50b0a86fc019fc0d10724", async() => {
                WriteLiteral("edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                                                                                                                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88bb4a58857cc5fca5f6868a50b0a86fc019fc0d13228", async() => {
                WriteLiteral("delete_forever");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                                                                                                                                        WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>
        </div>


        <!-- Paginação -->
        <!--
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
                                <li><a href=""#"">49</a></li>
                                <li class=""active""><a href");
            WriteLiteral(@"=""#"">50</a></li>
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
        !-->
    </div>
</div>



<script type=""text/javascript"">
          function Edit(item)
          {
              item.inEdition = true;
          //window.location.href = ");
#nullable restore
#line 114 "C:\Users\Izabely\source\repos\Pedidos-e-Produtos\PedidoProduto\PedidoProduto\Views\Produtos\Index.cshtml"
                              Write(Url.Action("Edit", "Produtos", new { @id = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        }\r\n\r\n\r\n</script>\r\n\r\n");
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
