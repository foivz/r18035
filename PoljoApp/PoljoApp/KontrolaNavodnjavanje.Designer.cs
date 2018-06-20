namespace PoljoAppVerzija2
{
    partial class KontrolaNavodnjavanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolaNavodnjavanje));
            this.navodnjavanjeTabs = new System.Windows.Forms.TabControl();
            this.navodnjavanjeTab = new System.Windows.Forms.TabPage();
            this.izborGodine = new System.Windows.Forms.ComboBox();
            this.uiActionStatistika = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuiraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaVodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navodnjavanjeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionNovo = new System.Windows.Forms.Button();
            this.oborineTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.uiActionOdbij = new System.Windows.Forms.Button();
            this.uiActionUnesi = new System.Windows.Forms.Button();
            this.pregledOborine = new System.Windows.Forms.DataGridView();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaVodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPovrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oborineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.ispisPomoc = new System.Windows.Forms.Label();
            this.navodnjavanjeTabs.SuspendLayout();
            this.navodnjavanjeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeViewBindingSource)).BeginInit();
            this.oborineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledOborine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborineBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // navodnjavanjeTabs
            // 
            this.navodnjavanjeTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navodnjavanjeTabs.Controls.Add(this.navodnjavanjeTab);
            this.navodnjavanjeTabs.Controls.Add(this.oborineTab);
            this.navodnjavanjeTabs.Controls.Add(this.pomocTab);
            this.navodnjavanjeTabs.Location = new System.Drawing.Point(18, 18);
            this.navodnjavanjeTabs.Name = "navodnjavanjeTabs";
            this.navodnjavanjeTabs.SelectedIndex = 0;
            this.navodnjavanjeTabs.Size = new System.Drawing.Size(474, 305);
            this.navodnjavanjeTabs.TabIndex = 8;
            this.navodnjavanjeTabs.SelectedIndexChanged += new System.EventHandler(this.NavodnjavanjeTabs_SelectedIndexChanged);
            // 
            // navodnjavanjeTab
            // 
            this.navodnjavanjeTab.Controls.Add(this.izborGodine);
            this.navodnjavanjeTab.Controls.Add(this.uiActionStatistika);
            this.navodnjavanjeTab.Controls.Add(this.uiActionIzbrisi);
            this.navodnjavanjeTab.Controls.Add(this.uiActionAzuiraj);
            this.navodnjavanjeTab.Controls.Add(this.dataGridView1);
            this.navodnjavanjeTab.Controls.Add(this.uiActionNovo);
            this.navodnjavanjeTab.Location = new System.Drawing.Point(4, 22);
            this.navodnjavanjeTab.Name = "navodnjavanjeTab";
            this.navodnjavanjeTab.Padding = new System.Windows.Forms.Padding(3);
            this.navodnjavanjeTab.Size = new System.Drawing.Size(466, 279);
            this.navodnjavanjeTab.TabIndex = 1;
            this.navodnjavanjeTab.Text = "Navodnjavanje";
            this.navodnjavanjeTab.UseVisualStyleBackColor = true;
            // 
            // izborGodine
            // 
            this.izborGodine.FormattingEnabled = true;
            this.izborGodine.Location = new System.Drawing.Point(25, 22);
            this.izborGodine.Name = "izborGodine";
            this.izborGodine.Size = new System.Drawing.Size(121, 21);
            this.izborGodine.TabIndex = 13;
            this.izborGodine.SelectedIndexChanged += new System.EventHandler(this.IzborGodine_SelectedIndexChanged);
            // 
            // uiActionStatistika
            // 
            this.uiActionStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionStatistika.Location = new System.Drawing.Point(341, 14);
            this.uiActionStatistika.Name = "uiActionStatistika";
            this.uiActionStatistika.Size = new System.Drawing.Size(102, 34);
            this.uiActionStatistika.TabIndex = 8;
            this.uiActionStatistika.Text = "Statistika";
            this.uiActionStatistika.UseVisualStyleBackColor = true;
            this.uiActionStatistika.Click += new System.EventHandler(this.UiActionStatistika_Click);
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
            // uiActionAzuiraj
            // 
            this.uiActionAzuiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionAzuiraj.Location = new System.Drawing.Point(25, 239);
            this.uiActionAzuiraj.Name = "uiActionAzuiraj";
            this.uiActionAzuiraj.Size = new System.Drawing.Size(102, 34);
            this.uiActionAzuiraj.TabIndex = 6;
            this.uiActionAzuiraj.Text = "Ažuriraj";
            this.uiActionAzuiraj.UseVisualStyleBackColor = true;
            this.uiActionAzuiraj.Click += new System.EventHandler(this.UiActionAzuiraj_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.povrsinaDataGridViewTextBoxColumn,
            this.kolicinaVodeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.navodnjavanjeViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(418, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // povrsinaDataGridViewTextBoxColumn
            // 
            this.povrsinaDataGridViewTextBoxColumn.DataPropertyName = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn.HeaderText = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn.Name = "povrsinaDataGridViewTextBoxColumn";
            this.povrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaVodeDataGridViewTextBoxColumn
            // 
            this.kolicinaVodeDataGridViewTextBoxColumn.DataPropertyName = "KolicinaVode";
            this.kolicinaVodeDataGridViewTextBoxColumn.HeaderText = "Količina vode";
            this.kolicinaVodeDataGridViewTextBoxColumn.Name = "kolicinaVodeDataGridViewTextBoxColumn";
            this.kolicinaVodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PovrsinaM2";
            this.dataGridViewTextBoxColumn2.HeaderText = "Veličina površine";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vrsta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdPovrsina";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdPovrsina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdStanja";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdStanja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // navodnjavanjeViewBindingSource
            // 
            this.navodnjavanjeViewBindingSource.DataSource = typeof(PoljoAppVerzija2.NavodnjavanjeView);
            // 
            // uiActionNovo
            // 
            this.uiActionNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionNovo.Location = new System.Drawing.Point(341, 239);
            this.uiActionNovo.Name = "uiActionNovo";
            this.uiActionNovo.Size = new System.Drawing.Size(102, 34);
            this.uiActionNovo.TabIndex = 4;
            this.uiActionNovo.Text = "Dodaj navodnjavanje";
            this.uiActionNovo.UseVisualStyleBackColor = true;
            this.uiActionNovo.Click += new System.EventHandler(this.UiActionNovo_Click);
            // 
            // oborineTab
            // 
            this.oborineTab.Controls.Add(this.label2);
            this.oborineTab.Controls.Add(this.uiActionOdbij);
            this.oborineTab.Controls.Add(this.uiActionUnesi);
            this.oborineTab.Controls.Add(this.pregledOborine);
            this.oborineTab.Location = new System.Drawing.Point(4, 22);
            this.oborineTab.Name = "oborineTab";
            this.oborineTab.Padding = new System.Windows.Forms.Padding(3);
            this.oborineTab.Size = new System.Drawing.Size(466, 279);
            this.oborineTab.TabIndex = 2;
            this.oborineTab.Text = "Oborine";
            this.oborineTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dohvaćeni zapisi o oborinama:";
            // 
            // uiActionOdbij
            // 
            this.uiActionOdbij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionOdbij.Location = new System.Drawing.Point(137, 239);
            this.uiActionOdbij.Name = "uiActionOdbij";
            this.uiActionOdbij.Size = new System.Drawing.Size(102, 34);
            this.uiActionOdbij.TabIndex = 10;
            this.uiActionOdbij.Text = "Izbriši";
            this.uiActionOdbij.UseVisualStyleBackColor = true;
            this.uiActionOdbij.Click += new System.EventHandler(this.UiActionOdbij_Click);
            // 
            // uiActionUnesi
            // 
            this.uiActionUnesi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionUnesi.Location = new System.Drawing.Point(29, 239);
            this.uiActionUnesi.Name = "uiActionUnesi";
            this.uiActionUnesi.Size = new System.Drawing.Size(102, 34);
            this.uiActionUnesi.TabIndex = 9;
            this.uiActionUnesi.Text = "Unesi";
            this.uiActionUnesi.UseVisualStyleBackColor = true;
            this.uiActionUnesi.Click += new System.EventHandler(this.UiActionUnesi_Click);
            // 
            // pregledOborine
            // 
            this.pregledOborine.AllowUserToAddRows = false;
            this.pregledOborine.AllowUserToDeleteRows = false;
            this.pregledOborine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pregledOborine.AutoGenerateColumns = false;
            this.pregledOborine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pregledOborine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledOborine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.povrsinaDataGridViewTextBoxColumn1,
            this.povrsinaM2DataGridViewTextBoxColumn,
            this.kolicinaVodeDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.idPovrsinaDataGridViewTextBoxColumn,
            this.idStanjaDataGridViewTextBoxColumn});
            this.pregledOborine.DataSource = this.oborineBindingSource;
            this.pregledOborine.Location = new System.Drawing.Point(29, 40);
            this.pregledOborine.MultiSelect = false;
            this.pregledOborine.Name = "pregledOborine";
            this.pregledOborine.ReadOnly = true;
            this.pregledOborine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledOborine.Size = new System.Drawing.Size(397, 179);
            this.pregledOborine.TabIndex = 0;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // povrsinaDataGridViewTextBoxColumn1
            // 
            this.povrsinaDataGridViewTextBoxColumn1.DataPropertyName = "Povrsina";
            this.povrsinaDataGridViewTextBoxColumn1.HeaderText = "Površina";
            this.povrsinaDataGridViewTextBoxColumn1.Name = "povrsinaDataGridViewTextBoxColumn1";
            this.povrsinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // povrsinaM2DataGridViewTextBoxColumn
            // 
            this.povrsinaM2DataGridViewTextBoxColumn.DataPropertyName = "PovrsinaM2";
            this.povrsinaM2DataGridViewTextBoxColumn.HeaderText = "Veličina površine";
            this.povrsinaM2DataGridViewTextBoxColumn.Name = "povrsinaM2DataGridViewTextBoxColumn";
            this.povrsinaM2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaVodeDataGridViewTextBoxColumn1
            // 
            this.kolicinaVodeDataGridViewTextBoxColumn1.DataPropertyName = "KolicinaVode";
            this.kolicinaVodeDataGridViewTextBoxColumn1.HeaderText = "Količina vode";
            this.kolicinaVodeDataGridViewTextBoxColumn1.Name = "kolicinaVodeDataGridViewTextBoxColumn1";
            this.kolicinaVodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kolicinaVodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idPovrsinaDataGridViewTextBoxColumn
            // 
            this.idPovrsinaDataGridViewTextBoxColumn.DataPropertyName = "IdPovrsina";
            this.idPovrsinaDataGridViewTextBoxColumn.HeaderText = "IdPovrsina";
            this.idPovrsinaDataGridViewTextBoxColumn.Name = "idPovrsinaDataGridViewTextBoxColumn";
            this.idPovrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPovrsinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idStanjaDataGridViewTextBoxColumn
            // 
            this.idStanjaDataGridViewTextBoxColumn.DataPropertyName = "IdStanja";
            this.idStanjaDataGridViewTextBoxColumn.HeaderText = "IdStanja";
            this.idStanjaDataGridViewTextBoxColumn.Name = "idStanjaDataGridViewTextBoxColumn";
            this.idStanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // oborineBindingSource
            // 
            this.oborineBindingSource.DataSource = typeof(PoljoAppVerzija2.NavodnjavanjeView);
            // 
            // pomocTab
            // 
            this.pomocTab.AutoScroll = true;
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
            this.ispisPomoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ispisPomoc.Location = new System.Drawing.Point(6, 11);
            this.ispisPomoc.Name = "ispisPomoc";
            this.ispisPomoc.Size = new System.Drawing.Size(440, 351);
            this.ispisPomoc.TabIndex = 0;
            this.ispisPomoc.Text = resources.GetString("ispisPomoc.Text");
            // 
            // KontrolaNavodnjavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navodnjavanjeTabs);
            this.Name = "KontrolaNavodnjavanje";
            this.Size = new System.Drawing.Size(510, 340);
            this.Load += new System.EventHandler(this.KontrolaNavodnjavanje_Load);
            this.navodnjavanjeTabs.ResumeLayout(false);
            this.navodnjavanjeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeViewBindingSource)).EndInit();
            this.oborineTab.ResumeLayout(false);
            this.oborineTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregledOborine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oborineBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navodnjavanjeTabs;
        private System.Windows.Forms.TabPage navodnjavanjeTab;
        private System.Windows.Forms.Button uiActionStatistika;
        private System.Windows.Forms.Button uiActionIzbrisi;
        private System.Windows.Forms.Button uiActionAzuiraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uiActionNovo;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label ispisPomoc;
        private System.Windows.Forms.ComboBox izborGodine;
        private System.Windows.Forms.BindingSource navodnjavanjeViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaVodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage oborineTab;
        private System.Windows.Forms.DataGridView pregledOborine;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinaM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaVodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPovrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oborineBindingSource;
        private System.Windows.Forms.Button uiActionOdbij;
        private System.Windows.Forms.Button uiActionUnesi;
        private System.Windows.Forms.Label label2;
    }
}
