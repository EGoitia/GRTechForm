namespace GRTechnology1._0
{
    partial class Frm_TipoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dgvTipoUsu = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtNomTipoUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboTipoSistema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsu)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.CheckBoxes = true;
            this.tvMenu.Location = new System.Drawing.Point(429, 118);
            this.tvMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(289, 283);
            this.tvMenu.TabIndex = 11;
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.txtBuscador);
            this.gbxBuscador.Location = new System.Drawing.Point(5, 138);
            this.gbxBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBuscador.Size = new System.Drawing.Size(218, 54);
            this.gbxBuscador.TabIndex = 10;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // txtBuscador
            // 
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscador.Location = new System.Drawing.Point(10, 23);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscador.MaxLength = 30;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(195, 20);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // dgvTipoUsu
            // 
            this.dgvTipoUsu.AllowUserToAddRows = false;
            this.dgvTipoUsu.AllowUserToDeleteRows = false;
            this.dgvTipoUsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoUsu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTipoUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2});
            this.dgvTipoUsu.Location = new System.Drawing.Point(5, 196);
            this.dgvTipoUsu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTipoUsu.MultiSelect = false;
            this.dgvTipoUsu.Name = "dgvTipoUsu";
            this.dgvTipoUsu.ReadOnly = true;
            this.dgvTipoUsu.RowTemplate.Height = 24;
            this.dgvTipoUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoUsu.Size = new System.Drawing.Size(415, 205);
            this.dgvTipoUsu.TabIndex = 9;
            this.dgvTipoUsu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoUsu_RowEnter);
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
            this.c2.HeaderText = "Tipo Usuario";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtNomTipoUsu);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Location = new System.Drawing.Point(5, 88);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Size = new System.Drawing.Size(415, 48);
            this.gbxDatos.TabIndex = 8;
            this.gbxDatos.TabStop = false;
            // 
            // txtNomTipoUsu
            // 
            this.txtNomTipoUsu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomTipoUsu.Location = new System.Drawing.Point(88, 18);
            this.txtNomTipoUsu.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomTipoUsu.MaxLength = 50;
            this.txtNomTipoUsu.Name = "txtNomTipoUsu";
            this.txtNomTipoUsu.Size = new System.Drawing.Size(305, 20);
            this.txtNomTipoUsu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Usuario:";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnBloquear);
            this.gbxBotones.Controls.Add(this.btnRest);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Location = new System.Drawing.Point(5, 3);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Size = new System.Drawing.Size(713, 81);
            this.gbxBotones.TabIndex = 7;
            this.gbxBotones.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(277, 14);
            this.btnAct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(66, 59);
            this.btnAct.TabIndex = 7;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(567, 14);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 59);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(634, 14);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 59);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(344, 14);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(66, 59);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Location = new System.Drawing.Point(143, 14);
            this.btnBloquear.Margin = new System.Windows.Forms.Padding(2);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(66, 59);
            this.btnBloquear.TabIndex = 3;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(210, 14);
            this.btnRest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(66, 59);
            this.btnRest.TabIndex = 2;
            this.btnRest.Text = "Restaurar";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(76, 14);
            this.btnModif.Margin = new System.Windows.Forms.Padding(2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(66, 59);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(10, 14);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 59);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboTipoSistema
            // 
            this.cboTipoSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoSistema.FormattingEnabled = true;
            this.cboTipoSistema.Items.AddRange(new object[] {
            "FORM",
            "WEB",
            "APP"});
            this.cboTipoSistema.Location = new System.Drawing.Point(515, 92);
            this.cboTipoSistema.Name = "cboTipoSistema";
            this.cboTipoSistema.Size = new System.Drawing.Size(203, 21);
            this.cboTipoSistema.TabIndex = 12;
            this.cboTipoSistema.SelectionChangeCommitted += new System.EventHandler(this.cboTipoSistema_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo Sistema:";
            // 
            // Frm_TipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoSistema);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.gbxBuscador);
            this.Controls.Add(this.dgvTipoUsu);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxBotones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TipoUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIPO USUARIO";
            this.Load += new System.EventHandler(this.TipoUsuario_Load);
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsu)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.DataGridView dgvTipoUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtNomTipoUsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboTipoSistema;
        private System.Windows.Forms.Label label1;

    }
}