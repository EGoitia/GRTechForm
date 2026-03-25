namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuDeposito
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
            this.grbDeposito = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.DtFecCobroDep = new System.Windows.Forms.DateTimePicker();
            this.txtBancoDep = new System.Windows.Forms.TextBox();
            this.txtCuentaDep = new System.Windows.Forms.TextBox();
            this.grbDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDeposito
            // 
            this.grbDeposito.BackColor = System.Drawing.Color.Transparent;
            this.grbDeposito.Controls.Add(this.Label12);
            this.grbDeposito.Controls.Add(this.Label28);
            this.grbDeposito.Controls.Add(this.Label29);
            this.grbDeposito.Controls.Add(this.DtFecCobroDep);
            this.grbDeposito.Controls.Add(this.txtBancoDep);
            this.grbDeposito.Controls.Add(this.txtCuentaDep);
            this.grbDeposito.Location = new System.Drawing.Point(3, 3);
            this.grbDeposito.Name = "grbDeposito";
            this.grbDeposito.Size = new System.Drawing.Size(373, 80);
            this.grbDeposito.TabIndex = 1524;
            this.grbDeposito.TabStop = false;
            this.grbDeposito.Text = "Depósito:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label12.Location = new System.Drawing.Point(186, 49);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(71, 13);
            this.Label12.TabIndex = 970;
            this.Label12.Text = "Fecha Cobro:";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label28.Location = new System.Drawing.Point(14, 48);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(59, 13);
            this.Label28.TabIndex = 969;
            this.Label28.Text = "Nº Cuenta:";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label29.Location = new System.Drawing.Point(14, 21);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(41, 13);
            this.Label29.TabIndex = 968;
            this.Label29.Text = "Banco:";
            // 
            // DtFecCobroDep
            // 
            this.DtFecCobroDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DtFecCobroDep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecCobroDep.Location = new System.Drawing.Point(263, 44);
            this.DtFecCobroDep.Name = "DtFecCobroDep";
            this.DtFecCobroDep.Size = new System.Drawing.Size(98, 20);
            this.DtFecCobroDep.TabIndex = 967;
            // 
            // txtBancoDep
            // 
            this.txtBancoDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBancoDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBancoDep.Location = new System.Drawing.Point(76, 18);
            this.txtBancoDep.MaxLength = 100;
            this.txtBancoDep.Name = "txtBancoDep";
            this.txtBancoDep.Size = new System.Drawing.Size(285, 20);
            this.txtBancoDep.TabIndex = 0;
            // 
            // txtCuentaDep
            // 
            this.txtCuentaDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCuentaDep.Location = new System.Drawing.Point(76, 44);
            this.txtCuentaDep.MaxLength = 50;
            this.txtCuentaDep.Name = "txtCuentaDep";
            this.txtCuentaDep.Size = new System.Drawing.Size(94, 20);
            this.txtCuentaDep.TabIndex = 957;
            // 
            // CntrUsuDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbDeposito);
            this.Name = "CntrUsuDeposito";
            this.Size = new System.Drawing.Size(386, 89);
            this.grbDeposito.ResumeLayout(false);
            this.grbDeposito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbDeposito;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.DateTimePicker DtFecCobroDep;
        internal System.Windows.Forms.TextBox txtBancoDep;
        internal System.Windows.Forms.TextBox txtCuentaDep;
    }
}
