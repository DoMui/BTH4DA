using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Đồ_án_1a
{
    public partial class GUI_SanPham : Form
    {
        private BUS_SanPham busSanPham;
        public GUI_SanPham()
        {
            InitializeComponent();
            busSanPham = new BUS_SanPham();
        }

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvQLSP.DataSource= busSanPham.GetSanPhamList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_SanPham sanPham = new DTO_SanPham();
            sanPham.masp=txtMaSP.Text;
            sanPham.tensp=txtTenSP.Text;
            sanPham.xuatxu = txtXuatXu.Text;
            sanPham.soluong = Convert.ToSingle(txtSoLuong.Text);
            sanPham.gia= Convert.ToSingle(txtGiaBan.Text);
           
            if(busSanPham.ThemSanPham(sanPham))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công");
            }    
        }
    }
}
