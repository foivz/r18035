namespace PoljoAppVerzija2
{
    partial class KontrolaSadnja
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
            this.izborSadnogMaterijala = new System.Windows.Forms.ComboBox();
            this.sadnimaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izborPoljPovrsina = new System.Windows.Forms.ComboBox();
            this.poljpovrsinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionIzbrisiSadnju = new System.Windows.Forms.Button();
            this.uiActionAzurirajSadnju = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sadnjaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionDodajSadnju = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.datumsadnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivmaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpovrsinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.sadnjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sadnimaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sadnjaViewBindingSource)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(24, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 375);
            this.tabControl1.TabIndex = 8;
            // 
            // sadnjaTab
            // 
            this.sadnjaTab.Controls.Add(this.izborSadnogMaterijala);
            this.sadnjaTab.Controls.Add(this.izborPoljPovrsina);
            this.sadnjaTab.Controls.Add(this.uiActionIzbrisiSadnju);
            this.sadnjaTab.Controls.Add(this.uiActionAzurirajSadnju);
            this.sadnjaTab.Controls.Add(this.dataGridView1);
            this.sadnjaTab.Controls.Add(this.uiActionDodajSadnju);
            this.sadnjaTab.Location = new System.Drawing.Point(4, 25);
            this.sadnjaTab.Margin = new System.Windows.Forms.Padding(4);
            this.sadnjaTab.Name = "sadnjaTab";
            this.sadnjaTab.Padding = new System.Windows.Forms.Padding(4);
            this.sadnjaTab.Size = new System.Drawing.Size(624, 346);
            this.sadnjaTab.TabIndex = 1;
            this.sadnjaTab.Text = "Sadnja";
            this.sadnjaTab.UseVisualStyleBackColor = true;
            // 
            // izborSadnogMaterijala
            // 
            this.izborSadnogMaterijala.DataSource = this.sadnimaterijalBindingSource;
            this.izborSadnogMaterijala.DisplayMember = "naziv";
            this.izborSadnogMaterijala.FormattingEnabled = true;
            this.izborSadnogMaterijala.Location = new System.Drawing.Point(204, 27);
            this.izborSadnogMaterijala.Margin = new System.Windows.Forms.Padding(4);
            this.izborSadnogMaterijala.Name = "izborSadnogMaterijala";
            this.izborSadnogMaterijala.Size = new System.Drawing.Size(160, 24);
            this.izborSadnogMaterijala.TabIndex = 10;
            this.izborSadnogMaterijala.ValueMember = "id";
            this.izborSadnogMaterijala.SelectedIndexChanged += new System.EventHandler(this.izborSadnogMaterijala_SelectedIndexChanged);
            // 
            // sadnimaterijalBindingSource
            // 
            this.sadnimaterijalBindingSource.DataSource = typeof(DataLayer.SadniMaterijal);
            // 
            // izborPoljPovrsina
            // 
            this.izborPoljPovrsina.DataSource = this.poljpovrsinaBindingSource;
            this.izborPoljPovrsina.DisplayMember = "naziv";
            this.izborPoljPovrsina.FormattingEnabled = true;
            this.izborPoljPovrsina.Location = new System.Drawing.Point(35, 27);
            this.izborPoljPovrsina.Margin = new System.Windows.Forms.Padding(4);
            this.izborPoljPovrsina.Name = "izborPoljPovrsina";
            this.izborPoljPovrsina.Size = new System.Drawing.Size(160, 24);
            this.izborPoljPovrsina.TabIndex = 9;
            this.izborPoljPovrsina.ValueMember = "id";
            this.izborPoljPovrsina.SelectedIndexChanged += new System.EventHandler(this.izborPoljPovrsina_SelectedIndexChanged);
            // 
            // poljpovrsinaBindingSource
            // 
            this.poljpovrsinaBindingSource.DataSource = typeof(DataLayer.PoljPovrsina);
            // 
            // uiActionIzbrisiSadnju
            // 
            this.uiActionIzbrisiSadnju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionIzbrisiSadnju.Location = new System.Drawing.Point(204, 294);
            this.uiActionIzbrisiSadnju.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionIzbrisiSadnju.Name = "uiActionIzbrisiSadnju";
            this.uiActionIzbrisiSadnju.Size = new System.Drawing.Size(136, 42);
            this.uiActionIzbrisiSadnju.TabIndex = 7;
            this.uiActionIzbrisiSadnju.Text = "Izbriši";
            this.uiActionIzbrisiSadnju.UseVisualStyleBackColor = true;
            this.uiActionIzbrisiSadnju.Click += new System.EventHandler(this.uiActionIzbrisiSadnju_Click);
            // 
            // uiActionAzurirajSadnju
            // 
            this.uiActionAzurirajSadnju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiActionAzurirajSadnju.Location = new System.Drawing.Point(33, 294);
            this.uiActionAzurirajSadnju.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionAzurirajSadnju.Name = "uiActionAzurirajSadnju";
            this.uiActionAzurirajSadnju.Size = new System.Drawing.Size(136, 42);
            this.uiActionAzurirajSadnju.TabIndex = 6;
            this.uiActionAzurirajSadnju.Text = "Ažuriraj";
            this.uiActionAzurirajSadnju.UseVisualStyleBackColor = true;
            this.uiActionAzurirajSadnju.Click += new System.EventHandler(this.uiActionAzurirajSadnju_Click);
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
            this.datumsadnjeDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.nazivmaterijalDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn,
            this.idpovrsinaDataGridViewTextBoxColumn,
            this.idmaterijalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sadnjaViewBindingSource;
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
            // sadnjaViewBindingSource
            // 
            this.sadnjaViewBindingSource.DataSource = typeof(DataLayer.SadnjaView);
            // 
            // uiActionDodajSadnju
            // 
            this.uiActionDodajSadnju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionDodajSadnju.Location = new System.Drawing.Point(455, 294);
            this.uiActionDodajSadnju.Margin = new System.Windows.Forms.Padding(4);
            this.uiActionDodajSadnju.Name = "uiActionDodajSadnju";
            this.uiActionDodajSadnju.Size = new System.Drawing.Size(136, 42);
            this.uiActionDodajSadnju.TabIndex = 4;
            this.uiActionDodajSadnju.Text = "Dodaj sadnju";
            this.uiActionDodajSadnju.UseVisualStyleBackColor = true;
            this.uiActionDodajSadnju.Click += new System.EventHandler(this.UiDodajSadnju_Click);
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
            // datumsadnjeDataGridViewTextBoxColumn
            // 
            this.datumsadnjeDataGridViewTextBoxColumn.DataPropertyName = "datum_sadnje";
            this.datumsadnjeDataGridViewTextBoxColumn.HeaderText = "datum_sadnje";
            this.datumsadnjeDataGridViewTextBoxColumn.Name = "datumsadnjeDataGridViewTextBoxColumn";
            this.datumsadnjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivmaterijalDataGridViewTextBoxColumn
            // 
            this.nazivmaterijalDataGridViewTextBoxColumn.DataPropertyName = "naziv_materijal";
            this.nazivmaterijalDataGridViewTextBoxColumn.HeaderText = "naziv_materijal";
            this.nazivmaterijalDataGridViewTextBoxColumn.Name = "nazivmaterijalDataGridViewTextBoxColumn";
            this.nazivmaterijalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpovrsinaDataGridViewTextBoxColumn
            // 
            this.idpovrsinaDataGridViewTextBoxColumn.DataPropertyName = "id_povrsina";
            this.idpovrsinaDataGridViewTextBoxColumn.HeaderText = "id_povrsina";
            this.idpovrsinaDataGridViewTextBoxColumn.Name = "idpovrsinaDataGridViewTextBoxColumn";
            this.idpovrsinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpovrsinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idmaterijalDataGridViewTextBoxColumn
            // 
            this.idmaterijalDataGridViewTextBoxColumn.DataPropertyName = "id_materijal";
            this.idmaterijalDataGridViewTextBoxColumn.HeaderText = "id_materijal";
            this.idmaterijalDataGridViewTextBoxColumn.Name = "idmaterijalDataGridViewTextBoxColumn";
            this.idmaterijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmaterijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // KontrolaSadnja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KontrolaSadnja";
            this.Size = new System.Drawing.Size(680, 418);
            this.Load += new System.EventHandler(this.KontrolaSadnja_Load);
            this.tabControl1.ResumeLayout(false);
            this.sadnjaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sadnimaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poljpovrsinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sadnjaViewBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sadnjaTab;
        private System.Windows.Forms.ComboBox izborPoljPovrsina;
        private System.Windows.Forms.Button uiActionIzbrisiSadnju;
        private System.Windows.Forms.Button uiActionAzurirajSadnju;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uiActionDodajSadnju;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox izborSadnogMaterijala;
        private System.Windows.Forms.BindingSource sadnimaterijalBindingSource;
        private System.Windows.Forms.BindingSource poljpovrsinaBindingSource;
        private System.Windows.Forms.BindingSource sadnjaViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumsadnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivmaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpovrsinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmaterijalDataGridViewTextBoxColumn;
    }
}
