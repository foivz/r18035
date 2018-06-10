namespace PoljoAppVerzija2
{
    partial class UnosNavodnjavanja
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
            this.izborPovrsine = new System.Windows.Forms.ComboBox();
            this.poljpovrsinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izborDatum = new System.Windows.Forms.DateTimePicker();
            this.izborVrsta = new System.Windows.Forms.ComboBox();
            this.stanjenavodnjavanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unosKolicinaVode = new System.Windows.Forms.TextBox();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjenavodnjavanjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // izborPovrsine
            // 
            this.izborPovrsine.DataSource = this.poljpovrsinaBindingSource;
            this.izborPovrsine.DisplayMember = "naziv";
            this.izborPovrsine.FormattingEnabled = true;
            this.izborPovrsine.Location = new System.Drawing.Point(15, 115);
            this.izborPovrsine.Name = "izborPovrsine";
            this.izborPovrsine.Size = new System.Drawing.Size(156, 21);
            this.izborPovrsine.TabIndex = 0;
            this.izborPovrsine.ValueMember = "id";
            // 
            // poljpovrsinaBindingSource
            // 
            this.poljpovrsinaBindingSource.DataSource = typeof(PoljoAppVerzija2.polj_povrsina);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Površina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // izborDatum
            // 
            this.izborDatum.Location = new System.Drawing.Point(104, 12);
            this.izborDatum.Name = "izborDatum";
            this.izborDatum.Size = new System.Drawing.Size(156, 20);
            this.izborDatum.TabIndex = 3;
            // 
            // izborVrsta
            // 
            this.izborVrsta.DataSource = this.stanjenavodnjavanjaBindingSource;
            this.izborVrsta.DisplayMember = "naziv";
            this.izborVrsta.FormattingEnabled = true;
            this.izborVrsta.Location = new System.Drawing.Point(104, 46);
            this.izborVrsta.Name = "izborVrsta";
            this.izborVrsta.Size = new System.Drawing.Size(156, 21);
            this.izborVrsta.TabIndex = 4;
            this.izborVrsta.ValueMember = "id";
            // 
            // stanjenavodnjavanjaBindingSource
            // 
            this.stanjenavodnjavanjaBindingSource.DataSource = typeof(PoljoAppVerzija2.stanje_navodnjavanja);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrsta:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(206, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Količina vode (u litrima):";
            // 
            // unosKolicinaVode
            // 
            this.unosKolicinaVode.Location = new System.Drawing.Point(209, 116);
            this.unosKolicinaVode.Name = "unosKolicinaVode";
            this.unosKolicinaVode.Size = new System.Drawing.Size(156, 20);
            this.unosKolicinaVode.TabIndex = 7;
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Enabled = false;
            this.uiActionSpremi.Location = new System.Drawing.Point(209, 168);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 33);
            this.uiActionSpremi.TabIndex = 8;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.UiActionSpremi_Click);
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(297, 168);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 33);
            this.uiActionOdustani.TabIndex = 9;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // UnosNavodnjavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 219);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.unosKolicinaVode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.izborVrsta);
            this.Controls.Add(this.izborDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izborPovrsine);
            this.KeyPreview = true;
            this.Name = "UnosNavodnjavanja";
            this.Text = "Unos navodnjavanja";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnosNavodnjavanja_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanjenavodnjavanjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox izborPovrsine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker izborDatum;
        private System.Windows.Forms.ComboBox izborVrsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unosKolicinaVode;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.BindingSource poljpovrsinaBindingSource;
        private System.Windows.Forms.BindingSource stanjenavodnjavanjaBindingSource;
    }
}