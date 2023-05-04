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
    public partial class show_trades : Form
    {
        businessLay.Cls_show_trades show_trade = new exchange_game.businessLay.Cls_show_trades();
        public show_trades()
        {
            InitializeComponent();
            show_trades_data_grid.DataSource = show_trade.get_all_trades();
            

        }

        private void canceled_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
