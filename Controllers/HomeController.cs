﻿using System;
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

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            this.configuration = config;
        }

        public IActionResult Schedule_Page()
        {
            conn = new SQL(this.configuration);
            DataTable[] dt = new DataTable[2];
            dt[0] = conn.Get_Information_Data(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity,a.Act_Quantity
                                                ,SUM(b.ProductTime) as 'Time'                                                
                                                ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'  
                                                ,CONVERT(varchar(20),a.Create_Date,23) as 'Create_Date'
                                                ,CONVERT(varchar(20),a.Act_End_Date,23) as 'Act_End_Date'
                                                ,a.Place
                                                ,CASE WHEN a.Finish = 1
                                                THEN N'完工'
                                                ELSE N'下所'
                                                END 'Status'
                                                ,CONVERT(FLOAT,(a.Act_Quantity/a.RequestQuantity))*100 as 'progress'
	                                                from [MES-Table].[dbo].[order] a
                                                left join 
                                                [MES-Table].[dbo].[product_Inf] b
                                                on a.[product-id] = b.[product-id] 
                                                --where a.Dispatch <> 0 
                                                GROUP BY a.[order-id],a.[product-id],b.product,a.RequestQuantity,a.Act_Quantity,CONVERT(varchar(20),a.ST_Date,23),a.Place
                                                ,CONVERT(varchar(20),a.End_Date,23),CONVERT(varchar(20),a.Create_Date,23),CONVERT(varchar(20),a.Act_End_Date,23) 
                                                ,CASE WHEN a.Finish = 1
                                                THEN N'完工'
                                                ELSE N'下所'
                                                END 
                                                ,CONVERT(FLOAT,(a.Act_Quantity/a.RequestQuantity))*100
                                                order by CONVERT(varchar(20),a.ST_Date,23) desc
                                                ");            
            dt[1] = conn.Get_Information_Data(@"SELECT distinct a.[order-id] as 'orderid',a.[product-id] as 'productid',c.product,d.Process
                                                ,d.[Process-Name],b.Finish_Quantity,'8',convert(nvarchar(20),b.Act_ST_Date,23) as 'Act_ST_Date'
                                                ,CONVERT(FLOAT,(b.Finish_Quantity/a.RequestQuantity))*100 as 'progress' FROM dbo.[order] a
                                                INNER JOIN  
                                                dbo.[Schedule-Inf] b
                                                on a.[order-id] = b.[order-id]
                                                LEFT JOIN 
                                                dbo.product_Inf c
                                                on a.[product-id] = c.[product-id]
                                                LEFT JOIN 
                                                dbo.Process_Inf d
                                                on b.[Process-Num] = d.[Process]
                                                ");            
            ViewData["Table"] = dt;
            return View();
        }

        public IActionResult Information_Page(string order, string productid, string status)
        {
            conn = new SQL(this.configuration);
            ViewData["Table"] = conn.Get_Information_Data(string.Format(
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
                                                                        order by a.Process", productid));
            ViewData["Today_Table"] = conn.Get_Information_Data(string.Format(@"SELECT DISTINCT a.[Schedule-Num],a.[order-id],c.product,f.[Staff-Name],d.[Process-Name],e.[Machine-Name],a.Act_Work_Hour,a.Quantity,a.Finish_Quantity,a.[Process-Num],a.Act_ST_Date,CONVERT(FLOAT,(a.Finish_Quantity/a.Quantity))*100 as 'Progress' FROM [dbo].[Schedule-Inf] a
                                                                        LEFT JOIN 
                                                                        [order] b
                                                                        on a.[order-id] = b.[order-id]
                                                                        LEFT JOIN
                                                                        product_Inf c
                                                                        on b.[product-id] = c.[product-id]
                                                                        LEFT JOIN
                                                                        Process_Inf d
                                                                        on a.[Process-Num] = d.Process
                                                                        LEFT JOIN
                                                                        Machine_Inf e
                                                                        on d.[Machine-Num] = e.[Machine-Num]
                                                                        LEFT JOIN
                                                                        [Staff-Inf] f
                                                                        on a.[Staff-Num] = f.[Staff-Num]
                                                                        where a.[order-id]='{0}' and CONVERT(VARCHAR(20),GETDATE(),23) = a.Act_ST_Date
                                                                        order by a.[Process-Num]", order));
            ViewData["History_Table"] = conn.Get_Information_Data(string.Format(@"SELECT DISTINCT a.[Schedule-Num],a.[order-id],c.product,f.[Staff-Name],d.[Process-Name],e.[Machine-Name],a.Quantity
                                                                                ,CONVERT(nvarchar(20),b.ST_Date,23) as 'ST_Date'
                                                                                ,CONVERT(nvarchar(20),b.End_Date,23) as 'End_Date'
                                                                                ,a.[Process-Num] FROM [dbo].[Schedule-Inf] a
                                                                                LEFT JOIN 
                                                                                [order] b
                                                                                on a.[order-id] = b.[order-id]
                                                                                LEFT JOIN
                                                                                product_Inf c
                                                                                on b.[product-id] = c.[product-id]
                                                                                LEFT JOIN
                                                                                Process_Inf d
                                                                                on a.[Process-Num] = d.Process
                                                                                LEFT JOIN
                                                                                Machine_Inf e
                                                                                on d.[Machine-Num] = e.[Machine-Num]
                                                                                LEFT JOIN
                                                                                [Staff-Inf] f
                                                                                on a.[Staff-Num] = f.[Staff-Num]
                                                                                where a.[order-id]='{0}' and a.Status<>0
                                                                                ORDER BY a.[Process-Num]", order));
            ViewData["Order"] = order;
            ViewData["ProductId"] = productid;
            ViewData["ProductName"] = conn.Get_ColumnData(string.Format(@"SELECT [product]      
                                                                        FROM [MES-Table].[dbo].[product_Inf] where[product-id] = {0}", productid));
            ViewData["RequestQuantity"] = conn.Get_ColumnData(string.Format(@"SELECT RequestQuantity FROM [dbo].[order]
                                                                        where [order-id]='{0}'", order));
            ViewData["Exp_ST_Date"] = conn.Get_ColumnData(string.Format(@"SELECT CONVERT(nvarchar(10),ST_Date,23) as 'ST_Date' FROM [dbo].[order]
                                                                        where [order-id]='{0}'", order));
            ViewData["Exp_End_Date"] = conn.Get_ColumnData(string.Format(@"SELECT CONVERT(nvarchar(10),End_Date,23) as 'End_Date' FROM [dbo].[order]
                                                                        where [order-id]='{0}'", order));
            ViewData["Act_ST_Date"] = conn.Get_ColumnData(string.Format(@"SELECT CONVERT(nvarchar(10),Act_ST_Date,23) as 'Act_ST_Date' FROM [dbo].[order]
                                                                        where [order-id]='{0}'", order));
            ViewData["Act_End_Date"] = conn.Get_ColumnData(string.Format(@"SELECT CONVERT(nvarchar(10),Act_End_Date,23) as 'Act_End_Date' FROM [dbo].[order]
                                                                        where [order-id]='{0}'", order));
            if (status == "order")
            {
                ViewData["Order_dis"] = "inline";
                ViewData["Product_dis"] = "none";
            }
            else
            {
                ViewData["Order_dis"] = "none";
                ViewData["Product_dis"] = "inline";
            }
            return View();
        }

        public IActionResult OrderInsert_Page()
        {
            conn = new SQL(this.configuration);
            DateTime time = DateTime.Now;
            string order = time.ToString("yyyy-MM-dd HH:mm:ss").Replace("-", "").Replace(":", "").Replace(" ", "");
            order = order.Substring(2, order.Length - 2);
            string judge = conn.Order_Repeat(order);
            while (judge != "Success") {
                order = time.ToString("yyyy-MM-dd HH:mm:ss").Replace("-", "").Replace(":", "").Replace(" ", "");
                judge = conn.Order_Repeat(order);
            }
            ViewData["OrderID"] = order;
            ViewData["Product_Table"] = conn.Get_Information_Data(@"SELECT distinct TOP 5 [product-id]
                                                         FROM[MES-Table].[dbo].[product_Inf] order by [product-id]");
            ViewData["Process_Table"] = conn.Get_Information_Data(@"SELECT distinct [Process]
                                                         FROM[MES-Table].[dbo].[Process_Inf] order by [Process]");
            return View();
        }

        public IActionResult Dispatch_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Order_Table"] = conn.Get_Information_Data(@"SELECT distinct [order-id] FROM [MES-Table ].[dbo].[order] WHERE Dispatch <> 1 order by [order-id]");
            ViewData["Dispatch_Table"] = conn.Get_Information_Data(@"SELECT distinct a.[order-id],a.[Process-Num],d.[Process-Name],b.[product-id],c.product,e.[Staff-Name]
                                                                    ,a.[Schedule-Hour],a.Quantity,a.Dispatch_Time FROM [dbo].[Schedule-Inf] a
                                                                    LEFT JOIN 
                                                                    dbo.[order] b
                                                                    on a.[order-id] = b.[order-id]
                                                                    LEFT JOIN 
                                                                    dbo.product_Inf c 
                                                                    on b.[product-id] = c.[product-id]
                                                                    LEFT JOIN 
                                                                    dbo.Process_Inf d
                                                                    on a.[Process-Num] = d.Process
                                                                    LEFT JOIN 
                                                                    dbo.[Staff-Inf] e
                                                                    on a.[Staff-Num] = e.[Staff-Num]");
            return View();
        }

        public IActionResult WorkStatus_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Machine_Status_Table"] = conn.Get_Information_Data(@"SELECT DISTINCT b.Team,a.[Machine-Num],a.[Machine-Name]
                                                                        ,CASE WHEN a.Status = N'待機中'
                                                                        THEN 'orange'
                                                                        WHEN a.Status = N'運轉中'
                                                                        THEN 'green'
                                                                        ELSE 'gray' 
                                                                        END 'Status'
                                                                        ,a.[order],d.product,c.RequestQuantity
                                                                        FROM [dbo].[Machine_Inf] a
                                                                        LEFT JOIN 
                                                                        dbo.Group_Inf b
                                                                        on a.[Local-Process] = b.[Process-Num]
                                                                        LEFT JOIN
                                                                        dbo.[order] c
                                                                        on a.[order] = c.[order-id]
                                                                        LEFT JOIN
                                                                        dbo.product_Inf d
                                                                        on c.[product-id] = d.[product-id]");
            return View();
        }

        public IActionResult Work_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["staff_name"] = conn.Get_Information_Data(@"SELECT [Staff-Name] 
                                                                FROM [dbo].[Staff-Inf] 
                                                                where Status=N'工作中'");
            return View();
        }

        public IActionResult Machine_Inf_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Table"] = conn.Get_Information_Data(@"  SELECT [Machine-Num],[Machine-Name],[Local-Process],Status 
                                                                FROM [MES-Table ].[dbo].[Machine_Inf] ");
            return View();
        }

        public IActionResult Staff_Inf_Page()
        {
            conn = new SQL(this.configuration);
            ViewData["Table"] = conn.Get_Information_Data(@"SELECT [Staff-Num]
                                                        ,[Staff-Name]
                                                        ,[Process]
                                                        ,[Status]
                                                    FROM [MES-Table ].[dbo].[Staff-Inf]");
            return View();
        }

        public IActionResult History_Page()
        {
            conn = new SQL(this.configuration);
            DataTable[] dt = new DataTable[2];
            //dt[0] = conn.Get_Information_Data(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity
            //                                ,SUM(b.ProductTime) as 'Time'
            //                                --,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'
            //                                ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'  
            //                                ,CONVERT(varchar(20),a.Create_Date,23) as 'Create_Date'
            //                                    from [MES-Table].[dbo].[order] a
            //                                left join 
            //                                [MES-Table].[dbo].[product_Inf] b
            //                                on a.[product-id] = b.[product-id] 
            //                                where a.Dispatch != 0
            //                                GROUP BY a.[order-id],a.[product-id],b.product,a.RequestQuantity,CONVERT(varchar(20),a.ST_Date,23)
            //                                ,CONVERT(varchar(20),a.End_Date,23),CONVERT(varchar(20),a.Create_Date,23)
            //                                order by CONVERT(varchar(20),a.ST_Date,23) desc");            
            dt[0] = conn.Get_Information_Data(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.Act_Quantity
                                                ,SUM(b.ProductTime) as 'Time'                                                
                                                ,CONVERT(varchar(20),a.Create_Date,23) as 'Create_Date'
                                                ,CONVERT(varchar(20),a.Act_End_Date,23) as 'Act_End_Date'
                                                ,a.Place
                                                ,CASE WHEN a.Finish = 1
                                                THEN N'完工'
                                                ELSE N'下所'
                                                END 'Status'
	                                                from [MES-Table].[dbo].[order] a
                                                left join 
                                                [MES-Table].[dbo].[product_Inf] b
                                                on a.[product-id] = b.[product-id] 
                                                WHERE a.Finish = 1
                                                GROUP BY a.[order-id],a.[product-id],b.product,a.Act_Quantity,CONVERT(varchar(20),a.ST_Date,23),a.Place
                                                ,CONVERT(varchar(20),a.End_Date,23),CONVERT(varchar(20),a.Create_Date,23),CONVERT(varchar(20),a.Act_End_Date,23) 
                                                ,CASE WHEN a.Finish = 1
                                                THEN N'完工'
                                                ELSE N'下所'
                                                END 
                                                ,CONVERT(FLOAT,(a.Act_Quantity/a.RequestQuantity))*100
                                                order by CONVERT(varchar(20),a.ST_Date,23) desc");
            dt[1] = conn.Get_Information_Data(@"select a.[order-id] as 'orderid',a.[product-id] as 'productid',
                                                b.product,b.Process,c.[Process-Name],a.RequestQuantity,round(b.ProductTime*a.RequestQuantity ,2) as Time
                                                ,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'
                                                ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'
                                                from [MES-Table].[dbo].[order] a
                                                left join 
                                                [MES-Table].[dbo].[product_Inf] b
                                                on a.[product-id] = b.[product-id] 
                                                LEFT JOIN
                                                [MES-Table].dbo.Process_Inf c
                                                on b.Process = c.Process
                                                where a.Dispatch != 0 
                                                order by CONVERT(varchar(20),a.ST_Date,23) desc,b.Process");
            ViewData["Table"] = dt;
            return View();
        }

        public IActionResult Machine_Inf_Page2(string machine_num)
        {
            conn = new SQL(this.configuration);
            DataTable machine_index = conn.Get_Information_Data(string.Format(@"SELECT *     
                            FROM [MES-Table].[dbo].[Machine_Inf] where[Machine-Num] = '{0}'", machine_num));
            ViewData["machine_index_Table"] = machine_index;
            return View();
            
        }


        public IActionResult Staff_lnf_Page2(string staff_num)
        {
            conn = new SQL(this.configuration);
            DataTable staff_index = conn.Get_Information_Data(string.Format(@"SELECT *     
                            FROM [MES-Table].[dbo].[Staff-Inf] where[Staff-Num] = '{0}'", staff_num));
            ViewData["staff_index_Table"] = staff_index;
            return View();

        }


        [HttpPost]
        public IActionResult Get_Information_Data()
        {
            conn = new SQL(this.configuration);
            //DataTable dt = conn.Get_Information_Data(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity
            //                                                                                    ,SUM(b.ProductTime) as 'Time'
            //                                                                                    ,CONVERT(varchar(20),a.ST_Date,120) as 'ST_Date'
            //                                                                                    ,CONVERT(varchar(20),a.End_Date,120) as 'End_Date'                                                                                                
            //                                                                                     from [MES-Table].[dbo].[order] a
            //                                                                                    left join 
            //                                                                                    [MES-Table].[dbo].[product_Inf] b
            //                                                                                    on a.[product-id] = b.[product-id] 
            //                                                                                    GROUP BY a.[order-id],a.[product-id],b.product,a.RequestQuantity,CONVERT(varchar(20),a.ST_Date,120)
            //                                                                                    ,CONVERT(varchar(20),a.End_Date,120)
            //                                                                                    order by a.[order-id] desc");

            //測試用
            DataTable dt = conn.Get_Information_Data(@"select  a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity
                                                    ,SUM(b.ProductTime) as 'Time'
                                                    ,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'
                                                    ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'                                                                                                
                                                    from [MES-Table].[dbo].[order] a
                                                    left join 
                                                    [MES-Table].[dbo].[product_Inf] b
                                                    on a.[product-id] = b.[product-id] 
                                                    GROUP BY a.[order-id],a.[product-id],b.product,a.RequestQuantity,CONVERT(varchar(20),a.ST_Date,23)
                                                    ,CONVERT(varchar(20),a.End_Date,23)
                                                    UNION All
                                                    select a.[order-id] as 'orderid',a.[product-id] as 'productid',b.product,a.RequestQuantity,round(b.ProductTime*a.RequestQuantity ,2) as Time
                                                    ,CONVERT(varchar(20),a.ST_Date,23) as 'ST_Date'
                                                    ,CONVERT(varchar(20),a.End_Date,23) as 'End_Date'
                                                    from [MES-Table].[dbo].[order] a
                                                    left join 
                                                    [MES-Table].[dbo].[product_Inf] b
                                                    on a.[product-id] = b.[product-id] ");
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            //string json = JsonConvert.SerializeObject(_item);
            return Json(json);
        }

        public IActionResult Get_ProductName(string productid)
        {
            conn = new SQL(this.configuration);
            string id = conn.Get_ColumnData(string.Format(@"SELECT [product]      
                            FROM [MES-Table].[dbo].[product_Inf] where[product-id] = {0}", productid));
            string time = conn.Get_ProductTime(productid);
            item _item = new item()
            {
                productname = id,
                producttime = time
            };
            string json = JsonConvert.SerializeObject(_item);
            return Json(json);
        }

        public IActionResult Insert_Order_Data(string order, string productid, string productname, string quantity, string time, string st_date, string end_date)
        {
            conn = new SQL(this.configuration);
            string response = conn.Insert(order, productid, productname, quantity, time, st_date, end_date);
            DateTime timeid = DateTime.Now;
            string orderid = timeid.ToString("yyyy-MM-dd HH:mm:ss").Replace("-", "").Replace(":", "").Replace(" ", "");
            if (response == "工令新增成功") {
                orderid = orderid.Substring(2, orderid.Length - 2);
                string judge = conn.Order_Repeat(orderid);
                while (judge != "Success") {
                    orderid = timeid.ToString("yyyy-MM-dd HH:mm:ss").Replace("-", "").Replace(":", "").Replace(" ", "");
                    judge = conn.Order_Repeat(orderid);
                }
            }
            return Content(response + "," + orderid);
        }

        public IActionResult Get_Dispatch_Data(string order)
        {
            conn = new SQL(this.configuration);
            //DataTable dt = conn.Get_Information_Data(string.Format(@"SELECT * FROM
            //(
            //select DENSE_RANK() OVER(ORDER BY CONVERT(varchar(20),e.Dispatch_Time,20) DESC) AS ROWID,a.[order-id],a.RequestQuantity
            //,case when e.Quantity is NULL
            //then 0
            //ELSE e.Quantity
            //END 'Quantity'
            //,a.RequestQuantity-case when e.Quantity is NULL
            //then 0
            //ELSE e.Quantity
            //END 'Leave_Quantity'
            //,b.Process,d.[Process-Name] as 'ProcessName',a.[product-id] as 'productid',b.product,c.[Staff-Name]  as 'StaffName',CONVERT(varchar(20),e.Dispatch_Time,20) as 'Dispatch_Time'
            //from [MES-Table].[dbo].[order] a
            //left join 
            //[MES-Table].[dbo].[product_Inf] b
            //on a.[product-id] = b.[product-id] 
            //left join 
            //[MES-Table ].dbo.[Staff-Inf] c
            //on b.[Process] = c.[Process]
            //left join 
            //[MES-Table ].[dbo].[Process_Inf] d
            //on b.[Process] = d.[Process]
            //left join
            //[MES-Table].dbo.[Schedule-Inf] e
            //on a.[order-id] = e.[order-id] and b.[process] = e.[Process-Num]
            //where a.[order-id] = '{0}' 
            //)aa
            //where aa.[Leave_Quantity] <> '0' and aa.ROWID = 1
            //order by aa.Dispatch_Time desc", order));
            List<Dispatch_Item> list = new List<Dispatch_Item>();
            DataTable dt_dis = conn.Get_Information_Data(string.Format(@"SELECT * FROM
            (
            select a.[order-id],b.Process,d.[Process-Name],a.[product-id],b.product,a.RequestQuantity
            ,SUM(e.Quantity) as 'Quantity'
            ,a.RequestQuantity-CASE WHEN SUM(e.Quantity) is NULL
            THEN 0
            ELSE SUM(e.Quantity)
            END 'Leave_Quantity'
            from [MES-Table].[dbo].[order] a
            left join 
            [MES-Table].[dbo].[product_Inf] b
            on a.[product-id] = b.[product-id] 
            left join 
            [MES-Table ].[dbo].[Process_Inf] d
            on b.[Process] = d.[Process]
            left join
            [MES-Table].dbo.[Schedule-Inf] e
            on a.[order-id] = e.[order-id] and b.[process] = e.[Process-Num]
            where a.[order-id] = '{0}'
            GROUP BY  a.[order-id],b.Process,d.[Process-Name],a.[product-id],b.product,a.RequestQuantity
            )aa
            WHERE aa.Leave_Quantity > 0 
            order by aa.Process ", order));
            for (int i = 0; i < dt_dis.Rows.Count; i++)
            {
                DataTable dt_staff = conn.Get_Information_Data(string.Format(@"SELECT [Staff-Name] FROM [dbo].[Staff-Inf]
                where Process={0}", dt_dis.Rows[i][1]));
                list.Add(new Dispatch_Item()
                {
                    order = dt_dis.Rows[i][0].ToString(),
                    process = dt_dis.Rows[i][1].ToString(),
                    processname = dt_dis.Rows[i][2].ToString(),
                    productid = dt_dis.Rows[i][3].ToString(),
                    product = dt_dis.Rows[i][4].ToString(),
                    requestquantity = dt_dis.Rows[i][5].ToString(),
                    quantity = dt_dis.Rows[i][7].ToString(),
                    staff_name = dt_staff.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray()
                });
            }
            var json = JsonConvert.SerializeObject(list);

            //string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Json(json);
        }


        public IActionResult Dispatch_Data(string data)
        {
            //json = JsonConvert.SerializeObject(data);
            conn = new SQL(this.configuration);
            List<Dispatch_Item> item = JsonConvert.DeserializeObject<List<Dispatch_Item>>(data);
            return Content(conn.Dispatch_Data(item));
        }

        public IActionResult Get_Wrok_Data(string staff)
        {
            conn = new SQL(this.configuration);
            DataTable dt = conn.Get_Information_Data(string.Format(@"
                                                                    DECLARE @S nvarchar(12)
                                                                    set @S = (SELECT [Staff-Num] FROM dbo.[Staff-Inf] where [Staff-Name] = N'{0}')
                                                                    SELECT c.[order-id] as 'orderid',e.Process as 'process' ,e.[Process-Name] as 'processname',d.[product-id] as 'productid',d.product,f.[Machine-Name] as 'machinename',a.Quantity as 'quantity',b.[Staff-Name] as 'staffname',b.[Staff-Num] as 'staffnum',a.[Schedule-Hour] as 'schedulehour' FROM dbo.[Schedule-Inf] a
                                                                    INNER JOIN
                                                                    dbo.[Staff-Inf] b
                                                                    on a.[Staff-Num] = b.[Staff-Num] AND CONVERT(VARCHAR(20),a.Dispatch_Time,23) = CONVERT(VARCHAR(20),GETDATE(),23)
                                                                    LEFT JOIN
                                                                    dbo.[order] c
                                                                    on a.[order-id] = c.[order-id]
                                                                    LEFT JOIN 
                                                                    dbo.product_Inf d
                                                                    on c.[product-id] = d.[product-id] and d.Process = b.Process
                                                                    LEFT JOIN
                                                                    dbo.Process_Inf e
                                                                    on a.[Process-Num] = e.Process
                                                                    LEFT JOIN 
                                                                    dbo.Machine_Inf f
                                                                    on b.Process = f.[Local-Process]
                                                                    where b.[Staff-Num] = @S and a.Status = 0
                                                                    ORDER BY e.Process", staff));
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Json(json);
        }

        public IActionResult Get_Machine_Data(string machine)
        {
            conn = new SQL(this.configuration);
            DataTable dt = new DataTable();
            if(machine=="All")
            {
                dt = conn.Get_Information_Data(string.Format(@"select [Machine-Num] as 'machinenum',[Machine-Name] as 'machinename' ,[Local-Process] as 'localprocess' ,Status from dbo.Machine_Inf ", machine));
            }
            else
            {
                dt = conn.Get_Information_Data(string.Format(@"select [Machine-Num] as 'machinenum',[Machine-Name] as 'machinename' ,[Local-Process] as 'localprocess' ,Status from dbo.Machine_Inf where [Machine-Num] = '{0}'", machine));
            }
            
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Json(json);
        }

        public IActionResult Get_Staff_Data(string staff)
        {
            conn = new SQL(this.configuration);
            DataTable dt = new DataTable();
            if (staff == "All")
            {
                dt = conn.Get_Information_Data(string.Format(@"select [Staff-Num] as 'staffnum',[Staff-Name] as 'staffname' ,[Process] as 'process' ,Status from dbo.[Staff-Inf] ", staff));
            }
            else
            {
                dt = conn.Get_Information_Data(string.Format(@"select [Staff-Num] as 'staffnum',[Staff-Name] as 'staffname' ,[Process] as 'process' ,Status from dbo.[Staff-Inf] where [Staff-Num] = '{0}'", staff));
            }            
            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return Json(json);
        }

        public IActionResult Work_Data(string data)
        {            
            conn = new SQL(this.configuration);
            List<Work_Data_Item> item = JsonConvert.DeserializeObject<List<Work_Data_Item>>(data);
            return Content(conn.Work_Data(item));
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
