using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdministrasi : Form
    {
        public FormAdministrasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDataAnggota fda = new FormDataAnggota();
            fda.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUnitKerja fuk = new FormUnitKerja();
            fuk.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDataBarang fdb = new FormDataBarang();
            fdb.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormJenisBarang fjb = new FormJenisBarang();
            fjb.Show();
            this.Close();
        }
    }
}
