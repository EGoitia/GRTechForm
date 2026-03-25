namespace TransportNET
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
            this.grbCheque.Location = new System.Drawing.Point(3, 2);
            this.grbCheque.Name = "grbCheque";
            this.grbCheque.Size = new System.Drawing.Size(398, 109);
            this.grbCheque.TabIndex = 1521;
            this.grbCheque.TabStop = false;
            this.grbCheque.Text = "Cheque:";
            // 
            // txtFechaChequeEmi
            // 
            this.txtFechaChequeEmi.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtFechaChequeEmi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaChequeEmi.Location = new System.Drawing.Point(272, 46);
            this.txtFechaChequeEmi.Name = "txtFechaChequeEmi";
            this.txtFechaChequeEmi.Size = new System.Drawing.Size(109, 22);
            this.txtFechaChequeEmi.TabIndex = 1503;
            // 
            // Label13
            // 
            this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(180, 47);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(97, 21);
            this.Label13.TabIndex = 970;
            this.Label13.Text = "Fec. Emisión:";
            // 
            // Label19
            // 
            this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(11, 75);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(97, 21);
            this.Label19.TabIndex = 970;
            this.Label19.Text = "Fecha Cobro:";
            // 
            // txtFechaChequeCobro
            // 
            this.txtFechaChequeCobro.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtFechaChequeCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaChequeCobro.Location = new System.Drawing.Point(113, 73);
            this.txtFechaChequeCobro.Name = "txtFechaChequeCobro";
            this.txtFechaChequeCobro.Size = new System.Drawing.Size(109, 22);
            this.txtFechaChequeCobro.TabIndex = 1503;
            // 
            // Label4
            // 
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(11, 45);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 21);
            this.Label4.TabIndex = 969;
            this.Label4.Text = "Nº Cheque:";
            // 
            // Label8
            // 
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(11, 18);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(97, 21);
            this.Label8.TabIndex = 968;
            this.Label8.Text = "Banco:";
            // 
            // txtBancoCheque
            // 
            this.txtBancoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBancoCheque.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancoCheque.Location = new System.Drawing.Point(113, 16);
            this.txtBancoCheque.MaxLength = 100;
            this.txtBancoCheque.Name = "txtBancoCheque";
            this.txtBancoCheque.Size = new System.Drawing.Size(268, 22);
            this.txtBancoCheque.TabIndex = 0;
            // 
            // TxtCheque
            // 
            this.TxtCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCheque.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtCheque.Location = new System.Drawing.Point(112, 45);
            this.TxtCheque.MaxLength = 50;
            this.TxtCheque.Name = "TxtCheque";
            this.TxtCheque.Size = new System.Drawing.Size(62, 22);
            this.TxtCheque.TabIndex = 957;
            // 
            // CntrUsuCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbCheque);
            this.Name = "CntrUsuCheque";
            this.Size = new System.Drawing.Size(409, 119);
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
