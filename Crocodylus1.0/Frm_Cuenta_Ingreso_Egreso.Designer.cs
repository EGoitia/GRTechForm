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
            this.btnBuscCuentCont = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboCuentaCont = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Tipo});
            this.dgvDatos.Location = new System.Drawing.Point(8, 235);
            this.dgvDatos.Size = new System.Drawing.Size(626, 169);
            // 
            // gbxCuenIngrEgre
            // 
            this.gbxCuenIngrEgre.Controls.Add(this.btnBuscCuentCont);
            this.gbxCuenIngrEgre.Controls.Add(this.txtDescripcion);
            this.gbxCuenIngrEgre.Controls.Add(this.cboCuentaCont);
            this.gbxCuenIngrEgre.Controls.Add(this.txtNombre);
            this.gbxCuenIngrEgre.Controls.Add(this.cboTipo);
            this.gbxCuenIngrEgre.Controls.Add(this.txtCodigo);
            this.gbxCuenIngrEgre.Controls.Add(this.label5);
            this.gbxCuenIngrEgre.Controls.Add(this.label4);
            this.gbxCuenIngrEgre.Controls.Add(this.label3);
            this.gbxCuenIngrEgre.Controls.Add(this.label2);
            this.gbxCuenIngrEgre.Location = new System.Drawing.Point(8, 62);
            this.gbxCuenIngrEgre.Name = "gbxCuenIngrEgre";
            this.gbxCuenIngrEgre.Size = new System.Drawing.Size(626, 115);
            this.gbxCuenIngrEgre.TabIndex = 6;
            this.gbxCuenIngrEgre.TabStop = false;
            // 
            // btnBuscCuentCont
            // 
            this.btnBuscCuentCont.ImageIndex = 14;
            this.btnBuscCuentCont.Location = new System.Drawing.Point(359, 76);
            this.btnBuscCuentCont.Name = "btnBuscCuentCont";
            this.btnBuscCuentCont.Size = new System.Drawing.Size(32, 23);
            this.btnBuscCuentCont.TabIndex = 4;
            this.btnBuscCuentCont.Text = ".....";
            this.btnBuscCuentCont.UseVisualStyleBackColor = true;
            this.btnBuscCuentCont.Visible = false;
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
            // cboCuentaCont
            // 
            this.cboCuentaCont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuentaCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuentaCont.FormattingEnabled = true;
            this.cboCuentaCont.Location = new System.Drawing.Point(98, 78);
            this.cboCuentaCont.Name = "cboCuentaCont";
            this.cboCuentaCont.Size = new System.Drawing.Size(255, 21);
            this.cboCuentaCont.TabIndex = 3;
            this.cboCuentaCont.Visible = false;
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
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "SELECCIONE.....",
            "INGRESO",
            "EGRESO"});
            this.cboTipo.Location = new System.Drawing.Point(98, 19);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(124, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(314, 19);
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
            this.label5.Location = new System.Drawing.Point(385, 47);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuenta Cont.:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // c1
            // 
            this.c1.FillWeight = 50F;
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
            this.Tipo.FillWeight = 50F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
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
        private System.Windows.Forms.Button btnBuscCuentCont;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboCuentaCont;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
