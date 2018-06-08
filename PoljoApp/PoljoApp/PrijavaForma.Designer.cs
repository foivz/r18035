namespace PoljoAppVerzija2
{
    partial class PrijavaForma
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unosLozinka = new System.Windows.Forms.TextBox();
            this.unosEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionPrijava = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoljoAppVerzija2.Properties.Resources.Logo___crni;
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // unosLozinka
            // 
            this.unosLozinka.Location = new System.Drawing.Point(149, 89);
            this.unosLozinka.Name = "unosLozinka";
            this.unosLozinka.PasswordChar = '*';
            this.unosLozinka.Size = new System.Drawing.Size(176, 20);
            this.unosLozinka.TabIndex = 1;
            this.unosLozinka.Leave += new System.EventHandler(this.UnosLozinka_Leave);
            // 
            // unosEmail
            // 
            this.unosEmail.Location = new System.Drawing.Point(149, 41);
            this.unosEmail.Name = "unosEmail";
            this.unosEmail.Size = new System.Drawing.Size(176, 20);
            this.unosEmail.TabIndex = 0;
            this.unosEmail.Leave += new System.EventHandler(this.UnosEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lozinka:";
            // 
            // uiActionPrijava
            // 
            this.uiActionPrijava.Location = new System.Drawing.Point(149, 137);
            this.uiActionPrijava.Name = "uiActionPrijava";
            this.uiActionPrijava.Size = new System.Drawing.Size(83, 27);
            this.uiActionPrijava.TabIndex = 17;
            this.uiActionPrijava.Text = "Prijava";
            this.uiActionPrijava.UseVisualStyleBackColor = true;
            this.uiActionPrijava.Click += new System.EventHandler(this.UiActionPrijava_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(242, 137);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(83, 27);
            this.uiActionOdustani.TabIndex = 18;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 189);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionPrijava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosEmail);
            this.Controls.Add(this.unosLozinka);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrijavaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox unosLozinka;
        private System.Windows.Forms.TextBox unosEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiActionPrijava;
        private System.Windows.Forms.Button uiActionOdustani;
    }
}