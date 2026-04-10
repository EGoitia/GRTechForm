namespace GRTechnology1._0
{
    partial class Frm_AbonosPOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrin = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAbonar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblPagado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusqClient = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.gbxFormaPago = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.CAbonar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelPrin.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.gbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.gbxFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrin
            // 
            this.panelPrin.Controls.Add(this.panelDatos);
            this.panelPrin.Controls.Add(this.panelLeft);
            this.panelPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrin.Location = new System.Drawing.Point(0, 0);
            this.panelPrin.Name = "panelPrin";
            this.panelPrin.Size = new System.Drawing.Size(878, 405);
            this.panelPrin.TabIndex = 13;
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.gbxTotales);
            this.panelDatos.Controls.Add(this.dgvDeudas);
            this.panelDatos.Controls.Add(this.groupBox1);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatos.Location = new System.Drawing.Point(308, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(570, 405);
            this.panelDatos.TabIndex = 1;
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.label12);
            this.gbxTotales.Controls.Add(this.lblAbonar);
            this.gbxTotales.Controls.Add(this.label11);
            this.gbxTotales.Controls.Add(this.label1);
            this.gbxTotales.Controls.Add(this.Label26);
            this.gbxTotales.Controls.Add(this.LblTotal);
            this.gbxTotales.Controls.Add(this.Label27);
            this.gbxTotales.Controls.Add(this.label7);
            this.gbxTotales.Controls.Add(this.LblPagado);
            this.gbxTotales.Controls.Add(this.label8);
            this.gbxTotales.Controls.Add(this.Label5);
            this.gbxTotales.Controls.Add(this.LblSaldo);
            this.gbxTotales.Location = new System.Drawing.Point(6, 329);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(554, 70);
            this.gbxTotales.TabIndex = 15;
            this.gbxTotales.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.label12.Location = new System.Drawing.Point(285, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 277;
            this.label12.Text = "ABONAR:";
            // 
            // lblAbonar
            // 
            this.lblAbonar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblAbonar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAbonar.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonar.Location = new System.Drawing.Point(403, 44);
            this.lblAbonar.Name = "lblAbonar";
            this.lblAbonar.Size = new System.Drawing.Size(93, 20);
            this.lblAbonar.TabIndex = 276;
            this.lblAbonar.Text = "0.00";
            this.lblAbonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(501, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 23);
            this.label11.TabIndex = 278;
            this.label11.Text = "Bs.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 275;
            this.label1.Text = "Bs.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label26
            // 
            this.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label26.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.Label26.Location = new System.Drawing.Point(21, 16);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(112, 20);
            this.Label26.TabIndex = 268;
            this.Label26.Text = "TOTAL VENTAS:";
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotal.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(139, 16);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(93, 20);
            this.LblTotal.TabIndex = 267;
            this.LblTotal.Text = "0.00";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label27
            // 
            this.Label27.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.Location = new System.Drawing.Point(237, 16);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(29, 23);
            this.Label27.TabIndex = 269;
            this.Label27.Text = "Bs.";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.label7.Location = new System.Drawing.Point(285, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 271;
            this.label7.Text = "TOTAL ABONADO:";
            // 
            // LblPagado
            // 
            this.LblPagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPagado.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPagado.Location = new System.Drawing.Point(403, 16);
            this.LblPagado.Name = "LblPagado";
            this.LblPagado.Size = new System.Drawing.Size(93, 20);
            this.LblPagado.TabIndex = 270;
            this.LblPagado.Text = "0.00";
            this.LblPagado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(501, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 23);
            this.label8.TabIndex = 272;
            this.label8.Text = "Bs.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label5.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.Label5.Location = new System.Drawing.Point(21, 43);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(109, 20);
            this.Label5.TabIndex = 274;
            this.Label5.Text = "TOTAL SALDO:";
            // 
            // LblSaldo
            // 
            this.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSaldo.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(139, 43);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(93, 20);
            this.LblSaldo.TabIndex = 273;
            this.LblSaldo.Text = "0.00";
            this.LblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.AllowUserToAddRows = false;
            this.dgvDeudas.AllowUserToDeleteRows = false;
            this.dgvDeudas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeudas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAbonar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeudas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeudas.Location = new System.Drawing.Point(6, 73);
            this.dgvDeudas.MultiSelect = false;
            this.dgvDeudas.Name = "dgvDeudas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeudas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDeudas.RowTemplate.Height = 40;
            this.dgvDeudas.Size = new System.Drawing.Size(554, 255);
            this.dgvDeudas.TabIndex = 14;
            this.dgvDeudas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeudas_CellValueChanged);
            this.dgvDeudas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDeudas_CurrentCellDirtyStateChanged);
            this.dgvDeudas.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeudas_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusqClient);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 60);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnBusqClient
            // 
            this.btnBusqClient.ImageIndex = 14;
            this.btnBusqClient.Location = new System.Drawing.Point(505, 21);
            this.btnBusqClient.Name = "btnBusqClient";
            this.btnBusqClient.Size = new System.Drawing.Size(33, 23);
            this.btnBusqClient.TabIndex = 62;
            this.btnBusqClient.Text = "......";
            this.btnBusqClient.UseVisualStyleBackColor = true;
            this.btnBusqClient.Click += new System.EventHandler(this.btnBusqClient_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(68, 21);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(431, 21);
            this.cboCliente.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Cliente:";
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.Controls.Add(this.gbxFormaPago);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(308, 405);
            this.panelLeft.TabIndex = 0;
            // 
            // gbxFormaPago
            // 
            this.gbxFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFormaPago.Controls.Add(this.btnAct);
            this.gbxFormaPago.Controls.Add(this.label9);
            this.gbxFormaPago.Controls.Add(this.label6);
            this.gbxFormaPago.Controls.Add(this.label4);
            this.gbxFormaPago.Controls.Add(this.label2);
            this.gbxFormaPago.Controls.Add(this.cboCaja);
            this.gbxFormaPago.Controls.Add(this.cboTipoPago);
            this.gbxFormaPago.Controls.Add(this.btnCancelar);
            this.gbxFormaPago.Controls.Add(this.btnGuardar);
            this.gbxFormaPago.Controls.Add(this.txtMonto);
            this.gbxFormaPago.Controls.Add(this.txtObs);
            this.gbxFormaPago.Location = new System.Drawing.Point(6, 4);
            this.gbxFormaPago.Name = "gbxFormaPago";
            this.gbxFormaPago.Size = new System.Drawing.Size(296, 392);
            this.gbxFormaPago.TabIndex = 0;
            this.gbxFormaPago.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Observación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Caja/Banco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Monto Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Metodo de Pago:";
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(6, 93);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(285, 37);
            this.cboCaja.TabIndex = 28;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(6, 34);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(285, 37);
            this.cboTipoPago.TabIndex = 27;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(106, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 57);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(6, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 57);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(6, 151);
            this.txtMonto.MaxLength = 10;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(285, 35);
            this.txtMonto.TabIndex = 22;
            this.txtMonto.Text = "0";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.Enter += new System.EventHandler(this.txtEfec_Enter);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(6, 211);
            this.txtObs.MaxLength = 500;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(285, 90);
            this.txtObs.TabIndex = 16;
            // 
            // btnAct
            // 
            this.btnAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAct.Location = new System.Drawing.Point(227, 307);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(64, 57);
            this.btnAct.TabIndex = 33;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // CAbonar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.NullValue = false;
            this.CAbonar.DefaultCellStyle = dataGridViewCellStyle2;
            this.CAbonar.FillWeight = 40F;
            this.CAbonar.HeaderText = "Abonar";
            this.CAbonar.Name = "CAbonar";
            this.CAbonar.Width = 50;
            // 
            // Frm_AbonosPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 405);
            this.Controls.Add(this.panelPrin);
            this.Name = "Frm_AbonosPOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_AbonosPOS_FormClosing);
            this.Load += new System.EventHandler(this.Frm_AbonosPOS_Load);
            this.panelPrin.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            this.gbxTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.gbxFormaPago.ResumeLayout(false);
            this.gbxFormaPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrin;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.DataGridView dgvDeudas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBusqClient;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox gbxTotales;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label LblPagado;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LblSaldo;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblAbonar;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbxFormaPago;
        private System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CAbonar;

    }
}