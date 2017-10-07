namespace D10cnpm_Bai2_DotNet
{
    partial class frmTKTonKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DemoQuanLyBanHangDataSet = new D10cnpm_Bai2_DotNet.DemoQuanLyBanHangDataSet();
            this.tb_SanPhamTableAdapter = new D10cnpm_Bai2_DotNet.DemoQuanLyBanHangDataSetTableAdapters.tb_SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyBanHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tb_SanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "D10cnpm_Bai2_DotNet.BaoCaoTonKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_SanPhamBindingSource
            // 
            this.tb_SanPhamBindingSource.DataMember = "tb_SanPham";
            this.tb_SanPhamBindingSource.DataSource = this.DemoQuanLyBanHangDataSet;
            // 
            // DemoQuanLyBanHangDataSet
            // 
            this.DemoQuanLyBanHangDataSet.DataSetName = "DemoQuanLyBanHangDataSet";
            this.DemoQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_SanPhamTableAdapter
            // 
            this.tb_SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // frmTKTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTKTonKho";
            this.Text = "frmTKTonKho";
            this.Load += new System.EventHandler(this.frmTKTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyBanHangDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_SanPhamBindingSource;
        private DemoQuanLyBanHangDataSet DemoQuanLyBanHangDataSet;
        private DemoQuanLyBanHangDataSetTableAdapters.tb_SanPhamTableAdapter tb_SanPhamTableAdapter;
    }
}