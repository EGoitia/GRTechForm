namespace GRTechnology1._0
{
    partial class Frm_Cuenta_Ingreso_Egreso
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
            this.gbxCuenIngrEgre = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboTipoIngEgr = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngEgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxBotones.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbxCuenIngrEgre.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Size = new System.Drawing.Size(626, 54);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(544, 13);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(473, 13);
            // 
            // btnAnular
            // 
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Location = new System.Drawing.Point(8, 179);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.Nombre,
            this.Tipo,
            this.IngEgr});
            this.dgvDatos.Location = new System.Drawing.Point(8, 235);
            this.dgvDatos.Size = new System.Drawing.Size(626, 169);
            // 
            // gbxCuenIngrEgre
            // 
            this.gbxCuenIngrEgre.Controls.Add(this.txtDescripcion);
            this.gbxCuenIngrEgre.Controls.Add(this.cboTipo);
            this.gbxCuenIngrEgre.Controls.Add(this.cboTipoIngEgr);
            this.gbxCuenIngrEgre.Controls.Add(this.txtCodigo);
            this.gbxCuenIngrEgre.Controls.Add(this.label5);
            this.gbxCuenIngrEgre.Controls.Add(this.label4);
            this.gbxCuenIngrEgre.Controls.Add(this.label1);
            this.gbxCuenIngrEgre.Controls.Add(this.label2);
            this.gbxCuenIngrEgre.Controls.Add(this.txtNombre);
            this.gbxCuenIngrEgre.Location = new System.Drawing.Point(8, 62);
            this.gbxCuenIngrEgre.Name = "gbxCuenIngrEgre";
            this.gbxCuenIngrEgre.Size = new System.Drawing.Size(626, 115);
            this.gbxCuenIngrEgre.TabIndex = 6;
            this.gbxCuenIngrEgre.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(457, 40);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(157, 59);
            this.txtDescripcion.TabIndex = 5;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "SELECCIONE.....",
            "INGRESO",
            "EGRESO"});
            this.cboTipo.Location = new System.Drawing.Point(98, 18);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(255, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // cboTipoIngEgr
            // 
            this.cboTipoIngEgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoIngEgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoIngEgr.FormattingEnabled = true;
            this.cboTipoIngEgr.Items.AddRange(new object[] {
            "SELECCIONE.....",
            "INGRESO",
            "EGRESO"});
            this.cboTipoIngEgr.Location = new System.Drawing.Point(457, 13);
            this.cboTipoIngEgr.Name = "cboTipoIngEgr";
            this.cboTipoIngEgr.Size = new System.Drawing.Size(157, 21);
            this.cboTipoIngEgr.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(98, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(39, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso/Egreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(98, 48);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // c1
            // 
            this.c1.FillWeight = 40F;
            this.c1.HeaderText = "ID";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 200F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 80F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // IngEgr
            // 
            this.IngEgr.FillWeight = 40F;
            this.IngEgr.HeaderText = "I/E";
            this.IngEgr.Name = "IngEgr";
            this.IngEgr.ReadOnly = true;
            // 
            // Frm_Cuenta_Ingreso_Egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(641, 411);
            this.Controls.Add(this.gbxCuenIngrEgre);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(657, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(657, 450);
            this.Name = "Frm_Cuenta_Ingreso_Egreso";
            this.Text = "CUENTAS INGRESOS/EGRESOS";
            this.Load += new System.EventHandler(this.Frm_Cuenta_Ingreso_Egreso_Load);
            this.Controls.SetChildIndex(this.gbxBuscador, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.Controls.SetChildIndex(this.gbxCuenIngrEgre, 0);
            this.gbxBotones.ResumeLayout(false);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbxCuenIngrEgre.ResumeLayout(false);
            this.gbxCuenIngrEgre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCuenIngrEgre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboTipoIngEgr;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngEgr;
    }
}
