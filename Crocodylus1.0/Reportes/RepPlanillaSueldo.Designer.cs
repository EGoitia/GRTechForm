namespace GRTechnology1._0.Reportes
{
    partial class RepPlanillaSueldo
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
            this.OPlanillaSueldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ODetallePlanillaSueldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OPlanillaSueldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetallePlanillaSueldoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OPlanillaSueldoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ODetallePlanillaSueldoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Crocodylus1._0.Reportes.RepPlanillaSueldo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(941, 542);
            this.reportViewer1.TabIndex = 0;
            // 
            // OPlanillaSueldoBindingSource
            // 
            this.OPlanillaSueldoBindingSource.DataSource = typeof(Objetos.OPlanillaSueldo);
            // 
            // ODetallePlanillaSueldoBindingSource
            // 
            this.ODetallePlanillaSueldoBindingSource.DataSource = typeof(Objetos.ODetallePlanillaSueldo);
            // 
            // RepPlanillaSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 542);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepPlanillaSueldo";
            this.ShowIcon = false;
            this.Text = "Planilla de Sueldo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepPlanillaSueldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OPlanillaSueldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ODetallePlanillaSueldoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OPlanillaSueldoBindingSource;
        private System.Windows.Forms.BindingSource ODetallePlanillaSueldoBindingSource;
    }
}