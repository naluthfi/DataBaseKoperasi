namespace WindowsFormsApp1
{
    partial class FormDataBarang
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
            this.label1 = new System.Windows.Forms.Label();
            this.koperasiDataSet3 = new WindowsFormsApp1.KoperasiDataSet3();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new WindowsFormsApp1.KoperasiDataSet3TableAdapters.barangTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.koperasiDataSet4 = new WindowsFormsApp1.KoperasiDataSet4();
            this.barangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter1 = new WindowsFormsApp1.KoperasiDataSet4TableAdapters.barangTableAdapter();
            this.kdbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdjenisbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgbeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrgjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARI";
            // 
            // koperasiDataSet3
            // 
            this.koperasiDataSet3.DataSetName = "KoperasiDataSet3";
            this.koperasiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "barang";
            this.barangBindingSource.DataSource = this.koperasiDataSet3;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdbarangDataGridViewTextBoxColumn,
            this.kdjenisbarangDataGridViewTextBoxColumn,
            this.nmbarangDataGridViewTextBoxColumn,
            this.hrgbeliDataGridViewTextBoxColumn,
            this.hrgjualDataGridViewTextBoxColumn,
            this.stockbarangDataGridViewTextBoxColumn,
            this.keteranganbarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // koperasiDataSet4
            // 
            this.koperasiDataSet4.DataSetName = "KoperasiDataSet4";
            this.koperasiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource1
            // 
            this.barangBindingSource1.DataMember = "barang";
            this.barangBindingSource1.DataSource = this.koperasiDataSet4;
            // 
            // barangTableAdapter1
            // 
            this.barangTableAdapter1.ClearBeforeFill = true;
            // 
            // kdbarangDataGridViewTextBoxColumn
            // 
            this.kdbarangDataGridViewTextBoxColumn.DataPropertyName = "kd_barang";
            this.kdbarangDataGridViewTextBoxColumn.HeaderText = "kd_barang";
            this.kdbarangDataGridViewTextBoxColumn.Name = "kdbarangDataGridViewTextBoxColumn";
            // 
            // kdjenisbarangDataGridViewTextBoxColumn
            // 
            this.kdjenisbarangDataGridViewTextBoxColumn.DataPropertyName = "kd_jenis_barang";
            this.kdjenisbarangDataGridViewTextBoxColumn.HeaderText = "kd_jenis_barang";
            this.kdjenisbarangDataGridViewTextBoxColumn.Name = "kdjenisbarangDataGridViewTextBoxColumn";
            // 
            // nmbarangDataGridViewTextBoxColumn
            // 
            this.nmbarangDataGridViewTextBoxColumn.DataPropertyName = "nm_barang";
            this.nmbarangDataGridViewTextBoxColumn.HeaderText = "nm_barang";
            this.nmbarangDataGridViewTextBoxColumn.Name = "nmbarangDataGridViewTextBoxColumn";
            // 
            // hrgbeliDataGridViewTextBoxColumn
            // 
            this.hrgbeliDataGridViewTextBoxColumn.DataPropertyName = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.HeaderText = "hrg_beli";
            this.hrgbeliDataGridViewTextBoxColumn.Name = "hrgbeliDataGridViewTextBoxColumn";
            // 
            // hrgjualDataGridViewTextBoxColumn
            // 
            this.hrgjualDataGridViewTextBoxColumn.DataPropertyName = "hrg_jual";
            this.hrgjualDataGridViewTextBoxColumn.HeaderText = "hrg_jual";
            this.hrgjualDataGridViewTextBoxColumn.Name = "hrgjualDataGridViewTextBoxColumn";
            // 
            // stockbarangDataGridViewTextBoxColumn
            // 
            this.stockbarangDataGridViewTextBoxColumn.DataPropertyName = "stock_barang";
            this.stockbarangDataGridViewTextBoxColumn.HeaderText = "stock_barang";
            this.stockbarangDataGridViewTextBoxColumn.Name = "stockbarangDataGridViewTextBoxColumn";
            // 
            // keteranganbarangDataGridViewTextBoxColumn
            // 
            this.keteranganbarangDataGridViewTextBoxColumn.DataPropertyName = "keterangan_barang";
            this.keteranganbarangDataGridViewTextBoxColumn.HeaderText = "keterangan_barang";
            this.keteranganbarangDataGridViewTextBoxColumn.Name = "keteranganbarangDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Harga Beli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Harga Jual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jenis Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Keterangan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(474, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(474, 227);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(474, 254);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(303, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(683, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Tutup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormDataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 351);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormDataBarang";
            this.Text = "FormDataBarang";
            this.Load += new System.EventHandler(this.FormDataBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private KoperasiDataSet3 koperasiDataSet3;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private KoperasiDataSet3TableAdapters.barangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KoperasiDataSet4 koperasiDataSet4;
        private System.Windows.Forms.BindingSource barangBindingSource1;
        private KoperasiDataSet4TableAdapters.barangTableAdapter barangTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdjenisbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgbeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}