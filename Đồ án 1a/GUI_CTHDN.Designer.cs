﻿namespace Đồ_án_1a
{
    partial class GUI_CTHDN
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
            this.grbCTHDN = new System.Windows.Forms.GroupBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.dgvCTHDN = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.txtMaCTHDB = new System.Windows.Forms.TextBox();
            this.lblMaCTHDN = new System.Windows.Forms.Label();
            this.grbCTHDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCTHDN
            // 
            this.grbCTHDN.BackColor = System.Drawing.Color.Lavender;
            this.grbCTHDN.Controls.Add(this.txtMaCTHDB);
            this.grbCTHDN.Controls.Add(this.lblMaCTHDN);
            this.grbCTHDN.Controls.Add(this.txtMaHDN);
            this.grbCTHDN.Controls.Add(this.lblMaHDN);
            this.grbCTHDN.Controls.Add(this.txtTong);
            this.grbCTHDN.Controls.Add(this.lblTong);
            this.grbCTHDN.Controls.Add(this.txtGia);
            this.grbCTHDN.Controls.Add(this.lblGia);
            this.grbCTHDN.Controls.Add(this.txtSL);
            this.grbCTHDN.Controls.Add(this.lblSL);
            this.grbCTHDN.Controls.Add(this.txtSP);
            this.grbCTHDN.Controls.Add(this.lblSP);
            this.grbCTHDN.Location = new System.Drawing.Point(12, 12);
            this.grbCTHDN.Name = "grbCTHDN";
            this.grbCTHDN.Size = new System.Drawing.Size(1001, 247);
            this.grbCTHDN.TabIndex = 1;
            this.grbCTHDN.TabStop = false;
            this.grbCTHDN.Text = "Chi tiết HDN";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(762, 202);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(181, 26);
            this.txtTong.TabIndex = 7;
            this.txtTong.TextChanged += new System.EventHandler(this.txtTong_TextChanged);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(630, 205);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(75, 20);
            this.lblTong.TabIndex = 6;
            this.lblTong.Text = "Tổng tiền";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(199, 202);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(181, 26);
            this.txtGia.TabIndex = 5;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(38, 205);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 20);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(762, 126);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(181, 26);
            this.txtSL.TabIndex = 3;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(635, 126);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(72, 20);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "Số lượng";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(199, 126);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(181, 26);
            this.txtSP.TabIndex = 1;
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(38, 129);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(82, 20);
            this.lblSP.TabIndex = 0;
            this.lblSP.Text = "Sản phẩm";
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDN.Location = new System.Drawing.Point(12, 282);
            this.dgvCTHDN.Name = "dgvCTHDN";
            this.dgvCTHDN.RowHeadersWidth = 62;
            this.dgvCTHDN.RowTemplate.Height = 28;
            this.dgvCTHDN.Size = new System.Drawing.Size(1001, 251);
            this.dgvCTHDN.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(872, 556);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 48);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLamMoi.Location = new System.Drawing.Point(646, 556);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(134, 48);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(433, 556);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 48);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(211, 556);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 48);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCapNhat.Location = new System.Drawing.Point(12, 556);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(134, 48);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Location = new System.Drawing.Point(635, 44);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(70, 20);
            this.lblMaHDN.TabIndex = 8;
            this.lblMaHDN.Text = "Mã HDN";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(762, 41);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(181, 26);
            this.txtMaHDN.TabIndex = 9;
            // 
            // txtMaCTHDB
            // 
            this.txtMaCTHDB.Location = new System.Drawing.Point(199, 41);
            this.txtMaCTHDB.Name = "txtMaCTHDB";
            this.txtMaCTHDB.Size = new System.Drawing.Size(181, 26);
            this.txtMaCTHDB.TabIndex = 11;
            // 
            // lblMaCTHDN
            // 
            this.lblMaCTHDN.AutoSize = true;
            this.lblMaCTHDN.Location = new System.Drawing.Point(38, 44);
            this.lblMaCTHDN.Name = "lblMaCTHDN";
            this.lblMaCTHDN.Size = new System.Drawing.Size(120, 20);
            this.lblMaCTHDN.TabIndex = 10;
            this.lblMaCTHDN.Text = "Mã chi tiết HDN";
            // 
            // GUI_CTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1025, 628);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvCTHDN);
            this.Controls.Add(this.grbCTHDN);
            this.Name = "GUI_CTHDN";
            this.Text = "GUI_CTHDN";
            this.grbCTHDN.ResumeLayout(false);
            this.grbCTHDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbCTHDN;
        private System.Windows.Forms.DataGridView dgvCTHDN;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.TextBox txtMaCTHDB;
        private System.Windows.Forms.Label lblMaCTHDN;
    }
}