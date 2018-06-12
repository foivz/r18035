namespace PoljoAppVerzija2.Admin
{
    partial class DjelatniciForma
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pregledDjelatnika = new System.Windows.Forms.DataGridView();
            this.djelatnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.uiActionUnos = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prskanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pregledDjelatnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pregledDjelatnika
            // 
            this.pregledDjelatnika.AllowUserToAddRows = false;
            this.pregledDjelatnika.AllowUserToDeleteRows = false;
            this.pregledDjelatnika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pregledDjelatnika.AutoGenerateColumns = false;
            this.pregledDjelatnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledDjelatnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn,
            this.adminDataGridViewTextBoxColumn,
            this.prskanjeDataGridViewTextBoxColumn});
            this.pregledDjelatnika.DataSource = this.djelatnikBindingSource;
            this.pregledDjelatnika.Location = new System.Drawing.Point(12, 58);
            this.pregledDjelatnika.MultiSelect = false;
            this.pregledDjelatnika.Name = "pregledDjelatnika";
            this.pregledDjelatnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pregledDjelatnika.Size = new System.Drawing.Size(588, 265);
            this.pregledDjelatnika.TabIndex = 0;
            // 
            // djelatnikBindingSource
            // 
            this.djelatnikBindingSource.DataSource = typeof(PoljoAppVerzija2.djelatnik);
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Location = new System.Drawing.Point(12, 18);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(102, 34);
            this.uiActionAzuriraj.TabIndex = 9;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.UiActionAzuriraj_Click);
            // 
            // uiActionUnos
            // 
            this.uiActionUnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionUnos.Location = new System.Drawing.Point(498, 18);
            this.uiActionUnos.Name = "uiActionUnos";
            this.uiActionUnos.Size = new System.Drawing.Size(102, 34);
            this.uiActionUnos.TabIndex = 10;
            this.uiActionUnos.Text = "Unos djelatnika";
            this.uiActionUnos.UseVisualStyleBackColor = true;
            this.uiActionUnos.Click += new System.EventHandler(this.UiActionUnos_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "broj_telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewTextBoxColumn
            // 
            this.adminDataGridViewTextBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewTextBoxColumn.HeaderText = "admin";
            this.adminDataGridViewTextBoxColumn.Name = "adminDataGridViewTextBoxColumn";
            this.adminDataGridViewTextBoxColumn.Visible = false;
            // 
            // prskanjeDataGridViewTextBoxColumn
            // 
            this.prskanjeDataGridViewTextBoxColumn.DataPropertyName = "prskanje";
            this.prskanjeDataGridViewTextBoxColumn.HeaderText = "prskanje";
            this.prskanjeDataGridViewTextBoxColumn.Name = "prskanjeDataGridViewTextBoxColumn";
            this.prskanjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // DjelatniciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 335);
            this.Controls.Add(this.uiActionUnos);
            this.Controls.Add(this.uiActionAzuriraj);
            this.Controls.Add(this.pregledDjelatnika);
            this.Name = "DjelatniciForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Djelatnici";
            ((System.ComponentModel.ISupportInitialize)(this.pregledDjelatnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pregledDjelatnika;
        private System.Windows.Forms.Button uiActionAzuriraj;
        private System.Windows.Forms.Button uiActionUnos;
        private System.Windows.Forms.BindingSource djelatnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prskanjeDataGridViewTextBoxColumn;
    }
}