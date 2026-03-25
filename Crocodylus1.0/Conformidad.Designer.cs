namespace GRTechnology1._0
{
    partial class Conformidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conformidad));
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.qrCodeImg = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboTipoBusq = new System.Windows.Forms.ComboBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnValor = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscDest = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboChofer = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtNotSalida = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumConf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gbxUbicacion = new System.Windows.Forms.GroupBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtTotPzas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotBolsas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotMetros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDConf = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtFechaNota = new System.Windows.Forms.DateTimePicker();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImg)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.gbxUbicacion.SuspendLayout();
            this.gbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDConf)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.qrCodeImg);
            this.gbxBotones.Controls.Add(this.txtBuscar);
            this.gbxBotones.Controls.Add(this.cboTipoBusq);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnAnul);
            this.gbxBotones.Controls.Add(this.btnRest);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Controls.Add(this.btnImp);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnValor);
            this.gbxBotones.Location = new System.Drawing.Point(6, 3);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(1231, 100);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // qrCodeImg
            // 
            this.qrCodeImg.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrCodeImg.Image = ((System.Drawing.Image)(resources.GetObject("qrCodeImg.Image")));
            this.qrCodeImg.Location = new System.Drawing.Point(1145, 22);
            this.qrCodeImg.Name = "qrCodeImg";
            this.qrCodeImg.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrCodeImg.Size = new System.Drawing.Size(71, 63);
            this.qrCodeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrCodeImg.TabIndex = 23;
            this.qrCodeImg.TabStop = false;
            this.qrCodeImg.Text = "Conformidad";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(881, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 25;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 22);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // cboTipoBusq
            // 
            this.cboTipoBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoBusq.FormattingEnabled = true;
            this.cboTipoBusq.Items.AddRange(new object[] {
            "Nota Conformidad",
            "N/Salida",
            "Destino",
            "Nombre Chofer",
            "Nombre Cliente",
            "Nombre Item",
            "Codigo Item"});
            this.cboTipoBusq.Location = new System.Drawing.Point(881, 52);
            this.cboTipoBusq.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoBusq.Name = "cboTipoBusq";
            this.cboTipoBusq.Size = new System.Drawing.Size(172, 24);
            this.cboTipoBusq.TabIndex = 12;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(100, 22);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(85, 61);
            this.btnModif.TabIndex = 2;
            this.btnModif.Text = "Modificar";
            this.btnModif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(186, 22);
            this.btnAnul.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(85, 61);
            this.btnAnul.TabIndex = 3;
            this.btnAnul.Text = "Anular";
            this.btnAnul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnul.UseVisualStyleBackColor = true;
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(272, 22);
            this.btnRest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(85, 61);
            this.btnRest.TabIndex = 4;
            this.btnRest.Text = "Restaurar";
            this.btnRest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(358, 22);
            this.btnAct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(85, 61);
            this.btnAct.TabIndex = 5;
            this.btnAct.Text = "Actualizar";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(444, 22);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 61);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(530, 22);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 61);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(14, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 61);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(616, 22);
            this.btnImp.Margin = new System.Windows.Forms.Padding(4);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(85, 61);
            this.btnImp.TabIndex = 8;
            this.btnImp.Text = "Imprimir";
            this.btnImp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(702, 22);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(85, 61);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Registro";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(788, 22);
            this.btnValor.Margin = new System.Windows.Forms.Padding(4);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(85, 61);
            this.btnValor.TabIndex = 10;
            this.btnValor.Text = "Valor Conf.";
            this.btnValor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBuscDest);
            this.gbxDatos.Controls.Add(this.txtValor);
            this.gbxDatos.Controls.Add(this.label13);
            this.gbxDatos.Controls.Add(this.cboOrigen);
            this.gbxDatos.Controls.Add(this.cboDestino);
            this.gbxDatos.Controls.Add(this.txtDetalle);
            this.gbxDatos.Controls.Add(this.txtReferencia);
            this.gbxDatos.Controls.Add(this.label10);
            this.gbxDatos.Controls.Add(this.label9);
            this.gbxDatos.Controls.Add(this.cboChofer);
            this.gbxDatos.Controls.Add(this.txtPlaca);
            this.gbxDatos.Controls.Add(this.txtNotSalida);
            this.gbxDatos.Controls.Add(this.dtFecha);
            this.gbxDatos.Controls.Add(this.txtNumConf);
            this.gbxDatos.Controls.Add(this.label8);
            this.gbxDatos.Controls.Add(this.label7);
            this.gbxDatos.Controls.Add(this.label6);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.lblNumero);
            this.gbxDatos.Location = new System.Drawing.Point(6, 105);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDatos.Size = new System.Drawing.Size(916, 167);
            this.gbxDatos.TabIndex = 24;
            this.gbxDatos.TabStop = false;
            // 
            // btnBuscDest
            // 
            this.btnBuscDest.Location = new System.Drawing.Point(452, 71);
            this.btnBuscDest.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscDest.Name = "btnBuscDest";
            this.btnBuscDest.Size = new System.Drawing.Size(45, 28);
            this.btnBuscDest.TabIndex = 22;
            this.btnBuscDest.Text = ".....";
            this.btnBuscDest.UseVisualStyleBackColor = true;
            this.btnBuscDest.Click += new System.EventHandler(this.btnBuscDest_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(573, 74);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(57, 22);
            this.txtValor.TabIndex = 20;
            this.txtValor.TabStop = false;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(511, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Valor.......";
            // 
            // cboOrigen
            // 
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(97, 43);
            this.cboOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrigen.MaxLength = 50;
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(276, 24);
            this.cboOrigen.TabIndex = 1;
            // 
            // cboDestino
            // 
            this.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(97, 73);
            this.cboDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(349, 24);
            this.cboDestino.TabIndex = 6;
            this.cboDestino.SelectedValueChanged += new System.EventHandler(this.cboDestino_SelectedValueChanged);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(97, 130);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.MaxLength = 200;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(809, 25);
            this.txtDetalle.TabIndex = 12;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(476, 103);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia.MaxLength = 70;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(431, 22);
            this.txtReferencia.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Detalle.........";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cliente.............";
            // 
            // cboChofer
            // 
            this.cboChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChofer.FormattingEnabled = true;
            this.cboChofer.Location = new System.Drawing.Point(97, 102);
            this.cboChofer.Margin = new System.Windows.Forms.Padding(4);
            this.cboChofer.Name = "cboChofer";
            this.cboChofer.Size = new System.Drawing.Size(276, 24);
            this.cboChofer.TabIndex = 9;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(747, 74);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlaca.MaxLength = 20;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(160, 22);
            this.txtPlaca.TabIndex = 10;
            // 
            // txtNotSalida
            // 
            this.txtNotSalida.Location = new System.Drawing.Point(476, 44);
            this.txtNotSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotSalida.MaxLength = 50;
            this.txtNotSalida.Name = "txtNotSalida";
            this.txtNotSalida.ReadOnly = true;
            this.txtNotSalida.Size = new System.Drawing.Size(431, 22);
            this.txtNotSalida.TabIndex = 5;
            this.txtNotSalida.TabStop = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(476, 15);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(155, 22);
            this.dtFecha.TabIndex = 3;
            this.dtFecha.TabStop = false;
            // 
            // txtNumConf
            // 
            this.txtNumConf.Location = new System.Drawing.Point(97, 15);
            this.txtNumConf.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumConf.Name = "txtNumConf";
            this.txtNumConf.ReadOnly = true;
            this.txtNumConf.Size = new System.Drawing.Size(120, 22);
            this.txtNumConf.TabIndex = 1;
            this.txtNumConf.TabStop = false;
            this.txtNumConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chofer..........";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Placa..........";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "N/Salida.......";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha...........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino..........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen............";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(11, 23);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(98, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero..........";
            // 
            // gbxUbicacion
            // 
            this.gbxUbicacion.Controls.Add(this.cboCiudad);
            this.gbxUbicacion.Controls.Add(this.txtLong);
            this.gbxUbicacion.Controls.Add(this.txtLat);
            this.gbxUbicacion.Controls.Add(this.txtDireccion);
            this.gbxUbicacion.Controls.Add(this.txtBarrio);
            this.gbxUbicacion.Controls.Add(this.txtZona);
            this.gbxUbicacion.Controls.Add(this.label28);
            this.gbxUbicacion.Controls.Add(this.label27);
            this.gbxUbicacion.Controls.Add(this.label26);
            this.gbxUbicacion.Controls.Add(this.label25);
            this.gbxUbicacion.Controls.Add(this.label24);
            this.gbxUbicacion.Controls.Add(this.label23);
            this.gbxUbicacion.Location = new System.Drawing.Point(6, 275);
            this.gbxUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUbicacion.Name = "gbxUbicacion";
            this.gbxUbicacion.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUbicacion.Size = new System.Drawing.Size(916, 79);
            this.gbxUbicacion.TabIndex = 28;
            this.gbxUbicacion.TabStop = false;
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.Enabled = false;
            this.cboCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Items.AddRange(new object[] {
            "Cobija",
            "Cochabamba",
            "La Paz",
            "Oruro",
            "Potosi",
            "Santa Cruz",
            "Sucre",
            "Tarija",
            "Trinidad"});
            this.cboCiudad.Location = new System.Drawing.Point(103, 14);
            this.cboCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(251, 24);
            this.cboCiudad.TabIndex = 21;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(805, 42);
            this.txtLong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(101, 22);
            this.txtLong.TabIndex = 19;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(805, 15);
            this.txtLat.Margin = new System.Windows.Forms.Padding(4);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(101, 22);
            this.txtLat.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(452, 42);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(251, 22);
            this.txtDireccion.TabIndex = 17;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(452, 15);
            this.txtBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(251, 22);
            this.txtBarrio.TabIndex = 16;
            // 
            // txtZona
            // 
            this.txtZona.Location = new System.Drawing.Point(103, 42);
            this.txtZona.Margin = new System.Windows.Forms.Padding(4);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(251, 22);
            this.txtZona.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(725, 50);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 17);
            this.label28.TabIndex = 9;
            this.label28.Text = "Longitud......";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(725, 26);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 17);
            this.label27.TabIndex = 8;
            this.label27.Text = "Latitud.........";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(372, 50);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Direccion......";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(372, 26);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 17);
            this.label25.TabIndex = 6;
            this.label25.Text = "Barrio...........";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(23, 50);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 17);
            this.label24.TabIndex = 5;
            this.label24.Text = "Zona.............";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 26);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 17);
            this.label23.TabIndex = 4;
            this.label23.Text = "Ciudad..........";
            // 
            // gbxTotales
            // 
            this.gbxTotales.Controls.Add(this.txtTotPzas);
            this.gbxTotales.Controls.Add(this.label11);
            this.gbxTotales.Controls.Add(this.txtTotBolsas);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Controls.Add(this.txtTotMetros);
            this.gbxTotales.Controls.Add(this.label1);
            this.gbxTotales.Controls.Add(this.dgvDConf);
            this.gbxTotales.Location = new System.Drawing.Point(6, 356);
            this.gbxTotales.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTotales.Size = new System.Drawing.Size(916, 269);
            this.gbxTotales.TabIndex = 29;
            this.gbxTotales.TabStop = false;
            // 
            // txtTotPzas
            // 
            this.txtTotPzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPzas.Location = new System.Drawing.Point(803, 234);
            this.txtTotPzas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotPzas.Name = "txtTotPzas";
            this.txtTotPzas.ReadOnly = true;
            this.txtTotPzas.Size = new System.Drawing.Size(104, 23);
            this.txtTotPzas.TabIndex = 19;
            this.txtTotPzas.TabStop = false;
            this.txtTotPzas.Text = "0.00";
            this.txtTotPzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(724, 242);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Total Pzas....";
            // 
            // txtTotBolsas
            // 
            this.txtTotBolsas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotBolsas.Location = new System.Drawing.Point(596, 234);
            this.txtTotBolsas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotBolsas.Name = "txtTotBolsas";
            this.txtTotBolsas.ReadOnly = true;
            this.txtTotBolsas.Size = new System.Drawing.Size(104, 23);
            this.txtTotBolsas.TabIndex = 18;
            this.txtTotBolsas.TabStop = false;
            this.txtTotBolsas.Text = "0.00";
            this.txtTotBolsas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Bolsas.....";
            // 
            // txtTotMetros
            // 
            this.txtTotMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotMetros.Location = new System.Drawing.Point(361, 234);
            this.txtTotMetros.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotMetros.Name = "txtTotMetros";
            this.txtTotMetros.ReadOnly = true;
            this.txtTotMetros.Size = new System.Drawing.Size(104, 23);
            this.txtTotMetros.TabIndex = 16;
            this.txtTotMetros.TabStop = false;
            this.txtTotMetros.Text = "0.00";
            this.txtTotMetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Mtr. ......";
            // 
            // dgvDConf
            // 
            this.dgvDConf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDConf.Location = new System.Drawing.Point(11, 16);
            this.dgvDConf.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDConf.MultiSelect = false;
            this.dgvDConf.Name = "dgvDConf";
            this.dgvDConf.Size = new System.Drawing.Size(897, 212);
            this.dgvDConf.TabIndex = 14;
            this.dgvDConf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDConf_CellDoubleClick);
            this.dgvDConf.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDConf_CellEndEdit);
            this.dgvDConf.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDConf_EditingControlShowing);
            this.dgvDConf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDConf_KeyDown);
            this.dgvDConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDConf_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtFechaNota);
            this.groupBox3.Controls.Add(this.dgvNotas);
            this.groupBox3.Location = new System.Drawing.Point(930, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(307, 520);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // dtFechaNota
            // 
            this.dtFechaNota.Location = new System.Drawing.Point(9, 14);
            this.dtFechaNota.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaNota.Name = "dtFechaNota";
            this.dtFechaNota.Size = new System.Drawing.Size(283, 22);
            this.dtFechaNota.TabIndex = 15;
            this.dtFechaNota.ValueChanged += new System.EventHandler(this.dtFechaNota_ValueChanged);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(8, 46);
            this.dgvNotas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(284, 462);
            this.dgvNotas.TabIndex = 14;
            this.dgvNotas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_RowEnter);
            // 
            // Conformidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1246, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbxTotales);
            this.Controls.Add(this.gbxUbicacion);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxBotones);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1264, 681);
            this.MinimumSize = new System.Drawing.Size(1264, 681);
            this.Name = "Conformidad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conformida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Conformida_FormClosing);
            this.Load += new System.EventHandler(this.Conformida_Load);
            this.gbxBotones.ResumeLayout(false);
            this.gbxBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeImg)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxUbicacion.ResumeLayout(false);
            this.gbxUbicacion.PerformLayout();
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDConf)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboTipoBusq;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnBuscDest;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboChofer;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtNotSalida;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtNumConf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox gbxUbicacion;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtTotPzas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotBolsas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotMetros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDConf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtFechaNota;
        private System.Windows.Forms.DataGridView dgvNotas;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrCodeImg;
    }
}