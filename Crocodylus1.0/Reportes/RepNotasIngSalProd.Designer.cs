namespace GRTechnology1._0.Reportes
{
    partial class RepNotasIngSalProd
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OIngSalProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODetalleIngSalProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OIngSalProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleIngSalProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OIngSalProductoBindingSource
            // 
            this.OIngSalProductoBindingSource.DataSource = typeof(Objetos.OIngSalProducto);
            // 
            // ODetalleIngSalProductoBindingSource
            // 
            this.ODetalleIngSalProductoBindingSource.DataSource = typeof(Objetos.ODetalleIngSalProducto);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OIngSalProductoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ODetalleIngSalProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GRTechnology1._0.Reportes.RepNotasIngSalProd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(718, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepNotasIngSalProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 445);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RepNotasIngSalProd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNotasIngSalProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OIngSalProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleIngSalProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OIngSalProductoBindingSource;
        private System.Windows.Forms.BindingSource ODetalleIngSalProductoBindingSource;
    }
}