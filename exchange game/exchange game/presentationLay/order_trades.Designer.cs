namespace exchange_game.presentationLay
{
    partial class order_trades
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.typ_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invester_name_txtBox = new System.Windows.Forms.TextBox();
            this.trading_order_groupbox = new System.Windows.Forms.GroupBox();
            this.quan_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.order_type_label = new System.Windows.Forms.Label();
            this.account_label = new System.Windows.Forms.Label();
            this.invester_name_label = new System.Windows.Forms.Label();
            this.quan_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.broker_comboBox = new System.Windows.Forms.ComboBox();
            this.securitys_comboBox = new System.Windows.Forms.ComboBox();
            this.account_no_comboBox = new System.Windows.Forms.ComboBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.trading_order_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(382, 326);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // typ_comboBox
            // 
            this.typ_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typ_comboBox.FormattingEnabled = true;
            this.typ_comboBox.Items.AddRange(new object[] {
            "Sell",
            "Buy"});
            this.typ_comboBox.Location = new System.Drawing.Point(95, 98);
            this.typ_comboBox.Name = "typ_comboBox";
            this.typ_comboBox.Size = new System.Drawing.Size(121, 21);
            this.typ_comboBox.TabIndex = 1;
            this.typ_comboBox.SelectedIndexChanged += new System.EventHandler(this.typ_comboBox_SelectedIndexChanged);
            this.typ_comboBox.Validated += new System.EventHandler(this.typ_comboBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trading_Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invester_name_txtBox
            // 
            this.invester_name_txtBox.Location = new System.Drawing.Point(95, 27);
            this.invester_name_txtBox.Name = "invester_name_txtBox";
            this.invester_name_txtBox.ReadOnly = true;
            this.invester_name_txtBox.Size = new System.Drawing.Size(121, 20);
            this.invester_name_txtBox.TabIndex = 4;
            this.invester_name_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trading_order_groupbox
            // 
            this.trading_order_groupbox.Controls.Add(this.quan_label);
            this.trading_order_groupbox.Controls.Add(this.label5);
            this.trading_order_groupbox.Controls.Add(this.label4);
            this.trading_order_groupbox.Controls.Add(this.label3);
            this.trading_order_groupbox.Controls.Add(this.label2);
            this.trading_order_groupbox.Controls.Add(this.order_type_label);
            this.trading_order_groupbox.Controls.Add(this.account_label);
            this.trading_order_groupbox.Controls.Add(this.invester_name_label);
            this.trading_order_groupbox.Controls.Add(this.quan_textBox);
            this.trading_order_groupbox.Controls.Add(this.price_textBox);
            this.trading_order_groupbox.Controls.Add(this.invester_name_txtBox);
            this.trading_order_groupbox.Controls.Add(this.broker_comboBox);
            this.trading_order_groupbox.Controls.Add(this.securitys_comboBox);
            this.trading_order_groupbox.Controls.Add(this.account_no_comboBox);
            this.trading_order_groupbox.Controls.Add(this.typ_comboBox);
            this.trading_order_groupbox.Location = new System.Drawing.Point(3, 25);
            this.trading_order_groupbox.Name = "trading_order_groupbox";
            this.trading_order_groupbox.Size = new System.Drawing.Size(465, 295);
            this.trading_order_groupbox.TabIndex = 5;
            this.trading_order_groupbox.TabStop = false;
            this.trading_order_groupbox.Text = "please enter this info";
            // 
            // quan_label
            // 
            this.quan_label.AutoSize = true;
            this.quan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan_label.Location = new System.Drawing.Point(222, 140);
            this.quan_label.Name = "quan_label";
            this.quan_label.Size = new System.Drawing.Size(0, 15);
            this.quan_label.TabIndex = 6;
            this.quan_label.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Broker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "security price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Securitys";
            // 
            // order_type_label
            // 
            this.order_type_label.AutoSize = true;
            this.order_type_label.Location = new System.Drawing.Point(16, 101);
            this.order_type_label.Name = "order_type_label";
            this.order_type_label.Size = new System.Drawing.Size(59, 13);
            this.order_type_label.TabIndex = 5;
            this.order_type_label.Text = "Order_type";
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(16, 66);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(64, 13);
            this.account_label.TabIndex = 5;
            this.account_label.Text = "account_no";
            // 
            // invester_name_label
            // 
            this.invester_name_label.AutoSize = true;
            this.invester_name_label.Location = new System.Drawing.Point(16, 30);
            this.invester_name_label.Name = "invester_name_label";
            this.invester_name_label.Size = new System.Drawing.Size(76, 13);
            this.invester_name_label.TabIndex = 5;
            this.invester_name_label.Text = "invester_name";
            // 
            // quan_textBox
            // 
            this.quan_textBox.Location = new System.Drawing.Point(95, 212);
            this.quan_textBox.Name = "quan_textBox";
            this.quan_textBox.Size = new System.Drawing.Size(121, 20);
            this.quan_textBox.TabIndex = 4;
            this.quan_textBox.Validated += new System.EventHandler(this.quan_textBox_Validated);
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(95, 177);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(121, 20);
            this.price_textBox.TabIndex = 4;
            // 
            // broker_comboBox
            // 
            this.broker_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.broker_comboBox.FormattingEnabled = true;
            this.broker_comboBox.Location = new System.Drawing.Point(95, 245);
            this.broker_comboBox.Name = "broker_comboBox";
            this.broker_comboBox.Size = new System.Drawing.Size(121, 21);
            this.broker_comboBox.TabIndex = 1;
            // 
            // securitys_comboBox
            // 
            this.securitys_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.securitys_comboBox.FormattingEnabled = true;
            this.securitys_comboBox.Location = new System.Drawing.Point(95, 139);
            this.securitys_comboBox.Name = "securitys_comboBox";
            this.securitys_comboBox.Size = new System.Drawing.Size(121, 21);
            this.securitys_comboBox.TabIndex = 1;
            this.securitys_comboBox.Validated += new System.EventHandler(this.securitys_comboBox_Validated);
            // 
            // account_no_comboBox
            // 
            this.account_no_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.account_no_comboBox.FormattingEnabled = true;
            this.account_no_comboBox.Location = new System.Drawing.Point(95, 63);
            this.account_no_comboBox.Name = "account_no_comboBox";
            this.account_no_comboBox.Size = new System.Drawing.Size(121, 21);
            this.account_no_comboBox.TabIndex = 1;
            this.account_no_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.account_no_comboBox_Validating);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(301, 326);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // order_trades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(469, 361);
            this.Controls.Add(this.trading_order_groupbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.cancel_btn);
            this.MaximumSize = new System.Drawing.Size(485, 399);
            this.MinimumSize = new System.Drawing.Size(485, 399);
            this.Name = "order_trades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "order_trades";
            this.trading_order_groupbox.ResumeLayout(false);
            this.trading_order_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox trading_order_groupbox;
        private System.Windows.Forms.Label invester_name_label;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label order_type_label;
        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label quan_label;
        public System.Windows.Forms.ComboBox typ_comboBox;
        public System.Windows.Forms.TextBox invester_name_txtBox;
        public System.Windows.Forms.ComboBox securitys_comboBox;
        public System.Windows.Forms.TextBox price_textBox;
        public System.Windows.Forms.TextBox quan_textBox;
        public System.Windows.Forms.ComboBox broker_comboBox;
        public System.Windows.Forms.ComboBox account_no_comboBox;
    }
}