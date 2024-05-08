using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AIR_TICKET_BOOKING
{
    class Class1
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7IRF0GL\MUNEEBSQLSERVER;Initial Catalog=Air_ticket_system;Integrated Security=True");
        public bool login (string myuser,string mypass)
        {
            string loginvalue = "select [user name],[user password] from my_login_data where [user name]='" + myuser + "'and [user password]='" + mypass + "'";
            SqlCommand log = new SqlCommand(loginvalue,conn);
            SqlDataReader rdr;
            conn.Open();
            rdr=log.ExecuteReader();
            return rdr.Read();
        }
        
        public void delete_round_trip(int passid)
        {
            string delete = "delete from Round_trip where [Passport ID]='" + passid + "'";
            SqlCommand bbb = new SqlCommand(delete,conn);
            conn.Open();
            bbb.ExecuteNonQuery();
            conn.Close();
        }
        public void delete_one_way(int pass_id) 
        {
            string dele = "delete from one_way where [Passport ID]= '"+pass_id+"'";
            SqlCommand cmd = new SqlCommand(dele, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void delete_hotel_detail(int passID) 
        {
            string del = "delete from Hotel_Detail where [Passport ID]='" + passID + "'";
            SqlCommand htb = new SqlCommand(del, conn);
            conn.Open();
            htb.ExecuteNonQuery();
            conn.Close();
        }
    }
}
