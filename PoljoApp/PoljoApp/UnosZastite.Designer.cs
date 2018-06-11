namespace PoljoAppVerzija2
{
    partial class UnosZastite
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
            this.uiActionOdabirVrste = new System.Windows.Forms.ComboBox();
            this.vrstazastiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiUnosKoncentracije = new System.Windows.Forms.TextBox();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vrstazastiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionOdabirVrste
            // 
            this.uiActionOdabirVrste.DataSource = this.vrstazastiteBindingSource;
            this.uiActionOdabirVrste.DisplayMember = "naziv";
            this.uiActionOdabirVrste.FormattingEnabled = true;
            this.uiActionOdabirVrste.Location = new System.Drawing.Point(94, 72);
            this.uiActionOdabirVrste.Name = "uiActionOdabirVrste";
            this.uiActionOdabirVrste.Size = new System.Drawing.Size(177, 21);
            this.uiActionOdabirVrste.TabIndex = 16;
            this.uiActionOdabirVrste.ValueMember = "id";
            // 
            // vrstazastiteBindingSource
            // 
            this.vrstazastiteBindingSource.DataSource = typeof(PoljoAppVerzija2.vrsta_zastite);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(196, 109);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 23);
            this.uiActionSpremi.TabIndex = 15;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(94, 109);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 14;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiUnosKoncentracije
            // 
            this.uiUnosKoncentracije.Location = new System.Drawing.Point(94, 41);
            this.uiUnosKoncentracije.Name = "uiUnosKoncentracije";
            this.uiUnosKoncentracije.Size = new System.Drawing.Size(177, 20);
            this.uiUnosKoncentracije.TabIndex = 13;
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(94, 12);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(177, 20);
            this.uiUnosNaziva.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vrsta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Koncentracija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv:";
            // 
            // UnosZastite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 147);
            this.Controls.Add(this.uiActionOdabirVrste);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiUnosKoncentracije);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosZastite";
            this.Text = "Unos zastite";
            ((System.ComponentModel.ISupportInitialize)(this.vrstazastiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiActionOdabirVrste;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.TextBox uiUnosKoncentracije;
        private System.Windows.Forms.TextBox uiUnosNaziva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vrstazastiteBindingSource;
    }
}