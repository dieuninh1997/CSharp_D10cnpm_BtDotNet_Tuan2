namespace D10cnpm_Bai2_DotNet
{
    partial class frmTKNhapHangTheoThang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_NhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DemoQuanLyBanHangDataSet = new D10cnpm_Bai2_DotNet.DemoQuanLyBanHangDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_NhapHangTableAdapter = new D10cnpm_Bai2_DotNet.DemoQuanLyBanHangDataSetTableAdapters.tb_NhapHangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyBanHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_NhapHangBindingSource
            // 
            this.tb_NhapHangBindingSource.DataMember = "tb_NhapHang";
            this.tb_NhapHangBindingSource.DataSource = this.DemoQuanLyBanHangDataSet;
            // 
            // DemoQuanLyBanHangDataSet
            // 
            this.DemoQuanLyBanHangDataSet.DataSetName = "DemoQuanLyBanHangDataSet";
            this.DemoQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_NhapHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "D10cnpm_Bai2_DotNet.BaoCaoNhapHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_NhapHangTableAdapter
            // 
            this.tb_NhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(640, 27);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(85, 27);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến ";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(369, 27);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 6;
            // 
            // frmTKNhapHangTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 440);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTKNhapHangTheoThang";
            this.Text = "frmTKNhapHangTheoThang";
            this.Load += new System.EventHandler(this.frmTKNhapHangTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_NhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyBanHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_NhapHangBindingSource;
        private DemoQuanLyBanHangDataSet DemoQuanLyBanHangDataSet;
        private DemoQuanLyBanHangDataSetTableAdapters.tb_NhapHangTableAdapter tb_NhapHangTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}