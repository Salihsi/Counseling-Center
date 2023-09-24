namespace CounselingCenter
{
    partial class hashtbehesht
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.مراجعاتtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.پروندهtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.دکترtoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(1203, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(160, 630);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مراجعاتtoolStripMenuItem2,
            this.پروندهtoolStripMenuItem3,
            this.دکترtoolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem1.Text = "مدیریت مرکز مشاوره";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // مراجعاتtoolStripMenuItem2
            // 
            this.مراجعاتtoolStripMenuItem2.Name = "مراجعاتtoolStripMenuItem2";
            this.مراجعاتtoolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.مراجعاتtoolStripMenuItem2.Size = new System.Drawing.Size(274, 26);
            this.مراجعاتtoolStripMenuItem2.Text = "درآمد                   Cntrl+D";
            this.مراجعاتtoolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // پروندهtoolStripMenuItem3
            // 
            this.پروندهtoolStripMenuItem3.Name = "پروندهtoolStripMenuItem3";
            this.پروندهtoolStripMenuItem3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.پروندهtoolStripMenuItem3.RightToLeftAutoMirrorImage = true;
            this.پروندهtoolStripMenuItem3.Size = new System.Drawing.Size(274, 26);
            this.پروندهtoolStripMenuItem3.Text = "پرونده ها                   Cntrl+P";
            this.پروندهtoolStripMenuItem3.Click += new System.EventHandler(this.پروندهtoolStripMenuItem3_Click);
            // 
            // دکترtoolStripMenuItem4
            // 
            this.دکترtoolStripMenuItem4.Name = "دکترtoolStripMenuItem4";
            this.دکترtoolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.دکترtoolStripMenuItem4.RightToLeftAutoMirrorImage = true;
            this.دکترtoolStripMenuItem4.Size = new System.Drawing.Size(274, 26);
            this.دکترtoolStripMenuItem4.Text = "هزینه                   Cntrl+H";
            this.دکترtoolStripMenuItem4.Click += new System.EventHandler(this.دکترtoolStripMenuItem4_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1203, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 634);
            this.panel1.TabIndex = 2;
            // 
            // hashtbehesht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "hashtbehesht";
            this.Text = "مرکز مشاوره هشت بهشت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hashtbehesht_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hashtbehesht_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem مراجعاتtoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem پروندهtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem دکترtoolStripMenuItem4;
    }
}