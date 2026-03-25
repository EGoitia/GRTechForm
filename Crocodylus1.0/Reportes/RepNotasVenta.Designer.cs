namespace GRTechnology1._0.Reportes
{
    partial class RepNotasVenta
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
            this.OVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsReportes1 = new GRTechnology1._0.DtsReportes();
            ((System.ComponentModel.ISupportInitialize)(this.OVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportes1)).BeginInit();
            this.SuspendLayout();
            // 
            // OVentaBindingSource
            // 
            this.OVentaBindingSource.DataSource = typeof(Objetos.OVenta);
            // 
            // ListaDetalleVentaBindingSource
            // 
            this.ListaDetalleVentaBindingSource.DataSource = typeof(Objetos.ODetalleVenta);
            // 
            // ODetalleVentaBindingSource
            // 
            this.ODetalleVentaBindingSource.DataSource = typeof(Objetos.ODetalleVenta);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OVentaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ListaDetalleVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GRTechnology1._0.Reportes.RepNotasVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(782, 260);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsReportes1
            // 
            this.dtsReportes1.DataSetName = "DtsReportes";
            this.dtsReportes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepNotasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 260);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RepNotasVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNotasVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsReportes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OVentaBindingSource;
        private System.Windows.Forms.BindingSource ListaDetalleVentaBindingSource;
        private System.Windows.Forms.BindingSource ODetalleVentaBindingSource;
        private GRTechnology1._0.DtsReportes dtsReportes1;
    }
}