namespace GRTechnology1._0
{
    partial class Frm_RubroSubRubro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRubSRub = new System.Windows.Forms.DataGridView();
            this.gbRSRub = new System.Windows.Forms.GroupBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtRubroSubRubroID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAnul = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubSRub)).BeginInit();
            this.gbRSRub.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRubSRub, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbRSRub, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbxBotones, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvRubSRub
            // 
            this.dgvRubSRub.AllowUserToAddRows = false;
            this.dgvRubSRub.AllowUserToDeleteRows = false;
            this.dgvRubSRub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubSRub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRubSRub.Location = new System.Drawing.Point(3, 145);
            this.dgvRubSRub.MultiSelect = false;
            this.dgvRubSRub.Name = "dgvRubSRub";
            this.dgvRubSRub.ReadOnly = true;
            this.dgvRubSRub.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRubSRub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRubSRub.Size = new System.Drawing.Size(574, 212);
            this.dgvRubSRub.TabIndex = 6;
            this.dgvRubSRub.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubSRub_RowEnter);
            // 
            // gbRSRub
            // 
            this.gbRSRub.Controls.Add(this.cboTipo);
            this.gbRSRub.Controls.Add(this.label3);
            this.gbRSRub.Controls.Add(this.txtNom);
            this.gbRSRub.Controls.Add(this.txtRubroSubRubroID);
            this.gbRSRub.Controls.Add(this.label2);
            this.gbRSRub.Controls.Add(this.label1);
            this.gbRSRub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRSRub.Location = new System.Drawing.Point(3, 68);
            this.gbRSRub.Name = "gbRSRub";
            this.gbRSRub.Size = new System.Drawing.Size(574, 71);
            this.gbRSRub.TabIndex = 5;
            this.gbRSRub.TabStop = false;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Rubro",
            "SubRubro"});
            this.cboTipo.Location = new System.Drawing.Point(364, 40);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(201, 21);
            this.cboTipo.TabIndex = 5;
            this.cboTipo.SelectedValueChanged += new System.EventHandler(this.cboTipo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo.............";
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Location = new System.Drawing.Point(74, 41);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(187, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtRubroSubRubroID
            // 
            this.txtRubroSubRubroID.Location = new System.Drawing.Point(74, 17);
            this.txtRubroSubRubroID.Name = "txtRubroSubRubroID";
            this.txtRubroSubRubroID.ReadOnly = true;
            this.txtRubroSubRubroID.Size = new System.Drawing.Size(76, 20);
            this.txtRubroSubRubroID.TabIndex = 2;
            this.txtRubroSubRubroID.TabStop = false;
            this.txtRubroSubRubroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo..........";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.label4);
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnAnul);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Controls.Add(this.txtBuscar);
            this.gbxBotones.Location = new System.Drawing.Point(2, 2);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Size = new System.Drawing.Size(573, 60);
            this.gbxBotones.TabIndex = 7;
            this.gbxBotones.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "BUSCADOR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(386, 6);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(63, 50);
            this.btnReg.TabIndex = 19;
            this.btnReg.Text = "Registro";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(67, 6);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(63, 50);
            this.btnModif.TabIndex = 12;
            this.btnModif.Text = "Modificar";
            this.btnModif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAnul
            // 
            this.btnAnul.Location = new System.Drawing.Point(130, 6);
            this.btnAnul.Name = "btnAnul";
            this.btnAnul.Size = new System.Drawing.Size(63, 50);
            this.btnAnul.TabIndex = 13;
            this.btnAnul.Text = "Anular";
            this.btnAnul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnul.UseVisualStyleBackColor = true;
            this.btnAnul.Click += new System.EventHandler(this.btnAnul_Click);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(194, 6);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(63, 50);
            this.btnAct.TabIndex = 15;
            this.btnAct.Text = "Actualizar";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(258, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 50);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(322, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 50);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(63, 50);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(450, 32);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(118, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Frm_RubroSubRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(596, 399);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(596, 399);
            this.Name = "Frm_RubroSubRubro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rubro - SubRubro";
            this.Load += new System.EventHandler(this.RubroSubRubro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubSRub)).EndInit();
            this.gbRSRub.ResumeLayout(false);
            this.gbRSRub.PerformLayout();
            this.gbxBotones.ResumeLayout(false);
            this.gbxBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvRubSRub;
        private System.Windows.Forms.GroupBox gbRSRub;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtRubroSubRubroID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAnul;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}