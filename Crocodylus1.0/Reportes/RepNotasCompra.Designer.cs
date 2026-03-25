namespace GRTechnology1._0.Reportes
{
    partial class RepNotasCompra
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OCompraProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODetalleCompraProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OCompraProdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleCompraProdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OCompraProdBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ODetalleCompraProdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Crocodylus1._0.Reportes.RepNotasCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(883, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // OCompraProdBindingSource
            // 
            this.OCompraProdBindingSource.DataSource = typeof(Objetos.OCompraProd);
            // 
            // ODetalleCompraProdBindingSource
            // 
            this.ODetalleCompraProdBindingSource.DataSource = typeof(Objetos.ODetalleCompraProd);
            // 
            // RepNotasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 491);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepNotasCompra";
            this.ShowIcon = false;
            this.Text = "Compra de Mercaderia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNotasCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OCompraProdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleCompraProdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OCompraProdBindingSource;
        private System.Windows.Forms.BindingSource ODetalleCompraProdBindingSource;
    }
}