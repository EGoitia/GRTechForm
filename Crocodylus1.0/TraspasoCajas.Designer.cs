namespace GRTechnology1._0
{
    partial class TraspasoCajas
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
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboTipoBusq = new System.Windows.Forms.ComboBox();
            this.ckbxMiCaja = new System.Windows.Forms.CheckBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCajaAl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDownMontoSus = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownMontoBs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCajaDel = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.dgvTraspCaj = new System.Windows.Forms.DataGridView();
            this.dtFecNota = new System.Windows.Forms.DateTimePicker();
            this.gbxBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoSus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoBs)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraspCaj)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.txtBuscar);
            this.gbxBotones.Controls.Add(this.cboTipoBusq);
            this.gbxBotones.Controls.Add(this.ckbxMiCaja);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnImp);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnAnul);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Location = new System.Drawing.Point(8, 4);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(906, 100);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(744, 25);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(148, 22);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // cboTipoBusq
            // 
            this.cboTipoBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoBusq.FormattingEnabled = true;
            this.cboTipoBusq.Items.AddRange(new object[] {
            "Codigo",
            "Caja Entrante",
            "Monto Bs",
            "MontoSus",
            "Detalle"});
            this.cboTipoBusq.Location = new System.Drawing.Point(744, 51);
            this.cboTipoBusq.Name = "cboTipoBusq";
            this.cboTipoBusq.Size = new System.Drawing.Size(148, 24);
            this.cboTipoBusq.TabIndex = 9;
            // 
            // ckbxMiCaja
            // 
            this.ckbxMiCaja.AutoSize = true;
            this.ckbxMiCaja.Location = new System.Drawing.Point(648, 40);
            this.ckbxMiCaja.Name = "ckbxMiCaja";
            this.ckbxMiCaja.Size = new System.Drawing.Size(89, 21);
            this.ckbxMiCaja.TabIndex = 8;
            this.ckbxMiCaja.Text = "A mi Caja";
            this.ckbxMiCaja.UseVisualStyleBackColor = true;
            this.ckbxMiCaja.CheckedChanged += new System.EventHandler(this.ckbxMiCaja_CheckedChanged);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(464, 52);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(90, 29);
            this.btnAct.TabIndex = 7;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(555, 21);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(90, 60);
            this.btnImp.TabIndex = 6;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(464, 21);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(90, 29);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(373, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(282, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 60);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(191, 21);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(90, 60);
            this.btnAnul.TabIndex = 2;
            this.btnAnul.Text = "Anular";
            this.btnAnul.UseVisualStyleBackColor = true;
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(100, 21);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(90, 60);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(9, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 60);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCajaAl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numUpDownMontoSus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUpDownMontoBs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCajaDel);
            this.groupBox1.Controls.Add(this.lblOpcion);
            this.groupBox1.Location = new System.Drawing.Point(8, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cboCajaAl
            // 
            this.cboCajaAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCajaAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCajaAl.FormattingEnabled = true;
            this.cboCajaAl.Location = new System.Drawing.Point(118, 101);
            this.cboCajaAl.Name = "cboCajaAl";
            this.cboCajaAl.Size = new System.Drawing.Size(277, 24);
            this.cboCajaAl.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Caja Entrante........";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo..............";
            // 
            // txtDet
            // 
            this.txtDet.Location = new System.Drawing.Point(118, 171);
            this.txtDet.MaxLength = 200;
            this.txtDet.Multiline = true;
            this.txtDet.Name = "txtDet";
            this.txtDet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDet.Size = new System.Drawing.Size(406, 92);
            this.txtDet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detalle..............";
            // 
            // numUpDownMontoSus
            // 
            this.numUpDownMontoSus.DecimalPlaces = 2;
            this.numUpDownMontoSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownMontoSus.Location = new System.Drawing.Point(408, 133);
            this.numUpDownMontoSus.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDownMontoSus.Name = "numUpDownMontoSus";
            this.numUpDownMontoSus.Size = new System.Drawing.Size(116, 22);
            this.numUpDownMontoSus.TabIndex = 3;
            this.numUpDownMontoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMontoSus.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto Sus.- .......";
            // 
            // numUpDownMontoBs
            // 
            this.numUpDownMontoBs.DecimalPlaces = 2;
            this.numUpDownMontoBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownMontoBs.Location = new System.Drawing.Point(118, 133);
            this.numUpDownMontoBs.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDownMontoBs.Name = "numUpDownMontoBs";
            this.numUpDownMontoBs.Size = new System.Drawing.Size(116, 22);
            this.numUpDownMontoBs.TabIndex = 2;
            this.numUpDownMontoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMontoBs.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monto Bs.- .......";
            // 
            // cboCajaDel
            // 
            this.cboCajaDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCajaDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCajaDel.FormattingEnabled = true;
            this.cboCajaDel.Location = new System.Drawing.Point(118, 64);
            this.cboCajaDel.Name = "cboCajaDel";
            this.cboCajaDel.Size = new System.Drawing.Size(277, 24);
            this.cboCajaDel.TabIndex = 0;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(19, 74);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(123, 17);
            this.lblOpcion.TabIndex = 0;
            this.lblOpcion.Text = "Caja Saliente........";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProc);
            this.groupBox2.Controls.Add(this.cboCaja);
            this.groupBox2.Controls.Add(this.dgvTraspCaj);
            this.groupBox2.Controls.Add(this.dtFecNota);
            this.groupBox2.Location = new System.Drawing.Point(557, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(264, 21);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(75, 23);
            this.btnProc.TabIndex = 3;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(18, 21);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(237, 24);
            this.cboCaja.TabIndex = 2;
            // 
            // dgvTraspCaj
            // 
            this.dgvTraspCaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraspCaj.Location = new System.Drawing.Point(18, 78);
            this.dgvTraspCaj.MultiSelect = false;
            this.dgvTraspCaj.Name = "dgvTraspCaj";
            this.dgvTraspCaj.ReadOnly = true;
            this.dgvTraspCaj.RowTemplate.Height = 24;
            this.dgvTraspCaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraspCaj.Size = new System.Drawing.Size(321, 188);
            this.dgvTraspCaj.TabIndex = 1;
            this.dgvTraspCaj.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraspCaj_RowEnter);
            // 
            // dtFecNota
            // 
            this.dtFecNota.Location = new System.Drawing.Point(18, 50);
            this.dtFecNota.Name = "dtFecNota";
            this.dtFecNota.Size = new System.Drawing.Size(321, 22);
            this.dtFecNota.TabIndex = 0;
            // 
            // TraspasoCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBotones);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(939, 434);
            this.MinimumSize = new System.Drawing.Size(939, 434);
            this.Name = "TraspasoCajas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traspaso Cajas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TraspasoCajas_FormClosing);
            this.Load += new System.EventHandler(this.TraspasoCajas_Load);
            this.gbxBotones.ResumeLayout(false);
            this.gbxBotones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoSus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoBs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraspCaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCajaDel;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDownMontoSus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownMontoBs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTraspCaj;
        private System.Windows.Forms.DateTimePicker dtFecNota;
        private System.Windows.Forms.ComboBox cboCajaAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.CheckBox ckbxMiCaja;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboTipoBusq;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.ComboBox cboCaja;
    }
}