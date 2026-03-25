namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepMovimientoDiarioCaja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOpcRep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOpc = new System.Windows.Forms.ComboBox();
            this.lblOpc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtAl = new System.Windows.Forms.DateTimePicker();
            this.dtDel = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOpcRep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboOpc);
            this.groupBox1.Controls.Add(this.lblOpc);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(313, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // cboOpcRep
            // 
            this.cboOpcRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcRep.FormattingEnabled = true;
            this.cboOpcRep.Items.AddRange(new object[] {
            "Sucursal",
            "Empresa"});
            this.cboOpcRep.Location = new System.Drawing.Point(113, 17);
            this.cboOpcRep.Margin = new System.Windows.Forms.Padding(2);
            this.cboOpcRep.Name = "cboOpcRep";
            this.cboOpcRep.Size = new System.Drawing.Size(181, 21);
            this.cboOpcRep.TabIndex = 4;
            this.cboOpcRep.SelectedValueChanged += new System.EventHandler(this.cboOpcRep_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Movimiento por..............";
            // 
            // cboOpc
            // 
            this.cboOpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpc.FormattingEnabled = true;
            this.cboOpc.Location = new System.Drawing.Point(86, 41);
            this.cboOpc.Margin = new System.Windows.Forms.Padding(2);
            this.cboOpc.Name = "cboOpc";
            this.cboOpc.Size = new System.Drawing.Size(209, 21);
            this.cboOpc.TabIndex = 1;
            // 
            // lblOpc
            // 
            this.lblOpc.AutoSize = true;
            this.lblOpc.Location = new System.Drawing.Point(16, 47);
            this.lblOpc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpc.Name = "lblOpc";
            this.lblOpc.Size = new System.Drawing.Size(76, 13);
            this.lblOpc.TabIndex = 0;
            this.lblOpc.Text = "Caja................";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtAl);
            this.groupBox2.Controls.Add(this.dtDel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(313, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // dtAl
            // 
            this.dtAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAl.Location = new System.Drawing.Point(193, 19);
            this.dtAl.Margin = new System.Windows.Forms.Padding(2);
            this.dtAl.Name = "dtAl";
            this.dtAl.Size = new System.Drawing.Size(102, 20);
            this.dtAl.TabIndex = 5;
            // 
            // dtDel
            // 
            this.dtDel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDel.Location = new System.Drawing.Point(38, 20);
            this.dtDel.Margin = new System.Windows.Forms.Padding(2);
            this.dtDel.Name = "dtDel";
            this.dtDel.Size = new System.Drawing.Size(102, 20);
            this.dtDel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Al......................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Del..................";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(51, 151);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(92, 46);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 151);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 46);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // OpRepMovimientoDiarioCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 229);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 268);
            this.MinimumSize = new System.Drawing.Size(342, 268);
            this.Name = "OpRepMovimientoDiarioCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento Diario de Caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepMovimientoDiarioCaja_FormClosing);
            this.Load += new System.EventHandler(this.MovimientoDiarioCaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOpcRep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOpc;
        private System.Windows.Forms.Label lblOpc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtAl;
        private System.Windows.Forms.DateTimePicker dtDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCancelar;
    }
}