namespace PoljoAppVerzija2
{
    partial class KontrolaPovrsine
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
            this.povrsineTab = new System.Windows.Forms.TabPage();
            this.izborNamjenePovrsina = new System.Windows.Forms.ComboBox();
            this.namjenapovrsineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnamjeneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namjenapovrsineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navodnjavanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prskanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadnjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poljpovrsinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodajPovrsinu = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.povrsineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namjenapovrsineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.povrsineTab);
            this.tabControl1.Controls.Add(this.pomocTab);
            this.tabControl1.Location = new System.Drawing.Point(24, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 375);
            this.tabControl1.TabIndex = 7;
            // 
            // povrsineTab
            // 
            this.povrsineTab.Controls.Add(this.izborNamjenePovrsina);
            this.povrsineTab.Controls.Add(this.button4);
            this.povrsineTab.Controls.Add(this.uiActionIzbrisi);
            this.povrsineTab.Controls.Add(this.uiActionAzuriraj);
            this.povrsineTab.Controls.Add(this.dataGridView1);
            this.povrsineTab.Controls.Add(this.uiActionDodajPovrsinu);
            this.povrsineTab.Location = new System.Drawing.Point(4, 25);
            this.povrsineTab.Margin = new System.Windows.Forms.Padding(4);
            this.povrsineTab.Name = "povrsineTab";
            this.povrsineTab.Padding = new System.Windows.Forms.Padding(4);
            this.povrsineTab.Size = new System.Drawing.Size(624, 346);
            this.povrsineTab.TabIndex = 1;
            this.povrsineTab.Text = "Povrsine";
            this.povrsineTab.UseVisualStyleBackColor = true;
            // 
            // izborNamjenePovrsina
            // 
            this.izborNamjenePovrsina.DataSource = this.namjenapovrsineBindingSource;
            this.izborNamjenePovrsina.DisplayMember = "namjena";
            this.izborNamjenePovrsina.FormattingEnabled = true;
            this.izborNamjenePovrsina.Location = new System.Drawing.Point(35, 27);
            this.izborNamjenePovrsina.Margin = new System.Windows.Forms.Padding(4);
            this.izborNamjenePovrsina.Name = "izborNamjenePovrsina";
            this.izborNamjenePovrsina.Size = new System.Drawing.Size(160, 24);
            this.izborNamjenePovrsina.TabIndex = 9;
            this.izborNamjenePovrsina.ValueMember = "id";
            this.izborNamjenePovrsina.SelectedIndexChanged += new System.EventHandler(this.izborNamjenePovrsina_SelectedIndexChanged);
            // 
            // namjenapovrsineBindingSource
            // 
            this.namjenapovrsineBindingSource.DataSource = typeof(PoljoAppVerzija2.namjena_povrsine);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sortiraj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // uiActionIzbrisi
            // 
            this.uiActionIzbrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionIzbrisi.Location = new System.Drawing.Point(204, 294);
            this.uiActionIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionIzbrisi.Name = "uiActionIzbrisi";
            this.uiActionIzbrisi.Size = new System.Drawing.Size(136, 42);
            this.uiActionIzbrisi.TabIndex = 7;
            this.uiActionIzbrisi.Text = "Izbriši";
            this.uiActionIzbrisi.UseVisualStyleBackColor = true;
            this.uiActionIzbrisi.Click += new System.EventHandler(this.uiActionIzbrisi_Click_1);
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionAzuriraj.Location = new System.Drawing.Point(33, 294);
            this.uiActionAzuriraj.Margin = new System.Windows.Forms.Padding(4);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.povrsinam2DataGridViewTextBoxColumn,
            this.idnamjeneDataGridViewTextBoxColumn,
            this.namjenapovrsineDataGridViewTextBoxColumn,
            this.navodnjavanjeDataGridViewTextBoxColumn,
            this.prskanjeDataGridViewTextBoxColumn,
            this.sadnjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poljpovrsinaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(557, 220);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // povrsinam2DataGridViewTextBoxColumn
            // 
            this.povrsinam2DataGridViewTextBoxColumn.DataPropertyName = "povrsina_m2";
            this.povrsinam2DataGridViewTextBoxColumn.HeaderText = "povrsina_m2";
            this.povrsinam2DataGridViewTextBoxColumn.Name = "povrsinam2DataGridViewTextBoxColumn";
            this.povrsinam2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idnamjeneDataGridViewTextBoxColumn
            // 
            this.idnamjeneDataGridViewTextBoxColumn.DataPropertyName = "id_namjene";
            this.idnamjeneDataGridViewTextBoxColumn.HeaderText = "id_namjene";
            this.idnamjeneDataGridViewTextBoxColumn.Name = "idnamjeneDataGridViewTextBoxColumn";
            this.idnamjeneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namjenapovrsineDataGridViewTextBoxColumn
            // 
            this.namjenapovrsineDataGridViewTextBoxColumn.DataPropertyName = "namjena_povrsine";
            this.namjenapovrsineDataGridViewTextBoxColumn.HeaderText = "namjena_povrsine";
            this.namjenapovrsineDataGridViewTextBoxColumn.Name = "namjenapovrsineDataGridViewTextBoxColumn";
            this.namjenapovrsineDataGridViewTextBoxColumn.ReadOnly = true;
            this.namjenapovrsineDataGridViewTextBoxColumn.Visible = false;
            // 
            // navodnjavanjeDataGridViewTextBoxColumn
            // 
            this.navodnjavanjeDataGridViewTextBoxColumn.DataPropertyName = "navodnjavanje";
            this.navodnjavanjeDataGridViewTextBoxColumn.HeaderText = "navodnjavanje";
            this.navodnjavanjeDataGridViewTextBoxColumn.Name = "navodnjavanjeDataGridViewTextBoxColumn";
            this.navodnjavanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.navodnjavanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // prskanjeDataGridViewTextBoxColumn
            // 
            this.prskanjeDataGridViewTextBoxColumn.DataPropertyName = "prskanje";
            this.prskanjeDataGridViewTextBoxColumn.HeaderText = "prskanje";
            this.prskanjeDataGridViewTextBoxColumn.Name = "prskanjeDataGridViewTextBoxColumn";
            this.prskanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prskanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sadnjaDataGridViewTextBoxColumn
            // 
            this.sadnjaDataGridViewTextBoxColumn.DataPropertyName = "sadnja";
            this.sadnjaDataGridViewTextBoxColumn.HeaderText = "sadnja";
            this.sadnjaDataGridViewTextBoxColumn.Name = "sadnjaDataGridViewTextBoxColumn";
            this.sadnjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sadnjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // poljpovrsinaBindingSource
            // 
            this.poljpovrsinaBindingSource.DataSource = typeof(PoljoAppVerzija2.polj_povrsina);
            // 
            // uiActionDodajPovrsinu
            // 
            this.uiActionDodajPovrsinu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajPovrsinu.Location = new System.Drawing.Point(455, 294);
            this.uiActionDodajPovrsinu.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionDodajPovrsinu.Name = "uiActionDodajPovrsinu";
            this.uiActionDodajPovrsinu.Size = new System.Drawing.Size(136, 42);
            this.uiActionDodajPovrsinu.TabIndex = 4;
            this.uiActionDodajPovrsinu.Text = "Dodaj površinu";
            this.uiActionDodajPovrsinu.UseVisualStyleBackColor = true;
            this.uiActionDodajPovrsinu.Click += new System.EventHandler(this.uiDodajPovrsinu_Click);
            // 
            // pomocTab
            // 
            this.pomocTab.Controls.Add(this.label1);
            this.pomocTab.Location = new System.Drawing.Point(4, 25);
            this.pomocTab.Margin = new System.Windows.Forms.Padding(4);
            this.pomocTab.Name = "pomocTab";
            this.pomocTab.Padding = new System.Windows.Forms.Padding(4);
            this.pomocTab.Size = new System.Drawing.Size(624, 346);
            this.pomocTab.TabIndex = 0;
            this.pomocTab.Text = "Pomoć";
            this.pomocTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomoć korisniku";
            // 
            // KontrolaPovrsine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KontrolaPovrsine";
            this.Size = new System.Drawing.Size(680, 418);
            this.Load += new System.EventHandler(this.KontrolaPovrsine_Load);
            this.tabControl1.ResumeLayout(false);
            this.povrsineTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.namjenapovrsineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage povrsineTab;
        private System.Windows.Forms.Button uiActionIzbrisi;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uiActionDodajPovrsinu;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox izborNamjenePovrsina;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource namjenapovrsineBindingSource;
        private System.Windows.Forms.BindingSource poljpovrsinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnamjeneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namjenapovrsineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn navodnjavanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prskanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadnjaDataGridViewTextBoxColumn;
    }
}
