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
    public partial class Form_login : Form

    {
        businessLay.Cls_Login log = new businessLay.Cls_Login();
        //dataAccessLay.dataAccessLay dal = new dataAccessLay.dataAccessLay();

        private static Form_login frm;


        public static Form_login getform_login
        {
            get
            {

                if (frm == null)
                {
                    frm = new Form_login();

                }
                return frm;
            }
        }


        public Form_login()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            dtb = log.login(uname_txt.Text, psw_txt.Text);
            if (dtb.Rows.Count > 0)
            {
                MessageBox.Show("Login seccess ! ");
                main_form.get_main_form.user_info.Enabled = true;
                main_form.get_main_form.help_menu.Enabled = true;
                main_form.get_main_form.menuStrip1.Enabled = true;
                main_form.get_main_form.tasks_menu.Enabled = true;
                main_form.get_main_form.update_your_info.Enabled = true;
                main_form.get_main_form.issuersInDSEToolStripMenuItem.Enabled = true;
                main_form.get_main_form.user_label.Text = this.uname_txt.Text;
                main_form.get_main_form.user_label.Visible = true;
                main_form.get_main_form.hellow_label.Visible = true;
                main_form.get_main_form.tradingOrderToolStripMenuItem.Enabled = true;
                //main_form.set_in_id(uname_txt.Text);
               
                this.Close();

               
            
                
                
                
                
            }
            else
            {
                MessageBox.Show("Login failed ! incorrect in \"user name or password\"");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up_newMember sign_up = new Sign_up_newMember();
            sign_up.ShowDialog();
        }

      



     

       
    }
}
