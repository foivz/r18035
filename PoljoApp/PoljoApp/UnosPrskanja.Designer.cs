namespace PoljoAppVerzija2
{
    partial class UnosPrskanja
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
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izborDjelatnik = new System.Windows.Forms.ComboBox();
            this.izborDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.izborPovrsine = new System.Windows.Forms.ComboBox();
            this.poljpovrsinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izborZastita = new System.Windows.Forms.ComboBox();
            this.zastitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.unosOpis = new System.Windows.Forms.TextBox();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(292, 256);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 33);
            this.uiActionOdustani.TabIndex = 19;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.UiActionOdustani_Click);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Enabled = false;
            this.uiActionSpremi.Location = new System.Drawing.Point(211, 256);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(75, 33);
            this.uiActionSpremi.TabIndex = 18;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.UiActionSpremi_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(208, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Korištena zaštita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Djelatnik:";
            // 
            // izborDjelatnik
            // 
            this.izborDjelatnik.DataSource = this.djelatnikBindingSource;
            this.izborDjelatnik.DisplayMember = "Ime";
            this.izborDjelatnik.FormattingEnabled = true;
            this.izborDjelatnik.Location = new System.Drawing.Point(106, 46);
            this.izborDjelatnik.Name = "izborDjelatnik";
            this.izborDjelatnik.Size = new System.Drawing.Size(156, 21);
            this.izborDjelatnik.TabIndex = 14;
            this.izborDjelatnik.ValueMember = "Id";
            // 
            // izborDatum
            // 
            this.izborDatum.Location = new System.Drawing.Point(106, 12);
            this.izborDatum.Name = "izborDatum";
            this.izborDatum.Size = new System.Drawing.Size(156, 20);
            this.izborDatum.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tretirana površina:";
            // 
            // izborPovrsine
            // 
            this.izborPovrsine.DataSource = this.poljpovrsinaBindingSource;
            this.izborPovrsine.DisplayMember = "naziv";
            this.izborPovrsine.FormattingEnabled = true;
            this.izborPovrsine.Location = new System.Drawing.Point(17, 115);
            this.izborPovrsine.Name = "izborPovrsine";
            this.izborPovrsine.Size = new System.Drawing.Size(156, 21);
            this.izborPovrsine.TabIndex = 10;
            this.izborPovrsine.ValueMember = "id";
            // 
            // izborZastita
            // 
            this.izborZastita.DataSource = this.zastitaBindingSource;
            this.izborZastita.DisplayMember = "naziv";
            this.izborZastita.FormattingEnabled = true;
            this.izborZastita.Location = new System.Drawing.Point(211, 115);
            this.izborZastita.Name = "izborZastita";
            this.izborZastita.Size = new System.Drawing.Size(156, 21);
            this.izborZastita.TabIndex = 20;
            this.izborZastita.ValueMember = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Opis";
            // 
            // unosOpis
            // 
            this.unosOpis.Location = new System.Drawing.Point(17, 166);
            this.unosOpis.Multiline = true;
            this.unosOpis.Name = "unosOpis";
            this.unosOpis.Size = new System.Drawing.Size(350, 73);
            this.unosOpis.TabIndex = 22;
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataSource = typeof(DataLayer.Djelatnik);
            // 
            // UnosPrskanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 301);
            this.Controls.Add(this.unosOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.izborZastita);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.izborDjelatnik);
            this.Controls.Add(this.izborDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izborPovrsine);
            this.KeyPreview = true;
            this.Name = "UnosPrskanja";
            this.Text = "Unos prskanja";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnosPrskanja_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox izborDjelatnik;
        private System.Windows.Forms.DateTimePicker izborDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox izborPovrsine;
        private System.Windows.Forms.ComboBox izborZastita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unosOpis;
        private System.Windows.Forms.BindingSource poljpovrsinaBindingSource;
        private System.Windows.Forms.BindingSource zastitaBindingSource;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
    }
}