namespace PoljoAppVerzija2
{
    partial class UnosProizvoda
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
            this.label4 = new System.Windows.Forms.Label();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.uiUnosCijene = new System.Windows.Forms.TextBox();
            this.uiActionOdabirJednicineMjere = new System.Windows.Forms.ComboBox();
            this.uiActionOdabirVrste = new System.Windows.Forms.ComboBox();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jedinična mjera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrsta:";
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(102, 6);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(175, 20);
            this.uiUnosNaziva.TabIndex = 4;
            // 
            // uiUnosCijene
            // 
            this.uiUnosCijene.Location = new System.Drawing.Point(102, 67);
            this.uiUnosCijene.Name = "uiUnosCijene";
            this.uiUnosCijene.Size = new System.Drawing.Size(175, 20);
            this.uiUnosCijene.TabIndex = 6;
            // 
            // uiActionOdabirJednicineMjere
            // 
            this.uiActionOdabirJednicineMjere.FormattingEnabled = true;
            this.uiActionOdabirJednicineMjere.Location = new System.Drawing.Point(102, 35);
            this.uiActionOdabirJednicineMjere.Name = "uiActionOdabirJednicineMjere";
            this.uiActionOdabirJednicineMjere.Size = new System.Drawing.Size(175, 21);
            this.uiActionOdabirJednicineMjere.TabIndex = 7;
            // 
            // uiActionOdabirVrste
            // 
            this.uiActionOdabirVrste.FormattingEnabled = true;
            this.uiActionOdabirVrste.Location = new System.Drawing.Point(102, 99);
            this.uiActionOdabirVrste.Name = "uiActionOdabirVrste";
            this.uiActionOdabirVrste.Size = new System.Drawing.Size(175, 21);
            this.uiActionOdabirVrste.TabIndex = 8;
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(102, 137);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 9;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(202, 137);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 23);
            this.uiActionSpremi.TabIndex = 10;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            // 
            // UnosProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 177);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionOdabirVrste);
            this.Controls.Add(this.uiActionOdabirJednicineMjere);
            this.Controls.Add(this.uiUnosCijene);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosProizvoda";
            this.Text = "UnosProizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiUnosNaziva;
        private System.Windows.Forms.TextBox uiUnosCijene;
        private System.Windows.Forms.ComboBox uiActionOdabirJednicineMjere;
        private System.Windows.Forms.ComboBox uiActionOdabirVrste;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
    }
}