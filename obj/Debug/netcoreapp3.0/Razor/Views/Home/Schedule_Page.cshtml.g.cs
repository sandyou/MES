#pragma checksum "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dedbbb8f795a2ed8990c55a28755c502d0a1c37"
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
#line 1 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\_ViewImports.cshtml"
using MES_MVC;

#line default
#line hidden
#line 2 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\_ViewImports.cshtml"
using MES_MVC.Models;

#line default
#line hidden
#line 3 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dedbbb8f795a2ed8990c55a28755c502d0a1c37", @"/Views/Home/Schedule_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Schedule_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
  
    ViewData["Title"]="工令總進度"; 
    

#line default
#line hidden
#line 3 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                           
    DataTable[] dt  = (DataTable[])ViewData["Table"];
    string judge = "";
    int cou = 1;
    int parent_cou = 1;

#line default
#line hidden
            BeginContext(191, 205, true);
            WriteLiteral("   <script>\r\n       //var a = self.setInterval(\'Get_Information_Data();\', 2000);\r\n       function Get_Information_Data()\r\n       {\r\n           $.ajax(\r\n                    {\r\n                        url: \"");
            EndContext();
            BeginContext(397, 41, false);
#line 15 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                         Write(Url.Action("Get_Information_Data","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(438, 4358, true);
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
                                var num =  new Number(wid*0.007);           
                                console.log(num+");
            WriteLiteral(@"'a');                              
                                var num =Math.floor((num .toFixed(2)*100))+val;
                                console.log(num);                      
                                if(wid>=110){
                                        $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",""0%"");
                                        $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(""0%"");    
                                }                                            
                                else{
                                        if(num>100){
                                            $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",""100%"");
                                            $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(""100%"");  
                                        }
                                        else{
  ");
            WriteLiteral(@"                                          $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",num+""%"");
                                            $(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(num+""%"");  
                                        }                                                
                                }
                                //$(""#Schedule_Table 6tbody tr:eq(""+i+"")"").find(""td"").eq(8).css(""width"",""20%"");
                                //$("".progress .progress-bar"").css(""width"",""60%"");
                                //$("".progress .progress-bar span"").html(""60%"");
                                //$(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar"").css(""width"",val+""%"");
                                //$(""#Schedule_Table tbody tr:eq(""+i+"") td .progress .progress-bar span"").html(val+""%"");
                            }); 
                        }, error: function (d) {
                       ");
            WriteLiteral(@"     /*console.log(""error"");*/
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
    <table id=""Schedule_Table"" class=""table table-hover tablesorter"">
        <thead class=""thead-light"">
            <tr>                
                <th>工令編號</th>
                <th>產品代號</th>
                <th>產品名稱</th>
                <th>預計生產總數量</th>
                <th>實際生產總數量</th>
                <th>預計使用時數</th>
                <th>實際使用時數</th>
                <th>預計開始日期</th>
                ");
            WriteLiteral(@"<th>預計結束日期</th>
                <th>實際開始日期</th>
                <th>實際結束日期</th>
                <th>工令建立日期</th>
                <th>受令單位</th>
                <th>目前狀態</th>
                <th>完成度</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 90 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
             for (int i = 0; i < dt[0].Rows.Count; i++)
            {
                var temp = cou;

#line default
#line hidden
            BeginContext(4901, 41, true);
            WriteLiteral("                <tr data-node=\"treetable-");
            EndContext();
            BeginContext(4943, 3, false);
#line 93 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                    Write(cou);

#line default
#line hidden
            EndContext();
            BeginContext(4946, 42, true);
            WriteLiteral("\">\r\n                    <td id=\"order-id\">");
            EndContext();
            BeginContext(4989, 16, false);
#line 94 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                 Write(dt[0].Rows[i][0]);

#line default
#line hidden
            EndContext();
            BeginContext(5005, 47, true);
            WriteLiteral("</td>\r\n                    <td id=\"product-id\">");
            EndContext();
            BeginContext(5053, 16, false);
#line 95 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                   Write(dt[0].Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(5069, 44, true);
            WriteLiteral("</td>\r\n                    <td id=\"product\">");
            EndContext();
            BeginContext(5114, 16, false);
#line 96 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                Write(dt[0].Rows[i][2]);

#line default
#line hidden
            EndContext();
            BeginContext(5130, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5162, 16, false);
#line 97 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][3]);

#line default
#line hidden
            EndContext();
            BeginContext(5178, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5210, 16, false);
#line 98 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][4]);

#line default
#line hidden
            EndContext();
            BeginContext(5226, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5258, 16, false);
#line 99 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][5]);

#line default
#line hidden
            EndContext();
            BeginContext(5274, 63, true);
            WriteLiteral("</td>\r\n                    <td>0</td>\r\n                    <td>");
            EndContext();
            BeginContext(5338, 16, false);
#line 101 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][7]);

#line default
#line hidden
            EndContext();
            BeginContext(5354, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5386, 16, false);
#line 102 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][6]);

#line default
#line hidden
            EndContext();
            BeginContext(5402, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5434, 16, false);
#line 103 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][7]);

#line default
#line hidden
            EndContext();
            BeginContext(5450, 62, true);
            WriteLiteral("</td>\r\n                    <td></td>\r\n                    <td>");
            EndContext();
            BeginContext(5513, 16, false);
#line 105 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][7]);

#line default
#line hidden
            EndContext();
            BeginContext(5529, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(5561, 16, false);
#line 106 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                   Write(dt[0].Rows[i][8]);

#line default
#line hidden
            EndContext();
            BeginContext(5577, 277, true);
            WriteLiteral(@"</td>
                    <td>下所</td>
                    <td><div class=progress><div style=""width:0%;background-color:red"" aria-valuemax=100 aria-valuemin=0 aria-valuenow=60 role=progressbar class=""red progress-bar""><span>0%</span></div></div></td>
                </tr>
");
            EndContext();
#line 110 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"

                cou++;
                var query = from row in dt[1].AsEnumerable()
                            where row.Field<string>("orderid") == dt[0].Rows[i][0].ToString()
                            select row;
                var list = query.ToList();
                

#line default
#line hidden
#line 116 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                 if (list.Count != 0)
                {                    

#line default
#line hidden
            BeginContext(6200, 59, true);
            WriteLiteral("                    <tr class=\"_true\" data-node=\"treetable-");
            EndContext();
            BeginContext(6260, 3, false);
#line 118 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                                      Write(cou);

#line default
#line hidden
            EndContext();
            BeginContext(6263, 31, true);
            WriteLiteral("\" data-pnode=\"treetable-parent-");
            EndContext();
            BeginContext(6295, 4, false);
#line 118 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                                                                         Write(temp);

#line default
#line hidden
            EndContext();
            BeginContext(6299, 606, true);
            WriteLiteral(@""">
                        <td colspan=""15"">
                            <table id=""Process_Table"" class=""table table-borderless"" style=""background-color:#fafafa;"">
                                <thead class=""thead-dark"">
                                    <tr>
                                        <th>產品名稱</th>
                                        <th>道次編號</th>
                                        <th>道次名稱</th>
                                        <th>目前完成數量</th>
                                        <th>目前使用時數</th>
                                        <th>開始作業時間</th>
");
            EndContext();
            BeginContext(6966, 216, true);
            WriteLiteral("                                        <th>完成度</th>\r\n                                    </tr>                                    \r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 134 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                     for (int j = 0; j < list.Count; j++)
                                    {

#line default
#line hidden
            BeginContext(7296, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(7391, 10, false);
#line 137 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][2]);

#line default
#line hidden
            EndContext();
            BeginContext(7401, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7457, 10, false);
#line 138 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][3]);

#line default
#line hidden
            EndContext();
            BeginContext(7467, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7523, 10, false);
#line 139 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][4]);

#line default
#line hidden
            EndContext();
            BeginContext(7533, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7589, 10, false);
#line 140 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][5]);

#line default
#line hidden
            EndContext();
            BeginContext(7599, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7655, 10, false);
#line 141 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][6]);

#line default
#line hidden
            EndContext();
            BeginContext(7665, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7721, 10, false);
#line 142 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                           Write(list[j][7]);

#line default
#line hidden
            EndContext();
            BeginContext(7731, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(7797, 285, true);
            WriteLiteral(@"                                            <td><div class=progress><div style=""width:0%;background-color:red"" aria-valuemax=100 aria-valuemin=0 aria-valuenow=60 role=progressbar class=""red progress-bar""><span>0%</span></div></div></td>
                                        </tr>
");
            EndContext();
#line 146 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                    }

#line default
#line hidden
            BeginContext(8121, 190, true);
            WriteLiteral("                                </tbody>\r\n                            </table>                            \r\n                        </td>\r\n                    </tr>                        \r\n");
            EndContext();
#line 151 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                    cou++;                    
                }

#line default
#line hidden
#line 152 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(8395, 66, true);
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
