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
            string Query = "select Did, Dtfname,Dtlname,Dtdegree,Dtdept,Dtchamber,Dtvhours,Dtvdays,Dtaptcall  from DoctorTbl where  lower(Dtfname) like '%" + s + "%'";
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

        public int CheckSignup(int key)
        {
            int count = 0;

            string Query = "select count(*) from RegisteredDtTbl where Rdid=" + key + "";
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

        //public Doctor GetPerson(String UserName, String Password)
        //{
        //    Doctor D = null;
        //    String Query = "select Rdid,Dtfname,Dtlname,Dtdegree,Dtdept,Dtchamber,Dtvhours,Dtvdays,Dtaptcall from RegisteredDtTbl Dtusername='" + UserName + "' AND Dtpassword='" + Password + "';";
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(db.connect);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(Query, con);
        //        SqlDataReader reader =cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            D = new Doctor();
        //            p.UserName = reader.GetString(0);
        //            p.FullName = reader.GetString(1);
        //            p.Password = reader.GetString(2);
        //            p.Age = reader.GetInt32(3);
        //            p.Gender = reader.GetInt32(4);
        //            p.Address = reader.GetString(5);
        //            p.Mail = reader.GetString(6);
        //            p.Phone = reader.GetInt32(7);
        //            p.PersonType = reader.GetInt32(8);
        //            p.ProfilePic = reader.GetString(9).Trim();
        //        }
        //        reader.Close();
        //        dbc.con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return p;
        //}
    }
}
