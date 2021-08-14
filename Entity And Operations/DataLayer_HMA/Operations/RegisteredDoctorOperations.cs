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
   public class RegisteredDoctorOperations
    {
        DBConnection db = new DBConnection();

        public DataSet ShowSpecificDoctor(string s)
        {
            string Query = "select Did, Dtfname,Dtlname,Dtdegree,Dtdept,Dtchamber,Dtvhours,Dtvdays,Dtaptcall  from DoctorTbl where  lower(Dtfname) like '%" + s + "%' OR UPPER(Dtfname) like '%" + s + "%'";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public DataSet ShowAllDoctor()
        {
            string Query = "select *  from DoctorTbl ";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void RegisterDoctor(Doctor d)
        {
            string Query = "insert into RegisteredDtTbl  values('" + d.id + "','" + d.FirstName + "','" + d.LastName + "','" + d.Degree + "','" + d.Department + "','" + d.Chammber + "','" + d.Visitng_Hours + "','" + d.visiting_days + "','" + d.Appoinment_CallNo + "','" + d.UserName + "','" + d.Password + "')";
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

        public int CheckSignup(int key,string username)
        {
            int count = 0;

            string Query = "select count(*) from RegisteredDtTbl where Rdid=" + key + " OR Dtusername='" + username + "'";
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

        public Doctor GetDoctor(String UserName, String Password)
        {
            Doctor D = null;
            String Query = "select Rdid,Dtfname,Dtlname,Dtdegree,Dtdept,Dtchamber,Dtvhours,Dtvdays,Dtaptcall from RegisteredDtTbl where Dtusername='" + UserName + "' COLLATE Latin1_General_CS_AS  AND Dtpassword='" + Password + "' COLLATE Latin1_General_CS_AS ;";
            try
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    D = new Doctor();
                    D.id= reader.GetInt32(0);
                    D.FirstName = reader.GetString(1);
                    D.LastName = reader.GetString(2);
                    D.Degree = reader.GetString(3);
                    D.Department = reader.GetString(4);
                    D.Chammber = reader.GetString(5);
                    D.Visitng_Hours = reader.GetString(6);
                    D.visiting_days = reader.GetString(7);
                    D.Appoinment_CallNo= reader.GetString(8);

                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return D;
        }
    }
}
