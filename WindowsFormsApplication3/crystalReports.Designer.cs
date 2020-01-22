namespace WindowsFormsApplication3
{
    partial class crystalReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product = new WindowsFormsApplication3.product();
            this.sateReport = new WindowsFormsApplication3.sateReport();
            this.SALEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SALETableAdapter = new WindowsFormsApplication3.sateReportTableAdapters.SALETableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PRODUCTTableAdapter = new WindowsFormsApplication3.productTableAdapters.PRODUCTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PRODUCTBindingSource
            // 
            this.PRODUCTBindingSource.DataMember = "PRODUCT";
            this.PRODUCTBindingSource.DataSource = this.product;
            // 
            // product
            // 
            this.product.DataSetName = "product";
            this.product.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sateReport
            // 
            this.sateReport.DataSetName = "sateReport";
            this.sateReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SALEBindingSource
            // 
            this.SALEBindingSource.DataMember = "SALE";
            this.SALEBindingSource.DataSource = this.sateReport;
            // 
            // SALETableAdapter
            // 
            this.SALETableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "saleReport";
            reportDataSource1.Value = this.SALEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(797, 506);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // PRODUCTTableAdapter
            // 
            this.PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "crystalReports";
            this.Size = new System.Drawing.Size(797, 506);
            this.Load += new System.EventHandler(this.crystalReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sateReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SALEBindingSource;
        private sateReport sateReport;
        private sateReportTableAdapters.SALETableAdapter SALETableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PRODUCTBindingSource;
        private product product;
        private productTableAdapters.PRODUCTTableAdapter PRODUCTTableAdapter;
    }
}
