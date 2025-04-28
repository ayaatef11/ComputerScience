namespace productManagement.PL
{
    partial class frm_customers_
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
            groupBox1 = new GroupBox();
            dg1 = new DataGridView();
            textBox5 = new TextBox();
            button10 = new Button();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtPhoto = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtPhNo = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoto).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dg1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(489, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "all customers list";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Location = new Point(3, 220);
            dg1.Name = "dg1";
            dg1.RowHeadersWidth = 51;
            dg1.RowTemplate.Height = 29;
            dg1.Size = new Size(300, 188);
            dg1.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(87, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 2;
            // 
            // button10
            // 
            button10.Location = new Point(218, 85);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 1;
            button10.Text = "accept";
            button10.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 85);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 0;
            label6.Text = "Search word";
            label6.Click += label6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPhoto);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtFname);
            groupBox2.Controls.Add(txtLname);
            groupBox2.Controls.Add(txtPhNo);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 270);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "customer details";
            // 
            // txtPhoto
            // 
            txtPhoto.Cursor = Cursors.Hand;
            txtPhoto.Location = new Point(285, 35);
            txtPhoto.Name = "txtPhoto";
            txtPhoto.Size = new Size(125, 143);
            txtPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            txtPhoto.TabIndex = 13;
            txtPhoto.TabStop = false;
            txtPhoto.Click += txtPhoto_Click;
            // 
            // button4
            // 
            button4.Location = new Point(338, 211);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "<<||";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(238, 211);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "<<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(89, 211);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(-11, 211);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "||>>";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 220);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 8;
            label5.Text = "7/6";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(135, 35);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(125, 27);
            txtFname.TabIndex = 7;
            txtFname.KeyDown += txtFname_KeyDown;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(135, 78);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(125, 27);
            txtLname.TabIndex = 6;
            txtLname.KeyDown += txtLname_KeyDown;
            // 
            // txtPhNo
            // 
            txtPhNo.Location = new Point(135, 111);
            txtPhNo.Name = "txtPhNo";
            txtPhNo.Size = new Size(125, 27);
            txtPhNo.TabIndex = 5;
            txtPhNo.KeyDown += txtPhNo_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 144);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 104);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnEdit);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnNew);
            groupBox3.Location = new Point(12, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(471, 125);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Available transactions";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(377, 41);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(285, 41);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(189, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button6_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(-7, 41);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "new";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // frm_customers_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frm_customers_";
            Text = "frm_customers_";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPhoto).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtPhNo;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private PictureBox txtPhoto;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnNew;
        private DataGridView dg1;
        private TextBox textBox5;
        private Button button10;
        private Label label6;
    }
}