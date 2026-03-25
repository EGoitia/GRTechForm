namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuCheque
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
            this.grbCheque = new System.Windows.Forms.GroupBox();
            this.txtFechaChequeEmi = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.txtFechaChequeCobro = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtBancoCheque = new System.Windows.Forms.TextBox();
            this.TxtCheque = new System.Windows.Forms.TextBox();
            this.grbCheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCheque
            // 
            this.grbCheque.BackColor = System.Drawing.Color.Transparent;
            this.grbCheque.Controls.Add(this.txtFechaChequeEmi);
            this.grbCheque.Controls.Add(this.Label13);
            this.grbCheque.Controls.Add(this.Label19);
            this.grbCheque.Controls.Add(this.txtFechaChequeCobro);
            this.grbCheque.Controls.Add(this.Label4);
            this.grbCheque.Controls.Add(this.Label8);
            this.grbCheque.Controls.Add(this.txtBancoCheque);
            this.grbCheque.Controls.Add(this.TxtCheque);
            this.grbCheque.Location = new System.Drawing.Point(3, 3);
            this.grbCheque.Name = "grbCheque";
            this.grbCheque.Size = new System.Drawing.Size(357, 99);
            this.grbCheque.TabIndex = 1522;
            this.grbCheque.TabStop = false;
            this.grbCheque.Text = "Cheque:";
            // 
            // txtFechaChequeEmi
            // 
            this.txtFechaChequeEmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFechaChequeEmi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaChequeEmi.Location = new System.Drawing.Point(235, 43);
            this.txtFechaChequeEmi.Name = "txtFechaChequeEmi";
            this.txtFechaChequeEmi.Size = new System.Drawing.Size(109, 20);
            this.txtFechaChequeEmi.TabIndex = 1503;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label13.Location = new System.Drawing.Point(161, 46);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 13);
            this.Label13.TabIndex = 970;
            this.Label13.Text = "Fec. Emisión:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label19.Location = new System.Drawing.Point(11, 73);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(71, 13);
            this.Label19.TabIndex = 970;
            this.Label19.Text = "Fecha Cobro:";
            // 
            // txtFechaChequeCobro
            // 
            this.txtFechaChequeCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFechaChequeCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaChequeCobro.Location = new System.Drawing.Point(85, 69);
            this.txtFechaChequeCobro.Name = "txtFechaChequeCobro";
            this.txtFechaChequeCobro.Size = new System.Drawing.Size(109, 20);
            this.txtFechaChequeCobro.TabIndex = 1503;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label4.Location = new System.Drawing.Point(11, 46);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 13);
            this.Label4.TabIndex = 969;
            this.Label4.Text = "Nº Cheque:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label8.Location = new System.Drawing.Point(11, 18);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(41, 13);
            this.Label8.TabIndex = 968;
            this.Label8.Text = "Banco:";
            // 
            // txtBancoCheque
            // 
            this.txtBancoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBancoCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBancoCheque.Location = new System.Drawing.Point(85, 16);
            this.txtBancoCheque.MaxLength = 100;
            this.txtBancoCheque.Name = "txtBancoCheque";
            this.txtBancoCheque.Size = new System.Drawing.Size(259, 20);
            this.txtBancoCheque.TabIndex = 0;
            // 
            // TxtCheque
            // 
            this.TxtCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtCheque.Location = new System.Drawing.Point(85, 42);
            this.TxtCheque.MaxLength = 50;
            this.TxtCheque.Name = "TxtCheque";
            this.TxtCheque.Size = new System.Drawing.Size(62, 20);
            this.TxtCheque.TabIndex = 957;
            // 
            // CntrUsuCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbCheque);
            this.Name = "CntrUsuCheque";
            this.Size = new System.Drawing.Size(368, 108);
            this.grbCheque.ResumeLayout(false);
            this.grbCheque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbCheque;
        internal System.Windows.Forms.DateTimePicker txtFechaChequeEmi;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.DateTimePicker txtFechaChequeCobro;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtBancoCheque;
        internal System.Windows.Forms.TextBox TxtCheque;
    }
}
