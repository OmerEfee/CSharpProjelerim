namespace otomasyondeneme2b
{
    partial class OgretmenBilgileri
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
            this.ogrtmnBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtmnTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtmnTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtmnMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogretmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1otomasyonDataSet = new otomasyondeneme2b.deneme1otomasyonDataSet();
            this.ogretmenTableAdapter = new otomasyondeneme2b.deneme1otomasyonDataSetTableAdapters.OgretmenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1otomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adSoyadDataGridViewTextBoxColumn,
            this.ogrtmnBransDataGridViewTextBoxColumn,
            this.ogrtmnTcNoDataGridViewTextBoxColumn,
            this.ogrtmnTelNoDataGridViewTextBoxColumn,
            this.ogrtmnMaasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogretmenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtmnBransDataGridViewTextBoxColumn
            // 
            this.ogrtmnBransDataGridViewTextBoxColumn.DataPropertyName = "ogrtmnBrans";
            this.ogrtmnBransDataGridViewTextBoxColumn.HeaderText = "ogrtmnBrans";
            this.ogrtmnBransDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtmnBransDataGridViewTextBoxColumn.Name = "ogrtmnBransDataGridViewTextBoxColumn";
            this.ogrtmnBransDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtmnTcNoDataGridViewTextBoxColumn
            // 
            this.ogrtmnTcNoDataGridViewTextBoxColumn.DataPropertyName = "ogrtmnTcNo";
            this.ogrtmnTcNoDataGridViewTextBoxColumn.HeaderText = "ogrtmnTcNo";
            this.ogrtmnTcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtmnTcNoDataGridViewTextBoxColumn.Name = "ogrtmnTcNoDataGridViewTextBoxColumn";
            this.ogrtmnTcNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtmnTelNoDataGridViewTextBoxColumn
            // 
            this.ogrtmnTelNoDataGridViewTextBoxColumn.DataPropertyName = "ogrtmnTelNo";
            this.ogrtmnTelNoDataGridViewTextBoxColumn.HeaderText = "ogrtmnTelNo";
            this.ogrtmnTelNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtmnTelNoDataGridViewTextBoxColumn.Name = "ogrtmnTelNoDataGridViewTextBoxColumn";
            this.ogrtmnTelNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtmnMaasDataGridViewTextBoxColumn
            // 
            this.ogrtmnMaasDataGridViewTextBoxColumn.DataPropertyName = "ogrtmnMaas";
            this.ogrtmnMaasDataGridViewTextBoxColumn.HeaderText = "ogrtmnMaas";
            this.ogrtmnMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtmnMaasDataGridViewTextBoxColumn.Name = "ogrtmnMaasDataGridViewTextBoxColumn";
            this.ogrtmnMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogretmenBindingSource
            // 
            this.ogretmenBindingSource.DataMember = "Ogretmen";
            this.ogretmenBindingSource.DataSource = this.deneme1otomasyonDataSet;
            // 
            // deneme1otomasyonDataSet
            // 
            this.deneme1otomasyonDataSet.DataSetName = "deneme1otomasyonDataSet";
            this.deneme1otomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogretmenTableAdapter
            // 
            this.ogretmenTableAdapter.ClearBeforeFill = true;
            // 
            // OgretmenBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgretmenBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgretmenBilgileri";
            this.Load += new System.EventHandler(this.OgretmenBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogretmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1otomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private deneme1otomasyonDataSet deneme1otomasyonDataSet;
        private System.Windows.Forms.BindingSource ogretmenBindingSource;
        private deneme1otomasyonDataSetTableAdapters.OgretmenTableAdapter ogretmenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtmnBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtmnTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtmnTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtmnMaasDataGridViewTextBoxColumn;
    }
}