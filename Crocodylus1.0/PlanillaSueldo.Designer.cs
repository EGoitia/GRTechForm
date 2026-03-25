namespace GRTechnology1._0
{
    partial class PlanillaSueldo
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaPla = new System.Windows.Forms.DateTimePicker();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMesPla = new System.Windows.Forms.ComboBox();
            this.cboGestionPla = new System.Windows.Forms.ComboBox();
            this.txtLiquidoPag = new System.Windows.Forms.TextBox();
            this.ckbxPag = new System.Windows.Forms.CheckBox();
            this.ckbxAutoriz = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAgrFila = new System.Windows.Forms.Button();
            this.btnImpBoleta = new System.Windows.Forms.Button();
            this.btnBoletaPag = new System.Windows.Forms.Button();
            this.btnElimFila = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.gbxBotones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.label4);
            this.gbxBotones.Controls.Add(this.dtFechaPla);
            this.gbxBotones.Controls.Add(this.btnImp);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Location = new System.Drawing.Point(8, 4);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(1102, 100);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(809, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "MES DE:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtFechaPla
            // 
            this.dtFechaPla.CustomFormat = "MMMM \'de\' yyyy";
            this.dtFechaPla.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaPla.Location = new System.Drawing.Point(812, 56);
            this.dtFechaPla.Name = "dtFechaPla";
            this.dtFechaPla.ShowUpDown = true;
            this.dtFechaPla.Size = new System.Drawing.Size(170, 22);
            this.dtFechaPla.TabIndex = 5;
            this.dtFechaPla.ValueChanged += new System.EventHandler(this.dtFechaPla_ValueChanged);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(528, 21);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(125, 66);
            this.btnImp.TabIndex = 5;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(654, 21);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(125, 66);
            this.btnAct.TabIndex = 4;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(276, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 66);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(402, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 66);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(150, 21);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(125, 66);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(24, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 66);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboMesPla);
            this.groupBox2.Controls.Add(this.cboGestionPla);
            this.groupBox2.Controls.Add(this.txtLiquidoPag);
            this.groupBox2.Controls.Add(this.ckbxPag);
            this.groupBox2.Controls.Add(this.ckbxAutoriz);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(894, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(504, 23);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(283, 51);
            this.txtObs.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observacion.................";
            // 
            // cboMesPla
            // 
            this.cboMesPla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesPla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMesPla.FormattingEnabled = true;
            this.cboMesPla.Location = new System.Drawing.Point(107, 44);
            this.cboMesPla.Margin = new System.Windows.Forms.Padding(4);
            this.cboMesPla.Name = "cboMesPla";
            this.cboMesPla.Size = new System.Drawing.Size(167, 24);
            this.cboMesPla.TabIndex = 0;
            // 
            // cboGestionPla
            // 
            this.cboGestionPla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGestionPla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGestionPla.FormattingEnabled = true;
            this.cboGestionPla.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboGestionPla.Location = new System.Drawing.Point(387, 44);
            this.cboGestionPla.Margin = new System.Windows.Forms.Padding(4);
            this.cboGestionPla.Name = "cboGestionPla";
            this.cboGestionPla.Size = new System.Drawing.Size(97, 24);
            this.cboGestionPla.TabIndex = 1;
            // 
            // txtLiquidoPag
            // 
            this.txtLiquidoPag.Location = new System.Drawing.Point(149, 17);
            this.txtLiquidoPag.Margin = new System.Windows.Forms.Padding(4);
            this.txtLiquidoPag.Name = "txtLiquidoPag";
            this.txtLiquidoPag.ReadOnly = true;
            this.txtLiquidoPag.Size = new System.Drawing.Size(125, 22);
            this.txtLiquidoPag.TabIndex = 5;
            this.txtLiquidoPag.TabStop = false;
            this.txtLiquidoPag.Text = "0.00";
            this.txtLiquidoPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbxPag
            // 
            this.ckbxPag.AutoSize = true;
            this.ckbxPag.Enabled = false;
            this.ckbxPag.Location = new System.Drawing.Point(794, 28);
            this.ckbxPag.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxPag.Name = "ckbxPag";
            this.ckbxPag.Size = new System.Drawing.Size(79, 21);
            this.ckbxPag.TabIndex = 3;
            this.ckbxPag.Text = "Pagado";
            this.ckbxPag.UseVisualStyleBackColor = true;
            // 
            // ckbxAutoriz
            // 
            this.ckbxAutoriz.AutoSize = true;
            this.ckbxAutoriz.Enabled = false;
            this.ckbxAutoriz.Location = new System.Drawing.Point(794, 52);
            this.ckbxAutoriz.Margin = new System.Windows.Forms.Padding(4);
            this.ckbxAutoriz.Name = "ckbxAutoriz";
            this.ckbxAutoriz.Size = new System.Drawing.Size(98, 21);
            this.ckbxAutoriz.TabIndex = 4;
            this.ckbxAutoriz.Text = "Autorizado";
            this.ckbxAutoriz.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gestion........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes..............";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liquido Pagable.........";
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.Location = new System.Drawing.Point(8, 205);
            this.dgvPlanilla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlanilla.MultiSelect = false;
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.ReadOnly = true;
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(1218, 372);
            this.dgvPlanilla.TabIndex = 3;
            this.dgvPlanilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanilla_CellDoubleClick);
            this.dgvPlanilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanilla_RowEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnAgrFila);
            this.groupBox3.Controls.Add(this.btnImpBoleta);
            this.groupBox3.Controls.Add(this.btnBoletaPag);
            this.groupBox3.Controls.Add(this.btnElimFila);
            this.groupBox3.Controls.Add(this.btnProcesar);
            this.groupBox3.Location = new System.Drawing.Point(909, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(213, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAgrFila
            // 
            this.btnAgrFila.Location = new System.Drawing.Point(118, 46);
            this.btnAgrFila.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgrFila.Name = "btnAgrFila";
            this.btnAgrFila.Size = new System.Drawing.Size(94, 28);
            this.btnAgrFila.TabIndex = 3;
            this.btnAgrFila.Text = "Agregar Fila";
            this.btnAgrFila.UseVisualStyleBackColor = true;
            this.btnAgrFila.Click += new System.EventHandler(this.btnAgrFila_Click);
            // 
            // btnImpBoleta
            // 
            this.btnImpBoleta.Location = new System.Drawing.Point(118, 16);
            this.btnImpBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.btnImpBoleta.Name = "btnImpBoleta";
            this.btnImpBoleta.Size = new System.Drawing.Size(94, 28);
            this.btnImpBoleta.TabIndex = 2;
            this.btnImpBoleta.Text = "Imp. Boleta";
            this.btnImpBoleta.UseVisualStyleBackColor = true;
            this.btnImpBoleta.Click += new System.EventHandler(this.btnImpBoleta_Click);
            // 
            // btnBoletaPag
            // 
            this.btnBoletaPag.Location = new System.Drawing.Point(23, 16);
            this.btnBoletaPag.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoletaPag.Name = "btnBoletaPag";
            this.btnBoletaPag.Size = new System.Drawing.Size(94, 28);
            this.btnBoletaPag.TabIndex = 0;
            this.btnBoletaPag.Text = "Boleta Pago";
            this.btnBoletaPag.UseVisualStyleBackColor = true;
            this.btnBoletaPag.Click += new System.EventHandler(this.btnBoletaPag_Click);
            // 
            // btnElimFila
            // 
            this.btnElimFila.Location = new System.Drawing.Point(23, 46);
            this.btnElimFila.Margin = new System.Windows.Forms.Padding(4);
            this.btnElimFila.Name = "btnElimFila";
            this.btnElimFila.Size = new System.Drawing.Size(94, 28);
            this.btnElimFila.TabIndex = 1;
            this.btnElimFila.Text = "Elim. Fila";
            this.btnElimFila.UseVisualStyleBackColor = true;
            this.btnElimFila.Click += new System.EventHandler(this.btnElimFila_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(213, 46);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(94, 28);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // PlanillaSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 586);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvPlanilla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxBotones);
            this.MaximizeBox = false;
            this.Name = "PlanillaSueldo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planilla de Sueldo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanillaSueldo_FormClosing);
            this.Load += new System.EventHandler(this.PlanillaSueldo_Load);
            this.gbxBotones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboMesPla;
        private System.Windows.Forms.ComboBox cboGestionPla;
        private System.Windows.Forms.TextBox txtLiquidoPag;
        private System.Windows.Forms.CheckBox ckbxPag;
        private System.Windows.Forms.CheckBox ckbxAutoriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnImpBoleta;
        private System.Windows.Forms.Button btnBoletaPag;
        private System.Windows.Forms.Button btnElimFila;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnAgrFila;
        private System.Windows.Forms.DateTimePicker dtFechaPla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
    }
}