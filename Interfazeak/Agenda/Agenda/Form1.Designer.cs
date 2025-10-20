namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Izenatb = new System.Windows.Forms.TextBox();
            this.Abizenatb = new System.Windows.Forms.TextBox();
            this.Teleftb = new System.Windows.Forms.TextBox();
            this.Prefijotb = new System.Windows.Forms.TextBox();
            this.Generocb = new System.Windows.Forms.ComboBox();
            this.Gordebtn = new System.Windows.Forms.Button();
            this.Ikusibtn = new System.Windows.Forms.Button();
            this.Bilatubtn = new System.Windows.Forms.Button();
            this.izenaTaula = new System.Windows.Forms.TableLayoutPanel();
            this.Grafikoa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userControl11 = new LibraryChartPrefijo2.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.Grafikoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abizena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Generoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prefijoa";
            // 
            // Izenatb
            // 
            this.Izenatb.Location = new System.Drawing.Point(129, 39);
            this.Izenatb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Izenatb.Name = "Izenatb";
            this.Izenatb.Size = new System.Drawing.Size(100, 22);
            this.Izenatb.TabIndex = 5;
            // 
            // Abizenatb
            // 
            this.Abizenatb.Location = new System.Drawing.Point(129, 78);
            this.Abizenatb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abizenatb.Name = "Abizenatb";
            this.Abizenatb.Size = new System.Drawing.Size(100, 22);
            this.Abizenatb.TabIndex = 6;
            // 
            // Teleftb
            // 
            this.Teleftb.Location = new System.Drawing.Point(129, 113);
            this.Teleftb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Teleftb.Name = "Teleftb";
            this.Teleftb.Size = new System.Drawing.Size(100, 22);
            this.Teleftb.TabIndex = 7;
            // 
            // Prefijotb
            // 
            this.Prefijotb.Location = new System.Drawing.Point(129, 190);
            this.Prefijotb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prefijotb.Name = "Prefijotb";
            this.Prefijotb.Size = new System.Drawing.Size(100, 22);
            this.Prefijotb.TabIndex = 9;
            // 
            // Generocb
            // 
            this.Generocb.FormattingEnabled = true;
            this.Generocb.Items.AddRange(new object[] {
            "Emakumea",
            "Gizona"});
            this.Generocb.Location = new System.Drawing.Point(129, 153);
            this.Generocb.Margin = new System.Windows.Forms.Padding(4);
            this.Generocb.Name = "Generocb";
            this.Generocb.Size = new System.Drawing.Size(100, 24);
            this.Generocb.TabIndex = 10;
            // 
            // Gordebtn
            // 
            this.Gordebtn.Location = new System.Drawing.Point(131, 260);
            this.Gordebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Gordebtn.Name = "Gordebtn";
            this.Gordebtn.Size = new System.Drawing.Size(100, 28);
            this.Gordebtn.TabIndex = 11;
            this.Gordebtn.Text = "Gorde";
            this.Gordebtn.UseVisualStyleBackColor = true;
            this.Gordebtn.Click += new System.EventHandler(this.btnGorde_Click);
            // 
            // Ikusibtn
            // 
            this.Ikusibtn.Location = new System.Drawing.Point(320, 260);
            this.Ikusibtn.Margin = new System.Windows.Forms.Padding(4);
            this.Ikusibtn.Name = "Ikusibtn";
            this.Ikusibtn.Size = new System.Drawing.Size(100, 28);
            this.Ikusibtn.TabIndex = 12;
            this.Ikusibtn.Text = "Ikusi";
            this.Ikusibtn.UseVisualStyleBackColor = true;
            this.Ikusibtn.Click += new System.EventHandler(this.Datuakikusi);
            // 
            // Bilatubtn
            // 
            this.Bilatubtn.Location = new System.Drawing.Point(537, 260);
            this.Bilatubtn.Margin = new System.Windows.Forms.Padding(4);
            this.Bilatubtn.Name = "Bilatubtn";
            this.Bilatubtn.Size = new System.Drawing.Size(100, 28);
            this.Bilatubtn.TabIndex = 13;
            this.Bilatubtn.Text = "Bilatu";
            this.Bilatubtn.UseVisualStyleBackColor = true;
            this.Bilatubtn.Click += new System.EventHandler(this.Bilatu);
            // 
            // izenaTaula
            // 
            this.izenaTaula.ColumnCount = 2;
            this.izenaTaula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.izenaTaula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.izenaTaula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.izenaTaula.Location = new System.Drawing.Point(0, 327);
            this.izenaTaula.Margin = new System.Windows.Forms.Padding(4);
            this.izenaTaula.Name = "izenaTaula";
            this.izenaTaula.RowCount = 2;
            this.izenaTaula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.izenaTaula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.izenaTaula.Size = new System.Drawing.Size(800, 123);
            this.izenaTaula.TabIndex = 14;
            // 
            // Grafikoa
            // 
            chartArea2.Name = "ChartArea1";
            this.Grafikoa.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Grafikoa.Legends.Add(legend2);
            this.Grafikoa.Location = new System.Drawing.Point(255, 39);
            this.Grafikoa.Margin = new System.Windows.Forms.Padding(4);
            this.Grafikoa.Name = "Grafikoa";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Grafikoa.Series.Add(series2);
            this.Grafikoa.Size = new System.Drawing.Size(311, 192);
            this.Grafikoa.TabIndex = 15;
            this.Grafikoa.Text = "chart1";
            this.Grafikoa.Click += new System.EventHandler(this.chart1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(573, 39);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(223, 192);
            this.userControl11.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Grafikoa);
            this.Controls.Add(this.izenaTaula);
            this.Controls.Add(this.Bilatubtn);
            this.Controls.Add(this.Ikusibtn);
            this.Controls.Add(this.Gordebtn);
            this.Controls.Add(this.Generocb);
            this.Controls.Add(this.Prefijotb);
            this.Controls.Add(this.Teleftb);
            this.Controls.Add(this.Abizenatb);
            this.Controls.Add(this.Izenatb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafikoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Izenatb;
        private System.Windows.Forms.TextBox Abizenatb;
        private System.Windows.Forms.TextBox Teleftb;
        private System.Windows.Forms.TextBox Prefijotb;
        private System.Windows.Forms.ComboBox Generocb;
        private System.Windows.Forms.Button Gordebtn;
        private System.Windows.Forms.Button Ikusibtn;
        private System.Windows.Forms.Button Bilatubtn;
        private System.Windows.Forms.TableLayoutPanel izenaTaula;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafikoa;
        private LibraryChartPrefijo2.UserControl1 userControl11;
    }
}

