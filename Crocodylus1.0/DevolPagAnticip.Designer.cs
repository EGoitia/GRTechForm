namespace GRTechnology1._0
{
    partial class DevolPagAnticip
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
            this.cboOpBusq = new System.Windows.Forms.ComboBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnPag = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPagosAnticip = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDownTC = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numUpDownSus = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownMontoBs = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotDsctoBs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotPagadoBs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSaldoBs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalBs = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDsctoBs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubTotBs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosAnticip)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoBs)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOpBusq);
            this.groupBox1.Controls.Add(this.txtBuscador);
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.btnPag);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboOpBusq
            // 
            this.cboOpBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpBusq.FormattingEnabled = true;
            this.cboOpBusq.Items.AddRange(new object[] {
            "Numero Nota",
            "Cliente",
            "Referencia"});
            this.cboOpBusq.Location = new System.Drawing.Point(230, 55);
            this.cboOpBusq.Name = "cboOpBusq";
            this.cboOpBusq.Size = new System.Drawing.Size(167, 24);
            this.cboOpBusq.TabIndex = 3;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(230, 28);
            this.txtBuscador.MaxLength = 20;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(167, 22);
            this.txtBuscador.TabIndex = 2;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(116, 21);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(99, 60);
            this.btnAct.TabIndex = 1;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnPag
            // 
            this.btnPag.Location = new System.Drawing.Point(15, 21);
            this.btnPag.Name = "btnPag";
            this.btnPag.Size = new System.Drawing.Size(99, 60);
            this.btnPag.TabIndex = 0;
            this.btnPag.Text = "Devolver";
            this.btnPag.UseVisualStyleBackColor = true;
            this.btnPag.Click += new System.EventHandler(this.btnPag_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPagosAnticip);
            this.groupBox3.Location = new System.Drawing.Point(583, 109);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(311, 474);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notas sin Regularizar";
            // 
            // dgvPagosAnticip
            // 
            this.dgvPagosAnticip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagosAnticip.Location = new System.Drawing.Point(13, 22);
            this.dgvPagosAnticip.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPagosAnticip.MultiSelect = false;
            this.dgvPagosAnticip.Name = "dgvPagosAnticip";
            this.dgvPagosAnticip.ReadOnly = true;
            this.dgvPagosAnticip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosAnticip.Size = new System.Drawing.Size(284, 439);
            this.dgvPagosAnticip.TabIndex = 0;
            this.dgvPagosAnticip.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagosAnticip_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cboCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 109);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(566, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(95, 99);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.MaxLength = 100;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(458, 61);
            this.txtObs.TabIndex = 3;
            this.txtObs.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 105);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 17);
            this.label21.TabIndex = 39;
            this.label21.Text = "Obs. ..............";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Enabled = false;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(95, 43);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(341, 24);
            this.cboCliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cliente..........";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(95, 72);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.ReadOnly = true;
            this.txtReferencia.Size = new System.Drawing.Size(458, 22);
            this.txtReferencia.TabIndex = 2;
            this.txtReferencia.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Referencia.............";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(95, 17);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(132, 22);
            this.txtNum.TabIndex = 0;
            this.txtNum.TabStop = false;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero..........";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDet);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cboCaja);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtSuma);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numUpDownTC);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numUpDownSus);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numUpDownMontoBs);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(9, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 183);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Devolucion";
            // 
            // txtDet
            // 
            this.txtDet.Location = new System.Drawing.Point(95, 109);
            this.txtDet.Margin = new System.Windows.Forms.Padding(4);
            this.txtDet.MaxLength = 100;
            this.txtDet.Multiline = true;
            this.txtDet.Name = "txtDet";
            this.txtDet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDet.Size = new System.Drawing.Size(458, 61);
            this.txtDet.TabIndex = 5;
            this.txtDet.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Detalle.........";
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(95, 21);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(341, 24);
            this.cboCaja.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Caja..............";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(95, 80);
            this.txtSuma.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(458, 22);
            this.txtSuma.TabIndex = 4;
            this.txtSuma.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Suma............";
            // 
            // numUpDownTC
            // 
            this.numUpDownTC.DecimalPlaces = 2;
            this.numUpDownTC.Location = new System.Drawing.Point(453, 51);
            this.numUpDownTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownTC.Name = "numUpDownTC";
            this.numUpDownTC.Size = new System.Drawing.Size(100, 22);
            this.numUpDownTC.TabIndex = 3;
            this.numUpDownTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "TC. ......";
            // 
            // numUpDownSus
            // 
            this.numUpDownSus.DecimalPlaces = 2;
            this.numUpDownSus.Location = new System.Drawing.Point(295, 51);
            this.numUpDownSus.Maximum = new decimal(new int[] {
            999000,
            0,
            0,
            0});
            this.numUpDownSus.Name = "numUpDownSus";
            this.numUpDownSus.Size = new System.Drawing.Size(100, 22);
            this.numUpDownSus.TabIndex = 2;
            this.numUpDownSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownSus.ValueChanged += new System.EventHandler(this.numUpDownSus_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Monto Sus.......";
            // 
            // numUpDownMontoBs
            // 
            this.numUpDownMontoBs.DecimalPlaces = 2;
            this.numUpDownMontoBs.Location = new System.Drawing.Point(95, 52);
            this.numUpDownMontoBs.Maximum = new decimal(new int[] {
            999000,
            0,
            0,
            0});
            this.numUpDownMontoBs.Name = "numUpDownMontoBs";
            this.numUpDownMontoBs.Size = new System.Drawing.Size(100, 22);
            this.numUpDownMontoBs.TabIndex = 1;
            this.numUpDownMontoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownMontoBs.ValueChanged += new System.EventHandler(this.numUpDownMontoBs_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Monto Bs.........";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotDsctoBs);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtTotPagadoBs);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtSaldoBs);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtTotalBs);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtDsctoBs);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtSubTotBs);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(9, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(566, 114);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monto";
            // 
            // txtTotDsctoBs
            // 
            this.txtTotDsctoBs.Location = new System.Drawing.Point(427, 21);
            this.txtTotDsctoBs.Name = "txtTotDsctoBs";
            this.txtTotDsctoBs.ReadOnly = true;
            this.txtTotDsctoBs.Size = new System.Drawing.Size(111, 22);
            this.txtTotDsctoBs.TabIndex = 3;
            this.txtTotDsctoBs.TabStop = false;
            this.txtTotDsctoBs.Text = "0.00";
            this.txtTotDsctoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 17);
            this.label13.TabIndex = 63;
            this.label13.Text = "Tot. Dscto Bs. ...................";
            // 
            // txtTotPagadoBs
            // 
            this.txtTotPagadoBs.Location = new System.Drawing.Point(427, 77);
            this.txtTotPagadoBs.Name = "txtTotPagadoBs";
            this.txtTotPagadoBs.ReadOnly = true;
            this.txtTotPagadoBs.Size = new System.Drawing.Size(111, 22);
            this.txtTotPagadoBs.TabIndex = 5;
            this.txtTotPagadoBs.TabStop = false;
            this.txtTotPagadoBs.Text = "0.00";
            this.txtTotPagadoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(255, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 17);
            this.label17.TabIndex = 57;
            this.label17.Text = "Total Pagado Bs. ...............";
            // 
            // txtSaldoBs
            // 
            this.txtSaldoBs.Location = new System.Drawing.Point(427, 49);
            this.txtSaldoBs.Name = "txtSaldoBs";
            this.txtSaldoBs.ReadOnly = true;
            this.txtSaldoBs.Size = new System.Drawing.Size(111, 22);
            this.txtSaldoBs.TabIndex = 4;
            this.txtSaldoBs.TabStop = false;
            this.txtSaldoBs.Text = "0.00";
            this.txtSaldoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(255, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 17);
            this.label16.TabIndex = 54;
            this.label16.Text = "Saldo Bs. ...............................";
            // 
            // txtTotalBs
            // 
            this.txtTotalBs.Location = new System.Drawing.Point(118, 77);
            this.txtTotalBs.Name = "txtTotalBs";
            this.txtTotalBs.ReadOnly = true;
            this.txtTotalBs.Size = new System.Drawing.Size(111, 22);
            this.txtTotalBs.TabIndex = 2;
            this.txtTotalBs.TabStop = false;
            this.txtTotalBs.Text = "0.00";
            this.txtTotalBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Total Bs. ...........";
            // 
            // txtDsctoBs
            // 
            this.txtDsctoBs.Location = new System.Drawing.Point(118, 49);
            this.txtDsctoBs.Name = "txtDsctoBs";
            this.txtDsctoBs.ReadOnly = true;
            this.txtDsctoBs.Size = new System.Drawing.Size(111, 22);
            this.txtDsctoBs.TabIndex = 1;
            this.txtDsctoBs.TabStop = false;
            this.txtDsctoBs.Text = "0.00";
            this.txtDsctoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Dscto. Bs. ..........";
            // 
            // txtSubTotBs
            // 
            this.txtSubTotBs.Location = new System.Drawing.Point(118, 21);
            this.txtSubTotBs.Name = "txtSubTotBs";
            this.txtSubTotBs.ReadOnly = true;
            this.txtSubTotBs.Size = new System.Drawing.Size(111, 22);
            this.txtSubTotBs.TabIndex = 0;
            this.txtSubTotBs.TabStop = false;
            this.txtSubTotBs.Text = "0.00";
            this.txtSubTotBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "SubTotal Bs. .......";
            // 
            // DevolPagAnticip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(904, 591);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DevolPagAnticip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion Pago Anticipado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevolPagAnticip_FormClosing);
            this.Load += new System.EventHandler(this.DevolPagAnticip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosAnticip)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontoBs)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPagosAnticip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnPag;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.ComboBox cboOpBusq;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDownTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numUpDownSus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUpDownMontoBs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubTotBs;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDsctoBs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalBs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotPagadoBs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSaldoBs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.TextBox txtTotDsctoBs;
        private System.Windows.Forms.Label label13;
    }
}