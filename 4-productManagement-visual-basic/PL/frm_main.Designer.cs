namespace productManagement.PL
{
    partial class frm_main
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            createAnotherEditionToolStripMenuItem = new ToolStripMenuItem();
            restorePreservedEditonToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            productsManangementToolStripMenuItem = new ToolStripMenuItem();
            addANewTypeToolStripMenuItem = new ToolStripMenuItem();
            adminstrateTypesToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            addANewClientToolStripMenuItem = new ToolStripMenuItem();
            adminstrateClientsToolStripMenuItem = new ToolStripMenuItem();
            addANewSaleToolStripMenuItem = new ToolStripMenuItem();
            adminstrateSalesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            addANewUserToolStripMenuItem = new ToolStripMenuItem();
            adminstrateUsersToolStripMenuItem = new ToolStripMenuItem();
            connectToTheServerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, productsToolStripMenuItem, clientsToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, createAnotherEditionToolStripMenuItem, restorePreservedEditonToolStripMenuItem, connectToTheServerToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "file";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(238, 26);
            loginToolStripMenuItem.Text = "login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // createAnotherEditionToolStripMenuItem
            // 
            createAnotherEditionToolStripMenuItem.Name = "createAnotherEditionToolStripMenuItem";
            createAnotherEditionToolStripMenuItem.Size = new Size(238, 26);
            createAnotherEditionToolStripMenuItem.Text = "create a backup copy";
            createAnotherEditionToolStripMenuItem.Click += createAnotherEditionToolStripMenuItem_Click;
            // 
            // restorePreservedEditonToolStripMenuItem
            // 
            restorePreservedEditonToolStripMenuItem.Name = "restorePreservedEditonToolStripMenuItem";
            restorePreservedEditonToolStripMenuItem.Size = new Size(238, 26);
            restorePreservedEditonToolStripMenuItem.Text = "restore a backup copy";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(238, 26);
            logoutToolStripMenuItem.Text = "logout";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem, productsManangementToolStripMenuItem, addANewTypeToolStripMenuItem, adminstrateTypesToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(81, 24);
            productsToolStripMenuItem.Text = "products";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(250, 26);
            addProductToolStripMenuItem.Text = "add product ";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // productsManangementToolStripMenuItem
            // 
            productsManangementToolStripMenuItem.Name = "productsManangementToolStripMenuItem";
            productsManangementToolStripMenuItem.Size = new Size(250, 26);
            productsManangementToolStripMenuItem.Text = "products manangement";
            productsManangementToolStripMenuItem.Click += productsManangementToolStripMenuItem_Click;
            // 
            // addANewTypeToolStripMenuItem
            // 
            addANewTypeToolStripMenuItem.Name = "addANewTypeToolStripMenuItem";
            addANewTypeToolStripMenuItem.Size = new Size(250, 26);
            addANewTypeToolStripMenuItem.Text = "add a new category ";
            addANewTypeToolStripMenuItem.Click += addANewTypeToolStripMenuItem_Click;
            // 
            // adminstrateTypesToolStripMenuItem
            // 
            adminstrateTypesToolStripMenuItem.Name = "adminstrateTypesToolStripMenuItem";
            adminstrateTypesToolStripMenuItem.Size = new Size(250, 26);
            adminstrateTypesToolStripMenuItem.Text = "category management";
            adminstrateTypesToolStripMenuItem.Click += adminstrateTypesToolStripMenuItem_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addANewClientToolStripMenuItem, adminstrateClientsToolStripMenuItem, addANewSaleToolStripMenuItem, adminstrateSalesToolStripMenuItem });
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(65, 24);
            clientsToolStripMenuItem.Text = "clients";
            // 
            // addANewClientToolStripMenuItem
            // 
            addANewClientToolStripMenuItem.Name = "addANewClientToolStripMenuItem";
            addANewClientToolStripMenuItem.Size = new Size(221, 26);
            addANewClientToolStripMenuItem.Text = "add a new client ";
            // 
            // adminstrateClientsToolStripMenuItem
            // 
            adminstrateClientsToolStripMenuItem.Name = "adminstrateClientsToolStripMenuItem";
            adminstrateClientsToolStripMenuItem.Size = new Size(221, 26);
            adminstrateClientsToolStripMenuItem.Text = "adminstrate clients ";
            // 
            // addANewSaleToolStripMenuItem
            // 
            addANewSaleToolStripMenuItem.Name = "addANewSaleToolStripMenuItem";
            addANewSaleToolStripMenuItem.Size = new Size(221, 26);
            addANewSaleToolStripMenuItem.Text = "add a new sale ";
            // 
            // adminstrateSalesToolStripMenuItem
            // 
            adminstrateSalesToolStripMenuItem.Name = "adminstrateSalesToolStripMenuItem";
            adminstrateSalesToolStripMenuItem.Size = new Size(221, 26);
            adminstrateSalesToolStripMenuItem.Text = "adminstrate sales ";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addANewUserToolStripMenuItem, adminstrateUsersToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(60, 24);
            usersToolStripMenuItem.Text = "users ";
            // 
            // addANewUserToolStripMenuItem
            // 
            addANewUserToolStripMenuItem.Name = "addANewUserToolStripMenuItem";
            addANewUserToolStripMenuItem.Size = new Size(208, 26);
            addANewUserToolStripMenuItem.Text = "add a new user";
            // 
            // adminstrateUsersToolStripMenuItem
            // 
            adminstrateUsersToolStripMenuItem.Name = "adminstrateUsersToolStripMenuItem";
            adminstrateUsersToolStripMenuItem.Size = new Size(208, 26);
            adminstrateUsersToolStripMenuItem.Text = "adminstrate users";
            // 
            // connectToTheServerToolStripMenuItem
            // 
            connectToTheServerToolStripMenuItem.Name = "connectToTheServerToolStripMenuItem";
            connectToTheServerToolStripMenuItem.Size = new Size(238, 26);
            connectToTheServerToolStripMenuItem.Text = "connect to the server";
            connectToTheServerToolStripMenuItem.Click += connectToTheServerToolStripMenuItem_Click;
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frm_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "product_management_expermintal_edition";
            WindowState = FormWindowState.Maximized;
            Load += frm_main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem productsManangementToolStripMenuItem;
        private ToolStripMenuItem addANewTypeToolStripMenuItem;
        private ToolStripMenuItem adminstrateTypesToolStripMenuItem;
        private ToolStripMenuItem addANewClientToolStripMenuItem;
        private ToolStripMenuItem adminstrateClientsToolStripMenuItem;
        private ToolStripMenuItem addANewSaleToolStripMenuItem;
        private ToolStripMenuItem adminstrateSalesToolStripMenuItem;
        private ToolStripMenuItem addANewUserToolStripMenuItem;
        private ToolStripMenuItem adminstrateUsersToolStripMenuItem;
        public ToolStripMenuItem createAnotherEditionToolStripMenuItem;
        public ToolStripMenuItem restorePreservedEditonToolStripMenuItem;
        public ToolStripMenuItem productsToolStripMenuItem;
        public ToolStripMenuItem clientsToolStripMenuItem;
        public ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem connectToTheServerToolStripMenuItem;
    }
}