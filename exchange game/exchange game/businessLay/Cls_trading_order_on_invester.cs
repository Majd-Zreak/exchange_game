using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace exchange_game.businessLay
{
    class Cls_trading_order_on_invester
    {
        dataAccessLay.dataAccessLay dal = new exchange_game.dataAccessLay.dataAccessLay();

        //get invester name Depending on user_name login
        public DataTable get_invester_on_username(string user)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user", SqlDbType.NChar,10);
            param[0].Value = user;

            DataTable dt = new DataTable();
            dt = dal.select_data("get_invester_on_username", param);
            dal.close();
            return dt;


        }

        public DataTable get_acc_no_from_username(string user)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user", SqlDbType.NChar,10);
            param[0].Value = user;

            DataTable dt = new DataTable();
            dt = dal.select_data("get_acc_no_from_username", param);
            dal.close();
            return dt;


        }


        
    }
}
