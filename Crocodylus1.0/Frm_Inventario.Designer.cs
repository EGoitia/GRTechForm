namespace GRTechnology1._0
{
    partial class Frm_Inventario
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
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.txtSubgrupo = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.GbxBotones = new System.Windows.Forms.GroupBox();
            this.BtnImpr = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbxDatos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboAlmacen = new System.Windows.Forms.ComboBox();
            this.btnFormatoExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.chkInvInic = new System.Windows.Forms.CheckBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.DgvDetInv = new System.Windows.Forms.DataGridView();
            this.gbxFiltro.SuspendLayout();
            this.panelInventario.SuspendLayout();
            this.GbxBotones.SuspendLayout();
            this.GbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetInv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFiltro.Controls.Add(this.txtSubgrupo);
            this.gbxFiltro.Controls.Add(this.txtGrupo);
            this.gbxFiltro.Controls.Add(this.txtMarca);
            this.gbxFiltro.Controls.Add(this.txtProducto);
            this.gbxFiltro.Controls.Add(this.txtCodigo);
            this.gbxFiltro.Controls.Add(this.label5);
            this.gbxFiltro.Controls.Add(this.label4);
            this.gbxFiltro.Controls.Add(this.label3);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Location = new System.Drawing.Point(5, 99);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(951, 77);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            // 
            // txtSubgrupo
            // 
            this.txtSubgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubgrupo.Location = new System.Drawing.Point(591, 44);
            this.txtSubgrupo.Name = "txtSubgrupo";
            this.txtSubgrupo.Size = new System.Drawing.Size(196, 20);
            this.txtSubgrupo.TabIndex = 1;
            this.txtSubgrupo.TextChanged += new System.EventHandler(this.txtFiltroProd_TextChanged);
            // 
            // txtGrupo
            // 
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupo.Location = new System.Drawing.Point(591, 19);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(196, 20);
            this.txtGrupo.TabIndex = 1;
            this.txtGrupo.TextChanged += new System.EventHandler(this.txtFiltroProd_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(297, 44);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 20);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtFiltroProd_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Location = new System.Drawing.Point(297, 19);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(194, 20);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtFiltroProd_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(79, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtFiltroProd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subgrupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.label8);
            this.panelInventario.Controls.Add(this.GbxBotones);
            this.panelInventario.Controls.Add(this.GbxDatos);
            this.panelInventario.Controls.Add(this.txtObs);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventario.Location = new System.Drawing.Point(0, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(968, 96);
            this.panelInventario.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.label8.Location = new System.Drawing.Point(407, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observaciones:";
            // 
            // GbxBotones
            // 
            this.GbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxBotones.Controls.Add(this.BtnImpr);
            this.GbxBotones.Controls.Add(this.BtnCancelar);
            this.GbxBotones.Controls.Add(this.BtnGuardar);
            this.GbxBotones.Location = new System.Drawing.Point(689, 5);
            this.GbxBotones.Name = "GbxBotones";
            this.GbxBotones.Size = new System.Drawing.Size(267, 84);
            this.GbxBotones.TabIndex = 4;
            this.GbxBotones.TabStop = false;
            // 
            // BtnImpr
            // 
            this.BtnImpr.Location = new System.Drawing.Point(179, 22);
            this.BtnImpr.Name = "BtnImpr";
            this.BtnImpr.Size = new System.Drawing.Size(75, 48);
            this.BtnImpr.TabIndex = 0;
            this.BtnImpr.Text = "Imprimir";
            this.BtnImpr.UseVisualStyleBackColor = true;
            this.BtnImpr.Click += new System.EventHandler(this.BtnImpr_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(98, 22);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 48);
            this.BtnCancelar.TabIndex = 0;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(15, 22);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 48);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GbxDatos
            // 
            this.GbxDatos.Controls.Add(this.label6);
            this.GbxDatos.Controls.Add(this.CboAlmacen);
            this.GbxDatos.Controls.Add(this.btnFormatoExcel);
            this.GbxDatos.Controls.Add(this.btnImportExcel);
            this.GbxDatos.Controls.Add(this.chkInvInic);
            this.GbxDatos.Location = new System.Drawing.Point(7, 5);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.Size = new System.Drawing.Size(386, 84);
            this.GbxDatos.TabIndex = 1;
            this.GbxDatos.TabStop = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 9.75F);
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Almacén:";
            // 
            // CboAlmacen
            // 
            this.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAlmacen.Font = new System.Drawing.Font("Calisto MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAlmacen.Location = new System.Drawing.Point(122, 49);
            this.CboAlmacen.Name = "CboAlmacen";
            this.CboAlmacen.Size = new System.Drawing.Size(247, 21);
            this.CboAlmacen.TabIndex = 11;
            this.CboAlmacen.TabStop = false;
            this.CboAlmacen.SelectionChangeCommitted += new System.EventHandler(this.CboAlmacen_SelectionChangeCommitted);
            // 
            // btnFormatoExcel
            // 
            this.btnFormatoExcel.Enabled = false;
            this.btnFormatoExcel.Location = new System.Drawing.Point(265, 16);
            this.btnFormatoExcel.Name = "btnFormatoExcel";
            this.btnFormatoExcel.Size = new System.Drawing.Size(104, 23);
            this.btnFormatoExcel.TabIndex = 9;
            this.btnFormatoExcel.Text = "Formato Excel";
            this.btnFormatoExcel.UseVisualStyleBackColor = true;
            this.btnFormatoExcel.Click += new System.EventHandler(this.btnFormatoExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Enabled = false;
            this.btnImportExcel.Location = new System.Drawing.Point(122, 16);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(104, 23);
            this.btnImportExcel.TabIndex = 8;
            this.btnImportExcel.Text = "Importar Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // chkInvInic
            // 
            this.chkInvInic.AutoSize = true;
            this.chkInvInic.Location = new System.Drawing.Point(15, 19);
            this.chkInvInic.Name = "chkInvInic";
            this.chkInvInic.Size = new System.Drawing.Size(93, 17);
            this.chkInvInic.TabIndex = 7;
            this.chkInvInic.Text = "Importar Excel";
            this.chkInvInic.UseVisualStyleBackColor = true;
            this.chkInvInic.CheckedChanged += new System.EventHandler(this.chkInvInic_CheckedChanged);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(502, 18);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObs.Size = new System.Drawing.Size(178, 71);
            this.txtObs.TabIndex = 8;
            // 
            // DgvDetInv
            // 
            this.DgvDetInv.AllowUserToAddRows = false;
            this.DgvDetInv.AllowUserToDeleteRows = false;
            this.DgvDetInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDetInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDetInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDetInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetInv.Location = new System.Drawing.Point(5, 182);
            this.DgvDetInv.MultiSelect = false;
            this.DgvDetInv.Name = "DgvDetInv";
            this.DgvDetInv.Size = new System.Drawing.Size(951, 236);
            this.DgvDetInv.TabIndex = 3;
            this.DgvDetInv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetInv_CellValueChanged);
            this.DgvDetInv.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvDetInv_CurrentCellDirtyStateChanged);
            this.DgvDetInv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvDetInv_DataError);
            this.DgvDetInv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvDetInv_RowPostPaint);
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 422);
            this.Controls.Add(this.DgvDetInv);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.gbxFiltro);
            this.Name = "Frm_Inventario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Inventario_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Inventario_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            this.GbxBotones.ResumeLayout(false);
            this.GbxDatos.ResumeLayout(false);
            this.GbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetInv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubgrupo;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panelInventario;
        internal System.Windows.Forms.GroupBox GbxDatos;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox CboAlmacen;
        internal System.Windows.Forms.Button btnFormatoExcel;
        internal System.Windows.Forms.Button btnImportExcel;
        internal System.Windows.Forms.CheckBox chkInvInic;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.GroupBox GbxBotones;
        internal System.Windows.Forms.Button BtnImpr;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnGuardar;
        internal System.Windows.Forms.TextBox txtObs;
        internal System.Windows.Forms.DataGridView DgvDetInv;
    }
}