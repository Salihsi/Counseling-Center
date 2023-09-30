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
            this.tableH1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counselingcenterDataSet9 = new CounselingCenter.counselingcenterDataSet9();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableH1TableAdapter = new CounselingCenter.counselingcenterDataSet9TableAdapters.tableH1TableAdapter();
            this.counselingcenterDataSet10 = new CounselingCenter.counselingcenterDataSet10();
            this.tableH1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableH1TableAdapter1 = new CounselingCenter.counselingcenterDataSet10TableAdapters.tableH1TableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوانخریدDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مبلغخریدDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نامخریدارDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.محلاعتبارDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نوعهزینهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableH1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableH1BindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.تاریخDataGridViewTextBoxColumn,
            this.عنوانخریدDataGridViewTextBoxColumn,
            this.مبلغخریدDataGridViewTextBoxColumn,
            this.نامخریدارDataGridViewTextBoxColumn,
            this.محلاعتبارDataGridViewTextBoxColumn,
            this.نوعهزینهDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableH1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1492, 681);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // tableH1BindingSource
            // 
            this.tableH1BindingSource.DataMember = "tableH1";
            this.tableH1BindingSource.DataSource = this.counselingcenterDataSet9;
            // 
            // counselingcenterDataSet9
            // 
            this.counselingcenterDataSet9.DataSetName = "counselingcenterDataSet9";
            this.counselingcenterDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "عنوان خرید";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "مبلغ خرید";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام خریدار";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "محل اعتبار";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "نوع هزینه";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 181);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(135, 49);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 236);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(135, 48);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 291);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(135, 48);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(205, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "اضافه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(205, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 69);
            this.button2.TabIndex = 8;
            this.button2.Text = "ویرایش";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(73, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 68);
            this.button3.TabIndex = 9;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(73, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 68);
            this.button4.TabIndex = 11;
            this.button4.Text = "پاک کردن";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(205, 527);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 68);
            this.button5.TabIndex = 10;
            this.button5.Text = "صفحه اصلی";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(73, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 69);
            this.button6.TabIndex = 8;
            this.button6.Text = "جستجو";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(116, 50);
            this.maskedTextBox1.Mask = "0/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedTextBox1.Size = new System.Drawing.Size(92, 22);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(135, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableH1TableAdapter
            // 
            this.tableH1TableAdapter.ClearBeforeFill = true;
            // 
            // counselingcenterDataSet10
            // 
            this.counselingcenterDataSet10.DataSetName = "counselingcenterDataSet10";
            this.counselingcenterDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableH1BindingSource1
            // 
            this.tableH1BindingSource1.DataMember = "tableH1";
            this.tableH1BindingSource1.DataSource = this.counselingcenterDataSet10;
            // 
            // tableH1TableAdapter1
            // 
            this.tableH1TableAdapter1.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(205, 601);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 68);
            this.button7.TabIndex = 12;
            this.button7.Text = "حالت اول";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(233, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cntrl+X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(101, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cnrtl+S";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(101, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cnrtl+D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(233, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Cnrtl+Z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(101, 570);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cnrtl+C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(231, 646);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cnrtl+T";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(73, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "ریال";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1110, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(382, 681);
            this.panel1.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(232, 495);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Cnrtl+F";
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
            // DAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "DAC";
            this.Text = "هزینه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DAC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DAC_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableH1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableH1BindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private counselingcenterDataSet9 counselingcenterDataSet9;
        private System.Windows.Forms.BindingSource tableH1BindingSource;
        private counselingcenterDataSet9TableAdapters.tableH1TableAdapter tableH1TableAdapter;
        private counselingcenterDataSet10 counselingcenterDataSet10;
        private System.Windows.Forms.BindingSource tableH1BindingSource1;
        private counselingcenterDataSet10TableAdapters.tableH1TableAdapter tableH1TableAdapter1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوانخریدDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مبلغخریدDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نامخریدارDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn محلاعتبارDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نوعهزینهDataGridViewTextBoxColumn;
    }
}