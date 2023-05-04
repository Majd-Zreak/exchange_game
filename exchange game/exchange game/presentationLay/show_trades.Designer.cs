namespace exchange_game.presentationLay
{
    partial class show_trades
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
            this.show_trades_data_grid = new System.Windows.Forms.DataGridView();
            this.canceled = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_trades_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.show_trades_data_grid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traded securities";
            // 
            // show_trades_data_grid
            // 
            this.show_trades_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_trades_data_grid.BackgroundColor = System.Drawing.Color.White;
            this.show_trades_data_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.show_trades_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_trades_data_grid.Location = new System.Drawing.Point(0, 22);
            this.show_trades_data_grid.Name = "show_trades_data_grid";
            this.show_trades_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.show_trades_data_grid.Size = new System.Drawing.Size(560, 221);
            this.show_trades_data_grid.TabIndex = 0;
            // 
            // canceled
            // 
            this.canceled.Location = new System.Drawing.Point(479, 330);
            this.canceled.Name = "canceled";
            this.canceled.Size = new System.Drawing.Size(75, 23);
            this.canceled.TabIndex = 1;
            this.canceled.Text = "OK";
            this.canceled.UseVisualStyleBackColor = true;
            this.canceled.Click += new System.EventHandler(this.canceled_Click);
            // 
            // show_trades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 365);
            this.Controls.Add(this.canceled);
            this.Controls.Add(this.groupBox1);
            this.Name = "show_trades";
            this.Text = "show_trades";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_trades_data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView show_trades_data_grid;
        private System.Windows.Forms.Button canceled;
    }
}