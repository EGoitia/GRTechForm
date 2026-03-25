namespace GRTechnology1._0
{
    partial class TurnoPersonal
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
            this.dgvDetTurno = new System.Windows.Forms.DataGridView();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnQuitarTurno = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnAsigTur = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxHrsExt = new System.Windows.Forms.CheckBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgrTurno = new System.Windows.Forms.Button();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.cboFiltroPer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetTurno)).BeginInit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.gbxBuscador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetTurno
            // 
            this.dgvDetTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetTurno.Location = new System.Drawing.Point(9, 372);
            this.dgvDetTurno.MultiSelect = false;
            this.dgvDetTurno.Name = "dgvDetTurno";
            this.dgvDetTurno.ReadOnly = true;
            this.dgvDetTurno.RowTemplate.Height = 24;
            this.dgvDetTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetTurno.Size = new System.Drawing.Size(712, 220);
            this.dgvDetTurno.TabIndex = 2;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnQuitarTurno);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnAsigTur);
            this.gbxBotones.Location = new System.Drawing.Point(356, 4);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(480, 83);
            this.gbxBotones.TabIndex = 4;
            this.gbxBotones.TabStop = false;
            // 
            // btnQuitarTurno
            // 
            this.btnQuitarTurno.Location = new System.Drawing.Point(356, 21);
            this.btnQuitarTurno.Name = "btnQuitarTurno";
            this.btnQuitarTurno.Size = new System.Drawing.Size(114, 44);
            this.btnQuitarTurno.TabIndex = 10;
            this.btnQuitarTurno.Text = "Quitar Turno";
            this.btnQuitarTurno.UseVisualStyleBackColor = true;
            this.btnQuitarTurno.Click += new System.EventHandler(this.btnQuitarTurno_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(241, 21);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(114, 44);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(126, 21);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(114, 44);
            this.btnAct.TabIndex = 8;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnAsigTur
            // 
            this.btnAsigTur.Location = new System.Drawing.Point(11, 21);
            this.btnAsigTur.Name = "btnAsigTur";
            this.btnAsigTur.Size = new System.Drawing.Size(114, 44);
            this.btnAsigTur.TabIndex = 6;
            this.btnAsigTur.Text = "Asignar Turno";
            this.btnAsigTur.UseVisualStyleBackColor = true;
            this.btnAsigTur.Click += new System.EventHandler(this.btnAsigTur_Click);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(9, 93);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(369, 220);
            this.dgvPersonal.TabIndex = 5;
            this.dgvPersonal.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_RowEnter);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.txtBuscador);
            this.gbxBuscador.Location = new System.Drawing.Point(9, 4);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(148, 83);
            this.gbxBuscador.TabIndex = 6;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(9, 32);
            this.txtBuscador.MaxLength = 25;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(133, 22);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxHrsExt);
            this.groupBox1.Controls.Add(this.cboTurno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFecIni);
            this.groupBox1.Controls.Add(this.dtFecFin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgrTurno);
            this.groupBox1.Location = new System.Drawing.Point(9, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // ckbxHrsExt
            // 
            this.ckbxHrsExt.AutoSize = true;
            this.ckbxHrsExt.Location = new System.Drawing.Point(722, 20);
            this.ckbxHrsExt.Name = "ckbxHrsExt";
            this.ckbxHrsExt.Size = new System.Drawing.Size(99, 21);
            this.ckbxHrsExt.TabIndex = 15;
            this.ckbxHrsExt.Text = "Hrs. Extras";
            this.ckbxHrsExt.UseVisualStyleBackColor = true;
            // 
            // cboTurno
            // 
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(443, 17);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(216, 24);
            this.cboTurno.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Turno.....";
            // 
            // dtFecIni
            // 
            this.dtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecIni.Location = new System.Drawing.Point(73, 18);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(114, 22);
            this.dtFecIni.TabIndex = 12;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(266, 18);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(114, 22);
            this.dtFecFin.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fec. Fin.......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fec. Ini. ......";
            // 
            // btnAgrTurno
            // 
            this.btnAgrTurno.Location = new System.Drawing.Point(665, 17);
            this.btnAgrTurno.Name = "btnAgrTurno";
            this.btnAgrTurno.Size = new System.Drawing.Size(37, 23);
            this.btnAgrTurno.TabIndex = 8;
            this.btnAgrTurno.Text = "......";
            this.btnAgrTurno.UseVisualStyleBackColor = true;
            this.btnAgrTurno.Click += new System.EventHandler(this.btnAgrTurno_Click);
            // 
            // dgvTurno
            // 
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Location = new System.Drawing.Point(384, 93);
            this.dgvTurno.MultiSelect = false;
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.ReadOnly = true;
            this.dgvTurno.RowTemplate.Height = 24;
            this.dgvTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurno.Size = new System.Drawing.Size(452, 220);
            this.dgvTurno.TabIndex = 9;
            this.dgvTurno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurno_RowEnter);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.cboFiltroPer);
            this.gbxFiltros.Location = new System.Drawing.Point(163, 4);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(190, 83);
            this.gbxFiltros.TabIndex = 10;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // cboFiltroPer
            // 
            this.cboFiltroPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltroPer.FormattingEnabled = true;
            this.cboFiltroPer.Items.AddRange(new object[] {
            "Todo el Personal",
            "Personal Habilitado",
            "Personal Desabilitado"});
            this.cboFiltroPer.Location = new System.Drawing.Point(11, 32);
            this.cboFiltroPer.Name = "cboFiltroPer";
            this.cboFiltroPer.Size = new System.Drawing.Size(168, 24);
            this.cboFiltroPer.TabIndex = 0;
            this.cboFiltroPer.SelectedValueChanged += new System.EventHandler(this.cboFiltroPer_SelectedValueChanged);
            // 
            // TurnoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 599);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.dgvTurno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBuscador);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.dgvDetTurno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 646);
            this.MinimumSize = new System.Drawing.Size(862, 646);
            this.Name = "TurnoPersonal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno del Personal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurnoPersonal_FormClosing);
            this.Load += new System.EventHandler(this.TurnoPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetTurno)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetTurno;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnAsigTur;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgrTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbxHrsExt;
        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.ComboBox cboFiltroPer;
        private System.Windows.Forms.Button btnQuitarTurno;
    }
}