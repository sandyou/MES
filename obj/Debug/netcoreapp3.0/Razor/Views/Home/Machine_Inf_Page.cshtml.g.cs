#pragma checksum "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d9e603c20f18de6b148eb115b1333eba7af02dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Machine_Inf_Page), @"mvc.1.0.view", @"/Views/Home/Machine_Inf_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Machine_Inf_Page.cshtml", typeof(AspNetCore.Views_Home_Machine_Inf_Page))]
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
#line 1 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\_ViewImports.cshtml"
using MES_MVC;

#line default
#line hidden
#line 2 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\_ViewImports.cshtml"
using MES_MVC.Models;

#line default
#line hidden
#line 3 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d9e603c20f18de6b148eb115b1333eba7af02dc", @"/Views/Home/Machine_Inf_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Machine_Inf_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
  
    ViewData["Title"] = "機台資訊";
    

#line default
#line hidden
#line 3 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
                       
    DataTable dt = (DataTable)ViewData["Table"];
    DataTable Machine_Table = (DataTable)ViewData["Machine_Table"];

#line default
#line hidden
            BeginContext(184, 316, true);
            WriteLiteral(@"    <table class=""table"">
        <tbody>
            <tr>
                <div class=""form-group"">
                    <label>機台代號</label>&nbsp;<span id=""product-id-span"" style=""color:red;display:none"">機台代號必須選擇</span>
                    <select class=""custom-select"" id=""product-id"">
                        ");
            EndContext();
            BeginContext(500, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d9e603c20f18de6b148eb115b1333eba7af02dc4076", async() => {
                BeginContext(517, 7, true);
                WriteLiteral("請選擇產品代號");
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
            BeginContext(533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
                         for (int i = 0; i < dt.Rows.Count; i++)
                        {

#line default
#line hidden
            BeginContext(628, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(656, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d9e603c20f18de6b148eb115b1333eba7af02dc5898", async() => {
                BeginContext(686, 13, false);
#line 16 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
                                                    Write(dt.Rows[i][0]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
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
            BeginContext(708, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
                        }

#line default
#line hidden
            BeginContext(737, 1001, true);
            WriteLiteral(@"                    </select>
                </div>
                <td>機台編號:<input type=""text"" /></td>
                <td>機台名稱:<input type=""text"" /></td>
                <td>目前道次:<input type=""text"" /></td>

            </tr>            
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
                <th>機台編號</th>
                <th>機台名稱</th>
                <th>目前道次</th>
                <th>目前狀態</th>
            </tr>
        </thead>
        <tbody id=""machine_body"">
");
            EndContext();
            BeginContext(2051, 249, true);
            WriteLiteral("        </tbody>        \r\n    </table>\r\n<div class=\"line\"></div>\r\n<script>\r\n    $(\"#product-id\").change(function () {\r\n        var machine = document.getElementById(\"product-id\").value;        \r\n        $.ajax(\r\n            {\r\n                url: \"");
            EndContext();
            BeginContext(2301, 37, false);
#line 61 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
                 Write(Url.Action("Get_Machine_Data","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 1807, true);
            WriteLiteral(@""",
                method: ""get"",
                contenType: 'application/json',
                data:
                {
                    machine:machine
                },
                success: function (data) {
                    $(""#machine_body"").html("""");
                    var result = JSON.parse(data);
                    $.each(result, function (i, item) {
                        $(""#machine_body"").append(function () {
                            return ""<tr>"" +
                                ""<td>"" + item.machinenum + ""</td>"" +
                                ""<td>"" + item.machinename + ""</td>"" +
                                ""<td>"" + item.localprocess + ""</td>"" +
                                ""<td>"" + item.Status + ""</td>"" +
                                ""</tr>"";
                        });
                    });
                },
                error: function (e) {
                    $.alert({
                        icon:""fas fa-exclamation-triangle"",
 ");
            WriteLiteral(@"                       title: ""錯誤"",
                        content: ""404. Please wait until the File is Loaded."",
                    });
                    $(""#machine_body"").html("""");
                }

            });
    });
    $(""#Data_Insert_btn"").on('click', function () {
        var num = $(""input"").eq(0).val();
        var name = $(""input"").eq(1).val();
        var process = $(""input"").eq(2).val();
        var status = $(""input"").eq(3).val();
        $.confirm(
        {
            title: ""資料確認"",
            content: ""請確認資料是否正確<br>機台編號:"" + num + ""<br>機台名稱:"" + name + ""<br>目前道次:"" + process ,
            buttons:
            {
                ""新增"": function () {
                    $.ajax(
                    {
                        url: """);
            EndContext();
            BeginContext(4146, 39, false);
#line 107 "C:\Users\ai-pc11\Desktop\致廷檔案\MES - 複製\Views\Home\Machine_Inf_Page.cshtml"
                         Write(Url.Action("Uptate_Machine_Inf","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(4185, 1350, true);
            WriteLiteral(@""",
                        method: ""get"",
                        contenType: 'application/json',
                        data:
                        {
                            machine_num: num,
                            machine_name: name,
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
                                content: ""404. Please wait until the File is Load");
            WriteLiteral(@"ed."",
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
    
</script>

");
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
