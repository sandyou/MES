#pragma checksum "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0d9a0e56addd6142c0ff0ba599bd81b6cb934f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Information_Page), @"mvc.1.0.view", @"/Views/Home/Information_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Information_Page.cshtml", typeof(AspNetCore.Views_Home_Information_Page))]
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
#line 1 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\_ViewImports.cshtml"
using MES_MVC;

#line default
#line hidden
#line 2 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\_ViewImports.cshtml"
using MES_MVC.Models;

#line default
#line hidden
#line 2 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a0d9a0e56addd6142c0ff0ba599bd81b6cb934f", @"/Views/Home/Information_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Information_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                       
    Layout=null;
    DataTable dt = (DataTable)ViewData["Table"];

#line default
#line hidden
            BeginContext(100, 64, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(164, 571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a0d9a0e56addd6142c0ff0ba599bd81b6cb934f4593", async() => {
                BeginContext(170, 311, true);
                WriteLiteral(@"
<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8""/>
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css"" integrity=""sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4"" crossorigin=""anonymous""/>
<!-- Our Custom CSS -->
");
                EndContext();
                BeginContext(481, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a0d9a0e56addd6142c0ff0ba599bd81b6cb934f5296", async() => {
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
                BeginContext(529, 199, true);
                WriteLiteral("\r\n<!-- Scrollbar Custom CSS -->\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css\"/>\r\n    <title>各類資訊</title>\r\n");
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
            BeginContext(735, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(737, 5227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a0d9a0e56addd6142c0ff0ba599bd81b6cb934f7634", async() => {
                BeginContext(743, 235, true);
                WriteLiteral("\r\n    <div style=\"padding:20px;margin:0 auto;width:60%\">\r\n        <br>        \r\n        <table class=\"table table-hover table-pro\">\r\n            <tbody>\r\n                <tr>\r\n                    <th>產品代號</th>\r\n                    <td>");
                EndContext();
                BeginContext(979, 21, false);
#line 25 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                   Write(ViewData["ProductId"]);

#line default
#line hidden
                EndContext();
                BeginContext(1000, 127, true);
                WriteLiteral("</td>\r\n                </tr>                \r\n                <tr>\r\n                    <th>產品名稱</th>\r\n                    <td>");
                EndContext();
                BeginContext(1128, 23, false);
#line 29 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                   Write(ViewData["ProductName"]);

#line default
#line hidden
                EndContext();
                BeginContext(1151, 699, true);
                WriteLiteral(@"</td>
                </tr>                
            </tbody>
        </table>
    </div> 
    <div class=""line""></div>
    <h1 style=""font-weight:bold;text-align:center"">產品道次資訊</h1>
    <div id=""content"">        
        <!-- <asp:DataGrid ID=""datagrid_process"" CssClass=""table  table-hover"" ></asp:DataGrid>    -->
        <table id=""datagrid_process"" class=""table table-hover"">            
            <thead class=""thead-light"">
                <tr>
                <th>道次編號</th>  
                <th>道次名稱</th>
                <th>機台編號</th>
                <th>機台名稱</th>                                      
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 48 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                     for(int i =0;i<dt.Rows.Count;i++)
                    {

#line default
#line hidden
                BeginContext(1929, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1992, 13, false);
#line 51 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                           Write(dt.Rows[i][0]);

#line default
#line hidden
                EndContext();
                BeginContext(2005, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2045, 13, false);
#line 52 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                           Write(dt.Rows[i][1]);

#line default
#line hidden
                EndContext();
                BeginContext(2058, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2098, 13, false);
#line 53 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                           Write(dt.Rows[i][2]);

#line default
#line hidden
                EndContext();
                BeginContext(2111, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(2151, 13, false);
#line 54 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                           Write(dt.Rows[i][3]);

#line default
#line hidden
                EndContext();
                BeginContext(2164, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 56 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Information_Page.cshtml"
                    }

#line default
#line hidden
                BeginContext(2225, 3732, true);
                WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""line""></div>
     <!-- <h1 style=""font-weight:bold;text-align:center"">產品道次資訊</h1>
        <div id=""content"">                        
            <table id=""Process_Table"" class=""table table-hover"">
            <thead class=""thead-light"">
                <tr>
                <th>人員編號</th>  
                <th>機台編號</th>
                <th>產品代號</th>
                <th>產品名稱</th>
                <th>道次編號</th>
                <th>目前道次名稱</th>
                <th>執行工令編號</th>                                              
                </tr>
            </thead>
            <tbody id=""process_body"">

            </tbody>
        </table>
        </div>             -->
       
    

    <!-- jQuery CDN - Slim version (=without AJAX) -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <");
                WriteLiteral(@"script src=""https://code.jquery.com/jquery-3.2.1.min.js"" ></script>
    <!-- Popper.JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js"" integrity=""sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ"" crossorigin=""anonymous""></script>
    <!-- Bootstrap JS -->
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js"" integrity=""sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm"" crossorigin=""anonymous""></script>
    <!-- jQuery Custom Scroller CDN -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.concat.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            //增加表頭
            $(""#datagrid tr:first,#datagrid_process tr:first"").wrap(""<thead></thead>""); 
            $(""#datagrid thead"").insertBefore(""#datagrid tbody"").addClass(""thead-light"");
            $(""#data");
                WriteLiteral(@"grid_process thead"").insertBefore(""#datagrid_process tbody"").addClass(""thead-light"");
            $(""#datagrid,#datagrid_process"").removeAttr(""style rules cellspacing border"");              
            $(""#datagrid_process tbody"").addClass(""process_body"");
            $(""#content"").css({ ""position"": ""static"", ""margin"": ""0 auto"" });
            //表頭標籤替換
            $('.thead-light td').replaceWith(function () {
                return $('<th/>', {
                    html: this.innerHTML                    
                })
            })            
            //簡易資料搜尋
            $(""#Information_Input"").on(""keyup"", function () { //Table Filter
                var value = $(this).val().toLowerCase();
                $(""#datagrid tbody tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });

            //$(""#datagrid"").on(""click"", ""td"", function () {
            //    $("".process_body"").html("""");
");
                WriteLiteral(@"                
            //    $("".process_body"").append("""");
            //    $.ajax(
            //    {
            //        type: ""GET"",
            //            url: ""Get_Process_Data.aspx?id=""+$(this).text()+""&status=Load"",
            //        success: function (data) {
            //            $("".process_body"").html(data);                        
            //        },error: function (d) {
                    /*console.log(""error"");*/
                            //alert(""404. Please wait until the File is Loaded."");
                        //}
            //    });
            //});      

        });
    </script>
");
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
            BeginContext(5964, 11, true);
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
