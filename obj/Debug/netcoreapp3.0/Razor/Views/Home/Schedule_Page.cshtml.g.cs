#pragma checksum "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94e60e8971c87f998c8083bcd21fc7c4ba9ffd0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Schedule_Page), @"mvc.1.0.view", @"/Views/Home/Schedule_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Schedule_Page.cshtml", typeof(AspNetCore.Views_Home_Schedule_Page))]
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
#line 1 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\_ViewImports.cshtml"
using MES_MVC;

#line default
#line hidden
#line 2 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\_ViewImports.cshtml"
using MES_MVC.Models;

#line default
#line hidden
#line 3 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e60e8971c87f998c8083bcd21fc7c4ba9ffd0a", @"/Views/Home/Schedule_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Schedule_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
  
    ViewData["Title"]="工令總進度"; 
    

#line default
#line hidden
#line 3 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                           
    DataTable[] dt  = (DataTable[])ViewData["Table"];
    string judge = "";
    int cou = 1;
    int parent_cou = 1;

#line default
#line hidden
            BeginContext(191, 217, true);
            WriteLiteral("   <script>\r\n       //var a = self.setInterval(\'Get_Information_Data();\', 2000);\r\n       function Get_Information_Data()\r\n       {\r\n           $.ajax(\r\n                          {\r\n                              url: \"");
            EndContext();
            BeginContext(409, 41, false);
