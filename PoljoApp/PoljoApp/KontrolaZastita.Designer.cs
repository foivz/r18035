namespace PoljoAppVerzija2
{
    partial class KontrolaZastita
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sadnjaTab = new System.Windows.Forms.TabPage();
            this.uiIzborVrsteZastite = new System.Windows.Forms.ComboBox();
            this.vrstazastiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koncentracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvrstezastiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prskanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstazastiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zastitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActionDodajZastitu = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.sadnjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstazastiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastitaBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.sadnjaTab);
            this.tabControl1.Controls.Add(this.pomocTab);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 305);
            this.tabControl1.TabIndex = 9;
            // 
            // sadnjaTab
            // 
            this.sadnjaTab.Controls.Add(this.uiIzborVrsteZastite);
            this.sadnjaTab.Controls.Add(this.button4);
            this.sadnjaTab.Controls.Add(this.uiActionIzbrisi);
            this.sadnjaTab.Controls.Add(this.uiActionAzuriraj);
            this.sadnjaTab.Controls.Add(this.dataGridView1);
            this.sadnjaTab.Controls.Add(this.ActionDodajZastitu);
            this.sadnjaTab.Location = new System.Drawing.Point(4, 22);
            this.sadnjaTab.Name = "sadnjaTab";
            this.sadnjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.sadnjaTab.Size = new System.Drawing.Size(466, 279);
            this.sadnjaTab.TabIndex = 1;
            this.sadnjaTab.Text = "Zaštita";
            this.sadnjaTab.UseVisualStyleBackColor = true;
            // 
            // uiIzborVrsteZastite
            // 
            this.uiIzborVrsteZastite.DataSource = this.vrstazastiteBindingSource;
            this.uiIzborVrsteZastite.DisplayMember = "naziv";
            this.uiIzborVrsteZastite.FormattingEnabled = true;
            this.uiIzborVrsteZastite.Location = new System.Drawing.Point(26, 22);
            this.uiIzborVrsteZastite.Name = "uiIzborVrsteZastite";
            this.uiIzborVrsteZastite.Size = new System.Drawing.Size(121, 21);
            this.uiIzborVrsteZastite.TabIndex = 9;
            this.uiIzborVrsteZastite.ValueMember = "id";
            this.uiIzborVrsteZastite.SelectedIndexChanged += new System.EventHandler(this.uiIzborVrsteZastite_SelectedIndexChanged);
            // 
            // vrstazastiteBindingSource
            // 
            this.vrstazastiteBindingSource.DataSource = typeof(PoljoAppVerzija2.vrsta_zastite);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(153, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sortiraj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // uiActionIzbrisi
            // 
            this.uiActionIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionIzbrisi.Location = new System.Drawing.Point(153, 239);
            this.uiActionIzbrisi.Name = "uiActionIzbrisi";
            this.uiActionIzbrisi.Size = new System.Drawing.Size(102, 34);
            this.uiActionIzbrisi.TabIndex = 7;
            this.uiActionIzbrisi.Text = "Izbriši";
            this.uiActionIzbrisi.UseVisualStyleBackColor = true;
            this.uiActionIzbrisi.Click += new System.EventHandler(this.uiActionIzbrisi_Click);
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionAzuriraj.Location = new System.Drawing.Point(25, 239);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(102, 34);
            this.uiActionAzuriraj.TabIndex = 6;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.koncentracijaDataGridViewTextBoxColumn,
            this.idvrstezastiteDataGridViewTextBoxColumn,
            this.prskanjeDataGridViewTextBoxColumn,
            this.vrstazastiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zastitaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // koncentracijaDataGridViewTextBoxColumn
            // 
            this.koncentracijaDataGridViewTextBoxColumn.DataPropertyName = "koncentracija";
            this.koncentracijaDataGridViewTextBoxColumn.HeaderText = "koncentracija";
            this.koncentracijaDataGridViewTextBoxColumn.Name = "koncentracijaDataGridViewTextBoxColumn";
            // 
            // idvrstezastiteDataGridViewTextBoxColumn
            // 
            this.idvrstezastiteDataGridViewTextBoxColumn.DataPropertyName = "id_vrste_zastite";
            this.idvrstezastiteDataGridViewTextBoxColumn.HeaderText = "id_vrste_zastite";
            this.idvrstezastiteDataGridViewTextBoxColumn.Name = "idvrstezastiteDataGridViewTextBoxColumn";
            // 
            // prskanjeDataGridViewTextBoxColumn
            // 
            this.prskanjeDataGridViewTextBoxColumn.DataPropertyName = "prskanje";
            this.prskanjeDataGridViewTextBoxColumn.HeaderText = "prskanje";
            this.prskanjeDataGridViewTextBoxColumn.Name = "prskanjeDataGridViewTextBoxColumn";
            this.prskanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // vrstazastiteDataGridViewTextBoxColumn
            // 
            this.vrstazastiteDataGridViewTextBoxColumn.DataPropertyName = "vrsta_zastite";
            this.vrstazastiteDataGridViewTextBoxColumn.HeaderText = "vrsta_zastite";
            this.vrstazastiteDataGridViewTextBoxColumn.Name = "vrstazastiteDataGridViewTextBoxColumn";
            this.vrstazastiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // zastitaBindingSource
            // 
            this.zastitaBindingSource.DataSource = typeof(PoljoAppVerzija2.zastita);
            // 
            // ActionDodajZastitu
            // 
            this.ActionDodajZastitu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionDodajZastitu.Location = new System.Drawing.Point(341, 239);
            this.ActionDodajZastitu.Name = "ActionDodajZastitu";
            this.ActionDodajZastitu.Size = new System.Drawing.Size(102, 34);
            this.ActionDodajZastitu.TabIndex = 4;
            this.ActionDodajZastitu.Text = "Dodaj zaštitu";
            this.ActionDodajZastitu.UseVisualStyleBackColor = true;
            this.ActionDodajZastitu.Click += new System.EventHandler(this.ActionDodajZastitu_Click);
            // 
            // pomocTab
            // 
            this.pomocTab.Controls.Add(this.label1);
            this.pomocTab.Location = new System.Drawing.Point(4, 22);
            this.pomocTab.Name = "pomocTab";
            this.pomocTab.Padding = new System.Windows.Forms.Padding(3);
            this.pomocTab.Size = new System.Drawing.Size(466, 279);
            this.pomocTab.TabIndex = 0;
            this.pomocTab.Text = "Pomoć";
            this.pomocTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomoć korisniku";
            // 
            // KontrolaZastita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "KontrolaZastita";
            this.Size = new System.Drawing.Size(510, 340);
            this.Load += new System.EventHandler(this.KontrolaZastita_Load);
            this.tabControl1.ResumeLayout(false);
            this.sadnjaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vrstazastiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastitaBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sadnjaTab;
        private System.Windows.Forms.ComboBox uiIzborVrsteZastite;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button uiActionIzbrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ActionDodajZastitu;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vrstazastiteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koncentracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvrstezastiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prskanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstazastiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zastitaBindingSource;
    }
}
