using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Extensions.Configuration;

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
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            cmd.Connection = conn;
            cmd.CommandText = str;
            ada.SelectCommand = cmd;
            ada.Fill(dt);
            conn.Close();
            return dt;            
        }

        public string Get_ProductName(string id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(string.Format(@"SELECT [product]      
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
                @"insert into [dbo].[order]([order-id],[product-id],RequestQuantity,ST_Date,End_Date) values('{0}','{1}','{2}','{3}','{4}')", order, productid, quantity, st_date, end_date), conn);
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

    }
}