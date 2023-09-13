using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounselingCenter
{
    public partial class hashtbehesht : Form
    {
        public hashtbehesht()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void hashtbehesht_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            visit visit = new visit();
            visit.ShowDialog();
        }

        private void پروندهtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            patient patient = new patient();
            patient.ShowDialog();
        }

        private void دکترtoolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DAC DAC = new DAC();
            DAC.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
