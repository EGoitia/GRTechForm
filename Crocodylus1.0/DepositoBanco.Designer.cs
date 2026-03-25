namespace GRTechnology1._0
{
    partial class DepositoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositoBanco));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDepBanco = new System.Windows.Forms.DataGridView();
            this.dtFecNota = new System.Windows.Forms.DateTimePicker();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnAsiento = new System.Windows.Forms.Button();
            this.cboTipoBusq = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUpDownTC = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDepositante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDownMontoSus = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownMontoBs = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.gbxCajas = new System.Windows.Forms.GroupBox();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.btnBorrarImg = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepBanco)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoSus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.gbxCajas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDepBanco);
            this.groupBox2.Controls.Add(this.dtFecNota);
            this.groupBox2.Location = new System.Drawing.Point(758, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 388);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dgvDepBanco
            // 
            this.dgvDepBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepBanco.Location = new System.Drawing.Point(15, 49);
            this.dgvDepBanco.MultiSelect = false;
            this.dgvDepBanco.Name = "dgvDepBanco";
            this.dgvDepBanco.ReadOnly = true;
            this.dgvDepBanco.RowTemplate.Height = 24;
            this.dgvDepBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepBanco.Size = new System.Drawing.Size(270, 329);
            this.dgvDepBanco.TabIndex = 1;
            this.dgvDepBanco.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepBanco_RowEnter);
            // 
            // dtFecNota
            // 
            this.dtFecNota.Location = new System.Drawing.Point(15, 21);
            this.dtFecNota.Name = "dtFecNota";
            this.dtFecNota.Size = new System.Drawing.Size(270, 22);
            this.dtFecNota.TabIndex = 0;
            this.dtFecNota.ValueChanged += new System.EventHandler(this.dtFecNota_ValueChanged);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnAsiento);
            this.gbxBotones.Controls.Add(this.cboTipoBusq);
            this.gbxBotones.Controls.Add(this.txtBuscar);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnAnul);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Location = new System.Drawing.Point(6, 3);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(799, 100);
            this.gbxBotones.TabIndex = 3;
            this.gbxBotones.TabStop = false;
            // 
            // btnAsiento
            // 
            this.btnAsiento.Location = new System.Drawing.Point(464, 52);
            this.btnAsiento.Name = "btnAsiento";
            this.btnAsiento.Size = new System.Drawing.Size(90, 29);
            this.btnAsiento.TabIndex = 9;
            this.btnAsiento.Text = "Asiento";
            this.btnAsiento.UseVisualStyleBackColor = true;
            this.btnAsiento.Click += new System.EventHandler(this.btnAsiento_Click);
            // 
            // cboTipoBusq
            // 
            this.cboTipoBusq.FormattingEnabled = true;
            this.cboTipoBusq.Items.AddRange(new object[] {
            "Codigo",
            "No. Comprobante",
            "Banco",
            "Depositante",
            "Detalle",
            "Monto Bs",
            "Monto Sus"});
            this.cboTipoBusq.Location = new System.Drawing.Point(651, 52);
            this.cboTipoBusq.Name = "cboTipoBusq";
            this.cboTipoBusq.Size = new System.Drawing.Size(134, 24);
            this.cboTipoBusq.TabIndex = 8;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(651, 24);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(134, 22);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(555, 21);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(90, 60);
            this.btnAct.TabIndex = 6;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
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
            this.groupBox1.Controls.Add(this.numUpDownTC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDepositante);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNoComp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numUpDownMontoSus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numUpDownMontoBs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboBanco);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 390);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // numUpDownTC
            // 
            this.numUpDownTC.DecimalPlaces = 2;
            this.numUpDownTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownTC.Location = new System.Drawing.Point(191, 225);
            this.numUpDownTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownTC.Name = "numUpDownTC";
            this.numUpDownTC.Size = new System.Drawing.Size(161, 30);
            this.numUpDownTC.TabIndex = 24;
            this.numUpDownTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownTC.ThousandsSeparator = true;
            this.numUpDownTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "TC............ ............................";
            // 
            // txtDepositante
            // 
            this.txtDepositante.Location = new System.Drawing.Point(130, 119);
            this.txtDepositante.Name = "txtDepositante";
            this.txtDepositante.Size = new System.Drawing.Size(223, 22);
            this.txtDepositante.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Depositante............";
            // 
            // txtNoComp
            // 
            this.txtNoComp.Location = new System.Drawing.Point(130, 53);
            this.txtNoComp.Name = "txtNoComp";
            this.txtNoComp.Size = new System.Drawing.Size(223, 22);
            this.txtNoComp.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "No. Comprobante......";
            // 
            // txtDet
            // 
            this.txtDet.Location = new System.Drawing.Point(119, 267);
            this.txtDet.Multiline = true;
            this.txtDet.Name = "txtDet";
            this.txtDet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDet.Size = new System.Drawing.Size(234, 107);
            this.txtDet.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Detalle...................";
            // 
            // numUpDownMontoSus
            // 
            this.numUpDownMontoSus.DecimalPlaces = 2;
            this.numUpDownMontoSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownMontoSus.Location = new System.Drawing.Point(192, 188);
            this.numUpDownMontoSus.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownMontoSus.Name = "numUpDownMontoSus";
            this.numUpDownMontoSus.Size = new System.Drawing.Size(161, 30);
            this.numUpDownMontoSus.TabIndex = 14;
            this.numUpDownMontoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMontoSus.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Monto Sus.- ............................";
            // 
            // numUpDownMontoBs
            // 
            this.numUpDownMontoBs.DecimalPlaces = 2;
            this.numUpDownMontoBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownMontoBs.Location = new System.Drawing.Point(192, 152);
            this.numUpDownMontoBs.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownMontoBs.Name = "numUpDownMontoBs";
            this.numUpDownMontoBs.Size = new System.Drawing.Size(161, 30);
            this.numUpDownMontoBs.TabIndex = 13;
            this.numUpDownMontoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMontoBs.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Monto Bs.- ............................";
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(130, 84);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(223, 24);
            this.cboBanco.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(130, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco.........................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo....................";
            // 
            // pbxImg
            // 
            this.pbxImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxImg.BackgroundImage")));
            this.pbxImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImg.Location = new System.Drawing.Point(395, 114);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(357, 357);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 6;
            this.pbxImg.TabStop = false;
            this.pbxImg.DoubleClick += new System.EventHandler(this.pbxImg_DoubleClick);
            // 
            // gbxCajas
            // 
            this.gbxCajas.Controls.Add(this.cboCaja);
            this.gbxCajas.Controls.Add(this.btnProc);
            this.gbxCajas.Controls.Add(this.label5);
            this.gbxCajas.Location = new System.Drawing.Point(811, 3);
            this.gbxCajas.Name = "gbxCajas";
            this.gbxCajas.Size = new System.Drawing.Size(248, 100);
            this.gbxCajas.TabIndex = 7;
            this.gbxCajas.TabStop = false;
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(11, 43);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(222, 24);
            this.cboCaja.TabIndex = 21;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(11, 71);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(222, 23);
            this.btnProc.TabIndex = 22;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "CAJA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.Location = new System.Drawing.Point(395, 474);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(41, 23);
            this.btnCargarImg.TabIndex = 8;
            this.btnCargarImg.Text = "..........";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // btnBorrarImg
            // 
            this.btnBorrarImg.Location = new System.Drawing.Point(438, 474);
            this.btnBorrarImg.Name = "btnBorrarImg";
            this.btnBorrarImg.Size = new System.Drawing.Size(41, 23);
            this.btnBorrarImg.TabIndex = 9;
            this.btnBorrarImg.UseVisualStyleBackColor = true;
            this.btnBorrarImg.Click += new System.EventHandler(this.btnBorrarImg_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // DepositoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 507);
            this.Controls.Add(this.btnBorrarImg);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.gbxCajas);
            this.Controls.Add(this.pbxImg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxBotones);
            this.MaximizeBox = false;
            this.Name = "DepositoBanco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposito al Banco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepositoBanco_FormClosing);
            this.Load += new System.EventHandler(this.DepositoBanco_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepBanco)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.gbxBotones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoSus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.gbxCajas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDepBanco;
        private System.Windows.Forms.DateTimePicker dtFecNota;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDownMontoSus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUpDownMontoBs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.GroupBox gbxCajas;
        private System.Windows.Forms.Button btnCargarImg;
        private System.Windows.Forms.Button btnBorrarImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtNoComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAsiento;
        private System.Windows.Forms.ComboBox cboTipoBusq;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepositante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numUpDownTC;
        private System.Windows.Forms.Label label9;
    }
}