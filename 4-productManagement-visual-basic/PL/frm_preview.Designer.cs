namespace productManagement.PL
{
    partial class frm_preview
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
            picture1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            SuspendLayout();
            // 
            // picture1
            // 
            picture1.Location = new Point(40, 31);
            picture1.Name = "picture1";
            picture1.Size = new Size(681, 308);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 0;
            picture1.TabStop = false;
            // 
            // frm_preview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picture1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_preview";
            Text = "frm_preview";
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox picture1;
    }
}