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
            this.uiActionOdabirVrste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdabirVrste.FormattingEnabled = true;
            this.uiActionOdabirVrste.Location = new System.Drawing.Point(125, 89);
            this.uiActionOdabirVrste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdabirVrste.Name = "uiActionOdabirVrste";
            this.uiActionOdabirVrste.Size = new System.Drawing.Size(235, 24);
            this.uiActionOdabirVrste.TabIndex = 16;
            this.uiActionOdabirVrste.ValueMember = "id";
            // 
            // vrstazastiteBindingSource
            // 
            this.vrstazastiteBindingSource.DataSource = typeof(DataLayer.vrsta_zastite);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(261, 134);
            this.uiActionSpremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(100, 28);
            this.uiActionSpremi.TabIndex = 15;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(125, 134);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 14;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiUnosKoncentracije
            // 
            this.uiUnosKoncentracije.Location = new System.Drawing.Point(125, 50);
            this.uiUnosKoncentracije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiUnosKoncentracije.Name = "uiUnosKoncentracije";
            this.uiUnosKoncentracije.Size = new System.Drawing.Size(235, 22);
            this.uiUnosKoncentracije.TabIndex = 13;
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(125, 15);
            this.uiUnosNaziva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(235, 22);
            this.uiUnosNaziva.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vrsta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Koncentracija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv:";
            // 
            // UnosZastite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 181);
            this.Controls.Add(this.uiActionOdabirVrste);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiUnosKoncentracije);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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