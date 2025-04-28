namespace productManagement.PL
{
    partial class frm_products
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
            label1 = new Label();
            textSearch = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter the word you search for:";
            label1.Click += label1_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(249, 39);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(125, 27);
            textSearch.TabIndex = 0;
            textSearch.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(30, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(860, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "products table";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(857, 173);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(30, 362);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(844, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "available transactions";
            // 
            // button7
            // 
            button7.Location = new Point(361, 91);
            button7.Name = "button7";
            button7.Size = new Size(116, 34);
            button7.TabIndex = 6;
            button7.Text = "exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(166, 96);
            button8.Name = "button8";
            button8.Size = new Size(189, 29);
            button8.TabIndex = 5;
            button8.Text = "save in an excel sheet";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(577, 41);
            button5.Name = "button5";
            button5.Size = new Size(167, 27);
            button5.TabIndex = 4;
            button5.Text = "print selected product ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(448, 41);
            button4.Name = "button4";
            button4.Size = new Size(123, 29);
            button4.TabIndex = 3;
            button4.Text = "product photo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(316, 41);
            button3.Name = "button3";
            button3.Size = new Size(116, 34);
            button3.TabIndex = 2;
            button3.Text = "edit a product ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(121, 46);
            button2.Name = "button2";
            button2.Size = new Size(189, 29);
            button2.TabIndex = 1;
            button2.Text = "delete selected product ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 46);
            button1.Name = "button1";
            button1.Size = new Size(115, 31);
            button1.TabIndex = 0;
            button1.Text = "add new ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(780, 401);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "print all";
            button6.UseVisualStyleBackColor = true;
            // 
            // frm_products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 575);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textSearch);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frm_products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_products";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textSearch;
        public DataGridView dataGridView1;
    }
}