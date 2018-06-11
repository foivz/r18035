namespace PoljoAppVerzija2
{
    partial class NavodnjavanjeStatistikaForma
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.godinaInfo = new System.Windows.Forms.Label();
            this.navodnjavanjeStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // godinaInfo
            // 
            this.godinaInfo.AutoSize = true;
            this.godinaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godinaInfo.Location = new System.Drawing.Point(12, 9);
            this.godinaInfo.Name = "godinaInfo";
            this.godinaInfo.Size = new System.Drawing.Size(78, 25);
            this.godinaInfo.TabIndex = 12;
            this.godinaInfo.Text = "Podaci";
            // 
            // navodnjavanjeStatistika
            // 
            this.navodnjavanjeStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Maximum = 12D;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.Title = "Mjesec";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Title = "Količina vode";
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.navodnjavanjeStatistika.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.navodnjavanjeStatistika.Legends.Add(legend1);
            this.navodnjavanjeStatistika.Location = new System.Drawing.Point(17, 37);
            this.navodnjavanjeStatistika.Name = "navodnjavanjeStatistika";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=False, EmptyPointValue=Zero";
            series1.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Navodnjavanje";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.EmptyPointStyle.BorderColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Oborine";
            this.navodnjavanjeStatistika.Series.Add(series1);
            this.navodnjavanjeStatistika.Series.Add(series2);
            this.navodnjavanjeStatistika.Size = new System.Drawing.Size(738, 305);
            this.navodnjavanjeStatistika.TabIndex = 14;
            this.navodnjavanjeStatistika.Text = "chart1";
            // 
            // NavodnjavanjeStatistikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 354);
            this.Controls.Add(this.navodnjavanjeStatistika);
            this.Controls.Add(this.godinaInfo);
            this.Name = "NavodnjavanjeStatistikaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika o natapanju površina";
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeStatistika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label godinaInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart navodnjavanjeStatistika;
    }
}