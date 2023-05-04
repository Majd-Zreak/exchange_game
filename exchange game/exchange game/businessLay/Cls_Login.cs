using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace exchange_game.businessLay
{
    class Cls_Login
    {
        dataAccessLay.dataAccessLay dal = new dataAccessLay.dataAccessLay();

        //login process
        public DataTable login(string name,string psw)
        {
            SqlParameter[] param = new SqlParameter[2];
            //param[0] = new SqlParameter("@user_id", SqlDbType.NChar, 10);
            //param[0].Value = id;

            param[0] = new SqlParameter("@user_name", SqlDbType.NChar, 10);
            param[0].Value = name;

            param[1] = new SqlParameter("@password", SqlDbType.NChar, 100);
            param[1].Value = psw;

            dal.open();
            DataTable dtb = new DataTable();

            dtb = dal.select_data("logIn_proc", param);
            dal.close();
            return dtb;
        }

        //save invester_info in invester table in db
        public void Sign_up(string f_name, string l_name,DateTime age,string phone)
        {
            SqlParameter[] param = new SqlParameter[4];
            //param[0] = new SqlParameter("@user_id", SqlDbType.NChar, 10);
            //param[0].Value = id;

            param[0] = new SqlParameter("@f_name", SqlDbType.NVarChar,20);
            param[0].Value = f_name;

            param[1] = new SqlParameter("@l_name", SqlDbType.NVarChar,20);
            param[1].Value = l_name;

            param[2] = new SqlParameter("@age", SqlDbType.Date);
            param[2].Value = age;

            param[3] = new SqlParameter("@phone", SqlDbType.NChar,10);
            param[3].Value = phone;

            dal.open();
            dal.execCommand("sign_up", param);
            dal.close();
            
        }

        // return f_name of invester
        public DataTable invester_f_name(string name)
        {
            SqlParameter[] param = new SqlParameter[1];
            //param[0] = new SqlParameter("@user_id", SqlDbType.NChar, 10);
            //param[0].Value = id;

            param[0] = new SqlParameter("@f_name", SqlDbType.NVarChar,20);
            param[0].Value = name;

           

            dal.open();
            DataTable dtb = new DataTable();

            dtb = dal.select_data("invester_f_name", param);
            dal.close();
            return dtb;
        }

        //return invester_l_name
        public DataTable invester_l_name(string name)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@l_name", SqlDbType.NVarChar, 20);
            param[0].Value = name;



            dal.open();
            DataTable dtb = new DataTable();

            dtb = dal.select_data("invester_l_name", param);
            dal.close();
            return dtb;
        }

        public void create_new_username(string name, string psw)
        {
            SqlParameter[] param = new SqlParameter[2];
            //param[0] = new SqlParameter("@user_id", SqlDbType.NChar, 10);
            //param[0].Value = id;

            param[0] = new SqlParameter("@username", SqlDbType.NChar, 10);
            param[0].Value = name;

            param[1] = new SqlParameter("@psw", SqlDbType.NChar, 100);
            param[1].Value = psw;

            

            dal.open();


            dal.execCommand("create_new_username", param);
            dal.close();
            
        }
    }
}
