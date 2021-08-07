using DataLayer_HMA.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Operations
{
    public class PrescriptionOperations
    {
        DBConnection db = new DBConnection();
        public void InsertDoctor(Doctor d,Patient P)
        {
            string Query = "insert into PrescriptionTbl  values('" + P.id + "','" + d.id + "','" + P.FirstName+" "+P.LastName + "','" + d.FirstName+" "+d.LastName + "','" + P.Prescription + "',GetDate())";
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
