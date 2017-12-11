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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDeselectAllMO = new System.Windows.Forms.Button();
            this.buttonSelectAllMO = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listViewManageOrders = new System.Windows.Forms.ListView();
            this.tabPageOrderHistory = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listViewOrderHistory = new System.Windows.Forms.ListView();
            this.tabPageManageUsers = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.listViewManageUsers = new System.Windows.Forms.ListView();
            this.tabPageRouteDraw = new System.Windows.Forms.TabPage();
            this.buttonDeselectAllRD = new System.Windows.Forms.Button();
            this.buttonSelectAllRD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabPageManageOrders.Controls.Add(this.button1);
            this.tabPageManageOrders.Controls.Add(this.textBox2);
            this.tabPageManageOrders.Controls.Add(this.buttonDeselectAllMO);
            this.tabPageManageOrders.Controls.Add(this.buttonSelectAllMO);
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
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(391, 321);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 4;
            // 
            // buttonDeselectAllMO
            // 
            this.buttonDeselectAllMO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeselectAllMO.Location = new System.Drawing.Point(195, 306);
            this.buttonDeselectAllMO.Name = "buttonDeselectAllMO";
            this.buttonDeselectAllMO.Size = new System.Drawing.Size(100, 49);
            this.buttonDeselectAllMO.TabIndex = 3;
            this.buttonDeselectAllMO.Text = "Deselect All";
            this.buttonDeselectAllMO.UseVisualStyleBackColor = true;
            this.buttonDeselectAllMO.Click += new System.EventHandler(this.buttonDeselectAllMO_Click);
            // 
            // buttonSelectAllMO
            // 
            this.buttonSelectAllMO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSelectAllMO.Location = new System.Drawing.Point(91, 306);
            this.buttonSelectAllMO.Name = "buttonSelectAllMO";
            this.buttonSelectAllMO.Size = new System.Drawing.Size(106, 49);
            this.buttonSelectAllMO.TabIndex = 2;
            this.buttonSelectAllMO.Text = "Select All";
            this.buttonSelectAllMO.UseVisualStyleBackColor = true;
            this.buttonSelectAllMO.Click += new System.EventHandler(this.buttonSelectAllMO_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConfirm.Location = new System.Drawing.Point(0, 306);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(92, 49);
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
            // 
            // tabPageOrderHistory
            // 
            this.tabPageOrderHistory.Controls.Add(this.button2);
            this.tabPageOrderHistory.Controls.Add(this.textBox4);
            this.tabPageOrderHistory.Controls.Add(this.listViewOrderHistory);
            this.tabPageOrderHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderHistory.Name = "tabPageOrderHistory";
            this.tabPageOrderHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderHistory.Size = new System.Drawing.Size(523, 355);
            this.tabPageOrderHistory.TabIndex = 1;
            this.tabPageOrderHistory.Text = "Order History";
            this.tabPageOrderHistory.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox4.Location = new System.Drawing.Point(385, 327);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 1;
            // 
            // listViewOrderHistory
            // 
            this.listViewOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrderHistory.Location = new System.Drawing.Point(0, 0);
            this.listViewOrderHistory.Name = "listViewOrderHistory";
            this.listViewOrderHistory.Size = new System.Drawing.Size(530, 319);
            this.listViewOrderHistory.TabIndex = 0;
            this.listViewOrderHistory.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageManageUsers
            // 
            this.tabPageManageUsers.Controls.Add(this.textBox3);
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
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox3.Location = new System.Drawing.Point(412, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 4;
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
            // 
            // tabPageRouteDraw
            // 
            this.tabPageRouteDraw.Controls.Add(this.buttonDeselectAllRD);
            this.tabPageRouteDraw.Controls.Add(this.buttonSelectAllRD);
            this.tabPageRouteDraw.Controls.Add(this.textBox1);
            this.tabPageRouteDraw.Controls.Add(this.buttonDrawRoute);
            this.tabPageRouteDraw.Controls.Add(this.listViewRouteDraw);
            this.tabPageRouteDraw.Location = new System.Drawing.Point(4, 22);
            this.tabPageRouteDraw.Name = "tabPageRouteDraw";
            this.tabPageRouteDraw.Size = new System.Drawing.Size(523, 355);
            this.tabPageRouteDraw.TabIndex = 3;
            this.tabPageRouteDraw.Text = "Route Draw";
            this.tabPageRouteDraw.UseVisualStyleBackColor = true;
            // 
            // buttonDeselectAllRD
            // 
            this.buttonDeselectAllRD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeselectAllRD.Location = new System.Drawing.Point(206, 313);
            this.buttonDeselectAllRD.Name = "buttonDeselectAllRD";
            this.buttonDeselectAllRD.Size = new System.Drawing.Size(113, 42);
            this.buttonDeselectAllRD.TabIndex = 4;
            this.buttonDeselectAllRD.Text = "Deselect All";
            this.buttonDeselectAllRD.UseVisualStyleBackColor = true;
            this.buttonDeselectAllRD.Click += new System.EventHandler(this.buttonDeselectAllRD_Click);
            // 
            // buttonSelectAllRD
            // 
            this.buttonSelectAllRD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSelectAllRD.Location = new System.Drawing.Point(106, 313);
            this.buttonSelectAllRD.Name = "buttonSelectAllRD";
            this.buttonSelectAllRD.Size = new System.Drawing.Size(101, 42);
            this.buttonSelectAllRD.TabIndex = 3;
            this.buttonSelectAllRD.Text = "Select All";
            this.buttonSelectAllRD.UseVisualStyleBackColor = true;
            this.buttonSelectAllRD.Click += new System.EventHandler(this.buttonSelectAllRD_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(422, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonDrawRoute
            // 
            this.buttonDrawRoute.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDrawRoute.Location = new System.Drawing.Point(0, 313);
            this.buttonDrawRoute.Name = "buttonDrawRoute";
            this.buttonDrawRoute.Size = new System.Drawing.Size(107, 42);
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
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(293, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(1, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tabPageManageOrders.PerformLayout();
            this.tabPageOrderHistory.ResumeLayout(false);
            this.tabPageOrderHistory.PerformLayout();
            this.tabPageManageUsers.ResumeLayout(false);
            this.tabPageManageUsers.PerformLayout();
            this.tabPageRouteDraw.ResumeLayout(false);
            this.tabPageRouteDraw.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDeselectAllMO;
        private System.Windows.Forms.Button buttonSelectAllMO;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDrawRoute;
        private System.Windows.Forms.Button buttonDeselectAllRD;
        private System.Windows.Forms.Button buttonSelectAllRD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}