using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exchange_game.presentationLay
{
    public partial class issuer_dispaly_form : Form
    {
        businessLay.Cls_show_trades show = new exchange_game.businessLay.Cls_show_trades();
        public issuer_dispaly_form()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = show.get_all_issuer();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = show.search_issuer(search_txt.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void issuer_dispaly_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dse3DataSet4.issuers' table. You can move, or remove it, as needed.
            this.issuersTableAdapter.Fill(this.dse3DataSet4.issuers);

        }

       
    }
}
