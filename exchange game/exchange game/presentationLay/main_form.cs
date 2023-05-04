using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace exchange_game.presentationLay
{
    public partial class main_form : Form
    {
        
        private static main_form frm ;

        //public static void frm_formClose(object sender, FormClosedEventArgs e) {
        //    frm = null;
        //}

        //public static string set_in_id(string param)
        //{
        //    String X = param;

        //    return X;
        //}
        
        public static main_form get_main_form {
            get {

                if (frm == null) {
                    frm=new main_form();

            }
                return frm;
            }
        }

        
        public main_form()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this; // to control and enable change in it from another form
            }

         
            this.tasks_menu.Enabled = false;
            this.help_menu.Enabled = false;
            this.update_your_info.Enabled = false;
            this.issuersInDSEToolStripMenuItem.Enabled = false;
            this.tradingOrderToolStripMenuItem.Enabled = false;
        }


      

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_login log = new Form_login();
            log.ShowDialog();
            //string user = Form_login.getform_login.uname_txt.Text;
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trading_order tr_o_frm = new trading_order();
            tr_o_frm.ShowDialog();
        }

        private void showTradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_trades sh_tr = new show_trades();
            sh_tr.ShowDialog();
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign_up_newMember si = new Sign_up_newMember();
            si.ShowDialog();
        }

        private void issuersInDSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuer_dispaly_form iss = new issuer_dispaly_form();
            iss.ShowDialog();
        }

        private void showSecurityshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_wallet_form wallet = new my_wallet_form();
            wallet.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tradingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            order_trades frm = new order_trades();
            frm.ShowDialog();
        }

     
      

   

      

      

        

     

     

      

      

      
    }
}
