using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace exchange_game.businessLay
{

    class Cls_show_trades
    {
        dataAccessLay.dataAccessLay dal = new dataAccessLay.dataAccessLay();

        //return all trades in trades db table 
        public DataTable get_all_trades()
        {
            
            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_trades", null);
            dal.close();
            return dt;

        }

        public DataTable get_all_issuer()
        {

            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_issuer", null);
            dal.close();
            return dt;

        }

        //return issuer from issuer table 
        public DataTable search_issuer(string id)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;



            dal.open();
            DataTable dtb = new DataTable();

            dtb = dal.select_data("search_issuer", param);
            dal.close();
            return dtb;
        }

        public DataTable get_sec_h_for_user(string user)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user", SqlDbType.NChar, 10);
            param[0].Value = user;



            dal.open();
            DataTable dtb = new DataTable();

            dtb = dal.select_data("get_sec_h_for_user", param);
            dal.close();
            return dtb;
        }
    }
}
