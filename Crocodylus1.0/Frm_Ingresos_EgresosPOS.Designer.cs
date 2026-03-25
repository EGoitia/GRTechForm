namespace GRTechnology1._0
{
    partial class Frm_Ingresos_EgresosPOS
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
            this.panelPrin = new System.Windows.Forms.Panel();
            this.panelEgreso = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.txtMontoBs = new System.Windows.Forms.TextBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelCuentas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTipoEgreso = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTipoEgreso = new System.Windows.Forms.Label();
            this.txtBusqProd = new System.Windows.Forms.TextBox();
            this.lblBusqProd = new System.Windows.Forms.Label();
            this.btnAbrirMenu = new System.Windows.Forms.Button();
            this.panelPrin.SuspendLayout();
            this.panelEgreso.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrin
            // 
            this.panelPrin.Controls.Add(this.panelEgreso);
            this.panelPrin.Controls.Add(this.panelLeft);
            this.panelPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrin.Location = new System.Drawing.Point(0, 0);
            this.panelPrin.Name = "panelPrin";
            this.panelPrin.Size = new System.Drawing.Size(1075, 399);
            this.panelPrin.TabIndex = 0;
            // 
            // panelEgreso
            // 
            this.panelEgreso.Controls.Add(this.btnConfig);
            this.panelEgreso.Controls.Add(this.txtMontoBs);
            this.panelEgreso.Controls.Add(this.cboTipoPago);
            this.panelEgreso.Controls.Add(this.label4);
            this.panelEgreso.Controls.Add(this.label5);
            this.panelEgreso.Controls.Add(this.cboCaja);
            this.panelEgreso.Controls.Add(this.label2);
            this.panelEgreso.Controls.Add(this.gbxBotones);
            this.panelEgreso.Controls.Add(this.txtDetalle);
            this.panelEgreso.Controls.Add(this.txtConcepto);
            this.panelEgreso.Controls.Add(this.label3);
            this.panelEgreso.Controls.Add(this.label1);
            this.panelEgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEgreso.Location = new System.Drawing.Point(455, 0);
            this.panelEgreso.Name = "panelEgreso";
            this.panelEgreso.Size = new System.Drawing.Size(620, 399);
            this.panelEgreso.TabIndex = 1;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.Window;
            this.btnConfig.BackgroundImage = global::GRTechnology1._0.Properties.Resources.ajustes_con_engranajes;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Location = new System.Drawing.Point(538, 93);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(25, 22);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // txtMontoBs
            // 
            this.txtMontoBs.Location = new System.Drawing.Point(72, 241);
            this.txtMontoBs.MaxLength = 10;
            this.txtMontoBs.Name = "txtMontoBs";
            this.txtMontoBs.Size = new System.Drawing.Size(74, 20);
            this.txtMontoBs.TabIndex = 51;
            this.txtMontoBs.Text = "0.00";
            this.txtMontoBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "INGRESO",
            "EGRESO"});
            this.cboTipoPago.Location = new System.Drawing.Point(72, 209);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(201, 21);
            this.cboTipoPago.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tipo Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Monto Bs.:";
            // 
            // cboCaja
            // 
            this.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(72, 173);
            this.cboCaja.Margin = new System.Windows.Forms.Padding(2);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(201, 21);
            this.cboCaja.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Caja:";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBotones.Controls.Add(this.btnGuardar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnAct);
            this.gbxBotones.Location = new System.Drawing.Point(6, 4);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBotones.Size = new System.Drawing.Size(603, 84);
            this.gbxBotones.TabIndex = 9;
            this.gbxBotones.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.Location = new System.Drawing.Point(397, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 60);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCancelar.Location = new System.Drawing.Point(462, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 60);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAct
            // 
            this.btnAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAct.Location = new System.Drawing.Point(528, 14);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(64, 60);
            this.btnAct.TabIndex = 3;
            this.btnAct.Text = "Actualizar";
            this.btnAct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Location = new System.Drawing.Point(72, 121);
            this.txtDetalle.MaxLength = 150;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalle.Size = new System.Drawing.Size(460, 44);
            this.txtDetalle.TabIndex = 8;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConcepto.Location = new System.Drawing.Point(72, 95);
            this.txtConcepto.MaxLength = 50;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(460, 20);
            this.txtConcepto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Concepto:";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Crimson;
            this.panelLeft.Controls.Add(this.panelCuentas);
            this.panelLeft.Controls.Add(this.panelTipoEgreso);
            this.panelLeft.Controls.Add(this.panel5);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(455, 399);
            this.panelLeft.TabIndex = 0;
            // 
            // panelCuentas
            // 
            this.panelCuentas.AutoScroll = true;
            this.panelCuentas.BackColor = System.Drawing.SystemColors.Control;
            this.panelCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuentas.Location = new System.Drawing.Point(117, 46);
            this.panelCuentas.Name = "panelCuentas";
            this.panelCuentas.Size = new System.Drawing.Size(338, 353);
            this.panelCuentas.TabIndex = 11;
            // 
            // panelTipoEgreso
            // 
            this.panelTipoEgreso.AutoScroll = true;
            this.panelTipoEgreso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTipoEgreso.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTipoEgreso.Location = new System.Drawing.Point(0, 46);
            this.panelTipoEgreso.Name = "panelTipoEgreso";
            this.panelTipoEgreso.Size = new System.Drawing.Size(117, 353);
            this.panelTipoEgreso.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.lblTipoEgreso);
            this.panel5.Controls.Add(this.txtBusqProd);
            this.panel5.Controls.Add(this.lblBusqProd);
            this.panel5.Controls.Add(this.btnAbrirMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 46);
            this.panel5.TabIndex = 9;
            // 
            // lblTipoEgreso
            // 
            this.lblTipoEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEgreso.Location = new System.Drawing.Point(246, 10);
            this.lblTipoEgreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoEgreso.Name = "lblTipoEgreso";
            this.lblTipoEgreso.Size = new System.Drawing.Size(177, 19);
            this.lblTipoEgreso.TabIndex = 5;
            this.lblTipoEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBusqProd
            // 
            this.txtBusqProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBusqProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBusqProd.Location = new System.Drawing.Point(106, 11);
            this.txtBusqProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqProd.MaxLength = 50;
            this.txtBusqProd.Name = "txtBusqProd";
            this.txtBusqProd.Size = new System.Drawing.Size(137, 20);
            this.txtBusqProd.TabIndex = 3;
            // 
            // lblBusqProd
            // 
            this.lblBusqProd.AutoSize = true;
            this.lblBusqProd.Location = new System.Drawing.Point(9, 18);
            this.lblBusqProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqProd.Name = "lblBusqProd";
            this.lblBusqProd.Size = new System.Drawing.Size(100, 13);
            this.lblBusqProd.TabIndex = 4;
            this.lblBusqProd.Text = "Buscar cuenta........";
            // 
            // btnAbrirMenu
            // 
            this.btnAbrirMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirMenu.BackgroundImage = global::GRTechnology1._0.Properties.Resources.if_menu_24_103174;
            this.btnAbrirMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirMenu.Location = new System.Drawing.Point(422, 4);
            this.btnAbrirMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirMenu.Name = "btnAbrirMenu";
            this.btnAbrirMenu.Size = new System.Drawing.Size(33, 36);
            this.btnAbrirMenu.TabIndex = 2;
            this.btnAbrirMenu.UseVisualStyleBackColor = true;
            this.btnAbrirMenu.Click += new System.EventHandler(this.btnAbrirMenu_Click);
            // 
            // Frm_Ingresos_EgresosPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 399);
            this.Controls.Add(this.panelPrin);
            this.Name = "Frm_Ingresos_EgresosPOS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Ingresos_EgresosPOS_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Ingresos_EgresosPOS_Load);
            this.panelPrin.ResumeLayout(false);
            this.panelEgreso.ResumeLayout(false);
            this.panelEgreso.PerformLayout();
            this.gbxBotones.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrin;
        private System.Windows.Forms.Panel panelEgreso;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTipoEgreso;
        private System.Windows.Forms.TextBox txtBusqProd;
        private System.Windows.Forms.Label lblBusqProd;
        private System.Windows.Forms.Button btnAbrirMenu;
        private System.Windows.Forms.FlowLayoutPanel panelTipoEgreso;
        private System.Windows.Forms.FlowLayoutPanel panelCuentas;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoBs;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}