namespace WindowsFormsApp1
{
    partial class FormJenisBarang
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
            this.kdjenisbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.koperasiDataSet2 = new WindowsFormsApp1.KoperasiDataSet2();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jenis_barangTableAdapter = new WindowsFormsApp1.KoperasiDataSet2TableAdapters.jenis_barangTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdjenisbarangDataGridViewTextBoxColumn,
            this.jenisbarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jenisbarangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 127);
            this.dataGridView1.TabIndex = 9;
            // 
            // kdjenisbarangDataGridViewTextBoxColumn
            // 
            this.kdjenisbarangDataGridViewTextBoxColumn.DataPropertyName = "kd_jenis_barang";
            this.kdjenisbarangDataGridViewTextBoxColumn.HeaderText = "kd_jenis_barang";
            this.kdjenisbarangDataGridViewTextBoxColumn.Name = "kdjenisbarangDataGridViewTextBoxColumn";
            this.kdjenisbarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenisbarangDataGridViewTextBoxColumn
            // 
            this.jenisbarangDataGridViewTextBoxColumn.DataPropertyName = "jenis_barang";
            this.jenisbarangDataGridViewTextBoxColumn.HeaderText = "jenis_barang";
            this.jenisbarangDataGridViewTextBoxColumn.Name = "jenisbarangDataGridViewTextBoxColumn";
            this.jenisbarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenisbarangBindingSource
            // 
            this.jenisbarangBindingSource.DataMember = "jenis_barang";
            this.jenisbarangBindingSource.DataSource = this.koperasiDataSet2;
            // 
            // koperasiDataSet2
            // 
            this.koperasiDataSet2.DataSetName = "KoperasiDataSet2";
            this.koperasiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jenis Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kode Jenis Barang";
            // 
            // jenis_barangTableAdapter
            // 
            this.jenis_barangTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Tutup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormJenisBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormJenisBarang";
            this.Text = "FormJenisBarang";
            this.Load += new System.EventHandler(this.FormJenisBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KoperasiDataSet2 koperasiDataSet2;
        private System.Windows.Forms.BindingSource jenisbarangBindingSource;
        private KoperasiDataSet2TableAdapters.jenis_barangTableAdapter jenis_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdjenisbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}