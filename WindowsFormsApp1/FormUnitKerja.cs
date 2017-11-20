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
    public partial class FormUnitKerja : Form
    {
        public FormUnitKerja()
        {
            InitializeComponent();
        }

        private void FormUnitKerja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'koperasiDataSet1.unit_kerja' table. You can move, or remove it, as needed.
            this.unit_kerjaTableAdapter.Fill(this.koperasiDataSet1.unit_kerja);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAdministrasi fa = new FormAdministrasi();
            fa.Show();
            this.Close();
        }
    }
}
