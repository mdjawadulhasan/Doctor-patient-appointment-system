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
            string Query = "select *from DonorTbl";
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

        public DataSet ShowSpecificDonor(string s)
        {
            string Query = "select * from DonorTbl where  DBGrp like '%" + s + "%' OR lower(DBGrp) like '%" + s + "%' ";
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
