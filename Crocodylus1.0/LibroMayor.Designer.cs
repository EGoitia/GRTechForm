namespace GRTechnology1._0
{
    partial class LibroMayor
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
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxTodo = new System.Windows.Forms.CheckBox();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusqCuenta = new System.Windows.Forms.Button();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMayor = new System.Windows.Forms.DataGridView();
            this.gbxBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnProc);
            this.gbxBotones.Location = new System.Drawing.Point(6, 3);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(252, 85);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 59);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(17, 16);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(109, 59);
            this.btnProc.TabIndex = 0;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxTodo);
            this.groupBox1.Controls.Add(this.dtFecFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFecIni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBusqCuenta);
            this.groupBox1.Controls.Add(this.cboCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ckbxTodo
            // 
            this.ckbxTodo.AutoSize = true;
            this.ckbxTodo.Location = new System.Drawing.Point(631, 28);
            this.ckbxTodo.Name = "ckbxTodo";
            this.ckbxTodo.Size = new System.Drawing.Size(148, 21);
            this.ckbxTodo.TabIndex = 7;
            this.ckbxTodo.Text = "Todas las Cuentas";
            this.ckbxTodo.UseVisualStyleBackColor = true;
            this.ckbxTodo.CheckedChanged += new System.EventHandler(this.ckbxTodo_CheckedChanged);
            // 
            // dtFecFin
            // 
            this.dtFecFin.Location = new System.Drawing.Point(426, 58);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(264, 22);
            this.dtFecFin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Al..........";
            // 
            // dtFecIni
            // 
            this.dtFecIni.Location = new System.Drawing.Point(52, 58);
            this.dtFecIni.Name = "dtFecIni";
            this.dtFecIni.Size = new System.Drawing.Size(265, 22);
            this.dtFecIni.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Del........";
            // 
            // btnBusqCuenta
            // 
            this.btnBusqCuenta.Location = new System.Drawing.Point(506, 21);
            this.btnBusqCuenta.Name = "btnBusqCuenta";
            this.btnBusqCuenta.Size = new System.Drawing.Size(39, 23);
            this.btnBusqCuenta.TabIndex = 2;
            this.btnBusqCuenta.Text = ".....";
            this.btnBusqCuenta.UseVisualStyleBackColor = true;
            this.btnBusqCuenta.Click += new System.EventHandler(this.btnBusqCuenta_Click);
            // 
            // cboCuenta
            // 
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(138, 21);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(363, 24);
            this.cboCuenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta Contable........";
            // 
            // dgvMayor
            // 
            this.dgvMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMayor.Location = new System.Drawing.Point(6, 193);
            this.dgvMayor.MultiSelect = false;
            this.dgvMayor.Name = "dgvMayor";
            this.dgvMayor.ReadOnly = true;
            this.dgvMayor.RowTemplate.Height = 24;
            this.dgvMayor.Size = new System.Drawing.Size(846, 379);
            this.dgvMayor.TabIndex = 2;
            // 
            // LibroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 584);
            this.Controls.Add(this.dgvMayor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBotones);
            this.MaximizeBox = false;
            this.Name = "LibroMayor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro Mayor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibroMayor_FormClosing);
            this.Load += new System.EventHandler(this.LibroMayor_Load);
            this.gbxBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMayor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBusqCuenta;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbxTodo;
        private System.Windows.Forms.DataGridView dgvMayor;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnCancelar;
    }
}