namespace GRTechnology1._0
{
    partial class Frm_Detalle_Traspaso
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
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.chkOrigen = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDestino = new System.Windows.Forms.CheckBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.chkConfirmada = new System.Windows.Forms.CheckBox();
            this.chkAnulada = new System.Windows.Forms.CheckBox();
            this.btnImpListaDetallada = new System.Windows.Forms.Button();
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
            this.btnModif.Text = "Confirmar";
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkAnulada);
            this.gbxFiltro.Controls.Add(this.chkConfirmada);
            this.gbxFiltro.Controls.Add(this.txtDetalle);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.Add(this.cboDestino);
            this.gbxFiltro.Controls.Add(this.chkDestino);
            this.gbxFiltro.Controls.Add(this.cboOrigen);
            this.gbxFiltro.Controls.Add(this.chkOrigen);
            this.gbxFiltro.Size = new System.Drawing.Size(865, 90);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkOrigen, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboOrigen, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkDestino, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboDestino, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtDetalle, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkConfirmada, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkAnulada, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(747, 25);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 100);
            this.dgvDetalle.Size = new System.Drawing.Size(865, 235);
            // 
            // btnImpLista
            // 
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnImpListaDetallada);
            this.gbxBotones.Controls.SetChildIndex(this.btnModif, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnRegistro, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnAnul, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpLista, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpNota, 0);
            this.gbxBotones.Controls.SetChildIndex(this.btnImpListaDetallada, 0);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(471, 12);
            // 
            // cboOrigen
            // 
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(97, 20);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(210, 21);
            this.cboOrigen.TabIndex = 47;
            // 
            // chkOrigen
            // 
            this.chkOrigen.AutoSize = true;
            this.chkOrigen.Checked = true;
            this.chkOrigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOrigen.Location = new System.Drawing.Point(24, 23);
            this.chkOrigen.Name = "chkOrigen";
            this.chkOrigen.Size = new System.Drawing.Size(62, 17);
            this.chkOrigen.TabIndex = 48;
            this.chkOrigen.Text = "Orígen:";
            this.chkOrigen.UseVisualStyleBackColor = true;
            this.chkOrigen.CheckedChanged += new System.EventHandler(this.chkOrigen_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(518, 21);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 50;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(393, 21);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 51;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(331, 22);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(59, 17);
            this.chkFechas.TabIndex = 49;
            this.chkFechas.Text = "Fecha:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // txtDetalle
            // 
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Location = new System.Drawing.Point(392, 52);
            this.txtDetalle.MaxLength = 50;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(222, 20);
            this.txtDetalle.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Detalle:";
            // 
            // chkDestino
            // 
            this.chkDestino.AutoSize = true;
            this.chkDestino.Location = new System.Drawing.Point(24, 54);
            this.chkDestino.Name = "chkDestino";
            this.chkDestino.Size = new System.Drawing.Size(65, 17);
            this.chkDestino.TabIndex = 48;
            this.chkDestino.Text = "Destino:";
            this.chkDestino.UseVisualStyleBackColor = true;
            this.chkDestino.CheckedChanged += new System.EventHandler(this.chkDestino_CheckedChanged);
            // 
            // cboDestino
            // 
            this.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestino.Enabled = false;
            this.cboDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(97, 51);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(210, 21);
            this.cboDestino.TabIndex = 47;
            // 
            // chkConfirmada
            // 
            this.chkConfirmada.AutoSize = true;
            this.chkConfirmada.Checked = true;
            this.chkConfirmada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfirmada.Location = new System.Drawing.Point(633, 23);
            this.chkConfirmada.Name = "chkConfirmada";
            this.chkConfirmada.Size = new System.Drawing.Size(79, 17);
            this.chkConfirmada.TabIndex = 55;
            this.chkConfirmada.Text = "Confirmada";
            this.chkConfirmada.UseVisualStyleBackColor = true;
            // 
            // chkAnulada
            // 
            this.chkAnulada.AutoSize = true;
            this.chkAnulada.Location = new System.Drawing.Point(633, 54);
            this.chkAnulada.Name = "chkAnulada";
            this.chkAnulada.Size = new System.Drawing.Size(65, 17);
            this.chkAnulada.TabIndex = 55;
            this.chkAnulada.Text = "Anulada";
            this.chkAnulada.UseVisualStyleBackColor = true;
            // 
            // btnImpListaDetallada
            // 
            this.btnImpListaDetallada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpListaDetallada.Location = new System.Drawing.Point(568, 12);
            this.btnImpListaDetallada.Name = "btnImpListaDetallada";
            this.btnImpListaDetallada.Size = new System.Drawing.Size(93, 41);
            this.btnImpListaDetallada.TabIndex = 1;
            this.btnImpListaDetallada.Text = "Imprimir Lista Detallada";
            this.btnImpListaDetallada.UseVisualStyleBackColor = true;
            this.btnImpListaDetallada.Click += new System.EventHandler(this.btnImpListaDetallada_Click);
            // 
            // Frm_Detalle_Traspaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 402);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Traspaso";
            this.Text = "DETALLE DE TRASPASOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Traspaso_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Traspaso_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.CheckBox chkOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.CheckBox chkDestino;
        private System.Windows.Forms.CheckBox chkAnulada;
        private System.Windows.Forms.CheckBox chkConfirmada;
        private System.Windows.Forms.Button btnImpListaDetallada;
    }
}
