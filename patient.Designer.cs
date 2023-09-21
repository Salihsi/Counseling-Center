namespace CounselingCenter
{
    partial class patient
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parvandenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darmangarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.counselingcenterDataSet4 = new CounselingCenter.counselingcenterDataSet4();
            this.tablePBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counselingcenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.counselingcenterDataSet = new CounselingCenter.counselingcenterDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.counselingcenterDataSet2 = new CounselingCenter.counselingcenterDataSet2();
            this.counselingcenterDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePTableAdapter = new CounselingCenter.counselingcenterDataSetTableAdapters.tablePTableAdapter();
            this.tablePTableAdapter1 = new CounselingCenter.counselingcenterDataSet4TableAdapters.tablePTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.parvandenumDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.darmangarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablePBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 678);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // parvandenumDataGridViewTextBoxColumn
            // 
            this.parvandenumDataGridViewTextBoxColumn.DataPropertyName = "parvandenum";
            this.parvandenumDataGridViewTextBoxColumn.HeaderText = "parvandenum";
            this.parvandenumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parvandenumDataGridViewTextBoxColumn.Name = "parvandenumDataGridViewTextBoxColumn";
            this.parvandenumDataGridViewTextBoxColumn.ReadOnly = true;
            this.parvandenumDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // darmangarDataGridViewTextBoxColumn
            // 
            this.darmangarDataGridViewTextBoxColumn.DataPropertyName = "darmangar";
            this.darmangarDataGridViewTextBoxColumn.HeaderText = "darmangar";
            this.darmangarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.darmangarDataGridViewTextBoxColumn.Name = "darmangarDataGridViewTextBoxColumn";
            this.darmangarDataGridViewTextBoxColumn.ReadOnly = true;
            this.darmangarDataGridViewTextBoxColumn.Width = 125;
            // 
            // tablePBindingSource1
            // 
            this.tablePBindingSource1.DataMember = "tableP";
            this.tablePBindingSource1.DataSource = this.counselingcenterDataSet4;
            // 
            // counselingcenterDataSet4
            // 
            this.counselingcenterDataSet4.DataSetName = "counselingcenterDataSet4";
            this.counselingcenterDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePBindingSource
            // 
            this.tablePBindingSource.DataMember = "tableP";
            this.tablePBindingSource.DataSource = this.counselingcenterDataSetBindingSource;
            // 
            // counselingcenterDataSetBindingSource
            // 
            this.counselingcenterDataSetBindingSource.DataSource = this.counselingcenterDataSet;
            this.counselingcenterDataSetBindingSource.Position = 0;
            // 
            // counselingcenterDataSet
            // 
            this.counselingcenterDataSet.DataSetName = "counselingcenterDataSet";
            this.counselingcenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1416, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام مراجع";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1398, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره پرونده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1400, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "شماره همراه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1425, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "روز تولد";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1242, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1242, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1242, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1394, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "ثبت بیمار";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1394, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "ویرایش بیمار";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1132, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "پاک کردن";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1260, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "جستجو بیمار";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1260, 560);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "حذف بیمار";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1132, 493);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 43);
            this.button6.TabIndex = 14;
            this.button6.Text = "صفحه اصلی";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1407, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "نام درمانگر";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1242, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 22);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1242, 275);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1242, 331);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 22);
            this.textBox6.TabIndex = 20;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1242, 389);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 22);
            this.textBox7.TabIndex = 21;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1426, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "ماه تولد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1422, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "سال تولد";
            // 
            // counselingcenterDataSet2
            // 
            this.counselingcenterDataSet2.DataSetName = "counselingcenterDataSet2";
            this.counselingcenterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // counselingcenterDataSet2BindingSource
            // 
            this.counselingcenterDataSet2BindingSource.DataSource = this.counselingcenterDataSet2;
            this.counselingcenterDataSet2BindingSource.Position = 0;
            // 
            // tablePTableAdapter
            // 
            this.tablePTableAdapter.ClearBeforeFill = true;
            // 
            // tablePTableAdapter1
            // 
            this.tablePTableAdapter1.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1394, 617);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 41);
            this.button7.TabIndex = 24;
            this.button7.Text = "حالت اول";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1561, 679);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "patient";
            this.Text = "پرونده ها";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counselingcenterDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource counselingcenterDataSet2BindingSource;
        private counselingcenterDataSet2 counselingcenterDataSet2;
        private counselingcenterDataSet counselingcenterDataSet;
        private System.Windows.Forms.BindingSource counselingcenterDataSetBindingSource;
        private System.Windows.Forms.BindingSource tablePBindingSource;
        private counselingcenterDataSetTableAdapters.tablePTableAdapter tablePTableAdapter;
        private counselingcenterDataSet4 counselingcenterDataSet4;
        private System.Windows.Forms.BindingSource tablePBindingSource1;
        private counselingcenterDataSet4TableAdapters.tablePTableAdapter tablePTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parvandenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darmangarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
    }
}