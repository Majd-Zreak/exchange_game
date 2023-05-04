using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace exchange_game.businessLay
{
    class Cls_trading_order
    {
        dataAccessLay.dataAccessLay dal = new dataAccessLay.dataAccessLay();

        //display acc_ser_no for the invester (in_id)
        public DataTable get_acc_ser_no(int in_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@in_id", SqlDbType.Int);
            param[0].Value = in_id;

            DataTable dt = new DataTable();
            dt = dal.select_data("get_acc_ser_no", param);
            dal.close();
            return dt;


        }


        public DataTable get_all_acc()
        {
            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_acc", null);
            dal.close();
            return dt;
        }


        //return all securitys name from database
        public DataTable get_all_securitys()
        {
            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_sec", null);
            dal.close();
            return dt;
        }

        public DataTable get_quantity(int sec_id, int acc_id)
        {
            SqlParameter[] param = new SqlParameter[2];
            //param[0] = new SqlParameter("@user_id", SqlDbType.NChar, 10);
            //param[0].Value = id;

            param[0] = new SqlParameter("@sec_id", SqlDbType.Int);
            param[0].Value = sec_id;

            param[1] = new SqlParameter("@acc_id", SqlDbType.Int);
            param[1].Value = acc_id;

            //dal.open();
            DataTable dtb = new DataTable();

            dtb = dal.select_data("get_sec_quantity", param);
            dal.close();
            return dtb;
        }

        // return broker_name Depending on acc_id that selected
        public DataTable get_broker(int acc_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@acc_id", SqlDbType.Int);
            param[0].Value = acc_id;

            DataTable dt = new DataTable();
            dt = dal.select_data("get_broker", param);
            dal.close();
            return dt;


        }

        // add order to database
        public void add_order(int acc_id,string order_typ ,int sec_id ,int moneys ,int quan ,int br_id 
)
        {
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@acc_id", SqlDbType.Int);
            param[0].Value = acc_id;

            param[1] = new SqlParameter("@order_typ", SqlDbType.NChar,10);
            param[1].Value = order_typ;

            param[2] = new SqlParameter("@sec_id", SqlDbType.Int);
            param[2].Value = sec_id;

            param[3] = new SqlParameter("@moneys", SqlDbType.Int);
            param[3].Value = moneys;

            param[4] = new SqlParameter("@quan", SqlDbType.Int);
            param[4].Value = quan;

            param[5] = new SqlParameter("@br_id", SqlDbType.Int);
            param[5].Value = br_id;

            dal.open();
            dal.execCommand("add_order", param);
            dal.close();
            


        }

        // return securitys that selected account have it for sell process
        public DataTable get_sec_sell(int acc_id)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@acc_id", SqlDbType.Int);
            param[0].Value = acc_id;

           
            DataTable dtb = new DataTable();

            dtb = dal.select_data("get_sec_sell", param);
            dal.close();
            return dtb;
        }

        //return quan from sec_h depending on sec_id + acc_id 
        public DataTable get_quan_sec_h(int acc_id,int sec_id)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@acc_id", SqlDbType.Int);
            param[0].Value = acc_id;

            param[1] = new SqlParameter("@sec_id", SqlDbType.Int);
            param[1].Value = sec_id;


            DataTable dtb = new DataTable();

            dtb = dal.select_data("get_quan_sec_h", param);
            dal.close();
            return dtb;
        }
    }
}
