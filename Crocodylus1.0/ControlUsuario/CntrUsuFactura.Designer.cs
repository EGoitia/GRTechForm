namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuFactura
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
            this.GrbFacturaG = new System.Windows.Forms.GroupBox();
            this.txtMontoFact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFechaFact = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExcentos = new System.Windows.Forms.TextBox();
            this.txtICE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroFact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAutorizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrbFacturaG.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbFacturaG
            // 
            this.GrbFacturaG.Controls.Add(this.txtMontoFact);
            this.GrbFacturaG.Controls.Add(this.label8);
            this.GrbFacturaG.Controls.Add(this.dtFechaFact);
            this.GrbFacturaG.Controls.Add(this.label6);
            this.GrbFacturaG.Controls.Add(this.txtExcentos);
            this.GrbFacturaG.Controls.Add(this.txtICE);
            this.GrbFacturaG.Controls.Add(this.label5);
            this.GrbFacturaG.Controls.Add(this.label4);
            this.GrbFacturaG.Controls.Add(this.txtCodControl);
            this.GrbFacturaG.Controls.Add(this.label3);
            this.GrbFacturaG.Controls.Add(this.txtRazonSocial);
            this.GrbFacturaG.Controls.Add(this.label2);
            this.GrbFacturaG.Controls.Add(this.txtNroFact);
            this.GrbFacturaG.Controls.Add(this.label9);
            this.GrbFacturaG.Controls.Add(this.txtAutorizacion);
            this.GrbFacturaG.Controls.Add(this.label1);
            this.GrbFacturaG.Controls.Add(this.txtNIT);
            this.GrbFacturaG.Controls.Add(this.label7);
            this.GrbFacturaG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbFacturaG.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbFacturaG.Location = new System.Drawing.Point(0, 0);
            this.GrbFacturaG.Name = "GrbFacturaG";
            this.GrbFacturaG.Size = new System.Drawing.Size(451, 140);
            this.GrbFacturaG.TabIndex = 0;
            this.GrbFacturaG.TabStop = false;
            // 
            // txtMontoFact
            // 
            this.txtMontoFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoFact.Location = new System.Drawing.Point(86, 99);
            this.txtMontoFact.MaxLength = 10;
            this.txtMontoFact.Name = "txtMontoFact";
            this.txtMontoFact.Size = new System.Drawing.Size(91, 21);
            this.txtMontoFact.TabIndex = 11;
            this.txtMontoFact.Text = "0.00";
            this.txtMontoFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Monto:";
            // 
            // dtFechaFact
            // 
            this.dtFechaFact.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFact.Location = new System.Drawing.Point(207, 16);
            this.dtFechaFact.Name = "dtFechaFact";
            this.dtFechaFact.Size = new System.Drawing.Size(97, 21);
            this.dtFechaFact.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha:";
            // 
            // txtExcentos
            // 
            this.txtExcentos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExcentos.Location = new System.Drawing.Point(360, 99);
            this.txtExcentos.MaxLength = 10;
            this.txtExcentos.Name = "txtExcentos";
            this.txtExcentos.Size = new System.Drawing.Size(64, 21);
            this.txtExcentos.TabIndex = 15;
            this.txtExcentos.Text = "0.00";
            this.txtExcentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExcentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // txtICE
            // 
            this.txtICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtICE.Location = new System.Drawing.Point(226, 99);
            this.txtICE.MaxLength = 10;
            this.txtICE.Name = "txtICE";
            this.txtICE.Size = new System.Drawing.Size(64, 21);
            this.txtICE.TabIndex = 13;
            this.txtICE.Text = "0.00";
            this.txtICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Exentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ICE:";
            // 
            // txtCodControl
            // 
            this.txtCodControl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodControl.Location = new System.Drawing.Point(307, 43);
            this.txtCodControl.MaxLength = 50;
            this.txtCodControl.Name = "txtCodControl";
            this.txtCodControl.Size = new System.Drawing.Size(117, 21);
            this.txtCodControl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cod. Control:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazonSocial.Location = new System.Drawing.Point(86, 70);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(338, 21);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razón Social:";
            // 
            // txtNroFact
            // 
            this.txtNroFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroFact.Location = new System.Drawing.Point(86, 16);
            this.txtNroFact.MaxLength = 10;
            this.txtNroFact.Name = "txtNroFact";
            this.txtNroFact.Size = new System.Drawing.Size(60, 21);
            this.txtNroFact.TabIndex = 1;
            this.txtNroFact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nº Factura:";
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutorizacion.Location = new System.Drawing.Point(86, 43);
            this.txtAutorizacion.MaxLength = 50;
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(139, 21);
            this.txtAutorizacion.TabIndex = 1;
            this.txtAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorización:";
            // 
            // txtNIT
            // 
            this.txtNIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNIT.Location = new System.Drawing.Point(350, 16);
            this.txtNIT.MaxLength = 20;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(74, 21);
            this.txtNIT.TabIndex = 3;
            this.txtNIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntero_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "NIT:";
            // 
            // CntrUsuFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrbFacturaG);
            this.Name = "CntrUsuFactura";
            this.Size = new System.Drawing.Size(451, 140);
            this.GrbFacturaG.ResumeLayout(false);
            this.GrbFacturaG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GrbFacturaG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtMontoFact;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtRazonSocial;
        public System.Windows.Forms.TextBox txtAutorizacion;
        public System.Windows.Forms.TextBox txtNIT;
        public System.Windows.Forms.TextBox txtCodControl;
        public System.Windows.Forms.TextBox txtExcentos;
        public System.Windows.Forms.TextBox txtICE;
        public System.Windows.Forms.DateTimePicker dtFechaFact;
        public System.Windows.Forms.TextBox txtNroFact;
    }
}
