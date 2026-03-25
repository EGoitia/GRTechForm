namespace GRTechnology1._0
{
    partial class Frm_Detalle_Dosificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.chkFechasVenc = new System.Windows.Forms.CheckBox();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoFact = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechasVenc);
            this.gbxFiltro.Controls.Add(this.cboEstado);
            this.gbxFiltro.Controls.Add(this.label5);
            this.gbxFiltro.Controls.Add(this.cboTipoFact);
            this.gbxFiltro.Controls.Add(this.label4);
            this.gbxFiltro.Controls.Add(this.cboActividad);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboActividad, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoFact, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label5, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboEstado, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechasVenc, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeight = 46;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal:";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(96, 17);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(200, 21);
            this.cboSucursal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actividad:";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(386, 44);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(350, 21);
            this.cboActividad.TabIndex = 2;
            // 
            // chkFechasVenc
            // 
            this.chkFechasVenc.AutoSize = true;
            this.chkFechasVenc.Location = new System.Drawing.Point(329, 21);
            this.chkFechasVenc.Name = "chkFechasVenc";
            this.chkFechasVenc.Size = new System.Drawing.Size(142, 17);
            this.chkFechasVenc.TabIndex = 3;
            this.chkFechasVenc.Text = "Fechas Vencimiento del:";
            this.chkFechasVenc.UseVisualStyleBackColor = true;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Enabled = false;
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(477, 18);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(100, 20);
            this.dtFecIni.TabIndex = 4;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Enabled = false;
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(636, 18);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(100, 20);
            this.dtFecFin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Al:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Factura:";
            // 
            // cboTipoFact
            // 
            this.cboTipoFact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFact.FormattingEnabled = true;
            this.cboTipoFact.Location = new System.Drawing.Point(96, 44);
            this.cboTipoFact.Name = "cboTipoFact";
            this.cboTipoFact.Size = new System.Drawing.Size(200, 21);
            this.cboTipoFact.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "[TODAS]",
            "VIGENTE",
            "PASADAS"});
            this.cboEstado.Location = new System.Drawing.Point(96, 71);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(200, 21);
            this.cboEstado.TabIndex = 2;
            // 
            // Frm_Detalle_Dosificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 402);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Dosificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Dosificaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Dosificacion_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Dosificacion_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFechasVenc;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.ComboBox cboTipoFact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label5;
    }
}
