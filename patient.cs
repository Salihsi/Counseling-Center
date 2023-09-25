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

        
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";
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
            // TODO: This line of code loads data into the 'counselingcenterDataSet4.tableP' table. You can move, or remove it, as needed.
            this.tablePTableAdapter1.Fill(this.counselingcenterDataSet4.tableP);
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
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";

            string query = string.Format(
                @"UPDATE tableP SET parvandenum = '{0}', name ='{1}', phone = '{2}', [day] = '{3}', [month] = '{4}', [year] = '{5}', darmangar = '{6}' WHERE ID = {7}",
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

            // Save changes to the database.
            tablePTableAdapter.Update(counselingcenterDataSet.tableP);

    

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("آیا می خواهید حذف شود؟", "حذف بیمار", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                // queryString = @"Select ID,parvandenum,name,phone,day,month,year,darmangar From [tableP] ";
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";
                //C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb


                string query = string.Format(
                    @"delete from tableP where ID = {0} ", dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            // Save changes to the database.
            tablePTableAdapter.Update(counselingcenterDataSet.tableP);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // queryString = @"Select ID,parvandenum,name,phone,day,month,year,darmangar From [tableP] ";
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";
            string query = string.Format(@"SELECT * FROM [tableP] WHERE parvandenum = '{0}' OR name LIKE '%{1}%' OR phone = '{2}' OR day = '{3}' OR month = '{4}' OR year = '{5}' OR darmangar = '{6}'", textBox1.Text, textBox2.Text,textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            //string query = string.Format(@"SELECT * FROM [tableP] WHERE parvandenum LIKE '%{0}%' OR name LIKE '%{1}%' OR phone LIKE '%{2}%' OR day LIKE '%{3}%' OR month LIKE '%{4}%' OR year LIKE '%{5}%' OR darmangar LIKE '%{6}%'", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

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
            // Save changes to the database.
            tablePTableAdapter.Update(counselingcenterDataSet.tableP);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";
            // string query = @"INSERT INTO tableP (parvandenum, name, phone, day, month, year, darmangar) VALUES (?, ?, ?, ?, ?, ?, ?)";
            string query = string.Format(
                                            @"insert into tableP (parvandenum,name,phone,[day],[month],[year],darmangar) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}') ",
                                            textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                
                connection.Open();
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
            // Save changes to the database.
            tablePTableAdapter.Update(counselingcenterDataSet.tableP);

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

        private void button7_Click(object sender, EventArgs e)
        {
           GetData();

        }

        private void patient_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl + D is pressed
            if (e.Control && e.KeyCode == Keys.X)
            {
                // Trigger the button's click action
                button1.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                // Trigger the button's click action
                button2.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                // Trigger the button's click action
                button3.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                // Trigger the button's click action
                button4.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                // Trigger the button's click action
                button5.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.Z)
            {
                // Trigger the button's click action
                button6.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.T)
            {
                // Trigger the button's click action
                button7.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Populate textboxes with data from the selected row
                    textBox1.Text = selectedRow.Cells[1].Value.ToString();
                    textBox2.Text = selectedRow.Cells[2].Value.ToString();
                    textBox3.Text = selectedRow.Cells[3].Value.ToString();
                    textBox4.Text = selectedRow.Cells[4].Value.ToString();
                    textBox5.Text = selectedRow.Cells[5].Value.ToString();
                    textBox6.Text = selectedRow.Cells[6].Value.ToString();
                    textBox7.Text = selectedRow.Cells[7].Value.ToString();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

}

