namespace GRTechnology1._0
{
    partial class Frm_Detalle_IngrSalProd
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
            this.lblNumeroIngSal = new System.Windows.Forms.Label();
            this.lblNroCompra = new System.Windows.Forms.Label();
            this.chkTipo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroIngrSal = new System.Windows.Forms.TextBox();
            this.txtNroCompra = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.chkAnulado = new System.Windows.Forms.CheckBox();
            this.chkAlmacen = new System.Windows.Forms.CheckBox();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.btnImpListaDetallado = new System.Windows.Forms.Button();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnModif
            // 
            this.btnModif.Text = "Modificar Costos";
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkAlmacen);
            this.gbxFiltro.Controls.Add(this.cmbAlmacen);
            this.gbxFiltro.Controls.Add(this.chkAnulado);
            this.gbxFiltro.Controls.Add(this.chkTipo);
            this.gbxFiltro.Controls.Add(this.cmbTipo);
            this.gbxFiltro.Controls.Add(this.txtProveedor);
            this.gbxFiltro.Controls.Add(this.txtNroCompra);
            this.gbxFiltro.Controls.Add(this.txtNroIngrSal);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.dtFechaFin);
            this.gbxFiltro.Controls.Add(this.dtFechaIni);
            this.gbxFiltro.Controls.Add(this.chkFecha);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.Add(this.lblNroCompra);
            this.gbxFiltro.Controls.Add(this.lblNumeroIngSal);
            this.gbxFiltro.Size = new System.Drawing.Size(928, 110);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.lblNumeroIngSal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.lblNroCompra, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFecha, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroIngrSal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroCompra, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtProveedor, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cmbTipo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkTipo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulado, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cmbAlmacen, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAlmacen, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(813, 29);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 120);
            this.dgvDetalle.Size = new System.Drawing.Size(928, 200);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(829, 12);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Location = new System.Drawing.Point(730, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnImpListaDetallado);
            this.gbxBotones.Location = new System.Drawing.Point(10, 321);
            this.gbxBotones.Size = new System.Drawing.Size(928, 63);
            this.gbxBotones.Controls.SetChildIndex(this.btnModif, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnRegistro, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnAnul, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpLista, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpNota, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpListaDetallado, 0);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(534, 12);
            // 
            // lblNumeroIngSal
            // 
            this.lblNumeroIngSal.AutoSize = true;
            this.lblNumeroIngSal.Location = new System.Drawing.Point(19, 30);
            this.lblNumeroIngSal.Name = "lblNumeroIngSal";
            this.lblNumeroIngSal.Size = new System.Drawing.Size(56, 13);
            this.lblNumeroIngSal.TabIndex = 1;
            this.lblNumeroIngSal.Text = "Nro. Nota:";
            // 
            // lblNroCompra
            // 
            this.lblNroCompra.AutoSize = true;
            this.lblNroCompra.Location = new System.Drawing.Point(199, 30);
            this.lblNroCompra.Name = "lblNroCompra";
            this.lblNroCompra.Size = new System.Drawing.Size(69, 13);
            this.lblNroCompra.TabIndex = 1;
            this.lblNroCompra.Text = "Nro. Compra:";
            this.lblNroCompra.Visible = false;
            // 
            // chkTipo
            // 
            this.chkTipo.AutoSize = true;
            this.chkTipo.Location = new System.Drawing.Point(377, 56);
            this.chkTipo.Name = "chkTipo";
            this.chkTipo.Size = new System.Drawing.Size(50, 17);
            this.chkTipo.TabIndex = 2;
            this.chkTipo.Text = "Tipo:";
            this.chkTipo.UseVisualStyleBackColor = true;
            this.chkTipo.CheckedChanged += new System.EventHandler(this.chkTipo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedor:";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Location = new System.Drawing.Point(377, 29);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(78, 17);
            this.chkFecha.TabIndex = 4;
            this.chkFecha.Text = "Fecha Del:";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(461, 26);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(100, 20);
            this.dtFechaIni.TabIndex = 5;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(596, 25);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtFechaFin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Al:";
            // 
            // txtNroIngrSal
            // 
            this.txtNroIngrSal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroIngrSal.Location = new System.Drawing.Point(93, 25);
            this.txtNroIngrSal.Name = "txtNroIngrSal";
            this.txtNroIngrSal.Size = new System.Drawing.Size(80, 20);
            this.txtNroIngrSal.TabIndex = 7;
            // 
            // txtNroCompra
            // 
            this.txtNroCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroCompra.Location = new System.Drawing.Point(273, 25);
            this.txtNroCompra.Name = "txtNroCompra";
            this.txtNroCompra.Size = new System.Drawing.Size(80, 20);
            this.txtNroCompra.TabIndex = 8;
            this.txtNroCompra.Visible = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProveedor.Location = new System.Drawing.Point(93, 53);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(260, 20);
            this.txtProveedor.TabIndex = 9;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(461, 53);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(235, 21);
            this.cmbTipo.TabIndex = 10;
            // 
            // chkAnulado
            // 
            this.chkAnulado.AutoSize = true;
            this.chkAnulado.Location = new System.Drawing.Point(288, 83);
            this.chkAnulado.Name = "chkAnulado";
            this.chkAnulado.Size = new System.Drawing.Size(65, 17);
            this.chkAnulado.TabIndex = 11;
            this.chkAnulado.Text = "Anulado";
            this.chkAnulado.UseVisualStyleBackColor = true;
            // 
            // chkAlmacen
            // 
            this.chkAlmacen.AutoSize = true;
            this.chkAlmacen.Checked = true;
            this.chkAlmacen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlmacen.Location = new System.Drawing.Point(377, 83);
            this.chkAlmacen.Name = "chkAlmacen";
            this.chkAlmacen.Size = new System.Drawing.Size(70, 17);
            this.chkAlmacen.TabIndex = 12;
            this.chkAlmacen.Text = "Almacén:";
            this.chkAlmacen.UseVisualStyleBackColor = true;
            this.chkAlmacen.CheckedChanged += new System.EventHandler(this.chkAlmacen_CheckedChanged);
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Location = new System.Drawing.Point(461, 81);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(235, 21);
            this.cmbAlmacen.TabIndex = 13;
            // 
            // btnImpListaDetallado
            // 
            this.btnImpListaDetallado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpListaDetallado.Location = new System.Drawing.Point(632, 12);
            this.btnImpListaDetallado.Name = "btnImpListaDetallado";
            this.btnImpListaDetallado.Size = new System.Drawing.Size(93, 41);
            this.btnImpListaDetallado.TabIndex = 1;
            this.btnImpListaDetallado.Text = "Imprimir Lista Detallado";
            this.btnImpListaDetallado.UseVisualStyleBackColor = true;
            this.btnImpListaDetallado.Click += new System.EventHandler(this.btnImpListaDetallado_Click);
            // 
            // Frm_Detalle_IngrSalProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 388);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_IngrSalProd";
            this.Text = "DETALLE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DetalleIngrSalProd_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DetalleIngrSalProd_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroIngSal;
        private System.Windows.Forms.Label lblNroCompra;
        private System.Windows.Forms.CheckBox chkTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroIngrSal;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtNroCompra;
        private System.Windows.Forms.CheckBox chkAnulado;
        private System.Windows.Forms.CheckBox chkAlmacen;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Button btnImpListaDetallado;
    }
}