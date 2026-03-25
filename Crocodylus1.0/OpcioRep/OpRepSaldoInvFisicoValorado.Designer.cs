namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepSaldoInvFisicoValorado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.rbFisic = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.cboSubgrupo = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSaldoCero = new System.Windows.Forms.CheckBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvSuc = new System.Windows.Forms.DataGridView();
            this.chkSelec = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbValor);
            this.groupBox3.Controls.Add(this.rbFisic);
            this.groupBox3.Location = new System.Drawing.Point(330, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 45);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Location = new System.Drawing.Point(177, 19);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(200, 17);
            this.rbValor.TabIndex = 9;
            this.rbValor.TabStop = true;
            this.rbValor.Text = "Saldo de Inventario Físico - Valorado";
            this.rbValor.UseVisualStyleBackColor = true;
            // 
            // rbFisic
            // 
            this.rbFisic.AutoSize = true;
            this.rbFisic.Checked = true;
            this.rbFisic.Location = new System.Drawing.Point(15, 19);
            this.rbFisic.Name = "rbFisic";
            this.rbFisic.Size = new System.Drawing.Size(149, 17);
            this.rbFisic.TabIndex = 8;
            this.rbFisic.TabStop = true;
            this.rbFisic.Text = "Saldo de Inventario Físico";
            this.rbFisic.UseVisualStyleBackColor = true;
            this.rbFisic.CheckedChanged += new System.EventHandler(this.rbFisic_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(this.cboSubgrupo);
            this.groupBox2.Controls.Add(this.cboGrupo);
            this.groupBox2.Controls.Add(this.cboMarca);
            this.groupBox2.Location = new System.Drawing.Point(330, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(79, 106);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(283, 20);
            this.txtProducto.TabIndex = 21;
            // 
            // cboSubgrupo
            // 
            this.cboSubgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubgrupo.FormattingEnabled = true;
            this.cboSubgrupo.Location = new System.Drawing.Point(79, 77);
            this.cboSubgrupo.Name = "cboSubgrupo";
            this.cboSubgrupo.Size = new System.Drawing.Size(283, 21);
            this.cboSubgrupo.TabIndex = 19;
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(79, 47);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(283, 21);
            this.cboGrupo.TabIndex = 19;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "SUB-RUBRO",
            "RUBRO",
            "TOTALES"});
            this.cboMarca.Location = new System.Drawing.Point(79, 18);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(283, 21);
            this.cboMarca.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSaldoCero);
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Location = new System.Drawing.Point(330, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 101);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // chkSaldoCero
            // 
            this.chkSaldoCero.AutoSize = true;
            this.chkSaldoCero.Location = new System.Drawing.Point(211, 23);
            this.chkSaldoCero.Name = "chkSaldoCero";
            this.chkSaldoCero.Size = new System.Drawing.Size(116, 17);
            this.chkSaldoCero.TabIndex = 18;
            this.chkSaldoCero.Text = "Imprimir Saldo Cero";
            this.chkSaldoCero.UseVisualStyleBackColor = true;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(282, 48);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(80, 40);
            this.btnAct.TabIndex = 17;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(67, 20);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(107, 20);
            this.dtFecha.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(196, 48);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(80, 40);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dgvSuc
            // 
            this.dgvSuc.AllowUserToAddRows = false;
            this.dgvSuc.AllowUserToDeleteRows = false;
            this.dgvSuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuc.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuc.Location = new System.Drawing.Point(10, 35);
            this.dgvSuc.MultiSelect = false;
            this.dgvSuc.Name = "dgvSuc";
            this.dgvSuc.Size = new System.Drawing.Size(312, 264);
            this.dgvSuc.TabIndex = 15;
            // 
            // chkSelec
            // 
            this.chkSelec.AutoSize = true;
            this.chkSelec.Checked = true;
            this.chkSelec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelec.Location = new System.Drawing.Point(266, 12);
            this.chkSelec.Name = "chkSelec";
            this.chkSelec.Size = new System.Drawing.Size(56, 17);
            this.chkSelec.TabIndex = 16;
            this.chkSelec.Text = "Selec.";
            this.chkSelec.UseVisualStyleBackColor = true;
            this.chkSelec.CheckedChanged += new System.EventHandler(this.chkSelec_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Subgrupo:";
            // 
            // OpRepSaldoInvFisicoValorado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(725, 307);
            this.Controls.Add(this.chkSelec);
            this.Controls.Add(this.dgvSuc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpRepSaldoInvFisicoValorado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALDO DE INVENTARIO FÍSICO - VALORADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepSaldoInvFisicoValorado_FormClosing);
            this.Load += new System.EventHandler(this.OpRepSaldoInvFisicoValorado_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.RadioButton rbFisic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.ComboBox cboSubgrupo;
        private System.Windows.Forms.DataGridView dgvSuc;
        private System.Windows.Forms.CheckBox chkSaldoCero;
        private System.Windows.Forms.CheckBox chkSelec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}