#line 15 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                               Write(Url.Action("Get_Information_Data","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(450, 4495, true);
            WriteLiteral(@""",
                             method: ""post"",
                             contentType: 'application/json',                                                           
                              data:
                              {                                  
                                  
                              },
                              //dataType: ""text"",
                              success: function (data) {
                                  var result = JSON.parse(data);
                                   $.each(result, function (i, item) {
                                       //測試用
                                        var val = Math.floor(Math.random()*15);
                                        var wid = $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"");
                                        wid = wid.substr(0,wid.indexOf(""p""));
                                        console.log(val);
                                  ");
            WriteLiteral(@"      var num =  new Number(wid*0.007);           
                                        console.log(num+'a');                              
                                        var num =Math.floor((num .toFixed(2)*100))+val;
                                        console.log(num);                      
                                        if(wid>=110){
                                                $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",""0%"");
                                                $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(""0%"");    
                                        }                                            
                                        else{
                                                if(num>100){
                                                    $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",""100%"");
                                             ");
            WriteLiteral(@"       $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(""100%"");  
                                                }
                                                else{
                                                    $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",num+""%"");
                                                    $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(num+""%"");  
                                                }                                                
                                        }
                                        //$(""#Schedule_Table 6tbody tr:eq(""+i+"")"").find(""td"").eq(8).css(""width"",""20%"");
                                        //$("".progress .progress-bar"").css(""width"",""60%"");
                                        //$("".progress .progress-bar span"").html(""60%"");
                                        //$(""#Schedule_Table tbody tr:eq(""+i+"") td .progress ");
            WriteLiteral(@".progress-bar"").css(""width"",val+""%"");
                                        //$(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(val+""%"");
                                    }); 
                              }, error: function (d) {
                                  /*console.log(""error"");*/
                                  $.alert({
                                    icon:""fas fa-exclamation-triangle"",
                                    title: ""錯誤"",
                                    content: ""404. Please wait until the File is Loaded."",
                                });
                                  //alert(""404. Please wait until the File is Loaded."");
                              }
                          });
       }
    </script>
    <!-- <h1 style=""text-align:center"">工令總進度</h1><br> -->
    <input class=""form-control"" id=""Schedule_Input"" type=""text"" placeholder=""請輸入工令編號...""><br>
    <table id=""Schedule_Table"" class=""table table-hover tablesorte");
            WriteLiteral(@"r"">
        <thead class=""thead-light"">
            <tr>
                <th>工令編號</th>
                <th>產品代號</th>
                <th>產品名稱</th>
                <th>總數量</th>
                <th>預計使用時數</th>
                <th>實際使用時數</th>
                <th>預計結束日期</th>
                <th>工令建立日期</th>
                <th>完成度</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 84 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
             for (int i = 0; i < dt[0].Rows.Count; i++)
            {
                var temp = cou;

#line default
#line hidden
            BeginContext(5050, 41, true);
            WriteLiteral("                <tr data-node=\"treetable-");
            EndContext();
            BeginContext(5092, 3, false);
#line 87 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                    Write(cou);

#line default
#line hidden
            EndContext();
            BeginContext(5095, 42, true);
            WriteLiteral("\">\r\n                    <td id=\"order-id\">");
            EndContext();
            BeginContext(5138, 16, false);
#line 88 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                 Write(dt[0].Rows[i][0]);

#line default
#line hidden
            EndContext();
            BeginContext(5154, 47, true);
            WriteLiteral("</td>\r\n                    <td id=\"product-id\">");
            EndContext();
            BeginContext(5202, 16, false);
#line 89 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                   Write(dt[0].Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(5218, 44, true);
            WriteLiteral("</td>\r\n                    <td id=\"product\">");
            EndContext();
            BeginContext(5263, 16, false);
#line 90 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                Write(dt[0].Rows[i][2]);

#line default
#line hidden
            EndContext();
            BeginContext(5279, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5311, 16, false);
#line 91 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][3]);

#line default
#line hidden
            EndContext();
            BeginContext(5327, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5359, 16, false);
#line 92 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][4]);

#line default
#line hidden
            EndContext();
            BeginContext(5375, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5407, 16, false);
#line 93 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][4]);

#line default
#line hidden
            EndContext();
            BeginContext(5423, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5455, 16, false);
#line 94 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][5]);

#line default
#line hidden
            EndContext();
            BeginContext(5471, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5503, 16, false);
#line 95 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][6]);

#line default
#line hidden
            EndContext();
            BeginContext(5519, 244, true);
            WriteLiteral("</td>\r\n                    <td><div class=progress><div style=\"width:0%;background-color:red\" aria-valuemax=100 aria-valuemin=0 aria-valuenow=60 role=progressbar class=\"red progress-bar\"><span>0%</span></div></div></td>\r\n                </tr>\r\n");
            EndContext();
#line 98 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"

                cou++;
                var query = from row in dt[1].AsEnumerable()
                            where row.Field<string>("orderid") == dt[0].Rows[i][0].ToString()
                            select row;
                var list = query.ToList();
                

#line default
#line hidden
#line 104 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                 if (list.Count != 0)
                {                    

#line default
#line hidden
            BeginContext(6109, 59, true);
            WriteLiteral("                    <tr class=\"_true\" data-node=\"treetable-");
            EndContext();
            BeginContext(6169, 3, false);
#line 106 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                                      Write(cou);

#line default
#line hidden
            EndContext();
            BeginContext(6172, 31, true);
            WriteLiteral("\" data-pnode=\"treetable-parent-");
            EndContext();
            BeginContext(6204, 4, false);
#line 106 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                                                                         Write(temp);

#line default
#line hidden
            EndContext();
            BeginContext(6208, 878, true);
            WriteLiteral(@""">
                        <td colspan=""9"">
                            <table id=""Process_Table"" class=""table table-borderless"" style=""background-color:#fafafa;"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th>產品名稱</th>
                                        <th>道次編號</th>
                                        <th>道次名稱</th>
                                        <th>目前完成數量</th>
                                        <th>目前使用時數</th>
                                        <th>開始作業時間</th>
                                        <th>結束作業時間</th>
                                        <th>完成度</th>
                                    </tr>                                    
                                </thead>
                                <tbody>
");
            EndContext();
#line 122 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                     for (int j = 0; j < list.Count; j++)
                                    {

#line default
#line hidden
            BeginContext(7200, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(7295, 10, false);
#line 125 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][2]);

#line default
#line hidden
            EndContext();
            BeginContext(7305, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7361, 10, false);
#line 126 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][3]);

#line default
#line hidden
            EndContext();
            BeginContext(7371, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7427, 10, false);
#line 127 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][4]);

#line default
#line hidden
            EndContext();
            BeginContext(7437, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7493, 10, false);
#line 128 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][5]);

#line default
#line hidden
            EndContext();
            BeginContext(7503, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7559, 10, false);
#line 129 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][6]);

#line default
#line hidden
            EndContext();
            BeginContext(7569, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7625, 10, false);
#line 130 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][7]);

#line default
#line hidden
            EndContext();
            BeginContext(7635, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7691, 10, false);
#line 131 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][8]);

#line default
#line hidden
            EndContext();
            BeginContext(7701, 292, true);
            WriteLiteral(@"</td>
                                            <td><div class=progress><div style=""width:0%;background-color:red"" aria-valuemax=100 aria-valuemin=0 aria-valuenow=60 role=progressbar class=""red progress-bar""><span>0%</span></div></div></td>
                                        </tr>
");
            EndContext();
#line 134 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                    }

#line default
#line hidden
            BeginContext(8032, 190, true);
            WriteLiteral("                                </tbody>\r\n                            </table>                            \r\n                        </td>\r\n                    </tr>                        \r\n");
            EndContext();
#line 139 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                    cou++;                    
                }

#line default
#line hidden
#line 140 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(8306, 66, true);
            WriteLiteral("        </tbody>\r\n    </table>    \r\n    <div class=\"line\"></div>\r\n");
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
