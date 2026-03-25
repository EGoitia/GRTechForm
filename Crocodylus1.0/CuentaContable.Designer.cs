namespace GRTechnology1._0
{
    partial class CuentaContable
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
            this.tabControlCCont = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImp = new System.Windows.Forms.Button();
            this.ckDesplegar = new System.Windows.Forms.CheckBox();
            this.ckCodigo = new System.Windows.Forms.CheckBox();
            this.tvCuentas = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCuentCont = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabControlCCont.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentCont)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCCont
            // 
            this.tabControlCCont.Controls.Add(this.tabPage1);
            this.tabControlCCont.Controls.Add(this.tabPage2);
            this.tabControlCCont.Location = new System.Drawing.Point(12, 12);
            this.tabControlCCont.Name = "tabControlCCont";
            this.tabControlCCont.SelectedIndex = 0;
            this.tabControlCCont.Size = new System.Drawing.Size(740, 524);
            this.tabControlCCont.TabIndex = 10;
            this.tabControlCCont.SelectedIndexChanged += new System.EventHandler(this.tabControlCCont_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImp);
            this.tabPage1.Controls.Add(this.ckDesplegar);
            this.tabPage1.Controls.Add(this.ckCodigo);
            this.tabPage1.Controls.Add(this.tvCuentas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista Previa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(201, 8);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(88, 31);
            this.btnImp.TabIndex = 13;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // ckDesplegar
            // 
            this.ckDesplegar.AutoSize = true;
            this.ckDesplegar.Location = new System.Drawing.Point(99, 18);
            this.ckDesplegar.Margin = new System.Windows.Forms.Padding(4);
            this.ckDesplegar.Name = "ckDesplegar";
            this.ckDesplegar.Size = new System.Drawing.Size(95, 21);
            this.ckDesplegar.TabIndex = 12;
            this.ckDesplegar.Text = "Desplegar";
            this.ckDesplegar.UseVisualStyleBackColor = true;
            this.ckDesplegar.CheckedChanged += new System.EventHandler(this.ckDesplegar_CheckedChanged);
            // 
            // ckCodigo
            // 
            this.ckCodigo.AutoSize = true;
            this.ckCodigo.Checked = true;
            this.ckCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCodigo.Location = new System.Drawing.Point(17, 18);
            this.ckCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.ckCodigo.Name = "ckCodigo";
            this.ckCodigo.Size = new System.Drawing.Size(74, 21);
            this.ckCodigo.TabIndex = 11;
            this.ckCodigo.Text = "Codigo";
            this.ckCodigo.UseVisualStyleBackColor = true;
            this.ckCodigo.CheckedChanged += new System.EventHandler(this.ckCodigo_CheckedChanged);
            // 
            // tvCuentas
            // 
            this.tvCuentas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tvCuentas.Location = new System.Drawing.Point(17, 46);
            this.tvCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.tvCuentas.Name = "tvCuentas";
            this.tvCuentas.Size = new System.Drawing.Size(699, 434);
            this.tvCuentas.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCuentCont);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert-Modif Cuentas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCuentCont
            // 
            this.dgvCuentCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentCont.Location = new System.Drawing.Point(14, 75);
            this.dgvCuentCont.MultiSelect = false;
            this.dgvCuentCont.Name = "dgvCuentCont";
            this.dgvCuentCont.ReadOnly = true;
            this.dgvCuentCont.RowTemplate.Height = 24;
            this.dgvCuentCont.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentCont.Size = new System.Drawing.Size(699, 404);
            this.dgvCuentCont.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAct);
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(213, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(297, 58);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(193, 13);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(88, 38);
            this.btnAct.TabIndex = 9;
            this.btnAct.Text = "Actualizar";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(104, 13);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(88, 38);
            this.btnModif.TabIndex = 8;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(15, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 38);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Location = new System.Drawing.Point(14, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(191, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 21);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 22);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // CuentaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 549);
            this.Controls.Add(this.tabControlCCont);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 596);
            this.MinimumSize = new System.Drawing.Size(785, 596);
            this.Name = "CuentaContable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Cuentas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CuentaContable_FormClosing);
            this.Load += new System.EventHandler(this.CuentaContable_Load);
            this.tabControlCCont.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentCont)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCCont;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView tvCuentas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCuentCont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.CheckBox ckDesplegar;
        private System.Windows.Forms.CheckBox ckCodigo;
        private System.Windows.Forms.Button btnAct;

    }
}