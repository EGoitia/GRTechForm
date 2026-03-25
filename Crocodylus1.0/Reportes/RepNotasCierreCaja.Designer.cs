namespace GRTechnology1._0.Reportes
{
    partial class RepNotasCierreCaja
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
            this.OAperturaCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODetalleCierreCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OAperturaCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleCierreCajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OAperturaCajaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ODetalleCierreCajaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Crocodylus1._0.Reportes.RepNotasCierreCaja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // OAperturaCajaBindingSource
            // 
            this.OAperturaCajaBindingSource.DataSource = typeof(Objetos.OAperturaCaja);
            // 
            // ODetalleCierreCajaBindingSource
            // 
            this.ODetalleCierreCajaBindingSource.DataSource = typeof(Objetos.ODetalleCierreCaja);
            // 
            // RepNotasCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 391);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepNotasCierreCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNotasCierreCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OAperturaCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetalleCierreCajaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OAperturaCajaBindingSource;
        private System.Windows.Forms.BindingSource ODetalleCierreCajaBindingSource;
    }
}