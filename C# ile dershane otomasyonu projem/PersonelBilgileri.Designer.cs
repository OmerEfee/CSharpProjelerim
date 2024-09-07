namespace otomasyondeneme2b
{
    partial class PersonelBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelGoreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1otomasyonDataSet = new otomasyondeneme2b.deneme1otomasyonDataSet();
            this.personelTableAdapter = new otomasyondeneme2b.deneme1otomasyonDataSetTableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1otomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adSoyadDataGridViewTextBoxColumn,
            this.personelGoreviDataGridViewTextBoxColumn,
            this.personelTcNoDataGridViewTextBoxColumn,
            this.personelTelNoDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelGoreviDataGridViewTextBoxColumn
            // 
            this.personelGoreviDataGridViewTextBoxColumn.DataPropertyName = "personelGorevi";
            this.personelGoreviDataGridViewTextBoxColumn.HeaderText = "personelGorevi";
            this.personelGoreviDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelGoreviDataGridViewTextBoxColumn.Name = "personelGoreviDataGridViewTextBoxColumn";
            this.personelGoreviDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelTcNoDataGridViewTextBoxColumn
            // 
            this.personelTcNoDataGridViewTextBoxColumn.DataPropertyName = "personelTcNo";
            this.personelTcNoDataGridViewTextBoxColumn.HeaderText = "personelTcNo";
            this.personelTcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelTcNoDataGridViewTextBoxColumn.Name = "personelTcNoDataGridViewTextBoxColumn";
            this.personelTcNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelTelNoDataGridViewTextBoxColumn
            // 
            this.personelTelNoDataGridViewTextBoxColumn.DataPropertyName = "personelTelNo";
            this.personelTelNoDataGridViewTextBoxColumn.HeaderText = "personelTelNo";
            this.personelTelNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelTelNoDataGridViewTextBoxColumn.Name = "personelTelNoDataGridViewTextBoxColumn";
            this.personelTelNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "personelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "personelMaas";
            this.personelMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            this.personelMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.deneme1otomasyonDataSet;
            // 
            // deneme1otomasyonDataSet
            // 
            this.deneme1otomasyonDataSet.DataSetName = "deneme1otomasyonDataSet";
            this.deneme1otomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelBilgileri";
            this.Load += new System.EventHandler(this.PersonelBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1otomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private deneme1otomasyonDataSet deneme1otomasyonDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private deneme1otomasyonDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelGoreviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
    }
}