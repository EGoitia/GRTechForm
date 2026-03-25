namespace GRTechnology1._0.Reportes
{
    partial class RepNotasConformidad
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
            this.ListaConformidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaDetalleConformidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConformidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleConformidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaConformidadBindingSource
            // 
            this.ListaConformidadBindingSource.DataSource = typeof(Objetos.OConformidad);
            // 
            // ListaDetalleConformidadBindingSource
            // 
            this.ListaDetalleConformidadBindingSource.DataSource = typeof(Objetos.ODetalleConformidad);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListaConformidadBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ListaDetalleConformidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Crocodylus1._0.Reportes.RepNotasConformidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(713, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepNotasConformidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 553);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RepNotasConformidad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas de Conformidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNotasConformidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaConformidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDetalleConformidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListaConformidadBindingSource;
        private System.Windows.Forms.BindingSource ListaDetalleConformidadBindingSource;
    }
}