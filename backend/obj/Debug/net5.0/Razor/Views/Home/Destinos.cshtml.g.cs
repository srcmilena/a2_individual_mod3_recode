#pragma checksum "C:\Users\Milena\Documents\RecodePro\Hardskills\Módulo 3\Projeto_Modulo_03\CSharp_CRUD\site\Views\Home\Destinos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf3b619cdb1e4f8c8efe5c0ff69f952a1489327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Destinos), @"mvc.1.0.view", @"/Views/Home/Destinos.cshtml")]
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
#line 1 "C:\Users\Milena\Documents\RecodePro\Hardskills\Módulo 3\Projeto_Modulo_03\CSharp_CRUD\site\Views\_ViewImports.cshtml"
using site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Milena\Documents\RecodePro\Hardskills\Módulo 3\Projeto_Modulo_03\CSharp_CRUD\site\Views\_ViewImports.cshtml"
using site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf3b619cdb1e4f8c8efe5c0ff69f952a1489327", @"/Views/Home/Destinos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4905027877af4a4749cfbf023c0ec7fa3830a63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Destinos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Milena\Documents\RecodePro\Hardskills\Módulo 3\Projeto_Modulo_03\CSharp_CRUD\site\Views\Home\Destinos.cshtml"
   
    ViewData["Title"] = "Destinos"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf3b619cdb1e4f8c8efe5c0ff69f952a14893273389", async() => {
                WriteLiteral(@"

    <div class=""container"">

        <h1 align=""center"">Destinos</h1>

        <br><br><br><br>

        <table width=""100%"" border=""0"" cellpadding=""30"" =>

            <tr rowspan=""5"" width=""20%"" vertical-align=""top"">

            <tr>
                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1555881400-74d7acaacd8b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cG9ydHVnYWx8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 570, "\"", 576, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Porto, em Portugal</font>
                    <br>
                    <font size=""3"">R$5.380,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1561789474-cb8a3cb4e319?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTh8fGFyaXpvbmF8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 1064, "\"", 1070, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Arizona, nos Estados Unidos</font>
                    <br>
                    <font size=""3"">R$4.270,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1557974040-3bec341da09b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8c2FudGlhZ28lMjBjaGlsZXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 1581, "\"", 1587, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Santiago, no Chile</font>
                    <br>
                    <font size=""3"">R$2.789,00</font>
                </td>
            </tr>

            <tr>
                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://media.istockphoto.com/photos/iguacu-impressive-4-falls-and-green-rainforest-brazil-south-america-picture-id498014429?b=1&k=20&m=498014429&s=170667a&w=0&h=aw5mHQ3iGa5_9PpjDP8aAA_hPQAaWOMwR6xhV1ZJYmg=""");
                BeginWriteAttribute("alt", " alt=\"", 2156, "\"", 2162, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Foz do Iguaçu, no Brasil</font>
                    <br>
                    <font size=""3"">R$1.300,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1542649350-a24209ce01b5?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8bG9zJTIwYW5nZWxlc3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 2666, "\"", 2672, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Los Angeles, nos Estados Unidos</font>
                    <br>
                    <font size=""3"">R$5.180,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1528702748617-c64d49f918af?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8ZHViYWl8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 3172, "\"", 3178, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Dubai, nos Emirados Árabes</font>
                    <br>
                    <font size=""3"">R$7.880,00</font>
                </td>
            </tr>

            <tr>
                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1513326738677-b964603b136d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bW9zY293fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 3718, "\"", 3724, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Moscou, na Rússia</font>
                    <br>
                    <font size=""3"">R$4.190,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1559499841-9ce719342aa3?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGZyYW5rZnVydHxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 4217, "\"", 4223, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Frankfurt, na Alemanha</font>
                    <br>
                    <font size=""3"">R$3.4790,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1598135753163-6167c1a1ad65?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8aGF3YWlpfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 4723, "\"", 4729, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Kauai, no Havaí</font>
                    <br>
                    <font size=""3"">R$4.870,00</font>
                </td>
            </tr>

            <tr>
                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1560525942-fca0ea0acade?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTF8fG9zbG98ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 5247, "\"", 5253, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Oslo, na Noruega</font>
                    <br>
                    <font size=""3"">R$3.989,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1605538108568-7f0d77a214c1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8ZmlsaXBpbmFzfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 5750, "\"", 5756, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Palauan, em Filipinas</font>
                    <br>
                    <font size=""3"">R$4.379,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://media.istockphoto.com/photos/haci-bayram-mosque-park-in-ancara-turkey-picture-id1337043774?b=1&k=20&m=1337043774&s=170667a&w=0&h=XGIXZXuz5YthXpP_NHwxWbYnT05tvdorpnWdThfemZs=""");
                BeginWriteAttribute("alt", " alt=\"", 6266, "\"", 6272, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Ancara, na Turquia</font>
                    <br>
                    <font size=""3"">R$4.280,00</font>
                </td>
            </tr>

            <tr>
                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1461838239441-4475121c0b7d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTR8fGJydXNzZWxzfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 6808, "\"", 6814, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Bruxélas, na Bélgica</font>
                    <br>
                    <font size=""3"">R$4.780,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1586724229931-cd4cd3b50ddc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGR1YmxpbnxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 7309, "\"", 7315, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Dublim, na Irlanda</font>
                    <br>
                    <font size=""3"">R$6.970,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1581289068946-ba5dbd4f7911?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTd8fGxvbmRyZXN8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 7806, "\"", 7812, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Londres, na Inglaterra</font>
                    <br>
                    <font size=""3"">R$5.220,00</font>
                </td>
            </tr>

            <tr>
                <td width=""20%"" height=""30%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1605043622169-ef16575c1e6c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjB8fG1pbmFzJTIwZ2VyYWlzfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 8373, "\"", 8379, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Minas Gerais, no Brasil</font>
                    <br>
                    <font size=""3"">R$565,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://cache.quantocustaviajar.com/blog/wp-content/uploads/2015/09/canions-no-brasil-canion-do-buracao-768x576.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8823, "\"", 8829, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Bahia, no Brasil</font>
                    <br>
                    <font size=""3"">R$850,00</font>
                </td>

                <td width=""20%"" align=""center"" vertical-align=""bottom"">
                    <img src=""https://images.unsplash.com/photo-1519677788145-49ecdd6cb4f9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8cm9yYWltYXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60""");
                BeginWriteAttribute("alt", " alt=\"", 9318, "\"", 9324, 0);
                EndWriteAttribute();
                WriteLiteral(@" width=""300"" height=""250"">
                    <br>
                    <font size=""4"">Roraima, no Brasil</font>
                    <br>
                    <font size=""3"">R$2.210,00</font>
                </td>
            </tr>

            </tr>
        </table>

        <br><br><br><br><br>

        <center>
            <img src=""https://img.icons8.com/external-vitaliy-gorbachev-fill-vitaly-gorbachev/60/000000/external-credit-card-online-shopping-vitaliy-gorbachev-fill-vitaly-gorbachev-1.png""");
                BeginWriteAttribute("alt", " alt=\"", 9841, "\"", 9847, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"50\" class=\"footerImg\" />\r\n        </center>\r\n\r\n    </div>\r\n");
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
