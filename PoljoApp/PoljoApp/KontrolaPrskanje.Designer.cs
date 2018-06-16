namespace PoljoAppVerzija2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolaPrskanje));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.prskanjeTab = new System.Windows.Forms.TabPage();
            this.izborGodine = new System.Windows.Forms.ComboBox();
            this.uiActionIspis = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.pregledPrskanja = new System.Windows.Forms.DataGridView();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zastitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZastitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPovrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prskanjeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionNovo = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.ispisPomoc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.prskanjeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledPrskanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prskanjeViewBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.prskanjeTab);
            this.tabControl1.Controls.Add(this.pomocTab);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 305);
            this.tabControl1.TabIndex = 9;
            // 
            // prskanjeTab
            // 
            this.prskanjeTab.Controls.Add(this.izborGodine);
            this.prskanjeTab.Controls.Add(this.uiActionIspis);
            this.prskanjeTab.Controls.Add(this.uiActionIzbrisi);
            this.prskanjeTab.Controls.Add(this.uiActionAzuriraj);
            this.prskanjeTab.Controls.Add(this.pregledPrskanja);
            this.prskanjeTab.Controls.Add(this.uiActionNovo);
            this.prskanjeTab.Location = new System.Drawing.Point(4, 22);
            this.prskanjeTab.Name = "prskanjeTab";
            this.prskanjeTab.Padding = new System.Windows.Forms.Padding(3);
            this.prskanjeTab.Size = new System.Drawing.Size(466, 279);
            this.prskanjeTab.TabIndex = 1;
            this.prskanjeTab.Text = "Prskanje";
            this.prskanjeTab.UseVisualStyleBackColor = true;
            // 
            // izborGodine
            // 
            this.izborGodine.FormattingEnabled = true;
            this.izborGodine.Location = new System.Drawing.Point(26, 22);
            this.izborGodine.Name = "izborGodine";
            this.izborGodine.Size = new System.Drawing.Size(121, 21);
            this.izborGodine.TabIndex = 11;
            // 
            // uiActionIspis
            // 
            this.uiActionIspis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionIspis.Location = new System.Drawing.Point(341, 14);
            this.uiActionIspis.Name = "uiActionIspis";
            this.uiActionIspis.Size = new System.Drawing.Size(102, 34);
            this.uiActionIspis.TabIndex = 8;
            this.uiActionIspis.Text = "Ispiši u PDF";
            this.uiActionIspis.UseVisualStyleBackColor = true;
            this.uiActionIspis.Click += new System.EventHandler(this.UiActionIspis_Click);
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
            this.uiActionIzbrisi.Click += new System.EventHandler(this.UiActionIzbrisi_Click);
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
            this.datumDataGridViewTextBoxColumn,
            this.zastitaDataGridViewTextBoxColumn,
            this.povrsinaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.idZastitaDataGridViewTextBoxColumn,
            this.idPovrsinaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.pregledPrskanja.DataSource = this.prskanjeViewBindingSource;
            this.pregledPrskanja.Location = new System.Drawing.Point(25, 54);
            this.pregledPrskanja.MultiSelect = false;
            this.pregledPrskanja.Name = "pregledPrskanja";
            this.pregledPrskanja.ReadOnly = true;
            this.pregledPrskanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledPrskanja.Size = new System.Drawing.Size(418, 179);
            this.pregledPrskanja.TabIndex = 5;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zastitaDataGridViewTextBoxColumn
            // 
            this.zastitaDataGridViewTextBoxColumn.DataPropertyName = "Zastita";
            this.zastitaDataGridViewTextBoxColumn.HeaderText = "Korištena zaštita";
            this.zastitaDataGridViewTextBoxColumn.Name = "zastitaDataGridViewTextBoxColumn";
            this.zastitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // povrsinaDataGridViewTextBoxColumn
            // 
            this.povrsinaDataGridViewTextBoxColumn.DataPropertyName = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn.HeaderText = "Tretirana površina";
            this.povrsinaDataGridViewTextBoxColumn.Name = "povrsinaDataGridViewTextBoxColumn";
            this.povrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idZastitaDataGridViewTextBoxColumn
            // 
            this.idZastitaDataGridViewTextBoxColumn.DataPropertyName = "IdZastita";
            this.idZastitaDataGridViewTextBoxColumn.HeaderText = "IdZastita";
            this.idZastitaDataGridViewTextBoxColumn.Name = "idZastitaDataGridViewTextBoxColumn";
            this.idZastitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idZastitaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPovrsinaDataGridViewTextBoxColumn
            // 
            this.idPovrsinaDataGridViewTextBoxColumn.DataPropertyName = "IdPovrsina";
            this.idPovrsinaDataGridViewTextBoxColumn.HeaderText = "IdPovrsina";
            this.idPovrsinaDataGridViewTextBoxColumn.Name = "idPovrsinaDataGridViewTextBoxColumn";
            this.idPovrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPovrsinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // prskanjeViewBindingSource
            // 
            this.prskanjeViewBindingSource.DataSource = typeof(PoljoAppVerzija2.PrskanjeView);
            // 
            // uiActionNovo
            // 
            this.uiActionNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionNovo.Location = new System.Drawing.Point(341, 239);
            this.uiActionNovo.Name = "uiActionNovo";
            this.uiActionNovo.Size = new System.Drawing.Size(102, 34);
            this.uiActionNovo.TabIndex = 4;
            this.uiActionNovo.Text = "Dodaj prskanje";
            this.uiActionNovo.UseVisualStyleBackColor = true;
            this.uiActionNovo.Click += new System.EventHandler(this.UiActionNovo_Click);
            // 
            // pomocTab
            // 
            this.pomocTab.Controls.Add(this.ispisPomoc);
            this.pomocTab.Location = new System.Drawing.Point(4, 22);
            this.pomocTab.Name = "pomocTab";
            this.pomocTab.Padding = new System.Windows.Forms.Padding(3);
            this.pomocTab.Size = new System.Drawing.Size(466, 279);
            this.pomocTab.TabIndex = 0;
            this.pomocTab.Text = "Pomoć";
            this.pomocTab.UseVisualStyleBackColor = true;
            // 
            // ispisPomoc
            // 
            this.ispisPomoc.AutoSize = true;
            this.ispisPomoc.Location = new System.Drawing.Point(21, 19);
            this.ispisPomoc.Name = "ispisPomoc";
            this.ispisPomoc.Size = new System.Drawing.Size(432, 169);
            this.ispisPomoc.TabIndex = 0;
            this.ispisPomoc.Text = resources.GetString("ispisPomoc.Text");
            // 
            // KontrolaPrskanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "KontrolaPrskanje";
            this.Size = new System.Drawing.Size(510, 340);
            this.Load += new System.EventHandler(this.KontrolaPrskanje_Load);
            this.tabControl1.ResumeLayout(false);
            this.prskanjeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pregledPrskanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prskanjeViewBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
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
        private System.Windows.Forms.BindingSource prskanjeViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zastitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZastitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPovrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
