namespace GRTechnology1._0
{
    partial class Frm_Detalle_Cierre
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.chkCajero = new System.Windows.Forms.CheckBox();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.dtFechaFin);
            this.gbxFiltro.Controls.Add(this.dtFechaIni);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.chkCajero);
            this.gbxFiltro.Controls.Add(this.cmbCajero);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cmbCajero, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkCajero, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaFin, 0);
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(294, 53);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(98, 20);
            this.dtFechaFin.TabIndex = 17;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(114, 53);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(98, 20);
            this.dtFechaIni.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Al:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Cierre de:";
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(429, 25);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 14;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // chkCajero
            // 
            this.chkCajero.AutoSize = true;
            this.chkCajero.Location = new System.Drawing.Point(28, 25);
            this.chkCajero.Name = "chkCajero";
            this.chkCajero.Size = new System.Drawing.Size(56, 17);
            this.chkCajero.TabIndex = 13;
            this.chkCajero.Text = "Cajero";
            this.chkCajero.UseVisualStyleBackColor = true;
            this.chkCajero.CheckedChanged += new System.EventHandler(this.chkCajero_CheckedChanged);
            // 
            // cmbCajero
            // 
            this.cmbCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCajero.Enabled = false;
            this.cmbCajero.FormattingEnabled = true;
            this.cmbCajero.Location = new System.Drawing.Point(97, 22);
            this.cmbCajero.Name = "cmbCajero";
            this.cmbCajero.Size = new System.Drawing.Size(295, 21);
            this.cmbCajero.TabIndex = 12;
            // 
            // Frm_Detalle_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 402);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Cierre";
            this.Text = "Detalles de Cierres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Cierre_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Cierre_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.CheckBox chkCajero;
        private System.Windows.Forms.ComboBox cmbCajero;
    }
}
