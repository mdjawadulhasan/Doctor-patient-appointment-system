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
    public class DonorOperations
    {

        DBConnection db = new DBConnection();
        public void InsertDonor(Donor d)
        {
            

            string Query = "insert into DonorTbl  values('" + d.FirstName + "','" + d.LastName + "','" + d.Phone + "','" + d.BloodGroup + "','" + d.address.City + "','" + d.address.Area + "')";
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


        public DataSet ShowDonors()
        {
            string Query="select *from DonorTbl";
            SqlConnection con = new SqlConnection(db.connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query,con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
