namespace GRTechnology1._0
{
    partial class Frm_Libro_Ventas
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
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.txtNumIni = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAutorizacion = new System.Windows.Forms.TextBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtICETot = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIVATot = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDsctoTot = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFin)).BeginInit();
            this.gbxTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.cboTipoFactura);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.cboActividad);
            this.gbxFiltro.Controls.Add(this.label8);
            this.gbxFiltro.Controls.Add(this.txtAutorizacion);
            this.gbxFiltro.Controls.Add(this.label7);
            this.gbxFiltro.Controls.Add(this.txtNIT);
            this.gbxFiltro.Controls.Add(this.label6);
            this.gbxFiltro.Controls.Add(this.label5);
            this.gbxFiltro.Controls.Add(this.label4);
            this.gbxFiltro.Controls.Add(this.txtNombre);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.txtNumFin);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtNumIni);
            this.gbxFiltro.Controls.Add(this.chkNumeros);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.Add(this.dtFechaFin);
            this.gbxFiltro.Controls.Add(this.dtFechaIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Size = new System.Drawing.Size(865, 130);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkNumeros, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNumIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNumFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNombre, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label5, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label6, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNIT, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label7, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtAutorizacion, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label8, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboActividad, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoFactura, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeight = 46;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 141);
            this.dgvDetalle.Size = new System.Drawing.Size(865, 143);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(21, 19);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(81, 17);
            this.chkFechas.TabIndex = 1;
            this.chkFechas.Text = "Fechas del:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(111, 16);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(100, 20);
            this.dtFechaIni.TabIndex = 2;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(254, 16);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtFechaFin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Al:";
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Location = new System.Drawing.Point(20, 46);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(88, 17);
            this.chkNumeros.TabIndex = 5;
            this.chkNumeros.Text = "Números del:";
            this.chkNumeros.UseVisualStyleBackColor = true;
            this.chkNumeros.CheckedChanged += new System.EventHandler(this.chkNumeros_CheckedChanged);
            // 
            // txtNumIni
            // 
            this.txtNumIni.Enabled = false;
            this.txtNumIni.Location = new System.Drawing.Point(111, 43);
            this.txtNumIni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumIni.Name = "txtNumIni";
            this.txtNumIni.Size = new System.Drawing.Size(100, 20);
            this.txtNumIni.TabIndex = 6;
            this.txtNumIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Al:";
            // 
            // txtNumFin
            // 
            this.txtNumFin.Enabled = false;
            this.txtNumFin.Location = new System.Drawing.Point(254, 43);
            this.txtNumFin.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumFin.Name = "txtNumFin";
            this.txtNumFin.Size = new System.Drawing.Size(100, 20);
            this.txtNumFin.TabIndex = 8;
            this.txtNumFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(453, 97);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // txtAutorizacion
            // 
            this.txtAutorizacion.Location = new System.Drawing.Point(453, 16);
            this.txtAutorizacion.Name = "txtAutorizacion";
            this.txtAutorizacion.Size = new System.Drawing.Size(280, 20);
            this.txtAutorizacion.TabIndex = 12;
            this.txtAutorizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(453, 42);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(280, 21);
            this.cboActividad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nit:";
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(453, 71);
            this.txtNIT.MaxLength = 30;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(121, 20);
            this.txtNIT.TabIndex = 10;
            this.txtNIT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Autorización:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Actividad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sucursal:";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(111, 71);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(243, 21);
            this.cboSucursal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo Facturación";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(111, 97);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(243, 21);
            this.cboTipoFactura.TabIndex = 13;
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtICETot);
            this.gbxTotales.Controls.Add(this.label12);
            this.gbxTotales.Controls.Add(this.txtIVATot);
            this.gbxTotales.Controls.Add(this.label11);
            this.gbxTotales.Controls.Add(this.txtDsctoTot);
            this.gbxTotales.Controls.Add(this.label9);
            this.gbxTotales.Controls.Add(this.txtMontoTot);
            this.gbxTotales.Controls.Add(this.label10);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotales.Location = new System.Drawing.Point(10, 287);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(865, 45);
            this.gbxTotales.TabIndex = 9;
            this.gbxTotales.TabStop = false;
            // 
            // txtICETot
            // 
            this.txtICETot.Location = new System.Drawing.Point(744, 17);
            this.txtICETot.MaxLength = 50;
            this.txtICETot.Name = "txtICETot";
            this.txtICETot.ReadOnly = true;
            this.txtICETot.Size = new System.Drawing.Size(110, 22);
            this.txtICETot.TabIndex = 4;
            this.txtICETot.Text = "0.00";
            this.txtICETot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total I.C.E:";
            // 
            // txtIVATot
            // 
            this.txtIVATot.Location = new System.Drawing.Point(532, 16);
            this.txtIVATot.MaxLength = 50;
            this.txtIVATot.Name = "txtIVATot";
            this.txtIVATot.ReadOnly = true;
            this.txtIVATot.Size = new System.Drawing.Size(110, 22);
            this.txtIVATot.TabIndex = 4;
            this.txtIVATot.Text = "0.00";
            this.txtIVATot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total IVA:";
            // 
            // txtDsctoTot
            // 
            this.txtDsctoTot.Location = new System.Drawing.Point(330, 15);
            this.txtDsctoTot.MaxLength = 50;
            this.txtDsctoTot.Name = "txtDsctoTot";
            this.txtDsctoTot.ReadOnly = true;
            this.txtDsctoTot.Size = new System.Drawing.Size(110, 22);
            this.txtDsctoTot.TabIndex = 4;
            this.txtDsctoTot.Text = "0.00";
            this.txtDsctoTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total Dscto.:";
            // 
            // txtMontoTot
            // 
            this.txtMontoTot.Location = new System.Drawing.Point(108, 15);
            this.txtMontoTot.MaxLength = 50;
            this.txtMontoTot.Name = "txtMontoTot";
            this.txtMontoTot.ReadOnly = true;
            this.txtMontoTot.Size = new System.Drawing.Size(110, 22);
            this.txtMontoTot.TabIndex = 4;
            this.txtMontoTot.Text = "0.00";
            this.txtMontoTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Monto:";
            // 
            // Frm_Libro_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 402);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Libro_Ventas";
            this.Text = "Libro de Ventas";
            this.Load += new System.EventHandler(this.Frm_Libro_Ventas_Load);
            this.Controls.SetChildIndex(this.gbxFiltro, 0);
            this.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.gbxTotales, 0);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumFin)).EndInit();
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.NumericUpDown txtNumIni;
        private System.Windows.Forms.NumericUpDown txtNumFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.TextBox txtAutorizacion;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtDsctoTot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtICETot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIVATot;
        private System.Windows.Forms.Label label11;
    }
}
