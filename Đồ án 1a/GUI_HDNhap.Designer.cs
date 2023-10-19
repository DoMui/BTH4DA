namespace Đồ_án_1a
{
    partial class GUI_HDNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbTTHDN = new System.Windows.Forms.GroupBox();
            this.grbTKHDN = new System.Windows.Forms.GroupBox();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.ttxMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTKNCC = new System.Windows.Forms.Label();
            this.txtTKNCC = new System.Windows.Forms.TextBox();
            this.lblTKNgayNhap = new System.Windows.Forms.Label();
            this.btnChitietHDN = new System.Windows.Forms.Button();
            this.btnTKHDN = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.grbTTHDN.SuspendLayout();
            this.grbTKHDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTHDN
            // 
            this.grbTTHDN.BackColor = System.Drawing.Color.Lavender;
            this.grbTTHDN.Controls.Add(this.dateTimePicker1);
            this.grbTTHDN.Controls.Add(this.btnChitietHDN);
            this.grbTTHDN.Controls.Add(this.lblNgayNhap);
            this.grbTTHDN.Controls.Add(this.ttxMaNCC);
            this.grbTTHDN.Controls.Add(this.lblMaNCC);
            this.grbTTHDN.Controls.Add(this.txtMaNV);
            this.grbTTHDN.Controls.Add(this.lblMaNV);
            this.grbTTHDN.Controls.Add(this.txtMaHDN);
            this.grbTTHDN.Controls.Add(this.lblMaHDN);
            this.grbTTHDN.Location = new System.Drawing.Point(12, 12);
            this.grbTTHDN.Name = "grbTTHDN";
            this.grbTTHDN.Size = new System.Drawing.Size(637, 204);
            this.grbTTHDN.TabIndex = 0;
            this.grbTTHDN.TabStop = false;
            this.grbTTHDN.Text = "Thông tin hóa đơn nhập";
            // 
            // grbTKHDN
            // 
            this.grbTKHDN.BackColor = System.Drawing.Color.Lavender;
            this.grbTKHDN.Controls.Add(this.dateTimePicker2);
            this.grbTKHDN.Controls.Add(this.btnTKHDN);
            this.grbTKHDN.Controls.Add(this.lblTKNgayNhap);
            this.grbTKHDN.Controls.Add(this.txtTKNCC);
            this.grbTKHDN.Controls.Add(this.lblTKNCC);
            this.grbTKHDN.Location = new System.Drawing.Point(670, 12);
            this.grbTKHDN.Name = "grbTKHDN";
            this.grbTKHDN.Size = new System.Drawing.Size(383, 204);
            this.grbTKHDN.TabIndex = 1;
            this.grbTKHDN.TabStop = false;
            this.grbTKHDN.Text = "Tìm kiếm hóa đơn nhập";
            // 
            // dgvHDN
            // 
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Location = new System.Drawing.Point(12, 235);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.RowHeadersWidth = 62;
            this.dgvHDN.RowTemplate.Height = 28;
            this.dgvHDN.Size = new System.Drawing.Size(1041, 252);
            this.dgvHDN.TabIndex = 2;
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Location = new System.Drawing.Point(35, 44);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(70, 20);
            this.lblMaHDN.TabIndex = 0;
            this.lblMaHDN.Text = "Mã HDN";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(157, 41);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(132, 26);
            this.txtMaHDN.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(157, 95);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 26);
            this.txtMaNV.TabIndex = 3;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(35, 98);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(103, 20);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // ttxMaNCC
            // 
            this.ttxMaNCC.Location = new System.Drawing.Point(478, 41);
            this.ttxMaNCC.Name = "ttxMaNCC";
            this.ttxMaNCC.Size = new System.Drawing.Size(132, 26);
            this.ttxMaNCC.TabIndex = 5;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(325, 44);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(131, 20);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(325, 98);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(85, 20);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblTKNCC
            // 
            this.lblTKNCC.AutoSize = true;
            this.lblTKNCC.Location = new System.Drawing.Point(42, 44);
            this.lblTKNCC.Name = "lblTKNCC";
            this.lblTKNCC.Size = new System.Drawing.Size(131, 20);
            this.lblTKNCC.TabIndex = 0;
            this.lblTKNCC.Text = "Mã nhà cung cấp";
            // 
            // txtTKNCC
            // 
            this.txtTKNCC.Location = new System.Drawing.Point(191, 41);
            this.txtTKNCC.Name = "txtTKNCC";
            this.txtTKNCC.Size = new System.Drawing.Size(149, 26);
            this.txtTKNCC.TabIndex = 1;
            // 
            // lblTKNgayNhap
            // 
            this.lblTKNgayNhap.AutoSize = true;
            this.lblTKNgayNhap.Location = new System.Drawing.Point(44, 98);
            this.lblTKNgayNhap.Name = "lblTKNgayNhap";
            this.lblTKNgayNhap.Size = new System.Drawing.Size(85, 20);
            this.lblTKNgayNhap.TabIndex = 2;
            this.lblTKNgayNhap.Text = "Ngày nhập";
            // 
            // btnChitietHDN
            // 
            this.btnChitietHDN.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChitietHDN.Location = new System.Drawing.Point(39, 143);
            this.btnChitietHDN.Name = "btnChitietHDN";
            this.btnChitietHDN.Size = new System.Drawing.Size(571, 43);
            this.btnChitietHDN.TabIndex = 8;
            this.btnChitietHDN.Text = "Chi tiết hóa đơn nhập";
            this.btnChitietHDN.UseVisualStyleBackColor = false;
            // 
            // btnTKHDN
            // 
            this.btnTKHDN.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKHDN.Location = new System.Drawing.Point(46, 143);
            this.btnTKHDN.Name = "btnTKHDN";
            this.btnTKHDN.Size = new System.Drawing.Size(294, 43);
            this.btnTKHDN.TabIndex = 4;
            this.btnTKHDN.Text = "Tìm kiếm";
            this.btnTKHDN.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.Location = new System.Drawing.Point(26, 507);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 48);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(225, 507);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 48);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(447, 507);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 48);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLamMoi.Location = new System.Drawing.Point(660, 507);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(134, 48);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(886, 507);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 48);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 99);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // GUI_HDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1065, 567);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHDN);
            this.Controls.Add(this.grbTKHDN);
            this.Controls.Add(this.grbTTHDN);
            this.Name = "GUI_HDNhap";
            this.Text = "GUI_HDNhap";
            this.grbTTHDN.ResumeLayout(false);
            this.grbTTHDN.PerformLayout();
            this.grbTKHDN.ResumeLayout(false);
            this.grbTKHDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTHDN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnChitietHDN;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox ttxMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.GroupBox grbTKHDN;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnTKHDN;
        private System.Windows.Forms.Label lblTKNgayNhap;
        private System.Windows.Forms.TextBox txtTKNCC;
        private System.Windows.Forms.Label lblTKNCC;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}