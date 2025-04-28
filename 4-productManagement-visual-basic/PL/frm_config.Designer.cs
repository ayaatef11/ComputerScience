namespace productManagement.PL
{
    partial class frm_config
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
            serverName = new TextBox();
            dbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rbSql = new RadioButton();
            rbWindow = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            pwd = new TextBox();
            usName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "server name:";
            // 
            // serverName
            // 
            serverName.Location = new Point(189, 34);
            serverName.Name = "serverName";
            serverName.Size = new Size(125, 27);
            serverName.TabIndex = 1;
            // 
            // dbName
            // 
            dbName.Location = new Point(189, 104);
            dbName.Name = "dbName";
            dbName.Size = new Size(125, 27);
            dbName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Database name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 168);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Connection type:";
            // 
            // rbSql
            // 
            rbSql.AutoSize = true;
            rbSql.Checked = true;
            rbSql.Location = new Point(197, 205);
            rbSql.Name = "rbSql";
            rbSql.Size = new Size(191, 24);
            rbSql.TabIndex = 6;
            rbSql.TabStop = true;
            rbSql.Text = "sql server authentication";
            rbSql.UseVisualStyleBackColor = true;
            // 
            // rbWindow
            // 
            rbWindow.AutoSize = true;
            rbWindow.Location = new Point(197, 164);
            rbWindow.Name = "rbWindow";
            rbWindow.Size = new Size(187, 24);
            rbWindow.TabIndex = 7;
            rbWindow.Text = "windows authentication";
            rbWindow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 307);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 266);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "user name :";
            // 
            // pwd
            // 
            pwd.Location = new Point(197, 304);
            pwd.Name = "pwd";
            pwd.Size = new Size(125, 27);
            pwd.TabIndex = 10;
            // 
            // usName
            // 
            usName.Location = new Point(197, 263);
            usName.Name = "usName";
            usName.Size = new Size(125, 27);
            usName.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(134, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "save settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 358);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = true;
            // 
            // frm_config
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(usName);
            Controls.Add(pwd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rbWindow);
            Controls.Add(rbSql);
            Controls.Add(label3);
            Controls.Add(dbName);
            Controls.Add(label2);
            Controls.Add(serverName);
            Controls.Add(label1);
            Name = "frm_config";
            Text = "frm_config";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox serverName;
        private TextBox dbName;
        private Label label2;
        private Label label3;
        private RadioButton rbSql;
        private RadioButton rbWindow;
        private Label label4;
        private Label label5;
        private TextBox pwd;
        private TextBox usName;
        private Button button1;
        private Button button2;
    }
}