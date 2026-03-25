namespace TransportNET
{
    partial class CntrUsuTarjeta
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
            this.grbTarjeta = new System.Windows.Forms.GroupBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.txtRefTar = new System.Windows.Forms.TextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.txtbancoTar = new System.Windows.Forms.TextBox();
            this.grbTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTarjeta
            // 
            this.grbTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.grbTarjeta.Controls.Add(this.Label36);
            this.grbTarjeta.Controls.Add(this.txtRefTar);
            this.grbTarjeta.Controls.Add(this.Label37);
            this.grbTarjeta.Controls.Add(this.txtbancoTar);
            this.grbTarjeta.Location = new System.Drawing.Point(4, 4);
            this.grbTarjeta.Name = "grbTarjeta";
            this.grbTarjeta.Size = new System.Drawing.Size(400, 88);
            this.grbTarjeta.TabIndex = 1524;
            this.grbTarjeta.TabStop = false;
            this.grbTarjeta.Text = "Tarjeta:";
            // 
            // Label36
            // 
            this.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label36.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.Location = new System.Drawing.Point(16, 51);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(97, 21);
            this.Label36.TabIndex = 970;
            this.Label36.Text = "Ref:";
            // 
            // txtRefTar
            // 
            this.txtRefTar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRefTar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefTar.Location = new System.Drawing.Point(119, 51);
            this.txtRefTar.MaxLength = 10;
            this.txtRefTar.Name = "txtRefTar";
            this.txtRefTar.Size = new System.Drawing.Size(268, 22);
            this.txtRefTar.TabIndex = 969;
            // 
            // Label37
            // 
            this.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label37.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label37.Location = new System.Drawing.Point(17, 22);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(97, 21);
            this.Label37.TabIndex = 968;
            this.Label37.Text = "Banco:";
            // 
            // txtbancoTar
            // 
            this.txtbancoTar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbancoTar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbancoTar.Location = new System.Drawing.Point(119, 20);
            this.txtbancoTar.MaxLength = 100;
            this.txtbancoTar.Name = "txtbancoTar";
            this.txtbancoTar.Size = new System.Drawing.Size(268, 22);
            this.txtbancoTar.TabIndex = 0;
            // 
            // CntrUsuTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbTarjeta);
            this.Name = "CntrUsuTarjeta";
            this.Size = new System.Drawing.Size(409, 100);
            this.grbTarjeta.ResumeLayout(false);
            this.grbTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbTarjeta;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.TextBox txtRefTar;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.TextBox txtbancoTar;
    }
}
