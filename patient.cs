using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CounselingCenter;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CounselingCenter
{
    public partial class patient : Form 
    {
        public string SelectedPID { get; set; }
        public patient()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();

            GetData();


        }
        public void GetData()
        {
           string queryString;
            string connectionString;

            queryString = @"Select * From [tableP] ";
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
                    dataGridView1.Columns[1].HeaderText = "parvandenum";
                    dataGridView1.Columns[2].HeaderText = "name";
                    dataGridView1.Columns[3].HeaderText = "phone";
                    dataGridView1.Columns[4].HeaderText = "day";
                    dataGridView1.Columns[5].HeaderText = "month";
                    dataGridView1.Columns[6].HeaderText = "year";
                    dataGridView1.Columns[7].HeaderText = "darmangar";
                }
            }
            catch (Exception ex)
            {
                // Handle database connection or query errors.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Display selected data in TextBox controls.
                textBox1.Text = selectedRow.Cells[1].Value?.ToString();
                textBox2.Text = selectedRow.Cells[2].Value?.ToString();
                textBox3.Text = selectedRow.Cells[3].Value?.ToString();
                textBox4.Text = selectedRow.Cells[4].Value?.ToString();
                textBox5.Text = selectedRow.Cells[5].Value?.ToString();
                textBox6.Text = selectedRow.Cells[6].Value?.ToString();
                textBox7.Text = selectedRow.Cells[7].Value?.ToString();
                /*textBox1.Text = selectedRow.Cells["parvandenum"].Value?.ToString();
                textBox2.Text = selectedRow.Cells["name"].Value?.ToString();
                textBox3.Text = selectedRow.Cells["phone"].Value?.ToString();
                textBox4.Text = selectedRow.Cells["day"].Value?.ToString();
                textBox5.Text = selectedRow.Cells["month"].Value?.ToString();
                textBox6.Text = selectedRow.Cells["year"].Value?.ToString();
                textBox7.Text = selectedRow.Cells["darmangar"].Value?.ToString();*/
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'counselingcenterDataSet.tableP' table. You can move, or remove it, as needed.
            this.tablePTableAdapter.Fill(this.counselingcenterDataSet.tableP);
            GetData();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // queryString = @"Select ID,parvandenum,name,phone,day,month,year,darmangar From [tableP] ";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb;";

            //string connectionStr = @"Driver={Microsoft Access Driver (*.mdb)};DBQ=Hospital.mdb";
            string query = string.Format(
                @"UPDATE Patient SET name = '{0}', NID ='{1}', [Birthdate] = '{2}', phone = '{3}' WHERE id = {4}",
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, dataGridView1.CurrentRow.Cells[0].Value.ToString());

            OleDbCommand command = new OleDbCommand(query);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("اطلاعات بیمار ویرایش شد.");
                    GetData();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error inserting database." + E.Message);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("آیا می خواهید حذف شود؟", "حذف بیمار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                // queryString = @"Select ID,parvandenum,name,phone,day,month,year,darmangar From [tableP] ";
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb;";


                string query = string.Format(
                    @"delete from patient where ID = {0} ", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                OleDbCommand command = new OleDbCommand(query);

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    command.Connection = connection;
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("بیمار از لیست حذف شد.");
                        GetData();
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show("Error inserting database.");

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // queryString = @"Select ID,parvandenum,name,phone,day,month,year,darmangar From [tableP] ";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb;";
            string query = string.Format(@"SELECT * FROM [Patient] WHERE parvandenum = '{0}' OR name = '{1}%'", textBox1.Text, textBox2.Text);

            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };


            try
            {
                OleDbCommand command = new OleDbCommand(query);
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    command.Connection = connection;
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the database.");
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "parvandenum";
            dataGridView1.Columns[2].HeaderText = "name";
            dataGridView1.Columns[3].HeaderText = "phone";
            dataGridView1.Columns[4].HeaderText = "day";
            dataGridView1.Columns[5].HeaderText = "month";
            dataGridView1.Columns[6].HeaderText = "year";
            dataGridView1.Columns[7].HeaderText = "darmangar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // queryString = @"Select ID,parvandenum,name,phone,day,month,year,darmangar From [tableP] ";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb;";

            string query = string.Format(
                @"insert into Patient (parvandenum,name,phone,day,month,year,darmangar) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}') ",
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

            OleDbCommand command = new OleDbCommand(query);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("نام بیمار جدید به لیست اضافه شد.");
                    GetData();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error inserting database." + E.Message);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
    }
}
