namespace GRTechnology1._0.ControlUsuario
{
    partial class CntrUsuBtnProducto
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
            this.lblNomProd = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomProd
            // 
            this.lblNomProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomProd.Location = new System.Drawing.Point(3, 114);
            this.lblNomProd.Name = "lblNomProd";
            this.lblNomProd.Size = new System.Drawing.Size(161, 24);
            this.lblNomProd.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesc.Location = new System.Drawing.Point(3, 138);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(161, 24);
            this.lblDesc.TabIndex = 3;
            // 
            // pbxImg
            // 
            this.pbxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImg.Location = new System.Drawing.Point(3, 4);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(161, 110);
            this.pbxImg.TabIndex = 2;
            this.pbxImg.TabStop = false;
            // 
            // CntrUsuBtnProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNomProd);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pbxImg);
            this.Name = "CntrUsuBtnProducto";
            this.Size = new System.Drawing.Size(167, 166);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNomProd;
        public System.Windows.Forms.Label lblDesc;
        public System.Windows.Forms.PictureBox pbxImg;
    }
}
