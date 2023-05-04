namespace exchange_game.presentationLay
{
    partial class userName_signIn_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.yes = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.yes);
            this.groupBox1.Controls.Add(this.password_txt);
            this.groupBox1.Controls.Add(this.userName_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "build your username and your password";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(212, 110);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(131, 110);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 23);
            this.yes.TabIndex = 2;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(126, 54);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(100, 20);
            this.password_txt.TabIndex = 1;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(126, 28);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(100, 20);
            this.userName_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New UserName";
            // 
            // userName_signIn_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 156);
            this.Controls.Add(this.groupBox1);
            this.Name = "userName_signIn_form";
            this.Text = " Sing_in Info";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button yes;
    }
}