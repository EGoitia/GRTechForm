namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepComparacionVentasVendedores
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.rbtnCantidad = new System.Windows.Forms.RadioButton();
            this.rbtnMonto = new System.Windows.Forms.RadioButton();
            this.dtMes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCliProdVen = new System.Windows.Forms.ComboBox();
            this.lblCliProdVen = new System.Windows.Forms.Label();
            this.cboSuc = new System.Windows.Forms.ComboBox();
            this.ckbxSuc = new System.Windows.Forms.CheckBox();
            this.cboTipoVen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.chartRep = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRep)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.rbtnCantidad);
            this.gbxDatos.Controls.Add(this.rbtnMonto);
            this.gbxDatos.Controls.Add(this.dtMes);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.cboCliProdVen);
            this.gbxDatos.Controls.Add(this.lblCliProdVen);
            this.gbxDatos.Controls.Add(this.cboSuc);
            this.gbxDatos.Controls.Add(this.ckbxSuc);
            this.gbxDatos.Controls.Add(this.cboTipoVen);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.btnProcesar);
            this.gbxDatos.Location = new System.Drawing.Point(6, 3);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDatos.Size = new System.Drawing.Size(783, 86);
            this.gbxDatos.TabIndex = 1;
            this.gbxDatos.TabStop = false;
            // 
            // rbtnCantidad
            // 
            this.rbtnCantidad.AutoSize = true;
            this.rbtnCantidad.Location = new System.Drawing.Point(696, 23);
            this.rbtnCantidad.Name = "rbtnCantidad";
            this.rbtnCantidad.Size = new System.Drawing.Size(67, 17);
            this.rbtnCantidad.TabIndex = 12;
            this.rbtnCantidad.TabStop = true;
            this.rbtnCantidad.Text = "Cantidad";
            this.rbtnCantidad.UseVisualStyleBackColor = true;
            // 
            // rbtnMonto
            // 
            this.rbtnMonto.AutoSize = true;
            this.rbtnMonto.Checked = true;
            this.rbtnMonto.Location = new System.Drawing.Point(623, 23);
            this.rbtnMonto.Name = "rbtnMonto";
            this.rbtnMonto.Size = new System.Drawing.Size(55, 17);
            this.rbtnMonto.TabIndex = 11;
            this.rbtnMonto.TabStop = true;
            this.rbtnMonto.Text = "Monto";
            this.rbtnMonto.UseVisualStyleBackColor = true;
            // 
            // dtMes
            // 
            this.dtMes.CustomFormat = "MM yyyy";
            this.dtMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMes.Location = new System.Drawing.Point(78, 51);
            this.dtMes.Margin = new System.Windows.Forms.Padding(2);
            this.dtMes.Name = "dtMes";
            this.dtMes.ShowUpDown = true;
            this.dtMes.Size = new System.Drawing.Size(93, 20);
            this.dtMes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha:";
            // 
            // cboCliProdVen
            // 
            this.cboCliProdVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliProdVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliProdVen.FormattingEnabled = true;
            this.cboCliProdVen.Location = new System.Drawing.Point(354, 51);
            this.cboCliProdVen.Margin = new System.Windows.Forms.Padding(2);
            this.cboCliProdVen.Name = "cboCliProdVen";
            this.cboCliProdVen.Size = new System.Drawing.Size(242, 21);
            this.cboCliProdVen.TabIndex = 8;
            // 
            // lblCliProdVen
            // 
            this.lblCliProdVen.AutoSize = true;
            this.lblCliProdVen.Location = new System.Drawing.Point(272, 59);
            this.lblCliProdVen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliProdVen.Name = "lblCliProdVen";
            this.lblCliProdVen.Size = new System.Drawing.Size(56, 13);
            this.lblCliProdVen.TabIndex = 7;
            this.lblCliProdVen.Text = "Vendedor:";
            // 
            // cboSuc
            // 
            this.cboSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuc.Enabled = false;
            this.cboSuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSuc.FormattingEnabled = true;
            this.cboSuc.Location = new System.Drawing.Point(354, 19);
            this.cboSuc.Margin = new System.Windows.Forms.Padding(2);
            this.cboSuc.Name = "cboSuc";
            this.cboSuc.Size = new System.Drawing.Size(242, 21);
            this.cboSuc.TabIndex = 5;
            // 
            // ckbxSuc
            // 
            this.ckbxSuc.AutoSize = true;
            this.ckbxSuc.Location = new System.Drawing.Point(275, 23);
            this.ckbxSuc.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxSuc.Name = "ckbxSuc";
            this.ckbxSuc.Size = new System.Drawing.Size(70, 17);
            this.ckbxSuc.TabIndex = 6;
            this.ckbxSuc.Text = "Sucursal:";
            this.ckbxSuc.UseVisualStyleBackColor = true;
            this.ckbxSuc.CheckedChanged += new System.EventHandler(this.ckbxSuc_CheckedChanged);
            // 
            // cboTipoVen
            // 
            this.cboTipoVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVen.FormattingEnabled = true;
            this.cboTipoVen.Items.AddRange(new object[] {
            "Todas las Ventas",
            "Contado",
            "Credito"});
            this.cboTipoVen.Location = new System.Drawing.Point(78, 19);
            this.cboTipoVen.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoVen.Name = "cboTipoVen";
            this.cboTipoVen.Size = new System.Drawing.Size(145, 21);
            this.cboTipoVen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Venta:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(639, 45);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(87, 31);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // chartRep
            // 
            this.chartRep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartRep.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRep.Legends.Add(legend1);
            this.chartRep.Location = new System.Drawing.Point(6, 93);
            this.chartRep.Margin = new System.Windows.Forms.Padding(2);
            this.chartRep.Name = "chartRep";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 15;
            series1.Name = "Mes";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartRep.Series.Add(series1);
            this.chartRep.Size = new System.Drawing.Size(1002, 386);
            this.chartRep.TabIndex = 4;
            this.chartRep.Text = "chart1";
            // 
            // OpRepComparacionVentasVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 490);
            this.Controls.Add(this.chartRep);
            this.Controls.Add(this.gbxDatos);
            this.Name = "OpRepComparacionVentasVendedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparación de Ventas de Vendedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepComparacionVentasVendedores_FormClosing);
            this.Load += new System.EventHandler(this.OpRepComparacionVentasVendedores_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.ComboBox cboSuc;
        private System.Windows.Forms.ComboBox cboTipoVen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboCliProdVen;
        private System.Windows.Forms.Label lblCliProdVen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbxSuc;
        private System.Windows.Forms.DateTimePicker dtMes;
        private System.Windows.Forms.RadioButton rbtnCantidad;
        private System.Windows.Forms.RadioButton rbtnMonto;
    }
}