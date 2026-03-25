namespace GRTechnology1._0
{
    partial class Frm_TipoCambio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDownVenta = new System.Windows.Forms.NumericUpDown();
            this.numUpDownCompra = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecNota = new System.Windows.Forms.DateTimePicker();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.gbxBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnReg);
            this.gbxBotones.Controls.Add(this.btnModif);
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Location = new System.Drawing.Point(8, 3);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Size = new System.Drawing.Size(241, 81);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(156, 14);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(70, 59);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Registro";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(82, 14);
            this.btnModif.Margin = new System.Windows.Forms.Padding(2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(70, 59);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(8, 14);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 59);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numUpDownVenta);
            this.groupBox1.Controls.Add(this.numUpDownCompra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(461, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(65, 17);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(106, 20);
            this.dtFecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // numUpDownVenta
            // 
            this.numUpDownVenta.DecimalPlaces = 2;
            this.numUpDownVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numUpDownVenta.Location = new System.Drawing.Point(371, 17);
            this.numUpDownVenta.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDownVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownVenta.Name = "numUpDownVenta";
            this.numUpDownVenta.Size = new System.Drawing.Size(72, 20);
            this.numUpDownVenta.TabIndex = 3;
            this.numUpDownVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownCompra
            // 
            this.numUpDownCompra.DecimalPlaces = 2;
            this.numUpDownCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numUpDownCompra.Location = new System.Drawing.Point(236, 17);
            this.numUpDownCompra.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDownCompra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownCompra.Name = "numUpDownCompra";
            this.numUpDownCompra.Size = new System.Drawing.Size(72, 20);
            this.numUpDownCompra.TabIndex = 2;
            this.numUpDownCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownCompra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra:";
            // 
            // dtFecNota
            // 
            this.dtFecNota.Enabled = false;
            this.dtFecNota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecNota.Location = new System.Drawing.Point(91, 17);
            this.dtFecNota.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecNota.Name = "dtFecNota";
            this.dtFecNota.Size = new System.Drawing.Size(104, 20);
            this.dtFecNota.TabIndex = 4;
            this.dtFecNota.ValueChanged += new System.EventHandler(this.dtFecNota_ValueChanged);
            // 
            // dgvTC
            // 
            this.dgvTC.AllowUserToAddRows = false;
            this.dgvTC.AllowUserToDeleteRows = false;
            this.dgvTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTC.Location = new System.Drawing.Point(8, 196);
            this.dgvTC.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTC.MultiSelect = false;
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.ReadOnly = true;
            this.dgvTC.RowTemplate.Height = 24;
            this.dgvTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTC.Size = new System.Drawing.Size(461, 180);
            this.dgvTC.TabIndex = 3;
            this.dgvTC.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTC_RowEnter);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(24, 19);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(59, 17);
            this.chkFecha.TabIndex = 5;
            this.chkFecha.Text = "Fecha:";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.chkFecha);
            this.gbxFiltro.Controls.Add(this.dtFecNota);
            this.gbxFiltro.Location = new System.Drawing.Point(8, 142);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(211, 48);
            this.gbxFiltro.TabIndex = 6;
            this.gbxFiltro.TabStop = false;
            // 
            // Frm_TipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 383);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.dgvTC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBotones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TipoCambio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOLSÍN";
            this.Load += new System.EventHandler(this.TipoCambio_Load);
            this.gbxBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUpDownVenta;
        private System.Windows.Forms.NumericUpDown numUpDownCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecNota;
        private System.Windows.Forms.DataGridView dgvTC;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.GroupBox gbxFiltro;
    }
}