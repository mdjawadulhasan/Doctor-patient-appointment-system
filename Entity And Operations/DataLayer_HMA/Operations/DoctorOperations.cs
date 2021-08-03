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
   public  class DoctorOperations
    {
        DBConnection db = new DBConnection();
        public void InsertDoctor(Doctor d)
        {
            string Query = "insert into DoctorTbl  values('" + d.FirstName + "','" + d.LastName + "','" + d.Degree + "','" + d.Department + "','" + d.Chammber + "','" + d.Visitng_Hours+ "','" + d.visiting_days + "','" + d.Appoinment_CallNo + "')";
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


        public DataSet ShowDoctors()
        {
            string Query = "select *from DoctorTbl";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void UpdateDonors(int key, Donor d)
        {
            string Query = "Update DonorTbl set Dfname='" + d.FirstName + "',Dlname='" + d.LastName + "',Dphone='" + d.Phone + "',DBGrp='" + d.BloodGroup + "',Dcity='" + d.address.City + "',Darea='" + d.address.Area + "' where DoID=" + key + ";";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteDonors(int key)
        {
            string Query = "Delete from DonorTbl where DoID=" + key + "";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}

