namespace productManagement.PL
{
    partial class frm_orders
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
            groupBox2 = new GroupBox();
            billId = new TextBox();
            label9 = new Label();
            billdesc = new TextBox();
            sellDate = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            search = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            txtPid = new TextBox();
            txtPname = new TextBox();
            txtMoney = new TextBox();
            txtDiscount = new TextBox();
            txtTamount = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            button5 = new Button();
            button4 = new Button();
            btnAdd = new Button();
            btnNew = new Button();
            button1 = new Button();
            dgvProducts = new DataGridView();
            groupBox1 = new GroupBox();
            pId = new TextBox();
            label11 = new Label();
            email = new TextBox();
            phno = new TextBox();
            lanme = new TextBox();
            fName = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(billId);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(billdesc);
            groupBox2.Controls.Add(sellDate);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(665, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 214);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order details";
            // 
            // billId
            // 
            billId.Location = new Point(97, 38);
            billId.Name = "billId";
            billId.Size = new Size(125, 27);
            billId.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 41);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 5;
            label9.Text = "bill no";
            // 
            // billdesc
            // 
            billdesc.Location = new Point(97, 87);
            billdesc.Multiline = true;
            billdesc.Name = "billdesc";
            billdesc.Size = new Size(125, 34);
            billdesc.TabIndex = 4;
            // 
            // sellDate
            // 
            sellDate.FormattingEnabled = true;
            sellDate.Location = new Point(97, 142);
            sellDate.Name = "sellDate";
            sellDate.Size = new Size(151, 28);
            sellDate.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 90);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "bill desc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "sell date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "seller name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(319, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 125);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(375, 21);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(search);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(txtPrice);
            groupBox3.Controls.Add(txtAmount);
            groupBox3.Controls.Add(txtPid);
            groupBox3.Controls.Add(txtPname);
            groupBox3.Controls.Add(txtMoney);
            groupBox3.Controls.Add(txtDiscount);
            groupBox3.Controls.Add(txtTamount);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(btnNew);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(dgvProducts);
            groupBox3.Location = new Point(28, 253);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1256, 328);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "products";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // search
            // 
            search.Location = new Point(1, 69);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 27;
            search.Text = "...";
            search.UseVisualStyleBackColor = true;
            search.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 33);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 12;
            label12.Text = "choose";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1125, 46);
            label13.Name = "label13";
            label13.Size = new Size(89, 20);
            label13.TabIndex = 13;
            label13.Text = "total money";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(973, 33);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 14;
            label14.Text = "discount";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(807, 33);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 15;
            label15.Text = "money";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(642, 33);
            label16.Name = "label16";
            label16.Size = new Size(60, 20);
            label16.TabIndex = 16;
            label16.Text = "amount";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(517, 33);
            label17.Name = "label17";
            label17.Size = new Size(46, 20);
            label17.TabIndex = 17;
            label17.Text = "price ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(258, 33);
            label18.Name = "label18";
            label18.Size = new Size(102, 20);
            label18.TabIndex = 18;
            label18.Text = "product name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(123, 33);
            label19.Name = "label19";
            label19.Size = new Size(78, 20);
            label19.TabIndex = 19;
            label19.Text = "product id";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(452, 69);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(169, 27);
            txtPrice.TabIndex = 20;
            txtPrice.TextChanged += textBox3_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(624, 69);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(155, 27);
            txtAmount.TabIndex = 21;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // txtPid
            // 
            txtPid.Location = new Point(93, 69);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(144, 27);
            txtPid.TabIndex = 22;
            // 
            // txtPname
            // 
            txtPname.Location = new Point(235, 69);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(218, 27);
            txtPname.TabIndex = 23;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(785, 69);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(150, 27);
            txtMoney.TabIndex = 24;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(941, 69);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(160, 27);
            txtDiscount.TabIndex = 25;
            // 
            // txtTamount
            // 
            txtTamount.Location = new Point(1107, 69);
            txtTamount.Name = "txtTamount";
            txtTamount.Size = new Size(125, 27);
            txtTamount.TabIndex = 26;
            txtTamount.TextChanged += txtTamount_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(785, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(700, 280);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 11;
            label10.Text = "sum:";
            // 
            // button5
            // 
            button5.Location = new Point(543, 275);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "exit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(418, 275);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "print bill";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(291, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "save sale";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(154, 275);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 7;
            btnNew.Text = "new sale";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 245);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 6;
            button1.Text = "delete selected line";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dgvProducts.Location = new Point(0, 102);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1243, 137);
            dgvProducts.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pId);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(phno);
            groupBox1.Controls.Add(lanme);
            groupBox1.Controls.Add(fName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 235);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "profile details";
            // 
            // pId
            // 
            pId.Location = new Point(150, 26);
            pId.Name = "pId";
            pId.Size = new Size(125, 27);
            pId.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 36);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 15;
            label11.Text = "profileId";
            // 
            // email
            // 
            email.Location = new Point(150, 180);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 1;
            // 
            // phno
            // 
            phno.Location = new Point(150, 138);
            phno.Name = "phno";
            phno.Size = new Size(125, 27);
            phno.TabIndex = 2;
            // 
            // lanme
            // 
            lanme.Location = new Point(150, 93);
            lanme.Name = "lanme";
            lanme.Size = new Size(125, 27);
            lanme.TabIndex = 3;
            // 
            // fName
            // 
            fName.Location = new Point(150, 62);
            fName.Name = "fName";
            fName.Size = new Size(125, 27);
            fName.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 171);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Profile name ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 96);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 5;
            label6.Text = "last name ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 134);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 6;
            label7.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(901, 191);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // frm_orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 593);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Name = "frm_orders";
            Text = "frm_orders";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox billId;
        private Label label9;
        private TextBox billdesc;
        private ComboBox sellDate;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private Button btnAdd;
        private Button btnNew;
        private Button button1;
        private DataGridView dgvProducts;
        private GroupBox groupBox1;
        private TextBox email;
        private TextBox phno;
        private TextBox lanme;
        private TextBox fName;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private TextBox textBox2;
        private Label label10;
        private PictureBox pictureBox1;
        private Button button2;
        private TextBox pId;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private TextBox txtPid;
        private TextBox txtPname;
        private TextBox txtMoney;
        private TextBox txtDiscount;
        private TextBox txtTamount;
        private Button search;
    }
}