namespace productManagement.PL
{
    partial class frm_backup
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
            button1 = new Button();
            btnCancel = new Button();
            btncreate = new Button();
            txtFileName = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 85);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 0;
            label1.Text = "select where to save the backup:";
            // 
            // button1
            // 
            button1.Location = new Point(522, 134);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btncreate
            // 
            btncreate.Location = new Point(56, 224);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(125, 29);
            btncreate.TabIndex = 3;
            btncreate.Text = "create a backup";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += button3_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(56, 136);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(422, 27);
            txtFileName.TabIndex = 4;
            // 
            // frm_backup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFileName);
            Controls.Add(btncreate);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frm_backup";
            Text = "frm_backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnCancel;
        private Button btncreate;
        private TextBox txtFileName;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}