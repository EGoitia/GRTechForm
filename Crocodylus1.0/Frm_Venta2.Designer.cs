namespace GRTechnology1._0
{
    partial class Frm_Venta2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.gbxPedido = new System.Windows.Forms.GroupBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.btnBusqCli = new System.Windows.Forms.Button();
            this.PanelVendedores = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.cProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDcto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CElim = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtDet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTipoProd = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.txtBusqProd = new System.Windows.Forms.TextBox();
            this.lblBusqProd = new System.Windows.Forms.Label();
            this.btnAbrirMenu = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            this.gbxPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.gbxBotones);
            this.panel4.Controls.Add(this.gbxPedido);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(471, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 678);
            this.panel4.TabIndex = 10;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBotones.Controls.Add(this.btnConfig);
            this.gbxBotones.Controls.Add(this.cmbTipoVenta);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Location = new System.Drawing.Point(7, 5);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Size = new System.Drawing.Size(589, 84);
            this.gbxBotones.TabIndex = 6;
            this.gbxBotones.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.Window;
            this.btnConfig.BackgroundImage = global::GRTechnology1._0.Properties.Resources.ajustes_con_engranajes;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Location = new System.Drawing.Point(8, 21);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(46, 45);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // cmbTipoVenta
            // 
            this.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVenta.FormattingEnabled = true;
            this.cmbTipoVenta.Items.AddRange(new object[] {
            "CONTADO",
            "CRÉDITO"});
            this.cmbTipoVenta.Location = new System.Drawing.Point(59, 21);
            this.cmbTipoVenta.Name = "cmbTipoVenta";
            this.cmbTipoVenta.Size = new System.Drawing.Size(228, 45);
            this.cmbTipoVenta.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(383, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 60);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.Location = new System.Drawing.Point(448, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 60);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAct
            // 
            this.btnAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAct.Location = new System.Drawing.Point(514, 14);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(64, 60);
            this.btnAct.TabIndex = 3;
            this.btnAct.Text = "Actualizar";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // gbxPedido
            // 
            this.gbxPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPedido.Controls.Add(this.txtClienteID);
            this.gbxPedido.Controls.Add(this.btnBusqCli);
            this.gbxPedido.Controls.Add(this.PanelVendedores);
            this.gbxPedido.Controls.Add(this.txtTotal);
            this.gbxPedido.Controls.Add(this.dgvPedido);
            this.gbxPedido.Controls.Add(this.txtDet);
            this.gbxPedido.Controls.Add(this.label5);
            this.gbxPedido.Controls.Add(this.txtRef);
            this.gbxPedido.Controls.Add(this.label3);
            this.gbxPedido.Location = new System.Drawing.Point(7, 88);
            this.gbxPedido.Margin = new System.Windows.Forms.Padding(2);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Padding = new System.Windows.Forms.Padding(2);
            this.gbxPedido.Size = new System.Drawing.Size(589, 572);
            this.gbxPedido.TabIndex = 4;
            this.gbxPedido.TabStop = false;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtClienteID.Location = new System.Drawing.Point(119, 17);
            this.txtClienteID.MaxLength = 10;
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(23, 24);
            this.txtClienteID.TabIndex = 21;
            this.txtClienteID.Text = "1";
            this.txtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClienteID.Visible = false;
            // 
            // btnBusqCli
            // 
            this.btnBusqCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqCli.Location = new System.Drawing.Point(540, 17);
            this.btnBusqCli.Name = "btnBusqCli";
            this.btnBusqCli.Size = new System.Drawing.Size(38, 23);
            this.btnBusqCli.TabIndex = 19;
            this.btnBusqCli.Text = "....";
            this.btnBusqCli.UseVisualStyleBackColor = true;
            this.btnBusqCli.Click += new System.EventHandler(this.btnBusqCli_Click);
            // 
            // PanelVendedores
            // 
            this.PanelVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelVendedores.AutoScroll = true;
            this.PanelVendedores.Location = new System.Drawing.Point(8, 96);
            this.PanelVendedores.Name = "PanelVendedores";
            this.PanelVendedores.Size = new System.Drawing.Size(570, 57);
            this.PanelVendedores.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Crimson;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(8, 156);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(278, 37);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "Total Bs.- 0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProdID,
            this.cDesc,
            this.cCantidad,
            this.cPrecio,
            this.cDcto,
            this.cTotal,
            this.CStock,
            this.CElim});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPedido.Location = new System.Drawing.Point(8, 197);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 20;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(577, 364);
            this.dgvPedido.TabIndex = 10;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // cProdID
            // 
            this.cProdID.HeaderText = "ProdID";
            this.cProdID.Name = "cProdID";
            this.cProdID.ReadOnly = true;
            this.cProdID.Visible = false;
            // 
            // cDesc
            // 
            this.cDesc.FillWeight = 180.33F;
            this.cDesc.HeaderText = "Descripcion";
            this.cDesc.Name = "cDesc";
            this.cDesc.ReadOnly = true;
            // 
            // cCantidad
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.cCantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.cCantidad.FillWeight = 63.11548F;
            this.cCantidad.HeaderText = "Peso";
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.ReadOnly = true;
            // 
            // cPrecio
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.cPrecio.DefaultCellStyle = dataGridViewCellStyle10;
            this.cPrecio.FillWeight = 63.11548F;
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.ReadOnly = true;
            // 
            // cDcto
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.cDcto.DefaultCellStyle = dataGridViewCellStyle11;
            this.cDcto.FillWeight = 63.11548F;
            this.cDcto.HeaderText = "Dcto.";
            this.cDcto.Name = "cDcto";
            this.cDcto.ReadOnly = true;
            this.cDcto.Visible = false;
            // 
            // cTotal
            // 
            this.cTotal.FillWeight = 63.11548F;
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            // 
            // CStock
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.CStock.DefaultCellStyle = dataGridViewCellStyle12;
            this.CStock.HeaderText = "Stock";
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            this.CStock.Visible = false;
            // 
            // CElim
            // 
            this.CElim.FillWeight = 35F;
            this.CElim.HeaderText = "Elim.";
            this.CElim.Image = global::GRTechnology1._0.Properties.Resources.quitar;
            this.CElim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.CElim.Name = "CElim";
            this.CElim.ReadOnly = true;
            this.CElim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtDet
            // 
            this.txtDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDet.Location = new System.Drawing.Point(143, 46);
            this.txtDet.Margin = new System.Windows.Forms.Padding(2);
            this.txtDet.MaxLength = 500;
            this.txtDet.Multiline = true;
            this.txtDet.Name = "txtDet";
            this.txtDet.Size = new System.Drawing.Size(435, 45);
            this.txtDet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "DESCRIPCIÓN:";
            // 
            // txtRef
            // 
            this.txtRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(143, 17);
            this.txtRef.Margin = new System.Windows.Forms.Padding(2);
            this.txtRef.MaxLength = 100;
            this.txtRef.Name = "txtRef";
            this.txtRef.ReadOnly = true;
            this.txtRef.Size = new System.Drawing.Size(392, 24);
            this.txtRef.TabIndex = 2;
            this.txtRef.Text = "CLIENTES VARIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "CLIENTE:";
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.Crimson;
            this.panelLeft.Controls.Add(this.panelProductos);
            this.panelLeft.Controls.Add(this.panelTipoProd);
            this.panelLeft.Controls.Add(this.panel5);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(471, 678);
            this.panelLeft.TabIndex = 8;
            // 
            // panelProductos
            // 
            this.panelProductos.AutoScroll = true;
            this.panelProductos.BackColor = System.Drawing.Color.LightGray;
            this.panelProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductos.Location = new System.Drawing.Point(117, 46);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(354, 632);
            this.panelProductos.TabIndex = 10;
            // 
            // panelTipoProd
            // 
            this.panelTipoProd.AutoScroll = true;
            this.panelTipoProd.BackColor = System.Drawing.Color.Silver;
            this.panelTipoProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTipoProd.Location = new System.Drawing.Point(0, 46);
            this.panelTipoProd.Margin = new System.Windows.Forms.Padding(2);
            this.panelTipoProd.Name = "panelTipoProd";
            this.panelTipoProd.Size = new System.Drawing.Size(117, 632);
            this.panelTipoProd.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.lblTipoProd);
            this.panel5.Controls.Add(this.txtBusqProd);
            this.panel5.Controls.Add(this.lblBusqProd);
            this.panel5.Controls.Add(this.btnAbrirMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 46);
            this.panel5.TabIndex = 8;
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProd.Location = new System.Drawing.Point(246, 10);
            this.lblTipoProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(177, 19);
            this.lblTipoProd.TabIndex = 5;
            this.lblTipoProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusqProd
            // 
            this.txtBusqProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBusqProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBusqProd.Location = new System.Drawing.Point(106, 11);
            this.txtBusqProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqProd.MaxLength = 50;
            this.txtBusqProd.Name = "txtBusqProd";
            this.txtBusqProd.Size = new System.Drawing.Size(137, 20);
            this.txtBusqProd.TabIndex = 3;
            // 
            // lblBusqProd
            // 
            this.lblBusqProd.AutoSize = true;
            this.lblBusqProd.Location = new System.Drawing.Point(9, 18);
            this.lblBusqProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqProd.Name = "lblBusqProd";
            this.lblBusqProd.Size = new System.Drawing.Size(109, 13);
            this.lblBusqProd.TabIndex = 4;
            this.lblBusqProd.Text = "Buscar producto........";
            // 
            // btnAbrirMenu
            // 
            this.btnAbrirMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirMenu.BackgroundImage = global::GRTechnology1._0.Properties.Resources.if_menu_24_103174;
            this.btnAbrirMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirMenu.Location = new System.Drawing.Point(438, 4);
            this.btnAbrirMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirMenu.Name = "btnAbrirMenu";
            this.btnAbrirMenu.Size = new System.Drawing.Size(33, 36);
            this.btnAbrirMenu.TabIndex = 2;
            this.btnAbrirMenu.UseVisualStyleBackColor = true;
            this.btnAbrirMenu.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 35F;
            this.dataGridViewImageColumn1.HeaderText = "Elim.";
            this.dataGridViewImageColumn1.Image = global::GRTechnology1._0.Properties.Resources.quitar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 43;
            // 
            // Frm_Venta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 678);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Name = "Frm_Venta2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Venta2_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Venta2_Load);
            this.panel4.ResumeLayout(false);
            this.gbxBotones.ResumeLayout(false);
            this.gbxPedido.ResumeLayout(false);
            this.gbxPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.GroupBox gbxPedido;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.TextBox txtBusqProd;
        private System.Windows.Forms.Label lblBusqProd;
        private System.Windows.Forms.Button btnAbrirMenu;
        private System.Windows.Forms.FlowLayoutPanel panelProductos;
        private System.Windows.Forms.Panel panelTipoProd;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.FlowLayoutPanel PanelVendedores;
        private System.Windows.Forms.Button btnBusqCli;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDcto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewImageColumn CElim;
    }
}