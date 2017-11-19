namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonAdministrasi = new System.Windows.Forms.Button();
            this.buttonTPUmum = new System.Windows.Forms.Button();
            this.buttonTPAnggota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(13, 13);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(75, 23);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonAdministrasi
            // 
            this.buttonAdministrasi.Location = new System.Drawing.Point(106, 13);
            this.buttonAdministrasi.Name = "buttonAdministrasi";
            this.buttonAdministrasi.Size = new System.Drawing.Size(75, 23);
            this.buttonAdministrasi.TabIndex = 1;
            this.buttonAdministrasi.Text = "Administrasi";
            this.buttonAdministrasi.UseVisualStyleBackColor = true;
            // 
            // buttonTPUmum
            // 
            this.buttonTPUmum.Location = new System.Drawing.Point(13, 52);
            this.buttonTPUmum.Name = "buttonTPUmum";
            this.buttonTPUmum.Size = new System.Drawing.Size(168, 23);
            this.buttonTPUmum.TabIndex = 2;
            this.buttonTPUmum.Text = "Transaksi Penjualan Umum";
            this.buttonTPUmum.UseVisualStyleBackColor = true;
            // 
            // buttonTPAnggota
            // 
            this.buttonTPAnggota.Location = new System.Drawing.Point(13, 91);
            this.buttonTPAnggota.Name = "buttonTPAnggota";
            this.buttonTPAnggota.Size = new System.Drawing.Size(168, 23);
            this.buttonTPAnggota.TabIndex = 3;
            this.buttonTPAnggota.Text = "Transaksi Penjualan Anggota";
            this.buttonTPAnggota.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 127);
            this.Controls.Add(this.buttonTPAnggota);
            this.Controls.Add(this.buttonTPUmum);
            this.Controls.Add(this.buttonAdministrasi);
            this.Controls.Add(this.buttonUser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonAdministrasi;
        private System.Windows.Forms.Button buttonTPUmum;
        private System.Windows.Forms.Button buttonTPAnggota;
    }
}