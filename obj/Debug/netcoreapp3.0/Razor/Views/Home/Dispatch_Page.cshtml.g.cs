#pragma checksum "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cdaecbe750df9bad032f8dffd0a06ff857f0d92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dispatch_Page), @"mvc.1.0.view", @"/Views/Home/Dispatch_Page.cshtml")]
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
#line 1 "/home/q11/桌面/MES/MES_MVC/Views/_ViewImports.cshtml"
using MES_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/q11/桌面/MES/MES_MVC/Views/_ViewImports.cshtml"
using MES_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdaecbe750df9bad032f8dffd0a06ff857f0d92", @"/Views/Home/Dispatch_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dispatch_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
  
    ViewData["Title"]="派工";    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
                       
    DataTable Order_dt = (DataTable)ViewData["Order_Table"];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n    <label >工令編號</label>&nbsp;<span id=\"order-span\" style=\"color:red;display:none\">*工令編號必須選擇</span>\n    <select class=\"custom-select\" id=\"order\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cdaecbe750df9bad032f8dffd0a06ff857f0d923680", async() => {
                WriteLiteral("請選擇工令編號");
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
            WriteLiteral("          \n");
#nullable restore
#line 10 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
         for(int i=0;i<Order_dt.Rows.Count;i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cdaecbe750df9bad032f8dffd0a06ff857f0d925173", async() => {
#nullable restore
#line 12 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
                                          Write(Order_dt.Rows[i][0]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
              WriteLiteral(Order_dt.Rows[i][0]);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 13 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
    </div>
    <table id=""Dispatch_Table"" class=""table table-hover tablesorter"">
        <thead class=""thead-light"">
            <tr>
            <th>道次流程</th>
            <th>道次名稱</th>
            <th>產品代號</th>
            <th>產品名稱</th>
            <th>作業人員</th>
            <th>作業時間</th>
            </tr>
        </thead>
        <tbody>                          
              
        </tbody>
    </table>
    <div class=""line""></div>
    <script>
        $(""#order"").change(function(){
                var order = document.getElementById(""order"").value;
                judge(""order-span"",order);
                if(order!='請選擇工令編號'){
                    $.ajax(
                        {
                            url: """);
#nullable restore
#line 39 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
                             Write(Url.Action("Get_Dispatch_Data","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                            method: ""get"",
                            contentType: 'application/json',                                                                                 
                            data:
                            {                          
                                order:order
                            },  
                            success:function(data){
                                $(""tbody"").html("""");
                                var result = JSON.parse(data);
                                var str = '';
                                $.each(result,function(i,item){
                                    console.log(i+""\t""+item.Process+""\t""+item.ProcessName+""\t""+item.productid+""\t""+item.product+""\t""+item.StaffName);
                                    var cou = $(""tbody tr"").length;
                                    //$(""tbody"").append(""<tr>"");                                    
                                    /*
                                 ");
            WriteLiteral(@"   $(""tbody"").append(""<td>""+item.Process+""</td>"");
                                    $(""tbody"").append(""<td>""+item.ProcessName+""</td>"");
                                    $(""tbody"").append(""<td>""+item.productid+""</td>"");
                                    $(""tbody"").append(""<td>""+item.product+""</td>"");
                                    $(""tbody"").append(""<td><select class=\""custom-select\"" id=\""staff\""><option selected>請選擇作業</option></td>"");
                                    $(""tbody"").append(""<td>""+item.StaffName+""</td>"");
                                    */                                    
                                    if(i!=0){
                                        if(item.Process.toString().indexOf(str)==-1){
                                            $(""tbody"").append(function(){
                                            return ""<tr>""+
                                                        ""<td>""+item.Process+""</td>""+
                                                        ""<td");
            WriteLiteral(@">""+item.ProcessName+""</td>""+
                                                        ""<td>""+item.productid+""</td>""+
                                                        ""<td>""+item.product+""</td>""+
                                                        ""<td><select class=\""custom-select\"" id=\""staff\""><option selected>請選擇作業</option></td>""+
                                                        ""<td>""+item.StaffName+""</td>""+
                                                        ""</tr>"";
                                        });
                                            if(item.StaffName!=''){
                                                $(""tbody tr:eq(""+(cou)+"") td select"").append(""<option selected>""+item.StaffName+""</option>"");    
                                            }
                                        }
                                        else{
                                            $(""tbody tr:eq(""+(cou-1)+"") td select"").append(""<option selected>""+item.StaffName+""</optio");
            WriteLiteral(@"n>"");
                                        }                                        
                                    } 
                                    else{             
                                        $(""tbody"").append(function(){
                                            return ""<tr>""+
                                                        ""<td>""+item.Process+""</td>""+
                                                        ""<td>""+item.ProcessName+""</td>""+
                                                        ""<td>""+item.productid+""</td>""+
                                                        ""<td>""+item.product+""</td>""+
                                                        ""<td><select class=\""custom-select\"" id=\""staff\""><option selected>請選擇作業</option></td>""+
                                                        ""<td>""+item.StaffName+""</td>""+
                                                        ""</tr>"";
                                        });                           ");
            WriteLiteral(@"             
                                        if(item.StaffName!=''){
                                            $(""#staff"").append(""<option selected>""+item.StaffName+""</option>"");    
                                        }
                                    }                                                            
                                    str = item.Process;
                                });
                            },
                            error:function(d){
                                alert(""404. Please wait until the File is Loaded."");
                                $(""tbody"").html("""");
                            }
                        });
                }
                else{
                    $(""tbody"").html("""");
                }
        });

        function judge(id,val) {
              if (val == '' || val == '請選擇工令編號' ) {                  
                  $(""span[id="" + id + ""]"").show();
              } else {
                  $(""span[id="" + id");
            WriteLiteral(" + \"]\").hide();\n              }\n          }\n    </script>");
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
