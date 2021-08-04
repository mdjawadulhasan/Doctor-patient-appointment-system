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
            string Query = "select Dtfname,Dtlname,Dtdegree,Dtdept,Dtchamber,Dtvhours,Dtvdays,Dtaptcall  from DoctorTbl where  lower(Dtfname) like '%" + s + "%'";
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
            string Query = "select Dtfname,Dtlname,Dtdegree,Dtdept,Dtchamber,Dtvhours,Dtvdays,Dtaptcall  from DoctorTbl ";
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
