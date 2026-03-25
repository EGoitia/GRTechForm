namespace GRTechnology1._0
{
    partial class Turno
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
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.dgvDetTurno = new System.Windows.Forms.DataGridView();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomTurno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurnoID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetTurno)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurno
            // 
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Location = new System.Drawing.Point(702, 177);
            this.dgvTurno.MultiSelect = false;
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.ReadOnly = true;
            this.dgvTurno.RowTemplate.Height = 24;
            this.dgvTurno.Size = new System.Drawing.Size(277, 293);
            this.dgvTurno.TabIndex = 0;
            this.dgvTurno.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurno_RowEnter);
            // 
            // dgvDetTurno
            // 
            this.dgvDetTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetTurno.Location = new System.Drawing.Point(12, 177);
            this.dgvDetTurno.MultiSelect = false;
            this.dgvDetTurno.Name = "dgvDetTurno";
            this.dgvDetTurno.ReadOnly = true;
            this.dgvDetTurno.RowTemplate.Height = 24;
            this.dgvDetTurno.Size = new System.Drawing.Size(684, 293);
            this.dgvDetTurno.TabIndex = 1;
            this.dgvDetTurno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetTurno_CellDoubleClick);
            this.dgvDetTurno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetTurno_KeyDown);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnRest);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnAnul);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Location = new System.Drawing.Point(12, 5);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(739, 100);
            this.gbxBotones.TabIndex = 2;
            this.gbxBotones.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(636, 21);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(88, 60);
            this.btnAct.TabIndex = 9;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(280, 21);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(88, 60);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Restaurar";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(547, 21);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(88, 60);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(191, 21);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(88, 60);
            this.btnAnul.TabIndex = 6;
            this.btnAnul.Text = "Anular";
            this.btnAnul.UseVisualStyleBackColor = true;
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(458, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 60);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(369, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 60);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(102, 21);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(88, 60);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 60);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTurnoID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtNomTurno
            // 
            this.txtNomTurno.Location = new System.Drawing.Point(369, 21);
            this.txtNomTurno.MaxLength = 50;
            this.txtNomTurno.Name = "txtNomTurno";
            this.txtNomTurno.Size = new System.Drawing.Size(288, 22);
            this.txtNomTurno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Turno...........";
            // 
            // txtTurnoID
            // 
            this.txtTurnoID.Location = new System.Drawing.Point(80, 21);
            this.txtTurnoID.Name = "txtTurnoID";
            this.txtTurnoID.ReadOnly = true;
            this.txtTurnoID.Size = new System.Drawing.Size(100, 22);
            this.txtTurnoID.TabIndex = 1;
            this.txtTurnoID.TabStop = false;
            this.txtTurnoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo.......";
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.dgvDetTurno);
            this.Controls.Add(this.dgvTurno);
            this.MaximizeBox = false;
            this.Name = "Turno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Turno_FormClosing);
            this.Load += new System.EventHandler(this.Turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetTurno)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.DataGridView dgvDetTurno;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTurnoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.TextBox txtNomTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAct;
    }
}