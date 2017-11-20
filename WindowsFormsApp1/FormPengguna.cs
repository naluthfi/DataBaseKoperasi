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
    public partial class FormPengguna : Form
    {
        public FormPengguna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormPengguna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPengguna.pengguna' table. You can move, or remove it, as needed.
            this.penggunaTableAdapter.Fill(this.dataSetPengguna.pengguna);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.penggunaTableAdapter.FillBy(this.dataSetPengguna.pengguna);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.penggunaTableAdapter.FillBy1(this.dataSetPengguna.pengguna);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
