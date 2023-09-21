using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CounselingCenter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CounselingCenter
{
    public partial class DAC : Form
    {
        public DAC()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string queryString;
            string connectionString;
            queryString = @"Select * From [tableH1] ";
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb;";
            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open(); // Open the database connection.

                    // Create and configure the command and adapter.
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                    // Fill the DataTable with data from the database.
                    adapter.Fill(table);

                    // Set the DataGridView's DataSource after successfully fetching data.
                    dataGridView1.DataSource = table;

                    // Set column headers.
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "تاریخ";
                    dataGridView1.Columns[2].HeaderText = "عنوان خرید";
                    dataGridView1.Columns[3].HeaderText = "مبلغ خرید";
                    dataGridView1.Columns[4].HeaderText = "نام خریدار";
                    dataGridView1.Columns[5].HeaderText = "محل اعتبار";
                    dataGridView1.Columns[6].HeaderText = "نوع هزینه";


                }
            }
            catch (Exception ex)
            {
                // Handle database connection or query errors.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DAC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'counselingcenterDataSet9.tableH1' table. You can move, or remove it, as needed.
            this.tableH1TableAdapter.Fill(this.counselingcenterDataSet9.tableH1);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new row for the DataTable
            DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();

            newRow["تاریخ"] = maskedTextBox1.Text;
            newRow["عنوان خرید"] = textBox1.Text;
            newRow["مبلغ خرید"] = textBox2.Text;
            newRow["نام خریدار"] = textBox3.Text;
            newRow["محل اعتبار"] = textBox4.Text;
            newRow["نوع هزینه"] = textBox5.Text;

            // Save changes to the database.
            tableHTableAdapter.Update(counselingcenterDataSet8.tableH);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Display selected data in TextBox controls.
                maskedTextBox1.Text = selectedRow.Cells[1].Value?.ToString();
                textBox1.Text = selectedRow.Cells[2].Value?.ToString();
                textBox2.Text = selectedRow.Cells[3].Value?.ToString();
                textBox3.Text = selectedRow.Cells[4].Value?.ToString();
                textBox4.Text = selectedRow.Cells[5].Value?.ToString();
                textBox5.Text = selectedRow.Cells[6].Value?.ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user if they want to delete the selected row
            DialogResult result = MessageBox.Show("آیا می‌خواهید ردیف انتخاب شده را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the corresponding DataRow
                DataRow dataRow = ((DataRowView)selectedRow.DataBoundItem).Row;

                // Delete the DataRow from the DataTable
                dataRow.Delete();

                // Refresh the DataGridView to reflect the changes
                dataGridView1.Refresh();

                // Show a success message
                MessageBox.Show("ردیف انتخاب شده حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
