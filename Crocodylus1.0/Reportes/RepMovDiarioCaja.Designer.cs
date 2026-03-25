namespace GRTechnology1._0.Reportes
{
    partial class RepMovDiarioCaja
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OVentasPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OAbonoPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OReciboIngEgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OGastoPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OCompraPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OAperturaCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODepositoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oTraspasoCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oVentasPorFechaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OVentasPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAbonoPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OReciboIngEgrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OGastoPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OCompraPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAperturaCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODepositoBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTraspasoCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oVentasPorFechaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // OVentasPorFechaBindingSource
            // 
            this.OVentasPorFechaBindingSource.DataSource = typeof(Objetos.OVentasPorFecha);
            // 
            // OReciboIngEgrBindingSource
            // 
            this.OReciboIngEgrBindingSource.DataSource = typeof(Objetos.OIngresoEgreso);
            // 
            // OGastoPersonalBindingSource
            // 
            this.OGastoPersonalBindingSource.DataSource = typeof(Objetos.OGastoPersonal);
            // 
            // OCompraPorFechaBindingSource
            // 
            this.OCompraPorFechaBindingSource.DataSource = typeof(Objetos.OCompraPorFecha);
            // 
            // OAperturaCajaBindingSource
            // 
            this.OAperturaCajaBindingSource.DataSource = typeof(Objetos.OAperturaCaja);
            // 
            // ODepositoBancoBindingSource
            // 
            this.ODepositoBancoBindingSource.DataSource = typeof(Objetos.ODepositoBanco);
            // 
            // oTraspasoCajaBindingSource
            // 
            this.oTraspasoCajaBindingSource.DataSource = typeof(Objetos.OTraspasoCaja);
            // 
            // oVentasPorFechaBindingSource1
            // 
            this.oVentasPorFechaBindingSource1.DataSource = typeof(Objetos.OVentasPorFecha);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSVentasContado";
            reportDataSource1.Value = this.OVentasPorFechaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.OAbonoPorFechaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.OReciboIngEgrBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.OGastoPersonalBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.OCompraPorFechaBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.OAperturaCajaBindingSource;
            reportDataSource7.Name = "DataSet7";
            reportDataSource7.Value = this.ODepositoBancoBindingSource;
            reportDataSource8.Name = "DSVentaAnticip";
            reportDataSource8.Value = this.OVentasPorFechaBindingSource;
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.oTraspasoCajaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GRTechnology1._0.Reportes.RepMovDiarioCaja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepMovDiarioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 418);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RepMovDiarioCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento diario de Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepMovDiarioCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OVentasPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAbonoPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OReciboIngEgrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OGastoPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OCompraPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OAperturaCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODepositoBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTraspasoCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oVentasPorFechaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OReciboIngEgrBindingSource;
        private System.Windows.Forms.BindingSource OGastoPersonalBindingSource;
        private System.Windows.Forms.BindingSource OAperturaCajaBindingSource;
        private System.Windows.Forms.BindingSource OVentasPorFechaBindingSource;
        private System.Windows.Forms.BindingSource OAbonoPorFechaBindingSource;
        private System.Windows.Forms.BindingSource OCompraPorFechaBindingSource;
        private System.Windows.Forms.BindingSource ODepositoBancoBindingSource;
        private System.Windows.Forms.BindingSource oVentasPorFechaBindingSource1;
        private System.Windows.Forms.BindingSource oTraspasoCajaBindingSource;
    }
}