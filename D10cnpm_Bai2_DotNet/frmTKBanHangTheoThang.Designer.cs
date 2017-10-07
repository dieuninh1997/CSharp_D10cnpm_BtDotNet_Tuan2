namespace D10cnpm_Bai2_DotNet
{
    partial class frmTKBanHangTheoThang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DemoQuanLyBanHangDataSet = new D10cnpm_Bai2_DotNet.DemoQuanLyBanHangDataSet();
            this.view_HienThiTatCaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_HienThiTatCaTableAdapter = new D10cnpm_Bai2_DotNet.DemoQuanLyBanHangDataSetTableAdapters.view_HienThiTatCaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyBanHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_HienThiTatCaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_HienThiTatCaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "D10cnpm_Bai2_DotNet.BaoCaoBanHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(904, 440);
            this.reportViewer1.TabIndex = 0;
            // 
            // DemoQuanLyBanHangDataSet
            // 
            this.DemoQuanLyBanHangDataSet.DataSetName = "DemoQuanLyBanHangDataSet";
            this.DemoQuanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_HienThiTatCaBindingSource
            // 
            this.view_HienThiTatCaBindingSource.DataMember = "view_HienThiTatCa";
            this.view_HienThiTatCaBindingSource.DataSource = this.DemoQuanLyBanHangDataSet;
            // 
            // view_HienThiTatCaTableAdapter
            // 
            this.view_HienThiTatCaTableAdapter.ClearBeforeFill = true;
            // 
            // frmTKBanHangTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmTKBanHangTheoThang";
            this.Text = "frmTKBanHangTheoThang";
            this.Load += new System.EventHandler(this.frmTKBanHangTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DemoQuanLyBanHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_HienThiTatCaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_HienThiTatCaBindingSource;
        private DemoQuanLyBanHangDataSet DemoQuanLyBanHangDataSet;
        private DemoQuanLyBanHangDataSetTableAdapters.view_HienThiTatCaTableAdapter view_HienThiTatCaTableAdapter;
    }
}