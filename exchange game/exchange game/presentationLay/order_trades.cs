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
    public partial class order_trades : Form
    {
        businessLay.Cls_trading_order tr_o = new exchange_game.businessLay.Cls_trading_order();
        businessLay.Cls_trading_order_on_invester tr = new exchange_game.businessLay.Cls_trading_order_on_invester();
        public order_trades()
        {
            InitializeComponent();

            string user = main_form.get_main_form.user_label.Text;
            DataTable dt = new DataTable();
            dt = tr.get_invester_on_username(user);  //return invester depending on username
            DataRow dr = dt.Rows[0];
            this.invester_name_txtBox.Text = dr[0].ToString();


            DataTable dtt = new DataTable();
            dtt = tr.get_acc_no_from_username(main_form.get_main_form.user_label.Text);
            this.account_no_comboBox.DataSource = dtt;
            this.account_no_comboBox.ValueMember = "acc_id";
            this.account_no_comboBox.DisplayMember = "acc_serial_no";
            //foreach(DataRow d in dt.Rows){
            //    acc_combobox.Items.Add(d.ToString()); 
            //}
            //acc_comboBox.ValueMember="acc_id" ;
            //acc_comboBox.Text="f_name" ;
        }

        //get only secyritys that account has it when the process is sell
        private void typ_comboBox_Validated(object sender, EventArgs e)
        {
            if (typ_comboBox.SelectedItem == "Sell")
            {
                DataTable dt = new DataTable();
                dt = tr_o.get_sec_sell(Convert.ToInt32(this.account_no_comboBox.SelectedValue));
                this.securitys_comboBox.DataSource = dt;
                this.securitys_comboBox.DisplayMember = "name";
                this.securitys_comboBox.ValueMember = "sec_id";
            }
            else {
                DataTable dt = new DataTable();
                dt = tr_o.get_all_securitys();
                this.securitys_comboBox.DataSource = dt;
                this.securitys_comboBox.ValueMember = "sec_id";
                this.securitys_comboBox.DisplayMember = "name";

                quan_label.Visible = false;
            }
        }

        private void securitys_comboBox_Validated(object sender, EventArgs e)
        {
            if (typ_comboBox.SelectedItem == "Sell")
            {
                DataTable dt = new DataTable();
                dt = tr_o.get_quan_sec_h(Convert.ToInt32(account_no_comboBox.SelectedValue)
                     , Convert.ToInt32(securitys_comboBox.SelectedValue));


                quan_label.Visible = true;

                foreach (DataRow dr in dt.Rows)
                {
                    var item = dr.ItemArray[0];
                    quan_label.Text = "quan:" + item.ToString();
                }

                
                
            }
            else
            {
                quan_label.Visible = false;
            }
        }

        private void account_no_comboBox_Validating(object sender, CancelEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = tr_o.get_all_securitys();
            this.securitys_comboBox.DataSource = dt;
            this.securitys_comboBox.ValueMember = "sec_id";
            this.securitys_comboBox.DisplayMember = "name";

            DataTable t = new DataTable();
            t = tr_o.get_broker(Convert.ToInt32(this.account_no_comboBox.SelectedValue));
            broker_comboBox.DataSource = t;
            this.broker_comboBox.DisplayMember = "name";
            this.broker_comboBox.ValueMember = "br_id";
        }

        private void quan_textBox_Validated(object sender, EventArgs e)
        {
            if (typ_comboBox.SelectedItem == "Sell")
            {
                DataTable dt = new DataTable();
                dt = tr_o.get_quan_sec_h(Convert.ToInt32(account_no_comboBox.SelectedValue)
                     , Convert.ToInt32(securitys_comboBox.SelectedValue));
                DataRow dr = dt.Rows[0];
                try
                {
                    if (Convert.ToInt32(quan_textBox.Text) > Convert.ToInt32(dr[0].ToString()))
                    {
                        MessageBox.Show("error.. you do not have this quantity");
                        this.quan_textBox.Focus();
                        this.quan_textBox.SelectionStart = 0;
                        this.quan_textBox.SelectionLength = quan_textBox.TextLength;


                    }
                }
                catch 
                {
                    MessageBox.Show("please inter the quantity");
                    this.quan_textBox.Focus();
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tr_o.add_order(Convert.ToInt32(account_no_comboBox.SelectedValue)
                    , typ_comboBox.Text
                    , Convert.ToInt32(securitys_comboBox.SelectedValue)
                    , Convert.ToInt32(price_textBox.Text)
                    , Convert.ToInt32(quan_textBox.Text)
                    , Convert.ToInt32(broker_comboBox.SelectedValue));
                MessageBox.Show("the order is saved  ");
                this.Close();
                show_trades show = new show_trades();
                show.ShowDialog();

            }
            catch
            {
                MessageBox.Show("you have an error in the input");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typ_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}
