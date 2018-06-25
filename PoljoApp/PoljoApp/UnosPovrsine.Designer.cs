namespace PoljoAppVerzija2
{
    partial class UnosPovrsine
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
            this.label3 = new System.Windows.Forms.Label();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.uiUnosPovrsine = new System.Windows.Forms.TextBox();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiOdabirNamjene = new System.Windows.Forms.ComboBox();
            this.namjenapovrsineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiUnosKoordinateX = new System.Windows.Forms.TextBox();
            this.uiUnosKoordinateY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.namjenapovrsineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Površina (m2):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namjena:";
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(129, 7);
            this.uiUnosNaziva.Margin = new System.Windows.Forms.Padding(4);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(235, 22);
            this.uiUnosNaziva.TabIndex = 3;
            // 
            // uiUnosPovrsine
            // 
            this.uiUnosPovrsine.Location = new System.Drawing.Point(129, 43);
            this.uiUnosPovrsine.Margin = new System.Windows.Forms.Padding(4);
            this.uiUnosPovrsine.Name = "uiUnosPovrsine";
            this.uiUnosPovrsine.Size = new System.Drawing.Size(235, 22);
            this.uiUnosPovrsine.TabIndex = 4;
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(128, 204);
            this.uiActionOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(100, 28);
            this.uiActionOdustani.TabIndex = 6;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            this.uiActionOdustani.Click += new System.EventHandler(this.uiActionOdustani_Click);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Enabled = false;
            this.uiActionSpremi.Location = new System.Drawing.Point(264, 204);
            this.uiActionSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(100, 28);
            this.uiActionSpremi.TabIndex = 7;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // uiOdabirNamjene
            // 
            this.uiOdabirNamjene.DataSource = this.namjenapovrsineBindingSource;
            this.uiOdabirNamjene.DisplayMember = "namjena";
            this.uiOdabirNamjene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiOdabirNamjene.FormattingEnabled = true;
            this.uiOdabirNamjene.Location = new System.Drawing.Point(129, 81);
            this.uiOdabirNamjene.Margin = new System.Windows.Forms.Padding(4);
            this.uiOdabirNamjene.Name = "uiOdabirNamjene";
            this.uiOdabirNamjene.Size = new System.Drawing.Size(235, 24);
            this.uiOdabirNamjene.TabIndex = 8;
            this.uiOdabirNamjene.ValueMember = "id";
            // 
            // namjenapovrsineBindingSource
            // 
            this.namjenapovrsineBindingSource.DataSource = typeof(DataLayer.NamjenaPovrsine);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Koordinata y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Koordinata x:";
            // 
            // uiUnosKoordinateX
            // 
            this.uiUnosKoordinateX.Location = new System.Drawing.Point(129, 113);
            this.uiUnosKoordinateX.Margin = new System.Windows.Forms.Padding(4);
            this.uiUnosKoordinateX.Name = "uiUnosKoordinateX";
            this.uiUnosKoordinateX.Size = new System.Drawing.Size(101, 22);
            this.uiUnosKoordinateX.TabIndex = 11;
            // 
            // uiUnosKoordinateY
            // 
            this.uiUnosKoordinateY.Location = new System.Drawing.Point(129, 146);
            this.uiUnosKoordinateY.Margin = new System.Windows.Forms.Padding(4);
            this.uiUnosKoordinateY.Name = "uiUnosKoordinateY";
            this.uiUnosKoordinateY.Size = new System.Drawing.Size(101, 22);
            this.uiUnosKoordinateY.TabIndex = 12;
            // 
            // UnosPovrsine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.uiUnosKoordinateY);
            this.Controls.Add(this.uiUnosKoordinateX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiOdabirNamjene);
            this.Controls.Add(this.uiActionSpremi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiUnosPovrsine);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UnosPovrsine";
            this.Text = "Unos Povrsine";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UnosPovrsine_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.namjenapovrsineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiUnosNaziva;
        private System.Windows.Forms.TextBox uiUnosPovrsine;
        private System.Windows.Forms.Button uiActionOdustani;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.ComboBox uiOdabirNamjene;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiUnosKoordinateX;
        private System.Windows.Forms.TextBox uiUnosKoordinateY;
        private System.Windows.Forms.BindingSource namjenapovrsineBindingSource;
    }
}