namespace GRTechnology1._0.OpcioRep
{
    partial class OpRepComparacionVentas
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
            this.cboSuc = new System.Windows.Forms.ComboBox();
            this.ckbxSuc = new System.Windows.Forms.CheckBox();
            this.cboTipoVen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dtAnio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chartRep = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxEspecif = new System.Windows.Forms.GroupBox();
            this.cboTipoBusq = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboCliProdVen = new System.Windows.Forms.ComboBox();
            this.lblCliProdVen = new System.Windows.Forms.Label();
            this.ckbxEspecif = new System.Windows.Forms.CheckBox();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRep)).BeginInit();
            this.gbxEspecif.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cboSuc);
            this.gbxDatos.Controls.Add(this.ckbxSuc);
            this.gbxDatos.Controls.Add(this.cboTipoVen);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Controls.Add(this.btnProcesar);
            this.gbxDatos.Controls.Add(this.dtAnio);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Location = new System.Drawing.Point(7, 3);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDatos.Size = new System.Drawing.Size(676, 48);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            // 
            // cboSuc
            // 
            this.cboSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSuc.FormattingEnabled = true;
            this.cboSuc.Location = new System.Drawing.Point(430, 19);
            this.cboSuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSuc.Name = "cboSuc";
            this.cboSuc.Size = new System.Drawing.Size(166, 21);
            this.cboSuc.TabIndex = 5;
            // 
            // ckbxSuc
            // 
            this.ckbxSuc.AutoSize = true;
            this.ckbxSuc.Location = new System.Drawing.Point(358, 24);
            this.ckbxSuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbxSuc.Name = "ckbxSuc";
            this.ckbxSuc.Size = new System.Drawing.Size(82, 17);
            this.ckbxSuc.TabIndex = 6;
            this.ckbxSuc.Text = "Sucursal.....";
            this.ckbxSuc.UseVisualStyleBackColor = true;
            this.ckbxSuc.CheckedChanged += new System.EventHandler(this.ckbxSuc_CheckedChanged);
            // 
            // cboTipoVen
            // 
            this.cboTipoVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoVen.FormattingEnabled = true;
            this.cboTipoVen.Items.AddRange(new object[] {
            "Todas",
            "Contado",
            "Credito"});
            this.cboTipoVen.Location = new System.Drawing.Point(193, 19);
            this.cboTipoVen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoVen.Name = "cboTipoVen";
            this.cboTipoVen.Size = new System.Drawing.Size(145, 21);
            this.cboTipoVen.TabIndex = 4;
            this.cboTipoVen.SelectedValueChanged += new System.EventHandler(this.cboTipoVen_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Venta.......";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(599, 17);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(68, 21);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dtAnio
            // 
            this.dtAnio.CustomFormat = "yyyy";
            this.dtAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAnio.Location = new System.Drawing.Point(51, 20);
            this.dtAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtAnio.Name = "dtAnio";
            this.dtAnio.ShowUpDown = true;
            this.dtAnio.Size = new System.Drawing.Size(64, 20);
            this.dtAnio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año........";
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
            this.chartRep.Location = new System.Drawing.Point(9, 102);
            this.chartRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartRep.Name = "chartRep";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 15;
            series1.Name = "Mes";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartRep.Series.Add(series1);
            this.chartRep.Size = new System.Drawing.Size(808, 363);
            this.chartRep.TabIndex = 3;
            this.chartRep.Text = "chart1";
            // 
            // gbxEspecif
            // 
            this.gbxEspecif.Controls.Add(this.cboTipoBusq);
            this.gbxEspecif.Controls.Add(this.label3);
            this.gbxEspecif.Controls.Add(this.btnBuscar);
            this.gbxEspecif.Controls.Add(this.cboCliProdVen);
            this.gbxEspecif.Controls.Add(this.lblCliProdVen);
            this.gbxEspecif.Location = new System.Drawing.Point(129, 54);
            this.gbxEspecif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxEspecif.Name = "gbxEspecif";
            this.gbxEspecif.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxEspecif.Size = new System.Drawing.Size(554, 43);
            this.gbxEspecif.TabIndex = 4;
            this.gbxEspecif.TabStop = false;
            // 
            // cboTipoBusq
            // 
            this.cboTipoBusq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBusq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoBusq.FormattingEnabled = true;
            this.cboTipoBusq.Items.AddRange(new object[] {
            "Cliente",
            "Vendedor",
            "--------------",
            "Rubro",
            "SubRubro",
            "Producto"});
            this.cboTipoBusq.Location = new System.Drawing.Point(84, 15);
            this.cboTipoBusq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoBusq.Name = "cboTipoBusq";
            this.cboTipoBusq.Size = new System.Drawing.Size(121, 21);
            this.cboTipoBusq.TabIndex = 7;
            this.cboTipoBusq.SelectedValueChanged += new System.EventHandler(this.cboTipoBusq_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por.........";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(518, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 19);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = ".....";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboCliProdVen
            // 
            this.cboCliProdVen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliProdVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliProdVen.FormattingEnabled = true;
            this.cboCliProdVen.Location = new System.Drawing.Point(272, 13);
            this.cboCliProdVen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCliProdVen.Name = "cboCliProdVen";
            this.cboCliProdVen.Size = new System.Drawing.Size(242, 21);
            this.cboCliProdVen.TabIndex = 4;
            // 
            // lblCliProdVen
            // 
            this.lblCliProdVen.AutoSize = true;
            this.lblCliProdVen.Location = new System.Drawing.Point(217, 21);
            this.lblCliProdVen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliProdVen.Name = "lblCliProdVen";
            this.lblCliProdVen.Size = new System.Drawing.Size(63, 13);
            this.lblCliProdVen.TabIndex = 3;
            this.lblCliProdVen.Text = "Cliente........";
            // 
            // ckbxEspecif
            // 
            this.ckbxEspecif.AutoSize = true;
            this.ckbxEspecif.Location = new System.Drawing.Point(10, 70);
            this.ckbxEspecif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbxEspecif.Name = "ckbxEspecif";
            this.ckbxEspecif.Size = new System.Drawing.Size(107, 17);
            this.ckbxEspecif.TabIndex = 7;
            this.ckbxEspecif.Text = "Busq. Específica";
            this.ckbxEspecif.UseVisualStyleBackColor = true;
            this.ckbxEspecif.CheckedChanged += new System.EventHandler(this.ckbxEspecif_CheckedChanged);
            // 
            // OpRepComparacionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 474);
            this.Controls.Add(this.ckbxEspecif);
            this.Controls.Add(this.gbxEspecif);
            this.Controls.Add(this.chartRep);
            this.Controls.Add(this.gbxDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "OpRepComparacionVentas";
            this.ShowIcon = false;
            this.Text = "Comparacion de Ventas por Meses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpRepComparacionVentas_FormClosing);
            this.Load += new System.EventHandler(this.OpRepComparacionVentas_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRep)).EndInit();
            this.gbxEspecif.ResumeLayout(false);
            this.gbxEspecif.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.DateTimePicker dtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRep;
        private System.Windows.Forms.ComboBox cboTipoVen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSuc;
        private System.Windows.Forms.CheckBox ckbxSuc;
        private System.Windows.Forms.GroupBox gbxEspecif;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboCliProdVen;
        private System.Windows.Forms.Label lblCliProdVen;
        private System.Windows.Forms.CheckBox ckbxEspecif;
        private System.Windows.Forms.ComboBox cboTipoBusq;
        private System.Windows.Forms.Label label3;
    }
}