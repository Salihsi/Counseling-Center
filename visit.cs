using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();

            GetData();
        }
        public void GetData()
        {
            string queryString;
            string connectionString;
            queryString = @"Select * From [tableD1] ";
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
                    dataGridView1.Columns[2].HeaderText = "نام مراجع";
                    dataGridView1.Columns[3].HeaderText = "نام مشاور";
                    dataGridView1.Columns[4].HeaderText = "نام معرف";
                    dataGridView1.Columns[5].HeaderText = "کارت";
                    dataGridView1.Columns[6].HeaderText = "پوز";
                    dataGridView1.Columns[7].HeaderText = "نقدی";
                    dataGridView1.Columns[8].HeaderText = "جمع دریافتی";
                    dataGridView1.Columns[9].HeaderText = "درصد مشاور";
                    dataGridView1.Columns[10].HeaderText = "سهم مشاور";
                    dataGridView1.Columns[11].HeaderText = "درصد معرف";
                    dataGridView1.Columns[12].HeaderText = "سهم معرف";
                    dataGridView1.Columns[13].HeaderText = "سهم مرکز";
                    
                }
            }
            catch (Exception ex)
            {
                // Handle database connection or query errors.
                MessageBox.Show("Error: " + ex.Message);
            }
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
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("تاریخ، نام مراجع، و نام مشاور الزامی هستند.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Calculate the values for جمع دریافتی, درصد مشاور, and سهم مشاور
            decimal kart = string.IsNullOrWhiteSpace(textBox4.Text) ? 0 : decimal.Parse(textBox4.Text);
            decimal poz = string.IsNullOrWhiteSpace(textBox5.Text) ? 0 : decimal.Parse(textBox5.Text);
            decimal naqd = string.IsNullOrWhiteSpace(textBox6.Text) ? 0 : decimal.Parse(textBox6.Text);

            decimal jameDaryafti = kart + poz + naqd;
            decimal darsadMoshaver = string.IsNullOrWhiteSpace(textBox8.Text) ? 0 : decimal.Parse(textBox8.Text);
            decimal sohmMoshaver = (darsadMoshaver) * jameDaryafti;

            // Calculate سهم معرف and سهم مرکز if درصد معرف is filled
            decimal darsadMaaref = string.IsNullOrWhiteSpace(textBox10.Text) ? 0 : decimal.Parse(textBox10.Text);
            decimal sohmMaaref = (darsadMaaref / 100) * jameDaryafti;
            decimal sohmMarkaz = jameDaryafti - (sohmMoshaver + sohmMaaref);

            // Create a new row for the DataTable
            DataRow newRow = ((DataTable)dataGridView1.DataSource).NewRow();

            // Populate the new row with data from textboxes
            newRow["تاریخ"] = maskedTextBox1.Text;
            newRow["نام مراجع"] = textBox1.Text;
            newRow["نام مشاور"] = textBox2.Text;
            newRow["نام معرف"] = textBox3.Text;
            newRow["کارت"] = string.IsNullOrWhiteSpace(textBox4.Text) ? "N/A" : textBox4.Text;
            newRow["پوز"] = string.IsNullOrWhiteSpace(textBox5.Text) ? 0 : decimal.Parse(textBox5.Text);
            newRow["نقدی"] = string.IsNullOrWhiteSpace(textBox6.Text) ? 0 : decimal.Parse(textBox6.Text);
            newRow["جمع دریافتی"] = jameDaryafti;
            newRow["درصد مشاور"] = darsadMoshaver;
            newRow["سهم مشاور"] = sohmMoshaver;
            newRow["درصد معرف"] = darsadMaaref;
            newRow["سهم معرف"] = sohmMaaref;
            newRow["سهم مرکز"] = sohmMarkaz;
            // Add the new row to the DataTable
            ((DataTable)dataGridView1.DataSource).Rows.Add(newRow);

            // Show a success message
            MessageBox.Show("اطلاعات مراجع اضافه شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tableD1TableAdapter1.Update(counselingcenterDataSet7.tableD1);

            // Clear the textboxes after adding
            ClearTextBoxes();
            // Display the values in the added row in the textboxes
            maskedTextBox1.Text = newRow["تاریخ"].ToString();
            textBox1.Text = newRow["نام مراجع"].ToString();
            textBox2.Text = newRow["نام مشاور"].ToString();
            textBox3.Text = newRow["نام معرف"].ToString();
            textBox4.Text = newRow["کارت"].ToString();
            textBox5.Text = newRow["پوز"].ToString();
            textBox6.Text = newRow["نقدی"].ToString();
            textBox7.Text = newRow["جمع دریافتی"].ToString();
            textBox8.Text = newRow["درصد مشاور"].ToString();
            textBox9.Text = newRow["سهم مشاور"].ToString();
            textBox10.Text = newRow["درصد معرف"].ToString();
            textBox11.Text = newRow["سهم معرف"].ToString();
            textBox12.Text = newRow["سهم مرکز"].ToString();
        }

        // Function to clear all textboxes
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            maskedTextBox1.Clear();
        }

        
        private void visit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'counselingcenterDataSet7.tableD1' table. You can move, or remove it, as needed.
            this.tableD1TableAdapter1.Fill(this.counselingcenterDataSet7.tableD1);
            //textBox1.Text = Selectednamem;
            GetData();
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
                textBox6.Text = selectedRow.Cells[7].Value?.ToString();
                textBox7.Text = selectedRow.Cells[8].Value?.ToString();
                textBox8.Text = selectedRow.Cells[9].Value?.ToString();
                textBox9.Text = selectedRow.Cells[10].Value?.ToString();
                textBox10.Text = selectedRow.Cells[11].Value?.ToString();
                textBox11.Text = selectedRow.Cells[12].Value?.ToString();
                textBox12.Text = selectedRow.Cells[13].Value?.ToString();
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get the corresponding DataRow
            DataRow dataRow = ((DataRowView)selectedRow.DataBoundItem).Row;

            // Update the DataRow with data from textboxes
            dataRow["تاریخ"] = maskedTextBox1.Text;
            dataRow["نام مراجع"] = textBox1.Text;
            dataRow["نام مشاور"] = textBox2.Text;
            dataRow["نام معرف"] = textBox3.Text;
            dataRow["کارت"] = string.IsNullOrWhiteSpace(textBox4.Text) ? "N/A" : textBox4.Text;
            dataRow["پوز"] = string.IsNullOrWhiteSpace(textBox5.Text) ? 0 : decimal.Parse(textBox5.Text);
            dataRow["نقدی"] = string.IsNullOrWhiteSpace(textBox6.Text) ? 0 : decimal.Parse(textBox6.Text);
            dataRow["جمع دریافتی"] = string.IsNullOrWhiteSpace(textBox7.Text) ? 0 : decimal.Parse(textBox7.Text);
            dataRow["درصد مشاور"] = string.IsNullOrWhiteSpace(textBox8.Text) ? 0 : decimal.Parse(textBox8.Text);
            dataRow["سهم مشاور"] = string.IsNullOrWhiteSpace(textBox9.Text) ? 0 : decimal.Parse(textBox9.Text);
            dataRow["درصد معرف"] = string.IsNullOrWhiteSpace(textBox10.Text) ? 0 : decimal.Parse(textBox10.Text);
            dataRow["سهم معرف"] = string.IsNullOrWhiteSpace(textBox11.Text) ? 0 : decimal.Parse(textBox11.Text);
            dataRow["سهم مرکز"] = string.IsNullOrWhiteSpace(textBox12.Text) ? 0 : decimal.Parse(textBox12.Text);

            // Refresh the DataGridView to reflect the changes
            dataGridView1.Refresh();

            // Show a success message
            MessageBox.Show("اطلاعات مراجع بروزرسانی شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tableD1TableAdapter1.Update(counselingcenterDataSet7.tableD1);
            // Clear the textboxes after updating
            ClearTextBoxes();
        }


       
        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
    
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a list to store filter conditions
            List<string> conditions = new List<string>();

            // Check each textbox and add conditions if they are not empty
            if (!string.IsNullOrWhiteSpace(maskedTextBox1.Text))
                conditions.Add($"[تاریخ] LIKE '*{maskedTextBox1.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                conditions.Add($"[نام مراجع] LIKE '*{textBox1.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                conditions.Add($"[نام مشاور] LIKE '*{textBox2.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox3.Text))
                conditions.Add($"[نام معرف] LIKE '*{textBox3.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox4.Text))
                conditions.Add($"[کارت] LIKE '*{textBox4.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox5.Text))
                conditions.Add($"[پوز] LIKE '*{textBox5.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox6.Text))
                conditions.Add($"[نقدی] LIKE '*{textBox6.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox7.Text))
                conditions.Add($"[جمع دریافتی] LIKE '*{textBox7.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox8.Text))
                conditions.Add($"[درصد مشاور] LIKE '*{textBox8.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox9.Text))
                conditions.Add($"[سهم مشاور] LIKE '*{textBox9.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox10.Text))
                conditions.Add($"[درصد معرف] LIKE '*{textBox10.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox11.Text))
                conditions.Add($"[سهم معرف] LIKE '*{textBox11.Text}*'");

            if (!string.IsNullOrWhiteSpace(textBox12.Text))
                conditions.Add($"[سهم مرکز] LIKE '*{textBox12.Text}*'");

            // Join the conditions with OR to create the filter query
            string filterQuery = string.Join(" OR ", conditions);

            // Apply the filter to the DataTable
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = filterQuery;

            // Show a message if no rows match the filter
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("هیچ موردی با معیارهای جستجوی وارد شده پیدا نشد.", "نتیجه جستجو", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Clear the filter by setting an empty filter string
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "";

            // Show all rows again
            dataGridView1.Refresh();
        }



    }
}
