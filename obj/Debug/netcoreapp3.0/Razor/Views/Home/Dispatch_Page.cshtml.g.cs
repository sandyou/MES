#pragma checksum "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237f013aa8c3341437f7f42a5044e395cdd3a1cf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237f013aa8c3341437f7f42a5044e395cdd3a1cf", @"/Views/Home/Dispatch_Page.cshtml")]
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
  
    ViewData["Title"]="每日派工";    
    

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237f013aa8c3341437f7f42a5044e395cdd3a1cf3682", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "237f013aa8c3341437f7f42a5044e395cdd3a1cf5175", async() => {
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
            <!-- <th></th> -->
            <th>道次流程</th>
            <th>道次名稱</th>
            <th>產品代號</th>
            <th>產品名稱</th>
            <th>作業人員</th>
            <th>作業時間(小時)</th>
            </tr>
        </thead>
        <tbody id=""Dispatch_Tbody"">                          
              
        </tbody>
    </table>
     <div style=""text-align:center"">
          <button type=""button"" id=""Data_Dispatch_btn"" class=""btn btn-secondary btn-lg"" style=""width:150px"">派工</button>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <button type=""button"" id=""Data_Clear_btn"" class=""btn btn-secondary btn-lg"" style=""width:150px"">清除</button>
      </div>   
    <div class=""line""></div>
    <h1>已派工資訊</h1>
    <table id=""Dispatch_Y_Table"" class=""table table-hover tablesorter"">
        <thead class=""thead-light"">
  ");
            WriteLiteral(@"          <tr>
            <th>工令編號</th>
            <th>道次流程</th>
            <th>道次名稱</th>
            <th>產品代號</th>
            <th>產品名稱</th>
            <th>作業人員</th>
            <th>作業時間(小時)</th>
            </tr>
        </thead>
        <tbody id=""Dispatch_Y_Tbody"">                          

        </tbody>
    </table>
    <div class=""line""></div>
    <script>
        $(""#order"").change(function(){
                var order = document.getElementById(""order"").value;
                var dispatch_table = $(""#Dispatch_Table"").tablesorter({sortList: [[0,0],[1,0]]})                
                judge(""order-span"",order);
                if(order!='請選擇工令編號'){
                    $.ajax(
                        {
                            url: """);
#nullable restore
#line 64 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
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
                                $(""#Dispatch_Tbody"").html("""");
                                var result = JSON.parse(data);
                                var str = '';
                                $.each(result,function(i,item){
                                    console.log(i+""\t""+item.Process+""\t""+item.ProcessName+""\t""+item.productid+""\t""+item.product+""\t""+item.StaffName);
                                    var cou = $(""#Dispatch_Tbody tr"").length;                             
                                    if(i!=0){
                                        if(item.Process.toString().indexOf(str");
            WriteLiteral(@")==-1){
                                            $(""#Dispatch_Tbody"").append(function(){
                                            return ""<tr role=\""row\"">""+
                                                        //""<td><input type=\""checkbox\""  class=\""form-check-input\"" id=\""time\""  /></td>""+
                                                        ""<td>""+item.Process+""</td>""+
                                                        ""<td>""+item.ProcessName+""</td>""+
                                                        ""<td>""+item.productid+""</td>""+
                                                        ""<td>""+item.product+""</td>""+
                                                        ""<td style=\""width:350px\""><select class=\""custom-select\"" id=\""staff\"" selected=\""selected\""><option selected>請選擇作業人員</option></td>""+
                                                        ""<td style=\""width:200px\""><input  type=\""number\"" class=\""form-control\"" id=\""time\""  step=\""0.5\"" disabled=\""true\"" placeholde");
            WriteLiteral(@"r=\""請輸入作業時數...\"" /></td>""+
                                                        ""</tr>"";
                                        });
                                            if(item.StaffName!=''){
                                                $(""#Dispatch_Tbody tr:eq(""+(cou)+"") td select"").append(""<option>""+item.StaffName+""</option>"");        
                                                //$(""tbody tr:eq(""+(cou)+"") td select"").val(""請選擇作業人員"");                                                                                            
                                            }
                                        }
                                        else{
                                            $(""#Dispatch_Tbody tr:eq(""+(cou-1)+"") td select"").append(""<option>""+item.StaffName+""</option>"");                                            
                                        }                                        
                                    } 
                                 ");
            WriteLiteral(@"   else{             
                                        $(""#Dispatch_Tbody"").append(function(){
                                            return ""<tr role=\""row\"">""+
                                                        //""<td><input type=\""checkbox\""  class=\""form-check-input\"" id=\""time\""  /></td>""+
                                                        ""<td>""+item.Process+""</td>""+
                                                        ""<td>""+item.ProcessName+""</td>""+
                                                        ""<td>""+item.productid+""</td>""+
                                                        ""<td>""+item.product+""</td>""+
                                                        ""<td style=\""width:350px\""><select class=\""custom-select\"" id=\""staff\"" selected=\""selected\""><option selected>請選擇作業人員</option></td>""+
                                                        ""<td style=\""width:200px\""><input type=\""number\""  class=\""form-control\"" id=\""time\""  step=\""0.5\"" disabled=\""true\"" ");
            WriteLiteral(@"placeholder=\""請輸入作業時數...\"" /></td>""+
                                                        ""</tr>"";
                                        });                                        
                                        if(item.StaffName!=''){
                                            $(""#staff"").append(""<option>""+item.StaffName+""</option>"");                                                
                                        }
                                    }                                                            
                                    str = item.Process;                                    
                                });    
                                var resort = true,
                                callback = function(){ console.log('table updated'); };
                                dispatch_table.trigger(""update"", [ resort, callback ]);                                                            
                            },
                            error");
            WriteLiteral(@":function(d){
                                $.alert({
                                    icon:""fas fa-exclamation-triangle"",
                                    title: ""錯誤"",
                                    content: ""404. Please wait until the File is Loaded."",
                                });
                                //alert(""404. Please wait until the File is Loaded."");
                                $(""#Dispatch_Tbody"").html("""");
                            }
                        });                        
                }
                else{
                    $(""#Dispatch_Tbody"").html("""");
                }
        });

        $(""#Dispatch_Table"").on(""input"", ""td"", function () {                    
                    var value = $(this).find(""select"").val();         
                    var ind = $(this).parent(""tr"").index();                                                                                                                    
                    $(this).find(""inpu");
            WriteLiteral(@"t"").val(function(n,c){ 
                        //c=c.replace(/[^\d]/g, '').replace(/^0{1,}/g, '');
                        c=c.replace(/[^\d{1,}\.\d{1,}|\d{1,}]/g, '');
                        if(c!='' && c<=12){
                           return c; 
                        }           
                        else  if(c>12){
                            $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""錯誤"",
                                content: ""作業時數不可超過12小時"",
                            });
                            //alert('作業時數不可超過12小時');
                            return '';
                        }
                        else{
                            return '';
                        }        
                        //return c.replace(/[^\d]/g, '').replace(/^0{1,}/g, '');
                    });                    
                    if(value == '請選擇作業人員'){
                        $(""tbody tr:eq(""+ind+"") td:eq(5) input"").");
            WriteLiteral(@"attr('disabled','true');
                        $(""tbody tr:eq(""+ind+"") td:eq(5) input"").val('');
                    }
                    else{
                        $(""tbody tr:eq(""+ind+"") td:eq(5) input"").removeAttr('disabled');
                    }
                    //this.value = this.value.replace(/[^\d]/g, '').replace(/^0{1,}/g, '');
                });
        $(""#Data_Clear_btn"").click(function(){
            document.getElementById(""order"").value = '請選擇工令編號';
            $(""#order"").trigger(""change"");
        });

        $(""#Data_Dispatch_btn"").on('click',function(){            
            //var val = document.getElementsByTagName(""tr""); $(""#Dispatch_Tbody"")[0].children[0].children[4].children[0].value
            var val = $(""#Dispatch_Tbody"");
            var order = document.getElementById(""order"").value;                    
            var dispatch_y_table = $(""#Dispatch_Y_Table"").tablesorter({sortList: [[0,0],[1,0]]})    
            if(order != '請選擇工令編號'){
                var arr = ne");
            WriteLiteral(@"w Array();
                $.each(val,function(i,item){                              
                    for(j=0;j<item.childElementCount;j++)
                    {
                        var process = item.children[j].children[0].innerText;
                        var processname = item.children[j].children[1].innerText;
                        var productid = item.children[j].children[2].innerText;
                        var product = item.children[j].children[3].innerText;
                        var staff = item.children[j].children[4].children[0].value;
                        var time = item.children[j].children[5].children[0].value;
                        /*
                        var process = item.children[0].innerText;
                        var processname = item.children[1].innerText;
                        var productid = item.children[2].innerText;
                        var product = item.children[3].innerText;
                        var staff = item.children[4].children[0].value;
    ");
            WriteLiteral(@"                    var time = item.children[5].children[0].value;
                        */
                        if(staff != '請選擇作業人員' && time !=''){
                            var obj = new Object();
                            obj.order = order;
                            obj.process = process;
                            obj.processname = processname;
                            obj.productid = productid;
                            obj.product = product;
                            obj.staff = staff;
                            obj.time = time;
                            arr = arr.concat(obj);
                        }
                        else{
                            $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""錯誤"",
                                content: ""有資料尚未輸入完成,請確認"",
                            });
                            //alert('有資料尚未輸入完成,請確認');
                            exit;
                        } ");
            WriteLiteral(@"                   
                        console.log(order+'\t'+process+'\t'+processname+'\t'+productid+'\t'+product+'\t'+staff+'\t'+time);
                    }                                                               
                });  
                if(arr.length==0){
                    $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""錯誤"",
                                content: ""請選擇欲派工之道次人員資料"",
                            });
                    //alert('請選擇欲派工之道次人員資料');
                }   
                else{
                    $.ajax(
                    {
                        url: """);
#nullable restore
#line 233 "/home/q11/桌面/MES/MES_MVC/Views/Home/Dispatch_Page.cshtml"
                         Write(Url.Action("Dispatch_Data","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        method: ""get"",
                        contentType: 'application/json',      
                        data:
                        {
                            data:JSON.stringify(arr)
                        },
                        success:function(data){
                            var result = JSON.parse(data);
                            $.each(result,function(i,item){                                
                                $(""#Dispatch_Y_Tbody"").append(function(){
                                    return ""<tr role=\""row\"">""+                                                
                                                ""<td>""+item.order+""</td>""+
                                                ""<td>""+item.process+""</td>""+
                                                ""<td>""+item.processname+""</td>""+
                                                ""<td>""+item.productid+""</td>""+
                                                ""<td>""+item.product+""</td>""+
         ");
            WriteLiteral(@"                                       ""<td>""+item.staff+""</td>""+
                                                ""<td>""+item.time+""</td>""+
                                                ""</tr>"";
                                });
                            });                                                        
                            //alert(data);
                            var resort = true,
                            callback = function(){ console.log('table updated'); };
                            dispatch_y_table.trigger(""update"", [ resort, callback ]);
                        },
                        error:function(d){
                            alert('error');
                        }
                    });                    
                }                                       
            }
            else{
                $.alert({
                                icon:""fas fa-exclamation-triangle"",
                                title: ""錯誤"",
                               ");
            WriteLiteral(@" content: ""請選擇欲派工之工令編號"",
                            });
                //alert('請選擇欲派工之工令編號');
            }
            
        });

        function judge(id,val) {
              if (val == '' || val == '請選擇工令編號' ) {                  
                  $(""span[id="" + id + ""]"").show();
              } else {
                  $(""span[id="" + id + ""]"").hide();
              }
          }
    </script>");
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
