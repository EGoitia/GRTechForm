namespace GRTechnology1._0
{
    partial class Frm_Ingresos_Egresos
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxRecib = new System.Windows.Forms.GroupBox();
            this.panelSelec = new System.Windows.Forms.Panel();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.rbVarios = new System.Windows.Forms.RadioButton();
            this.panelPerActiv = new System.Windows.Forms.Panel();
            this.btnBusqPerActiv = new System.Windows.Forms.Button();
            this.cboPerActiv = new System.Windows.Forms.ComboBox();
            this.lblNomPerActiv = new System.Windows.Forms.Label();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaGastoIngre = new System.Windows.Forms.Button();
            this.cboCuentaIngrEgre = new System.Windows.Forms.ComboBox();
            this.lblGastIng = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxTipPago = new System.Windows.Forms.GroupBox();
            this.rbRecibo = new System.Windows.Forms.RadioButton();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtMontoSus = new System.Windows.Forms.TextBox();
            this.txtMontoBs = new System.Windows.Forms.TextBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTipPago = new System.Windows.Forms.Panel();
            this.panelFacturaRecibo = new System.Windows.Forms.Panel();
            this.gbxBotones.SuspendLayout();
            this.gbxRecib.SuspendLayout();
            this.panelSelec.SuspendLayout();
            this.panelPerActiv.SuspendLayout();
            this.gbxTipPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Location = new System.Drawing.Point(684, 299);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Size = new System.Drawing.Size(186, 100);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 68);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(98, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 68);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxRecib
            // 
            this.gbxRecib.Controls.Add(this.panelSelec);
            this.gbxRecib.Controls.Add(this.panelPerActiv);
            this.gbxRecib.Controls.Add(this.cboCaja);
            this.gbxRecib.Controls.Add(this.label2);
            this.gbxRecib.Controls.Add(this.btnBuscaGastoIngre);
            this.gbxRecib.Controls.Add(this.cboCuentaIngrEgre);
            this.gbxRecib.Controls.Add(this.lblGastIng);
            this.gbxRecib.Controls.Add(this.cboTipo);
            this.gbxRecib.Controls.Add(this.label8);
            this.gbxRecib.Controls.Add(this.txtDetalle);
            this.gbxRecib.Controls.Add(this.txtConcepto);
            this.gbxRecib.Controls.Add(this.label3);
            this.gbxRecib.Controls.Add(this.label1);
            this.gbxRecib.Location = new System.Drawing.Point(6, 3);
            this.gbxRecib.Name = "gbxRecib";
            this.gbxRecib.Size = new System.Drawing.Size(864, 181);
            this.gbxRecib.TabIndex = 1;
            this.gbxRecib.TabStop = false;
            // 
            // panelSelec
            // 
            this.panelSelec.Controls.Add(this.rbActivos);
            this.panelSelec.Controls.Add(this.rbPersonal);
            this.panelSelec.Controls.Add(this.rbVarios);
            this.panelSelec.Location = new System.Drawing.Point(181, 49);
            this.panelSelec.Name = "panelSelec";
            this.panelSelec.Size = new System.Drawing.Size(240, 25);
            this.panelSelec.TabIndex = 47;
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(148, 5);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(84, 17);
            this.rbActivos.TabIndex = 2;
            this.rbActivos.Text = "Activos Fijos";
            this.rbActivos.UseVisualStyleBackColor = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbVarios_CheckedChanged);
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(72, 5);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(66, 17);
            this.rbPersonal.TabIndex = 1;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.CheckedChanged += new System.EventHandler(this.rbVarios_CheckedChanged);
            // 
            // rbVarios
            // 
            this.rbVarios.AutoSize = true;
            this.rbVarios.Checked = true;
            this.rbVarios.Location = new System.Drawing.Point(10, 5);
            this.rbVarios.Name = "rbVarios";
            this.rbVarios.Size = new System.Drawing.Size(54, 17);
            this.rbVarios.TabIndex = 0;
            this.rbVarios.TabStop = true;
            this.rbVarios.Text = "Varios";
            this.rbVarios.UseVisualStyleBackColor = true;
            this.rbVarios.CheckedChanged += new System.EventHandler(this.rbVarios_CheckedChanged);
            // 
            // panelPerActiv
            // 
            this.panelPerActiv.Controls.Add(this.btnBusqPerActiv);
            this.panelPerActiv.Controls.Add(this.cboPerActiv);
            this.panelPerActiv.Controls.Add(this.lblNomPerActiv);
            this.panelPerActiv.Location = new System.Drawing.Point(427, 49);
            this.panelPerActiv.Name = "panelPerActiv";
            this.panelPerActiv.Size = new System.Drawing.Size(432, 25);
            this.panelPerActiv.TabIndex = 46;
            this.panelPerActiv.Visible = false;
            // 
            // btnBusqPerActiv
            // 
            this.btnBusqPerActiv.ImageIndex = 14;
            this.btnBusqPerActiv.Location = new System.Drawing.Point(389, 1);
            this.btnBusqPerActiv.Name = "btnBusqPerActiv";
            this.btnBusqPerActiv.Size = new System.Drawing.Size(35, 23);
            this.btnBusqPerActiv.TabIndex = 46;
            this.btnBusqPerActiv.Text = ".......";
            this.btnBusqPerActiv.UseVisualStyleBackColor = true;
            this.btnBusqPerActiv.Click += new System.EventHandler(this.btnBusqPerActiv_Click);
            // 
            // cboPerActiv
            // 
            this.cboPerActiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerActiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPerActiv.FormattingEnabled = true;
            this.cboPerActiv.Location = new System.Drawing.Point(90, 3);
            this.cboPerActiv.Name = "cboPerActiv";
            this.cboPerActiv.Size = new System.Drawing.Size(293, 21);
            this.cboPerActiv.TabIndex = 44;
            // 
            // lblNomPerActiv
            // 
            this.lblNomPerActiv.Location = new System.Drawing.Point(0, 4);
            this.lblNomPerActiv.Name = "lblNomPerActiv";
            this.lblNomPerActiv.Size = new System.Drawing.Size(84, 19);
            this.lblNomPerActiv.TabIndex = 45;
            this.lblNomPerActiv.Text = "Personal:";
            this.lblNomPerActiv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(77, 84);
            this.cboCaja.Margin = new System.Windows.Forms.Padding(2);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(201, 21);
            this.cboCaja.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Caja:";
            // 
            // btnBuscaGastoIngre
            // 
            this.btnBuscaGastoIngre.ImageIndex = 14;
            this.btnBuscaGastoIngre.Location = new System.Drawing.Point(816, 83);
            this.btnBuscaGastoIngre.Name = "btnBuscaGastoIngre";
            this.btnBuscaGastoIngre.Size = new System.Drawing.Size(35, 23);
            this.btnBuscaGastoIngre.TabIndex = 7;
            this.btnBuscaGastoIngre.Text = ".......";
            this.btnBuscaGastoIngre.UseVisualStyleBackColor = true;
            this.btnBuscaGastoIngre.Click += new System.EventHandler(this.btnBuscaGastoIngre_Click);
            // 
            // cboCuentaIngrEgre
            // 
            this.cboCuentaIngrEgre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaIngrEgre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuentaIngrEgre.FormattingEnabled = true;
            this.cboCuentaIngrEgre.Location = new System.Drawing.Point(356, 84);
            this.cboCuentaIngrEgre.Name = "cboCuentaIngrEgre";
            this.cboCuentaIngrEgre.Size = new System.Drawing.Size(454, 21);
            this.cboCuentaIngrEgre.TabIndex = 6;
            // 
            // lblGastIng
            // 
            this.lblGastIng.AutoSize = true;
            this.lblGastIng.Location = new System.Drawing.Point(302, 90);
            this.lblGastIng.Name = "lblGastIng";
            this.lblGastIng.Size = new System.Drawing.Size(48, 13);
            this.lblGastIng.TabIndex = 22;
            this.lblGastIng.Text = "Egresos:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.cboTipo.Location = new System.Drawing.Point(77, 52);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(94, 21);
            this.cboTipo.TabIndex = 5;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Location = new System.Drawing.Point(77, 122);
            this.txtDetalle.MaxLength = 150;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(774, 44);
            this.txtDetalle.TabIndex = 4;
            // 
            // txtConcepto
            // 
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.Location = new System.Drawing.Point(77, 20);
            this.txtConcepto.MaxLength = 50;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(774, 20);
            this.txtConcepto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concepto:";
            // 
            // gbxTipPago
            // 
            this.gbxTipPago.Controls.Add(this.rbRecibo);
            this.gbxTipPago.Controls.Add(this.rbFactura);
            this.gbxTipPago.Controls.Add(this.txtTC);
            this.gbxTipPago.Controls.Add(this.txtMontoSus);
            this.gbxTipPago.Controls.Add(this.txtMontoBs);
            this.gbxTipPago.Controls.Add(this.cboTipoPago);
            this.gbxTipPago.Controls.Add(this.label4);
            this.gbxTipPago.Controls.Add(this.label10);
            this.gbxTipPago.Controls.Add(this.label6);
            this.gbxTipPago.Controls.Add(this.label5);
            this.gbxTipPago.Location = new System.Drawing.Point(6, 190);
            this.gbxTipPago.Name = "gbxTipPago";
            this.gbxTipPago.Size = new System.Drawing.Size(397, 105);
            this.gbxTipPago.TabIndex = 8;
            this.gbxTipPago.TabStop = false;
            // 
            // rbRecibo
            // 
            this.rbRecibo.AutoSize = true;
            this.rbRecibo.Checked = true;
            this.rbRecibo.Location = new System.Drawing.Point(175, 79);
            this.rbRecibo.Name = "rbRecibo";
            this.rbRecibo.Size = new System.Drawing.Size(59, 17);
            this.rbRecibo.TabIndex = 27;
            this.rbRecibo.TabStop = true;
            this.rbRecibo.Text = "Recibo";
            this.rbRecibo.UseVisualStyleBackColor = true;
            this.rbRecibo.CheckedChanged += new System.EventHandler(this.rbRecibo_CheckedChanged);
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Location = new System.Drawing.Point(77, 79);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(61, 17);
            this.rbFactura.TabIndex = 26;
            this.rbFactura.Text = "Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(335, 49);
            this.txtTC.MaxLength = 5;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(46, 20);
            this.txtTC.TabIndex = 25;
            this.txtTC.Text = "6.96";
            this.txtTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTC.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtMontoSus
            // 
            this.txtMontoSus.Location = new System.Drawing.Point(204, 49);
            this.txtMontoSus.MaxLength = 10;
            this.txtMontoSus.Name = "txtMontoSus";
            this.txtMontoSus.Size = new System.Drawing.Size(74, 20);
            this.txtMontoSus.TabIndex = 24;
            this.txtMontoSus.Text = "0.00";
            this.txtMontoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoSus.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtMontoBs
            // 
            this.txtMontoBs.Location = new System.Drawing.Point(77, 49);
            this.txtMontoBs.MaxLength = 10;
            this.txtMontoBs.Name = "txtMontoBs";
            this.txtMontoBs.Size = new System.Drawing.Size(74, 20);
            this.txtMontoBs.TabIndex = 23;
            this.txtMontoBs.Text = "0.00";
            this.txtMontoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoBs.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.cboTipoPago.Location = new System.Drawing.Point(77, 17);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(201, 21);
            this.cboTipoPago.TabIndex = 22;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "T.C.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "$us.-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Monto Bs.:";
            // 
            // panelTipPago
            // 
            this.panelTipPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTipPago.Location = new System.Drawing.Point(409, 190);
            this.panelTipPago.Name = "panelTipPago";
            this.panelTipPago.Size = new System.Drawing.Size(461, 105);
            this.panelTipPago.TabIndex = 9;
            // 
            // panelFacturaRecibo
            // 
            this.panelFacturaRecibo.Location = new System.Drawing.Point(6, 299);
            this.panelFacturaRecibo.Name = "panelFacturaRecibo";
            this.panelFacturaRecibo.Size = new System.Drawing.Size(600, 140);
            this.panelFacturaRecibo.TabIndex = 10;
            // 
            // Frm_Ingresos_Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.panelFacturaRecibo);
            this.Controls.Add(this.panelTipPago);
            this.Controls.Add(this.gbxRecib);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.gbxTipPago);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Ingresos_Egresos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESOS/EGRESOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReciboIngEgr_FormClosing);
            this.Load += new System.EventHandler(this.ReciboIngEgr_Load);
            this.gbxBotones.ResumeLayout(false);
            this.gbxRecib.ResumeLayout(false);
            this.gbxRecib.PerformLayout();
            this.panelSelec.ResumeLayout(false);
            this.panelSelec.PerformLayout();
            this.panelPerActiv.ResumeLayout(false);
            this.gbxTipPago.ResumeLayout(false);
            this.gbxTipPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.GroupBox gbxRecib;
        private System.Windows.Forms.Button btnBuscaGastoIngre;
        private System.Windows.Forms.ComboBox cboCuentaIngrEgre;
        private System.Windows.Forms.Label lblGastIng;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.GroupBox gbxTipPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPerActiv;
        private System.Windows.Forms.Label lblNomPerActiv;
        private System.Windows.Forms.Panel panelPerActiv;
        private System.Windows.Forms.Button btnBusqPerActiv;
        private System.Windows.Forms.Panel panelTipPago;
        private System.Windows.Forms.Panel panelFacturaRecibo;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoBs;
        private System.Windows.Forms.TextBox txtMontoSus;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.RadioButton rbRecibo;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.Panel panelSelec;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.RadioButton rbVarios;
    }
}