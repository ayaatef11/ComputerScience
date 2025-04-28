namespace productManagement.PL
{
    partial class FormLogin
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
            txtId = new Label();
            txtPWD = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            btnExt = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(59, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(85, 20);
            txtId.TabIndex = 0;
            txtId.Text = "User Name:";
            txtId.Click += label1_Click;
            // 
            // txtPWD
            // 
            txtPWD.AutoSize = true;
            txtPWD.Location = new Point(59, 123);
            txtPWD.Name = "txtPWD";
            txtPWD.Size = new Size(73, 20);
            txtPWD.TabIndex = 1;
            txtPWD.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 27);
            textBox2.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ScrollBar;
            btnLogin.Location = new Point(171, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExt
            // 
            btnExt.BackColor = SystemColors.ScrollBar;
            btnExt.Location = new Point(324, 220);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(94, 29);
            btnExt.TabIndex = 5;
            btnExt.Text = "Exit";
            btnExt.UseVisualStyleBackColor = false;
            btnExt.Click += btnExt_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExt);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPWD);
            Controls.Add(txtId);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            Text = "loging";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtId;
        private Label txtPWD;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private Button btnExt;
    }
}