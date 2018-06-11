namespace PoljoAppVerzija2
{
    partial class UnosSadnje
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
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.izborProizvodaZaSadnju = new System.Windows.Forms.ComboBox();
            this.sadnimaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiUnosKolicine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.izborPovrsine = new System.Windows.Forms.ComboBox();
            this.poljpovrsinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.uiLabelaMjernaJedinica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sadnimaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Location = new System.Drawing.Point(256, 189);
            this.uiActionSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(100, 28);
            this.uiActionSpremi.TabIndex = 20;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(127, 189);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 19;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // izborProizvodaZaSadnju
            // 
            this.izborProizvodaZaSadnju.DataSource = this.sadnimaterijalBindingSource;
            this.izborProizvodaZaSadnju.DisplayMember = "naziv";
            this.izborProizvodaZaSadnju.FormattingEnabled = true;
            this.izborProizvodaZaSadnju.Location = new System.Drawing.Point(198, 50);
            this.izborProizvodaZaSadnju.Margin = new System.Windows.Forms.Padding(4);
            this.izborProizvodaZaSadnju.Name = "izborProizvodaZaSadnju";
            this.izborProizvodaZaSadnju.Size = new System.Drawing.Size(232, 24);
            this.izborProizvodaZaSadnju.TabIndex = 17;
            this.izborProizvodaZaSadnju.ValueMember = "id";
            this.izborProizvodaZaSadnju.SelectedIndexChanged += new System.EventHandler(this.izborProizvodaZaSadnju_SelectedIndexChanged);
            // 
            // sadnimaterijalBindingSource
            // 
            this.sadnimaterijalBindingSource.DataSource = typeof(PoljoAppVerzija2.sadni_materijal);
            // 
            // uiUnosKolicine
            // 
            this.uiUnosKolicine.Location = new System.Drawing.Point(16, 145);
            this.uiUnosKolicine.Margin = new System.Windows.Forms.Padding(4);
            this.uiUnosKolicine.Name = "uiUnosKolicine";
            this.uiUnosKolicine.Size = new System.Drawing.Size(186, 22);
            this.uiUnosKolicine.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mjerna jedinica:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Upiši količinu sadnica: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odaberi proizvod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odaberi površinu:";
            // 
            // izborPovrsine
            // 
            this.izborPovrsine.DataSource = this.poljpovrsinaBindingSource;
            this.izborPovrsine.DisplayMember = "naziv";
            this.izborPovrsine.FormattingEnabled = true;
            this.izborPovrsine.Location = new System.Drawing.Point(198, 11);
            this.izborPovrsine.Margin = new System.Windows.Forms.Padding(4);
            this.izborPovrsine.Name = "izborPovrsine";
            this.izborPovrsine.Size = new System.Drawing.Size(232, 24);
            this.izborPovrsine.TabIndex = 21;
            this.izborPovrsine.ValueMember = "id";
            this.izborPovrsine.SelectedIndexChanged += new System.EventHandler(this.izborPovrsine_SelectedIndexChanged);
            // 
            // poljpovrsinaBindingSource
            // 
            this.poljpovrsinaBindingSource.DataSource = typeof(PoljoAppVerzija2.polj_povrsina);
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(198, 81);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(200, 22);
            this.datum.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Odaberi datumm sadnje:";
            // 
            // uiLabelaMjernaJedinica
            // 
            this.uiLabelaMjernaJedinica.AutoSize = true;
            this.uiLabelaMjernaJedinica.Location = new System.Drawing.Point(253, 148);
            this.uiLabelaMjernaJedinica.Name = "uiLabelaMjernaJedinica";
            this.uiLabelaMjernaJedinica.Size = new System.Drawing.Size(46, 17);
            this.uiLabelaMjernaJedinica.TabIndex = 25;
            this.uiLabelaMjernaJedinica.Text = "label5";
            // 
            // UnosSadnje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 241);
            this.Controls.Add(this.uiLabelaMjernaJedinica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.izborPovrsine);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.izborProizvodaZaSadnju);
            this.Controls.Add(this.uiUnosKolicine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosSadnje";
            this.Text = "Unos Sadnje";
            ((System.ComponentModel.ISupportInitialize)(this.sadnimaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.ComboBox izborProizvodaZaSadnju;
        private System.Windows.Forms.TextBox uiUnosKolicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox izborPovrsine;
        private System.Windows.Forms.BindingSource sadnimaterijalBindingSource;
        private System.Windows.Forms.BindingSource poljpovrsinaBindingSource;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label uiLabelaMjernaJedinica;
    }
}