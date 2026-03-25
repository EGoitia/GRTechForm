namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepProdVenXVendedor
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
            this.rbDeta = new System.Windows.Forms.RadioButton();
            this.rbResum = new System.Windows.Forms.RadioButton();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.btnAct = new System.Windows.Forms.Button();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.lblNomCliVende = new System.Windows.Forms.Label();
            this.dgvSuc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSubgrupo = new System.Windows.Forms.CheckBox();
            this.chkGrupo = new System.Windows.Forms.CheckBox();
            this.chkMarca = new System.Windows.Forms.CheckBox();
            this.cboSubgrupo = new System.Windows.Forms.ComboBox();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.chkSelec = new System.Windows.Forms.CheckBox();
            this.chkSelecSuc = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeta);
            this.groupBox1.Controls.Add(this.rbResum);
            this.groupBox1.Controls.Add(this.dtFecFin);
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.dtFecIni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Location = new System.Drawing.Point(353, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 111);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbDeta
            // 
            this.rbDeta.AutoSize = true;
            this.rbDeta.Location = new System.Drawing.Point(24, 84);
            this.rbDeta.Name = "rbDeta";
            this.rbDeta.Size = new System.Drawing.Size(70, 17);
            this.rbDeta.TabIndex = 20;
            this.rbDeta.Text = "Detallado";
            this.rbDeta.UseVisualStyleBackColor = true;
            // 
            // rbResum
            // 
            this.rbResum.AutoSize = true;
            this.rbResum.Checked = true;
            this.rbResum.Location = new System.Drawing.Point(24, 58);
            this.rbResum.Name = "rbResum";
            this.rbResum.Size = new System.Drawing.Size(72, 17);
            this.rbResum.TabIndex = 20;
            this.rbResum.TabStop = true;
            this.rbResum.Text = "Resumido";
            this.rbResum.UseVisualStyleBackColor = true;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(209, 19);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(101, 20);
            this.dtFecFin.TabIndex = 19;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(206, 51);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(96, 50);
            this.btnAct.TabIndex = 17;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(98, 19);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(100, 20);
            this.dtFecIni.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fechas:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(109, 50);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(91, 51);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Location = new System.Drawing.Point(10, 32);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.Size = new System.Drawing.Size(331, 208);
            this.dgvVendedores.TabIndex = 17;
            // 
            // lblNomCliVende
            // 
            this.lblNomCliVende.Location = new System.Drawing.Point(7, 4);
            this.lblNomCliVende.Name = "lblNomCliVende";
            this.lblNomCliVende.Size = new System.Drawing.Size(272, 23);
            this.lblNomCliVende.TabIndex = 18;
            this.lblNomCliVende.Text = "VendCli";
            this.lblNomCliVende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSuc
            // 
            this.dgvSuc.AllowUserToAddRows = false;
            this.dgvSuc.AllowUserToDeleteRows = false;
            this.dgvSuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuc.Location = new System.Drawing.Point(353, 32);
            this.dgvSuc.Name = "dgvSuc";
            this.dgvSuc.Size = new System.Drawing.Size(327, 208);
            this.dgvSuc.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(353, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "SUCURSALES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSubgrupo);
            this.groupBox2.Controls.Add(this.chkGrupo);
            this.groupBox2.Controls.Add(this.chkMarca);
            this.groupBox2.Controls.Add(this.cboSubgrupo);
            this.groupBox2.Controls.Add(this.cboGrupo);
            this.groupBox2.Controls.Add(this.cboMarca);
            this.groupBox2.Location = new System.Drawing.Point(10, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 111);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // chkSubgrupo
            // 
            this.chkSubgrupo.AutoSize = true;
            this.chkSubgrupo.Location = new System.Drawing.Point(13, 83);
            this.chkSubgrupo.Name = "chkSubgrupo";
            this.chkSubgrupo.Size = new System.Drawing.Size(75, 17);
            this.chkSubgrupo.TabIndex = 20;
            this.chkSubgrupo.Text = "Subgrupo:";
            this.chkSubgrupo.UseVisualStyleBackColor = true;
            this.chkSubgrupo.CheckedChanged += new System.EventHandler(this.chkMarca_CheckedChanged);
            // 
            // chkGrupo
            // 
            this.chkGrupo.AutoSize = true;
            this.chkGrupo.Location = new System.Drawing.Point(13, 51);
            this.chkGrupo.Name = "chkGrupo";
            this.chkGrupo.Size = new System.Drawing.Size(58, 17);
            this.chkGrupo.TabIndex = 20;
            this.chkGrupo.Text = "Grupo:";
            this.chkGrupo.UseVisualStyleBackColor = true;
            this.chkGrupo.CheckedChanged += new System.EventHandler(this.chkMarca_CheckedChanged);
            // 
            // chkMarca
            // 
            this.chkMarca.AutoSize = true;
            this.chkMarca.Location = new System.Drawing.Point(13, 22);
            this.chkMarca.Name = "chkMarca";
            this.chkMarca.Size = new System.Drawing.Size(59, 17);
            this.chkMarca.TabIndex = 20;
            this.chkMarca.Text = "Marca:";
            this.chkMarca.UseVisualStyleBackColor = true;
            this.chkMarca.CheckedChanged += new System.EventHandler(this.chkMarca_CheckedChanged);
            // 
            // cboSubgrupo
            // 
            this.cboSubgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubgrupo.Enabled = false;
            this.cboSubgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubgrupo.FormattingEnabled = true;
            this.cboSubgrupo.Location = new System.Drawing.Point(90, 77);
            this.cboSubgrupo.Name = "cboSubgrupo";
            this.cboSubgrupo.Size = new System.Drawing.Size(226, 21);
            this.cboSubgrupo.TabIndex = 19;
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.Enabled = false;
            this.cboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(90, 47);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(226, 21);
            this.cboGrupo.TabIndex = 19;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Enabled = false;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "SUB-RUBRO",
            "RUBRO",
            "TOTALES"});
            this.cboMarca.Location = new System.Drawing.Point(90, 18);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(226, 21);
            this.cboMarca.TabIndex = 16;
            // 
            // chkSelec
            // 
            this.chkSelec.AutoSize = true;
            this.chkSelec.Checked = true;
            this.chkSelec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelec.Location = new System.Drawing.Point(285, 8);
            this.chkSelec.Name = "chkSelec";
            this.chkSelec.Size = new System.Drawing.Size(56, 17);
            this.chkSelec.TabIndex = 21;
            this.chkSelec.Text = "Selec.";
            this.chkSelec.UseVisualStyleBackColor = true;
            this.chkSelec.CheckedChanged += new System.EventHandler(this.chkSelec_CheckedChanged);
            // 
            // chkSelecSuc
            // 
            this.chkSelecSuc.AutoSize = true;
            this.chkSelecSuc.Checked = true;
            this.chkSelecSuc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelecSuc.Location = new System.Drawing.Point(624, 8);
            this.chkSelecSuc.Name = "chkSelecSuc";
            this.chkSelecSuc.Size = new System.Drawing.Size(56, 17);
            this.chkSelecSuc.TabIndex = 22;
            this.chkSelecSuc.Text = "Selec.";
            this.chkSelecSuc.UseVisualStyleBackColor = true;
            this.chkSelecSuc.CheckedChanged += new System.EventHandler(this.chkSelecSuc_CheckedChanged);
            // 
            // OpRepProdVenXVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 363);
            this.Controls.Add(this.chkSelecSuc);
            this.Controls.Add(this.chkSelec);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNomCliVende);
            this.Controls.Add(this.dgvSuc);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpRepProdVenXVendedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTOS VENDIDOS POR VENDEDOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepProdVenXVendedor_FormClosing);
            this.Load += new System.EventHandler(this.OpRepProdVenXVendedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Label lblNomCliVende;
        private System.Windows.Forms.DataGridView dgvSuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSubgrupo;
        private System.Windows.Forms.CheckBox chkGrupo;
        private System.Windows.Forms.CheckBox chkMarca;
        private System.Windows.Forms.ComboBox cboSubgrupo;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.CheckBox chkSelec;
        private System.Windows.Forms.CheckBox chkSelecSuc;
        private System.Windows.Forms.RadioButton rbDeta;
        private System.Windows.Forms.RadioButton rbResum;
    }
}