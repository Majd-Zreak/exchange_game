namespace exchange_game.presentationLay
{
    partial class issuer_dispaly_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.dse3DataSet4 = new exchange_game.dse3DataSet4();
            this.issuersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuersTableAdapter = new exchange_game.dse3DataSet4TableAdapters.issuersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(462, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(118, 21);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(181, 20);
            this.search_txt.TabIndex = 3;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(399, 215);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "cansel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // dse3DataSet4
            // 
            this.dse3DataSet4.DataSetName = "dse3DataSet4";
            this.dse3DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuersBindingSource
            // 
            this.issuersBindingSource.DataMember = "issuers";
            this.issuersBindingSource.DataSource = this.dse3DataSet4;
            // 
            // issuersTableAdapter
            // 
            this.issuersTableAdapter.ClearBeforeFill = true;
            // 
            // issuer_dispaly_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(483, 246);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancel_btn);
            this.MaximumSize = new System.Drawing.Size(499, 284);
            this.MinimumSize = new System.Drawing.Size(499, 284);
            this.Name = "issuer_dispaly_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "issuer_dispaly_form";
            this.Load += new System.EventHandler(this.issuer_dispaly_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dse3DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.TextBox search_txt;
        private dse3DataSet4 dse3DataSet4;
        private System.Windows.Forms.BindingSource issuersBindingSource;
        private exchange_game.dse3DataSet4TableAdapters.issuersTableAdapter issuersTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}