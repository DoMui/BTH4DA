namespace Đồ_án_1a
{
    partial class GUI_QLNV
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
            this.grbTTNV = new System.Windows.Forms.GroupBox();
            this.btnQLCV = new System.Windows.Forms.Button();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMKDN = new System.Windows.Forms.TextBox();
            this.lblMKDN = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTennv = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.lblManv = new System.Windows.Forms.Label();
            this.grbTKNV = new System.Windows.Forms.GroupBox();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuanv = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grbTTNV.SuspendLayout();
            this.grbTKNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTNV
            // 
            this.grbTTNV.BackColor = System.Drawing.Color.Lavender;
            this.grbTTNV.Controls.Add(this.btnQLCV);
            this.grbTTNV.Controls.Add(this.rdoNu);
            this.grbTTNV.Controls.Add(this.rdoNam);
            this.grbTTNV.Controls.Add(this.dateTimePicker1);
            this.grbTTNV.Controls.Add(this.cbbChucVu);
            this.grbTTNV.Controls.Add(this.lblgioitinh);
            this.grbTTNV.Controls.Add(this.lblNgaysinh);
            this.grbTTNV.Controls.Add(this.lblChucvu);
            this.grbTTNV.Controls.Add(this.txtSDT);
            this.grbTTNV.Controls.Add(this.lblSDT);
            this.grbTTNV.Controls.Add(this.txtMKDN);
            this.grbTTNV.Controls.Add(this.lblMKDN);
            this.grbTTNV.Controls.Add(this.textBox2);
            this.grbTTNV.Controls.Add(this.lblTennv);
            this.grbTTNV.Controls.Add(this.txtManv);
            this.grbTTNV.Controls.Add(this.lblManv);
            this.grbTTNV.Location = new System.Drawing.Point(12, 12);
            this.grbTTNV.Name = "grbTTNV";
            this.grbTTNV.Size = new System.Drawing.Size(634, 303);
            this.grbTTNV.TabIndex = 0;
            this.grbTTNV.TabStop = false;
            this.grbTTNV.Text = "Thông tin nhân viên";
            // 
            // btnQLCV
            // 
            this.btnQLCV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnQLCV.Location = new System.Drawing.Point(320, 233);
            this.btnQLCV.Name = "btnQLCV";
            this.btnQLCV.Size = new System.Drawing.Size(265, 47);
            this.btnQLCV.TabIndex = 18;
            this.btnQLCV.Text = "Quản lý chức vụ";
            this.btnQLCV.UseVisualStyleBackColor = false;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(531, 185);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(54, 24);
            this.rdoNu.TabIndex = 17;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(428, 185);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(67, 24);
            this.rdoNam.TabIndex = 16;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbbChucVu.Location = new System.Drawing.Point(428, 43);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(157, 28);
            this.cbbChucVu.TabIndex = 14;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(316, 189);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(67, 20);
            this.lblgioitinh.TabIndex = 12;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(316, 116);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(78, 20);
            this.lblNgaysinh.TabIndex = 10;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Location = new System.Drawing.Point(317, 43);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(66, 20);
            this.lblChucvu.TabIndex = 8;
            this.lblChucvu.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(145, 254);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(131, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(25, 257);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 20);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "SĐT";
            // 
            // txtMKDN
            // 
            this.txtMKDN.Location = new System.Drawing.Point(145, 186);
            this.txtMKDN.Name = "txtMKDN";
            this.txtMKDN.Size = new System.Drawing.Size(131, 26);
            this.txtMKDN.TabIndex = 5;
            // 
            // lblMKDN
            // 
            this.lblMKDN.AutoSize = true;
            this.lblMKDN.Location = new System.Drawing.Point(25, 189);
            this.lblMKDN.Name = "lblMKDN";
            this.lblMKDN.Size = new System.Drawing.Size(75, 20);
            this.lblMKDN.TabIndex = 4;
            this.lblMKDN.Text = "Mật khẩu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 26);
            this.textBox2.TabIndex = 3;
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Location = new System.Drawing.Point(25, 116);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(108, 20);
            this.lblTennv.TabIndex = 2;
            this.lblTennv.Text = "Tên nhân viên";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(145, 43);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(131, 26);
            this.txtManv.TabIndex = 1;
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Location = new System.Drawing.Point(25, 43);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(103, 20);
            this.lblManv.TabIndex = 0;
            this.lblManv.Text = "Mã nhân viên";
            // 
            // grbTKNV
            // 
            this.grbTKNV.BackColor = System.Drawing.Color.Lavender;
            this.grbTKNV.Controls.Add(this.btnTKNV);
            this.grbTKNV.Controls.Add(this.textBox3);
            this.grbTKNV.Controls.Add(this.label2);
            this.grbTKNV.Controls.Add(this.textBox1);
            this.grbTKNV.Controls.Add(this.label1);
            this.grbTKNV.Location = new System.Drawing.Point(662, 12);
            this.grbTKNV.Name = "grbTKNV";
            this.grbTKNV.Size = new System.Drawing.Size(375, 303);
            this.grbTKNV.TabIndex = 1;
            this.grbTKNV.TabStop = false;
            this.grbTKNV.Text = "Tìm kiếm nhân viên";
            // 
            // btnTKNV
            // 
            this.btnTKNV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKNV.Location = new System.Drawing.Point(44, 228);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(274, 49);
            this.btnTKNV.TabIndex = 6;
            this.btnTKNV.Text = "Tìm kiếm nhân viên";
            this.btnTKNV.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(907, 608);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 51);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThemNV.Location = new System.Drawing.Point(24, 608);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(121, 51);
            this.btnThemNV.TabIndex = 4;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSuanv.Location = new System.Drawing.Point(239, 608);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(121, 51);
            this.btnSuanv.TabIndex = 5;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoaNV.Location = new System.Drawing.Point(462, 608);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(122, 51);
            this.btnXoaNV.TabIndex = 6;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLamMoi.Location = new System.Drawing.Point(683, 608);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 51);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // GUI_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1049, 663);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuanv);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbTKNV);
            this.Controls.Add(this.grbTTNV);
            this.Name = "GUI_QLNV";
            this.Text = "Quản lý nhân viên";
            this.grbTTNV.ResumeLayout(false);
            this.grbTTNV.PerformLayout();
            this.grbTKNV.ResumeLayout(false);
            this.grbTKNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTNV;
        private System.Windows.Forms.GroupBox grbTKNV;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtMKDN;
        private System.Windows.Forms.Label lblMKDN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Button btnQLCV;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Button btnTKNV;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnLamMoi;
    }
}