﻿namespace PoljoAppVerzija2
{
    partial class KontrolaPrskanje
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
            this.prskanjeTab = new System.Windows.Forms.TabPage();
            this.izborGodine = new System.Windows.Forms.ComboBox();
            this.uiActionIspis = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.pregledPrskanja = new System.Windows.Forms.DataGridView();
            this.uiActionNovo = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.ispisPomoc = new System.Windows.Forms.Label();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzastitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpovrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prskanjeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.prskanjeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledPrskanja)).BeginInit();
            this.pomocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prskanjeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.prskanjeTab);
            this.tabControl1.Controls.Add(this.pomocTab);
            this.tabControl1.Location = new System.Drawing.Point(19, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 375);
            this.tabControl1.TabIndex = 9;
            // 
            // prskanjeTab
            // 
            this.prskanjeTab.Controls.Add(this.izborGodine);
            this.prskanjeTab.Controls.Add(this.uiActionIspis);
            this.prskanjeTab.Controls.Add(this.button5);
            this.prskanjeTab.Controls.Add(this.uiActionIzbrisi);
            this.prskanjeTab.Controls.Add(this.uiActionAzuriraj);
            this.prskanjeTab.Controls.Add(this.pregledPrskanja);
            this.prskanjeTab.Controls.Add(this.uiActionNovo);
            this.prskanjeTab.Location = new System.Drawing.Point(4, 25);
            this.prskanjeTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prskanjeTab.Name = "prskanjeTab";
            this.prskanjeTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prskanjeTab.Size = new System.Drawing.Size(624, 346);
            this.prskanjeTab.TabIndex = 1;
            this.prskanjeTab.Text = "Prskanje";
            this.prskanjeTab.UseVisualStyleBackColor = true;
            // 
            // izborGodine
            // 
            this.izborGodine.FormattingEnabled = true;
            this.izborGodine.Location = new System.Drawing.Point(35, 27);
            this.izborGodine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izborGodine.Name = "izborGodine";
            this.izborGodine.Size = new System.Drawing.Size(160, 24);
            this.izborGodine.TabIndex = 11;
            // 
            // uiActionIspis
            // 
            this.uiActionIspis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionIspis.Location = new System.Drawing.Point(455, 17);
            this.uiActionIspis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionIspis.Name = "uiActionIspis";
            this.uiActionIspis.Size = new System.Drawing.Size(136, 42);
            this.uiActionIspis.TabIndex = 8;
            this.uiActionIspis.Text = "Ispiši u PDF";
            this.uiActionIspis.UseVisualStyleBackColor = true;
            this.uiActionIspis.Click += new System.EventHandler(this.UiActionIspis_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 17);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 42);
            this.button5.TabIndex = 10;
            this.button5.Text = "Sortiraj";
            this.button5.UseVisualStyleBackColor = true;
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
            this.uiActionIzbrisi.Click += new System.EventHandler(this.UiActionIzbrisi_Click);
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
            this.uiActionAzuriraj.Click += new System.EventHandler(this.UiActionAzuriraj_Click);
            // 
            // pregledPrskanja
            // 
            this.pregledPrskanja.AllowUserToAddRows = false;
            this.pregledPrskanja.AllowUserToDeleteRows = false;
            this.pregledPrskanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pregledPrskanja.AutoGenerateColumns = false;
            this.pregledPrskanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledPrskanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.povrsinaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.idzastitaDataGridViewTextBoxColumn,
            this.idpovrsinaDataGridViewTextBoxColumn});
            this.pregledPrskanja.DataSource = this.prskanjeViewBindingSource;
            this.pregledPrskanja.Location = new System.Drawing.Point(33, 66);
            this.pregledPrskanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pregledPrskanja.MultiSelect = false;
            this.pregledPrskanja.Name = "pregledPrskanja";
            this.pregledPrskanja.ReadOnly = true;
            this.pregledPrskanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledPrskanja.Size = new System.Drawing.Size(557, 220);
            this.pregledPrskanja.TabIndex = 5;
            // 
            // uiActionNovo
            // 
            this.uiActionNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionNovo.Location = new System.Drawing.Point(455, 294);
            this.uiActionNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionNovo.Name = "uiActionNovo";
            this.uiActionNovo.Size = new System.Drawing.Size(136, 42);
            this.uiActionNovo.TabIndex = 4;
            this.uiActionNovo.Text = "Dodaj prskanje";
            this.uiActionNovo.UseVisualStyleBackColor = true;
            this.uiActionNovo.Click += new System.EventHandler(this.UiActionNovo_Click);
            // 
            // pomocTab
            // 
            this.pomocTab.Controls.Add(this.ispisPomoc);
            this.pomocTab.Location = new System.Drawing.Point(4, 25);
            this.pomocTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomocTab.Name = "pomocTab";
            this.pomocTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomocTab.Size = new System.Drawing.Size(624, 346);
            this.pomocTab.TabIndex = 0;
            this.pomocTab.Text = "Pomoć";
            this.pomocTab.UseVisualStyleBackColor = true;
            // 
            // ispisPomoc
            // 
            this.ispisPomoc.AutoSize = true;
            this.ispisPomoc.Location = new System.Drawing.Point(28, 23);
            this.ispisPomoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ispisPomoc.Name = "ispisPomoc";
            this.ispisPomoc.Size = new System.Drawing.Size(111, 17);
            this.ispisPomoc.TabIndex = 0;
            this.ispisPomoc.Text = "Pomoć korisniku";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // povrsinaDataGridViewTextBoxColumn
            // 
            this.povrsinaDataGridViewTextBoxColumn.DataPropertyName = "povrsina";
            this.povrsinaDataGridViewTextBoxColumn.HeaderText = "povrsina";
            this.povrsinaDataGridViewTextBoxColumn.Name = "povrsinaDataGridViewTextBoxColumn";
            this.povrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idzastitaDataGridViewTextBoxColumn
            // 
            this.idzastitaDataGridViewTextBoxColumn.DataPropertyName = "id_zastita";
            this.idzastitaDataGridViewTextBoxColumn.HeaderText = "id_zastita";
            this.idzastitaDataGridViewTextBoxColumn.Name = "idzastitaDataGridViewTextBoxColumn";
            this.idzastitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzastitaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpovrsinaDataGridViewTextBoxColumn
            // 
            this.idpovrsinaDataGridViewTextBoxColumn.DataPropertyName = "id_povrsina";
            this.idpovrsinaDataGridViewTextBoxColumn.HeaderText = "id_povrsina";
            this.idpovrsinaDataGridViewTextBoxColumn.Name = "idpovrsinaDataGridViewTextBoxColumn";
            this.idpovrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpovrsinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // prskanjeViewBindingSource
            // 
            this.prskanjeViewBindingSource.DataSource = typeof(PoljoAppVerzija2.prskanjeView);
            // 
            // KontrolaPrskanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KontrolaPrskanje";
            this.Size = new System.Drawing.Size(680, 418);
            this.Load += new System.EventHandler(this.KontrolaPrskanje_Load);
            this.tabControl1.ResumeLayout(false);
            this.prskanjeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pregledPrskanja)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prskanjeViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage prskanjeTab;
        private System.Windows.Forms.Button uiActionIspis;
        private System.Windows.Forms.Button uiActionIzbrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.DataGridView pregledPrskanja;
        private System.Windows.Forms.Button uiActionNovo;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label ispisPomoc;
        private System.Windows.Forms.ComboBox izborGodine;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource prskanjeViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzastitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpovrsinaDataGridViewTextBoxColumn;
    }
}
