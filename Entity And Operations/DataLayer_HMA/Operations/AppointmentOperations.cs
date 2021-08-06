using DataLayer_HMA.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Operations
{
    public class AppointmentOperations
    {
        DBConnection db = new DBConnection();
        public void SetAppointment(Patient P,Doctor D)
        {
            string Query = "insert into AppointmentTbl  values('" + D.id + "','" + P.id + "','" + P.FirstName+" "+P.LastName + "','" + P.UserName + "','" + D.FirstName+" "+D.LastName + "','" + P.Date + "')";
            try
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public int CheckSignup(int pid,int did)
        {
            int count = 0;

            string Query = "select count(*) from AppointmentTbl where Did=" + did + " AND Pid=" + pid + "";
            try
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                //cmd.ExecuteNonQuery();
                count = (Int32)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count;
        }
    }
}
