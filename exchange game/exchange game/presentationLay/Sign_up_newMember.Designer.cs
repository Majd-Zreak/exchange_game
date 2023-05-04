namespace exchange_game.presentationLay
{
    partial class Sign_up_newMember
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
            this.sign_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.First_name_txt = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.age_txt = new System.Windows.Forms.DateTimePicker();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.Last_name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            this.sign_in.Location = new System.Drawing.Point(122, 192);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(75, 23);
            this.sign_in.TabIndex = 0;
            this.sign_in.Text = "Sign_up";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // First_name_txt
            // 
            this.First_name_txt.Location = new System.Drawing.Point(87, 19);
            this.First_name_txt.Name = "First_name_txt";
            this.First_name_txt.Size = new System.Drawing.Size(100, 20);
            this.First_name_txt.TabIndex = 2;
            this.First_name_txt.Validated += new System.EventHandler(this.First_name_txt_Validated);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(203, 192);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.age_txt);
            this.groupBox1.Controls.Add(this.Phone_txt);
            this.groupBox1.Controls.Add(this.Last_name_txt);
            this.groupBox1.Controls.Add(this.First_name_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter your Info";
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(87, 83);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(100, 20);
            this.age_txt.TabIndex = 3;
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(87, 111);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(100, 20);
            this.Phone_txt.TabIndex = 2;
            // 
            // Last_name_txt
            // 
            this.Last_name_txt.Location = new System.Drawing.Point(87, 51);
            this.Last_name_txt.Name = "Last_name_txt";
            this.Last_name_txt.Size = new System.Drawing.Size(100, 20);
            this.Last_name_txt.TabIndex = 2;
            this.Last_name_txt.Validated += new System.EventHandler(this.Last_name_txt_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // Sign_up_newMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(282, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.sign_in);
            this.Name = "Sign_up_newMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log_in_newMember";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Last_name_txt;
        public System.Windows.Forms.TextBox First_name_txt;
        public System.Windows.Forms.Button sign_in;
        public System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker age_txt;
        public System.Windows.Forms.TextBox Phone_txt;
    }
}