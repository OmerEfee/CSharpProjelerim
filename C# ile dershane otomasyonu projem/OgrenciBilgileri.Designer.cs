namespace otomasyondeneme2b
{
    partial class OgrenciBilgileri
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
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1otomasyonDataSet = new otomasyondeneme2b.deneme1otomasyonDataSet();
            this.ogrenciTableAdapter = new otomasyondeneme2b.deneme1otomasyonDataSetTableAdapters.OgrenciTableAdapter();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncSınıfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncSubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncBolumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrncCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1otomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.deneme1otomasyonDataSet;
            // 
            // deneme1otomasyonDataSet
            // 
            this.deneme1otomasyonDataSet.DataSetName = "deneme1otomasyonDataSet";
            this.deneme1otomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.deneme1otomasyonDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adSoyadDataGridViewTextBoxColumn,
            this.ogrncNoDataGridViewTextBoxColumn,
            this.ogrncSınıfDataGridViewTextBoxColumn,
            this.ogrncSubeDataGridViewTextBoxColumn,
            this.ogrncBolumuDataGridViewTextBoxColumn,
            this.ogrncTelNoDataGridViewTextBoxColumn,
            this.ogrncTcNoDataGridViewTextBoxColumn,
            this.ogrncCinsiyetDataGridViewTextBoxColumn,
            this.veliAdSoyadDataGridViewTextBoxColumn,
            this.veliTelNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 150);
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
            // ogrncNoDataGridViewTextBoxColumn
            // 
            this.ogrncNoDataGridViewTextBoxColumn.DataPropertyName = "ogrncNo";
            this.ogrncNoDataGridViewTextBoxColumn.HeaderText = "ogrncNo";
            this.ogrncNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncNoDataGridViewTextBoxColumn.Name = "ogrncNoDataGridViewTextBoxColumn";
            this.ogrncNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrncSınıfDataGridViewTextBoxColumn
            // 
            this.ogrncSınıfDataGridViewTextBoxColumn.DataPropertyName = "ogrncSınıf";
            this.ogrncSınıfDataGridViewTextBoxColumn.HeaderText = "ogrncSınıf";
            this.ogrncSınıfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncSınıfDataGridViewTextBoxColumn.Name = "ogrncSınıfDataGridViewTextBoxColumn";
            this.ogrncSınıfDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrncSubeDataGridViewTextBoxColumn
            // 
            this.ogrncSubeDataGridViewTextBoxColumn.DataPropertyName = "ogrncSube";
            this.ogrncSubeDataGridViewTextBoxColumn.HeaderText = "ogrncSube";
            this.ogrncSubeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncSubeDataGridViewTextBoxColumn.Name = "ogrncSubeDataGridViewTextBoxColumn";
            this.ogrncSubeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrncBolumuDataGridViewTextBoxColumn
            // 
            this.ogrncBolumuDataGridViewTextBoxColumn.DataPropertyName = "ogrncBolumu";
            this.ogrncBolumuDataGridViewTextBoxColumn.HeaderText = "ogrncBolumu";
            this.ogrncBolumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncBolumuDataGridViewTextBoxColumn.Name = "ogrncBolumuDataGridViewTextBoxColumn";
            this.ogrncBolumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrncTelNoDataGridViewTextBoxColumn
            // 
            this.ogrncTelNoDataGridViewTextBoxColumn.DataPropertyName = "ogrncTelNo";
            this.ogrncTelNoDataGridViewTextBoxColumn.HeaderText = "ogrncTelNo";
            this.ogrncTelNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncTelNoDataGridViewTextBoxColumn.Name = "ogrncTelNoDataGridViewTextBoxColumn";
            this.ogrncTelNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrncTcNoDataGridViewTextBoxColumn
            // 
            this.ogrncTcNoDataGridViewTextBoxColumn.DataPropertyName = "ogrncTcNo";
            this.ogrncTcNoDataGridViewTextBoxColumn.HeaderText = "ogrncTcNo";
            this.ogrncTcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncTcNoDataGridViewTextBoxColumn.Name = "ogrncTcNoDataGridViewTextBoxColumn";
            this.ogrncTcNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrncCinsiyetDataGridViewTextBoxColumn
            // 
            this.ogrncCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "ogrncCinsiyet";
            this.ogrncCinsiyetDataGridViewTextBoxColumn.HeaderText = "ogrncCinsiyet";
            this.ogrncCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrncCinsiyetDataGridViewTextBoxColumn.Name = "ogrncCinsiyetDataGridViewTextBoxColumn";
            this.ogrncCinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // veliAdSoyadDataGridViewTextBoxColumn
            // 
            this.veliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "veliAdSoyad";
            this.veliAdSoyadDataGridViewTextBoxColumn.HeaderText = "veliAdSoyad";
            this.veliAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliAdSoyadDataGridViewTextBoxColumn.Name = "veliAdSoyadDataGridViewTextBoxColumn";
            this.veliAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // veliTelNoDataGridViewTextBoxColumn
            // 
            this.veliTelNoDataGridViewTextBoxColumn.DataPropertyName = "veliTelNo";
            this.veliTelNoDataGridViewTextBoxColumn.HeaderText = "veliTelNo";
            this.veliTelNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.veliTelNoDataGridViewTextBoxColumn.Name = "veliTelNoDataGridViewTextBoxColumn";
            this.veliTelNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciBindingSource2
            // 
            this.ogrenciBindingSource2.DataMember = "Ogrenci";
            this.ogrenciBindingSource2.DataSource = this.deneme1otomasyonDataSet;
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1304, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciBilgileri";
            this.Load += new System.EventHandler(this.OgrenciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1otomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private deneme1otomasyonDataSet deneme1otomasyonDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private deneme1otomasyonDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncSınıfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncSubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncBolumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrncCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ogrenciBindingSource2;
    }
}