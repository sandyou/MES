using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Extensions.Configuration;
using MES_MVC.Models;

namespace MES_MVC.Data
{
    public class SQL
    {
        private readonly IConfiguration configuration;
        SqlConnection conn;
        public SQL(IConfiguration config)
        {     
            this.configuration = config;       
            conn = new SqlConnection();
            conn.ConnectionString = config.GetConnectionString("DefaultConnectionStrings");
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }

        public DataTable Get_Information_Data(string str)
        {
            conn.Open();
            DataTable dt = new DataTable();
            try
            {                
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter ada = new SqlDataAdapter();
                cmd.Connection = conn;
                cmd.CommandText = str;
                ada.SelectCommand = cmd;
                ada.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                conn.Close();
                return  dt;
            }                                   
        }

        public string Get_ColumnData(string cmd_str)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(cmd_str, conn);
            try
            {
                string str = cmd.ExecuteScalar().ToString();
                conn.Close();
                return str;
            }
            catch (Exception e)
            {
                conn.Close();
                return "";
            }

        }

        public string Get_ProductTime(string id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"SELECT [ProductTime]      
                            FROM[MES-Table].[dbo].[product_Inf] where[product-id] = {0}", id), conn);
            try
            {
                string str = cmd.ExecuteScalar().ToString();
                conn.Close();
                return str;
            }
            catch (Exception e)
            {
                conn.Close();
                return "0";
            }

        }

