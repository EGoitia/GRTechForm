namespace GRTechnology1._0
{
    partial class Frm_Descuento_Promocion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelSup = new System.Windows.Forms.Panel();
            this.chkSelecProd = new System.Windows.Forms.CheckBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.CSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDsctoPromocion = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDscto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxFiltrosBusqProd = new System.Windows.Forms.GroupBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtSubgrupo = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodFab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInf = new System.Windows.Forms.Panel();
            this.dgvPromociones = new System.Windows.Forms.DataGridView();
            this.CPDescuentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPCodInmode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPSubgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFechIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbxFiltrosProm = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboPromSucursal = new System.Windows.Forms.ComboBox();
            this.chkVigentes = new System.Windows.Forms.CheckBox();
            this.btnBuscarProm = new System.Windows.Forms.Button();
            this.txtPromMarca = new System.Windows.Forms.TextBox();
            this.txtPromSubgrupo = new System.Windows.Forms.TextBox();
            this.txtPromGrupo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPromCodFab = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPromProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtHrIni = new System.Windows.Forms.DateTimePicker();
            this.dtHrFin = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel.SuspendLayout();
            this.panelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbxDsctoPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDscto)).BeginInit();
            this.gbxFiltrosBusqProd.SuspendLayout();
            this.panelInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).BeginInit();
            this.gbxFiltrosProm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelSup, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelInf, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(936, 440);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // panelSup
            // 
            this.panelSup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSup.BackColor = System.Drawing.Color.Teal;
            this.panelSup.Controls.Add(this.chkSelecProd);
            this.panelSup.Controls.Add(this.dgvProductos);
            this.panelSup.Controls.Add(this.gbxDsctoPromocion);
            this.panelSup.Controls.Add(this.gbxFiltrosBusqProd);
            this.panelSup.Location = new System.Drawing.Point(3, 3);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(930, 214);
            this.panelSup.TabIndex = 5;
            // 
            // chkSelecProd
            // 
            this.chkSelecProd.AutoSize = true;
            this.chkSelecProd.Location = new System.Drawing.Point(57, 84);
            this.chkSelecProd.Name = "chkSelecProd";
            this.chkSelecProd.Size = new System.Drawing.Size(15, 14);
            this.chkSelecProd.TabIndex = 7;
            this.chkSelecProd.Tag = "Seleccionar Todos";
            this.chkSelecProd.UseVisualStyleBackColor = true;
            this.chkSelecProd.CheckedChanged += new System.EventHandler(this.chkSelecProd_CheckedChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSeleccionar,
            this.CProductoID,
            this.CCodigo,
            this.CProducto,
            this.CUnidad,
            this.CGrupo,
            this.CSubgrupo,
            this.CMarca});
            this.dgvProductos.Location = new System.Drawing.Point(7, 78);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(916, 76);
            this.dgvProductos.TabIndex = 6;
            // 
            // CSeleccionar
            // 
            this.CSeleccionar.FillWeight = 12F;
            this.CSeleccionar.HeaderText = "";
            this.CSeleccionar.Name = "CSeleccionar";
            this.CSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CProductoID
            // 
            this.CProductoID.FillWeight = 35F;
            this.CProductoID.HeaderText = "ID";
            this.CProductoID.Name = "CProductoID";
            this.CProductoID.ReadOnly = true;
            // 
            // CCodigo
            // 
            this.CCodigo.FillWeight = 50F;
            this.CCodigo.HeaderText = "Código";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto";
            this.CProducto.Name = "CProducto";
            this.CProducto.ReadOnly = true;
            // 
            // CUnidad
            // 
            this.CUnidad.FillWeight = 50F;
            this.CUnidad.HeaderText = "Unidad";
            this.CUnidad.Name = "CUnidad";
            this.CUnidad.ReadOnly = true;
            // 
            // CGrupo
            // 
            this.CGrupo.FillWeight = 80F;
            this.CGrupo.HeaderText = "Grupo";
            this.CGrupo.Name = "CGrupo";
            this.CGrupo.ReadOnly = true;
            // 
            // CSubgrupo
            // 
            this.CSubgrupo.FillWeight = 80F;
            this.CSubgrupo.HeaderText = "Subgrupo";
            this.CSubgrupo.Name = "CSubgrupo";
            this.CSubgrupo.ReadOnly = true;
            // 
            // CMarca
            // 
            this.CMarca.FillWeight = 90F;
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            this.CMarca.ReadOnly = true;
            // 
            // gbxDsctoPromocion
            // 
            this.gbxDsctoPromocion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDsctoPromocion.Controls.Add(this.label14);
            this.gbxDsctoPromocion.Controls.Add(this.btnGuardar);
            this.gbxDsctoPromocion.Controls.Add(this.dtFecFin);
            this.gbxDsctoPromocion.Controls.Add(this.dtHrFin);
            this.gbxDsctoPromocion.Controls.Add(this.dtHrIni);
            this.gbxDsctoPromocion.Controls.Add(this.dtFecIni);
            this.gbxDsctoPromocion.Controls.Add(this.cboSucursal);
            this.gbxDsctoPromocion.Controls.Add(this.label8);
            this.gbxDsctoPromocion.Controls.Add(this.label7);
            this.gbxDsctoPromocion.Controls.Add(this.txtDscto);
            this.gbxDsctoPromocion.Controls.Add(this.label6);
            this.gbxDsctoPromocion.Location = new System.Drawing.Point(7, 154);
            this.gbxDsctoPromocion.Name = "gbxDsctoPromocion";
            this.gbxDsctoPromocion.Size = new System.Drawing.Size(916, 55);
            this.gbxDsctoPromocion.TabIndex = 5;
            this.gbxDsctoPromocion.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(607, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 84;
            this.label14.Text = "Sucursal:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(823, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(444, 19);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(98, 20);
            this.dtFecFin.TabIndex = 83;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(219, 19);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(98, 20);
            this.dtFecIni.TabIndex = 83;
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(660, 19);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(155, 21);
            this.cboSucursal.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Fecha Fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Fecha Inicio:";
            // 
            // txtDscto
            // 
            this.txtDscto.DecimalPlaces = 2;
            this.txtDscto.Location = new System.Drawing.Point(70, 19);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.Size = new System.Drawing.Size(60, 20);
            this.txtDscto.TabIndex = 78;
            this.txtDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "% Dscto.:";
            // 
            // gbxFiltrosBusqProd
            // 
            this.gbxFiltrosBusqProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFiltrosBusqProd.Controls.Add(this.btnBuscarProd);
            this.gbxFiltrosBusqProd.Controls.Add(this.txtMarca);
            this.gbxFiltrosBusqProd.Controls.Add(this.txtSubgrupo);
            this.gbxFiltrosBusqProd.Controls.Add(this.txtGrupo);
            this.gbxFiltrosBusqProd.Controls.Add(this.label5);
            this.gbxFiltrosBusqProd.Controls.Add(this.label3);
            this.gbxFiltrosBusqProd.Controls.Add(this.label2);
            this.gbxFiltrosBusqProd.Controls.Add(this.txtCodFab);
            this.gbxFiltrosBusqProd.Controls.Add(this.label4);
            this.gbxFiltrosBusqProd.Controls.Add(this.txtProducto);
            this.gbxFiltrosBusqProd.Controls.Add(this.label1);
            this.gbxFiltrosBusqProd.Location = new System.Drawing.Point(7, 4);
            this.gbxFiltrosBusqProd.Name = "gbxFiltrosBusqProd";
            this.gbxFiltrosBusqProd.Size = new System.Drawing.Size(916, 68);
            this.gbxFiltrosBusqProd.TabIndex = 4;
            this.gbxFiltrosBusqProd.TabStop = false;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(823, 13);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 44);
            this.btnBuscarProd.TabIndex = 86;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(615, 13);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);
            this.txtMarca.TabIndex = 80;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // txtSubgrupo
            // 
            this.txtSubgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupo.Location = new System.Drawing.Point(353, 37);
            this.txtSubgrupo.MaxLength = 50;
            this.txtSubgrupo.Name = "txtSubgrupo";
            this.txtSubgrupo.Size = new System.Drawing.Size(200, 20);
            this.txtSubgrupo.TabIndex = 81;
            this.txtSubgrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // txtGrupo
            // 
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupo.Location = new System.Drawing.Point(353, 14);
            this.txtGrupo.MaxLength = 50;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(200, 20);
            this.txtGrupo.TabIndex = 82;
            this.txtGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Subgrupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Grupo:";
            // 
            // txtCodFab
            // 
            this.txtCodFab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFab.Location = new System.Drawing.Point(70, 40);
            this.txtCodFab.MaxLength = 50;
            this.txtCodFab.Name = "txtCodFab";
            this.txtCodFab.Size = new System.Drawing.Size(92, 20);
            this.txtCodFab.TabIndex = 79;
            this.txtCodFab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Código:";
            // 
            // txtProducto
            // 
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Location = new System.Drawing.Point(70, 16);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 20);
            this.txtProducto.TabIndex = 77;
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Producto:";
            // 
            // panelInf
            // 
            this.panelInf.BackColor = System.Drawing.Color.LightBlue;
            this.panelInf.Controls.Add(this.dgvPromociones);
            this.panelInf.Controls.Add(this.btnEliminar);
            this.panelInf.Controls.Add(this.gbxFiltrosProm);
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInf.Location = new System.Drawing.Point(3, 223);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(930, 214);
            this.panelInf.TabIndex = 6;
            // 
            // dgvPromociones
            // 
            this.dgvPromociones.AllowUserToAddRows = false;
            this.dgvPromociones.AllowUserToDeleteRows = false;
            this.dgvPromociones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromociones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromociones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromociones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPDescuentoID,
            this.CPCodInmode,
            this.CPProductoID,
            this.CPCodigo,
            this.CPProducto,
            this.CPUnidad,
            this.CPMarca,
            this.CPGrupo,
            this.CPSubgrupo,
            this.CPPorcentaje,
            this.CPFechIni,
            this.CPFechaFin,
            this.CPSucursal});
            this.dgvPromociones.Location = new System.Drawing.Point(7, 85);
            this.dgvPromociones.Name = "dgvPromociones";
            this.dgvPromociones.Size = new System.Drawing.Size(916, 91);
            this.dgvPromociones.TabIndex = 9;
            this.dgvPromociones.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPromociones_RowPostPaint);
            // 
            // CPDescuentoID
            // 
            this.CPDescuentoID.HeaderText = "DescuentoID";
            this.CPDescuentoID.Name = "CPDescuentoID";
            this.CPDescuentoID.ReadOnly = true;
            this.CPDescuentoID.Visible = false;
            // 
            // CPCodInmode
            // 
            this.CPCodInmode.HeaderText = "Inmode";
            this.CPCodInmode.Name = "CPCodInmode";
            this.CPCodInmode.ReadOnly = true;
            this.CPCodInmode.Visible = false;
            // 
            // CPProductoID
            // 
            this.CPProductoID.FillWeight = 30F;
            this.CPProductoID.HeaderText = "ID";
            this.CPProductoID.Name = "CPProductoID";
            this.CPProductoID.ReadOnly = true;
            // 
            // CPCodigo
            // 
            this.CPCodigo.FillWeight = 35F;
            this.CPCodigo.HeaderText = "Código";
            this.CPCodigo.Name = "CPCodigo";
            this.CPCodigo.ReadOnly = true;
            // 
            // CPProducto
            // 
            this.CPProducto.HeaderText = "Producto";
            this.CPProducto.Name = "CPProducto";
            this.CPProducto.ReadOnly = true;
            // 
            // CPUnidad
            // 
            this.CPUnidad.FillWeight = 50F;
            this.CPUnidad.HeaderText = "Unidad";
            this.CPUnidad.Name = "CPUnidad";
            this.CPUnidad.ReadOnly = true;
            // 
            // CPMarca
            // 
            this.CPMarca.FillWeight = 80F;
            this.CPMarca.HeaderText = "Marca";
            this.CPMarca.Name = "CPMarca";
            this.CPMarca.ReadOnly = true;
            // 
            // CPGrupo
            // 
            this.CPGrupo.FillWeight = 75F;
            this.CPGrupo.HeaderText = "Grupo";
            this.CPGrupo.Name = "CPGrupo";
            this.CPGrupo.ReadOnly = true;
            // 
            // CPSubgrupo
            // 
            this.CPSubgrupo.FillWeight = 75F;
            this.CPSubgrupo.HeaderText = "Subgrupo";
            this.CPSubgrupo.Name = "CPSubgrupo";
            this.CPSubgrupo.ReadOnly = true;
            // 
            // CPPorcentaje
            // 
            this.CPPorcentaje.FillWeight = 70F;
            this.CPPorcentaje.HeaderText = "% Dscto.";
            this.CPPorcentaje.Name = "CPPorcentaje";
            this.CPPorcentaje.ReadOnly = true;
            // 
            // CPFechIni
            // 
            this.CPFechIni.FillWeight = 80F;
            this.CPFechIni.HeaderText = "Fecha Inicio";
            this.CPFechIni.Name = "CPFechIni";
            this.CPFechIni.ReadOnly = true;
            // 
            // CPFechaFin
            // 
            this.CPFechaFin.FillWeight = 80F;
            this.CPFechaFin.HeaderText = "Fecha Fin";
            this.CPFechaFin.Name = "CPFechaFin";
            this.CPFechaFin.ReadOnly = true;
            // 
            // CPSucursal
            // 
            this.CPSucursal.FillWeight = 90F;
            this.CPSucursal.HeaderText = "Sucursal";
            this.CPSucursal.Name = "CPSucursal";
            this.CPSucursal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(7, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbxFiltrosProm
            // 
            this.gbxFiltrosProm.Controls.Add(this.label15);
            this.gbxFiltrosProm.Controls.Add(this.cboPromSucursal);
            this.gbxFiltrosProm.Controls.Add(this.chkVigentes);
            this.gbxFiltrosProm.Controls.Add(this.btnBuscarProm);
            this.gbxFiltrosProm.Controls.Add(this.txtPromMarca);
            this.gbxFiltrosProm.Controls.Add(this.txtPromSubgrupo);
            this.gbxFiltrosProm.Controls.Add(this.txtPromGrupo);
            this.gbxFiltrosProm.Controls.Add(this.label9);
            this.gbxFiltrosProm.Controls.Add(this.label10);
            this.gbxFiltrosProm.Controls.Add(this.label11);
            this.gbxFiltrosProm.Controls.Add(this.txtPromCodFab);
            this.gbxFiltrosProm.Controls.Add(this.label12);
            this.gbxFiltrosProm.Controls.Add(this.txtPromProducto);
            this.gbxFiltrosProm.Controls.Add(this.label13);
            this.gbxFiltrosProm.Location = new System.Drawing.Point(7, 5);
            this.gbxFiltrosProm.Name = "gbxFiltrosProm";
            this.gbxFiltrosProm.Size = new System.Drawing.Size(916, 73);
            this.gbxFiltrosProm.TabIndex = 0;
            this.gbxFiltrosProm.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(561, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "Sucursal:";
            // 
            // cboPromSucursal
            // 
            this.cboPromSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPromSucursal.FormattingEnabled = true;
            this.cboPromSucursal.Location = new System.Drawing.Point(615, 40);
            this.cboPromSucursal.Name = "cboPromSucursal";
            this.cboPromSucursal.Size = new System.Drawing.Size(200, 21);
            this.cboPromSucursal.TabIndex = 98;
            // 
            // chkVigentes
            // 
            this.chkVigentes.AutoSize = true;
            this.chkVigentes.Checked = true;
            this.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVigentes.Location = new System.Drawing.Point(203, 45);
            this.chkVigentes.Name = "chkVigentes";
            this.chkVigentes.Size = new System.Drawing.Size(67, 17);
            this.chkVigentes.TabIndex = 97;
            this.chkVigentes.Text = "Vigentes";
            this.chkVigentes.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProm
            // 
            this.btnBuscarProm.Location = new System.Drawing.Point(823, 16);
            this.btnBuscarProm.Name = "btnBuscarProm";
            this.btnBuscarProm.Size = new System.Drawing.Size(75, 46);
            this.btnBuscarProm.TabIndex = 96;
            this.btnBuscarProm.Text = "Buscar";
            this.btnBuscarProm.UseVisualStyleBackColor = true;
            this.btnBuscarProm.Click += new System.EventHandler(this.btnBuscarProm_Click);
            // 
            // txtPromMarca
            // 
            this.txtPromMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPromMarca.Location = new System.Drawing.Point(615, 15);
            this.txtPromMarca.MaxLength = 50;
            this.txtPromMarca.Name = "txtPromMarca";
            this.txtPromMarca.Size = new System.Drawing.Size(200, 20);
            this.txtPromMarca.TabIndex = 90;
            this.txtPromMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPromProducto_KeyDown);
            // 
            // txtPromSubgrupo
            // 
            this.txtPromSubgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPromSubgrupo.Location = new System.Drawing.Point(353, 40);
            this.txtPromSubgrupo.MaxLength = 50;
            this.txtPromSubgrupo.Name = "txtPromSubgrupo";
            this.txtPromSubgrupo.Size = new System.Drawing.Size(189, 20);
            this.txtPromSubgrupo.TabIndex = 91;
            this.txtPromSubgrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPromProducto_KeyDown);
            // 
            // txtPromGrupo
            // 
            this.txtPromGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPromGrupo.Location = new System.Drawing.Point(353, 16);
            this.txtPromGrupo.MaxLength = 50;
            this.txtPromGrupo.Name = "txtPromGrupo";
            this.txtPromGrupo.Size = new System.Drawing.Size(189, 20);
            this.txtPromGrupo.TabIndex = 92;
            this.txtPromGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPromProducto_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Marca:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Subgrupo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Grupo:";
            // 
            // txtPromCodFab
            // 
            this.txtPromCodFab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPromCodFab.Location = new System.Drawing.Point(70, 42);
            this.txtPromCodFab.MaxLength = 50;
            this.txtPromCodFab.Name = "txtPromCodFab";
            this.txtPromCodFab.Size = new System.Drawing.Size(92, 20);
            this.txtPromCodFab.TabIndex = 89;
            this.txtPromCodFab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPromProducto_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Código:";
            // 
            // txtPromProducto
            // 
            this.txtPromProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPromProducto.Location = new System.Drawing.Point(70, 18);
            this.txtPromProducto.MaxLength = 50;
            this.txtPromProducto.Name = "txtPromProducto";
            this.txtPromProducto.Size = new System.Drawing.Size(200, 20);
            this.txtPromProducto.TabIndex = 87;
            this.txtPromProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPromProducto_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "Producto:";
            // 
            // dtHrIni
            // 
            this.dtHrIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrIni.Location = new System.Drawing.Point(319, 19);
            this.dtHrIni.Name = "dtHrIni";
            this.dtHrIni.ShowUpDown = true;
            this.dtHrIni.Size = new System.Drawing.Size(50, 20);
            this.dtHrIni.TabIndex = 83;
            // 
            // dtHrFin
            // 
            this.dtHrFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHrFin.Location = new System.Drawing.Point(544, 19);
            this.dtHrFin.Name = "dtHrFin";
            this.dtHrFin.ShowUpDown = true;
            this.dtHrFin.Size = new System.Drawing.Size(50, 20);
            this.dtHrFin.TabIndex = 83;
            // 
            // Frm_Descuento_Promocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 440);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Frm_Descuento_Promocion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento Promocional";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Descuento_Promocion_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Descuento_Promocion_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelSup.ResumeLayout(false);
            this.panelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbxDsctoPromocion.ResumeLayout(false);
            this.gbxDsctoPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDscto)).EndInit();
            this.gbxFiltrosBusqProd.ResumeLayout(false);
            this.gbxFiltrosBusqProd.PerformLayout();
            this.panelInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).EndInit();
            this.gbxFiltrosProm.ResumeLayout(false);
            this.gbxFiltrosProm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gbxDsctoPromocion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtDscto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxFiltrosBusqProd;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtSubgrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodFab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.GroupBox gbxFiltrosProm;
        private System.Windows.Forms.TextBox txtPromMarca;
        private System.Windows.Forms.TextBox txtPromSubgrupo;
        private System.Windows.Forms.TextBox txtPromGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPromCodFab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPromProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnBuscarProm;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPromociones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPDescuentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPCodInmode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPSubgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFechIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPSucursal;
        private System.Windows.Forms.CheckBox chkSelecProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.CheckBox chkVigentes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboPromSucursal;
        private System.Windows.Forms.DateTimePicker dtHrIni;
        private System.Windows.Forms.DateTimePicker dtHrFin;

    }
}