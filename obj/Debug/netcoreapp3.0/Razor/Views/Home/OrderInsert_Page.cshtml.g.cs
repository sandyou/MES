#pragma checksum "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e895003fc5357c75649bd0bbcdb05d13907a7c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderInsert_Page), @"mvc.1.0.view", @"/Views/Home/OrderInsert_Page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OrderInsert_Page.cshtml", typeof(AspNetCore.Views_Home_OrderInsert_Page))]
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
#line 3 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e895003fc5357c75649bd0bbcdb05d13907a7c45", @"/Views/Home/OrderInsert_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderInsert_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
  
         ViewData["Title"]="新增工令";
        

#line default
#line hidden
#line 3 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                           
        DataTable Product_dt = (DataTable)ViewData["Product_Table"];
        DataTable Process_Table = (DataTable)ViewData["Process_Table"];
    

#line default
#line hidden
            BeginContext(225, 178, true);
            WriteLiteral("<div class=\"form-group\">\r\n        <label >工令編號</label>&nbsp;<span id=\"order-span\" style=\"color:red;display:none\">*工令編號不可為空</span>\r\n        <input  class=\"form-control\" id=\"order\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 403, "", 430, 1);
#line 9 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
WriteAttributeValue("", 410, ViewData["OrderID"], 410, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(430, 245, true);
            WriteLiteral(" disabled=\"disabled\">\r\n      </div>\r\n      <div class=\"form-group\">\r\n        <label >產品代號</label>&nbsp;<span id=\"product-id-span\" style=\"color:red;display:none\">*產品代號必須選擇</span>\r\n        <select class=\"custom-select\" id=\"product-id\">\r\n          ");
            EndContext();
            BeginContext(675, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e895003fc5357c75649bd0bbcdb05d13907a7c454602", async() => {
                BeginContext(692, 7, true);
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
            BeginContext(708, 12, true);
            WriteLiteral("          \r\n");
            EndContext();
#line 15 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
           for(int i=0;i<Product_dt.Rows.Count;i++)
          {

#line default
#line hidden
            BeginContext(786, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(800, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e895003fc5357c75649bd0bbcdb05d13907a7c456389", async() => {
                BeginContext(838, 21, false);
#line 17 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                                              Write(Product_dt.Rows[i][0]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                WriteLiteral(Product_dt.Rows[i][0]);

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
            BeginContext(868, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
          }

#line default
#line hidden
            BeginContext(883, 1059, true);
            WriteLiteral(@"        </select>
      </div>
      <div class=""form-group"">
        <label >產品名稱</label>
        <input  class=""form-control"" id=""productname"" disabled=""disabled"" />
      </div>
      <div class=""form-group form_img"" style=""text-align:center ;display:none"">
          <img src="""" class=""img-rounded"" alt=""Cinque Terre"" width=""560"" height=""300"">
      </div>
        <div class=""form-group"">
        <label >總數量</label>&nbsp;<span id=""quantity-span"" style=""color:red;display:none"">*總數量不可為空</span>
        <input  class=""form-control"" id=""quantity""/>
      </div>
        <div class=""form-group"">
        <label >使用時數(小時)</label>
        <span id=""CT"" style=""display:none""></span>
        <input  class=""form-control"" id=""time"" value=""0"" disabled=""disabled"" />
      </div>      
      <!-- <div class=""form-group"">
        <label >道次流程</label>&nbsp;<span id=""process-id-span"" style=""color:red;display:none"">*道次流程必須選擇</span>
        <select class=""custom-select"" id=""process-id"">
            <option se");
            WriteLiteral("lected>請選擇道次流程</option>          \r\n");
            EndContext();
#line 41 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
             for(int i=0;i<Process_Table.Rows.Count;i++)
            {

#line default
#line hidden
            BeginContext(2015, 14, true);
            WriteLiteral("              ");
            EndContext();
            BeginContext(2029, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e895003fc5357c75649bd0bbcdb05d13907a7c459996", async() => {
                BeginContext(2070, 24, false);
#line 43 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                                                 Write(Process_Table.Rows[i][0]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                WriteLiteral(Process_Table.Rows[i][0]);

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
            BeginContext(2103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
            }

#line default
#line hidden
            BeginContext(2120, 1750, true);
            WriteLiteral(@"          </select>
        </div>   -->
        <div class=""form-group"">
            <label >開始日期</label>&nbsp;<span id=""st-date-span"" style=""color:red;display:none"">*開始日期不可為空</span>
            <input type=""date""  class=""form-control"" id=""st_date"" disabled=""disabled""  style=""width:500px""/>
        </div>
        <div class=""form-group"">
            <label >結束日期</label>&nbsp;<span id=""end-date-span"" style=""color:red;display:none"">*結束日期不可為空</span>
            <input type=""date""  class=""form-control"" id=""end_date"" style=""width:500px""/>
      </div>  
      <div style=""text-align:center"">
          <button type=""button"" id=""Data_Insert_btn"" class=""btn btn-secondary btn-lg"" style=""width:150px"">送出</button>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <button type=""button"" id=""Data_Clear_btn"" class=""btn btn-secondary btn-lg"" style=""width:150px"">清除</button>
      </div>     
      
      <script>      
          var date = new  Date();
  ");
            WriteLiteral(@"        var today_date = date.getFullYear() + '-' + (date.getMonth() + 1) + '-' + date.getDate();          
          var yyyy = date.toLocaleDateString().slice(0, 4);
          var MM = (date.getMonth()+1<10 ? '0' : '')+(date.getMonth()+1);
          var dd = (date.getDate()<10 ? '0' : '')+date.getDate();
          document.getElementById(""st_date"").value = yyyy+'-'+MM+'-'+dd;
          $(""#product-id"").change(function () {
              var checkText = $(""#product-id"").find(""option:selected"").text();
              judge(""product-id-span"",checkText,""*產品代號必須選擇"");
              var productid = document.getElementById(""product-id"").value;
              $.ajax(
                  {
                      url: """);
            EndContext();
            BeginContext(3871, 36, false);
#line 74 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                       Write(Url.Action("Get_ProductName","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(3907, 8679, true);
            WriteLiteral(@""",
                      method: ""get"",
                      contentType: 'application/json',                                                                                 
                      data:
                        {                          
                            productid: productid
                        },                      
                      //dataType:""text"",                      
                      success: function (data) {        
                          console.log(data);                                             
                          var result = JSON.parse(data);                                 
                          var quantity = document.getElementById(""quantity"").value;                          
                          /*$.each(result, function (i, item) {
                              //console.log(i+'\t'+item+'\t'+result.productname+'\t'+result.producttime);
                              document.getElementById(""productname"").value =");
            WriteLiteral(@" item.productname;                              
                              document.getElementById(""CT"").innerHTML = item.producttime; 
                          }); */
                          document.getElementById(""productname"").value = result.productname;                              
                          document.getElementById(""CT"").innerHTML = result.producttime; 
                          if (quantity != '0') {
                              document.getElementById(""time"").value = (document.getElementById(""CT"").innerHTML*quantity);
                          } else {
                              document.getElementById(""time"").value = 0;
                          }
                          if(result.productname != ''){
                                if(result.productname=='T91' || result.productname == 'T94'){
                                    $(""img"").attr(""src"",""/product_img/""+result.productname+"".png"");
                                }else{
                             ");
            WriteLiteral(@"       $(""img"").attr(""src"",""/product_img/Other.png"");
                                }
                                $("".form_img"").show();
                          }else{
                                $("".form_img"").hide();
                          }                          
                      }, error: function (d) {
                                  /*console.log(""error"");*/
                                     $.alert({
                                            icon:""fas fa-exclamation-triangle"",
                                            title: ""連線失敗"",
                                            content: ""404. Please wait until the File is Loaded."",
                                        });
                                  //alert(""404. Please wait until the File is Loaded."");
                              }
                  });
          });
        
        $(""#order"").on('input', function () {
              var order = document.getElementById('order').value;
     ");
            WriteLiteral(@"         judge(""order-span"", order,""*工令編號不可為空"");
          });

        $(""#quantity"").on('input', function () {                    
              this.value = this.value.replace(/[^\d]/g, '').replace(/^0{1,}/g, '');
              var productname = document.getElementById(""productname"").value
              var quantity = document.getElementById(""quantity"").value;      
              var time = document.getElementById(""CT"").innerHTML;
              if (productname != '' && quantity != '' && time != '') {
                  document.getElementById(""time"").value = (quantity * time).toFixed(1);
              }
              else {
                  document.getElementById(""time"").value = 0;
              }
              judge(""quantity-span"", quantity,""*總數量不可為空"");
          });
          
        //ubuntu無法使用keyup
        /* 
          $(""#order"").on('keyup', function () {   
              var order = document.getElementById('order').value;
              judge(""order-span"", order);
          ");
            WriteLiteral(@"});

          $(""#quantity"").on('keyup', function () {                    
              this.value = this.value.replace(/[^\d]/g, '').replace(/^0{1,}/g, '');
              var productname = document.getElementById(""productname"").value
              var quantity = document.getElementById(""quantity"").value;      
              var time = document.getElementById(""CT"").innerHTML;
              if (productname != '' && quantity != '' && time != '') {
                  document.getElementById(""time"").value = (quantity * time).toFixed(1);
              }
              else {
                  document.getElementById(""time"").value = 0;
              }
              judge(""quantity-span"", quantity);
          });
        */

          $(""#process-id"").change(function(){
               var checkText = $(""#process-id"").find(""option:selected"").text();
               judge(""process-id-span"",checkText,""*產品道次必須選擇"");
          });

          $(""#st_date"").change(function () {
              var st_dat");
            WriteLiteral(@"e = $(""#st_date"").val();
              var end_date = $(""#end_date"").val();                            
              var today = Date.parse(today_date).valueOf();              
              //if (end_date != '') {
                  var st = Date.parse(st_date).valueOf();
                  var end = Date.parse(end_date).valueOf();
                  if (st > end && end !=0) {
                      //alert('開始日期不可以大於結束日期');
                      judge(""st-date-span"", st_date,""*開始日期不可以大於結束日期"",false);
                      document.getElementById(""st_date"").value = '';
                      //$(""#st_date"").val('');
                  }
                  else if(st<today){
                      //alert('開始日期不可以小於當日時間');
                      judge(""st-date-span"", st_date,""*開始日期不可以小於當日時間"",false);
                      document.getElementById(""st_date"").value = '';
                  }
                  else{
                      judge(""st-date-span"", st_date,""*開始日期不可為空"");
                  }
   ");
            WriteLiteral(@"           //}
              //judge(""st-date-span"", st_date);
          });

          $(""#end_date"").change(function () {
              var st_date = $(""#st_date"").val();
              var end_date = $(""#end_date"").val();
              var today = Date.parse(today_date).valueOf();
              //if (st_date != '') {
                  var st = Date.parse(st_date).valueOf();
                  var end = Date.parse(end_date).valueOf();
                  if (st > end && st!=0) {
                      //alert('開始日期不可以大於結束日期');
                      judge(""end-date-span"", end_date,""*結束日期不可以小於開始日期"",false);
                      document.getElementById(""end_date"").value = '';
                      //$(""#end_date"").val('');
                  }
                  else if(end<today){
                      //alert('結束日期不可以小於當日時間');
                      judge(""end-date-span"", end_date,""*結束日期不可以小於當日時間"",false);
                      document.getElementById(""end_date"").value = '';
                  }
");
            WriteLiteral(@"                  else{
                      judge(""end-date-span"", end_date,""*結束日期不可為空"");
                  }
              //}
              //judge(""end-date-span"", end_date);
          });

          $('#Data_Insert_btn').on('click', function () {
              var order = document.getElementById(""order"").value;
              var productid = document.getElementById(""product-id"").value;
              var productname = document.getElementById(""productname"").value;
              var quantity = document.getElementById(""quantity"").value;
              var time = document.getElementById(""time"").value;
              //var processid = document.getElementById(""process-id"").value;
              var st_date = document.getElementById(""st_date"").value;
              var end_date = document.getElementById(""end_date"").value;    
              if (order != '' && productid != '請選擇產品代號' && productname != '' && quantity != '' && time != '0' && st_date != '' && end_date != '' ) {
                  $.confirm");
            WriteLiteral(@"({
                        title: ""資料確認"",
                        content: ""請確認資料是否正確:<br>"" +
                      ""工令編號:"" + order + ""<br>產品代號:"" + productid + ""<br>產品名稱:"" + productname + ""<br>總數量:"" + quantity + ""<br>使用時數:"" + time +""<br>開始日期:"" + st_date + ""<br>結束日期:"" + end_date,
                        buttons: {
                            ""新增"": function () {
                                $.ajax(
                                {
                                    url: """);
            EndContext();
            BeginContext(12587, 38, false);
#line 234 "C:\Users\ai-pc10\Desktop\致廷檔案\MES\Views\Home\OrderInsert_Page.cshtml"
                                     Write(Url.Action("Insert_Order_Data","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(12625, 4580, true);
            WriteLiteral(@""",
                                    method: ""get"",
                                    contentType: 'application/json',                                                           
                                    data:
                                    {                                  
                                        order: order,
                                        productid: productid,
                                        productname:productname,
                                        quantity: quantity,
                                        time: time,
                                        //processid:processid,
                                        st_date: st_date,
                                        end_date:end_date
                                    },
                                    //dataType: ""text"",
                                    success: function (data) {
                                        $.alert({
                               ");
            WriteLiteral(@"             title: ""新增結果"",
                                            content: data.split("","")[0],
                                        });
                                        //alert(data.split("","")[0]);
                                        document.getElementById(""order"").value = data.split("","")[1];
                                    }, error: function (d) {
                                        /*console.log(""error"");*/
                                        $.alert({
                                            icon:""fas fa-exclamation-triangle"",
                                            title: ""新增失敗"",
                                            content: ""404. Please wait until the File is Loaded."",
                                        });
                                        //alert(""404. Please wait until the File is Loaded."");
                                    }
                                });                      
                                document.get");
            WriteLiteral(@"ElementById(""product-id"").value = '請選擇產品代號';
                                document.getElementById(""productname"").value = '';
                                document.getElementById(""quantity"").value = '';
                                document.getElementById(""time"").value = 0;
                                //document.getElementById(""process-id"").value = '請選擇道次流程';
                                //document.getElementById(""st_date"").value = '';
                                document.getElementById(""end_date"").value = '';
                                $("".form_img"").hide();
                                $(""span[id!='CT']"").hide();
                            },
                            ""取消"": function () {                        
                            }
                        }
                    });                  
              }
              else {
                  $.alert({
                        icon:""fas fa-exclamation-triangle"",
                        title:");
            WriteLiteral(@" ""資料尚未填寫完成"",
                        content: ""有資料尚未填寫完成,請確認."",
                    });
              }

          });

          $(""#Data_Clear_btn"").on('click', function () {                                              
              //document.getElementById(""order"").value = '';
              document.getElementById(""product-id"").value = '請選擇產品代號';
              document.getElementById(""productname"").value = '';
              document.getElementById(""quantity"").value = '';
              document.getElementById(""time"").value = 0;
              //document.getElementById(""process-id"").value = '請選擇道次流程';
              //document.getElementById(""st_date"").value = '';
              document.getElementById(""end_date"").value = '';
              $("".form_img"").hide();
              $(""span[id!='CT']"").hide();
          });          

          function judge(id,val,content,flag=true) {
              if (val == '' || val == '請選擇產品代號'  || val=='請選擇道次流程') {                       
               ");
            WriteLiteral(@"   $(""span[id="" + id + ""]"").text(content);             
                  $(""span[id="" + id + ""]"").show();
              }
              else if(val != '' && flag==false && (id=='st-date-span' || id=='end-date-span')){
                  $(""span[id="" + id + ""]"").text(content);             
                  $(""span[id="" + id + ""]"").show();
              } 
              else {
                  $(""span[id="" + id + ""]"").hide();
              }
          }
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
