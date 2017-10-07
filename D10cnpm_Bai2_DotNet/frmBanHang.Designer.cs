namespace D10cnpm_Bai2_DotNet
{
    partial class frmBanHang
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
            System.Windows.Forms.Button btnThemHD;
            System.Windows.Forms.ComboBox cmbMaKH;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefreshHD = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtGhiChuHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongHangBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTienHangBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChuHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnThemHD = new System.Windows.Forms.Button();
            cmbMaKH = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemHD
            // 
            btnThemHD.Location = new System.Drawing.Point(492, 384);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Size = new System.Drawing.Size(62, 40);
            btnThemHD.TabIndex = 32;
            btnThemHD.Text = "Thêm";
            btnThemHD.UseVisualStyleBackColor = true;
            // 
            // cmbMaKH
            // 
            cmbMaKH.FormattingEnabled = true;
            cmbMaKH.Location = new System.Drawing.Point(94, 88);
            cmbMaKH.Name = "cmbMaKH";
            cmbMaKH.Size = new System.Drawing.Size(243, 21);
            cmbMaKH.TabIndex = 15;
            // 
            // btnRefreshHD
            // 
            this.btnRefreshHD.Location = new System.Drawing.Point(825, 384);
            this.btnRefreshHD.Name = "btnRefreshHD";
            this.btnRefreshHD.Size = new System.Drawing.Size(62, 40);
            this.btnRefreshHD.TabIndex = 33;
            this.btnRefreshHD.Text = "Refresh";
            this.btnRefreshHD.UseVisualStyleBackColor = true;
            // 
            // btnCTHD
            // 
            this.btnCTHD.Location = new System.Drawing.Point(744, 384);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(62, 40);
            this.btnCTHD.TabIndex = 29;
            this.btnCTHD.Text = "Chi Tiết";
            this.btnCTHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(660, 384);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(62, 40);
            this.btnXoaHD.TabIndex = 30;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(580, 384);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(62, 40);
            this.btnSuaHD.TabIndex = 31;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnThemKH);
            this.groupBox2.Controls.Add(cmbMaKH);
            this.groupBox2.Controls.Add(this.txtGhiChuHoaDon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoLuongHangBan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpNgayLap);
            this.groupBox2.Controls.Add(this.txtTongTienHangBan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMaHoaDon);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(492, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 352);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bán Hàng";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(339, 86);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(35, 23);
            this.btnThemKH.TabIndex = 16;
            this.btnThemKH.Text = "+";
            this.btnThemKH.UseVisualStyleBackColor = true;
            // 
            // txtGhiChuHoaDon
            // 
            this.txtGhiChuHoaDon.Location = new System.Drawing.Point(94, 194);
            this.txtGhiChuHoaDon.Multiline = true;
            this.txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            this.txtGhiChuHoaDon.Size = new System.Drawing.Size(280, 135);
            this.txtGhiChuHoaDon.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú";
            // 
            // txtSoLuongHangBan
            // 
            this.txtSoLuongHangBan.Location = new System.Drawing.Point(94, 120);
            this.txtSoLuongHangBan.Name = "txtSoLuongHangBan";
            this.txtSoLuongHangBan.Size = new System.Drawing.Size(280, 20);
            this.txtSoLuongHangBan.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số lượng";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(94, 54);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(280, 20);
            this.dtpNgayLap.TabIndex = 10;
            // 
            // txtTongTienHangBan
            // 
            this.txtTongTienHangBan.Location = new System.Drawing.Point(94, 155);
            this.txtTongTienHangBan.Name = "txtTongTienHangBan";
            this.txtTongTienHangBan.Size = new System.Drawing.Size(280, 20);
            this.txtTongTienHangBan.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tổng tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mã khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ngày lập";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(94, 23);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(280, 20);
            this.txtMaHoaDon.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã hóa đơn";
            // 
            // dgvBanHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvBanHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHoaDon,
            this.TenKhachHang,
            this.DienThoaiKhachHang,
            this.TongTien,
            this.GhiChuHD});
            this.dgvBanHang.Location = new System.Drawing.Point(12, 16);
            this.dgvBanHang.Name = "dgvBanHang";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBanHang.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBanHang.Size = new System.Drawing.Size(458, 408);
            this.dgvBanHang.TabIndex = 34;
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "IDHoaDon";
            this.IDHoaDon.HeaderText = "Mã hóa đơn";
            this.IDHoaDon.Name = "IDHoaDon";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // DienThoaiKhachHang
            // 
            this.DienThoaiKhachHang.DataPropertyName = "DienThoaiKhachHang";
            this.DienThoaiKhachHang.HeaderText = "SĐT";
            this.DienThoaiKhachHang.Name = "DienThoaiKhachHang";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // GhiChuHD
            // 
            this.GhiChuHD.DataPropertyName = "GhiChuHD";
            this.GhiChuHD.HeaderText = "Ghi chú";
            this.GhiChuHD.Name = "GhiChuHD";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 440);
            this.Controls.Add(this.dgvBanHang);
            this.Controls.Add(this.btnRefreshHD);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(btnThemHD);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshHD;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongHangBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtTongTienHangBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChuHD;
    }
}