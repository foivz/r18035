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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.navodnjavanjeTab = new System.Windows.Forms.TabPage();
            this.uiActionStatistika = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuiraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpovrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinavodelitriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinanazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navodnjavanjeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionNovo = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.navodnjavanjeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeViewBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
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
            // uiActionStatistika
            // 
            this.uiActionStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionStatistika.Location = new System.Drawing.Point(341, 14);
            this.uiActionStatistika.Name = "uiActionStatistika";
            this.uiActionStatistika.Size = new System.Drawing.Size(102, 34);
            this.uiActionStatistika.TabIndex = 8;
            this.uiActionStatistika.Text = "Statistika";
            this.uiActionStatistika.UseVisualStyleBackColor = true;
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
            this.idpovrsinaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.kolicinavodelitriDataGridViewTextBoxColumn,
            this.idstanjaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.povrsinanazivDataGridViewTextBoxColumn,
            this.povrsinam2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.navodnjavanjeViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(418, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // idpovrsinaDataGridViewTextBoxColumn
            // 
            this.idpovrsinaDataGridViewTextBoxColumn.DataPropertyName = "id_povrsina";
            this.idpovrsinaDataGridViewTextBoxColumn.HeaderText = "id_povrsina";
            this.idpovrsinaDataGridViewTextBoxColumn.Name = "idpovrsinaDataGridViewTextBoxColumn";
            this.idpovrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpovrsinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinavodelitriDataGridViewTextBoxColumn
            // 
            this.kolicinavodelitriDataGridViewTextBoxColumn.DataPropertyName = "kolicina_vode_litri";
            this.kolicinavodelitriDataGridViewTextBoxColumn.HeaderText = "kolicina_vode_litri";
            this.kolicinavodelitriDataGridViewTextBoxColumn.Name = "kolicinavodelitriDataGridViewTextBoxColumn";
            this.kolicinavodelitriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idstanjaDataGridViewTextBoxColumn
            // 
            this.idstanjaDataGridViewTextBoxColumn.DataPropertyName = "id_stanja";
            this.idstanjaDataGridViewTextBoxColumn.HeaderText = "id_stanja";
            this.idstanjaDataGridViewTextBoxColumn.Name = "idstanjaDataGridViewTextBoxColumn";
            this.idstanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // povrsinanazivDataGridViewTextBoxColumn
            // 
            this.povrsinanazivDataGridViewTextBoxColumn.DataPropertyName = "povrsina_naziv";
            this.povrsinanazivDataGridViewTextBoxColumn.HeaderText = "povrsina_naziv";
            this.povrsinanazivDataGridViewTextBoxColumn.Name = "povrsinanazivDataGridViewTextBoxColumn";
            this.povrsinanazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // povrsinam2DataGridViewTextBoxColumn
            // 
            this.povrsinam2DataGridViewTextBoxColumn.DataPropertyName = "povrsina_m2";
            this.povrsinam2DataGridViewTextBoxColumn.HeaderText = "povrsina_m2";
            this.povrsinam2DataGridViewTextBoxColumn.Name = "povrsinam2DataGridViewTextBoxColumn";
            this.povrsinam2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // navodnjavanjeViewBindingSource
            // 
            this.navodnjavanjeViewBindingSource.DataSource = typeof(PoljoAppVerzija2.navodnjavanjeView);
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
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomoć korisniku";
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
            ((System.ComponentModel.ISupportInitialize)(this.navodnjavanjeViewBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idpovrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinavodelitriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinanazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource navodnjavanjeViewBindingSource;
    }
}
