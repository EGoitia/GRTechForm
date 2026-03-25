namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuTarjetas
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
            this.grbTarjeta.Location = new System.Drawing.Point(3, 3);
            this.grbTarjeta.Name = "grbTarjeta";
            this.grbTarjeta.Size = new System.Drawing.Size(346, 70);
            this.grbTarjeta.TabIndex = 1525;
            this.grbTarjeta.TabStop = false;
            this.grbTarjeta.Text = "Tarjeta:";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label36.Location = new System.Drawing.Point(17, 44);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(27, 13);
            this.Label36.TabIndex = 970;
            this.Label36.Text = "Ref:";
            // 
            // txtRefTar
            // 
            this.txtRefTar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRefTar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRefTar.Location = new System.Drawing.Point(64, 41);
            this.txtRefTar.MaxLength = 10;
            this.txtRefTar.Name = "txtRefTar";
            this.txtRefTar.Size = new System.Drawing.Size(268, 20);
            this.txtRefTar.TabIndex = 969;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label37.Location = new System.Drawing.Point(17, 19);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(41, 13);
            this.Label37.TabIndex = 968;
            this.Label37.Text = "Banco:";
            // 
            // txtbancoTar
            // 
            this.txtbancoTar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbancoTar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtbancoTar.Location = new System.Drawing.Point(64, 15);
            this.txtbancoTar.MaxLength = 100;
            this.txtbancoTar.Name = "txtbancoTar";
            this.txtbancoTar.Size = new System.Drawing.Size(268, 20);
            this.txtbancoTar.TabIndex = 0;
            // 
            // CntrUsuTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbTarjeta);
            this.Name = "CntrUsuTarjetas";
            this.Size = new System.Drawing.Size(357, 79);
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
