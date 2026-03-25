namespace GRTechnology1._0
{
    partial class Frm_Compra
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBusqProv = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoCompraProd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotCompraSus = new System.Windows.Forms.TextBox();
            this.txtTotCompraBs = new System.Windows.Forms.TextBox();
            this.txtTotCantidad = new System.Windows.Forms.TextBox();
            this.txtTotRecagargoSus = new System.Windows.Forms.TextBox();
            this.txtTotRecagargoBs = new System.Windows.Forms.TextBox();
            this.txtTotProd = new System.Windows.Forms.TextBox();
            this.txtTotImporteSus = new System.Windows.Forms.TextBox();
            this.txtTotImporteBs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelFactRecib = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGastoAdicID = new System.Windows.Forms.TextBox();
            this.rbReciboGasto = new System.Windows.Forms.RadioButton();
            this.rbFacturaGasto = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTCGasto = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtGlosaGasto = new System.Windows.Forms.TextBox();
            this.txtMontoGastoSus = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMontoGastoBs = new System.Windows.Forms.TextBox();
            this.btnBusqProvGasto = new System.Windows.Forms.Button();
            this.cboProveedorGasto = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnBusqGastos = new System.Windows.Forms.Button();
            this.cboGastos = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnModifGasto = new System.Windows.Forms.Button();
            this.BtnAgregarGasto = new System.Windows.Forms.Button();
            this.btnElimGasto = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.btnCerrarGastos = new System.Windows.Forms.Button();
            this.panelGastos = new System.Windows.Forms.Panel();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.rbRecibo = new System.Windows.Forms.RadioButton();
            this.panelSup.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panelGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSup.Size = new System.Drawing.Size(1354, 40);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1200, 10);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(1245, 7);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(91, 82);
            this.txtObs.Size = new System.Drawing.Size(430, 45);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 82);
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.Text = "Glosa:";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.rbFactura);
            this.gbxDatos.Controls.Add(this.rbRecibo);
            this.gbxDatos.Controls.Add(this.dtFecha);
            this.gbxDatos.Controls.Add(this.label4);
            this.gbxDatos.Controls.Add(this.btnBusqProv);
            this.gbxDatos.Controls.Add(this.cboProveedor);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.txtRef);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.cboTipoCompraProd);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Size = new System.Drawing.Size(615, 141);
            this.gbxDatos.Controls.SetChildIndex(this.label6, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtObs, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label2, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboTipoCompraProd, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label3, 0);
            this.gbxDatos.Controls.SetChildIndex(this.txtRef, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label5, 0);
            this.gbxDatos.Controls.SetChildIndex(this.cboProveedor, 0);
            this.gbxDatos.Controls.SetChildIndex(this.btnBusqProv, 0);
            this.gbxDatos.Controls.SetChildIndex(this.label4, 0);
            this.gbxDatos.Controls.SetChildIndex(this.dtFecha, 0);
            this.gbxDatos.Controls.SetChildIndex(this.rbRecibo, 0);
            this.gbxDatos.Controls.SetChildIndex(this.rbFactura, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.Size = new System.Drawing.Size(1402, 23);
            this.lblFecha.Text = "12/10/2019";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.panelFactRecib);
            this.panel3.Controls.Add(this.txtTotCompraSus);
            this.panel3.Controls.Add(this.txtTotCompraBs);
            this.panel3.Controls.Add(this.txtTotCantidad);
            this.panel3.Controls.Add(this.txtTotRecagargoSus);
            this.panel3.Controls.Add(this.txtTotRecagargoBs);
            this.panel3.Controls.Add(this.txtTotProd);
            this.panel3.Controls.Add(this.txtTotImporteSus);
            this.panel3.Controls.Add(this.txtTotImporteBs);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Size = new System.Drawing.Size(586, 433);
            this.panel3.Controls.SetChildIndex(this.label18, 0);
            this.panel3.Controls.SetChildIndex(this.label19, 0);
            this.panel3.Controls.SetChildIndex(this.label20, 0);
            this.panel3.Controls.SetChildIndex(this.label21, 0);
            this.panel3.Controls.SetChildIndex(this.label22, 0);
            this.panel3.Controls.SetChildIndex(this.label23, 0);
            this.panel3.Controls.SetChildIndex(this.label9, 0);
            this.panel3.Controls.SetChildIndex(this.label8, 0);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.label16, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotImporteBs, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotImporteSus, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotProd, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotRecagargoBs, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotRecagargoSus, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotCantidad, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotCompraBs, 0);
            this.panel3.Controls.SetChildIndex(this.txtTotCompraSus, 0);
            this.panel3.Controls.SetChildIndex(this.panelFactRecib, 0);
            this.panel3.Controls.SetChildIndex(this.pbxImg, 0);
            this.panel3.Controls.SetChildIndex(this.gbxDatos, 0);
            this.panel3.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.panel3.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel3.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panel3.Controls.SetChildIndex(this.label17, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Location = new System.Drawing.Point(8, 151);
            this.dgvDetalle.Size = new System.Drawing.Size(570, 190);
            this.dgvDetalle.ColumnHeadersHeight = 46;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(410, 363);
            this.btnGuardar.Size = new System.Drawing.Size(80, 40);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(500, 363);
            this.btnCancelar.Size = new System.Drawing.Size(80, 40);
            // 
            // btnAbriCerrarPanel
            // 
            this.btnAbriCerrarPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAbriCerrarPanel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelGastos);
            this.panel1.Size = new System.Drawing.Size(1354, 433);
            this.panel1.Controls.SetChildIndex(this.panelGastos, 0);
            this.panel1.Controls.SetChildIndex(this.panelBusqProd, 0);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            // 
            // pbxImg
            // 
            this.pbxImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxImg.Location = new System.Drawing.Point(364, 376);
            this.pbxImg.Size = new System.Drawing.Size(50, 50);
            this.pbxImg.Visible = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(492, 16);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(114, 22);
            this.dtFecha.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Fecha Pago:";
            // 
            // btnBusqProv
            // 
            this.btnBusqProv.Location = new System.Drawing.Point(347, 16);
            this.btnBusqProv.Name = "btnBusqProv";
            this.btnBusqProv.Size = new System.Drawing.Size(39, 23);
            this.btnBusqProv.TabIndex = 53;
            this.btnBusqProv.Text = ".....";
            this.btnBusqProv.UseVisualStyleBackColor = true;
            this.btnBusqProv.Click += new System.EventHandler(this.btnBusqProv_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(91, 15);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(250, 24);
            this.cboProveedor.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Proveedor:";
            // 
            // txtRef
            // 
            this.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef.Location = new System.Drawing.Point(91, 48);
            this.txtRef.MaxLength = 50;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(295, 22);
            this.txtRef.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Referencia:";
            // 
            // cboTipoCompraProd
            // 
            this.cboTipoCompraProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCompraProd.FormattingEnabled = true;
            this.cboTipoCompraProd.Location = new System.Drawing.Point(492, 46);
            this.cboTipoCompraProd.Name = "cboTipoCompraProd";
            this.cboTipoCompraProd.Size = new System.Drawing.Size(114, 24);
            this.cboTipoCompraProd.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tipo Compra:";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(325, 354);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 80;
            this.label23.Text = "Sus.";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(325, 382);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 79;
            this.label22.Text = "Sus.";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(325, 410);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 78;
            this.label21.Text = "Sus.";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(193, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 77;
            this.label20.Text = "Bs.";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(193, 382);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "Bs.";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(193, 354);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 75;
            this.label18.Text = "Bs.";
            // 
            // txtTotCompraSus
            // 
            this.txtTotCompraSus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotCompraSus.Location = new System.Drawing.Point(224, 406);
            this.txtTotCompraSus.Name = "txtTotCompraSus";
            this.txtTotCompraSus.ReadOnly = true;
            this.txtTotCompraSus.Size = new System.Drawing.Size(100, 20);
            this.txtTotCompraSus.TabIndex = 73;
            this.txtTotCompraSus.TabStop = false;
            this.txtTotCompraSus.Text = "0.00";
            this.txtTotCompraSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotCompraBs
            // 
            this.txtTotCompraBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotCompraBs.Location = new System.Drawing.Point(92, 406);
            this.txtTotCompraBs.Name = "txtTotCompraBs";
            this.txtTotCompraBs.ReadOnly = true;
            this.txtTotCompraBs.Size = new System.Drawing.Size(100, 20);
            this.txtTotCompraBs.TabIndex = 72;
            this.txtTotCompraBs.TabStop = false;
            this.txtTotCompraBs.Text = "0.00";
            this.txtTotCompraBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotCantidad
            // 
            this.txtTotCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotCantidad.Location = new System.Drawing.Point(447, 378);
            this.txtTotCantidad.Name = "txtTotCantidad";
            this.txtTotCantidad.ReadOnly = true;
            this.txtTotCantidad.Size = new System.Drawing.Size(53, 20);
            this.txtTotCantidad.TabIndex = 74;
            this.txtTotCantidad.TabStop = false;
            this.txtTotCantidad.Text = "0.00";
            this.txtTotCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotRecagargoSus
            // 
            this.txtTotRecagargoSus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotRecagargoSus.Location = new System.Drawing.Point(224, 378);
            this.txtTotRecagargoSus.Name = "txtTotRecagargoSus";
            this.txtTotRecagargoSus.ReadOnly = true;
            this.txtTotRecagargoSus.Size = new System.Drawing.Size(100, 20);
            this.txtTotRecagargoSus.TabIndex = 71;
            this.txtTotRecagargoSus.TabStop = false;
            this.txtTotRecagargoSus.Text = "0.00";
            this.txtTotRecagargoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotRecagargoBs
            // 
            this.txtTotRecagargoBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotRecagargoBs.Location = new System.Drawing.Point(92, 378);
            this.txtTotRecagargoBs.Name = "txtTotRecagargoBs";
            this.txtTotRecagargoBs.ReadOnly = true;
            this.txtTotRecagargoBs.Size = new System.Drawing.Size(100, 20);
            this.txtTotRecagargoBs.TabIndex = 70;
            this.txtTotRecagargoBs.TabStop = false;
            this.txtTotRecagargoBs.Text = "0.00";
            this.txtTotRecagargoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotProd
            // 
            this.txtTotProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotProd.Location = new System.Drawing.Point(447, 351);
            this.txtTotProd.Name = "txtTotProd";
            this.txtTotProd.ReadOnly = true;
            this.txtTotProd.Size = new System.Drawing.Size(53, 20);
            this.txtTotProd.TabIndex = 69;
            this.txtTotProd.TabStop = false;
            this.txtTotProd.Text = "0";
            this.txtTotProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotImporteSus
            // 
            this.txtTotImporteSus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotImporteSus.Location = new System.Drawing.Point(224, 351);
            this.txtTotImporteSus.Name = "txtTotImporteSus";
            this.txtTotImporteSus.ReadOnly = true;
            this.txtTotImporteSus.Size = new System.Drawing.Size(100, 20);
            this.txtTotImporteSus.TabIndex = 68;
            this.txtTotImporteSus.TabStop = false;
            this.txtTotImporteSus.Text = "0.00";
            this.txtTotImporteSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotImporteBs
            // 
            this.txtTotImporteBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotImporteBs.Location = new System.Drawing.Point(92, 351);
            this.txtTotImporteBs.Name = "txtTotImporteBs";
            this.txtTotImporteBs.ReadOnly = true;
            this.txtTotImporteBs.Size = new System.Drawing.Size(100, 20);
            this.txtTotImporteBs.TabIndex = 67;
            this.txtTotImporteBs.TabStop = false;
            this.txtTotImporteBs.Text = "0.00";
            this.txtTotImporteBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 382);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "Total Cantidad:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(361, 355);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 65;
            this.label16.Text = "Total Productos:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Total Global:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Total Recargos:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Total Compra:";
            // 
            // panelFactRecib
            // 
            this.panelFactRecib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFactRecib.Location = new System.Drawing.Point(627, 6);
            this.panelFactRecib.Name = "panelFactRecib";
            this.panelFactRecib.Size = new System.Drawing.Size(134, 141);
            this.panelFactRecib.TabIndex = 81;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvGastos, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 433);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGastos.Location = new System.Drawing.Point(3, 386);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.Size = new System.Drawing.Size(445, 44);
            this.dgvGastos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGastoAdicID);
            this.groupBox1.Controls.Add(this.rbReciboGasto);
            this.groupBox1.Controls.Add(this.rbFacturaGasto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTCGasto);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtGlosaGasto);
            this.groupBox1.Controls.Add(this.txtMontoGastoSus);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtMontoGastoBs);
            this.groupBox1.Controls.Add(this.btnBusqProvGasto);
            this.groupBox1.Controls.Add(this.cboProveedorGasto);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.btnBusqGastos);
            this.groupBox1.Controls.Add(this.cboGastos);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtGastoAdicID
            // 
            this.txtGastoAdicID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGastoAdicID.Location = new System.Drawing.Point(70, 16);
            this.txtGastoAdicID.MaxLength = 100;
            this.txtGastoAdicID.Name = "txtGastoAdicID";
            this.txtGastoAdicID.Size = new System.Drawing.Size(29, 20);
            this.txtGastoAdicID.TabIndex = 26;
            this.txtGastoAdicID.Text = "-1";
            this.txtGastoAdicID.Visible = false;
            // 
            // rbReciboGasto
            // 
            this.rbReciboGasto.AutoSize = true;
            this.rbReciboGasto.Location = new System.Drawing.Point(376, 136);
            this.rbReciboGasto.Name = "rbReciboGasto";
            this.rbReciboGasto.Size = new System.Drawing.Size(59, 17);
            this.rbReciboGasto.TabIndex = 23;
            this.rbReciboGasto.Text = "Recibo";
            this.rbReciboGasto.UseVisualStyleBackColor = true;
            this.rbReciboGasto.CheckedChanged += new System.EventHandler(this.rbReciboGasto_CheckedChanged);
            // 
            // rbFacturaGasto
            // 
            this.rbFacturaGasto.AutoSize = true;
            this.rbFacturaGasto.Checked = true;
            this.rbFacturaGasto.Location = new System.Drawing.Point(297, 136);
            this.rbFacturaGasto.Name = "rbFacturaGasto";
            this.rbFacturaGasto.Size = new System.Drawing.Size(61, 17);
            this.rbFacturaGasto.TabIndex = 23;
            this.rbFacturaGasto.TabStop = true;
            this.rbFacturaGasto.Text = "Factura";
            this.rbFacturaGasto.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "T.C.:";
            // 
            // txtTCGasto
            // 
            this.txtTCGasto.Location = new System.Drawing.Point(385, 107);
            this.txtTCGasto.MaxLength = 5;
            this.txtTCGasto.Name = "txtTCGasto";
            this.txtTCGasto.Size = new System.Drawing.Size(50, 20);
            this.txtTCGasto.TabIndex = 24;
            this.txtTCGasto.Text = "6.96";
            this.txtTCGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTCGasto.TextChanged += new System.EventHandler(this.txtMontoGasto_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 85);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Glosa:";
            // 
            // txtGlosaGasto
            // 
            this.txtGlosaGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGlosaGasto.Location = new System.Drawing.Point(70, 78);
            this.txtGlosaGasto.MaxLength = 100;
            this.txtGlosaGasto.Name = "txtGlosaGasto";
            this.txtGlosaGasto.Size = new System.Drawing.Size(365, 20);
            this.txtGlosaGasto.TabIndex = 21;
            // 
            // txtMontoGastoSus
            // 
            this.txtMontoGastoSus.Location = new System.Drawing.Point(196, 107);
            this.txtMontoGastoSus.MaxLength = 10;
            this.txtMontoGastoSus.Name = "txtMontoGastoSus";
            this.txtMontoGastoSus.Size = new System.Drawing.Size(75, 20);
            this.txtMontoGastoSus.TabIndex = 18;
            this.txtMontoGastoSus.Text = "0.00";
            this.txtMontoGastoSus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoGastoSus.TextChanged += new System.EventHandler(this.txtMontoGasto_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Monto:";
            // 
            // txtMontoGastoBs
            // 
            this.txtMontoGastoBs.Location = new System.Drawing.Point(70, 107);
            this.txtMontoGastoBs.MaxLength = 9;
            this.txtMontoGastoBs.Name = "txtMontoGastoBs";
            this.txtMontoGastoBs.Size = new System.Drawing.Size(75, 20);
            this.txtMontoGastoBs.TabIndex = 16;
            this.txtMontoGastoBs.Text = "0.00";
            this.txtMontoGastoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMontoGastoBs.TextChanged += new System.EventHandler(this.txtMontoGasto_TextChanged);
            // 
            // btnBusqProvGasto
            // 
            this.btnBusqProvGasto.Location = new System.Drawing.Point(394, 14);
            this.btnBusqProvGasto.Name = "btnBusqProvGasto";
            this.btnBusqProvGasto.Size = new System.Drawing.Size(41, 23);
            this.btnBusqProvGasto.TabIndex = 15;
            this.btnBusqProvGasto.Text = ".....";
            this.btnBusqProvGasto.UseVisualStyleBackColor = true;
            this.btnBusqProvGasto.Click += new System.EventHandler(this.btnBusqProvGasto_Click);
            // 
            // cboProveedorGasto
            // 
            this.cboProveedorGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedorGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedorGasto.FormattingEnabled = true;
            this.cboProveedorGasto.Location = new System.Drawing.Point(70, 16);
            this.cboProveedorGasto.Name = "cboProveedorGasto";
            this.cboProveedorGasto.Size = new System.Drawing.Size(316, 21);
            this.cboProveedorGasto.TabIndex = 13;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "Proveedor:";
            // 
            // btnBusqGastos
            // 
            this.btnBusqGastos.Location = new System.Drawing.Point(394, 45);
            this.btnBusqGastos.Name = "btnBusqGastos";
            this.btnBusqGastos.Size = new System.Drawing.Size(41, 23);
            this.btnBusqGastos.TabIndex = 2;
            this.btnBusqGastos.Text = "....";
            this.btnBusqGastos.UseVisualStyleBackColor = true;
            this.btnBusqGastos.Click += new System.EventHandler(this.btnBusqGastos_Click);
            // 
            // cboGastos
            // 
            this.cboGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGastos.FormattingEnabled = true;
            this.cboGastos.Location = new System.Drawing.Point(70, 47);
            this.cboGastos.Name = "cboGastos";
            this.cboGastos.Size = new System.Drawing.Size(316, 21);
            this.cboGastos.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Gasto:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(146, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(22, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Bs.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(274, 111);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "$us";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnModifGasto, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnAgregarGasto, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnElimGasto, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 351);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(445, 29);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnModifGasto
            // 
            this.btnModifGasto.Location = new System.Drawing.Point(363, 3);
            this.btnModifGasto.Name = "btnModifGasto";
            this.btnModifGasto.Size = new System.Drawing.Size(29, 23);
            this.btnModifGasto.TabIndex = 3;
            this.btnModifGasto.Text = "-";
            this.btnModifGasto.UseVisualStyleBackColor = true;
            this.btnModifGasto.Click += new System.EventHandler(this.btnModifGasto_Click);
            // 
            // BtnAgregarGasto
            // 
            this.BtnAgregarGasto.Location = new System.Drawing.Point(328, 3);
            this.BtnAgregarGasto.Name = "BtnAgregarGasto";
            this.BtnAgregarGasto.Size = new System.Drawing.Size(29, 23);
            this.BtnAgregarGasto.TabIndex = 2;
            this.BtnAgregarGasto.Text = "+";
            this.BtnAgregarGasto.UseVisualStyleBackColor = true;
            this.BtnAgregarGasto.Click += new System.EventHandler(this.BtnAgregarGasto_Click);
            // 
            // btnElimGasto
            // 
            this.btnElimGasto.Location = new System.Drawing.Point(398, 3);
            this.btnElimGasto.Name = "btnElimGasto";
            this.btnElimGasto.Size = new System.Drawing.Size(29, 23);
            this.btnElimGasto.TabIndex = 0;
            this.btnElimGasto.Text = "x";
            this.btnElimGasto.UseVisualStyleBackColor = true;
            this.btnElimGasto.Click += new System.EventHandler(this.btnElimGasto_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnCerrarGastos, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(445, 34);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.SteelBlue;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(43, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(399, 34);
            this.label30.TabIndex = 9;
            this.label30.Text = "GASTOS";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrarGastos
            // 
            this.btnCerrarGastos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrarGastos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarGastos.Location = new System.Drawing.Point(3, 3);
            this.btnCerrarGastos.Name = "btnCerrarGastos";
            this.btnCerrarGastos.Size = new System.Drawing.Size(34, 28);
            this.btnCerrarGastos.TabIndex = 8;
            this.btnCerrarGastos.Text = ">>>";
            this.btnCerrarGastos.UseVisualStyleBackColor = false;
            this.btnCerrarGastos.Click += new System.EventHandler(this.btnCerrarGastos_Click);
            // 
            // panelGastos
            // 
            this.panelGastos.Controls.Add(this.tableLayoutPanel2);
            this.panelGastos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGastos.Location = new System.Drawing.Point(903, 0);
            this.panelGastos.Name = "panelGastos";
            this.panelGastos.Size = new System.Drawing.Size(451, 433);
            this.panelGastos.TabIndex = 65;
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Checked = true;
            this.rbFactura.Location = new System.Drawing.Point(535, 80);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(71, 20);
            this.rbFactura.TabIndex = 56;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            this.rbFactura.CheckedChanged += new System.EventHandler(this.rbFactura_CheckedChanged);
            // 
            // rbRecibo
            // 
            this.rbRecibo.AutoSize = true;
            this.rbRecibo.Location = new System.Drawing.Point(535, 104);
            this.rbRecibo.Name = "rbRecibo";
            this.rbRecibo.Size = new System.Drawing.Size(70, 20);
            this.rbRecibo.TabIndex = 57;
            this.rbRecibo.Text = "Recibo";
            this.rbRecibo.UseVisualStyleBackColor = true;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1354, 473);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Compra";
            this.Text = "COMPRA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Compra_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Compra_Load);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panelGastos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBusqProv;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoCompraProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotCompraSus;
        private System.Windows.Forms.TextBox txtTotCompraBs;
        private System.Windows.Forms.TextBox txtTotCantidad;
        private System.Windows.Forms.TextBox txtTotRecagargoSus;
        private System.Windows.Forms.TextBox txtTotRecagargoBs;
        private System.Windows.Forms.TextBox txtTotProd;
        private System.Windows.Forms.TextBox txtTotImporteSus;
        private System.Windows.Forms.TextBox txtTotImporteBs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelFactRecib;
        private System.Windows.Forms.Panel panelGastos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGastoAdicID;
        private System.Windows.Forms.RadioButton rbReciboGasto;
        private System.Windows.Forms.RadioButton rbFacturaGasto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTCGasto;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtGlosaGasto;
        private System.Windows.Forms.TextBox txtMontoGastoSus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMontoGastoBs;
        private System.Windows.Forms.Button btnBusqProvGasto;
        private System.Windows.Forms.ComboBox cboProveedorGasto;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnBusqGastos;
        private System.Windows.Forms.ComboBox cboGastos;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnModifGasto;
        private System.Windows.Forms.Button BtnAgregarGasto;
        private System.Windows.Forms.Button btnElimGasto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnCerrarGastos;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.RadioButton rbRecibo;
    }
}
