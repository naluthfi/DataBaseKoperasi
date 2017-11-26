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
    public partial class FormTPUmum : Form
    {
        public FormTPUmum()
        {
            InitializeComponent();
        }

        private void FormTPUmum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'koperasiDataSet6.barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.koperasiDataSet6.barang);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.barangTableAdapter.FillBy(this.koperasiDataSet6.barang);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
