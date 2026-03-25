namespace GRTechnology1._0
{
    partial class Frm_DetaModifAnul
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
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtDetAnul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(165, 76);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(103, 23);
            this.btnAnular.TabIndex = 1;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtDetAnul
            // 
            this.txtDetAnul.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetAnul.Location = new System.Drawing.Point(59, 12);
            this.txtDetAnul.MaxLength = 200;
            this.txtDetAnul.Multiline = true;
            this.txtDetAnul.Name = "txtDetAnul";
            this.txtDetAnul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetAnul.Size = new System.Drawing.Size(313, 60);
            this.txtDetAnul.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalle........";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 76);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_DetaModifAnul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 110);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtDetAnul);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(395, 149);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 149);
            this.Name = "Frm_DetaModifAnul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anular";
            this.Load += new System.EventHandler(this.DetaModifAnul_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DetaModifAnul_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DetaModifAnul_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.TextBox txtDetAnul;
    }
}