#pragma checksum "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e029638c2dc5dfb318d5578c53fc3d20b4dc8e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderInsert_Page), @"mvc.1.0.view", @"/Views/Home/OrderInsert_Page.cshtml")]
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
#line 3 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e029638c2dc5dfb318d5578c53fc3d20b4dc8e0", @"/Views/Home/OrderInsert_Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef355c0d663a763c5faa255c60f0b4785dd434b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderInsert_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
  
         ViewData["Title"]="新增工令";
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                           
        DataTable Product_dt = (DataTable)ViewData["Product_Table"];
        DataTable Process_Table = (DataTable)ViewData["Process_Table"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""form-group"">
        <label >工令編號</label>&nbsp;<span id=""order-span"" style=""color:red;display:none"">*工令編號不可為空</span>
        <input  class=""form-control"" id=""order"">
      </div>
      <div class=""form-group"">
        <label >產品代號</label>&nbsp;<span id=""product-id-span"" style=""color:red;display:none"">*產品代號必須選擇</span>
        <select class=""custom-select"" id=""product-id"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e029638c2dc5dfb318d5578c53fc3d20b4dc8e04021", async() => {
                WriteLiteral("請選擇產品代號");
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
#line 15 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
           for(int i=0;i<Product_dt.Rows.Count;i++)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e029638c2dc5dfb318d5578c53fc3d20b4dc8e05525", async() => {
#nullable restore
#line 17 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                                              Write(Product_dt.Rows[i][0]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                WriteLiteral(Product_dt.Rows[i][0]);

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
#line 18 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
      </div>
      <div class=""form-group"">
        <label >產品名稱</label>
        <input  class=""form-control"" id=""productname"" disabled=""disabled"" />
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
      <div class=""form-group"">
        <label >道次流程</label>&nbsp;<span id=""process-id-span"" style=""color:red;display:none"">*道次流程必須選擇</span>
        <select class=""custom-select"" id=""process-id"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e029638c2dc5dfb318d5578c53fc3d20b4dc8e08292", async() => {
                WriteLiteral("請選擇道次流程");
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
#line 38 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
             for(int i=0;i<Process_Table.Rows.Count;i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e029638c2dc5dfb318d5578c53fc3d20b4dc8e09803", async() => {
#nullable restore
#line 40 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                                                 Write(Process_Table.Rows[i][0]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                WriteLiteral(Process_Table.Rows[i][0]);

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
#line 41 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          </select>
        </div>  
        <div class=""form-group"">
            <label >開始日期</label>&nbsp;<span id=""st-date-span"" style=""color:red;display:none"">*開始日期不可為空</span>
            <input type=""date""  class=""form-control"" id=""st_date""  style=""width:500px""/>
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
          $(""#product-id"").change(function () {
              var checkText = ");
            WriteLiteral("$(\"#product-id\").find(\"option:selected\").text();\n              judge(\"product-id-span\",checkText);\n              var productid = document.getElementById(\"product-id\").value;\n              $.ajax(\n                  {\n                      url: \"");
#nullable restore
#line 65 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                       Write(Url.Action("Get_ProductName","Home"));

#line default
#line hidden
#nullable disable
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
                              document.getElementById(""productname"").value = item.productn");
            WriteLiteral(@"ame;                              
                              document.getElementById(""CT"").innerHTML = item.producttime; 
                          }); */
                          document.getElementById(""productname"").value = result.productname;                              
                          document.getElementById(""CT"").innerHTML = result.producttime; 
                          if (quantity != '0') {
                              document.getElementById(""time"").value = (document.getElementById(""CT"").innerHTML*quantity);
                          } else {
                              document.getElementById(""time"").value = 0;
                          }
                      }, error: function (d) {
                                  /*console.log(""error"");*/
                                  alert(""404. Please wait until the File is Loaded."");
                              }
                  });
          });
        
        $(""#order"").on('input', function () {
              var order = doc");
            WriteLiteral(@"ument.getElementById('order').value;
              judge(""order-span"", order);
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
              judge(""quantity-span"", quantity);
          });
          
        //ubuntu無法使用keyup
        /* 
          $(""#order"").on('keyup', function () {   
              var order = document.getElementById('order').value;
              judge(""order-span"", order);
          });");
            WriteLiteral(@"

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
               judge(""process-id-span"",checkText);
          });

          $(""#st_date"").change(function () {
              var st_date = $(""#st_date"").val();
             ");
            WriteLiteral(@" var end_date = $(""#end_date"").val();
              if (end_date != '') {
                  var st = Date.parse(st_date).valueOf();
                  var end = Date.parse(end_date).valueOf();
                  if (st > end) {
                      alert('開始日期不可以大於結束日期');
                      document.getElementById(""st_date"").value = '';
                      //$(""#st_date"").val('');
                  }
              }
              judge(""st-date-span"", st_date);
          });

          $(""#end_date"").change(function () {
              var st_date = $(""#st_date"").val();
              var end_date = $(""#end_date"").val();
              if (st_date != '') {
                  var st = Date.parse(st_date).valueOf();
                  var end = Date.parse(end_date).valueOf();
                  if (st > end) {
                      alert('開始日期不可以大於結束日期');
                      document.getElementById(""end_date"").value = '';
                      //$(""#end_date"").val('');
                  }
              }
      ");
            WriteLiteral(@"        judge(""end-date-span"", end_date);
          });

          $('#Data_Insert_btn').on('click', function () {
              var order = document.getElementById(""order"").value;
              var productid = document.getElementById(""product-id"").value;
              var productname = document.getElementById(""productname"").value;
              var quantity = document.getElementById(""quantity"").value;
              var time = document.getElementById(""time"").value;
              var processid = document.getElementById(""process-id"").value;
              var st_date = document.getElementById(""st_date"").value;
              var end_date = document.getElementById(""end_date"").value;    
              if (order != '' && productid != '請選擇產品代號' && productname != '' && quantity != '' && time != '0' && st_date != '' && end_date != '' && processid!='請選擇道次流程') {
                  var x = window.confirm(""請確認資料是否正確:\n"" +
                      ""工令編號:"" + order + ""\n產品代號:"" + productid + ""\n產品名稱:"" + productname + ""\n總數量:"" + qu");
            WriteLiteral("antity + \"\\n使用時數:\" + time + \"\\n道次流程\"+processid+\"\\n開始日期:\" + st_date + \"\\n結束日期:\" + end_date);\n                  if (x == true) {\n                      $.ajax(\n                          {\n                              url: \"");
#nullable restore
#line 187 "/home/q11/桌面/MES/MES_MVC/Views/Home/OrderInsert_Page.cshtml"
                               Write(Url.Action("Insert_Order_Data","Home"));

#line default
#line hidden
#nullable disable
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
                                  processid:processid,
                                  st_date: st_date,
                                  end_date:end_date
                              },
                              //dataType: ""text"",
                              success: function (data) {
                                  alert(data);
                              }, error: function (d) {
                                  /*console.log(""error"");*/
                              ");
            WriteLiteral(@"    alert(""404. Please wait until the File is Loaded."");
                              }
                          });
                      document.getElementById(""order"").value = '';
                      document.getElementById(""product-id"").value = '請選擇產品代號';
                      document.getElementById(""productname"").value = '';
                      document.getElementById(""quantity"").value = '';
                      document.getElementById(""time"").value = 0;
                      document.getElementById(""process-id"").value = '請選擇道次流程';
                      document.getElementById(""st_date"").value = '';
                      document.getElementById(""end_date"").value = '';
                      $(""span[id!='CT']"").hide();
                  }
              }
              else {
                  alert('有欄位尚未填寫');
              }

          });

          $(""#Data_Clear_btn"").on('click', function () {
              document.getElementById(""order"").value = '';
              document.getElementById(""pro");
            WriteLiteral(@"duct-id"").value = '請選擇產品代號';
              document.getElementById(""productname"").value = '';
              document.getElementById(""quantity"").value = '';
              document.getElementById(""time"").value = 0;
              document.getElementById(""process-id"").value = '請選擇道次流程';
              document.getElementById(""st_date"").value = '';
              document.getElementById(""end_date"").value = '';
              $(""span[id!='CT']"").hide();
          });          

          function judge(id,val) {
              if (val == '' || val == '請選擇產品代號'  || val=='請選擇道次流程') {                  
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
