using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_SanPham:DBCConnect
    {
        private string connectionString = @"Data Source=LAPTOP-3JSDS55G\SQLEXPRESS01;Initial Catalog=ĐoAn;Integrated Security=True";

        public DataTable GetAllSanPham()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sanpham";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();
            }    
            return dataTable;
        }
        public bool InsertSanPham(string masp, string tensp, float soluong, float gia, string xuatxu)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Sanpham(masp, tensp, soluong, gia, xuatxu) VALUES(@masp, @tensp, @soluong, @gia, @xuatxu)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@masp", masp);
                command.Parameters.AddWithValue("@tenso", tensp);
                command.Parameters.AddWithValue("@soluong", soluong);
                command.Parameters.AddWithValue("@gia", gia);
                command.Parameters.AddWithValue("@xuatxu", xuatxu);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }    
        }
    }
}
