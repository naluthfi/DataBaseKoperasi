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
   
public partial class FormUbahPassword : Form
    {
        public FormUbahPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=hahaha; Database=Koperasi;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
                string username = textBox3.Text;
                string passwordlama = textBox1.Text;
                string passwordbaru = textBox2.Text;
            //                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.pengguna " + " SET (pass_login='" + textBox2.Text + "') " + " WHERE nm_login='" + textBox3.Text + "' AND pass_login='" + textBox1.Text + "'", connection);
            NpgsqlCommand cmd = new NpgsqlCommand("select nm_login,pass_login from pengguna where nm_login='" + textBox3.Text + "'and pass_login='" + textBox1.Text + "'", connection);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sedang memperbarui password...");
                NpgsqlCommand cmd2 = new NpgsqlCommand("UPDATE public.pengguna " + " SET (pass_login='" + textBox2.Text + "') " + " WHERE nm_login='" + textBox3.Text + "' AND pass_login='" + textBox1.Text + "'", connection);
                
            }
            else
            {
                MessageBox.Show("Ganti Gagal. Silahkan cek kembali nama login dan password anda.");
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUser fu = new FormUser();
            fu.Show();
            this.Close();
        }
    }
}
