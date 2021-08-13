using DataLayer_HMA.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int ChecApt(int pid,int did)
        {
            int count = 0;

            string Query = "select count(*) from AppointmentTbl where Did=" + did + " AND Pid=" + pid + " AND AppDate>GETDATE()";
            try
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                
                count = (Int32)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count;
        }


        public DataSet ShowUpComingApt(int pid)
        {
            string Query = "select * from AppointmentTbl where  Pid=" + pid + " AND AppDate>GETDATE()";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataSet ShowPrevApt(int pid)
        {
            string Query = "select * from AppointmentTbl where  Pid=" + pid + " AND AppDate<GETDATE()";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void DeleteApt(int key)
        {
            string Query = "Delete from AppointmentTbl where Apid=" + key + "";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public DataSet ShowDtAptList(int Did)
        {
            string Query = "select * from AppointmentTbl where  Did=" + Did + " AND AppDate>GETDATE()";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

       
    }
}
