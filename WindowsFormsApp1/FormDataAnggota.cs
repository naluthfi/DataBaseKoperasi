using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class FormDataAnggota : Form
    {
        public FormDataAnggota()
        {
            InitializeComponent();
        }

        private void FormDataAnggota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'koperasiDataSet5.anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.koperasiDataSet5.anggota);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAdministrasi fa = new FormAdministrasi();
            fa.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=hahaha; Database=Koperasi;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into public.pengguna (kd_anggota, kd_unit_kerja, npp, nm_anggota, tmp_lahir, tgl_lahir, jenis_kelamin, alamat, tgl_jadi_anggota) values (" + textBox1.Text + " , " + textBox2.Text + " , " + textBox3.Text + " , " + textBox4.Text + " , " + textBox5.Text + " , " + textBox6.Text + ", " + textBox7.Text + " , " + textBox8.Text + ")", connection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=hahaha; Database=Koperasi;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.anggota " + " SET kd_unit_kerja='" + textBox2.Text + "' , npp='" + textBox3.Text + "' , nm_anggota='" + textBox4.Text + "' , tmp_lahir='" + textBox5.Text + "' , tgl_lahir='" + textBox10.Text + "' , jenis_kelamin='" + textBox6.Text + "' , alamat='" + textBox7.Text + "' , tgl_jadi_anggota='" + textBox8.Text + "' " + " WHERE kd_anggota='" + textBox1.Text + "'", connection);
            int success = cmd.ExecuteNonQuery();
            if (Convert.ToBoolean(success))
            {
                MessageBox.Show("Data anggota berhasil diperbarui");
            }
            else
            {
                MessageBox.Show("Penggantian data anggota gagal. Silahkan cek kode anggota kembali.");
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=hahaha; Database=Koperasi;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.anggota " + " WHERE kd_anggota='" + textBox1.Text + "'", connection);
            int success = cmd.ExecuteNonQuery();
            if (Convert.ToBoolean(success))
            {
                MessageBox.Show("Data anggota berhasil dihapus");
            }
            else
            {
                MessageBox.Show("Penghapusan data anggota gagal. Silahkan cek kode anggota kembali.");
            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=hahaha; Database=Koperasi;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.anggota (kd_anggota, kd_unit_kerja, npp, nm_anggota, tmp_lahir, tgl_lahir, jenis_kelamin, alamat, tgl_jadi_anggota) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox10.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')", connection);
            int success = cmd.ExecuteNonQuery();
            if (Convert.ToBoolean(success))
            {
                MessageBox.Show("Data anggota berhasil ditambah");
            }
            else
            {
                MessageBox.Show("Penambahan data anggota gagal. Silahkan cek kode anggota kembali.");
            }
            connection.Close();
        }
    }
}
