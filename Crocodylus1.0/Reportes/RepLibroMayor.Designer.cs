namespace GRTechnology1._0.Reportes
{
    partial class RepLibroMayor
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
            this.OLibroMayorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRep = new System.Windows.Forms.Panel();
            this.reportViewerLibroDiarioDet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerLibMayor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.cboTipoRep = new System.Windows.Forms.ComboBox();
            this.cboTipoLibro = new System.Windows.Forms.ComboBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OLibroMayorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRep.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OLibroMayorBindingSource
            // 
            this.OLibroMayorBindingSource.DataSource = typeof(Objetos.OLibroMayor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelRep);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 421);
            this.panel1.TabIndex = 0;
            // 
            // panelRep
            // 
            this.panelRep.Controls.Add(this.reportViewerLibroDiarioDet);
            this.panelRep.Controls.Add(this.reportViewerLibMayor);
            this.panelRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRep.Location = new System.Drawing.Point(0, 49);
            this.panelRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRep.Name = "panelRep";
            this.panelRep.Size = new System.Drawing.Size(906, 372);
            this.panelRep.TabIndex = 1;
            // 
            // reportViewerLibroDiarioDet
            // 
            this.reportViewerLibroDiarioDet.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSLibroDiario";
            reportDataSource1.Value = this.OLibroMayorBindingSource;
            this.reportViewerLibroDiarioDet.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerLibroDiarioDet.LocalReport.ReportEmbeddedResource = "GRTechnology1._0.Reportes.RepLibroMayorDet.rdlc";
            this.reportViewerLibroDiarioDet.Location = new System.Drawing.Point(0, 0);
            this.reportViewerLibroDiarioDet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewerLibroDiarioDet.Name = "reportViewerLibroDiarioDet";
            this.reportViewerLibroDiarioDet.Size = new System.Drawing.Size(906, 372);
            this.reportViewerLibroDiarioDet.TabIndex = 1;
            // 
            // reportViewerLibMayor
            // 
            this.reportViewerLibMayor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSLibroMayor";
            reportDataSource2.Value = this.OLibroMayorBindingSource;
            this.reportViewerLibMayor.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerLibMayor.LocalReport.ReportEmbeddedResource = "GRTechnology1._0.Reportes.RepLibroMayor.rdlc";
            this.reportViewerLibMayor.Location = new System.Drawing.Point(0, 0);
            this.reportViewerLibMayor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewerLibMayor.Name = "reportViewerLibMayor";
            this.reportViewerLibMayor.Size = new System.Drawing.Size(906, 372);
            this.reportViewerLibMayor.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.cboTipoRep);
            this.panelMenu.Controls.Add(this.cboTipoLibro);
            this.panelMenu.Controls.Add(this.btnProc);
            this.panelMenu.Controls.Add(this.dtFecFin);
            this.panelMenu.Controls.Add(this.dtFecIni);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(906, 49);
            this.panelMenu.TabIndex = 0;
            // 
            // cboTipoRep
            // 
            this.cboTipoRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoRep.FormattingEnabled = true;
            this.cboTipoRep.Items.AddRange(new object[] {
            "Detallado",
            "Resumido"});
            this.cboTipoRep.Location = new System.Drawing.Point(699, 16);
            this.cboTipoRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoRep.Name = "cboTipoRep";
            this.cboTipoRep.Size = new System.Drawing.Size(92, 21);
            this.cboTipoRep.TabIndex = 3;
            // 
            // cboTipoLibro
            // 
            this.cboTipoLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoLibro.FormattingEnabled = true;
            this.cboTipoLibro.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.cboTipoLibro.Location = new System.Drawing.Point(590, 16);
            this.cboTipoLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoLibro.Name = "cboTipoLibro";
            this.cboTipoLibro.Size = new System.Drawing.Size(92, 21);
            this.cboTipoLibro.TabIndex = 3;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(804, 17);
            this.btnProc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(93, 19);
            this.btnProc.TabIndex = 2;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // dtFecFin
            // 
            this.dtFecFin.Location = new System.Drawing.Point(382, 17);
            this.dtFecFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(204, 20);
            this.dtFecFin.TabIndex = 1;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Location = new System.Drawing.Point(89, 17);
            this.dtFecIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(204, 20);
            this.dtFecIni.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial:";
            // 
            // RepLibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 421);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RepLibroMayor";
            this.ShowIcon = false;
            this.Text = "Reporte Libro Mayor Detallado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepLibroMayorDetallado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OLibroMayorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelRep.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRep;
        private System.Windows.Forms.Panel panelMenu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLibMayor;
        private System.Windows.Forms.BindingSource OLibroMayorBindingSource;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoLibro;
        private System.Windows.Forms.ComboBox cboTipoRep;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLibroDiarioDet;
    }
}