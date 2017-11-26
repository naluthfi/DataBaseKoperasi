namespace WindowsFormsApp1
{
    partial class FormDataAnggota
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
            this.kdanggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdunitkerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nppDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmanggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmplahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgljadianggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anggotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.koperasiDataSet5 = new WindowsFormsApp1.KoperasiDataSet5();
            this.anggotaTableAdapter = new WindowsFormsApp1.KoperasiDataSet5TableAdapters.anggotaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anggotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdanggotaDataGridViewTextBoxColumn,
            this.kdunitkerjaDataGridViewTextBoxColumn,
            this.nppDataGridViewTextBoxColumn,
            this.nmanggotaDataGridViewTextBoxColumn,
            this.tmplahirDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.tgljadianggotaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.anggotaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // kdanggotaDataGridViewTextBoxColumn
            // 
            this.kdanggotaDataGridViewTextBoxColumn.DataPropertyName = "kd_anggota";
            this.kdanggotaDataGridViewTextBoxColumn.HeaderText = "kd_anggota";
            this.kdanggotaDataGridViewTextBoxColumn.Name = "kdanggotaDataGridViewTextBoxColumn";
            this.kdanggotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdunitkerjaDataGridViewTextBoxColumn
            // 
            this.kdunitkerjaDataGridViewTextBoxColumn.DataPropertyName = "kd_unit_kerja";
            this.kdunitkerjaDataGridViewTextBoxColumn.HeaderText = "kd_unit_kerja";
            this.kdunitkerjaDataGridViewTextBoxColumn.Name = "kdunitkerjaDataGridViewTextBoxColumn";
            this.kdunitkerjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nppDataGridViewTextBoxColumn
            // 
            this.nppDataGridViewTextBoxColumn.DataPropertyName = "npp";
            this.nppDataGridViewTextBoxColumn.HeaderText = "npp";
            this.nppDataGridViewTextBoxColumn.Name = "nppDataGridViewTextBoxColumn";
            this.nppDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmanggotaDataGridViewTextBoxColumn
            // 
            this.nmanggotaDataGridViewTextBoxColumn.DataPropertyName = "nm_anggota";
            this.nmanggotaDataGridViewTextBoxColumn.HeaderText = "nm_anggota";
            this.nmanggotaDataGridViewTextBoxColumn.Name = "nmanggotaDataGridViewTextBoxColumn";
            this.nmanggotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tmplahirDataGridViewTextBoxColumn
            // 
            this.tmplahirDataGridViewTextBoxColumn.DataPropertyName = "tmp_lahir";
            this.tmplahirDataGridViewTextBoxColumn.HeaderText = "tmp_lahir";
            this.tmplahirDataGridViewTextBoxColumn.Name = "tmplahirDataGridViewTextBoxColumn";
            this.tmplahirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            this.tgllahirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tgljadianggotaDataGridViewTextBoxColumn
            // 
            this.tgljadianggotaDataGridViewTextBoxColumn.DataPropertyName = "tgl_jadi_anggota";
            this.tgljadianggotaDataGridViewTextBoxColumn.HeaderText = "tgl_jadi_anggota";
            this.tgljadianggotaDataGridViewTextBoxColumn.Name = "tgljadianggotaDataGridViewTextBoxColumn";
            this.tgljadianggotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anggotaBindingSource
            // 
            this.anggotaBindingSource.DataMember = "anggota";
            this.anggotaBindingSource.DataSource = this.koperasiDataSet5;
            // 
            // koperasiDataSet5
            // 
            this.koperasiDataSet5.DataSetName = "KoperasiDataSet5";
            this.koperasiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anggotaTableAdapter
            // 
            this.anggotaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kode Anggota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit Kerja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "NPP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nama Anggota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tempat Lahir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Alamat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Menjadi Anggota Mulai";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(480, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(480, 227);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(480, 255);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(480, 281);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(883, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Tutup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(16, 10);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(181, 20);
            this.textBox9.TabIndex = 23;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "CARI";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(858, 198);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tanggal Lahir";
            // 
            // FormDataAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 348);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataAnggota";
            this.Text = "Form Data Anggota";
            this.Load += new System.EventHandler(this.FormDataAnggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anggotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private KoperasiDataSet5 koperasiDataSet5;
        private System.Windows.Forms.BindingSource anggotaBindingSource;
        private KoperasiDataSet5TableAdapters.anggotaTableAdapter anggotaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdanggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdunitkerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nppDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmanggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmplahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgljadianggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label1;
    }
}