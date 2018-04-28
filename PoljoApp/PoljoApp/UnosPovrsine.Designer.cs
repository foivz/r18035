namespace PoljoAppVerzija2
{
    partial class UnosPovrsine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.uiUnosPovrsine = new System.Windows.Forms.TextBox();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiActionOdabirNamjene = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Površina (m2):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namjena:";
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(129, 7);
            this.uiUnosNaziva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(235, 22);
            this.uiUnosNaziva.TabIndex = 3;
            // 
            // uiUnosPovrsine
            // 
            this.uiUnosPovrsine.Location = new System.Drawing.Point(129, 43);
            this.uiUnosPovrsine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiUnosPovrsine.Name = "uiUnosPovrsine";
            this.uiUnosPovrsine.Size = new System.Drawing.Size(235, 22);
            this.uiUnosPovrsine.TabIndex = 4;
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(129, 127);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 6;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(265, 127);
            this.uiActionSpremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(100, 28);
            this.uiActionSpremi.TabIndex = 7;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            // 
            // uiActionOdabirNamjene
            // 
            this.uiActionOdabirNamjene.FormattingEnabled = true;
            this.uiActionOdabirNamjene.Location = new System.Drawing.Point(129, 81);
            this.uiActionOdabirNamjene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdabirNamjene.Name = "uiActionOdabirNamjene";
            this.uiActionOdabirNamjene.Size = new System.Drawing.Size(235, 24);
            this.uiActionOdabirNamjene.TabIndex = 8;
            // 
            // UnosPovrsine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 181);
            this.Controls.Add(this.uiActionOdabirNamjene);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiUnosPovrsine);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UnosPovrsine";
            this.Text = "Unos KontrolaPovrsine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiUnosNaziva;
        private System.Windows.Forms.TextBox uiUnosPovrsine;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.ComboBox uiActionOdabirNamjene;
    }
}