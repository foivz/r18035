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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolaPovrsine));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.povrsineTab = new System.Windows.Forms.TabPage();
            this.izborNamjenePovrsina = new System.Windows.Forms.ComboBox();
            this.uiActionIzbrisi = new System.Windows.Forms.Button();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.povrsinam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_koordinata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_koordinata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_namjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poljPovrsinaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodajPovrsinu = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.namjenapovrsineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poljpovrsinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.povrsineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljPovrsinaViewBindingSource)).BeginInit();
            this.pomocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namjenapovrsineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).BeginInit();
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
            this.povrsineTab.Text = "Površine";
            this.povrsineTab.UseVisualStyleBackColor = true;
            // 
            // izborNamjenePovrsina
            // 
            this.izborNamjenePovrsina.FormattingEnabled = true;
            this.izborNamjenePovrsina.Location = new System.Drawing.Point(35, 27);
            this.izborNamjenePovrsina.Margin = new System.Windows.Forms.Padding(4);
            this.izborNamjenePovrsina.Name = "izborNamjenePovrsina";
            this.izborNamjenePovrsina.Size = new System.Drawing.Size(160, 24);
            this.izborNamjenePovrsina.TabIndex = 9;
            this.izborNamjenePovrsina.SelectedIndexChanged += new System.EventHandler(this.izborNamjenePovrsina_SelectedIndexChanged);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.namjena,
            this.povrsinam2DataGridViewTextBoxColumn,
            this.x_koordinata,
            this.y_koordinata,
            this.id_namjena});
            this.dataGridView1.DataSource = this.poljPovrsinaViewBindingSource;
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
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namjena
            // 
            this.namjena.DataPropertyName = "namjena";
            this.namjena.HeaderText = "Namjena";
            this.namjena.Name = "namjena";
            this.namjena.ReadOnly = true;
            // 
            // povrsinam2DataGridViewTextBoxColumn
            // 
            this.povrsinam2DataGridViewTextBoxColumn.DataPropertyName = "povrsina_m2";
            this.povrsinam2DataGridViewTextBoxColumn.HeaderText = "Veličina površine (m^2)";
            this.povrsinam2DataGridViewTextBoxColumn.Name = "povrsinam2DataGridViewTextBoxColumn";
            this.povrsinam2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // x_koordinata
            // 
            this.x_koordinata.DataPropertyName = "x_koordinata";
            this.x_koordinata.HeaderText = "x koordinata";
            this.x_koordinata.Name = "x_koordinata";
            this.x_koordinata.ReadOnly = true;
            // 
            // y_koordinata
            // 
            this.y_koordinata.DataPropertyName = "y_koordinata";
            this.y_koordinata.HeaderText = "y koordinata";
            this.y_koordinata.Name = "y_koordinata";
            this.y_koordinata.ReadOnly = true;
            // 
            // id_namjena
            // 
            this.id_namjena.DataPropertyName = "id_namjena";
            this.id_namjena.HeaderText = "id_namjena";
            this.id_namjena.Name = "id_namjena";
            this.id_namjena.ReadOnly = true;
            this.id_namjena.Visible = false;
            // 
            // poljPovrsinaViewBindingSource
            // 
            this.poljPovrsinaViewBindingSource.DataSource = typeof(DataLayer.PoljPovrsinaView);
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
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 289);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // namjenapovrsineBindingSource
            // 
            this.namjenapovrsineBindingSource.DataSource = typeof(DataLayer.NamjenaPovrsine);
            // 
            // poljpovrsinaBindingSource
            // 
            this.poljpovrsinaBindingSource.DataSource = typeof(DataLayer.PoljPovrsina);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljPovrsinaViewBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namjenapovrsineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource namjenapovrsineBindingSource;
        private System.Windows.Forms.BindingSource poljpovrsinaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn navodnjavanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prskanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poljPovrsinaViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn povrsinam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_koordinata;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_koordinata;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_namjena;
    }
}
