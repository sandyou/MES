#pragma checksum "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f6023746021a3415a36838245ab82eced0692af"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6023746021a3415a36838245ab82eced0692af", @"/Views/Home/Schedule_Page.cshtml")]
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
                           
    DataTable dt  = (DataTable)ViewData["Table"];   

#line default
#line hidden
            BeginContext(123, 215, true);
            WriteLiteral("   <script>\r\n       var a = self.setInterval(\'Get_Information_Data();\', 2000);\r\n       function Get_Information_Data()\r\n       {\r\n           $.ajax(\r\n                          {\r\n                              url: \"");
            EndContext();
            BeginContext(339, 41, false);
#line 12 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                               Write(Url.Action("Get_Information_Data","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(380, 4519, true);
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
            <th>使用時數</th>
            <th>預計開始日期</th>
            <th>預計結束日期</th>
            <th>工令建立日期</th>
            <!-- <th>道次途層</th> -->
            <th>完成度</th>
            </tr>
        </thead>
        <tbody>                          
");
            EndContext();
#line 82 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                for(int i=0;i<dt.Rows.Count;i++)
               {

#line default
#line hidden
            BeginContext(4967, 66, true);
            WriteLiteral("                   <tr>\r\n                       <td id=\"order-id\">");
            EndContext();
            BeginContext(5034, 13, false);
#line 85 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                    Write(dt.Rows[i][0]);

#line default
#line hidden
            EndContext();
            BeginContext(5047, 50, true);
            WriteLiteral("</td>\r\n                       <td id=\"product-id\">");
            EndContext();
            BeginContext(5098, 13, false);
#line 86 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                      Write(dt.Rows[i][1]);

#line default
#line hidden
            EndContext();
            BeginContext(5111, 47, true);
            WriteLiteral("</td>\r\n                       <td id=\"product\">");
            EndContext();
            BeginContext(5159, 13, false);
#line 87 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                                   Write(dt.Rows[i][2]);

#line default
#line hidden
            EndContext();
            BeginContext(5172, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(5207, 13, false);
#line 88 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                      Write(dt.Rows[i][3]);

#line default
#line hidden
            EndContext();
            BeginContext(5220, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(5255, 13, false);
#line 89 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                      Write(dt.Rows[i][4]);

#line default
#line hidden
            EndContext();
            BeginContext(5268, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(5303, 13, false);
#line 90 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                      Write(dt.Rows[i][5]);

#line default
#line hidden
            EndContext();
            BeginContext(5316, 39, true);
            WriteLiteral("</td>\r\n                       <!-- <td>");
            EndContext();
            BeginContext(5356, 13, false);
#line 91 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                           Write(dt.Rows[i][6]);

#line default
#line hidden
            EndContext();
            BeginContext(5369, 38, true);
            WriteLiteral("</td> -->\r\n                       <td>");
            EndContext();
            BeginContext(5408, 13, false);
#line 92 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                      Write(dt.Rows[i][6]);

#line default
#line hidden
            EndContext();
            BeginContext(5421, 34, true);
            WriteLiteral("</td>\r\n                       <td>");
            EndContext();
            BeginContext(5456, 13, false);
#line 93 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
                      Write(dt.Rows[i][5]);

#line default
#line hidden
            EndContext();
            BeginContext(5469, 259, true);
            WriteLiteral(@"</td>
                       <td><div class=progress><div style =""width:0%;background-color:red"" aria-valuemax = 100 aria-valuemin = 0 aria-valuenow = 60 role = progressbar class=""red progress-bar""><span>0%</span></div></div></td>
                   </tr>
");
            EndContext();
#line 96 "C:\Users\ai-pc11\Desktop\致廷檔案\MES\Views\Home\Schedule_Page.cshtml"
               }

#line default
#line hidden
            BeginContext(5746, 60, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"line\"></div>");
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
