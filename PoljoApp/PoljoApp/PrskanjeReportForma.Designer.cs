namespace PoljoAppVerzija2
{
    partial class PrskanjeReportForma
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.prskanjeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prskanjeReport = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.prskanjeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prskanjeViewBindingSource
            // 
            this.prskanjeViewBindingSource.DataSource = typeof(PoljoAppVerzija2.PrskanjeView);
            // 
            // prskanjeReport
            // 
            this.prskanjeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prskanjeReport.AutoSize = true;
            reportDataSource1.Name = "PrskanjeDataSet";
            reportDataSource1.Value = this.prskanjeViewBindingSource;
            this.prskanjeReport.LocalReport.DataSources.Add(reportDataSource1);
            this.prskanjeReport.LocalReport.ReportEmbeddedResource = "PoljoAppVerzija2.PrskanjeReport.rdlc";
            this.prskanjeReport.Location = new System.Drawing.Point(12, 12);
            this.prskanjeReport.Name = "prskanjeReport";
            this.prskanjeReport.ServerReport.BearerToken = null;
            this.prskanjeReport.Size = new System.Drawing.Size(598, 345);
            this.prskanjeReport.TabIndex = 0;
            this.prskanjeReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.prskanjeReport.ZoomPercent = 150;
            // 
            // PrskanjeReportForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 369);
            this.Controls.Add(this.prskanjeReport);
            this.Name = "PrskanjeReportForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaj o prskanju";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrskanjeReportForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prskanjeViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer prskanjeReport;
        private System.Windows.Forms.BindingSource prskanjeViewBindingSource;
    }
}