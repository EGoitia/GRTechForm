namespace GRTechnology1._0.Buscadores
{
    partial class Buscador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboTipoCli = new System.Windows.Forms.ComboBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.chkTipo = new System.Windows.Forms.CheckBox();
            this.lblNomBuscador = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnSeleccionar);
            this.groupBox5.Controls.Add(this.cboTipoCli);
            this.groupBox5.Controls.Add(this.txtBuscador);
            this.groupBox5.Controls.Add(this.chkTipo);
            this.groupBox5.Controls.Add(this.lblNomBuscador);
            this.groupBox5.Location = new System.Drawing.Point(7, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(719, 49);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscador:";
            // 
            // cboTipoCli
            // 
            this.cboTipoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCli.Enabled = false;
            this.cboTipoCli.FormattingEnabled = true;
            this.cboTipoCli.Location = new System.Drawing.Point(337, 18);
            this.cboTipoCli.Name = "cboTipoCli";
            this.cboTipoCli.Size = new System.Drawing.Size(159, 21);
            this.cboTipoCli.TabIndex = 3;
            this.cboTipoCli.SelectedIndexChanged += new System.EventHandler(this.cboTipoCli_SelectedIndexChanged);
            // 
            // txtBuscador
            // 
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscador.Location = new System.Drawing.Point(61, 19);
            this.txtBuscador.MaxLength = 25;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(170, 20);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // chkTipo
            // 
            this.chkTipo.AutoSize = true;
            this.chkTipo.Location = new System.Drawing.Point(254, 21);
            this.chkTipo.Name = "chkTipo";
            this.chkTipo.Size = new System.Drawing.Size(85, 17);
            this.chkTipo.TabIndex = 2;
            this.chkTipo.Text = "Tipo Cliente:";
            this.chkTipo.UseVisualStyleBackColor = true;
            this.chkTipo.CheckedChanged += new System.EventHandler(this.chkTipo_CheckedChanged);
            // 
            // lblNomBuscador
            // 
            this.lblNomBuscador.AutoSize = true;
            this.lblNomBuscador.Location = new System.Drawing.Point(17, 23);
            this.lblNomBuscador.Name = "lblNomBuscador";
            this.lblNomBuscador.Size = new System.Drawing.Size(42, 13);
            this.lblNomBuscador.TabIndex = 0;
            this.lblNomBuscador.Text = "Cliente:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.GridColor = System.Drawing.Color.Turquoise;
            this.dgvDatos.Location = new System.Drawing.Point(7, 73);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowTemplate.Height = 40;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(719, 321);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSeleccionar.Location = new System.Drawing.Point(517, 16);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 406);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox5);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buscador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCADOR";
            this.Load += new System.EventHandler(this.BusqCliente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscador_KeyPress);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label lblNomBuscador;
        public System.Windows.Forms.DataGridView dgvDatos;
        public System.Windows.Forms.ComboBox cboTipoCli;
        public System.Windows.Forms.CheckBox chkTipo;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}