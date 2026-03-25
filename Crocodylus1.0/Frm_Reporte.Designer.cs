using GRTechnology1._0;
namespace GRTechnology1._0
{
    partial class Frm_Reporte
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
            this.Reporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.Dts = new GRTechnology1._0.DtsReportes();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Visor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Dts)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dts
            // 
            this.Dts.DataSetName = "DtsReportes";
            this.Dts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.btnBuscar);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(802, 100);
            this.panelFiltros.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(692, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Visor
            // 
            this.Visor.ActiveViewIndex = -1;
            this.Visor.AutoScroll = true;
            this.Visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Visor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Visor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visor.Location = new System.Drawing.Point(0, 100);
            this.Visor.Name = "Visor";
            this.Visor.SelectionFormula = "";
            this.Visor.ShowCloseButton = false;
            this.Visor.ShowGroupTreeButton = false;
            this.Visor.ShowLogo = false;
            this.Visor.Size = new System.Drawing.Size(802, 248);
            this.Visor.TabIndex = 4;
            this.Visor.ViewTimeSelectionFormula = "";
            // 
            // Frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 348);
            this.Controls.Add(this.Visor);
            this.Controls.Add(this.panelFiltros);
            this.Name = "Frm_Reporte";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Reporte_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dts)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal CrystalDecisions.CrystalReports.Engine.ReportDocument Reporte;
        public DtsReportes Dts;
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer Visor;
        public System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btnBuscar;
    }
}