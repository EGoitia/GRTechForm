namespace GRTechnology1._0
{
    partial class Frm_Tipo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxEstado = new System.Windows.Forms.CheckBox();
            this.txtNomTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbxBotones.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Size = new System.Drawing.Size(738, 54);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(658, 13);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(587, 13);
            // 
            // btnAnular
            // 
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Location = new System.Drawing.Point(8, 110);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3});
            this.dgvDatos.Location = new System.Drawing.Point(8, 170);
            this.dgvDatos.Size = new System.Drawing.Size(738, 210);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxEstado);
            this.groupBox1.Controls.Add(this.txtNomTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(738, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // ckbxEstado
            // 
            this.ckbxEstado.AutoSize = true;
            this.ckbxEstado.Location = new System.Drawing.Point(646, 19);
            this.ckbxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxEstado.Name = "ckbxEstado";
            this.ckbxEstado.Size = new System.Drawing.Size(59, 17);
            this.ckbxEstado.TabIndex = 2;
            this.ckbxEstado.Text = "Estado";
            this.ckbxEstado.UseVisualStyleBackColor = true;
            this.ckbxEstado.Visible = false;
            // 
            // txtNomTipo
            // 
            this.txtNomTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomTipo.Location = new System.Drawing.Point(82, 17);
            this.txtNomTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomTipo.MaxLength = 100;
            this.txtNomTipo.Name = "txtNomTipo";
            this.txtNomTipo.Size = new System.Drawing.Size(523, 20);
            this.txtNomTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Tipo:";
            // 
            // c1
            // 
            this.c1.HeaderText = "TipoID";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Visible = false;
            // 
            // c2
            // 
            this.c2.FillWeight = 300F;
            this.c2.HeaderText = "Nombre Tipo";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.FillWeight = 50F;
            this.c3.HeaderText = "Estado";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Frm_Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 389);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 428);
            this.Name = "Frm_Tipo";
            this.Text = "Tipo";
            this.Load += new System.EventHandler(this.Frm_Tipo_Load);
            this.Controls.SetChildIndex(this.gbxBuscador, 0);
            this.Controls.SetChildIndex(this.gbxBotones, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gbxBotones.ResumeLayout(false);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c3;
        public System.Windows.Forms.TextBox txtNomTipo;
    }
}