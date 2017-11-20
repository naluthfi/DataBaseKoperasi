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
    public partial class FormDataBarang : Form
    {
        public FormDataBarang()
        {
            InitializeComponent();
        }

        private void FormDataBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'koperasiDataSet4.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter1.Fill(this.koperasiDataSet4.barang);
            // TODO: This line of code loads data into the 'koperasiDataSet3.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.koperasiDataSet3.barang);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdministrasi fa = new FormAdministrasi();
            fa.Show();
        }
    }
}
