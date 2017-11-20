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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            FormUser fu = new FormUser();
            fu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdministrasi fa = new FormAdministrasi();
            fa.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTPUmum ftpu = new FormTPUmum();
            ftpu.Close();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTPAnggota ftpa = new FormTPAnggota();
            ftpa.Show();
            this.Close();
        }
    }
}
