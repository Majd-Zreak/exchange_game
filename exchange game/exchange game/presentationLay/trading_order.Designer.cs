namespace exchange_game.presentationLay
{
    partial class trading_order
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.order_typ_combobox = new System.Windows.Forms.ComboBox();
            this.all_sec_combobox = new System.Windows.Forms.ComboBox();
            this.getallsecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dse3DataSet3 = new exchange_game.dse3DataSet3();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.acc_combobox = new System.Windows.Forms.ComboBox();
            this.getallaccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dse3DataSet1 = new exchange_game.dse3DataSet1();
            this.securitys_price = new System.Windows.Forms.TextBox();
            this.get_all_accTableAdapter = new exchange_game.dse3DataSet1TableAdapters.get_all_accTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.broker_name_combobox = new System.Windows.Forms.ComboBox();
            this.getbrokerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dse3DataSet2 = new exchange_game.dse3DataSet2();
            this.get_brokerTableAdapter = new exchange_game.dse3DataSet2TableAdapters.get_brokerTableAdapter();
            this.get_all_secTableAdapter = new exchange_game.dse3DataSet3TableAdapters.get_all_secTableAdapter();
            this.label_quan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getallsecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallaccBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getbrokerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Typ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Secyritys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secyrity price";
            // 
            // order_typ_combobox
            // 
            this.order_typ_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_typ_combobox.FormattingEnabled = true;
            this.order_typ_combobox.Items.AddRange(new object[] {
            "sell",
            "buy"});
            this.order_typ_combobox.Location = new System.Drawing.Point(115, 89);
            this.order_typ_combobox.Name = "order_typ_combobox";
            this.order_typ_combobox.Size = new System.Drawing.Size(121, 21);
            this.order_typ_combobox.TabIndex = 6;
            this.order_typ_combobox.SelectedIndexChanged += new System.EventHandler(this.order_typ_combobox_SelectedIndexChanged);
            // 
            // all_sec_combobox
            // 
            this.all_sec_combobox.DataSource = this.getallsecBindingSource;
            this.all_sec_combobox.DisplayMember = "name";
            this.all_sec_combobox.FormattingEnabled = true;
            this.all_sec_combobox.Location = new System.Drawing.Point(114, 132);
            this.all_sec_combobox.Name = "all_sec_combobox";
            this.all_sec_combobox.Size = new System.Drawing.Size(121, 21);
            this.all_sec_combobox.TabIndex = 6;
            this.all_sec_combobox.ValueMember = "sec_id";
            this.all_sec_combobox.Validated += new System.EventHandler(this.all_sec_combobox_Validated);
            // 
            // getallsecBindingSource
            // 
            this.getallsecBindingSource.DataMember = "get_all_sec";
            this.getallsecBindingSource.DataSource = this.dse3DataSet3;
            // 
            // dse3DataSet3
            // 
            this.dse3DataSet3.DataSetName = "dse3DataSet3";
            this.dse3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Save and new";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(114, 215);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(121, 20);
            this.quantity_txt.TabIndex = 7;
            this.quantity_txt.Text = "0";
            this.quantity_txt.Validating += new System.ComponentModel.CancelEventHandler(this.quantity_txt_Validating);
            // 
            // acc_combobox
            // 
            this.acc_combobox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.acc_combobox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.acc_combobox.DataSource = this.getallaccBindingSource;
            this.acc_combobox.DisplayMember = "acc_serial_no";
            this.acc_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acc_combobox.FormattingEnabled = true;
            this.acc_combobox.Location = new System.Drawing.Point(114, 42);
            this.acc_combobox.Name = "acc_combobox";
            this.acc_combobox.Size = new System.Drawing.Size(290, 21);
            this.acc_combobox.TabIndex = 8;
            this.acc_combobox.UseWaitCursor = true;
            this.acc_combobox.ValueMember = "acc_id";
            this.acc_combobox.Validating += new System.ComponentModel.CancelEventHandler(this.acc_combobox_Validating);
            this.acc_combobox.TextChanged += new System.EventHandler(this.acc_combobox_TextChanged);
            // 
            // getallaccBindingSource
            // 
            this.getallaccBindingSource.DataMember = "get_all_acc";
            this.getallaccBindingSource.DataSource = this.dse3DataSet1;
            // 
            // dse3DataSet1
            // 
            this.dse3DataSet1.DataSetName = "dse3DataSet1";
            this.dse3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securitys_price
            // 
            this.securitys_price.Location = new System.Drawing.Point(115, 167);
            this.securitys_price.Name = "securitys_price";
            this.securitys_price.Size = new System.Drawing.Size(121, 20);
            this.securitys_price.TabIndex = 9;
            // 
            // get_all_accTableAdapter
            // 
            this.get_all_accTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "broker";
            // 
            // broker_name_combobox
            // 
            this.broker_name_combobox.DataSource = this.getbrokerBindingSource;
            this.broker_name_combobox.DisplayMember = "name";
            this.broker_name_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.broker_name_combobox.FormattingEnabled = true;
            this.broker_name_combobox.Location = new System.Drawing.Point(115, 264);
            this.broker_name_combobox.Name = "broker_name_combobox";
            this.broker_name_combobox.Size = new System.Drawing.Size(121, 21);
            this.broker_name_combobox.TabIndex = 6;
            this.broker_name_combobox.ValueMember = "br_id";
            // 
            // getbrokerBindingSource
            // 
            this.getbrokerBindingSource.DataMember = "get_broker";
            this.getbrokerBindingSource.DataSource = this.dse3DataSet2;
            // 
            // dse3DataSet2
            // 
            this.dse3DataSet2.DataSetName = "dse3DataSet2";
            this.dse3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_brokerTableAdapter
            // 
            this.get_brokerTableAdapter.ClearBeforeFill = true;
            // 
            // get_all_secTableAdapter
            // 
            this.get_all_secTableAdapter.ClearBeforeFill = true;
            // 
            // label_quan
            // 
            this.label_quan.AutoSize = true;
            this.label_quan.Location = new System.Drawing.Point(241, 132);
            this.label_quan.Name = "label_quan";
            this.label_quan.Size = new System.Drawing.Size(35, 13);
            this.label_quan.TabIndex = 10;
            this.label_quan.Text = "label7";
            this.label_quan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_quan.Visible = false;
            // 
            // trading_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 372);
            this.Controls.Add(this.label_quan);
            this.Controls.Add(this.securitys_price);
            this.Controls.Add(this.acc_combobox);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.broker_name_combobox);
            this.Controls.Add(this.all_sec_combobox);
            this.Controls.Add(this.order_typ_combobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "trading_order";
            this.Text = "trading_order";
            this.Load += new System.EventHandler(this.trading_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getallsecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallaccBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getbrokerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox acc_combobox;
        private dse3DataSet1 dse3DataSet1;
        private System.Windows.Forms.BindingSource getallaccBindingSource;
        private exchange_game.dse3DataSet1TableAdapters.get_all_accTableAdapter get_all_accTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource getbrokerBindingSource;
        private dse3DataSet2 dse3DataSet2;
        private exchange_game.dse3DataSet2TableAdapters.get_brokerTableAdapter get_brokerTableAdapter;
        private dse3DataSet3 dse3DataSet3;
        private System.Windows.Forms.BindingSource getallsecBindingSource;
        private exchange_game.dse3DataSet3TableAdapters.get_all_secTableAdapter get_all_secTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox order_typ_combobox;
        public System.Windows.Forms.ComboBox all_sec_combobox;
        public System.Windows.Forms.TextBox quantity_txt;
        public System.Windows.Forms.TextBox securitys_price;
        public System.Windows.Forms.ComboBox broker_name_combobox;
        public System.Windows.Forms.Label label_quan;
    }
}