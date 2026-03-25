namespace GRTechnology1._0
{
    partial class Frm_Detalle_Movimiento_Banco
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
            this.gbxTotales = new System.Windows.Forms.GroupBox();
            this.txtTotSaldo = new System.Windows.Forms.TextBox();
            this.txtTotSalida = new System.Windows.Forms.TextBox();
            this.txtTotEntrada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKardexBanco = new System.Windows.Forms.DataGridView();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnImp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtFecFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecInic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusqBanco = new System.Windows.Forms.Button();
            this.lblCliProv = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoReg = new System.Windows.Forms.Button();
            this.gbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardexBanco)).BeginInit();
            this.gbxBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTotales
            // 
            this.gbxTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxTotales.Controls.Add(this.txtTotSaldo);
            this.gbxTotales.Controls.Add(this.txtTotSalida);
            this.gbxTotales.Controls.Add(this.txtTotEntrada);
            this.gbxTotales.Controls.Add(this.label6);
            this.gbxTotales.Controls.Add(this.label5);
            this.gbxTotales.Controls.Add(this.label4);
            this.gbxTotales.Location = new System.Drawing.Point(5, 310);
            this.gbxTotales.Name = "gbxTotales";
            this.gbxTotales.Size = new System.Drawing.Size(765, 68);
            this.gbxTotales.TabIndex = 6;
            this.gbxTotales.TabStop = false;
            // 
            // txtTotSaldo
            // 
            this.txtTotSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSaldo.Location = new System.Drawing.Point(643, 28);
            this.txtTotSaldo.Name = "txtTotSaldo";
            this.txtTotSaldo.ReadOnly = true;
            this.txtTotSaldo.Size = new System.Drawing.Size(100, 21);
            this.txtTotSaldo.TabIndex = 5;
            this.txtTotSaldo.Text = "0.00";
            this.txtTotSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotSalida
            // 
            this.txtTotSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSalida.Location = new System.Drawing.Point(429, 28);
            this.txtTotSalida.Name = "txtTotSalida";
            this.txtTotSalida.ReadOnly = true;
            this.txtTotSalida.Size = new System.Drawing.Size(100, 21);
            this.txtTotSalida.TabIndex = 4;
            this.txtTotSalida.Text = "0.00";
            this.txtTotSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotEntrada
            // 
            this.txtTotEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotEntrada.Location = new System.Drawing.Point(165, 28);
            this.txtTotEntrada.Name = "txtTotEntrada";
            this.txtTotEntrada.ReadOnly = true;
            this.txtTotEntrada.Size = new System.Drawing.Size(100, 21);
            this.txtTotEntrada.TabIndex = 3;
            this.txtTotEntrada.Text = "0.00";
            this.txtTotEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(571, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "SALDO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(298, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "TOTAL SALIDA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL ENTRADA:";
            // 
            // dgvKardexBanco
            // 
            this.dgvKardexBanco.AllowUserToAddRows = false;
            this.dgvKardexBanco.AllowUserToDeleteRows = false;
            this.dgvKardexBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKardexBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKardexBanco.BackgroundColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKardexBanco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKardexBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKardexBanco.Location = new System.Drawing.Point(5, 78);
            this.dgvKardexBanco.Name = "dgvKardexBanco";
            this.dgvKardexBanco.ReadOnly = true;
            this.dgvKardexBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKardexBanco.Size = new System.Drawing.Size(1020, 226);
            this.dgvKardexBanco.TabIndex = 3;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBotones.Controls.Add(this.btnImp);
            this.gbxBotones.Location = new System.Drawing.Point(909, 310);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(116, 68);
            this.gbxBotones.TabIndex = 4;
            this.gbxBotones.TabStop = false;
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(11, 16);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(91, 42);
            this.btnImp.TabIndex = 2;
            this.btnImp.Text = "Imprimir";
            this.btnImp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProc);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dtFecFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFecInic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBusqBanco);
            this.groupBox1.Controls.Add(this.lblCliProv);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(807, 13);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(91, 42);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "Procesar";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(73, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(37, 20);
            this.txtID.TabIndex = 16;
            this.txtID.Text = "-1";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.Visible = false;
            // 
            // dtFecFin
            // 
            this.dtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecFin.Location = new System.Drawing.Point(688, 19);
            this.dtFecFin.Name = "dtFecFin";
            this.dtFecFin.Size = new System.Drawing.Size(98, 20);
            this.dtFecFin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Al:";
            // 
            // dtFecInic
            // 
            this.dtFecInic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecInic.Location = new System.Drawing.Point(550, 19);
            this.dtFecInic.Name = "dtFecInic";
            this.dtFecInic.Size = new System.Drawing.Size(97, 20);
            this.dtFecInic.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha del:";
            // 
            // btnBusqBanco
            // 
            this.btnBusqBanco.Location = new System.Drawing.Point(435, 17);
            this.btnBusqBanco.Name = "btnBusqBanco";
            this.btnBusqBanco.Size = new System.Drawing.Size(35, 23);
            this.btnBusqBanco.TabIndex = 2;
            this.btnBusqBanco.Text = ".....";
            this.btnBusqBanco.UseVisualStyleBackColor = true;
            this.btnBusqBanco.Click += new System.EventHandler(this.btnBusqBanco_Click);
            // 
            // lblCliProv
            // 
            this.lblCliProv.AutoSize = true;
            this.lblCliProv.Location = new System.Drawing.Point(23, 23);
            this.lblCliProv.Name = "lblCliProv";
            this.lblCliProv.Size = new System.Drawing.Size(35, 13);
            this.lblCliProv.TabIndex = 0;
            this.lblCliProv.Text = "Bano:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(356, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // btnNuevoReg
            // 
            this.btnNuevoReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoReg.Location = new System.Drawing.Point(934, 18);
            this.btnNuevoReg.Name = "btnNuevoReg";
            this.btnNuevoReg.Size = new System.Drawing.Size(91, 42);
            this.btnNuevoReg.TabIndex = 7;
            this.btnNuevoReg.Text = "Nuevo Registro";
            this.btnNuevoReg.UseVisualStyleBackColor = true;
            this.btnNuevoReg.Click += new System.EventHandler(this.btnNuevoReg_Click);
            // 
            // Frm_Detalle_Movimiento_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 384);
            this.Controls.Add(this.btnNuevoReg);
            this.Controls.Add(this.gbxTotales);
            this.Controls.Add(this.dgvKardexBanco);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Detalle_Movimiento_Banco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de Banco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Movimiento_Banco_FormClosing);
            this.gbxTotales.ResumeLayout(false);
            this.gbxTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKardexBanco)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTotales;
        private System.Windows.Forms.TextBox txtTotSaldo;
        private System.Windows.Forms.TextBox txtTotSalida;
        private System.Windows.Forms.TextBox txtTotEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKardexBanco;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.DateTimePicker dtFecFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecInic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBusqBanco;
        private System.Windows.Forms.Label lblCliProv;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnNuevoReg;
    }
}