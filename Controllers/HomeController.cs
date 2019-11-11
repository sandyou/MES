using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MES_MVC.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.IO;
using System.Net;
using MES_MVC.Data;
//using MES_MVC.Models;
using Newtonsoft.Json;


namespace MES_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        SQL conn;
        
        public HomeController(ILogger<HomeController> logger,IConfiguration config)
        {
            _logger = logger;            
            this.configuration = config;
        }
        
        public IActionResult Schedule_Page()
        {
            string connectionstring =  configuration.GetConnectionString("DefaultConnectionStrings");
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            // SqlCommand cmd =new SqlCommand(@"select a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity,round(b.ProductTime*a.RequestQuantity ,2) as Time
            //                                                                                     ,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'
            //                                                                                     ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'
            //                                                                                     ,b.Process,60 as 'id' from [MES-Table].[dbo].[order] a
            //                                                                                     left join 
            //                                                                                     [MES-Table].[dbo].[product_Inf] b
            //                                                                                     on a.[product-id] = b.[product-id] order by a.[order-id] desc",con);        
            SqlCommand cmd = new SqlCommand(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity
                                                                                                ,SUM(b.ProductTime) as 'Time'
                                                                                                ,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'
                                                                                                ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'                                                                                                
                                                                                                 from [MES-Table].[dbo].[order] a
                                                                                                left join 
                                                                                                [MES-Table].[dbo].[product_Inf] b
                                                                                                on a.[product-id] = b.[product-id] 
                                                                                                GROUP BY a.[order-id],a.[product-id],b.product,a.RequestQuantity,CONVERT(varchar(20),a.ST_Date,23)
                                                                                                ,CONVERT(varchar(20),a.End_Date,23)
                                                                                                order by a.[order-id] desc", con);
            SqlDataAdapter ada =new SqlDataAdapter();
            System.Data.DataTable dt =new System.Data.DataTable();    
            ada.SelectCommand = cmd;
            ada.Fill(dt);                        
            con.Close();
            ViewData["Table"]=dt;

            return View();
        }

        public IActionResult Information_Page(string  id,string status)
        {        
             conn = new SQL(this.configuration);                        
            ViewData["Table"] =conn.Get_Information_Data(string.Format(
            @"select
            distinct
            a.[Process] as '道次編號',
            b.[Process-Name] as '道次名稱',
            c.[Machine-Num] as '機台編號',
            c.[Machine-Name] as '機台名稱'
            from dbo.product_Inf a
            left join 
            dbo.Process_Inf b
            on a.Process = b.Process
            left join 
            dbo.Machine_Inf c
            on b.[Machine-Num] = c.[Machine-Num]
            where a.[product-id]='{0}'
            order by a.Process",id));            
            ViewData["ProductId"] = id;
            ViewData["ProductName"]=conn.Get_ProductName(id);
            return View();
        }

        public IActionResult OrderInsert_Page()
        {
            conn = new SQL(this.configuration);            
            DateTime time = DateTime.Now;
            string order  = time.ToString("yyyy-MM-dd HH:mm:ss").Replace("-","").Replace(":","").Replace(" ","");
            order = order.Substring(2,order.Length-2);
            string judge = conn.Order_Repeat(order);            
            while(judge!="Success"){
                order  = time.ToString("yyyy-MM-dd HH:mm:ss").Replace("-","").Replace(":","").Replace(" ","");
                judge = conn.Order_Repeat(order);            
            }                          
            ViewData["OrderID"] = order;  
            ViewData["Product_Table"] = conn.Get_Information_Data(@"SELECT distinct [product-id]
                                                         FROM[MES-Table].[dbo].[product_Inf] order by [product-id]");
            ViewData["Process_Table"]=conn.Get_Information_Data(@"SELECT distinct [Process]
                                                         FROM[MES-Table].[dbo].[Process_Inf] order by [Process]");
            return View();
        }

        public IActionResult Dispatch_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Order_Table"] = conn.Get_Information_Data(@"SELECT distinct [order-id] FROM [MES-Table ].[dbo].[order] order by [order-id]");                                                                                                                                                
            
            return View();
        }

        public IActionResult WorkStatus_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["WorkStatus_Table"] = conn.Get_Information_Data(@"select a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product
                                                                    ,c.[Machine-Num] as 'MachineNum'
                                                                    ,c.[Machine-Name] as 'MachineName'
                                                                    ,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'        
                                                                    ,a.RequestQuantity                                                                                         
                                                                    from [MES-Table].[dbo].[order] a
                                                                    left join 
                                                                    [MES-Table].[dbo].[product_Inf] b on a.[product-id] = b.[product-id] 
                                                                    left join 
                                                                    [MES-Table].[dbo].[Machine_Inf] c on b.Process = c.[Local-Process]
                                                                    order by a.[order-id] desc");
            return View();
        }

        public IActionResult Work_Page()
        {
            return View();
        }

        public IActionResult Machine_Inf_Page()
        {
            conn = new SQL(this.configuration);            
            ViewData["Table"] = conn.Get_Information_Data(@"  SELECT * FROM [MES-Table ].[dbo].[Machine_Inf] ");                                                                                                                            
            return View();
        }

        public IActionResult Staff_Inf_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Table"]=conn.Get_Information_Data(@"SELECT [Staff-Num]
                                                                                                                ,[Staff-Name]
                                                                                                                ,[Process]
                                                                                                                ,[Status]
                                                                                                            FROM [MES-Table ].[dbo].[Staff-Inf]");
            return View();
        }

        [HttpPost]
        public IActionResult Get_Information_Data()
        {
            conn = new SQL(this.configuration);      
            DataTable dt = conn.Get_Information_Data(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity
                                                                                                ,SUM(b.ProductTime) as 'Time'
                                                                                                ,CONVERT(varchar(20),a.ST_Date,120) as 'ST_Date'
                                                                                                ,CONVERT(varchar(20),a.End_Date,120) as 'End_Date'                                                                                                
                                                                                                 from [MES-Table].[dbo].[order] a
                                                                                                left join 
                                                                                                [MES-Table].[dbo].[product_Inf] b
                                                                                                on a.[product-id] = b.[product-id] 
                                                                                                GROUP BY a.[order-id],a.[product-id],b.product,a.RequestQuantity,CONVERT(varchar(20),a.ST_Date,120)
                                                                                                ,CONVERT(varchar(20),a.End_Date,120)
                                                                                                order by a.[order-id] desc");      
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            //string json = JsonConvert.SerializeObject(_item);
            return  Json(json);
        }

        public  IActionResult Get_ProductName(string productid)
        {
            conn = new SQL(this.configuration);
            string  id = conn.Get_ProductName(productid);
            string time = conn.Get_ProductTime(productid);            
            item _item = new item()
            {
                productname=id,
                producttime = time
            };            
            string json = JsonConvert.SerializeObject(_item);
            return  Json(json);
        }       

        public IActionResult Insert_Order_Data(string order,string productid,string productname,string quantity,string time ,string st_date,string end_date)
        {            
            conn = new SQL(this.configuration);  
            string response = conn.Insert(order, productid, productname, quantity, time, st_date, end_date);
            DateTime timeid = DateTime.Now;
            string orderid  = timeid.ToString("yyyy-MM-dd HH:mm:ss").Replace("-","").Replace(":","").Replace(" ","");               
            if(response=="工令新增成功"){
                orderid = orderid.Substring(2,orderid.Length-2);
                string judge = conn.Order_Repeat(orderid);            
                while(judge!="Success"){
                    orderid  = timeid.ToString("yyyy-MM-dd HH:mm:ss").Replace("-","").Replace(":","").Replace(" ","");
                    judge = conn.Order_Repeat(orderid);            
                }      
            }            
            return Content(response+","+orderid);
        }

        public IActionResult Get_Dispatch_Data(string order)
        {
            conn = new SQL(this.configuration);
            DataTable dt =conn.Get_Information_Data(string.Format(@"select b.Process,d.[Process-Name] as 'ProcessName',a.[product-id] as 'productid',b.product,c.[Staff-Name]  as 'StaffName'
                                                        from [MES-Table].[dbo].[order] a
                                                        left join 
                                                        [MES-Table].[dbo].[product_Inf] b
                                                        on a.[product-id] = b.[product-id] 
                                                        left join 
                                                        [MES-Table ].dbo.[Staff-Inf] c
                                                        on b.[Process] = c.[Process]
                                                        left join 
                                                        [MES-Table ].[dbo].[Process_Inf] d
                                                        on b.[Process] = d.[Process]
                                                        where a.[order-id] = '{0}'
                                                        order by a.[order-id] desc",order));
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Json(json);
        }

        public  IActionResult Dispatch_Data(string data)
        {                       
             //json = JsonConvert.SerializeObject(data);
            List<Dispatch_Item> item = JsonConvert.DeserializeObject<List<Dispatch_Item>>(data);
             return Content(data);
        }

        public IActionResult Uptate_Machine_Inf(string machine_num,string machine_name,string process,string status)
        {
            conn = new SQL(this.configuration);
            conn.Insert_Machine_Inf(machine_num, machine_name, process, status);
            return Content("新增成功");
        }

        public IActionResult Uptate_Staff_Inf(string staff_num, string staff_name, string process, string status)
        {
            conn = new SQL(this.configuration);
            conn.Insert_Staff_Inf(staff_num, staff_name, process, status);
            return Content("新增成功");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
