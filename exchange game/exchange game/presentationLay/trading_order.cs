using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace exchange_game.presentationLay
{
    public partial class trading_order : Form
    {
        businessLay.Cls_trading_order tr_o = new businessLay.Cls_trading_order();

        public trading_order()
        {
            InitializeComponent();




            //DataTable dt = new DataTable();
            //dt=tr_o.get_all_acc();
            //foreach(DataRow d in dt.Rows){
            //    acc_combobox.Items.Add(d.ToString()); 
            //}
            //acc_comboBox.ValueMember="acc_id" ;
            //acc_comboBox.Text="f_name" ;

        }




        private void trading_order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dse3DataSet3.get_all_sec' table. You can move, or remove it, as needed.
            this.get_all_secTableAdapter.Fill(this.dse3DataSet3.get_all_sec);
            // TODO: This line of code loads data into the 'dse3DataSet1.get_all_acc' table. You can move, or remove it, as needed.
            this.get_all_accTableAdapter.Fill(this.dse3DataSet1.get_all_acc);

        }



        private void acc_combobox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tr_o.add_order(Convert.ToInt32(acc_combobox.SelectedValue)
                    , order_typ_combobox.Text
                    , Convert.ToInt32(all_sec_combobox.SelectedValue)
                    , Convert.ToInt32(securitys_price.Text)
                    , Convert.ToInt32(quantity_txt.Text)
                    , Convert.ToInt32(broker_name_combobox.SelectedValue));
                MessageBox.Show("the order is saved  ");
                this.Close();
            }
            catch
            {
                MessageBox.Show("you have an error in the input");
            }

            //tr_o.add_order(acc_combobox.SelectedValue,Convert.ToInt32( order_typ_combobox.SelectedText), all_sec_combobox.SelectedValue,Convert.ToInt32( securitys_price.SelectedText),Convert.ToInt32( quantity_txt.SelectedText), broker_name_combobox.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tr_o.add_order(Convert.ToInt32(acc_combobox.SelectedValue)
                    , order_typ_combobox.Text
                    , Convert.ToInt32(all_sec_combobox.SelectedValue)
                    , Convert.ToInt32(securitys_price.Text)
                    , Convert.ToInt32(quantity_txt.Text)
                    , Convert.ToInt32(broker_name_combobox.SelectedValue));
                MessageBox.Show("the order is saved  ");

            }
            catch
            {
                MessageBox.Show("you have an error in the input");
            }
        }



        //display brokers name depending on account that selected
        private void acc_combobox_TextChanged(object sender, EventArgs e)
        {
            broker_name_combobox.DataSource = tr_o.get_broker(Convert.ToInt32(acc_combobox.SelectedValue));
            broker_name_combobox.DisplayMember = "name";
            broker_name_combobox.ValueMember = "br_id";
        }


        //display quan_label
        private void all_sec_combobox_Validated(object sender, EventArgs e)
        {
            if (order_typ_combobox.Text == "sell")
            {
                DataTable dt = new DataTable();
                dt = tr_o.get_quan_sec_h(Convert.ToInt32(acc_combobox.SelectedValue)
                     , Convert.ToInt32(all_sec_combobox.SelectedValue));


                label_quan.Visible = true;

                foreach (DataRow dr in dt.Rows)
                {
                    var item = dr.ItemArray[0];
                    label_quan.Text = "quan:" + item.ToString();
                }

            }


            else
            {
                label_quan.Visible = false;
            }
        }

        //display securitys after order typ selected
        private void order_typ_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (order_typ_combobox.Text == "sell")
            {
                all_sec_combobox.DataSource = tr_o.get_sec_sell(Convert.ToInt32(acc_combobox.SelectedValue));
                all_sec_combobox.DisplayMember = "name";
                all_sec_combobox.ValueMember = "sec_id";

            }
            else
            {
                all_sec_combobox.DataSource = tr_o.get_all_securitys();
                all_sec_combobox.DisplayMember = "name";
                all_sec_combobox.ValueMember = "sec_id";

                label_quan.Visible = false;
            }
        }

        private void quantity_txt_Validating(object sender, CancelEventArgs e)
        {
            if (order_typ_combobox.Text == "sell")
            {
                DataTable dt = new DataTable();
                dt = tr_o.get_quan_sec_h(Convert.ToInt32(acc_combobox.SelectedValue)
                     , Convert.ToInt32(all_sec_combobox.SelectedValue));

                foreach (DataRow dr in dt.Rows)
                {
                    var item = dr.ItemArray[0];

                    if (Convert.ToInt32(quantity_txt.Text) > Convert.ToInt32(item.ToString()))
                    {
                        MessageBox.Show("quan that you have is less than the enterd value");
                        quantity_txt.Focus();
                        quantity_txt.SelectionStart = 0;
                        quantity_txt.SelectionLength = quantity_txt.TextLength;
                        
                    }


                }

            }

        }
    }
}

