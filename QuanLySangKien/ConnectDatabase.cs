﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySangKien
{
    class ConnectDatabase
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        private static DataTable dt;
        public static SqlDataAdapter adap;
        public static string sqlConnect = @"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True";
        
        public DataTable getdata(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                conn = new SqlConnection(sqlConnect);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                adap = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adap.Fill(dt);
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi getData");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return dt;
        }
        public int RepairData(string sql)
        {
            Console.WriteLine(sql);
            int rowCount = 0;
            try
            {
                conn = new SqlConnection(sqlConnect);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi phần InsertData module ConnectDatabase");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return rowCount;
        }
        public int insetGetId(string sql)
        {
            int newId = 0;
            try
            {
                conn = new SqlConnection(sqlConnect);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                newId = (int)cmd.ExecuteScalar();
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi phần InsertData module ConnectDatabase");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return newId;
        }
    }
}
