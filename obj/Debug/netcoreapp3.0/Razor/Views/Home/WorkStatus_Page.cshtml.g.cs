#pragma checksum "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58895a05a4b0ac7d6156bb366dc1a120498c82bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WorkStatus_Page), @"mvc.1.0.view", @"/Views/Home/WorkStatus_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WorkStatus_Page.cshtml", typeof(AspNetCore.Views_Home_WorkStatus_Page))]
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
#line 3 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58895a05a4b0ac7d6156bb366dc1a120498c82bb", @"/Views/Home/WorkStatus_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WorkStatus_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/CNC.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-holder-rendered", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 180px;width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
  
    ViewData["Title"] = "當日產線即時情況";
    

#line default
#line hidden
#line 3 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                       
    DataTable dt = (DataTable)ViewData["WorkStatus_Table"];
    DataTable Machine_dt = (DataTable)ViewData["Machine_Status_Table"];

#line default
#line hidden
            BeginContext(1423, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1804, 1325, true);
            WriteLiteral(@"    <div class=""row"" style=""margin: 0 auto;width: 42%;"">
        <div class=""col green"" id=""col"">
            <i class=""fas fa-play"" style=""font-size: 2.5rem;color: white;""></i>
            <div style=""width: 100%;text-align: center;"">
                運轉中
            </div>
        </div>
        <div class=""col orange"" id=""col"">
            <i class=""fas fa-pause"" style=""font-size: 2.5rem;color: white;""></i>
            <div style=""width: 100%;text-align: center;"">
                待機中
            </div>
        </div>
        <div class=""col gray"" id=""col"">
            <i class=""fas fa-power-off"" style=""font-size: 2.5rem;color: white;""></i>
            <div style=""width: 100%;text-align: center;"">
                停機中
            </div>
        </div>
    </div>
    <br>               

    <div class=""accordion"" id=""accordionExample"">
        <div class=""card"">
            <div class=""card-header"" id=""headingOne"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" a");
            WriteLiteral(@"ria-controls=""collapseOne"" style=""font-size: 1.5rem;font-weight: bold;cursor:pointer"">
                A線機台生產狀態
            </div>
            <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"">
                <table class=""table table-borderless"">
                    <tbody>
");
            EndContext();
#line 133 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                           int cou = 0;int loop=0 ; bool flag = false; bool fla = false;bool wrap = false;

#line default
#line hidden
            BeginContext(7515, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 134 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                         while(flag==false)
                        {

#line default
#line hidden
            BeginContext(7587, 34, true);
            WriteLiteral("                            <tr>\r\n");
            EndContext();
#line 137 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                 while(fla == false)
                                {
                                    

#line default
#line hidden
#line 139 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                     for (int i = loop; i < Machine_dt.Rows.Count; i++)
                                    {                                        
                                        if(Machine_dt.Rows[i][0].ToString()=="A")
                                        {
                                            if(cou%6==0 && cou!=0 && wrap==true)
                                            {
                                                fla = true;
                                                wrap = false;
                                                break;
                                            }
                                            else
                                            {
                                                wrap = true;

#line default
#line hidden
            BeginContext(8519, 247, true);
            WriteLiteral("                                                <td>\r\n                                                <div class=\"card click\" style=\"width: 18rem;margin: 0 auto;border:0.5px solid #fafafa\">\r\n                                                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 8766, "\"", 8817, 2);
            WriteAttributeValue("", 8774, "card-body", 8774, 9, true);
#line 154 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 8783, Machine_dt.Rows[i][2].ToString(), 8784, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8818, 61, true);
            WriteLiteral(">\r\n                                                        <p");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 8879, "\"", 8930, 2);
            WriteAttributeValue("", 8887, "card-text", 8887, 9, true);
#line 155 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 8896, Machine_dt.Rows[i][2].ToString(), 8897, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8931, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(8933, 21, false);
#line 155 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                                                                                          Write(Machine_dt.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(8954, 62, true);
            WriteLiteral("</p>\r\n                                                        ");
            EndContext();
            BeginContext(9016, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58895a05a4b0ac7d6156bb366dc1a120498c82bb10403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9125, 246, true);
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                                </td>                                                                         \r\n");
            EndContext();
#line 160 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                            }                                            
                                            cou++;
                                        }
                                        if(i==Machine_dt.Rows.Count-1)
                                        {
                                            flag = true;
                                            fla = true;
                                            break;
                                        }
                                        loop++;
                                    }

#line default
#line hidden
#line 170 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(10005, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 173 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                            fla = false;
                        }                        

#line default
#line hidden
            BeginContext(10133, 577, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingTwo"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"" style=""font-size: 1.5rem;font-weight: bold;cursor:pointer"">
                B線機台生產狀態
            </div>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"">
                <table class=""table table-borderless"">
                    <tbody>
                        <tr>
");
            EndContext();
#line 187 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                               cou = 0; loop = 0;  flag = false;  fla = false;  wrap = false;

#line default
#line hidden
            BeginContext(10806, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 188 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                             while (flag == false)
                            {

#line default
#line hidden
            BeginContext(10889, 38, true);
            WriteLiteral("                                <tr>\r\n");
            EndContext();
#line 191 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                     while (fla == false)
                                    {
                                        

#line default
#line hidden
#line 193 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                         for (int i = loop; i < Machine_dt.Rows.Count; i++)
                                        {
                                            if (Machine_dt.Rows[i][0].ToString() == "B")
                                            {
                                                if (cou % 6 == 0 && cou != 0 && wrap == true)
                                                {
                                                    fla = true;
                                                    wrap = false;
                                                    break;
                                                }
                                                else
                                                {
                                                    wrap = true;

#line default
#line hidden
            BeginContext(11858, 267, true);
            WriteLiteral(@"                                                    <td>
                                                        <div class=""card click"" style=""width: 18rem;margin: 0 auto;border:0.5px solid #fafafa"">
                                                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 12125, "\"", 12176, 2);
            WriteAttributeValue("", 12133, "card-body", 12133, 9, true);
#line 208 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 12142, Machine_dt.Rows[i][2].ToString(), 12143, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12177, 69, true);
            WriteLiteral(">\r\n                                                                <p");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 12246, "\"", 12297, 2);
            WriteAttributeValue("", 12254, "card-text", 12254, 9, true);
#line 209 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 12263, Machine_dt.Rows[i][2].ToString(), 12264, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12298, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(12300, 21, false);
#line 209 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                                                                                                  Write(Machine_dt.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(12321, 70, true);
            WriteLiteral("</p>\r\n                                                                ");
            EndContext();
            BeginContext(12391, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58895a05a4b0ac7d6156bb366dc1a120498c82bb17818", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12500, 193, true);
            WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n                                                    </td>\r\n");
            EndContext();
#line 214 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"

                                                }
                                                cou++;
                                            }
                                            if (i == Machine_dt.Rows.Count - 1)
                                            {
                                                flag = true;
                                                fla = true;
                                                break;
                                            }
                                            loop++;
                                        }

#line default
#line hidden
#line 225 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(13338, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 228 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                fla = false;
                            }

#line default
#line hidden
            BeginContext(13454, 626, true);
            WriteLiteral(@"                            </tr>
                        </tbody>
                </table>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingThree"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"" style=""font-size: 1.5rem;font-weight: bold;cursor:pointer"">
                C線機台生產狀態
            </div>
            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"">
                <table class=""table table-borderless"">
                    <tbody>
                        <tr>
");
            EndContext();
#line 243 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                               cou = 0; loop = 0; flag = false; fla = false; wrap = false;

#line default
#line hidden
            BeginContext(14173, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 244 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                             while (flag == false)
                            {

#line default
#line hidden
            BeginContext(14256, 38, true);
            WriteLiteral("                                <tr>\r\n");
            EndContext();
#line 247 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                     while (fla == false)
                                    {
                                        

#line default
#line hidden
#line 249 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                         for (int i = loop; i < Machine_dt.Rows.Count; i++)
                                        {
                                            if (Machine_dt.Rows[i][0].ToString() == "C")
                                            {
                                                if (cou % 6 == 0 && cou != 0 && wrap == true)
                                                {
                                                    fla = true;
                                                    wrap = false;
                                                    break;
                                                }
                                                else
                                                {
                                                    wrap = true;

#line default
#line hidden
            BeginContext(15225, 267, true);
            WriteLiteral(@"                                                    <td>
                                                        <div class=""card click"" style=""width: 18rem;margin: 0 auto;border:0.5px solid #fafafa"">
                                                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 15492, "\"", 15543, 2);
            WriteAttributeValue("", 15500, "card-body", 15500, 9, true);
#line 264 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 15509, Machine_dt.Rows[i][2].ToString(), 15510, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15544, 69, true);
            WriteLiteral(">\r\n                                                                <p");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 15613, "\"", 15664, 2);
            WriteAttributeValue("", 15621, "card-text", 15621, 9, true);
#line 265 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 15630, Machine_dt.Rows[i][2].ToString(), 15631, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(15665, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(15667, 21, false);
#line 265 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                                                                                                  Write(Machine_dt.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(15688, 70, true);
            WriteLiteral("</p>\r\n                                                                ");
            EndContext();
            BeginContext(15758, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58895a05a4b0ac7d6156bb366dc1a120498c82bb25230", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(15867, 193, true);
            WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n                                                    </td>\r\n");
            EndContext();
#line 270 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"

                                                }
                                                cou++;
                                            }
                                            if (i == Machine_dt.Rows.Count - 1)
                                            {
                                                flag = true;
                                                fla = true;
                                                break;
                                            }
                                            loop++;
                                        }

#line default
#line hidden
#line 281 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(16705, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 284 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                fla = false;
                            }

#line default
#line hidden
            BeginContext(16821, 613, true);
            WriteLiteral(@"                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingFour"" data-toggle=""collapse"" data-target=""#collapseFour"" aria-expanded=""false"" aria-controls=""collapseFour"" style=""font-size: 1.5rem;font-weight: bold;cursor:pointer"">
                D線機台生產狀態
            </div>
            <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour"">
                <table class=""table table-borderless"">
                    <tbody>
                        <tr>
");
            EndContext();
#line 299 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                               cou = 0; loop = 0; flag = false; fla = false; wrap = false;

#line default
#line hidden
            BeginContext(17527, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 300 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                             while (flag == false)
                            {

#line default
#line hidden
            BeginContext(17610, 38, true);
            WriteLiteral("                                <tr>\r\n");
            EndContext();
#line 303 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                     while (fla == false)
                                    {
                                        

#line default
#line hidden
#line 305 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                         for (int i = loop; i < Machine_dt.Rows.Count; i++)
                                        {
                                            if (Machine_dt.Rows[i][0].ToString() == "D")
                                            {
                                                if (cou % 6 == 0 && cou != 0 && wrap == true)
                                                {
                                                    fla = true;
                                                    wrap = false;
                                                    break;
                                                }
                                                else
                                                {
                                                    wrap = true;

#line default
#line hidden
            BeginContext(18579, 267, true);
            WriteLiteral(@"                                                    <td>
                                                        <div class=""card click"" style=""width: 18rem;margin: 0 auto;border:0.5px solid #fafafa"">
                                                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 18846, "\"", 18897, 2);
            WriteAttributeValue("", 18854, "card-body", 18854, 9, true);
#line 320 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 18863, Machine_dt.Rows[i][2].ToString(), 18864, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(18898, 69, true);
            WriteLiteral(">\r\n                                                                <p");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 18967, "\"", 19018, 2);
            WriteAttributeValue("", 18975, "card-text", 18975, 9, true);
#line 321 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
WriteAttributeValue(" ", 18984, Machine_dt.Rows[i][2].ToString(), 18985, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(19019, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(19021, 21, false);
#line 321 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                                                                                                  Write(Machine_dt.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(19042, 70, true);
            WriteLiteral("</p>\r\n                                                                ");
            EndContext();
            BeginContext(19112, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "58895a05a4b0ac7d6156bb366dc1a120498c82bb32629", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(19221, 193, true);
            WriteLiteral("\r\n                                                            </div>\r\n                                                        </div>\r\n                                                    </td>\r\n");
            EndContext();
#line 326 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"

                                                }
                                                cou++;
                                            }
                                            if (i == Machine_dt.Rows.Count - 1)
                                            {
                                                flag = true;
                                                fla = true;
                                                break;
                                            }
                                            loop++;
                                        }

#line default
#line hidden
#line 337 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(20059, 39, true);
            WriteLiteral("                                </tr>\r\n");
            EndContext();
#line 340 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\WorkStatus_Page.cshtml"
                                fla = false;
                            }

#line default
#line hidden
            BeginContext(20175, 169, true);
            WriteLiteral("                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    \r\n<div class=\"line\"></div>\r\n");
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
