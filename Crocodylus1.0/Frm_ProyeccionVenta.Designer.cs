namespace GRTechnology1._0
{
    partial class Frm_ProyeccionVenta
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotDias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotProy = new System.Windows.Forms.TextBox();
            this.txtTotEjec = new System.Windows.Forms.TextBox();
            this.txtTotPorcent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.rbSucursal = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDatos1 = new System.Windows.Forms.GroupBox();
            this.txtNumProy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownProyectado = new System.Windows.Forms.NumericUpDown();
            this.txtNomProy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetProyec = new System.Windows.Forms.DataGridView();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.gbxDatos1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownProyectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetProyec)).BeginInit();
            this.gbxTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(778, 354);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 44);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(884, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 44);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotDias
            // 
            this.txtTotDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDias.Location = new System.Drawing.Point(96, 16);
            this.txtTotDias.Name = "txtTotDias";
            this.txtTotDias.ReadOnly = true;
            this.txtTotDias.Size = new System.Drawing.Size(100, 20);
            this.txtTotDias.TabIndex = 45;
            this.txtTotDias.TabStop = false;
            this.txtTotDias.Text = "0.00";
            this.txtTotDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Días Laborales:";
            // 
            // txtTotProy
            // 
            this.txtTotProy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotProy.Location = new System.Drawing.Point(279, 16);
            this.txtTotProy.Name = "txtTotProy";
            this.txtTotProy.ReadOnly = true;
            this.txtTotProy.Size = new System.Drawing.Size(100, 20);
            this.txtTotProy.TabIndex = 43;
            this.txtTotProy.TabStop = false;
            this.txtTotProy.Text = "0.00";
            this.txtTotProy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotEjec
            // 
            this.txtTotEjec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotEjec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotEjec.Location = new System.Drawing.Point(460, 16);
            this.txtTotEjec.Name = "txtTotEjec";
            this.txtTotEjec.ReadOnly = true;
            this.txtTotEjec.Size = new System.Drawing.Size(100, 20);
            this.txtTotEjec.TabIndex = 42;
            this.txtTotEjec.TabStop = false;
            this.txtTotEjec.Text = "0.00";
            this.txtTotEjec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotPorcent
            // 
            this.txtTotPorcent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotPorcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPorcent.Location = new System.Drawing.Point(645, 16);
            this.txtTotPorcent.Name = "txtTotPorcent";
            this.txtTotPorcent.ReadOnly = true;
            this.txtTotPorcent.Size = new System.Drawing.Size(100, 20);
            this.txtTotPorcent.TabIndex = 41;
            this.txtTotPorcent.TabStop = false;
            this.txtTotPorcent.Text = "0.00%";
            this.txtTotPorcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "% Avance:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ejecutado:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Proyectado:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(711, 48);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(90, 47);
            this.btnProcesar.TabIndex = 40;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // rbSucursal
            // 
            this.rbSucursal.AutoSize = true;
            this.rbSucursal.Checked = true;
            this.rbSucursal.Location = new System.Drawing.Point(90, 47);
            this.rbSucursal.Name = "rbSucursal";
            this.rbSucursal.Size = new System.Drawing.Size(66, 17);
            this.rbSucursal.TabIndex = 15;
            this.rbSucursal.TabStop = true;
            this.rbSucursal.Text = "Sucursal";
            this.rbSucursal.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(13, 47);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 14;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            this.rbVendedor.CheckedChanged += new System.EventHandler(this.rbVendedor_CheckedChanged);
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(275, 74);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(102, 20);
            this.dtFecFin.TabIndex = 5;
            // 
            // cboOpcion
            // 
            this.cboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Location = new System.Drawing.Point(240, 43);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(228, 21);
            this.cboOpcion.TabIndex = 2;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(86, 74);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(102, 20);
            this.dtFecIni.TabIndex = 4;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Location = new System.Drawing.Point(183, 48);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(51, 13);
            this.lblOpcion.TabIndex = 0;
            this.lblOpcion.Text = "Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicial:";
            // 
            // gbxDatos1
            // 
            this.gbxDatos1.Controls.Add(this.txtNumProy);
            this.gbxDatos1.Controls.Add(this.label1);
            this.gbxDatos1.Controls.Add(this.dtFecFin);
            this.gbxDatos1.Controls.Add(this.label4);
            this.gbxDatos1.Controls.Add(this.btnProcesar);
            this.gbxDatos1.Controls.Add(this.rbSucursal);
            this.gbxDatos1.Controls.Add(this.dtFecIni);
            this.gbxDatos1.Controls.Add(this.cboOpcion);
            this.gbxDatos1.Controls.Add(this.label3);
            this.gbxDatos1.Controls.Add(this.rbVendedor);
            this.gbxDatos1.Controls.Add(this.numUpDownProyectado);
            this.gbxDatos1.Controls.Add(this.lblOpcion);
            this.gbxDatos1.Controls.Add(this.txtNomProy);
            this.gbxDatos1.Controls.Add(this.label9);
            this.gbxDatos1.Controls.Add(this.label2);
            this.gbxDatos1.Location = new System.Drawing.Point(8, 2);
            this.gbxDatos1.Name = "gbxDatos1";
            this.gbxDatos1.Size = new System.Drawing.Size(976, 105);
            this.gbxDatos1.TabIndex = 38;
            this.gbxDatos1.TabStop = false;
            // 
            // txtNumProy
            // 
            this.txtNumProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumProy.Location = new System.Drawing.Point(871, 20);
            this.txtNumProy.Name = "txtNumProy";
            this.txtNumProy.ReadOnly = true;
            this.txtNumProy.Size = new System.Drawing.Size(71, 21);
            this.txtNumProy.TabIndex = 43;
            this.txtNumProy.Text = "-1";
            this.txtNumProy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumProy.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nº:";
            this.label1.Visible = false;
            // 
            // numUpDownProyectado
            // 
            this.numUpDownProyectado.DecimalPlaces = 2;
            this.numUpDownProyectado.Location = new System.Drawing.Point(711, 17);
            this.numUpDownProyectado.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDownProyectado.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDownProyectado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownProyectado.Name = "numUpDownProyectado";
            this.numUpDownProyectado.Size = new System.Drawing.Size(90, 20);
            this.numUpDownProyectado.TabIndex = 12;
            this.numUpDownProyectado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownProyectado.ThousandsSeparator = true;
            this.numUpDownProyectado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownProyectado.ValueChanged += new System.EventHandler(this.numUpDownProyectado_ValueChanged);
            // 
            // txtNomProy
            // 
            this.txtNomProy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomProy.Location = new System.Drawing.Point(63, 14);
            this.txtNomProy.MaxLength = 50;
            this.txtNomProy.Name = "txtNomProy";
            this.txtNomProy.Size = new System.Drawing.Size(535, 20);
            this.txtNomProy.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proyectado:";
            // 
            // dgvDetProyec
            // 
            this.dgvDetProyec.AllowUserToAddRows = false;
            this.dgvDetProyec.AllowUserToDeleteRows = false;
            this.dgvDetProyec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetProyec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetProyec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetProyec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetProyec.Location = new System.Drawing.Point(8, 113);
            this.dgvDetProyec.MultiSelect = false;
            this.dgvDetProyec.Name = "dgvDetProyec";
            this.dgvDetProyec.ReadOnly = true;
            this.dgvDetProyec.Size = new System.Drawing.Size(976, 235);
            this.dgvDetProyec.TabIndex = 37;
            this.dgvDetProyec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetProyec_CellDoubleClick);
            this.dgvDetProyec.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetProyec_CellValueChanged);
            this.dgvDetProyec.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetProyec_CurrentCellDirtyStateChanged);
            this.dgvDetProyec.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetProyec_EditingControlShowing);
            this.dgvDetProyec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDetProyec_KeyPress);
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxTotales.Controls.Add(this.label8);
            this.gbxTotales.Controls.Add(this.label5);
            this.gbxTotales.Controls.Add(this.label6);
            this.gbxTotales.Controls.Add(this.label7);
            this.gbxTotales.Controls.Add(this.txtTotPorcent);
            this.gbxTotales.Controls.Add(this.txtTotEjec);
            this.gbxTotales.Controls.Add(this.txtTotProy);
            this.gbxTotales.Controls.Add(this.txtTotDias);
            this.gbxTotales.Location = new System.Drawing.Point(8, 354);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(761, 44);
            this.gbxTotales.TabIndex = 46;
            this.gbxTotales.TabStop = false;
            // 
            // Frm_ProyeccionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 406);
            this.Controls.Add(this.gbxTotales);
            this.Controls.Add(this.dgvDetProyec);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDatos1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ProyeccionVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROYECCIÓN DE VENTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proyecciones_FormClosing);
            this.Load += new System.EventHandler(this.Proyecciones_Load);
            this.gbxDatos1.ResumeLayout(false);
            this.gbxDatos1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownProyectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetProyec)).EndInit();
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotProy;
        private System.Windows.Forms.TextBox txtTotEjec;
        private System.Windows.Forms.TextBox txtTotPorcent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbSucursal;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDatos1;
        private System.Windows.Forms.NumericUpDown numUpDownProyectado;
        private System.Windows.Forms.TextBox txtNomProy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetProyec;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumProy;
    }
}