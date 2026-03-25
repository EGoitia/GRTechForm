namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepNotasVentasXCantidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSuc = new System.Windows.Forms.ComboBox();
            this.dtDel = new System.Windows.Forms.DateTimePicker();
            this.dtAl = new System.Windows.Forms.DateTimePicker();
            this.btnProc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal.......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Del.............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Al.................";
            // 
            // cboSuc
            // 
            this.cboSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSuc.FormattingEnabled = true;
            this.cboSuc.Location = new System.Drawing.Point(116, 20);
            this.cboSuc.Name = "cboSuc";
            this.cboSuc.Size = new System.Drawing.Size(269, 24);
            this.cboSuc.TabIndex = 3;
            // 
            // dtDel
            // 
            this.dtDel.Location = new System.Drawing.Point(116, 52);
            this.dtDel.Name = "dtDel";
            this.dtDel.Size = new System.Drawing.Size(269, 22);
            this.dtDel.TabIndex = 4;
            // 
            // dtAl
            // 
            this.dtAl.Location = new System.Drawing.Point(116, 80);
            this.dtAl.Name = "dtAl";
            this.dtAl.Size = new System.Drawing.Size(269, 22);
            this.dtAl.TabIndex = 5;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(116, 120);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(131, 31);
            this.btnProc.TabIndex = 6;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // OpRepNotasVentasXCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 164);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.dtAl);
            this.Controls.Add(this.dtDel);
            this.Controls.Add(this.cboSuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpRepNotasVentasXCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpRepNotasVentasXCantidad";
            this.Load += new System.EventHandler(this.OpRepNotasVentasXCantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSuc;
        private System.Windows.Forms.DateTimePicker dtDel;
        private System.Windows.Forms.DateTimePicker dtAl;
        private System.Windows.Forms.Button btnProc;
    }
}