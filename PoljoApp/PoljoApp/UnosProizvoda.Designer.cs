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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.uiActionOdabirJednicineMjere = new System.Windows.Forms.ComboBox();
            this.uiActionOdabirVrste = new System.Windows.Forms.ComboBox();
            this.vrstasadnogmaterijalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasadnogmaterijalaBindingSource)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jedinična mjera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrsta:";
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(136, 7);
            this.uiUnosNaziva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(232, 22);
            this.uiUnosNaziva.TabIndex = 4;
            // 
            // uiActionOdabirJednicineMjere
            // 
            this.uiActionOdabirJednicineMjere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdabirJednicineMjere.FormattingEnabled = true;
            this.uiActionOdabirJednicineMjere.Location = new System.Drawing.Point(136, 43);
            this.uiActionOdabirJednicineMjere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdabirJednicineMjere.Name = "uiActionOdabirJednicineMjere";
            this.uiActionOdabirJednicineMjere.Size = new System.Drawing.Size(232, 24);
            this.uiActionOdabirJednicineMjere.TabIndex = 7;
            // 
            // uiActionOdabirVrste
            // 
            this.uiActionOdabirVrste.DataSource = this.vrstasadnogmaterijalaBindingSource;
            this.uiActionOdabirVrste.DisplayMember = "naziv";
            this.uiActionOdabirVrste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionOdabirVrste.FormattingEnabled = true;
            this.uiActionOdabirVrste.Location = new System.Drawing.Point(136, 80);
            this.uiActionOdabirVrste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdabirVrste.Name = "uiActionOdabirVrste";
            this.uiActionOdabirVrste.Size = new System.Drawing.Size(232, 24);
            this.uiActionOdabirVrste.TabIndex = 8;
            this.uiActionOdabirVrste.ValueMember = "id";
            // 
            // vrstasadnogmaterijalaBindingSource
            // 
            this.vrstasadnogmaterijalaBindingSource.DataSource = typeof(DataLayer.VrstaSadnogMaterijala);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(136, 127);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 9;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(269, 127);
            this.uiActionSpremi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(100, 28);
            this.uiActionSpremi.TabIndex = 10;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // UnosProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 174);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionOdabirVrste);
            this.Controls.Add(this.uiActionOdabirJednicineMjere);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UnosProizvoda";
            this.Text = "Unos proizvoda";
            ((System.ComponentModel.ISupportInitialize)(this.vrstasadnogmaterijalaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiUnosNaziva;
        private System.Windows.Forms.ComboBox uiActionOdabirJednicineMjere;
        private System.Windows.Forms.ComboBox uiActionOdabirVrste;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.BindingSource vrstasadnogmaterijalaBindingSource;
    }
}