namespace exchange_game.presentationLay
{
    partial class Form_login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uname_txt = new System.Windows.Forms.TextBox();
            this.U_name_label = new System.Windows.Forms.Label();
            this.psw_label = new System.Windows.Forms.Label();
            this.psw_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(454, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "welcome in login form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uname_txt
            // 
            this.uname_txt.Location = new System.Drawing.Point(97, 39);
            this.uname_txt.Name = "uname_txt";
            this.uname_txt.Size = new System.Drawing.Size(100, 20);
            this.uname_txt.TabIndex = 1;
            // 
            // U_name_label
            // 
            this.U_name_label.AutoSize = true;
            this.U_name_label.Location = new System.Drawing.Point(30, 39);
            this.U_name_label.Name = "U_name_label";
            this.U_name_label.Size = new System.Drawing.Size(61, 13);
            this.U_name_label.TabIndex = 1;
            this.U_name_label.Text = "User_name";
            // 
            // psw_label
            // 
            this.psw_label.AutoSize = true;
            this.psw_label.Location = new System.Drawing.Point(30, 64);
            this.psw_label.Name = "psw_label";
            this.psw_label.Size = new System.Drawing.Size(52, 13);
            this.psw_label.TabIndex = 1;
            this.psw_label.Text = "password";
            this.psw_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // psw_txt
            // 
            this.psw_txt.AcceptsTab = true;
            this.psw_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.psw_txt.Location = new System.Drawing.Point(97, 64);
            this.psw_txt.MaxLength = 8;
            this.psw_txt.Name = "psw_txt";
            this.psw_txt.PasswordChar = '$';
            this.psw_txt.Size = new System.Drawing.Size(100, 20);
            this.psw_txt.TabIndex = 2;
            // 
            // login_btn
            // 
            this.login_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Location = new System.Drawing.Point(97, 105);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(84, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "logIn";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sign_up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "new member !";
            // 
            // Form_login
            // 
            this.AcceptButton = this.login_btn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(534, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.psw_txt);
            this.Controls.Add(this.uname_txt);
            this.Controls.Add(this.psw_label);
            this.Controls.Add(this.U_name_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label psw_label;
        public System.Windows.Forms.Label U_name_label;
        public System.Windows.Forms.TextBox uname_txt;
        public System.Windows.Forms.Button login_btn;
        public System.Windows.Forms.TextBox psw_txt;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label2;
    }
}