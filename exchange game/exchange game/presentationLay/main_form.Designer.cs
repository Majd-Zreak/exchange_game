namespace exchange_game.presentationLay
{
    partial class main_form
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
            this.user_info = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.update_your_info = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasks_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSecurityshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issuersInDSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradingOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_label = new System.Windows.Forms.Label();
            this.hellow_label = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_info
            // 
            this.user_info.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1,
            this.loginToolStripMenuItem,
            this.update_your_info,
            this.createNewAccountToolStripMenuItem});
            this.user_info.Name = "user_info";
            this.user_info.Size = new System.Drawing.Size(77, 20);
            this.user_info.Text = "User info";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.loginToolStripMenuItem1.Text = "log_in";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.loginToolStripMenuItem.Text = "log_out";
            // 
            // update_your_info
            // 
            this.update_your_info.Name = "update_your_info";
            this.update_your_info.Size = new System.Drawing.Size(198, 22);
            this.update_your_info.Text = "update your info";
            // 
            // createNewAccountToolStripMenuItem
            // 
            this.createNewAccountToolStripMenuItem.Name = "createNewAccountToolStripMenuItem";
            this.createNewAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.createNewAccountToolStripMenuItem.Text = "create new account";
            this.createNewAccountToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountToolStripMenuItem_Click);
            // 
            // tasks_menu
            // 
            this.tasks_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.showTradesToolStripMenuItem,
            this.showSecurityshToolStripMenuItem});
            this.tasks_menu.Name = "tasks_menu";
            this.tasks_menu.Size = new System.Drawing.Size(56, 20);
            this.tasks_menu.Text = "Tasks";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.createOrderToolStripMenuItem.Text = "trading order";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // showTradesToolStripMenuItem
            // 
            this.showTradesToolStripMenuItem.Name = "showTradesToolStripMenuItem";
            this.showTradesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showTradesToolStripMenuItem.Text = "show the trades";
            this.showTradesToolStripMenuItem.Click += new System.EventHandler(this.showTradesToolStripMenuItem_Click);
            // 
            // showSecurityshToolStripMenuItem
            // 
            this.showSecurityshToolStripMenuItem.Name = "showSecurityshToolStripMenuItem";
            this.showSecurityshToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.showSecurityshToolStripMenuItem.Text = "my wallet";
            this.showSecurityshToolStripMenuItem.Click += new System.EventHandler(this.showSecurityshToolStripMenuItem_Click);
            // 
            // help_menu
            // 
            this.help_menu.Name = "help_menu";
            this.help_menu.Size = new System.Drawing.Size(49, 20);
            this.help_menu.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_info,
            this.tasks_menu,
            this.issuersInDSEToolStripMenuItem,
            this.tradingOrderToolStripMenuItem,
            this.help_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issuersInDSEToolStripMenuItem
            // 
            this.issuersInDSEToolStripMenuItem.Name = "issuersInDSEToolStripMenuItem";
            this.issuersInDSEToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.issuersInDSEToolStripMenuItem.Text = "Issuers in DSE";
            this.issuersInDSEToolStripMenuItem.Click += new System.EventHandler(this.issuersInDSEToolStripMenuItem_Click);
            // 
            // tradingOrderToolStripMenuItem
            // 
            this.tradingOrderToolStripMenuItem.Name = "tradingOrderToolStripMenuItem";
            this.tradingOrderToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.tradingOrderToolStripMenuItem.Text = "Trading Order";
            this.tradingOrderToolStripMenuItem.Click += new System.EventHandler(this.tradingOrderToolStripMenuItem_Click);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(659, 24);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(0, 15);
            this.user_label.TabIndex = 1;
            this.user_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_label.Visible = false;
            // 
            // hellow_label
            // 
            this.hellow_label.AutoSize = true;
            this.hellow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellow_label.Location = new System.Drawing.Point(569, 24);
            this.hellow_label.Name = "hellow_label";
            this.hellow_label.Size = new System.Drawing.Size(73, 16);
            this.hellow_label.TabIndex = 2;
            this.hellow_label.Text = "welcome:";
            this.hellow_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hellow_label.Visible = false;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(649, 364);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // main_form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.hellow_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(752, 437);
            this.MinimumSize = new System.Drawing.Size(752, 437);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem user_info;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tasks_menu;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSecurityshToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem help_menu;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem update_your_info;
        public System.Windows.Forms.ToolStripMenuItem issuersInDSEToolStripMenuItem;
        public System.Windows.Forms.Label user_label;
        public System.Windows.Forms.Label hellow_label;
        public System.Windows.Forms.Button cancel;
        public System.Windows.Forms.ToolStripMenuItem tradingOrderToolStripMenuItem;

    }
}