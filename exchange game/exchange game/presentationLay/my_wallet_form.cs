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
    public partial class my_wallet_form : Form
    {
        businessLay.Cls_show_trades show = new exchange_game.businessLay.Cls_show_trades();

        public my_wallet_form()
        {
            InitializeComponent();
            string user_name = main_form.get_main_form.user_label.Text;
            DataTable dt=new DataTable();
            dt=show.get_sec_h_for_user(user_name);
            this.dataGridView1.DataSource = dt;
        }

   
        
    }
}
