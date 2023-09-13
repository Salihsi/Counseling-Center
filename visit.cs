using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CounselingCenter;

namespace CounselingCenter
{
    public partial class visit : Form
    {
        public visit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*OdbcCommand command = new OdbcCommand(query);

            using (OdbcConnection connection = new OdbcConnection(connectionStr))
            {
                connection.Open();
                command.Connection = connection;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("مراجعه جدید به لیست اضافه شد.");
                    GetData();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error inserting database." + E.Message);

                }
            }*/
        }

        private void visit_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
