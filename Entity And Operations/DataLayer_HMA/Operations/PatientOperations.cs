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
        //public void InsertDoctor(Patient  P)
        //{
        //    string Query = "insert into DoctorTbl  values('" + d.FirstName + "','" + d.LastName + "','" + d.Degree + "','" + d.Department + "','" + d.Chammber + "','" + d.Visitng_Hours + "','" + d.visiting_days + "','" + d.Appoinment_CallNo + "')";
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(db.connect);
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(Query, con);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}
    }
}
