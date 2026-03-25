namespace GRTechnology1._0
{
    partial class Frm_Detalle_Pagos
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
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gbxTotales
            // 
            this.gbxTotales.Location = new System.Drawing.Point(9, 6);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(696, 100);
            this.gbxTotales.TabIndex = 0;
            this.gbxTotales.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 251);
            this.panel1.TabIndex = 1;
            // 
            // Frm_Detalle_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxTotales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Detalle_Pagos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Pagos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.Panel panel1;
    }
}