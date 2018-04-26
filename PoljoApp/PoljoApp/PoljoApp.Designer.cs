namespace PoljoAppVerzija2
{
    partial class PoljoApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uiActionOpenPovrsine = new System.Windows.Forms.Button();
            this.uiActionOpenSadnja = new System.Windows.Forms.Button();
            this.uiActionNavodnjavanje = new System.Windows.Forms.Button();
            this.uiActionPrskanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.uiUserControlSadnja = new PoljoAppVerzija2.Sadnja();
            this.uiUserControlPovrsine = new PoljoAppVerzija2.Povrsine();
            this.uiNavodnjavanje = new PoljoAppVerzija2.Navodnjavanje();
            this.uiPrskanje = new PoljoAppVerzija2.Prskanje();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Proizvodi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 222);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zaštita";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // uiActionOpenPovrsine
            // 
            this.uiActionOpenPovrsine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOpenPovrsine.Location = new System.Drawing.Point(12, 178);
            this.uiActionOpenPovrsine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionOpenPovrsine.Name = "uiActionOpenPovrsine";
            this.uiActionOpenPovrsine.Size = new System.Drawing.Size(199, 37);
            this.uiActionOpenPovrsine.TabIndex = 3;
            this.uiActionOpenPovrsine.Text = "Površine";
            this.uiActionOpenPovrsine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiActionOpenPovrsine.UseVisualStyleBackColor = true;
            this.uiActionOpenPovrsine.Click += new System.EventHandler(this.UiActionOpenPovrsine_Click);
            // 
            // uiActionOpenSadnja
            // 
            this.uiActionOpenSadnja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionOpenSadnja.Location = new System.Drawing.Point(12, 343);
            this.uiActionOpenSadnja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionOpenSadnja.Name = "uiActionOpenSadnja";
            this.uiActionOpenSadnja.Size = new System.Drawing.Size(199, 37);
            this.uiActionOpenSadnja.TabIndex = 4;
            this.uiActionOpenSadnja.Text = "Sadnja";
            this.uiActionOpenSadnja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiActionOpenSadnja.UseVisualStyleBackColor = true;
            this.uiActionOpenSadnja.Click += new System.EventHandler(this.UiActionOpenSadnja_Click);
            // 
            // uiActionNavodnjavanje
            // 
            this.uiActionNavodnjavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionNavodnjavanje.Location = new System.Drawing.Point(12, 386);
            this.uiActionNavodnjavanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionNavodnjavanje.Name = "uiActionNavodnjavanje";
            this.uiActionNavodnjavanje.Size = new System.Drawing.Size(199, 37);
            this.uiActionNavodnjavanje.TabIndex = 5;
            this.uiActionNavodnjavanje.Text = "Navodnjavanje";
            this.uiActionNavodnjavanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiActionNavodnjavanje.UseVisualStyleBackColor = true;
            this.uiActionNavodnjavanje.Click += new System.EventHandler(this.UiActionNavodnjavanje_Click);
            // 
            // uiActionPrskanje
            // 
            this.uiActionPrskanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionPrskanje.Location = new System.Drawing.Point(12, 430);
            this.uiActionPrskanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiActionPrskanje.Name = "uiActionPrskanje";
            this.uiActionPrskanje.Size = new System.Drawing.Size(199, 37);
            this.uiActionPrskanje.TabIndex = 6;
            this.uiActionPrskanje.Text = "Prskanje";
            this.uiActionPrskanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiActionPrskanje.UseVisualStyleBackColor = true;
            this.uiActionPrskanje.Click += new System.EventHandler(this.UiActionPrskanje_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popisi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Evidencije";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 69);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "PoljoApp";
            // 
            // uiUserControlSadnja
            // 
            this.uiUserControlSadnja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiUserControlSadnja.Location = new System.Drawing.Point(221, 84);
            this.uiUserControlSadnja.Margin = new System.Windows.Forms.Padding(5);
            this.uiUserControlSadnja.Name = "uiUserControlSadnja";
            this.uiUserControlSadnja.Size = new System.Drawing.Size(680, 418);
            this.uiUserControlSadnja.TabIndex = 10;
            // 
            // uiUserControlPovrsine
            // 
            this.uiUserControlPovrsine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiUserControlPovrsine.Location = new System.Drawing.Point(221, 84);
            this.uiUserControlPovrsine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiUserControlPovrsine.Name = "uiUserControlPovrsine";
            this.uiUserControlPovrsine.Size = new System.Drawing.Size(680, 418);
            this.uiUserControlPovrsine.TabIndex = 9;
            // 
            // uiNavodnjavanje
            // 
            this.uiNavodnjavanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNavodnjavanje.Location = new System.Drawing.Point(221, 84);
            this.uiNavodnjavanje.Name = "uiNavodnjavanje";
            this.uiNavodnjavanje.Size = new System.Drawing.Size(680, 418);
            this.uiNavodnjavanje.TabIndex = 11;
            // 
            // uiPrskanje
            // 
            this.uiPrskanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPrskanje.Location = new System.Drawing.Point(221, 84);
            this.uiPrskanje.Name = "uiPrskanje";
            this.uiPrskanje.Size = new System.Drawing.Size(680, 418);
            this.uiPrskanje.TabIndex = 12;
            // 
            // PoljoApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.uiPrskanje);
            this.Controls.Add(this.uiNavodnjavanje);
            this.Controls.Add(this.uiUserControlPovrsine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiActionPrskanje);
            this.Controls.Add(this.uiActionNavodnjavanje);
            this.Controls.Add(this.uiActionOpenSadnja);
            this.Controls.Add(this.uiActionOpenPovrsine);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiUserControlSadnja);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PoljoApp";
            this.Text = "PoljoApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button uiActionOpenPovrsine;
        private System.Windows.Forms.Button uiActionOpenSadnja;
        private System.Windows.Forms.Button uiActionNavodnjavanje;
        private System.Windows.Forms.Button uiActionPrskanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Povrsine uiUserControlPovrsine;
        private Sadnja uiUserControlSadnja;
        private Navodnjavanje uiNavodnjavanje;
        private Prskanje uiPrskanje;
    }
}

