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
using MES_MVC.Models;
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
            SqlCommand cmd =new SqlCommand(@"select a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity,round(b.ProductTime*a.RequestQuantity ,2) as Time
                                                                                                ,CONVERT(varchar(20),a.ST_Date,120) as 'ST_Date'
                                                                                                ,CONVERT(varchar(20),a.End_Date,120) as 'End_Date'
                                                                                                ,b.Process,60 as 'id' from [MES-Table].[dbo].[order] a
                                                                                                left join 
                                                                                                [MES-Table].[dbo].[product_Inf] b
                                                                                                on a.[product-id] = b.[product-id] order by a.[order-id] desc",con);        
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
            ViewData["Product_Table"] = conn.Get_Information_Data(@"SELECT distinct [product-id]
                                                         FROM[MES-Table].[dbo].[product_Inf] order by [product-id]");
            ViewData["Process_Table"]=conn.Get_Information_Data(@"SELECT distinct [Process]
                                                         FROM[MES-Table].[dbo].[Process_Inf] order by [Process]");
            return View();
        }

        public IActionResult Dispatch_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Order_Table"] = conn.Get_Information_Data(@"SELECT distinct  [order-id]                                                                                                                                           
                                                                                                                                        FROM [MES-Table ].[dbo].[order] order by [order-id]");                                                                                                                                                
            
            return View();
        }

        public IActionResult WorkStatus_Page()
        {
            return View();
        }

        public IActionResult Work_Page()
        {
            return View();
        }

        public IActionResult Machine_Inf_Page()
        {
            conn = new SQL(this.configuration);            
            ViewData["Table"] = conn.Get_Information_Data(@"  SELECT a.[Machine-Num],a.[Machine-Name],a.[Local-Process],b.[Status-Type]
                                                                                                                FROM [MES-Table ].[dbo].[Machine_Inf] a
                                                                                                                left join
                                                                                                                [MES-Table ].[dbo].[Machine-Status] b
                                                                                                                on a.[Machine-Num] = b.[Machine-Num]");                                                                                                                            
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

        public IActionResult Get_Information_Data()
        {
            conn = new SQL(this.configuration);      
            DataTable dt = conn.Get_Information_Data(@"select a.[order-id] as orderid,a.[product-id] as productid,b.product,a.RequestQuantity,round(b.ProductTime*a.RequestQuantity ,2) as Time
                                                                                                ,CONVERT(varchar(20),a.ST_Date,120) as 'ST_Date'
                                                                                                ,CONVERT(varchar(20),a.End_Date,120) as 'End_Date'
                                                                                                ,b.Process,80 as 'id' from [MES-Table].[dbo].[order] a
                                                                                                left join 
                                                                                                [MES-Table].[dbo].[product_Inf] b
                                                                                                on a.[product-id] = b.[product-id] order by a.[order-id] desc");      
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
            return Content(response);
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
