﻿namespace PoljoAppVerzija2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolaZastita));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sadnjaTab = new System.Windows.Forms.TabPage();
            this.uiIzborVrsteZastite = new System.Windows.Forms.ComboBox();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koncentracijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zastitaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActionDodajZastitu = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vrstazastiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.sadnjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastitaViewBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstazastiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.sadnjaTab);
            this.tabControl1.Controls.Add(this.pomocTab);
            this.tabControl1.Location = new System.Drawing.Point(24, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 375);
            this.tabControl1.TabIndex = 9;
            // 
            // sadnjaTab
            // 
            this.sadnjaTab.Controls.Add(this.uiIzborVrsteZastite);
            this.sadnjaTab.Controls.Add(this.uiActionIzbrisi);
            this.sadnjaTab.Controls.Add(this.uiActionAzuriraj);
            this.sadnjaTab.Controls.Add(this.dataGridView1);
            this.sadnjaTab.Controls.Add(this.ActionDodajZastitu);
            this.sadnjaTab.Location = new System.Drawing.Point(4, 25);
            this.sadnjaTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sadnjaTab.Name = "sadnjaTab";
            this.sadnjaTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sadnjaTab.Size = new System.Drawing.Size(624, 346);
            this.sadnjaTab.TabIndex = 1;
            this.sadnjaTab.Text = "Zaštita";
            this.sadnjaTab.UseVisualStyleBackColor = true;
            // 
            // uiIzborVrsteZastite
            // 
            this.uiIzborVrsteZastite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiIzborVrsteZastite.FormattingEnabled = true;
            this.uiIzborVrsteZastite.Location = new System.Drawing.Point(35, 27);
            this.uiIzborVrsteZastite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiIzborVrsteZastite.Name = "uiIzborVrsteZastite";
            this.uiIzborVrsteZastite.Size = new System.Drawing.Size(160, 24);
            this.uiIzborVrsteZastite.TabIndex = 9;
            this.uiIzborVrsteZastite.SelectedIndexChanged += new System.EventHandler(this.uiIzborVrsteZastite_SelectedIndexChanged);
            // 
            // uiActionIzbrisi
            // 
            this.uiActionIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionIzbrisi.Location = new System.Drawing.Point(204, 294);
            this.uiActionIzbrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionIzbrisi.Name = "uiActionIzbrisi";
            this.uiActionIzbrisi.Size = new System.Drawing.Size(136, 42);
            this.uiActionIzbrisi.TabIndex = 7;
            this.uiActionIzbrisi.Text = "Izbriši";
            this.uiActionIzbrisi.UseVisualStyleBackColor = true;
            this.uiActionIzbrisi.Click += new System.EventHandler(this.uiActionIzbrisi_Click);
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionAzuriraj.Location = new System.Drawing.Point(33, 294);
            this.uiActionAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(136, 42);
            this.uiActionAzuriraj.TabIndex = 6;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.koncentracijaDataGridViewTextBoxColumn,
            this.Vrsta});
            this.dataGridView1.DataSource = this.zastitaViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(557, 220);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Zaštite";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // koncentracijaDataGridViewTextBoxColumn
            // 
            this.koncentracijaDataGridViewTextBoxColumn.DataPropertyName = "koncentracija";
            this.koncentracijaDataGridViewTextBoxColumn.HeaderText = "Koncentracija";
            this.koncentracijaDataGridViewTextBoxColumn.Name = "koncentracijaDataGridViewTextBoxColumn";
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta zaštite";
            this.Vrsta.Name = "Vrsta";
            // 
            // zastitaViewBindingSource
            // 
            this.zastitaViewBindingSource.DataSource = typeof(DataLayer.ZastitaView);
            // 
            // ActionDodajZastitu
            // 
            this.ActionDodajZastitu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionDodajZastitu.Location = new System.Drawing.Point(455, 294);
            this.ActionDodajZastitu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActionDodajZastitu.Name = "ActionDodajZastitu";
            this.ActionDodajZastitu.Size = new System.Drawing.Size(136, 42);
            this.ActionDodajZastitu.TabIndex = 4;
            this.ActionDodajZastitu.Text = "Dodaj zaštitu";
            this.ActionDodajZastitu.UseVisualStyleBackColor = true;
            this.ActionDodajZastitu.Click += new System.EventHandler(this.ActionDodajZastitu_Click);
            // 
            // pomocTab
            // 
            this.pomocTab.Controls.Add(this.label4);
            this.pomocTab.Controls.Add(this.label3);
            this.pomocTab.Controls.Add(this.label2);
            this.pomocTab.Controls.Add(this.label1);
            this.pomocTab.Location = new System.Drawing.Point(4, 25);
            this.pomocTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomocTab.Name = "pomocTab";
            this.pomocTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomocTab.Size = new System.Drawing.Size(624, 346);
            this.pomocTab.TabIndex = 0;
            this.pomocTab.Text = "Pomoć";
            this.pomocTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(518, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = "4. Brisanje zaštite\r\nKorisnik briše zaštitu tako da klikne na željenu zaštitu u t" +
    "ablici i zatim klikne na \r\ngumb \"Izbriši\". Na skočnom prozoru potrebno je odabra" +
    "ti \"Da\" za brisanje zaštite.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 68);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // vrstazastiteBindingSource
            // 
            this.vrstazastiteBindingSource.DataSource = typeof(DataLayer.vrsta_zastite);
            // 
            // KontrolaZastita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KontrolaZastita";
            this.Size = new System.Drawing.Size(680, 418);
            this.Load += new System.EventHandler(this.KontrolaZastita_Load);
            this.tabControl1.ResumeLayout(false);
            this.sadnjaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zastitaViewBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstazastiteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sadnjaTab;
        private System.Windows.Forms.ComboBox uiIzborVrsteZastite;
        private System.Windows.Forms.Button uiActionIzbrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ActionDodajZastitu;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.BindingSource vrstazastiteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prskanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zastitaViewBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koncentracijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
    }
}
