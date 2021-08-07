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
    public class PrescriptionOperations
    {
        DBConnection db = new DBConnection();
        public void InsertPrescription(Doctor d,Patient P)
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


        public DataSet ShowPrescription(int key)
        {
            string Query = "select * from PrescriptionTbl where  Patid=" + key + "";
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
