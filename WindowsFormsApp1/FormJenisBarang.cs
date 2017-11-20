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
    public partial class FormJenisBarang : Form
    {
        public FormJenisBarang()
        {
            InitializeComponent();
        }

        private void FormJenisBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'koperasiDataSet2.jenis_barang' table. You can move, or remove it, as needed.
            this.jenis_barangTableAdapter.Fill(this.koperasiDataSet2.jenis_barang);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAdministrasi fa = new FormAdministrasi();
            fa.Show();
            this.Close();
        }
    }
}
