namespace PoljoAppVerzija2.Admin
{
    partial class UnosDjelatnika
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
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unosIme = new System.Windows.Forms.TextBox();
            this.unosPrezime = new System.Windows.Forms.TextBox();
            this.unosEmail = new System.Windows.Forms.TextBox();
            this.unosLozinka = new System.Windows.Forms.TextBox();
            this.unosTelefon = new System.Windows.Forms.TextBox();
            this.ispisID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vidljivostLozinke = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionOdustani.Location = new System.Drawing.Point(187, 207);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(102, 34);
            this.uiActionOdustani.TabIndex = 9;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionSpremi.Enabled = false;
            this.uiActionSpremi.Location = new System.Drawing.Point(295, 207);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(102, 34);
            this.uiActionSpremi.TabIndex = 10;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.UiActionSpremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Broj telefona:";
            // 
            // unosIme
            // 
            this.unosIme.Location = new System.Drawing.Point(241, 62);
            this.unosIme.Name = "unosIme";
            this.unosIme.Size = new System.Drawing.Size(152, 20);
            this.unosIme.TabIndex = 16;
            // 
            // unosPrezime
            // 
            this.unosPrezime.Location = new System.Drawing.Point(241, 110);
            this.unosPrezime.Name = "unosPrezime";
            this.unosPrezime.Size = new System.Drawing.Size(152, 20);
            this.unosPrezime.TabIndex = 17;
            // 
            // unosEmail
            // 
            this.unosEmail.Location = new System.Drawing.Point(25, 110);
            this.unosEmail.Name = "unosEmail";
            this.unosEmail.Size = new System.Drawing.Size(152, 20);
            this.unosEmail.TabIndex = 18;
            // 
            // unosLozinka
            // 
            this.unosLozinka.Location = new System.Drawing.Point(25, 156);
            this.unosLozinka.Name = "unosLozinka";
            this.unosLozinka.Size = new System.Drawing.Size(152, 20);
            this.unosLozinka.TabIndex = 19;
            this.unosLozinka.UseSystemPasswordChar = true;
            // 
            // unosTelefon
            // 
            this.unosTelefon.Location = new System.Drawing.Point(241, 156);
            this.unosTelefon.Name = "unosTelefon";
            this.unosTelefon.Size = new System.Drawing.Size(152, 20);
            this.unosTelefon.TabIndex = 20;
            // 
            // ispisID
            // 
            this.ispisID.AutoSize = true;
            this.ispisID.Location = new System.Drawing.Point(22, 20);
            this.ispisID.Name = "ispisID";
            this.ispisID.Size = new System.Drawing.Size(21, 13);
            this.ispisID.TabIndex = 22;
            this.ispisID.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Podaci za prijavu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Opći podaci";
            // 
            // vidljivostLozinke
            // 
            this.vidljivostLozinke.AutoSize = true;
            this.vidljivostLozinke.Location = new System.Drawing.Point(38, 182);
            this.vidljivostLozinke.Name = "vidljivostLozinke";
            this.vidljivostLozinke.Size = new System.Drawing.Size(89, 17);
            this.vidljivostLozinke.TabIndex = 25;
            this.vidljivostLozinke.Text = "Pokaži/Sakrij";
            this.vidljivostLozinke.UseVisualStyleBackColor = true;
            this.vidljivostLozinke.CheckedChanged += new System.EventHandler(this.VidljivostLozinke_CheckedChanged);
            // 
            // UnosDjelatnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 253);
            this.Controls.Add(this.vidljivostLozinke);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ispisID);
            this.Controls.Add(this.unosTelefon);
            this.Controls.Add(this.unosLozinka);
            this.Controls.Add(this.unosEmail);
            this.Controls.Add(this.unosPrezime);
            this.Controls.Add(this.unosIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.KeyPreview = true;
            this.Name = "UnosDjelatnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos djelatnika";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnosDjelatnika_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unosIme;
        private System.Windows.Forms.TextBox unosPrezime;
        private System.Windows.Forms.TextBox unosEmail;
        private System.Windows.Forms.TextBox unosLozinka;
        private System.Windows.Forms.TextBox unosTelefon;
        private System.Windows.Forms.Label ispisID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox vidljivostLozinke;
    }
}