namespace PoljoAppVerzija2
{
    partial class KontrolaProizvodi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolaProizvodi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sadnjaTab = new System.Windows.Forms.TabPage();
            this.cmbIzborVrsteSadnogMaterijala = new System.Windows.Forms.ComboBox();
            this.uiIzbrisiProizvod = new System.Windows.Forms.Button();
            this.uiAzurirajProizvod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiDodajProizvod = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadniMaterijalViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstasadnogmaterijalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.sadnjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pomocTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sadniMaterijalViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasadnogmaterijalaBindingSource)).BeginInit();
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
            this.sadnjaTab.Controls.Add(this.cmbIzborVrsteSadnogMaterijala);
            this.sadnjaTab.Controls.Add(this.uiIzbrisiProizvod);
            this.sadnjaTab.Controls.Add(this.uiAzurirajProizvod);
            this.sadnjaTab.Controls.Add(this.dataGridView1);
            this.sadnjaTab.Controls.Add(this.uiDodajProizvod);
            this.sadnjaTab.Location = new System.Drawing.Point(4, 25);
            this.sadnjaTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sadnjaTab.Name = "sadnjaTab";
            this.sadnjaTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sadnjaTab.Size = new System.Drawing.Size(624, 346);
            this.sadnjaTab.TabIndex = 1;
            this.sadnjaTab.Text = "Proizvodi";
            this.sadnjaTab.UseVisualStyleBackColor = true;
            // 
            // cmbIzborVrsteSadnogMaterijala
            // 
            this.cmbIzborVrsteSadnogMaterijala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzborVrsteSadnogMaterijala.FormattingEnabled = true;
            this.cmbIzborVrsteSadnogMaterijala.Location = new System.Drawing.Point(35, 27);
            this.cmbIzborVrsteSadnogMaterijala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIzborVrsteSadnogMaterijala.Name = "cmbIzborVrsteSadnogMaterijala";
            this.cmbIzborVrsteSadnogMaterijala.Size = new System.Drawing.Size(160, 24);
            this.cmbIzborVrsteSadnogMaterijala.TabIndex = 9;
            this.cmbIzborVrsteSadnogMaterijala.SelectedIndexChanged += new System.EventHandler(this.cmbIzborVrsteSadnogMaterijala_SelectedIndexChanged);
            // 
            // uiIzbrisiProizvod
            // 
            this.uiIzbrisiProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiIzbrisiProizvod.Location = new System.Drawing.Point(204, 294);
            this.uiIzbrisiProizvod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiIzbrisiProizvod.Name = "uiIzbrisiProizvod";
            this.uiIzbrisiProizvod.Size = new System.Drawing.Size(136, 42);
            this.uiIzbrisiProizvod.TabIndex = 7;
            this.uiIzbrisiProizvod.Text = "Izbriši";
            this.uiIzbrisiProizvod.UseVisualStyleBackColor = true;
            this.uiIzbrisiProizvod.Click += new System.EventHandler(this.uiIzbrisiProizvod_Click);
            // 
            // uiAzurirajProizvod
            // 
            this.uiAzurirajProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiAzurirajProizvod.Location = new System.Drawing.Point(33, 294);
            this.uiAzurirajProizvod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiAzurirajProizvod.Name = "uiAzurirajProizvod";
            this.uiAzurirajProizvod.Size = new System.Drawing.Size(136, 42);
            this.uiAzurirajProizvod.TabIndex = 6;
            this.uiAzurirajProizvod.Text = "Ažuriraj";
            this.uiAzurirajProizvod.UseVisualStyleBackColor = true;
            this.uiAzurirajProizvod.Click += new System.EventHandler(this.uiAzurirajProizvod_Click);
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
            this.jedinicnamjeraDataGridViewTextBoxColumn,
            this.vrstaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sadniMaterijalViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(557, 220);
            this.dataGridView1.TabIndex = 5;
            // 
            // uiDodajProizvod
            // 
            this.uiDodajProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDodajProizvod.Location = new System.Drawing.Point(455, 294);
            this.uiDodajProizvod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiDodajProizvod.Name = "uiDodajProizvod";
            this.uiDodajProizvod.Size = new System.Drawing.Size(136, 42);
            this.uiDodajProizvod.TabIndex = 4;
            this.uiDodajProizvod.Text = "Dodaj proizvod";
            this.uiDodajProizvod.UseVisualStyleBackColor = true;
            this.uiDodajProizvod.Click += new System.EventHandler(this.UiDodajProizvod_Click);
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
            this.label4.Location = new System.Drawing.Point(28, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(539, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "4. Brisanje proizvoda\r\nKorisnik briše proizvod tako da klikne na željeni proizvod" +
    " u tablici i zatim klikne na \r\ngumb \"Izbriši\". Na skočnom prozoru potrebno je od" +
    "abrati \"Da\" za brisanje proizvoda.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 68);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Proizvoda";
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
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinična mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            this.vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            this.vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta proizvoda";
            this.vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            this.vrstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sadniMaterijalViewBindingSource
            // 
            this.sadniMaterijalViewBindingSource.DataSource = typeof(DataLayer.SadniMaterijalView);
            // 
            // vrstasadnogmaterijalaBindingSource
            // 
            this.vrstasadnogmaterijalaBindingSource.DataSource = typeof(DataLayer.VrstaSadnogMaterijala);
            // 
            // KontrolaProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KontrolaProizvodi";
            this.Size = new System.Drawing.Size(680, 418);
            this.Load += new System.EventHandler(this.KontrolaProizvodi_Load);
            this.tabControl1.ResumeLayout(false);
            this.sadnjaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sadniMaterijalViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasadnogmaterijalaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sadnjaTab;
        private System.Windows.Forms.ComboBox cmbIzborVrsteSadnogMaterijala;
        private System.Windows.Forms.Button uiIzbrisiProizvod;
        private System.Windows.Forms.Button uiAzurirajProizvod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uiDodajProizvod;
        private System.Windows.Forms.TabPage pomocTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vrstasadnogmaterijalaBindingSource;
        private System.Windows.Forms.BindingSource sadniMaterijalViewBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
    }
}
