namespace Đồ_án_1a
{
    partial class GUI_QLKH
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
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.lblSDTKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.grbTKKH = new System.Windows.Forms.GroupBox();
            this.btnTKKH = new System.Windows.Forms.Button();
            this.txtTKTenKH = new System.Windows.Forms.TextBox();
            this.lblTKTenKH = new System.Windows.Forms.Label();
            this.txtTKMaKH = new System.Windows.Forms.TextBox();
            this.lblTMaKH = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.grbTTKH.SuspendLayout();
            this.grbTKKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTKH
            // 
            this.grbTTKH.BackColor = System.Drawing.Color.Lavender;
            this.grbTTKH.Controls.Add(this.txtDiaChi);
            this.grbTTKH.Controls.Add(this.lblDiaChi);
            this.grbTTKH.Controls.Add(this.txtSDTKH);
            this.grbTTKH.Controls.Add(this.lblSDTKH);
            this.grbTTKH.Controls.Add(this.txtTenKH);
            this.grbTTKH.Controls.Add(this.lblTenKH);
            this.grbTTKH.Controls.Add(this.txtMaKH);
            this.grbTTKH.Controls.Add(this.lblMaKH);
            this.grbTTKH.Location = new System.Drawing.Point(12, 12);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(654, 256);
            this.grbTTKH.TabIndex = 0;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin khách hàng";
            this.grbTTKH.Enter += new System.EventHandler(this.grbTTKH_Enter);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(221, 154);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(343, 26);
            this.txtSDTKH.TabIndex = 5;
            // 
            // lblSDTKH
            // 
            this.lblSDTKH.AutoSize = true;
            this.lblSDTKH.Location = new System.Drawing.Point(40, 157);
            this.lblSDTKH.Name = "lblSDTKH";
            this.lblSDTKH.Size = new System.Drawing.Size(102, 20);
            this.lblSDTKH.TabIndex = 4;
            this.lblSDTKH.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(221, 100);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(343, 26);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(40, 103);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(123, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(221, 44);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(343, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(40, 47);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(118, 20);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // grbTKKH
            // 
            this.grbTKKH.BackColor = System.Drawing.Color.Lavender;
            this.grbTKKH.Controls.Add(this.btnTKKH);
            this.grbTKKH.Controls.Add(this.txtTKTenKH);
            this.grbTKKH.Controls.Add(this.lblTKTenKH);
            this.grbTKKH.Controls.Add(this.txtTKMaKH);
            this.grbTKKH.Controls.Add(this.lblTMaKH);
            this.grbTKKH.Location = new System.Drawing.Point(688, 12);
            this.grbTKKH.Name = "grbTKKH";
            this.grbTKKH.Size = new System.Drawing.Size(350, 256);
            this.grbTKKH.TabIndex = 1;
            this.grbTKKH.TabStop = false;
            this.grbTKKH.Text = "Tìm kiếm khách hàng";
            // 
            // btnTKKH
            // 
            this.btnTKKH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKKH.Location = new System.Drawing.Point(32, 179);
            this.btnTKKH.Name = "btnTKKH";
            this.btnTKKH.Size = new System.Drawing.Size(280, 46);
            this.btnTKKH.TabIndex = 4;
            this.btnTKKH.Text = "Tìm kiếm";
            this.btnTKKH.UseVisualStyleBackColor = false;
            // 
            // txtTKTenKH
            // 
            this.txtTKTenKH.Location = new System.Drawing.Point(143, 118);
            this.txtTKTenKH.Name = "txtTKTenKH";
            this.txtTKTenKH.Size = new System.Drawing.Size(169, 26);
            this.txtTKTenKH.TabIndex = 3;
            // 
            // lblTKTenKH
            // 
            this.lblTKTenKH.AutoSize = true;
            this.lblTKTenKH.Location = new System.Drawing.Point(6, 121);
            this.lblTKTenKH.Name = "lblTKTenKH";
            this.lblTKTenKH.Size = new System.Drawing.Size(123, 20);
            this.lblTKTenKH.TabIndex = 2;
            this.lblTKTenKH.Text = "Tên khách hàng";
            // 
            // txtTKMaKH
            // 
            this.txtTKMaKH.Location = new System.Drawing.Point(143, 43);
            this.txtTKMaKH.Name = "txtTKMaKH";
            this.txtTKMaKH.Size = new System.Drawing.Size(169, 26);
            this.txtTKMaKH.TabIndex = 1;
            // 
            // lblTMaKH
            // 
            this.lblTMaKH.AutoSize = true;
            this.lblTMaKH.Location = new System.Drawing.Point(6, 46);
            this.lblTMaKH.Name = "lblTMaKH";
            this.lblTMaKH.Size = new System.Drawing.Size(118, 20);
            this.lblTMaKH.TabIndex = 0;
            this.lblTMaKH.Text = "Mã khách hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(12, 282);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 62;
            this.dgvKH.RowTemplate.Height = 28;
            this.dgvKH.Size = new System.Drawing.Size(1026, 252);
            this.dgvKH.TabIndex = 2;
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThemKH.Location = new System.Drawing.Point(27, 551);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(101, 46);
            this.btnThemKH.TabIndex = 3;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(314, 551);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 46);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(605, 551);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 46);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(908, 551);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 46);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(221, 211);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(343, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(40, 214);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // GUI_QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1050, 609);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.grbTKKH);
            this.Controls.Add(this.grbTTKH);
            this.Name = "GUI_QLKH";
            this.Text = "GUI_QLKH";
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.grbTKKH.ResumeLayout(false);
            this.grbTKKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.GroupBox grbTKKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label lblSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Button btnTKKH;
        private System.Windows.Forms.TextBox txtTKTenKH;
        private System.Windows.Forms.Label lblTKTenKH;
        private System.Windows.Forms.TextBox txtTKMaKH;
        private System.Windows.Forms.Label lblTMaKH;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
    }
}