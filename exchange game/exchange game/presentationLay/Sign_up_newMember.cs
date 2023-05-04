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
    public partial class Sign_up_newMember : Form
    {
        businessLay.Cls_Login log = new exchange_game.businessLay.Cls_Login();
        public  static Sign_up_newMember signUp_form;

        public static Sign_up_newMember get_signUp_form()
        { 
            //get
            //{
                if(signUp_form == null)
                    signUp_form = new Sign_up_newMember();
                
            return signUp_form;
            //}
        }
       
        public Sign_up_newMember()
        {
            InitializeComponent();
            if (signUp_form == null)
                signUp_form=this;
        }

    

        private void First_name_txt_Validated(object sender, EventArgs e)
        {
            DataTable dt =new DataTable();
            dt=log.invester_f_name(First_name_txt.Text);
            
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("This name already exists! , Please choose another name :)");
                First_name_txt.Focus();
                First_name_txt.SelectionStart = 0;
                First_name_txt.SelectionLength = First_name_txt.Text.Length;
            }
        }

        private void Last_name_txt_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = log.invester_l_name(Last_name_txt.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This name already exists! , Please choose another name :)");
                First_name_txt.Focus();
                First_name_txt.SelectionStart = 0;
                First_name_txt.SelectionLength = First_name_txt.Text.Length;
            }
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                log.Sign_up(First_name_txt.Text
                    , Last_name_txt.Text
                   , (age_txt.Value)
                    , Phone_txt.Text);
                MessageBox.Show("your info was saved");
                
                
                userName_signIn_form si = new userName_signIn_form();
                si.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("error.. please try again ");
            }
        }

    }
}
