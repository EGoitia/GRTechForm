namespace GRTechnology1._0
{
    partial class Frm_Detalle_Compra
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoCompra = new System.Windows.Forms.ComboBox();
            this.chkTipoCompra = new System.Windows.Forms.CheckBox();
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngrCompra = new System.Windows.Forms.Button();
            this.txtNumCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.gbxTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnModif
            // 
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.txtNumCompra);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Controls.Add(this.chkTipoCompra);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.cboTipoCompra);
            this.gbxFiltro.Controls.Add(this.txtProv);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtProv, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoCompra, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkTipoCompra, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNumCompra, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(736, 23);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Size = new System.Drawing.Size(865, 180);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnIngrCompra);
            this.gbxBotones.Location = new System.Drawing.Point(10, 346);
            this.gbxBotones.Controls.SetChildIndex(this.btnModif, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnRegistro, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnAnul, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpLista, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpNota, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnIngrCompra, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(212, 20);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 7;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(86, 20);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 8;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(19, 21);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(56, 17);
            this.chkFechas.TabIndex = 6;
            this.chkFechas.Text = "Fecha";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // txtProv
            // 
            this.txtProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProv.Location = new System.Drawing.Point(86, 46);
            this.txtProv.MaxLength = 50;
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(223, 20);
            this.txtProv.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proveedor:";
            // 
            // cboTipoCompra
            // 
            this.cboTipoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCompra.Enabled = false;
            this.cboTipoCompra.FormattingEnabled = true;
            this.cboTipoCompra.Location = new System.Drawing.Point(449, 47);
            this.cboTipoCompra.Name = "cboTipoCompra";
            this.cboTipoCompra.Size = new System.Drawing.Size(114, 21);
            this.cboTipoCompra.TabIndex = 12;
            // 
            // chkTipoCompra
            // 
            this.chkTipoCompra.AutoSize = true;
            this.chkTipoCompra.Location = new System.Drawing.Point(354, 49);
            this.chkTipoCompra.Name = "chkTipoCompra";
            this.chkTipoCompra.Size = new System.Drawing.Size(89, 17);
            this.chkTipoCompra.TabIndex = 13;
            this.chkTipoCompra.Text = "Tipo Compra:";
            this.chkTipoCompra.UseVisualStyleBackColor = true;
            this.chkTipoCompra.CheckedChanged += new System.EventHandler(this.chkTipoCompra_CheckedChanged);
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotales.Controls.Add(this.txtMontoTot);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotales.Location = new System.Drawing.Point(10, 297);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(865, 45);
            this.gbxTotales.TabIndex = 9;
            this.gbxTotales.TabStop = false;
            // 
            // txtMontoTot
            // 
            this.txtMontoTot.Location = new System.Drawing.Point(127, 15);
            this.txtMontoTot.MaxLength = 50;
            this.txtMontoTot.Name = "txtMontoTot";
            this.txtMontoTot.ReadOnly = true;
            this.txtMontoTot.Size = new System.Drawing.Size(110, 22);
            this.txtMontoTot.TabIndex = 4;
            this.txtMontoTot.Text = "0.00";
            this.txtMontoTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Compras:";
            // 
            // btnIngrCompra
            // 
            this.btnIngrCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIngrCompra.Location = new System.Drawing.Point(206, 12);
            this.btnIngrCompra.Name = "btnIngrCompra";
            this.btnIngrCompra.Size = new System.Drawing.Size(93, 41);
            this.btnIngrCompra.TabIndex = 1;
            this.btnIngrCompra.Text = "Ingresos Compra";
            this.btnIngrCompra.UseVisualStyleBackColor = true;
            this.btnIngrCompra.Click += new System.EventHandler(this.btnRegul_Click);
            // 
            // txtNumCompra
            // 
            this.txtNumCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumCompra.Location = new System.Drawing.Point(86, 72);
            this.txtNumCompra.MaxLength = 50;
            this.txtNumCompra.Name = "txtNumCompra";
            this.txtNumCompra.Size = new System.Drawing.Size(80, 20);
            this.txtNumCompra.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nº Compra:";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Items.AddRange(new object[] {
            "CONTADO",
            "CREDITO",
            "ANTICIPADO"});
            this.cboSucursal.Location = new System.Drawing.Point(449, 19);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(200, 21);
            this.cboSucursal.TabIndex = 12;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(354, 23);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 13;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(581, 50);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 16;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // Frm_Detalle_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 412);
            this.Controls.Add(this.gbxTotales);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Compra";
            this.Text = "DETALLE DE COMPRAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Compra_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Compra_Load);
            this.Controls.SetChildIndex(this.gbxFiltro, 0);
            this.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.gbxTotales, 0);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTipoCompra;
        private System.Windows.Forms.ComboBox cboTipoCompra;
        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngrCompra;
        private System.Windows.Forms.TextBox txtNumCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkAnulado;
    }
}
