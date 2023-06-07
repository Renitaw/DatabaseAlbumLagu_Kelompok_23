namespace Exer3
{
    partial class Form3
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
            this.albumLaguDataSet = new Exer3.AlbumLaguDataSet();
            this.produserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produserTableAdapter = new Exer3.AlbumLaguDataSetTableAdapters.ProduserTableAdapter();
            this.iDProduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perusahaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTeleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumLaguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProduserDataGridViewTextBoxColumn,
            this.namaProduserDataGridViewTextBoxColumn,
            this.perusahaanDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTeleponDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produserBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(795, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // albumLaguDataSet
            // 
            this.albumLaguDataSet.DataSetName = "AlbumLaguDataSet";
            this.albumLaguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produserBindingSource
            // 
            this.produserBindingSource.DataMember = "Produser";
            this.produserBindingSource.DataSource = this.albumLaguDataSet;
            // 
            // produserTableAdapter
            // 
            this.produserTableAdapter.ClearBeforeFill = true;
            // 
            // iDProduserDataGridViewTextBoxColumn
            // 
            this.iDProduserDataGridViewTextBoxColumn.DataPropertyName = "ID_Produser";
            this.iDProduserDataGridViewTextBoxColumn.HeaderText = "ID_Produser";
            this.iDProduserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDProduserDataGridViewTextBoxColumn.Name = "iDProduserDataGridViewTextBoxColumn";
            this.iDProduserDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaProduserDataGridViewTextBoxColumn
            // 
            this.namaProduserDataGridViewTextBoxColumn.DataPropertyName = "Nama_Produser";
            this.namaProduserDataGridViewTextBoxColumn.HeaderText = "Nama_Produser";
            this.namaProduserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaProduserDataGridViewTextBoxColumn.Name = "namaProduserDataGridViewTextBoxColumn";
            this.namaProduserDataGridViewTextBoxColumn.Width = 150;
            // 
            // perusahaanDataGridViewTextBoxColumn
            // 
            this.perusahaanDataGridViewTextBoxColumn.DataPropertyName = "Perusahaan";
            this.perusahaanDataGridViewTextBoxColumn.HeaderText = "Perusahaan";
            this.perusahaanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perusahaanDataGridViewTextBoxColumn.Name = "perusahaanDataGridViewTextBoxColumn";
            this.perusahaanDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // noTeleponDataGridViewTextBoxColumn
            // 
            this.noTeleponDataGridViewTextBoxColumn.DataPropertyName = "No_Telepon";
            this.noTeleponDataGridViewTextBoxColumn.HeaderText = "No_Telepon";
            this.noTeleponDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noTeleponDataGridViewTextBoxColumn.Name = "noTeleponDataGridViewTextBoxColumn";
            this.noTeleponDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumLaguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AlbumLaguDataSet albumLaguDataSet;
        private System.Windows.Forms.BindingSource produserBindingSource;
        private AlbumLaguDataSetTableAdapters.ProduserTableAdapter produserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perusahaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTeleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}