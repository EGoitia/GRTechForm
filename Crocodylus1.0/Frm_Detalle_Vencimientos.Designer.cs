namespace GRTechnology1._0
{
    partial class Frm_Detalle_Vencimientos
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
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodFab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubgrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNroLote = new System.Windows.Forms.TextBox();
            this.chkFechaVenc = new System.Windows.Forms.CheckBox();
            this.dtFechaVencIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaVencFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.chkCantVigente = new System.Windows.Forms.CheckBox();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(550, 12);
            this.btnAnul.Visible = false;
            // 
            // btnModif
            // 
            this.btnModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModif.Location = new System.Drawing.Point(929, 13);
            this.btnModif.Text = "Guardar";
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkCantVigente);
            this.gbxFiltro.Controls.Add(this.dtFechaVencFin);
            this.gbxFiltro.Controls.Add(this.dtFecFin);
            this.gbxFiltro.Controls.Add(this.dtFechaVencIni);
            this.gbxFiltro.Controls.Add(this.dtFecIni);
            this.gbxFiltro.Controls.Add(this.label8);
            this.gbxFiltro.Controls.Add(this.label6);
            this.gbxFiltro.Controls.Add(this.chkFechaVenc);
            this.gbxFiltro.Controls.Add(this.chkFechas);
            this.gbxFiltro.Controls.Add(this.txtSubgrupo);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.txtMarca);
            this.gbxFiltro.Controls.Add(this.txtGrupo);
            this.gbxFiltro.Controls.Add(this.label5);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtNroLote);
            this.gbxFiltro.Controls.Add(this.label7);
            this.gbxFiltro.Controls.Add(this.txtCodFab);
            this.gbxFiltro.Controls.Add(this.label4);
            this.gbxFiltro.Controls.Add(this.txtProducto);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Controls.Add(this.cboSucursal);
            this.gbxFiltro.Controls.Add(this.chkSucursal);
            this.gbxFiltro.Size = new System.Drawing.Size(1033, 115);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboSucursal, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtProducto, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtCodFab, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label7, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtNroLote, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label5, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtGrupo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtMarca, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtSubgrupo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechas, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkFechaVenc, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label6, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label8, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaVencIni, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFecFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.dtFechaVencFin, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.chkCantVigente, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(927, 55);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 132);
            this.dgvDetalle.ReadOnly = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1033, 200);
            this.dgvDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellValueChanged);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Location = new System.Drawing.Point(646, 13);
            this.btnImpNota.Visible = false;
            // 
            // btnImpLista
            // 
            this.btnImpLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImpLista.Location = new System.Drawing.Point(113, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Size = new System.Drawing.Size(1033, 63);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistro.Location = new System.Drawing.Point(14, 12);
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(93, 19);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(228, 21);
            this.cboSucursal.TabIndex = 47;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Checked = true;
            this.chkSucursal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSucursal.Location = new System.Drawing.Point(20, 22);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(70, 17);
            this.chkSucursal.TabIndex = 48;
            this.chkSucursal.Text = "Sucursal:";
            this.chkSucursal.UseVisualStyleBackColor = true;
            this.chkSucursal.CheckedChanged += new System.EventHandler(this.chkSucursal_CheckedChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(397, 77);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);
            this.txtMarca.TabIndex = 80;
            // 
            // txtGrupo
            // 
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupo.Location = new System.Drawing.Point(397, 48);
            this.txtGrupo.MaxLength = 50;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(200, 20);
            this.txtGrupo.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Grupo:";
            // 
            // txtCodFab
            // 
            this.txtCodFab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFab.Location = new System.Drawing.Point(93, 77);
            this.txtCodFab.MaxLength = 50;
            this.txtCodFab.Name = "txtCodFab";
            this.txtCodFab.Size = new System.Drawing.Size(92, 20);
            this.txtCodFab.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Código:";
            // 
            // txtProducto
            // 
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Location = new System.Drawing.Point(93, 48);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(228, 20);
            this.txtProducto.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Producto:";
            // 
            // txtSubgrupo
            // 
            this.txtSubgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupo.Location = new System.Drawing.Point(397, 19);
            this.txtSubgrupo.MaxLength = 50;
            this.txtSubgrupo.Name = "txtSubgrupo";
            this.txtSubgrupo.Size = new System.Drawing.Size(200, 20);
            this.txtSubgrupo.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Subgrupo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Al";
            // 
            // dtFecFin
            // 
            this.dtFecFin.Enabled = false;
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(821, 27);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(97, 20);
            this.dtFecFin.TabIndex = 87;
            // 
            // dtFecIni
            // 
            this.dtFecIni.Enabled = false;
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(696, 27);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(97, 20);
            this.dtFecIni.TabIndex = 88;
            // 
            // chkFechas
            // 
            this.chkFechas.Location = new System.Drawing.Point(611, 20);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(85, 40);
            this.chkFechas.TabIndex = 86;
            this.chkFechas.Text = "Fecha Fabricación:";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Nº Lote:";
            // 
            // txtNroLote
            // 
            this.txtNroLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroLote.Location = new System.Drawing.Point(249, 77);
            this.txtNroLote.MaxLength = 50;
            this.txtNroLote.Name = "txtNroLote";
            this.txtNroLote.Size = new System.Drawing.Size(72, 20);
            this.txtNroLote.TabIndex = 79;
            // 
            // chkFechaVenc
            // 
            this.chkFechaVenc.Checked = true;
            this.chkFechaVenc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechaVenc.Location = new System.Drawing.Point(611, 63);
            this.chkFechaVenc.Name = "chkFechaVenc";
            this.chkFechaVenc.Size = new System.Drawing.Size(85, 40);
            this.chkFechaVenc.TabIndex = 86;
            this.chkFechaVenc.Text = "Fecha Vencimiento:";
            this.chkFechaVenc.UseVisualStyleBackColor = true;
            this.chkFechaVenc.CheckedChanged += new System.EventHandler(this.chkFechaVenc_CheckedChanged);
            // 
            // dtFechaVencIni
            // 
            this.dtFechaVencIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencIni.Location = new System.Drawing.Point(696, 68);
            this.dtFechaVencIni.Name = "dtFechaVencIni";
            this.dtFechaVencIni.Size = new System.Drawing.Size(97, 20);
            this.dtFechaVencIni.TabIndex = 88;
            // 
            // dtFechaVencFin
            // 
            this.dtFechaVencFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVencFin.Location = new System.Drawing.Point(821, 68);
            this.dtFechaVencFin.Name = "dtFechaVencFin";
            this.dtFechaVencFin.Size = new System.Drawing.Size(97, 20);
            this.dtFechaVencFin.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Al";
            // 
            // chkCantVigente
            // 
            this.chkCantVigente.AutoSize = true;
            this.chkCantVigente.Checked = true;
            this.chkCantVigente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCantVigente.Location = new System.Drawing.Point(932, 27);
            this.chkCantVigente.Name = "chkCantVigente";
            this.chkCantVigente.Size = new System.Drawing.Size(90, 17);
            this.chkCantVigente.TabIndex = 90;
            this.chkCantVigente.Text = "Cant. Vigente";
            this.chkCantVigente.UseVisualStyleBackColor = true;
            // 
            // Frm_Detalle_Vencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1052, 402);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Detalle_Vencimientos";
            this.Text = "DETALLE DE VENCIMIENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Detalle_Vencimientos_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Detalle_Vencimientos_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodFab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubgrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.TextBox txtNroLote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFechaVencFin;
        private System.Windows.Forms.DateTimePicker dtFechaVencIni;
        private System.Windows.Forms.CheckBox chkFechaVenc;
        private System.Windows.Forms.CheckBox chkCantVigente;
    }
}
