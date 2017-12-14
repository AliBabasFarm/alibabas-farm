namespace AliBabasFarmDesktop
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageManageOrders = new System.Windows.Forms.TabPage();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listViewManageOrders = new System.Windows.Forms.ListView();
            this.tabPageOrderHistory = new System.Windows.Forms.TabPage();
            this.listViewOrderHistory = new System.Windows.Forms.ListView();
            this.tabPageManageUsers = new System.Windows.Forms.TabPage();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.listViewManageUsers = new System.Windows.Forms.ListView();
            this.tabPageRouteDraw = new System.Windows.Forms.TabPage();
            this.buttonDrawRoute = new System.Windows.Forms.Button();
            this.listViewRouteDraw = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageManageOrders.SuspendLayout();
            this.tabPageOrderHistory.SuspendLayout();
            this.tabPageManageUsers.SuspendLayout();
            this.tabPageRouteDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageManageOrders);
            this.tabControl.Controls.Add(this.tabPageOrderHistory);
            this.tabControl.Controls.Add(this.tabPageManageUsers);
            this.tabControl.Controls.Add(this.tabPageRouteDraw);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(531, 381);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tabPageManageOrders
            // 
            this.tabPageManageOrders.Controls.Add(this.button2);
            this.tabPageManageOrders.Controls.Add(this.button1);
            this.tabPageManageOrders.Controls.Add(this.buttonConfirm);
            this.tabPageManageOrders.Controls.Add(this.listViewManageOrders);
            this.tabPageManageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageOrders.Name = "tabPageManageOrders";
            this.tabPageManageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageOrders.Size = new System.Drawing.Size(523, 355);
            this.tabPageManageOrders.TabIndex = 0;
            this.tabPageManageOrders.Text = "Manage Orders";
            this.tabPageManageOrders.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConfirm.Location = new System.Drawing.Point(0, 306);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(93, 49);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // listViewManageOrders
            // 
            this.listViewManageOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewManageOrders.Location = new System.Drawing.Point(0, 0);
            this.listViewManageOrders.Name = "listViewManageOrders";
            this.listViewManageOrders.Size = new System.Drawing.Size(523, 308);
            this.listViewManageOrders.TabIndex = 0;
            this.listViewManageOrders.UseCompatibleStateImageBehavior = false;
            this.listViewManageOrders.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewManageOrders_ColumnClick);
            // 
            // tabPageOrderHistory
            // 
            this.tabPageOrderHistory.Controls.Add(this.listViewOrderHistory);
            this.tabPageOrderHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderHistory.Name = "tabPageOrderHistory";
            this.tabPageOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderHistory.Size = new System.Drawing.Size(523, 355);
            this.tabPageOrderHistory.TabIndex = 1;
            this.tabPageOrderHistory.Text = "Order History";
            this.tabPageOrderHistory.UseVisualStyleBackColor = true;
            // 
            // listViewOrderHistory
            // 
            this.listViewOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrderHistory.Location = new System.Drawing.Point(0, 0);
            this.listViewOrderHistory.Name = "listViewOrderHistory";
            this.listViewOrderHistory.Size = new System.Drawing.Size(530, 355);
            this.listViewOrderHistory.TabIndex = 0;
            this.listViewOrderHistory.UseCompatibleStateImageBehavior = false;
            this.listViewOrderHistory.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewOrderHistory_ColumnClick);
            // 
            // tabPageManageUsers
            // 
            this.tabPageManageUsers.Controls.Add(this.buttonUpdateUser);
            this.tabPageManageUsers.Controls.Add(this.buttonRemoveUser);
            this.tabPageManageUsers.Controls.Add(this.buttonAddUser);
            this.tabPageManageUsers.Controls.Add(this.listViewManageUsers);
            this.tabPageManageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageManageUsers.Name = "tabPageManageUsers";
            this.tabPageManageUsers.Size = new System.Drawing.Size(523, 355);
            this.tabPageManageUsers.TabIndex = 2;
            this.tabPageManageUsers.Text = "Manage Users";
            this.tabPageManageUsers.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUpdateUser.Location = new System.Drawing.Point(96, 308);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(109, 47);
            this.buttonUpdateUser.TabIndex = 3;
            this.buttonUpdateUser.Text = "Update User";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRemoveUser.Location = new System.Drawing.Point(204, 308);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(108, 47);
            this.buttonRemoveUser.TabIndex = 2;
            this.buttonRemoveUser.Text = "Remove User";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddUser.Location = new System.Drawing.Point(0, 308);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(97, 47);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // listViewManageUsers
            // 
            this.listViewManageUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewManageUsers.Location = new System.Drawing.Point(0, 0);
            this.listViewManageUsers.Name = "listViewManageUsers";
            this.listViewManageUsers.Size = new System.Drawing.Size(527, 308);
            this.listViewManageUsers.TabIndex = 0;
            this.listViewManageUsers.UseCompatibleStateImageBehavior = false;
            this.listViewManageUsers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewManageUsers_ColumnClick);
            // 
            // tabPageRouteDraw
            // 
            this.tabPageRouteDraw.Controls.Add(this.buttonDrawRoute);
            this.tabPageRouteDraw.Controls.Add(this.listViewRouteDraw);
            this.tabPageRouteDraw.Location = new System.Drawing.Point(4, 22);
            this.tabPageRouteDraw.Name = "tabPageRouteDraw";
            this.tabPageRouteDraw.Size = new System.Drawing.Size(523, 355);
            this.tabPageRouteDraw.TabIndex = 3;
            this.tabPageRouteDraw.Text = "Route Draw";
            this.tabPageRouteDraw.UseVisualStyleBackColor = true;
            // 
            // buttonDrawRoute
            // 
            this.buttonDrawRoute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDrawRoute.Location = new System.Drawing.Point(0, 313);
            this.buttonDrawRoute.Name = "buttonDrawRoute";
            this.buttonDrawRoute.Size = new System.Drawing.Size(100, 42);
            this.buttonDrawRoute.TabIndex = 1;
            this.buttonDrawRoute.Text = "Draw Route";
            this.buttonDrawRoute.UseVisualStyleBackColor = true;
            this.buttonDrawRoute.Click += new System.EventHandler(this.buttonDrawRoute_Click);
            // 
            // listViewRouteDraw
            // 
            this.listViewRouteDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRouteDraw.Location = new System.Drawing.Point(0, 0);
            this.listViewRouteDraw.Name = "listViewRouteDraw";
            this.listViewRouteDraw.Size = new System.Drawing.Size(527, 314);
            this.listViewRouteDraw.TabIndex = 0;
            this.listViewRouteDraw.UseCompatibleStateImageBehavior = false;
            this.listViewRouteDraw.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewRouteDraw_ColumnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSelectAllMO_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Deselect All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDeselectAllMO_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 378);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageManageOrders.ResumeLayout(false);
            this.tabPageOrderHistory.ResumeLayout(false);
            this.tabPageManageUsers.ResumeLayout(false);
            this.tabPageRouteDraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageManageOrders;
        private System.Windows.Forms.TabPage tabPageOrderHistory;
        private System.Windows.Forms.TabPage tabPageManageUsers;
        private System.Windows.Forms.TabPage tabPageRouteDraw;
        private System.Windows.Forms.ListView listViewManageOrders;
        private System.Windows.Forms.ListView listViewOrderHistory;
        private System.Windows.Forms.ListView listViewManageUsers;
        private System.Windows.Forms.ListView listViewRouteDraw;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDrawRoute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}