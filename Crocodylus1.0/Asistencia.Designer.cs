namespace GRTechnology1._0
{
    partial class Asistencia
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
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.cboGestion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscPer = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.cboPer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.dtFecNota = new System.Windows.Forms.DateTimePicker();
            this.gbxDias = new System.Windows.Forms.GroupBox();
            this.txtDiaVacacion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDiaTempra = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtDiaExtras = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaFalta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiaAtrasos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiaPermi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbxHrs = new System.Windows.Forms.GroupBox();
            this.txtHrTempra = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtHrExtras = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHrFalta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHrAtrasos = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtHrPermi = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.gbxDias.SuspendLayout();
            this.gbxHrs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Controls.Add(this.cboGestion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscPer);
            this.groupBox1.Controls.Add(this.btnProc);
            this.groupBox1.Controls.Add(this.cboPer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(436, 23);
            this.cboMes.Margin = new System.Windows.Forms.Padding(4);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(183, 24);
            this.cboMes.TabIndex = 3;
            this.cboMes.SelectedValueChanged += new System.EventHandler(this.cboMesPla_SelectedValueChanged);
            // 
            // cboGestion
            // 
            this.cboGestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGestion.FormattingEnabled = true;
            this.cboGestion.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboGestion.Location = new System.Drawing.Point(715, 20);
            this.cboGestion.Margin = new System.Windows.Forms.Padding(4);
            this.cboGestion.Name = "cboGestion";
            this.cboGestion.Size = new System.Drawing.Size(97, 24);
            this.cboGestion.TabIndex = 4;
            this.cboGestion.SelectedValueChanged += new System.EventHandler(this.cboGestionPla_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gestion........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mes..............";
            // 
            // btnBuscPer
            // 
            this.btnBuscPer.Location = new System.Drawing.Point(339, 23);
            this.btnBuscPer.Name = "btnBuscPer";
            this.btnBuscPer.Size = new System.Drawing.Size(44, 23);
            this.btnBuscPer.TabIndex = 2;
            this.btnBuscPer.Text = "......";
            this.btnBuscPer.UseVisualStyleBackColor = true;
            this.btnBuscPer.Click += new System.EventHandler(this.btnBuscPer_Click);
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(832, 22);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(89, 23);
            this.btnProc.TabIndex = 5;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // cboPer
            // 
            this.cboPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPer.FormattingEnabled = true;
            this.cboPer.Location = new System.Drawing.Point(87, 21);
            this.cboPer.Name = "cboPer";
            this.cboPer.Size = new System.Drawing.Size(246, 24);
            this.cboPer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal............";
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(6, 160);
            this.dgvAsistencia.MultiSelect = false;
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencia.Size = new System.Drawing.Size(936, 362);
            this.dgvAsistencia.TabIndex = 4;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnImp);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnCancel);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Location = new System.Drawing.Point(6, 3);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(701, 84);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(397, 18);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(95, 52);
            this.btnImp.TabIndex = 4;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(301, 18);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(95, 52);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(589, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(493, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 52);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(205, 18);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(95, 52);
            this.btnAct.TabIndex = 2;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(109, 18);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(95, 52);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 52);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(951, 128);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(304, 478);
            this.dgvNotas.TabIndex = 3;
            this.dgvNotas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNotas_RowEnter);
            // 
            // dtFecNota
            // 
            this.dtFecNota.Location = new System.Drawing.Point(948, 100);
            this.dtFecNota.Name = "dtFecNota";
            this.dtFecNota.Size = new System.Drawing.Size(304, 22);
            this.dtFecNota.TabIndex = 2;
            this.dtFecNota.ValueChanged += new System.EventHandler(this.dtFecNota_ValueChanged);
            // 
            // gbxDias
            // 
            this.gbxDias.Controls.Add(this.txtDiaVacacion);
            this.gbxDias.Controls.Add(this.label24);
            this.gbxDias.Controls.Add(this.txtDiaTempra);
            this.gbxDias.Controls.Add(this.label23);
            this.gbxDias.Controls.Add(this.txtDiaExtras);
            this.gbxDias.Controls.Add(this.label11);
            this.gbxDias.Controls.Add(this.txtDiaFalta);
            this.gbxDias.Controls.Add(this.label12);
            this.gbxDias.Controls.Add(this.txtDiaAtrasos);
            this.gbxDias.Controls.Add(this.label13);
            this.gbxDias.Controls.Add(this.txtDiaPermi);
            this.gbxDias.Controls.Add(this.label14);
            this.gbxDias.Location = new System.Drawing.Point(469, 525);
            this.gbxDias.Name = "gbxDias";
            this.gbxDias.Size = new System.Drawing.Size(473, 81);
            this.gbxDias.TabIndex = 6;
            this.gbxDias.TabStop = false;
            this.gbxDias.Text = "Total Dias:";
            // 
            // txtDiaVacacion
            // 
            this.txtDiaVacacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaVacacion.Location = new System.Drawing.Point(391, 46);
            this.txtDiaVacacion.Name = "txtDiaVacacion";
            this.txtDiaVacacion.ReadOnly = true;
            this.txtDiaVacacion.Size = new System.Drawing.Size(67, 22);
            this.txtDiaVacacion.TabIndex = 5;
            this.txtDiaVacacion.TabStop = false;
            this.txtDiaVacacion.Text = "0";
            this.txtDiaVacacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(318, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 17);
            this.label24.TabIndex = 19;
            this.label24.Text = "Vacacion:";
            // 
            // txtDiaTempra
            // 
            this.txtDiaTempra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaTempra.Location = new System.Drawing.Point(240, 21);
            this.txtDiaTempra.Name = "txtDiaTempra";
            this.txtDiaTempra.ReadOnly = true;
            this.txtDiaTempra.Size = new System.Drawing.Size(67, 22);
            this.txtDiaTempra.TabIndex = 2;
            this.txtDiaTempra.TabStop = false;
            this.txtDiaTempra.Text = "0";
            this.txtDiaTempra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(161, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 17);
            this.label23.TabIndex = 17;
            this.label23.Text = "Temprano:";
            // 
            // txtDiaExtras
            // 
            this.txtDiaExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaExtras.Location = new System.Drawing.Point(240, 49);
            this.txtDiaExtras.Name = "txtDiaExtras";
            this.txtDiaExtras.ReadOnly = true;
            this.txtDiaExtras.Size = new System.Drawing.Size(67, 22);
            this.txtDiaExtras.TabIndex = 3;
            this.txtDiaExtras.TabStop = false;
            this.txtDiaExtras.Text = "0";
            this.txtDiaExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Extras:";
            // 
            // txtDiaFalta
            // 
            this.txtDiaFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaFalta.Location = new System.Drawing.Point(78, 51);
            this.txtDiaFalta.Name = "txtDiaFalta";
            this.txtDiaFalta.ReadOnly = true;
            this.txtDiaFalta.Size = new System.Drawing.Size(67, 22);
            this.txtDiaFalta.TabIndex = 1;
            this.txtDiaFalta.TabStop = false;
            this.txtDiaFalta.Text = "0";
            this.txtDiaFalta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Faltas:";
            // 
            // txtDiaAtrasos
            // 
            this.txtDiaAtrasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaAtrasos.Location = new System.Drawing.Point(78, 23);
            this.txtDiaAtrasos.Name = "txtDiaAtrasos";
            this.txtDiaAtrasos.ReadOnly = true;
            this.txtDiaAtrasos.Size = new System.Drawing.Size(67, 22);
            this.txtDiaAtrasos.TabIndex = 0;
            this.txtDiaAtrasos.TabStop = false;
            this.txtDiaAtrasos.Text = "0";
            this.txtDiaAtrasos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Atrasos:";
            // 
            // txtDiaPermi
            // 
            this.txtDiaPermi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaPermi.Location = new System.Drawing.Point(391, 21);
            this.txtDiaPermi.Name = "txtDiaPermi";
            this.txtDiaPermi.ReadOnly = true;
            this.txtDiaPermi.Size = new System.Drawing.Size(67, 22);
            this.txtDiaPermi.TabIndex = 4;
            this.txtDiaPermi.TabStop = false;
            this.txtDiaPermi.Text = "0";
            this.txtDiaPermi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(325, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Permiso:";
            // 
            // gbxHrs
            // 
            this.gbxHrs.Controls.Add(this.txtHrTempra);
            this.gbxHrs.Controls.Add(this.label22);
            this.gbxHrs.Controls.Add(this.txtHrExtras);
            this.gbxHrs.Controls.Add(this.label15);
            this.gbxHrs.Controls.Add(this.txtHrFalta);
            this.gbxHrs.Controls.Add(this.label19);
            this.gbxHrs.Controls.Add(this.txtHrAtrasos);
            this.gbxHrs.Controls.Add(this.label20);
            this.gbxHrs.Controls.Add(this.txtHrPermi);
            this.gbxHrs.Controls.Add(this.label21);
            this.gbxHrs.Location = new System.Drawing.Point(6, 525);
            this.gbxHrs.Name = "gbxHrs";
            this.gbxHrs.Size = new System.Drawing.Size(457, 81);
            this.gbxHrs.TabIndex = 5;
            this.gbxHrs.TabStop = false;
            this.gbxHrs.Text = "Total Horas:";
            // 
            // txtHrTempra
            // 
            this.txtHrTempra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrTempra.Location = new System.Drawing.Point(232, 21);
            this.txtHrTempra.Name = "txtHrTempra";
            this.txtHrTempra.ReadOnly = true;
            this.txtHrTempra.Size = new System.Drawing.Size(67, 22);
            this.txtHrTempra.TabIndex = 2;
            this.txtHrTempra.TabStop = false;
            this.txtHrTempra.Text = "0.00";
            this.txtHrTempra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(153, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 17);
            this.label22.TabIndex = 16;
            this.label22.Text = "Temprano:";
            // 
            // txtHrExtras
            // 
            this.txtHrExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrExtras.Location = new System.Drawing.Point(232, 48);
            this.txtHrExtras.Name = "txtHrExtras";
            this.txtHrExtras.ReadOnly = true;
            this.txtHrExtras.Size = new System.Drawing.Size(67, 22);
            this.txtHrExtras.TabIndex = 3;
            this.txtHrExtras.TabStop = false;
            this.txtHrExtras.Text = "0.00";
            this.txtHrExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(179, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Extras:";
            // 
            // txtHrFalta
            // 
            this.txtHrFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrFalta.Location = new System.Drawing.Point(75, 48);
            this.txtHrFalta.Name = "txtHrFalta";
            this.txtHrFalta.ReadOnly = true;
            this.txtHrFalta.Size = new System.Drawing.Size(67, 22);
            this.txtHrFalta.TabIndex = 1;
            this.txtHrFalta.TabStop = false;
            this.txtHrFalta.Text = "0.00";
            this.txtHrFalta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 17);
            this.label19.TabIndex = 12;
            this.label19.Text = "Faltas:";
            // 
            // txtHrAtrasos
            // 
            this.txtHrAtrasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrAtrasos.Location = new System.Drawing.Point(75, 21);
            this.txtHrAtrasos.Name = "txtHrAtrasos";
            this.txtHrAtrasos.ReadOnly = true;
            this.txtHrAtrasos.Size = new System.Drawing.Size(67, 22);
            this.txtHrAtrasos.TabIndex = 0;
            this.txtHrAtrasos.TabStop = false;
            this.txtHrAtrasos.Text = "0.00";
            this.txtHrAtrasos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 17);
            this.label20.TabIndex = 10;
            this.label20.Text = "Atrasos:";
            // 
            // txtHrPermi
            // 
            this.txtHrPermi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrPermi.Location = new System.Drawing.Point(381, 21);
            this.txtHrPermi.Name = "txtHrPermi";
            this.txtHrPermi.ReadOnly = true;
            this.txtHrPermi.Size = new System.Drawing.Size(67, 22);
            this.txtHrPermi.TabIndex = 4;
            this.txtHrPermi.TabStop = false;
            this.txtHrPermi.Text = "0.00";
            this.txtHrPermi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(316, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 8;
            this.label21.Text = "Permiso:";
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 612);
            this.Controls.Add(this.gbxDias);
            this.Controls.Add(this.gbxHrs);
            this.Controls.Add(this.dtFecNota);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1279, 659);
            this.MinimumSize = new System.Drawing.Size(1279, 659);
            this.Name = "Asistencia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Asistencia_FormClosing);
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.gbxDias.ResumeLayout(false);
            this.gbxDias.PerformLayout();
            this.gbxHrs.ResumeLayout(false);
            this.gbxHrs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnBuscPer;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.ComboBox cboGestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DateTimePicker dtFecNota;
        private System.Windows.Forms.GroupBox gbxDias;
        private System.Windows.Forms.TextBox txtDiaVacacion;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtDiaTempra;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDiaExtras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaFalta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiaAtrasos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiaPermi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbxHrs;
        private System.Windows.Forms.TextBox txtHrTempra;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtHrExtras;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHrFalta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHrAtrasos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtHrPermi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnImp;
    }
}