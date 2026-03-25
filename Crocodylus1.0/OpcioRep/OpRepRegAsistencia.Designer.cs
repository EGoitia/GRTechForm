namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepRegAsistencia
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
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.cboTipoRep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.ckbxTodoPer = new System.Windows.Forms.CheckBox();
            this.gbxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.ckbxTodoPer);
            this.gbxFiltros.Controls.Add(this.dtFecFin);
            this.gbxFiltros.Controls.Add(this.dtFecIni);
            this.gbxFiltros.Controls.Add(this.label4);
            this.gbxFiltros.Controls.Add(this.label3);
            this.gbxFiltros.Controls.Add(this.cboTipoRep);
            this.gbxFiltros.Controls.Add(this.label2);
            this.gbxFiltros.Controls.Add(this.cboPer);
            this.gbxFiltros.Controls.Add(this.label1);
            this.gbxFiltros.Location = new System.Drawing.Point(8, 3);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(431, 187);
            this.gbxFiltros.TabIndex = 0;
            this.gbxFiltros.TabStop = false;
            // 
            // cboTipoRep
            // 
            this.cboTipoRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoRep.FormattingEnabled = true;
            this.cboTipoRep.Items.AddRange(new object[] {
            "Marcaciones",
            "Tardanzas",
            "Faltas",
            "Horas Extraordinarias",
            "Faltas Justificadas/Vacaciones",
            "Asistencia"});
            this.cboTipoRep.Location = new System.Drawing.Point(104, 22);
            this.cboTipoRep.Name = "cboTipoRep";
            this.cboTipoRep.Size = new System.Drawing.Size(298, 24);
            this.cboTipoRep.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reporte........";
            // 
            // cboPer
            // 
            this.cboPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPer.FormattingEnabled = true;
            this.cboPer.Location = new System.Drawing.Point(104, 52);
            this.cboPer.Name = "cboPer";
            this.cboPer.Size = new System.Drawing.Size(298, 24);
            this.cboPer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal..........";
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(219, 196);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(107, 60);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(332, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 60);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Inicial..........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Final..........";
            // 
            // dtFecIni
            // 
            this.dtFecIni.Location = new System.Drawing.Point(137, 116);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(265, 22);
            this.dtFecIni.TabIndex = 7;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Location = new System.Drawing.Point(137, 144);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(265, 22);
            this.dtFecFin.TabIndex = 8;
            // 
            // ckbxTodoPer
            // 
            this.ckbxTodoPer.AutoSize = true;
            this.ckbxTodoPer.Location = new System.Drawing.Point(187, 89);
            this.ckbxTodoPer.Name = "ckbxTodoPer";
            this.ckbxTodoPer.Size = new System.Drawing.Size(138, 21);
            this.ckbxTodoPer.TabIndex = 9;
            this.ckbxTodoPer.Text = "Todo el Personal";
            this.ckbxTodoPer.UseVisualStyleBackColor = true;
            this.ckbxTodoPer.CheckedChanged += new System.EventHandler(this.ckbxTodoPer_CheckedChanged);
            // 
            // OpRepRegAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 260);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.gbxFiltros);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 307);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(463, 307);
            this.Name = "OpRepRegAsistencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Registro de Asistencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepRegAsistencia_FormClosing);
            this.Load += new System.EventHandler(this.OpRepRegAsistencia_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.ComboBox cboPer;
        private System.Windows.Forms.ComboBox cboTipoRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbxTodoPer;
    }
}