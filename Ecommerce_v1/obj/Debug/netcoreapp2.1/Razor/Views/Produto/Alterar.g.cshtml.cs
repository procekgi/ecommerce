#pragma checksum "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76221c83919cffc9a216f6ff2b6bef2a6f1d33a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Alterar), @"mvc.1.0.view", @"/Views/Produto/Alterar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Alterar.cshtml", typeof(AspNetCore.Views_Produto_Alterar))]
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
#line 1 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\_ViewImports.cshtml"
using Ecommerce_v1;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\_ViewImports.cshtml"
using Ecommerce_v1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76221c83919cffc9a216f6ff2b6bef2a6f1d33a7", @"/Views/Produto/Alterar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3a1cf5efcb3fc6edf8b5787e87468ef47f5fa94", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Alterar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alterar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml"
  
    Produto produto = ViewBag.Produto;

#line default
#line hidden
            BeginContext(49, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(78, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b774f99dce4e8b99dd81711641c9b7", async() => {
                BeginContext(84, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Alterar</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(182, 685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1940506772ba4ba9b618902c61f3a335", async() => {
                BeginContext(188, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(196, 662, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88b89867842646fdb25e94d604c65db3", async() => {
                    BeginContext(237, 71, true);
                    WriteLiteral("\r\n\r\n        <label>Id:</label>\r\n        <input type=\"text\" name=\"txtId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 308, "\"", 334, 1);
#line 18 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 316, produto.ProdutoId, 316, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(335, 95, true);
                    WriteLiteral(" readonly=\"\"/><br />\r\n\r\n        <label>Nome:</label>\r\n        <input type=\"text\" name=\"txtNome\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 430, "\"", 451, 1);
#line 21 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 438, produto.Nome, 438, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(452, 94, true);
                    WriteLiteral(" /><br />\r\n\r\n        <label>Descrição:</label>\r\n        <input type=\"text\" name=\"txtDescricao\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 546, "\"", 572, 1);
#line 24 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 554, produto.Descricao, 554, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(573, 77, true);
                    WriteLiteral(" /><br />\r\n\r\n        <label>Preço:</label> <input type=\"text\" name=\"txtPreco\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 650, "\"", 672, 1);
#line 26 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 658, produto.Preco, 658, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(673, 85, true);
                    WriteLiteral(" /><br />\r\n        <label>Quantidade:</label> <input type=\"text\" name=\"txtQuantidade\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 758, "\"", 785, 1);
#line 27 "C:\Users\Aluno\Desktop\ecommerce\ecommerce\Ecommerce_v1\Views\Produto\Alterar.cshtml"
WriteAttributeValue("", 766, produto.Quantidade, 766, 19, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(786, 65, true);
                    WriteLiteral(" /><br />\r\n\r\n        <input type=\"submit\" value=\"Salvar\" />\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(858, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(867, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591