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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.navodnjavanjeTab = new System.Windows.Forms.TabPage();
            this.izborGodine = new System.Windows.Forms.ComboBox();
            this.uiActionStatistika = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuiraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiActionNovo = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.navodnjavanjeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaVodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.navodnjavanjeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pomocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.navodnjavanjeTab);
            this.tabControl1.Controls.Add(this.pomocTab);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 305);
            this.tabControl1.TabIndex = 8;
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
            this.label1.Size = new System.Drawing.Size(431, 169);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // navodnjavanjeViewBindingSource
            // 
            this.navodnjavanjeViewBindingSource.DataSource = typeof(PoljoAppVerzija2.NavodnjavanjeView);
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
            // KontrolaNavodnjavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "KontrolaNavodnjavanje";
            this.Size = new System.Drawing.Size(510, 340);
            this.tabControl1.ResumeLayout(false);
            this.navodnjavanjeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage navodnjavanjeTab;
        private System.Windows.Forms.Button uiActionStatistika;
        private System.Windows.Forms.Button uiActionIzbrisi;
        private System.Windows.Forms.Button uiActionAzuiraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uiActionNovo;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label label1;
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
    }
}
