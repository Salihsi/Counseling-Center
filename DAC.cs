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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";
            //C:\Company-main\Codes\CounselingCenter\bin\Debug\counselingcenter.accdb
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
                    table.DefaultView.Sort = "ID";

                    // Bind the sorted data to the DataGridView.
                    dataGridView1.DataSource = table.DefaultView.ToTable();
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
            // TODO: This line of code loads data into the 'counselingcenterDataSet10.tableH1' table. You can move, or remove it, as needed.
            this.tableH1TableAdapter1.Fill(this.counselingcenterDataSet10.tableH1);
            // TODO: This line of code loads data into the 'counselingcenterDataSet9.tableH1' table. You can move, or remove it, as needed.
            this.tableH1TableAdapter.Fill(this.counselingcenterDataSet9.tableH1);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {
           string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";
           string insertQuery = "INSERT INTO tableH1 ([تاریخ], [عنوان خرید], [مبلغ خرید], [نام خریدار], [محل اعتبار], [نوع هزینه]) VALUES (?, ?, ?, ?, ?, ?)";

           try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection))
                    {
                        // Set parameters for the query using textboxes' values.
                        cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                        cmd.Parameters.AddWithValue("@p2", textBox1.Text);
                        cmd.Parameters.AddWithValue("@p3", textBox2.Text);
                        cmd.Parameters.AddWithValue("@p4", textBox3.Text);
                        cmd.Parameters.AddWithValue("@p5", textBox4.Text);
                        cmd.Parameters.AddWithValue("@p6", textBox5.Text);

                        // Execute the query to insert the data.
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // If data is successfully inserted, refresh the DataGridView.
                            GetData();
                            MessageBox.Show("داده با موفقیت اضافه شد.");
                        }
                        else
                        {
                            MessageBox.Show("داده ای وارد نشده است.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            tableH1TableAdapter1.Update(counselingcenterDataSet10.tableH1);

        }

        private void ClearTextBoxes()
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
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
            // Check if any row is selected.
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Prompt the user for confirmation.
                DialogResult result = MessageBox.Show("آیا حذف خود مطمئن هستید؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User confirmed deletion.
                    // Get the selected row.
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the ID (assuming it's in the first column) of the selected row.
                    int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);

                    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";

                    // Construct a DELETE query to remove the selected row by its ID.
                    string deleteQuery = "DELETE FROM tableH1 WHERE ID = @ID";

                    try
                    {
                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            connection.Open();
                            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, connection))
                            {
                                // Set the parameter for the ID.
                                cmd.Parameters.AddWithValue("@ID", selectedID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // If the row is successfully deleted, refresh the DataGridView.
                                    GetData();
                                    MessageBox.Show("سطر انتخاب شده، حذف شد.");
                                }
                                else
                                {
                                    MessageBox.Show("سطری حذف نشد.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
            tableH1TableAdapter1.Update(counselingcenterDataSet10.tableH1);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "0") return;
            decimal price;
            price = decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.Currency);
            textBox2.Text = price.ToString("#,#");
            textBox2.SelectionStart = textBox2.Text.Length;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any row is selected.
            if (dataGridView1.SelectedRows != null)
            {
                // Get the ID (assuming it's in the first column) of the selected row.
                int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";

                // Construct an UPDATE query to update the selected row by its ID.
                string updateQuery = "UPDATE tableH1 SET [تاریخ] = ?, [عنوان خرید] = ?, [مبلغ خرید] = ?, [نام خریدار] = ?, [محل اعتبار] = ?, [نوع هزینه] = ? WHERE ID = ?";

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        using (OleDbCommand cmd = new OleDbCommand(updateQuery, connection))
                        {
                            // Set parameters for the UPDATE query using textboxes' values.
                            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
                            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
                            cmd.Parameters.AddWithValue("@p3", textBox2.Text);
                            cmd.Parameters.AddWithValue("@p4", textBox3.Text);
                            cmd.Parameters.AddWithValue("@p5", textBox4.Text);
                            cmd.Parameters.AddWithValue("@p6", textBox5.Text);
                            cmd.Parameters.AddWithValue("@p7", selectedID); // Parameter for the WHERE clause

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // If the row is successfully updated, refresh the DataGridView.
                                GetData();
                                MessageBox.Show("با موفقیت ویرایش شد.");
                            }
                            else
                            {
                                MessageBox.Show("ویرایشی انجام نشد.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("لطفا یک نمونه برای ویرایش انتخاب کنید.");
            }
            tableH1TableAdapter1.Update(counselingcenterDataSet10.tableH1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> conditions = new List<string>();
            List<OleDbParameter> parameters = new List<OleDbParameter>();

            // Add conditions for each filled textbox and corresponding parameters.
            if (!string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                conditions.Add("[تاریخ] LIKE ?");
                parameters.Add(new OleDbParameter("@p1", "%" + maskedTextBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                conditions.Add("[عنوان خرید] LIKE ?");
                parameters.Add(new OleDbParameter("@p2", "%" + textBox1.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                conditions.Add("[مبلغ خرید] LIKE ?");
                parameters.Add(new OleDbParameter("@p3", "%" + textBox2.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                conditions.Add("[نام خریدار] LIKE ?");
                parameters.Add(new OleDbParameter("@p4", "%" + textBox3.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                conditions.Add("[محل اعتبار] LIKE ?");
                parameters.Add(new OleDbParameter("@p5", "%" + textBox4.Text + "%"));
            }

            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                conditions.Add("[نوع هزینه] LIKE ?");
                parameters.Add(new OleDbParameter("@p6", "%" + textBox5.Text + "%"));
            }

            // Check if at least one textbox was filled.
            if (conditions.Count > 0)
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\counselingcenter.accdb;";

                // Construct a SELECT query with a WHERE clause based on the filled textboxes.
                string searchQuery = "SELECT * FROM tableH1 WHERE " + string.Join(" OR ", conditions);

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        using (OleDbCommand cmd = new OleDbCommand(searchQuery, connection))
                        {
                            // Add parameters to the command.
                            cmd.Parameters.AddRange(parameters.ToArray());

                            DataTable table = new DataTable
                            {
                                Locale = CultureInfo.InvariantCulture
                            };

                            // Create and configure the adapter.
                            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                            // Fill the DataTable with matching data from the database.
                            adapter.Fill(table);

                            // Set the DataGridView's DataSource to the search results.
                            dataGridView1.DataSource = table;

                            // Set column headers...
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter at least one search criterion.");
            }
            tableH1TableAdapter1.Update(counselingcenterDataSet10.tableH1);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void DAC_KeyDown(object sender, KeyEventArgs e)
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
            if (e.Control && e.KeyCode == Keys.D)
            {
                // Trigger the button's click action
                button3.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                // Trigger the button's click action
                button4.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.Z)
            {
                // Trigger the button's click action
                button5.PerformClick();
                // Prevent further handling of the key press
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.S)
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



            // Add more cases for other operators and special keys

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

                    maskedTextBox1.Text = selectedRow.Cells[1].Value.ToString();
                    textBox1.Text = selectedRow.Cells[2].Value.ToString();
                    textBox2.Text = selectedRow.Cells[3].Value.ToString();
                    textBox3.Text = selectedRow.Cells[4].Value.ToString();
                    textBox4.Text = selectedRow.Cells[5].Value.ToString();
                    textBox5.Text = selectedRow.Cells[6].Value.ToString();
                }
            }
        }
    }
}
