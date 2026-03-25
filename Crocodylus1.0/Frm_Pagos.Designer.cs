namespace GRTechnology1._0
{
    partial class Frm_Pagos
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
            this.txtEfectivoBs = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.txtMontoSus = new System.Windows.Forms.TextBox();
            this.txtMontoBs = new System.Windows.Forms.TextBox();
            this.TxtTipoCambioCo = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtTipoCambioVe = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtTipoCambioOf = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.LblMonedaPrin = new System.Windows.Forms.Label();
            this.LblMonedaEqui = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEfectivo = new System.Windows.Forms.Panel();
            this.LblEfectivoEqui = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMonedaEqui3 = new System.Windows.Forms.Label();
            this.txtEfectivoSus = new System.Windows.Forms.TextBox();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.TxtNroRef1 = new System.Windows.Forms.MaskedTextBox();
            this.txtTarjetaBs = new System.Windows.Forms.TextBox();
            this.CmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtTarjetaSus = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.LblMonedaEqui6 = new System.Windows.Forms.Label();
            this.panelCheque = new System.Windows.Forms.Panel();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.cmbBancoCheque = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNroCheque = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.panelDeposito = new System.Windows.Forms.Panel();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.cmbBancoDeposito = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNroDeposito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelTransferencia = new System.Windows.Forms.Panel();
            this.txtTranferencia = new System.Windows.Forms.TextBox();
            this.cmbBancoTransferencia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNroCpte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.txtCambioBs = new System.Windows.Forms.TextBox();
            this.txtTotalPagado = new System.Windows.Forms.TextBox();
            this.txtCambioSus = new System.Windows.Forms.TextBox();
            this.LblIgual = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LblMonedaEqui5 = new System.Windows.Forms.Label();
            this.LblMoneda9 = new System.Windows.Forms.Label();
            this.LblMoneda10 = new System.Windows.Forms.Label();
            this.gbxDatos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelEfectivo.SuspendLayout();
            this.panelTarjeta.SuspendLayout();
            this.panelCheque.SuspendLayout();
            this.panelDeposito.SuspendLayout();
            this.panelTransferencia.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEfectivoBs
            // 
            this.txtEfectivoBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoBs.Location = new System.Drawing.Point(146, 14);
            this.txtEfectivoBs.MaxLength = 15;
            this.txtEfectivoBs.Name = "txtEfectivoBs";
            this.txtEfectivoBs.Size = new System.Drawing.Size(136, 29);
            this.txtEfectivoBs.TabIndex = 1;
            this.txtEfectivoBs.Text = "0.00";
            this.txtEfectivoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEfectivoBs.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(707, 20);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 58);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(814, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 58);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.BtnCalculadora);
            this.gbxDatos.Controls.Add(this.txtMontoSus);
            this.gbxDatos.Controls.Add(this.txtMontoBs);
            this.gbxDatos.Controls.Add(this.TxtTipoCambioCo);
            this.gbxDatos.Controls.Add(this.Label5);
            this.gbxDatos.Controls.Add(this.TxtTipoCambioVe);
            this.gbxDatos.Controls.Add(this.Label3);
            this.gbxDatos.Controls.Add(this.TxtTipoCambioOf);
            this.gbxDatos.Controls.Add(this.Label2);
            this.gbxDatos.Controls.Add(this.lbltc);
            this.gbxDatos.Controls.Add(this.LblMonedaPrin);
            this.gbxDatos.Controls.Add(this.LblMonedaEqui);
            this.gbxDatos.Location = new System.Drawing.Point(7, 6);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Size = new System.Drawing.Size(710, 107);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalculadora.FlatAppearance.BorderSize = 0;
            this.BtnCalculadora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculadora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculadora.Image = global::GRTechnology1._0.Properties.Resources.calculadora;
            this.BtnCalculadora.Location = new System.Drawing.Point(656, 31);
            this.BtnCalculadora.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.BtnCalculadora.Size = new System.Drawing.Size(46, 67);
            this.BtnCalculadora.TabIndex = 11;
            this.BtnCalculadora.UseVisualStyleBackColor = false;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // txtMontoSus
            // 
            this.txtMontoSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoSus.Location = new System.Drawing.Point(184, 60);
            this.txtMontoSus.MaxLength = 15;
            this.txtMontoSus.Name = "txtMontoSus";
            this.txtMontoSus.ReadOnly = true;
            this.txtMontoSus.Size = new System.Drawing.Size(136, 29);
            this.txtMontoSus.TabIndex = 2;
            this.txtMontoSus.Text = "0.00";
            this.txtMontoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMontoBs
            // 
            this.txtMontoBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoBs.Location = new System.Drawing.Point(184, 26);
            this.txtMontoBs.MaxLength = 15;
            this.txtMontoBs.Name = "txtMontoBs";
            this.txtMontoBs.ReadOnly = true;
            this.txtMontoBs.Size = new System.Drawing.Size(136, 29);
            this.txtMontoBs.TabIndex = 1;
            this.txtMontoBs.Text = "0.00";
            this.txtMontoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtTipoCambioCo
            // 
            this.TxtTipoCambioCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TxtTipoCambioCo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTipoCambioCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoCambioCo.Location = new System.Drawing.Point(594, 74);
            this.TxtTipoCambioCo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipoCambioCo.Name = "TxtTipoCambioCo";
            this.TxtTipoCambioCo.ReadOnly = true;
            this.TxtTipoCambioCo.Size = new System.Drawing.Size(56, 26);
            this.TxtTipoCambioCo.TabIndex = 10;
            this.TxtTipoCambioCo.TabStop = false;
            this.TxtTipoCambioCo.Text = "6.96";
            this.TxtTipoCambioCo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(464, 74);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(131, 24);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Cambio Compra:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtTipoCambioVe
            // 
            this.TxtTipoCambioVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(160)))));
            this.TxtTipoCambioVe.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTipoCambioVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoCambioVe.Location = new System.Drawing.Point(594, 46);
            this.TxtTipoCambioVe.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipoCambioVe.Name = "TxtTipoCambioVe";
            this.TxtTipoCambioVe.ReadOnly = true;
            this.TxtTipoCambioVe.Size = new System.Drawing.Size(56, 26);
            this.TxtTipoCambioVe.TabIndex = 9;
            this.TxtTipoCambioVe.TabStop = false;
            this.TxtTipoCambioVe.Text = "6.96";
            this.TxtTipoCambioVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(464, 46);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(131, 24);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Cambio Venta:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtTipoCambioOf
            // 
            this.TxtTipoCambioOf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(198)))));
            this.TxtTipoCambioOf.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTipoCambioOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoCambioOf.Location = new System.Drawing.Point(594, 18);
            this.TxtTipoCambioOf.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTipoCambioOf.Name = "TxtTipoCambioOf";
            this.TxtTipoCambioOf.ReadOnly = true;
            this.TxtTipoCambioOf.Size = new System.Drawing.Size(56, 26);
            this.TxtTipoCambioOf.TabIndex = 8;
            this.TxtTipoCambioOf.TabStop = false;
            this.TxtTipoCambioOf.Text = "6.96";
            this.TxtTipoCambioOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 27);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(184, 24);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Monto a Cobrar:";
            // 
            // lbltc
            // 
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltc.Location = new System.Drawing.Point(464, 18);
            this.lbltc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(131, 24);
            this.lbltc.TabIndex = 5;
            this.lbltc.Text = "Cambio Oficial:";
            this.lbltc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblMonedaPrin
            // 
            this.LblMonedaPrin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonedaPrin.Location = new System.Drawing.Point(325, 63);
            this.LblMonedaPrin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonedaPrin.Name = "LblMonedaPrin";
            this.LblMonedaPrin.Size = new System.Drawing.Size(52, 23);
            this.LblMonedaPrin.TabIndex = 4;
            this.LblMonedaPrin.Text = "$us.";
            // 
            // LblMonedaEqui
            // 
            this.LblMonedaEqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LblMonedaEqui.Location = new System.Drawing.Point(326, 28);
            this.LblMonedaEqui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonedaEqui.Name = "LblMonedaEqui";
            this.LblMonedaEqui.Size = new System.Drawing.Size(52, 23);
            this.LblMonedaEqui.TabIndex = 3;
            this.LblMonedaEqui.Text = "Bs.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelEfectivo);
            this.flowLayoutPanel1.Controls.Add(this.panelTarjeta);
            this.flowLayoutPanel1.Controls.Add(this.panelCheque);
            this.flowLayoutPanel1.Controls.Add(this.panelDeposito);
            this.flowLayoutPanel1.Controls.Add(this.panelTransferencia);
            this.flowLayoutPanel1.Controls.Add(this.panelTotal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 119);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 395);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelEfectivo
            // 
            this.panelEfectivo.Controls.Add(this.txtEfectivoBs);
            this.panelEfectivo.Controls.Add(this.LblEfectivoEqui);
            this.panelEfectivo.Controls.Add(this.label4);
            this.panelEfectivo.Controls.Add(this.LblMonedaEqui3);
            this.panelEfectivo.Controls.Add(this.txtEfectivoSus);
            this.panelEfectivo.Location = new System.Drawing.Point(2, 2);
            this.panelEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.panelEfectivo.Name = "panelEfectivo";
            this.panelEfectivo.Size = new System.Drawing.Size(938, 53);
            this.panelEfectivo.TabIndex = 0;
            // 
            // LblEfectivoEqui
            // 
            this.LblEfectivoEqui.AutoSize = true;
            this.LblEfectivoEqui.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEfectivoEqui.Location = new System.Drawing.Point(13, 15);
            this.LblEfectivoEqui.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEfectivoEqui.Name = "LblEfectivoEqui";
            this.LblEfectivoEqui.Size = new System.Drawing.Size(112, 26);
            this.LblEfectivoEqui.TabIndex = 0;
            this.LblEfectivoEqui.Text = "Efectivo Bs:";
            this.LblEfectivoEqui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "=";
            // 
            // LblMonedaEqui3
            // 
            this.LblMonedaEqui3.AutoSize = true;
            this.LblMonedaEqui3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonedaEqui3.Location = new System.Drawing.Point(450, 17);
            this.LblMonedaEqui3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonedaEqui3.Name = "LblMonedaEqui3";
            this.LblMonedaEqui3.Size = new System.Drawing.Size(48, 26);
            this.LblMonedaEqui3.TabIndex = 4;
            this.LblMonedaEqui3.Text = "$us.";
            // 
            // txtEfectivoSus
            // 
            this.txtEfectivoSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoSus.Location = new System.Drawing.Point(310, 14);
            this.txtEfectivoSus.MaxLength = 15;
            this.txtEfectivoSus.Name = "txtEfectivoSus";
            this.txtEfectivoSus.Size = new System.Drawing.Size(136, 29);
            this.txtEfectivoSus.TabIndex = 3;
            this.txtEfectivoSus.Text = "0.00";
            this.txtEfectivoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEfectivoSus.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.Controls.Add(this.TxtNroRef1);
            this.panelTarjeta.Controls.Add(this.txtTarjetaBs);
            this.panelTarjeta.Controls.Add(this.CmbTipoTarjeta);
            this.panelTarjeta.Controls.Add(this.label1);
            this.panelTarjeta.Controls.Add(this.Label11);
            this.panelTarjeta.Controls.Add(this.txtTarjetaSus);
            this.panelTarjeta.Controls.Add(this.Label23);
            this.panelTarjeta.Controls.Add(this.LblMonedaEqui6);
            this.panelTarjeta.Location = new System.Drawing.Point(2, 59);
            this.panelTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(938, 57);
            this.panelTarjeta.TabIndex = 1;
            // 
            // TxtNroRef1
            // 
            this.TxtNroRef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtNroRef1.Location = new System.Drawing.Point(576, 15);
            this.TxtNroRef1.Mask = "0000-0000";
            this.TxtNroRef1.Name = "TxtNroRef1";
            this.TxtNroRef1.Size = new System.Drawing.Size(124, 29);
            this.TxtNroRef1.TabIndex = 8;
            // 
            // txtTarjetaBs
            // 
            this.txtTarjetaBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaBs.Location = new System.Drawing.Point(146, 15);
            this.txtTarjetaBs.MaxLength = 15;
            this.txtTarjetaBs.Name = "txtTarjetaBs";
            this.txtTarjetaBs.Size = new System.Drawing.Size(136, 29);
            this.txtTarjetaBs.TabIndex = 1;
            this.txtTarjetaBs.Text = "0.00";
            this.txtTarjetaBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarjetaBs.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // CmbTipoTarjeta
            // 
            this.CmbTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoTarjeta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoTarjeta.FormattingEnabled = true;
            this.CmbTipoTarjeta.Location = new System.Drawing.Point(721, 16);
            this.CmbTipoTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoTarjeta.Name = "CmbTipoTarjeta";
            this.CmbTipoTarjeta.Size = new System.Drawing.Size(204, 27);
            this.CmbTipoTarjeta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(13, 17);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(107, 26);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Tarjeta Bs.:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTarjetaSus
            // 
            this.txtTarjetaSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaSus.Location = new System.Drawing.Point(310, 15);
            this.txtTarjetaSus.MaxLength = 15;
            this.txtTarjetaSus.Name = "txtTarjetaSus";
            this.txtTarjetaSus.Size = new System.Drawing.Size(136, 29);
            this.txtTarjetaSus.TabIndex = 3;
            this.txtTarjetaSus.Text = "0.00";
            this.txtTarjetaSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarjetaSus.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.Location = new System.Drawing.Point(504, 17);
            this.Label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(71, 23);
            this.Label23.TabIndex = 5;
            this.Label23.Text = "Nº Ref.:";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblMonedaEqui6
            // 
            this.LblMonedaEqui6.AutoSize = true;
            this.LblMonedaEqui6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonedaEqui6.Location = new System.Drawing.Point(449, 17);
            this.LblMonedaEqui6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonedaEqui6.Name = "LblMonedaEqui6";
            this.LblMonedaEqui6.Size = new System.Drawing.Size(48, 26);
            this.LblMonedaEqui6.TabIndex = 4;
            this.LblMonedaEqui6.Text = "$us.";
            // 
            // panelCheque
            // 
            this.panelCheque.Controls.Add(this.txtCheque);
            this.panelCheque.Controls.Add(this.cmbBancoCheque);
            this.panelCheque.Controls.Add(this.label6);
            this.panelCheque.Controls.Add(this.TxtNroCheque);
            this.panelCheque.Controls.Add(this.Label25);
            this.panelCheque.Controls.Add(this.Label26);
            this.panelCheque.Location = new System.Drawing.Point(2, 120);
            this.panelCheque.Margin = new System.Windows.Forms.Padding(2);
            this.panelCheque.Name = "panelCheque";
            this.panelCheque.Size = new System.Drawing.Size(938, 51);
            this.panelCheque.TabIndex = 2;
            // 
            // txtCheque
            // 
            this.txtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.Location = new System.Drawing.Point(146, 11);
            this.txtCheque.MaxLength = 15;
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(136, 29);
            this.txtCheque.TabIndex = 1;
            this.txtCheque.Text = "0.00";
            this.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheque.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // cmbBancoCheque
            // 
            this.cmbBancoCheque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancoCheque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBancoCheque.FormattingEnabled = true;
            this.cmbBancoCheque.Location = new System.Drawing.Point(721, 11);
            this.cmbBancoCheque.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBancoCheque.Name = "cmbBancoCheque";
            this.cmbBancoCheque.Size = new System.Drawing.Size(204, 27);
            this.cmbBancoCheque.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bs.";
            // 
            // TxtNroCheque
            // 
            this.TxtNroCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtNroCheque.Location = new System.Drawing.Point(576, 7);
            this.TxtNroCheque.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNroCheque.MaxLength = 20;
            this.TxtNroCheque.Name = "TxtNroCheque";
            this.TxtNroCheque.Size = new System.Drawing.Size(126, 29);
            this.TxtNroCheque.TabIndex = 4;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.Color.Transparent;
            this.Label25.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.Location = new System.Drawing.Point(13, 13);
            this.Label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(84, 26);
            this.Label25.TabIndex = 0;
            this.Label25.Text = "Cheque:";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(466, 10);
            this.Label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(100, 23);
            this.Label26.TabIndex = 3;
            this.Label26.Text = "Nº Cheque:";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDeposito
            // 
            this.panelDeposito.Controls.Add(this.txtDeposito);
            this.panelDeposito.Controls.Add(this.cmbBancoDeposito);
            this.panelDeposito.Controls.Add(this.label7);
            this.panelDeposito.Controls.Add(this.TxtNroDeposito);
            this.panelDeposito.Controls.Add(this.label8);
            this.panelDeposito.Controls.Add(this.label10);
            this.panelDeposito.Location = new System.Drawing.Point(2, 175);
            this.panelDeposito.Margin = new System.Windows.Forms.Padding(2);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(938, 51);
            this.panelDeposito.TabIndex = 3;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(146, 11);
            this.txtDeposito.MaxLength = 15;
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(136, 29);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.Text = "0.00";
            this.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeposito.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // cmbBancoDeposito
            // 
            this.cmbBancoDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancoDeposito.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBancoDeposito.FormattingEnabled = true;
            this.cmbBancoDeposito.Location = new System.Drawing.Point(721, 8);
            this.cmbBancoDeposito.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBancoDeposito.Name = "cmbBancoDeposito";
            this.cmbBancoDeposito.Size = new System.Drawing.Size(204, 27);
            this.cmbBancoDeposito.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bs.";
            // 
            // TxtNroDeposito
            // 
            this.TxtNroDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtNroDeposito.Location = new System.Drawing.Point(576, 6);
            this.TxtNroDeposito.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNroDeposito.MaxLength = 20;
            this.TxtNroDeposito.Name = "TxtNroDeposito";
            this.TxtNroDeposito.Size = new System.Drawing.Size(126, 29);
            this.TxtNroDeposito.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Depósito:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nº Depósito:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTransferencia
            // 
            this.panelTransferencia.Controls.Add(this.txtTranferencia);
            this.panelTransferencia.Controls.Add(this.cmbBancoTransferencia);
            this.panelTransferencia.Controls.Add(this.label9);
            this.panelTransferencia.Controls.Add(this.TxtNroCpte);
            this.panelTransferencia.Controls.Add(this.label12);
            this.panelTransferencia.Controls.Add(this.label13);
            this.panelTransferencia.Location = new System.Drawing.Point(2, 230);
            this.panelTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.panelTransferencia.Name = "panelTransferencia";
            this.panelTransferencia.Size = new System.Drawing.Size(938, 51);
            this.panelTransferencia.TabIndex = 4;
            // 
            // txtTranferencia
            // 
            this.txtTranferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranferencia.Location = new System.Drawing.Point(146, 11);
            this.txtTranferencia.MaxLength = 15;
            this.txtTranferencia.Name = "txtTranferencia";
            this.txtTranferencia.Size = new System.Drawing.Size(136, 29);
            this.txtTranferencia.TabIndex = 1;
            this.txtTranferencia.Text = "0.00";
            this.txtTranferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTranferencia.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // cmbBancoTransferencia
            // 
            this.cmbBancoTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancoTransferencia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBancoTransferencia.FormattingEnabled = true;
            this.cmbBancoTransferencia.Location = new System.Drawing.Point(721, 8);
            this.cmbBancoTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBancoTransferencia.Name = "cmbBancoTransferencia";
            this.cmbBancoTransferencia.Size = new System.Drawing.Size(204, 27);
            this.cmbBancoTransferencia.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bs.";
            // 
            // TxtNroCpte
            // 
            this.TxtNroCpte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroCpte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtNroCpte.Location = new System.Drawing.Point(576, 6);
            this.TxtNroCpte.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNroCpte.MaxLength = 20;
            this.TxtNroCpte.Name = "TxtNroCpte";
            this.TxtNroCpte.Size = new System.Drawing.Size(126, 29);
            this.TxtNroCpte.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Transferencia:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(466, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nº Cpte.:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.txtCambioBs);
            this.panelTotal.Controls.Add(this.txtTotalPagado);
            this.panelTotal.Controls.Add(this.txtCambioSus);
            this.panelTotal.Controls.Add(this.btnCancelar);
            this.panelTotal.Controls.Add(this.btnPagar);
            this.panelTotal.Controls.Add(this.LblIgual);
            this.panelTotal.Controls.Add(this.label14);
            this.panelTotal.Controls.Add(this.label15);
            this.panelTotal.Controls.Add(this.LblMonedaEqui5);
            this.panelTotal.Controls.Add(this.LblMoneda9);
            this.panelTotal.Controls.Add(this.LblMoneda10);
            this.panelTotal.Location = new System.Drawing.Point(2, 285);
            this.panelTotal.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(938, 98);
            this.panelTotal.TabIndex = 5;
            // 
            // txtCambioBs
            // 
            this.txtCambioBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioBs.Location = new System.Drawing.Point(146, 50);
            this.txtCambioBs.MaxLength = 15;
            this.txtCambioBs.Name = "txtCambioBs";
            this.txtCambioBs.ReadOnly = true;
            this.txtCambioBs.Size = new System.Drawing.Size(136, 29);
            this.txtCambioBs.TabIndex = 4;
            this.txtCambioBs.Text = "0.00";
            this.txtCambioBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagado.Location = new System.Drawing.Point(146, 12);
            this.txtTotalPagado.MaxLength = 15;
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.ReadOnly = true;
            this.txtTotalPagado.Size = new System.Drawing.Size(136, 29);
            this.txtTotalPagado.TabIndex = 1;
            this.txtTotalPagado.Text = "0.00";
            this.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCambioSus
            // 
            this.txtCambioSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioSus.Location = new System.Drawing.Point(364, 49);
            this.txtCambioSus.MaxLength = 15;
            this.txtCambioSus.Name = "txtCambioSus";
            this.txtCambioSus.ReadOnly = true;
            this.txtCambioSus.Size = new System.Drawing.Size(136, 29);
            this.txtCambioSus.TabIndex = 7;
            this.txtCambioSus.Text = "0.00";
            this.txtCambioSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblIgual
            // 
            this.LblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIgual.Location = new System.Drawing.Point(332, 50);
            this.LblIgual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblIgual.Name = "LblIgual";
            this.LblIgual.Size = new System.Drawing.Size(23, 23);
            this.LblIgual.TabIndex = 6;
            this.LblIgual.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Pagado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 51);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "CAMBIO:";
            // 
            // LblMonedaEqui5
            // 
            this.LblMonedaEqui5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonedaEqui5.Location = new System.Drawing.Point(505, 51);
            this.LblMonedaEqui5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMonedaEqui5.Name = "LblMonedaEqui5";
            this.LblMonedaEqui5.Size = new System.Drawing.Size(57, 23);
            this.LblMonedaEqui5.TabIndex = 8;
            this.LblMonedaEqui5.Text = "$us.";
            // 
            // LblMoneda9
            // 
            this.LblMoneda9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneda9.Location = new System.Drawing.Point(282, 14);
            this.LblMoneda9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMoneda9.Name = "LblMoneda9";
            this.LblMoneda9.Size = new System.Drawing.Size(57, 23);
            this.LblMoneda9.TabIndex = 2;
            this.LblMoneda9.Text = "Bs.";
            this.LblMoneda9.Visible = false;
            // 
            // LblMoneda10
            // 
            this.LblMoneda10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoneda10.Location = new System.Drawing.Point(282, 50);
            this.LblMoneda10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMoneda10.Name = "LblMoneda10";
            this.LblMoneda10.Size = new System.Drawing.Size(57, 23);
            this.LblMoneda10.TabIndex = 5;
            this.LblMoneda10.Text = "Bs.";
            // 
            // Frm_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(956, 527);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Pagos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Frm_Pagos_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelEfectivo.ResumeLayout(false);
            this.panelEfectivo.PerformLayout();
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            this.panelCheque.ResumeLayout(false);
            this.panelCheque.PerformLayout();
            this.panelDeposito.ResumeLayout(false);
            this.panelDeposito.PerformLayout();
            this.panelTransferencia.ResumeLayout(false);
            this.panelTransferencia.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtEfectivoBs;
        internal System.Windows.Forms.GroupBox gbxDatos;
        internal System.Windows.Forms.Button BtnCalculadora;
        internal System.Windows.Forms.TextBox TxtTipoCambioCo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtTipoCambioVe;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtTipoCambioOf;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbltc;
        internal System.Windows.Forms.Label LblMonedaPrin;
        internal System.Windows.Forms.Label LblMonedaEqui;
        public System.Windows.Forms.TextBox txtMontoSus;
        public System.Windows.Forms.TextBox txtMontoBs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelEfectivo;
        internal System.Windows.Forms.Label LblEfectivoEqui;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label LblMonedaEqui3;
        public System.Windows.Forms.TextBox txtEfectivoSus;
        private System.Windows.Forms.Panel panelTarjeta;
        internal System.Windows.Forms.ComboBox CmbTipoTarjeta;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label LblMonedaEqui6;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTarjetaSus;
        public System.Windows.Forms.TextBox txtTarjetaBs;
        private System.Windows.Forms.Panel panelCheque;
        internal System.Windows.Forms.TextBox TxtNroCheque;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        public System.Windows.Forms.TextBox txtCheque;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDeposito;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox TxtNroDeposito;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtDeposito;
        internal System.Windows.Forms.ComboBox cmbBancoCheque;
        internal System.Windows.Forms.ComboBox cmbBancoDeposito;
        private System.Windows.Forms.Panel panelTransferencia;
        internal System.Windows.Forms.ComboBox cmbBancoTransferencia;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox TxtNroCpte;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtTranferencia;
        private System.Windows.Forms.Panel panelTotal;
        internal System.Windows.Forms.Label LblIgual;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label LblMonedaEqui5;
        internal System.Windows.Forms.Label LblMoneda9;
        internal System.Windows.Forms.Label LblMoneda10;
        public System.Windows.Forms.TextBox txtCambioSus;
        public System.Windows.Forms.TextBox txtCambioBs;
        public System.Windows.Forms.TextBox txtTotalPagado;
        public System.Windows.Forms.MaskedTextBox TxtNroRef1;
    }
}