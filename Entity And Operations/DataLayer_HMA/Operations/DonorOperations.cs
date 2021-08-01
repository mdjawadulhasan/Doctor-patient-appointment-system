using DataLayer_HMA.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Operations
{
    public class DonorOperations
    {
        public int insert(Person pp)
        {
            SqlConnection con = new SqlConnection("Data Source=JAWAD;Initial Catalog=HealthManagementAppDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stb  values('" + pp.FirstName + "','" + pp.LastName + "','" + pp.UserName + "')", con);
            int flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }
    }
}
