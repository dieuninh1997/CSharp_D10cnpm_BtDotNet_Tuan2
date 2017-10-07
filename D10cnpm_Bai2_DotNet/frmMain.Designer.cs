namespace D10cnpm_Bai2_DotNet
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTKNH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTKBH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTKTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTKDoanhSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhapHang,
            this.menuBanHang});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // menuNhapHang
            // 
            this.menuNhapHang.Name = "menuNhapHang";
            this.menuNhapHang.Size = new System.Drawing.Size(135, 22);
            this.menuNhapHang.Text = "Nhập Hàng";
            this.menuNhapHang.Click += new System.EventHandler(this.menuNhapHang_Click);
            // 
            // menuBanHang
            // 
            this.menuBanHang.Name = "menuBanHang";
            this.menuBanHang.Size = new System.Drawing.Size(135, 22);
            this.menuBanHang.Text = "Bán Hàng";
            this.menuBanHang.Click += new System.EventHandler(this.menuBanHang_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTKNH,
            this.menuTKBH,
            this.menuTKTonKho,
            this.menuTKDoanhSo});
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "Thống Kê - Báo Cáo";
            // 
            // menuTKNH
            // 
            this.menuTKNH.Name = "menuTKNH";
            this.menuTKNH.Size = new System.Drawing.Size(169, 22);
            this.menuTKNH.Text = "Nhập Hàng";
            this.menuTKNH.Click += new System.EventHandler(this.menuTKNH_Click);
            // 
            // menuTKBH
            // 
            this.menuTKBH.Name = "menuTKBH";
            this.menuTKBH.Size = new System.Drawing.Size(169, 22);
            this.menuTKBH.Text = "Bán Hàng";
            this.menuTKBH.Click += new System.EventHandler(this.menuTKBH_Click);
            // 
            // menuTKTonKho
            // 
            this.menuTKTonKho.Name = "menuTKTonKho";
            this.menuTKTonKho.Size = new System.Drawing.Size(169, 22);
            this.menuTKTonKho.Text = "Tồn Kho";
            this.menuTKTonKho.Click += new System.EventHandler(this.menuTKTonKho_Click);
            // 
            // menuTKDoanhSo
            // 
            this.menuTKDoanhSo.Name = "menuTKDoanhSo";
            this.menuTKDoanhSo.Size = new System.Drawing.Size(169, 22);
            this.menuTKDoanhSo.Text = "Biểu Đồ Doanh Số";
            this.menuTKDoanhSo.Click += new System.EventHandler(this.menuTKDoanhSo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 441);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menuBanHang;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTKNH;
        private System.Windows.Forms.ToolStripMenuItem menuTKBH;
        private System.Windows.Forms.ToolStripMenuItem menuTKTonKho;
        private System.Windows.Forms.ToolStripMenuItem menuTKDoanhSo;
    }
}