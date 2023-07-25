using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Gym_management
{
    class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private String ConStr;
        private SqlDataAdapter sda;

        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\renil\Documents\FitnessDB.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public int setData(String Query)
        {
            int cnt = 0;
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }

        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query,ConStr);
            sda.Fill(dt);
            return dt;
        }



    }
}
