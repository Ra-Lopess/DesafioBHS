#pragma checksum "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc71743ab349b8529b4124be8da848247b167302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_PedidoSearch), @"mvc.1.0.view", @"/Views/Pedido/PedidoSearch.cshtml")]
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
#line 1 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\_ViewImports.cshtml"
using ToBuy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\_ViewImports.cshtml"
using ToBuy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc71743ab349b8529b4124be8da848247b167302", @"/Views/Pedido/PedidoSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c1bc888ca36745d1126da4d91175b215cefd1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_PedidoSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PedidoRemove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-flash-border-primary text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PedidoRestore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-flash-border-primary text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
  
    ViewData["Title"] = "Pedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
         foreach (var viewModel in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <div class=\"card card-margin\">\r\n                    <div class=\"card-header no-border\">\r\n                        <h5 class=\"card-title\">Pedido ");
#nullable restore
#line 15 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                 Write(viewModel.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    </div>
                    <div class=""card-body pt-0"">
                        <div class=""widget-49"">
                            <div class=""widget-49-title-wrapper"">
                                <div class=""widget-49-date-primary"">
");
#nullable restore
#line 21 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                     if (@viewModel.Status == "A")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-shopping-cart fa-2x text-success\"></i>\r\n");
#nullable restore
#line 24 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-shopping-cart fa-2x text-danger\"></i>\r\n");
#nullable restore
#line 28 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"widget-49-meeting-info\">\r\n                                    <span class=\"widget-49-pro-title\">");
#nullable restore
#line 31 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                                 Write(viewModel.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"widget-49-meeting-time\">");
#nullable restore
#line 32 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                                    Write(viewModel.Datapedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <ol class=\"widget-49-meeting-points\">\r\n");
#nullable restore
#line 36 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                 foreach (var itens in @viewModel.Itens)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"widget-49-meeting-item\"><span>");
#nullable restore
#line 38 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                                        Write(itens.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 39 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </ol>\r\n                            <hr>\r\n                            <div class=\"row widget-49-meeting-action\">\r\n                                <a class=\"widget-49-meeting-item ml-auto pr-4\">");
#nullable restore
#line 44 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                                          Write(viewModel.Valorpedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                            <div class=\"widget-49-meeting-action\">\r\n");
#nullable restore
#line 47 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                 if (@viewModel.Status == "A")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc71743ab349b8529b4124be8da848247b1673029873", async() => {
                WriteLiteral("Remover");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                                       WriteLiteral(viewModel.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc71743ab349b8529b4124be8da848247b16730212691", async() => {
                WriteLiteral("Restaurar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                                                        WriteLiteral(viewModel.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 64 "C:\Users\raiss\source\repos\ToBuy\ToBuy\Views\Pedido\PedidoSearch.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
