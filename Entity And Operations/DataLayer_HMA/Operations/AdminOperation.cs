using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Operations
{
   public class AdminOperation
    {
        DBConnection db = new DBConnection();
        public int Doctorcount()
        {
            int count = 0;

            string Query = "select count(*) from DoctorTbl";
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

        public int DonorCount()
        {
            int count = 0;

            string Query = "select count(*) from DonorTbl";
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

        

        public int PatientCount()
        {
            int count = 0;

            string Query = "select count(*) from PatientTbl";
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
