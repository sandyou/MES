#pragma checksum "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "391efb0e0835fe19f9209cc5485fcafbc61eaec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Staff_Inf_Page), @"mvc.1.0.view", @"/Views/Home/Staff_Inf_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Staff_Inf_Page.cshtml", typeof(AspNetCore.Views_Home_Staff_Inf_Page))]
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
#line 3 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391efb0e0835fe19f9209cc5485fcafbc61eaec8", @"/Views/Home/Staff_Inf_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Staff_Inf_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
  
    ViewData["Title"]="人員資訊";    
    

#line default
#line hidden
#line 3 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                           
    DataTable dt  = (DataTable)ViewData["Table"];  
    DataTable Stuff_Table = (DataTable)ViewData["Machine_Table"];

#line default
#line hidden
            BeginContext(191, 377, true);
            WriteLiteral(@"   
            <table class=""table"">
                <tbody>
                    <tr>
                        <div class=""form-group"">
                            <label>人員編號</label>&nbsp;<span id=""product-id-span"" style=""color:red;display:none"">人員編號必須選擇</span>
                            <select class=""custom-select"" id=""product-id"">
                                ");
            EndContext();
            BeginContext(568, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391efb0e0835fe19f9209cc5485fcafbc61eaec84094", async() => {
                BeginContext(585, 7, true);
                WriteLiteral("請選擇人員編號");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(601, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(635, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391efb0e0835fe19f9209cc5485fcafbc61eaec85611", async() => {
                BeginContext(643, 3, true);
                WriteLiteral("All");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(655, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                                 for (int i = 0; i < dt.Rows.Count; i++)
                                {

#line default
#line hidden
            BeginContext(766, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(802, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391efb0e0835fe19f9209cc5485fcafbc61eaec87135", async() => {
                BeginContext(832, 13, false);
#line 18 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                                                            Write(dt.Rows[i][0]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                                      WriteLiteral(dt.Rows[i][0]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(854, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                                }

#line default
#line hidden
            BeginContext(891, 252, true);
            WriteLiteral("                            </select>\r\n                        </div>\r\n                        <td>人員編號:<input type=\"text\" /></td>\r\n                        <td>姓名:<input type=\"text\" /></td>\r\n                        <td>執行道次:<input type=\"text\" /></td>\r\n");
            EndContext();
            BeginContext(1206, 1227, true);
            WriteLiteral(@"                    </tr>

                </tbody>
            </table>
            <div style=""text-align:center"">
                <button type=""button"" id=""Data_Insert_btn"" class=""btn btn-secondary btn-lg"" style=""width:150px"">送出</button>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <button type=""button"" id=""Data_Clear_btn"" class=""btn btn-secondary btn-lg"" style=""width:150px"">清除</button>
            </div>
            <br>
            <table id=""Staff_Table"" class=""table table-hover tablesorter"">

                <thead class=""thead-light"">
                    <tr>
                        <th>人員編號</th>
                        <th>姓名</th>
                        <th>執行道次</th>
                        <th>假況</th>
                    </tr>
                </thead>
                <tbody id=""staff_body"">

                </tbody>
            </table>
            <div class=""line""></div>
            <script>
        ");
            WriteLiteral("    $(\"#product-id\").change(function () {\r\n                var staff = document.getElementById(\"product-id\").value;        \r\n                $.ajax(\r\n                    {\r\n                        url: \"");
            EndContext();
            BeginContext(2434, 35, false);
#line 56 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                         Write(Url.Action("Get_Staff_Data","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 2073, true);
            WriteLiteral(@""",
                        method: ""get"",
                        contenType: 'application/json',
                        data:
                        {
                            staff:staff
                        },
                        success: function (data) {
                            $(""#staff_body"").html("""");
                            var result = JSON.parse(data);
                            $.each(result, function (i, item) {
                                $(""#staff_body"").append(function () {
                                    return ""<tr>"" +
                                        ""<td>"" + item.staffnum + ""</td>"" +
                                        ""<td>"" + item.staffname + ""</td>"" +
                                        ""<td>"" + item.process + ""</td>"" +
                                        ""<td>"" + item.Status + ""</td>"" +
                                        ""</tr>"";
                                });
                            });
                 ");
            WriteLiteral(@"       },
                        error: function (e) {
                            $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""錯誤"",
                                content: ""404. Please wait until the File is Loaded."",
                            });
                            $(""#staff_body"").html("""");
                        }

                    });
            });
    $(""#Data_Insert_btn"").on('click', function () {
        var num = $(""input"").eq(0).val();
        var name = $(""input"").eq(1).val();
        var process = $(""input"").eq(2).val();
        //var status = $(""input"").eq(3).val();
        var status = ""閒置中 "";
        $.confirm(
        {
            title: ""資料確認"",
            content: ""請確認資料是否正確<br>人員編號:"" + num + ""<br>姓名:"" + name + ""<br>執行道次:"" + process + ""<br>假況:閒置中"" ,
            buttons:
            {
                ""新增"": function () {
                    $.ajax(
                    {
     ");
            WriteLiteral("                   url: \"");
            EndContext();
            BeginContext(4543, 37, false);
#line 103 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\Staff_Inf_Page.cshtml"
                         Write(Url.Action("Uptate_Staff_Inf","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(4580, 1874, true);
            WriteLiteral(@""",
                        method: ""get"",
                        contenType: 'application/json',
                        data:
                        {
                            staff_num: num,
                            staff_name: name,
                            process: process,
                            status:status
                        },
                        success: function (data) {
                            $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""結果"",
                                content: data,
                            });
                                //location.reload();
                        },
                        error: function (e) {
                            $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""錯誤"",
                                content: ""404. Please wait until the File is Loaded.""");
            WriteLiteral(@",
                            });
                        }
                    });
                },
                ""取消"": function () {

                }
            }
        });
    });

    $(""#Data_Clear_btn"").on('click', function () {
        $(""input"").val('');
    });
     $(""#Staff_Table"").on(""click"", ""td"", function () {
                var x = $(this).attr('id');
                var id = $(this).text();                
                if ($(this).index() == 0) {                                        
                    var staff_num = $(this).parent(""tr"").find(""td"").eq(0).text();
                    var newwin = window.open();   //此行一定要如此書寫,否則失效
                    newwin.location = '/Home/Staff_lnf_Page2?staff_num='+staff_num;
                }
              
            });

            </script>");
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
