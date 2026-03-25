namespace GRTechnology1._0
{
    partial class ControlChequera
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
            this.tabControlChequera = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvChequesPendientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaCheqCobr = new System.Windows.Forms.DateTimePicker();
            this.dgvChequeCobrados = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.tabControlChequera.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesPendientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequeCobrados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlChequera
            // 
            this.tabControlChequera.Controls.Add(this.tabPage1);
            this.tabControlChequera.Controls.Add(this.tabPage2);
            this.tabControlChequera.Location = new System.Drawing.Point(8, 4);
            this.tabControlChequera.Name = "tabControlChequera";
            this.tabControlChequera.SelectedIndex = 0;
            this.tabControlChequera.Size = new System.Drawing.Size(1309, 531);
            this.tabControlChequera.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.dgvChequesPendientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1301, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cheques Pendientes";
            // 
            // dgvChequesPendientes
            // 
            this.dgvChequesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChequesPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChequesPendientes.Location = new System.Drawing.Point(3, 3);
            this.dgvChequesPendientes.MultiSelect = false;
            this.dgvChequesPendientes.Name = "dgvChequesPendientes";
            this.dgvChequesPendientes.ReadOnly = true;
            this.dgvChequesPendientes.RowTemplate.Height = 24;
            this.dgvChequesPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequesPendientes.Size = new System.Drawing.Size(1295, 496);
            this.dgvChequesPendientes.TabIndex = 0;
            this.dgvChequesPendientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChequesPendientes_RowEnter);
            this.dgvChequesPendientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvChequesPendientes_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dgvChequeCobrados);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1301, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cheques Cobrados/Anulados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaCheqCobr);
            this.groupBox1.Location = new System.Drawing.Point(992, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha";
            // 
            // dtFechaCheqCobr
            // 
            this.dtFechaCheqCobr.Location = new System.Drawing.Point(17, 21);
            this.dtFechaCheqCobr.Name = "dtFechaCheqCobr";
            this.dtFechaCheqCobr.Size = new System.Drawing.Size(270, 22);
            this.dtFechaCheqCobr.TabIndex = 0;
            // 
            // dgvChequeCobrados
            // 
            this.dgvChequeCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChequeCobrados.Location = new System.Drawing.Point(3, 72);
            this.dgvChequeCobrados.MultiSelect = false;
            this.dgvChequeCobrados.Name = "dgvChequeCobrados";
            this.dgvChequeCobrados.ReadOnly = true;
            this.dgvChequeCobrados.RowTemplate.Height = 24;
            this.dgvChequeCobrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChequeCobrados.Size = new System.Drawing.Size(1295, 427);
            this.dgvChequeCobrados.TabIndex = 0;
            this.dgvChequeCobrados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChequeCobrados_RowEnter);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscador);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(14, 23);
            this.txtBuscador.MaxLength = 25;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(193, 22);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // ControlChequera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 540);
            this.Controls.Add(this.tabControlChequera);
            this.MaximizeBox = false;
            this.Name = "ControlChequera";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Cheques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlChequera_FormClosing);
            this.Load += new System.EventHandler(this.ControlChequera_Load);
            this.tabControlChequera.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequesPendientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChequeCobrados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChequera;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvChequesPendientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvChequeCobrados;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaCheqCobr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscador;
    }
}