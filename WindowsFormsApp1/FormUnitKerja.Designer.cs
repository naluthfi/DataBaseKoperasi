﻿namespace WindowsFormsApp1
{
    partial class FormUnitKerja
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kdunitkerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitkerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitkerjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.koperasiDataSet1 = new WindowsFormsApp1.KoperasiDataSet1();
            this.unit_kerjaTableAdapter = new WindowsFormsApp1.KoperasiDataSet1TableAdapters.unit_kerjaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitkerjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Unit Kerja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Kerja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdunitkerjaDataGridViewTextBoxColumn,
            this.unitkerjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.unitkerjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 126);
            this.dataGridView1.TabIndex = 4;
            // 
            // kdunitkerjaDataGridViewTextBoxColumn
            // 
            this.kdunitkerjaDataGridViewTextBoxColumn.DataPropertyName = "kd_unit_kerja";
            this.kdunitkerjaDataGridViewTextBoxColumn.HeaderText = "kd_unit_kerja";
            this.kdunitkerjaDataGridViewTextBoxColumn.Name = "kdunitkerjaDataGridViewTextBoxColumn";
            this.kdunitkerjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitkerjaDataGridViewTextBoxColumn
            // 
            this.unitkerjaDataGridViewTextBoxColumn.DataPropertyName = "unit_kerja";
            this.unitkerjaDataGridViewTextBoxColumn.HeaderText = "unit_kerja";
            this.unitkerjaDataGridViewTextBoxColumn.Name = "unitkerjaDataGridViewTextBoxColumn";
            this.unitkerjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitkerjaBindingSource
            // 
            this.unitkerjaBindingSource.DataMember = "unit_kerja";
            this.unitkerjaBindingSource.DataSource = this.koperasiDataSet1;
            // 
            // koperasiDataSet1
            // 
            this.koperasiDataSet1.DataSetName = "KoperasiDataSet1";
            this.koperasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unit_kerjaTableAdapter
            // 
            this.unit_kerjaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Tutup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormUnitKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 275);
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
            this.Name = "FormUnitKerja";
            this.Text = "Form Unit Kerja";
            this.Load += new System.EventHandler(this.FormUnitKerja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitkerjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koperasiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KoperasiDataSet1 koperasiDataSet1;
        private System.Windows.Forms.BindingSource unitkerjaBindingSource;
        private KoperasiDataSet1TableAdapters.unit_kerjaTableAdapter unit_kerjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdunitkerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitkerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}