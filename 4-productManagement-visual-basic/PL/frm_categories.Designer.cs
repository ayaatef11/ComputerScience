namespace productManagement.PL
{
    partial class frm_categories
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
            iblPos = new Label();
            btnprev = new Button();
            btnfirst = new Button();
            btnNext = new Button();
            btnLast = new Button();
            txtId = new TextBox();
            txtdesc = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnNew = new Button();
            btnAdd = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            btnexit = new Button();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iblPos);
            groupBox1.Controls.Add(btnprev);
            groupBox1.Controls.Add(btnfirst);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnLast);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtdesc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "category details";
            // 
            // iblPos
            // 
            iblPos.AutoSize = true;
            iblPos.Location = new Point(240, 126);
            iblPos.Name = "iblPos";
            iblPos.Size = new Size(31, 20);
            iblPos.TabIndex = 8;
            iblPos.Text = "7/6";
            iblPos.Click += iblPos_Click;
            // 
            // btnprev
            // 
            btnprev.Location = new Point(29, 117);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(94, 29);
            btnprev.TabIndex = 7;
            btnprev.Text = ">>";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += btnprev_Click;
            // 
            // btnfirst
            // 
            btnfirst.Location = new Point(140, 117);
            btnfirst.Name = "btnfirst";
            btnfirst.Size = new Size(94, 29);
            btnfirst.TabIndex = 6;
            btnfirst.Text = ">>||";
            btnfirst.UseVisualStyleBackColor = true;
            btnfirst.Click += button3_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(284, 117);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 5;
            btnNext.Text = "<<";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(384, 117);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(94, 29);
            btnLast.TabIndex = 4;
            btnLast.Text = "<<||";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(183, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 3;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(183, 53);
            txtdesc.Multiline = true;
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(125, 34);
            txtdesc.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 1;
            label2.Text = "category description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "category id";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(31, 45);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "btnNew";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += button5_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(213, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "btnadd ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button7
            // 
            button7.Location = new Point(384, 45);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 3;
            button7.Text = "btndelete ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(516, 45);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 4;
            button8.Text = "btnedit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(642, 45);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 5;
            button9.Text = "btnprint recent category";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(6, 90);
            button10.Name = "button10";
            button10.Size = new Size(147, 29);
            button10.TabIndex = 6;
            button10.Text = "btnprint all categories";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(159, 90);
            button11.Name = "button11";
            button11.Size = new Size(192, 29);
            button11.TabIndex = 7;
            button11.Text = "btnsave recent categry as pdf ";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(372, 90);
            button12.Name = "button12";
            button12.Size = new Size(196, 29);
            button12.TabIndex = 8;
            button12.Text = "btnsave all categories as pdf";
            button12.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(648, 90);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 9;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += button13_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnexit);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(btnNew);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button11);
            groupBox2.Location = new Point(64, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(748, 125);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Available transactions";
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Location = new Point(11, 37);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 51;
            dgList.RowTemplate.Height = 29;
            dgList.Size = new Size(796, 246);
            dgList.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgList);
            groupBox3.Location = new Point(30, 367);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(832, 289);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "categories list";
            // 
            // frm_categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 668);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frm_categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_categories";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtId;
        private TextBox txtdesc;
        private Label label2;
        private Label label1;
        private Button btnprev;
        private Button btnfirst;
        private Button btnNext;
        private Button btnLast;
        private Button btnNew;
        private Button btnAdd;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnexit;
        private GroupBox groupBox2;
        private DataGridView dgList;
        private GroupBox groupBox3;
        private Label iblPos;
    }
}