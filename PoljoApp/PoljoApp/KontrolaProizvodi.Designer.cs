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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sadnjaTab = new System.Windows.Forms.TabPage();
            this.cmbIzborVrsteSadnogMaterijala = new System.Windows.Forms.ComboBox();
            this.vrstasadnogmaterijalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiIzbrisiProizvod = new System.Windows.Forms.Button();
            this.uiAzurirajProizvod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvrstematerijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadnjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadnimaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiDodajProizvod = new System.Windows.Forms.Button();
            this.pomocTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.sadnjaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstasadnogmaterijalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sadnimaterijalBindingSource)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 305);
            this.tabControl1.TabIndex = 9;
            // 
            // sadnjaTab
            // 
            this.sadnjaTab.Controls.Add(this.cmbIzborVrsteSadnogMaterijala);
            this.sadnjaTab.Controls.Add(this.uiIzbrisiProizvod);
            this.sadnjaTab.Controls.Add(this.uiAzurirajProizvod);
            this.sadnjaTab.Controls.Add(this.dataGridView1);
            this.sadnjaTab.Controls.Add(this.uiDodajProizvod);
            this.sadnjaTab.Location = new System.Drawing.Point(4, 22);
            this.sadnjaTab.Name = "sadnjaTab";
            this.sadnjaTab.Padding = new System.Windows.Forms.Padding(3);
            this.sadnjaTab.Size = new System.Drawing.Size(466, 279);
            this.sadnjaTab.TabIndex = 1;
            this.sadnjaTab.Text = "Proizvodi";
            this.sadnjaTab.UseVisualStyleBackColor = true;
            // 
            // cmbIzborVrsteSadnogMaterijala
            // 
            this.cmbIzborVrsteSadnogMaterijala.FormattingEnabled = true;
            this.cmbIzborVrsteSadnogMaterijala.Location = new System.Drawing.Point(26, 22);
            this.cmbIzborVrsteSadnogMaterijala.Name = "cmbIzborVrsteSadnogMaterijala";
            this.cmbIzborVrsteSadnogMaterijala.Size = new System.Drawing.Size(121, 21);
            this.cmbIzborVrsteSadnogMaterijala.TabIndex = 9;
            this.cmbIzborVrsteSadnogMaterijala.SelectedIndexChanged += new System.EventHandler(this.cmbIzborVrsteSadnogMaterijala_SelectedIndexChanged);
            // 
            // vrstasadnogmaterijalaBindingSource
            // 
            this.vrstasadnogmaterijalaBindingSource.DataSource = typeof(DataLayer.VrstaSadnogMaterijala);
            // 
            // uiIzbrisiProizvod
            // 
            this.uiIzbrisiProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiIzbrisiProizvod.Location = new System.Drawing.Point(153, 239);
            this.uiIzbrisiProizvod.Name = "uiIzbrisiProizvod";
            this.uiIzbrisiProizvod.Size = new System.Drawing.Size(102, 34);
            this.uiIzbrisiProizvod.TabIndex = 7;
            this.uiIzbrisiProizvod.Text = "Izbriši";
            this.uiIzbrisiProizvod.UseVisualStyleBackColor = true;
            this.uiIzbrisiProizvod.Click += new System.EventHandler(this.uiIzbrisiProizvod_Click);
            // 
            // uiAzurirajProizvod
            // 
            this.uiAzurirajProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiAzurirajProizvod.Location = new System.Drawing.Point(25, 239);
            this.uiAzurirajProizvod.Name = "uiAzurirajProizvod";
            this.uiAzurirajProizvod.Size = new System.Drawing.Size(102, 34);
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
            this.idvrstematerijalaDataGridViewTextBoxColumn,
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn,
            this.sadnjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sadnimaterijalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(418, 179);
            this.dataGridView1.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Proizvoda";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // idvrstematerijalaDataGridViewTextBoxColumn
            // 
            this.idvrstematerijalaDataGridViewTextBoxColumn.DataPropertyName = "id_vrste_materijala";
            this.idvrstematerijalaDataGridViewTextBoxColumn.HeaderText = "ID Vrste materijala";
            this.idvrstematerijalaDataGridViewTextBoxColumn.Name = "idvrstematerijalaDataGridViewTextBoxColumn";
            this.idvrstematerijalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstasadnogmaterijalaDataGridViewTextBoxColumn
            // 
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn.DataPropertyName = "vrsta_sadnog_materijala";
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn.HeaderText = "vrsta_sadnog_materijala";
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn.Name = "vrstasadnogmaterijalaDataGridViewTextBoxColumn";
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrstasadnogmaterijalaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sadnjaDataGridViewTextBoxColumn
            // 
            this.sadnjaDataGridViewTextBoxColumn.DataPropertyName = "sadnja";
            this.sadnjaDataGridViewTextBoxColumn.HeaderText = "sadnja";
            this.sadnjaDataGridViewTextBoxColumn.Name = "sadnjaDataGridViewTextBoxColumn";
            this.sadnjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sadnjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sadnimaterijalBindingSource
            // 
            this.sadnimaterijalBindingSource.DataSource = typeof(DataLayer.SadniMaterijal);
            // 
            // uiDodajProizvod
            // 
            this.uiDodajProizvod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDodajProizvod.Location = new System.Drawing.Point(341, 239);
            this.uiDodajProizvod.Name = "uiDodajProizvod";
            this.uiDodajProizvod.Size = new System.Drawing.Size(102, 34);
            this.uiDodajProizvod.TabIndex = 4;
            this.uiDodajProizvod.Text = "Dodaj proizvod";
            this.uiDodajProizvod.UseVisualStyleBackColor = true;
            this.uiDodajProizvod.Click += new System.EventHandler(this.UiDodajProizvod_Click);
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
            // KontrolaProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "KontrolaProizvodi";
            this.Size = new System.Drawing.Size(510, 340);
            this.Load += new System.EventHandler(this.KontrolaProizvodi_Load);
            this.tabControl1.ResumeLayout(false);
            this.sadnjaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vrstasadnogmaterijalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sadnimaterijalBindingSource)).EndInit();
            this.pomocTab.ResumeLayout(false);
            this.pomocTab.PerformLayout();
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
        private System.Windows.Forms.BindingSource sadnimaterijalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvrstematerijalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstasadnogmaterijalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadnjaDataGridViewTextBoxColumn;
    }
}
