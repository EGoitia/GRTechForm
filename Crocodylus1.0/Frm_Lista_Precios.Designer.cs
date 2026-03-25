namespace GRTechnology1._0
{
    partial class Frm_Lista_Precios
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
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnul
            // 
            this.btnAnul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnul.Location = new System.Drawing.Point(736, 12);
            this.btnAnul.Visible = false;
            // 
            // btnModif
            // 
            this.btnModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModif.Location = new System.Drawing.Point(835, 12);
            this.btnModif.Text = "Guardar Precios";
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.label6);
            this.gbxFiltro.Controls.Add(this.cboTipoCliente);
            this.gbxFiltro.Controls.Add(this.txtMarca);
            this.gbxFiltro.Controls.Add(this.txtSubgrupo);
            this.gbxFiltro.Controls.Add(this.txtGrupo);
            this.gbxFiltro.Controls.Add(this.label5);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtCodFab);
            this.gbxFiltro.Controls.Add(this.label4);
            this.gbxFiltro.Controls.Add(this.txtProducto);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Size = new System.Drawing.Size(940, 75);
            this.gbxFiltro.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label1, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtProducto, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label4, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtCodFab, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label2, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label3, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label5, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtGrupo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtSubgrupo, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.txtMarca, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.cboTipoCliente, 0);
            this.gbxFiltro.Controls.SetChildIndex(this.label6, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(836, 17);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(10, 87);
            this.dgvDetalle.ReadOnly = false;
            this.dgvDetalle.Size = new System.Drawing.Size(940, 260);
            this.dgvDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetalle_DataError);
            // 
            // btnImpNota
            // 
            this.btnImpNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImpNota.Location = new System.Drawing.Point(209, 12);
            this.btnImpNota.Visible = false;
            // 
            // btnImpLista
            // 
            this.btnImpLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImpLista.Location = new System.Drawing.Point(111, 12);
            this.btnImpLista.Click += new System.EventHandler(this.btnImpLista_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Location = new System.Drawing.Point(10, 350);
            this.gbxBotones.Size = new System.Drawing.Size(940, 63);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistro.Location = new System.Drawing.Point(12, 12);
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(619, 17);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);
            this.txtMarca.TabIndex = 70;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // txtSubgrupo
            // 
            this.txtSubgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupo.Location = new System.Drawing.Point(357, 44);
            this.txtSubgrupo.MaxLength = 50;
            this.txtSubgrupo.Name = "txtSubgrupo";
            this.txtSubgrupo.Size = new System.Drawing.Size(200, 20);
            this.txtSubgrupo.TabIndex = 71;
            this.txtSubgrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // txtGrupo
            // 
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupo.Location = new System.Drawing.Point(357, 18);
            this.txtGrupo.MaxLength = 50;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(200, 20);
            this.txtGrupo.TabIndex = 72;
            this.txtGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Subgrupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Grupo:";
            // 
            // txtCodFab
            // 
            this.txtCodFab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFab.Location = new System.Drawing.Point(74, 47);
            this.txtCodFab.MaxLength = 50;
            this.txtCodFab.Name = "txtCodFab";
            this.txtCodFab.Size = new System.Drawing.Size(92, 20);
            this.txtCodFab.TabIndex = 69;
            this.txtCodFab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Código:";
            // 
            // txtProducto
            // 
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Location = new System.Drawing.Point(74, 20);
            this.txtProducto.MaxLength = 50;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 20);
            this.txtProducto.TabIndex = 67;
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Producto:";
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(619, 44);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(200, 21);
            this.cboTipoCliente.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Tipo:";
            // 
            // Frm_Lista_Precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 417);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Lista_Precios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Precios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Lista_Precios_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Lista_Precios_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipoCliente;

    }
}