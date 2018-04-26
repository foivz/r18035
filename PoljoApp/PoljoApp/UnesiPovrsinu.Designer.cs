namespace PoljoAppVerzija2
{
    partial class UnesiPovrsinu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiUnosNaziva = new System.Windows.Forms.TextBox();
            this.uiUnosPovrsine = new System.Windows.Forms.TextBox();
            this.uiActionOdustani = new System.Windows.Forms.Button();
            this.uiActionUnesi = new System.Windows.Forms.Button();
            this.uiUnosNamjene = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Površina (m2):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Namjena:";
            // 
            // uiUnosNaziva
            // 
            this.uiUnosNaziva.Location = new System.Drawing.Point(97, 6);
            this.uiUnosNaziva.Name = "uiUnosNaziva";
            this.uiUnosNaziva.Size = new System.Drawing.Size(177, 20);
            this.uiUnosNaziva.TabIndex = 3;
            // 
            // uiUnosPovrsine
            // 
            this.uiUnosPovrsine.Location = new System.Drawing.Point(97, 33);
            this.uiUnosPovrsine.Name = "uiUnosPovrsine";
            this.uiUnosPovrsine.Size = new System.Drawing.Size(177, 20);
            this.uiUnosPovrsine.TabIndex = 4;
            // 
            // uiActionOdustani
            // 
            this.uiActionOdustani.Location = new System.Drawing.Point(97, 103);
            this.uiActionOdustani.Name = "uiActionOdustani";
            this.uiActionOdustani.Size = new System.Drawing.Size(75, 23);
            this.uiActionOdustani.TabIndex = 6;
            this.uiActionOdustani.Text = "Odustani";
            this.uiActionOdustani.UseVisualStyleBackColor = true;
            // 
            // uiActionUnesi
            // 
            this.uiActionUnesi.Location = new System.Drawing.Point(199, 103);
            this.uiActionUnesi.Name = "uiActionUnesi";
            this.uiActionUnesi.Size = new System.Drawing.Size(75, 23);
            this.uiActionUnesi.TabIndex = 7;
            this.uiActionUnesi.Text = "Spremi";
            this.uiActionUnesi.UseVisualStyleBackColor = true;
            // 
            // uiUnosNamjene
            // 
            this.uiUnosNamjene.FormattingEnabled = true;
            this.uiUnosNamjene.Location = new System.Drawing.Point(97, 66);
            this.uiUnosNamjene.Name = "uiUnosNamjene";
            this.uiUnosNamjene.Size = new System.Drawing.Size(177, 21);
            this.uiUnosNamjene.TabIndex = 8;
            // 
            // UnesiPovrsinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 147);
            this.Controls.Add(this.uiUnosNamjene);
            this.Controls.Add(this.uiActionUnesi);
            this.Controls.Add(this.uiActionOdustani);
            this.Controls.Add(this.uiUnosPovrsine);
            this.Controls.Add(this.uiUnosNaziva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnesiPovrsinu";
            this.Text = "UnesiPovrsinu";
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
        private System.Windows.Forms.Button uiActionUnesi;
        private System.Windows.Forms.ComboBox uiUnosNamjene;
    }
}