namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuRecibo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxRecibo = new System.Windows.Forms.GroupBox();
            this.cboTipoReten = new System.Windows.Forms.ComboBox();
            this.chkRetencion = new System.Windows.Forms.CheckBox();
            this.txtMontoRecib = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFechaRecib = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroRecib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRecibo
            // 
            this.gbxRecibo.Controls.Add(this.cboTipoReten);
            this.gbxRecibo.Controls.Add(this.chkRetencion);
            this.gbxRecibo.Controls.Add(this.txtMontoRecib);
            this.gbxRecibo.Controls.Add(this.label8);
            this.gbxRecibo.Controls.Add(this.dtFechaRecib);
            this.gbxRecibo.Controls.Add(this.label6);
            this.gbxRecibo.Controls.Add(this.txtNroRecib);
            this.gbxRecibo.Controls.Add(this.label1);
            this.gbxRecibo.Location = new System.Drawing.Point(8, 6);
            this.gbxRecibo.Name = "gbxRecibo";
            this.gbxRecibo.Size = new System.Drawing.Size(330, 115);
            this.gbxRecibo.TabIndex = 0;
            this.gbxRecibo.TabStop = false;
            // 
            // cboTipoReten
            // 
            this.cboTipoReten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReten.Enabled = false;
            this.cboTipoReten.FormattingEnabled = true;
            this.cboTipoReten.Location = new System.Drawing.Point(87, 51);
            this.cboTipoReten.Name = "cboTipoReten";
            this.cboTipoReten.Size = new System.Drawing.Size(228, 21);
            this.cboTipoReten.TabIndex = 17;
            // 
            // chkRetencion
            // 
            this.chkRetencion.AutoSize = true;
            this.chkRetencion.Location = new System.Drawing.Point(11, 55);
            this.chkRetencion.Name = "chkRetencion";
            this.chkRetencion.Size = new System.Drawing.Size(78, 17);
            this.chkRetencion.TabIndex = 16;
            this.chkRetencion.Text = "Retención:";
            this.chkRetencion.UseVisualStyleBackColor = true;
            this.chkRetencion.CheckedChanged += new System.EventHandler(this.chkRetencion_CheckedChanged);
            // 
            // txtMontoRecib
            // 
            this.txtMontoRecib.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoRecib.Location = new System.Drawing.Point(87, 83);
            this.txtMontoRecib.MaxLength = 10;
            this.txtMontoRecib.Name = "txtMontoRecib";
            this.txtMontoRecib.Size = new System.Drawing.Size(91, 20);
            this.txtMontoRecib.TabIndex = 15;
            this.txtMontoRecib.Text = "0.00";
            this.txtMontoRecib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Monto:";
            // 
            // dtFechaRecib
            // 
            this.dtFechaRecib.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaRecib.Location = new System.Drawing.Point(218, 19);
            this.dtFechaRecib.Name = "dtFechaRecib";
            this.dtFechaRecib.Size = new System.Drawing.Size(97, 20);
            this.dtFechaRecib.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha:";
            // 
            // txtNroRecib
            // 
            this.txtNroRecib.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroRecib.Location = new System.Drawing.Point(87, 19);
            this.txtNroRecib.MaxLength = 10;
            this.txtNroRecib.Name = "txtNroRecib";
            this.txtNroRecib.Size = new System.Drawing.Size(71, 20);
            this.txtNroRecib.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Recibo:";
            // 
            // CntrUsuRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxRecibo);
            this.Name = "CntrUsuRecibo";
            this.Size = new System.Drawing.Size(348, 128);
            this.Load += new System.EventHandler(this.CntrUsuRecibo_Load);
            this.gbxRecibo.ResumeLayout(false);
            this.gbxRecibo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRecibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtMontoRecib;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNroRecib;
        public System.Windows.Forms.DateTimePicker dtFechaRecib;
        public System.Windows.Forms.CheckBox chkRetencion;
        public System.Windows.Forms.ComboBox cboTipoReten;
    }
}
