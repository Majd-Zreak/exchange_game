using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace exchange_game.dataAccessLay
{
    class dataAccessLay
    {
        SqlConnection connection;

        //inisialize the connection to database
        public dataAccessLay() 
        {
            connection = new SqlConnection(@"Server=USER-PC; Database= dse3; Integrated Security=true" );
        }
        // open the connection 
        public void open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
           
        }
        public void close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public DataTable select_data(string stored_proc,SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_proc;
            cmd.Connection = connection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add( param[i]);
                }
            } 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            dataAdapter.Fill(dtb);
            return dtb;
        }

        //insert update and delete to database
        public void execCommand(string stored_proc, SqlParameter[] param)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = stored_proc;
            command.Connection = connection;
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }
            
            command.ExecuteNonQuery();
        }
    }
}
