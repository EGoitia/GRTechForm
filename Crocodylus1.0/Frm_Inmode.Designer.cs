namespace GRTechnology1._0
{
    partial class Frm_Inmode
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
            this.dgvInmode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInmode
            // 
            this.dgvInmode.AllowUserToAddRows = false;
            this.dgvInmode.AllowUserToDeleteRows = false;
            this.dgvInmode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInmode.Location = new System.Drawing.Point(0, 0);
            this.dgvInmode.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInmode.MultiSelect = false;
            this.dgvInmode.Name = "dgvInmode";
            this.dgvInmode.ReadOnly = true;
            this.dgvInmode.RowTemplate.Height = 24;
            this.dgvInmode.Size = new System.Drawing.Size(934, 250);
            this.dgvInmode.TabIndex = 0;
            // 
            // Frm_Inmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 250);
            this.Controls.Add(this.dgvInmode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Inmode";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Inmode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInmode;


    }
}