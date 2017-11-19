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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=hahaha; Database=Koperasi;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            string namalogin = TBUsername.Text;
            string password = TBPassword.Text;
            NpgsqlCommand cmd = new NpgsqlCommand("select nm_login,pass_login from pengguna where nm_login='" + TBUsername.Text + "'and pass_login='" + TBPassword.Text + "'", connection);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login berhasil.");
                MainForm mf = new MainForm();
                mf.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal. Silahkan cek kembali nama login dan password anda.");
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
