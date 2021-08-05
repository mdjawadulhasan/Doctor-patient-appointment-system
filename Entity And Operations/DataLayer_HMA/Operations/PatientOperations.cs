using DataLayer_HMA.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Operations
{
   public class PatientOperations
    {
        DBConnection db = new DBConnection();
        public void InsertPatient(Patient P)
        {
            string Query = "insert into PatientTbl  values('" + P.FirstName + "','" + P.LastName + "','" + P.Phone + "','" + P.Gender + "','" + P.Age + "','" + P.HeightInCm + "','" + P.WeightInKg + "','" + P.BloodGroup + "','" + P.Diseases + "','" + P.UserName + "','" + P.Password + "')";
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
    }
}
