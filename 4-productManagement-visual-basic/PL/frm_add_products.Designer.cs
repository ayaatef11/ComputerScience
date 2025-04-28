namespace productManagement.PL
{
    partial class frm_add_products
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
            refText = new TextBox();
            cmbCategories = new ComboBox();
            pbox = new PictureBox();
            btnOk = new Button();
            btnCancel = new Button();
            txtQte = new TextBox();
            txtPrice = new TextBox();
            button1 = new Button();
            textDesc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(refText);
            groupBox1.Controls.Add(cmbCategories);
            groupBox1.Controls.Add(pbox);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtQte);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textDesc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "product details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // refText
            // 
            refText.Location = new Point(191, 80);
            refText.Name = "refText";
            refText.Size = new Size(151, 27);
            refText.TabIndex = 0;
            refText.Validated += refText_Validated;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(191, 40);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(151, 28);
            cmbCategories.TabIndex = 16;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // pbox
            // 
            pbox.Image = Properties.Resources.Screenshot_2023_10_03_113900;
            pbox.Location = new Point(191, 237);
            pbox.Name = "pbox";
            pbox.Size = new Size(240, 82);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.TabIndex = 15;
            pbox.TabStop = false;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(124, 391);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 14;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button3_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "exit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // txtQte
            // 
            txtQte.Location = new Point(191, 153);
            txtQte.Name = "txtQte";
            txtQte.Size = new Size(164, 27);
            txtQte.TabIndex = 2;
            txtQte.TextChanged += txtQte_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(191, 195);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(164, 27);
            txtPrice.TabIndex = 3;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(234, 339);
            button1.Name = "button1";
            button1.Size = new Size(130, 46);
            button1.TabIndex = 4;
            button1.Text = "bselect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textDesc
            // 
            textDesc.Location = new Point(191, 114);
            textDesc.Multiline = true;
            textDesc.Name = "textDesc";
            textDesc.ScrollBars = ScrollBars.Vertical;
            textDesc.Size = new Size(164, 34);
            textDesc.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 117);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 5;
            label6.Text = "product description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 237);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "image product ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 195);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "price ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "quantity in stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "poduct label ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "product id:";
            // 
            // frm_add_products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_add_products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add a new product ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        public Button button1;
        public TextBox textDesc;
        public TextBox txtQte;
        public TextBox txtPrice;
        public PictureBox pbox;
        public ComboBox cmbCategories;
        public TextBox refText;
        public Button btnOk;
        public Button btnCancel;
    }
}