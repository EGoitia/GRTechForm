namespace GRTechnology1._0.Reportes
{
    partial class RepNotasProyeccion
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
            this.OProyeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaDetalleProyeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OProyeccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleProyeccionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OProyeccionesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ListaDetalleProyeccionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Crocodylus1._0.Reportes.RepNotasProyeccion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(965, 518);
            this.reportViewer1.TabIndex = 2;
            // 
            // OProyeccionesBindingSource
            // 
            this.OProyeccionesBindingSource.DataSource = typeof(Objetos.OProyecciones);
            // 
            // ListaDetalleProyeccionesBindingSource
            // 
            this.ListaDetalleProyeccionesBindingSource.DataSource = typeof(Objetos.ODetalleProyecciones);
            // 
            // RepNotasProyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 518);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepNotasProyeccion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepNotasProyeccion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNotasProyeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OProyeccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleProyeccionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OProyeccionesBindingSource;
        private System.Windows.Forms.BindingSource ListaDetalleProyeccionesBindingSource;
    }
}