namespace WindowsFormsApp1
{
    partial class FormPengguna
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.koperasiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.koperasiDataSet = new WindowsFormsApp1.KoperasiDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kdpenggunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmpenggunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penggunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPengguna = new WindowsFormsApp1.DataSetPengguna();
            this.penggunaTableAdapter = new WindowsFormsApp1.DataSetPenggunaTableAdapters.penggunaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPengguna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pengguna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pengguna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Level Pengguna";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(337, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(362, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Tutup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // koperasiDataSetBindingSource
            // 
            this.koperasiDataSetBindingSource.DataSource = this.koperasiDataSet;
            this.koperasiDataSetBindingSource.Position = 0;
            // 
            // koperasiDataSet
            // 
            this.koperasiDataSet.DataSetName = "KoperasiDataSet";
            this.koperasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdpenggunaDataGridViewTextBoxColumn,
            this.nmpenggunaDataGridViewTextBoxColumn,
            this.nmloginDataGridViewTextBoxColumn,
            this.passloginDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.penggunaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(418, 134);
            this.dataGridView1.TabIndex = 15;
            // 
            // kdpenggunaDataGridViewTextBoxColumn
            // 
            this.kdpenggunaDataGridViewTextBoxColumn.DataPropertyName = "kd_pengguna";
            this.kdpenggunaDataGridViewTextBoxColumn.HeaderText = "kd_pengguna";
            this.kdpenggunaDataGridViewTextBoxColumn.Name = "kdpenggunaDataGridViewTextBoxColumn";
            this.kdpenggunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmpenggunaDataGridViewTextBoxColumn
            // 
            this.nmpenggunaDataGridViewTextBoxColumn.DataPropertyName = "nm_pengguna";
            this.nmpenggunaDataGridViewTextBoxColumn.HeaderText = "nm_pengguna";
            this.nmpenggunaDataGridViewTextBoxColumn.Name = "nmpenggunaDataGridViewTextBoxColumn";
            this.nmpenggunaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nmloginDataGridViewTextBoxColumn
            // 
            this.nmloginDataGridViewTextBoxColumn.DataPropertyName = "nm_login";
            this.nmloginDataGridViewTextBoxColumn.HeaderText = "nm_login";
            this.nmloginDataGridViewTextBoxColumn.Name = "nmloginDataGridViewTextBoxColumn";
            this.nmloginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passloginDataGridViewTextBoxColumn
            // 
            this.passloginDataGridViewTextBoxColumn.DataPropertyName = "pass_login";
            this.passloginDataGridViewTextBoxColumn.HeaderText = "pass_login";
            this.passloginDataGridViewTextBoxColumn.Name = "passloginDataGridViewTextBoxColumn";
            this.passloginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penggunaBindingSource
            // 
            this.penggunaBindingSource.DataMember = "pengguna";
            this.penggunaBindingSource.DataSource = this.dataSetPengguna;
            // 
            // dataSetPengguna
            // 
            this.dataSetPengguna.DataSetName = "DataSetPengguna";
            this.dataSetPengguna.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penggunaTableAdapter
            // 
            this.penggunaTableAdapter.ClearBeforeFill = true;
            // 
            // FormPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 325);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPengguna";
            this.Text = "FormPengguna";
            this.Load += new System.EventHandler(this.FormPengguna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPengguna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource koperasiDataSetBindingSource;
        private KoperasiDataSet koperasiDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPengguna dataSetPengguna;
        private System.Windows.Forms.BindingSource penggunaBindingSource;
        private DataSetPenggunaTableAdapters.penggunaTableAdapter penggunaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdpenggunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmpenggunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
    }
}