        public string Insert(string order, string productid, string productname, string quantity, string time, string st_date, string end_date)
        {
            conn.Open();
            SqlCommand order_cmd = new SqlCommand(string.Format("select [order-id] from [dbo].[order] where [order-id]='{0}' ",order),conn);
            string judge = "";
            try
            {
                judge = order_cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                judge = "";                
            }
            if(judge=="")
            {
                SqlCommand cmd = new SqlCommand(string.Format(
                @"insert into [dbo].[order]([order-id],[product-id],RequestQuantity,ST_Date,End_Date,Act_ST_Date,Place) values('{0}','{1}','{2}','{3}','{4}','{3}',N'自槍所')", order, productid, quantity, st_date, end_date), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "工令新增成功";
            }
            else
            {
                conn.Close();
                return "此工令已存在，請重新輸入";                
            }                        
        }

        public string Order_Repeat(string order)
        {
            conn.Open();
            SqlCommand cmd =new SqlCommand(string.Format("select [order-id] from [dbo].[order] where [order-id]='{0}' ",order),conn);
            string judge = "";
            try
            {
                judge = cmd.ExecuteScalar().ToString();
                conn.Close();
                return "Fail";
            }
            catch (Exception)
            {                
                conn.Close();
                return "Success";
            }            
        }        

        public string Dispatch_Data(List<Dispatch_Item>list)
        {
            conn.Open();
            for(int i=0;i<list.Count;i++)
            {
                //SqlCommand cmd = new SqlCommand(string.Format(
                //    @"
                //    declare @Q INT
                //    set @Q = (SELECT RequestQuantity FROM dbo.[order] where [order-id]='{0}')
                //    declare @S INT
                //    set @S = (SELECT [Staff-Num] FROM dbo.[Staff-Inf] where [Staff-Name]=N'{3}')
                //    INSERT INTO [dbo].[Schedule-Inf]([order-id],Quantity,[Process-Num],[Schedule-Hour],[Staff-Num])
                //    VALUES('{0}', @Q, '{1}', '{2}', @S)", list[i].order,list[i].process,list[i].time,list[i].staff),conn);
                SqlCommand cmd = new SqlCommand(string.Format(
                    @"                    
                    declare @S INT
                    set @S = (SELECT [Staff-Num] FROM dbo.[Staff-Inf] where [Staff-Name]=N'{4}')
                    declare @ST nvarchar(20)
                    set @ST = (SELECT CONVERT(nvarchar(20),ST_Date,23) FROM dbo.[order] where [order-id] = '{0}')
                    declare @End_T nvarchar(20)
                    set @End_T = (SELECT CONVERT(nvarchar(20),End_Date,23) FROM dbo.[order] where [order-id] = '{0}')
                    INSERT INTO [dbo].[Schedule-Inf]([order-id],Quantity,[Process-Num],[Schedule-Hour],[Staff-Num],Exp_ST_Date,Exp_End_Date,Act_ST_Date)
                    VALUES('{0}',{1}, '{2}', '{3}', @S,@ST,@End_T,@ST)
                    update dbo.Machine_Inf 
                    set Status = N'運轉中',[order]='{0}'
                    where [Local-Process] = '{2}' 
                    update dbo.[Staff-Inf] 
                    SET Status = N'工作中' 
                    where [Staff-Num] = @S", list[i].order,list[i].quantity, list[i].process, list[i].time, list[i].staff), conn);
                cmd.ExecuteNonQuery();
                if(i==list.Count-1)
                {                    
                    SqlCommand cmd_ = new SqlCommand(string.Format(@"declare @C INT
                    set @C = (SELECT COUNT(*) FROM product_Inf where [product-id] = '{1}')
                    declare @C_ INT
                    set @C_ = (SELECT COUNT(*) from	
                    (
                    SELECT a.*,b.RequestQuantity
                    ,CASE WHEN b.RequestQuantity - a.Quantity <=0
                    THEN 1
                    ELSE 0
                    END 
                    'Status'
                    FROM
                    (
                    SELECT [order-id],[Process-Num],SUM(Quantity) as 'Quantity' FROM dbo.[Schedule-Inf]
                    where [order-id] = '{0}'
                    GROUP BY [order-id],[Process-Num]
                    )a
                    LEFT JOIN 
                    dbo.[order] b
                    on a.[order-id] = b.[order-id]
                    )aa
                    where aa.Status = 1)
                    IF @C = @C_
                    BEGIN
	                    update [dbo].[order] set Dispatch = 1 where [order-id]='{0}'
                    END", list[i].order,list[i].productid), conn);
                    cmd_.ExecuteNonQuery();
                }
            }
            conn.Close();
            return "派工成功";
        }

        public string Work_Data(List<Work_Data_Item> list)
        {
            conn.Open();
            for(int i=0;i<list.Count;i++)
            {
                SqlCommand cmd = new SqlCommand(string.Format(@"
                                            DECLARE @S nvarchar(12)
                                            set @S = (SELECT [Staff-Num] FROM dbo.[Staff-Inf] where [Staff-Name] = N'{0}')
                                            DECLARE @M nvarchar(12)
                                            set @M = (SELECT [Machine-Num] FROM dbo.[Machine_Inf] where [Machine-Name] = N'{1}')
                                            UPDATE dbo.[Schedule-Inf] 
                                            SET Finish_Quantity='{2}',Act_Work_Hour='{3}',Act_End_Date=GETDATE(),Status=1 where [Staff-Num]=@S and [order-id] = '{4}' and convert(nvarchar(20),Dispatch_Time,23) = convert(nvarchar(20),GETDATE(),23) and Status = 0
                                            UPDATE dbo.[Staff-Inf]
                                            SET Status = N'閒置中' WHERE [Staff-Num]=@S
                                            UPDATE dbo.Machine_Inf
                                            SET Status = N'待機中',[order] = '' WHERE [Machine-Num] =@M  
                                            ", list[i].staff,list[i].machine,list[i].quantity,list[i].time,list[i].order), conn);
                cmd.ExecuteNonQuery();
            }            
            conn.Close();
            return "報工成功";
        }

        public void Insert_Machine_Inf(string machine_num, string machine_name, string process, string status) 
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"insert into [dbo].[Machine_Inf]([Machine-Num],[Machine-Name],[Local-Process],[Status])
                                                            values('{0}',N'{1}','{2}',N'{3}')",machine_num,machine_name,process,status),conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Insert_Staff_Inf(string staff_num, string staff_name, string process, string status)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"insert into [dbo].[Staff-Inf]([Staff-Num],[Staff-Name],[Process],[Status])
                                                            values('{0}',N'{1}','{2}',N'{3}')", staff_num, staff_name, process, status), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}