namespace CounselingCenter
{
    partial class DAC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.counselingcenterDataSet8 = new CounselingCenter.counselingcenterDataSet8();
            this.tableHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableHTableAdapter = new CounselingCenter.counselingcenterDataSet8TableAdapters.tableHTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوانخریدDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مبلغخریدDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نامخریدارDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.محلاعتبارDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نوعهزینهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.counselingcenterDataSet9 = new CounselingCenter.counselingcenterDataSet9();
            this.tableH1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableH1TableAdapter = new CounselingCenter.counselingcenterDataSet9TableAdapters.tableH1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableH1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.تاریخDataGridViewTextBoxColumn,
            this.عنوانخریدDataGridViewTextBoxColumn,
            this.مبلغخریدDataGridViewTextBoxColumn,
            this.نامخریدارDataGridViewTextBoxColumn,
            this.محلاعتبارDataGridViewTextBoxColumn,
            this.نوعهزینهDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableH1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 678);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1312, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1287, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "عنوان خرید";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1293, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "مبلغ خرید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1291, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام خریدار";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1287, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "محل اعتبار";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1287, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "نوع هزینه";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1142, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1142, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1096, 235);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1096, 272);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 22);
            this.textBox5.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1095, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "اضافه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1227, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 55);
            this.button2.TabIndex = 14;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1095, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 55);
            this.button3.TabIndex = 15;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1227, 456);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 55);
            this.button4.TabIndex = 16;
            this.button4.Text = "پاک کردن";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1227, 542);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 55);
            this.button5.TabIndex = 17;
            this.button5.Text = "صفحه اصلی";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1095, 542);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 55);
            this.button6.TabIndex = 18;
            this.button6.Text = "جستجو";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // counselingcenterDataSet8
            // 
            this.counselingcenterDataSet8.DataSetName = "counselingcenterDataSet8";
            this.counselingcenterDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableHBindingSource
            // 
            this.tableHBindingSource.DataMember = "tableH";
            this.tableHBindingSource.DataSource = this.counselingcenterDataSet8;
            // 
            // tableHTableAdapter
            // 
            this.tableHTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // تاریخDataGridViewTextBoxColumn
            // 
            this.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ";
            this.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.تاریخDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn";
            this.تاریخDataGridViewTextBoxColumn.Width = 125;
            // 
            // عنوانخریدDataGridViewTextBoxColumn
            // 
            this.عنوانخریدDataGridViewTextBoxColumn.DataPropertyName = "عنوان خرید";
            this.عنوانخریدDataGridViewTextBoxColumn.HeaderText = "عنوان خرید";
            this.عنوانخریدDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.عنوانخریدDataGridViewTextBoxColumn.Name = "عنوانخریدDataGridViewTextBoxColumn";
            this.عنوانخریدDataGridViewTextBoxColumn.Width = 125;
            // 
            // مبلغخریدDataGridViewTextBoxColumn
            // 
            this.مبلغخریدDataGridViewTextBoxColumn.DataPropertyName = "مبلغ خرید";
            this.مبلغخریدDataGridViewTextBoxColumn.HeaderText = "مبلغ خرید";
            this.مبلغخریدDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.مبلغخریدDataGridViewTextBoxColumn.Name = "مبلغخریدDataGridViewTextBoxColumn";
            this.مبلغخریدDataGridViewTextBoxColumn.Width = 125;
            // 
            // نامخریدارDataGridViewTextBoxColumn
            // 
            this.نامخریدارDataGridViewTextBoxColumn.DataPropertyName = "نام خریدار";
            this.نامخریدارDataGridViewTextBoxColumn.HeaderText = "نام خریدار";
            this.نامخریدارDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.نامخریدارDataGridViewTextBoxColumn.Name = "نامخریدارDataGridViewTextBoxColumn";
            this.نامخریدارDataGridViewTextBoxColumn.Width = 125;
            // 
            // محلاعتبارDataGridViewTextBoxColumn
            // 
            this.محلاعتبارDataGridViewTextBoxColumn.DataPropertyName = "محل اعتبار";
            this.محلاعتبارDataGridViewTextBoxColumn.HeaderText = "محل اعتبار";
            this.محلاعتبارDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.محلاعتبارDataGridViewTextBoxColumn.Name = "محلاعتبارDataGridViewTextBoxColumn";
            this.محلاعتبارDataGridViewTextBoxColumn.Width = 125;
            // 
            // نوعهزینهDataGridViewTextBoxColumn
            // 
            this.نوعهزینهDataGridViewTextBoxColumn.DataPropertyName = "نوع هزینه";
            this.نوعهزینهDataGridViewTextBoxColumn.HeaderText = "نوع هزینه";
            this.نوعهزینهDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.نوعهزینهDataGridViewTextBoxColumn.Name = "نوعهزینهDataGridViewTextBoxColumn";
            this.نوعهزینهDataGridViewTextBoxColumn.Width = 125;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1142, 59);
            this.maskedTextBox1.Mask = "0/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(145, 22);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1142, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // counselingcenterDataSet9
            // 
            this.counselingcenterDataSet9.DataSetName = "counselingcenterDataSet9";
            this.counselingcenterDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableH1BindingSource
            // 
            this.tableH1BindingSource.DataMember = "tableH1";
            this.tableH1BindingSource.DataSource = this.counselingcenterDataSet9;
            // 
            // tableH1TableAdapter
            // 
            this.tableH1TableAdapter.ClearBeforeFill = true;
            // 
            // DAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 681);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DAC";
            this.Text = "هزینه";
            this.Load += new System.EventHandler(this.DAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableH1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private counselingcenterDataSet8 counselingcenterDataSet8;
        private System.Windows.Forms.BindingSource tableHBindingSource;
        private counselingcenterDataSet8TableAdapters.tableHTableAdapter tableHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوانخریدDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مبلغخریدDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نامخریدارDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn محلاعتبارDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نوعهزینهDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private counselingcenterDataSet9 counselingcenterDataSet9;
        private System.Windows.Forms.BindingSource tableH1BindingSource;
        private counselingcenterDataSet9TableAdapters.tableH1TableAdapter tableH1TableAdapter;
    }
}