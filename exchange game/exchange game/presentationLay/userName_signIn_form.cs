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
    public partial class userName_signIn_form : Form
    {
        businessLay.Cls_Login log = new exchange_game.businessLay.Cls_Login();
        public userName_signIn_form()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            try
            {
                log.create_new_username(userName_txt.Text, password_txt.Text);
                MessageBox.Show("your information was saved successfully");
                this.Close();

            }
            catch
            {
                MessageBox.Show("error..try again");
            }
        }

      
    }
}
