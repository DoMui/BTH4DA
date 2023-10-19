using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_dbConnec
    {
        private SqlConnection conn;
        public DAL_dbConnec()
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-3JSDS55G\SQLEXPRESS01;Initial Catalog=ĐoAn;Integrated Security=True");
        }
        public DataTable GetDataTable(string strSQL) //select
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable GetDataTable(string procName, SqlParameter[]para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if(para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public int ExecuteSQL (string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL,conn);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
        public int ExecuteSQL(string procName, SqlParameter[]para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            if (para != null)
                cmd.Parameters.AddRange(para);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            return row;
        }
    }
}
