using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_SanPham
    {
        private DAL_SanPham dalSanPham;

        public BUS_SanPham()
        {
            dalSanPham = new DAL_SanPham();
        }
        public DataTable GetSanPhamList()
        {
            return dalSanPham.GetAllSanPham();
        }
        public bool ThemSanPham(DTO_SanPham sanPham)
        {
            return
                dalSanPham.InsertSanPham(sanPham.masp, sanPham.tensp, sanPham.soluong, sanPham.gia, sanPham.xuatxu);
        }
    }
}
