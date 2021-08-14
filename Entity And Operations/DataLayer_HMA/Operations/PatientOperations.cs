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

        public int CheckSignup(string username)
        {
            int count = 0;
                                                                 
            string Query = "select count(*) from PatientTbl where Pusername='" + username + "'";
            try         
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                
                count = (Int32)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count;
        }


        public Patient GetPatient(String UserName, String Password)
        {
            Patient P = null;
            String Query = "select Pid,Pfname,Plname,Pcontactno,Pgender,Page,Pheight,Pweight,Pbldgrp,PcrnDis,Pusername,PPassword from PatientTbl where Pusername='" + UserName + "' COLLATE Latin1_General_CS_AS AND Ppassword='" + Password + "' COLLATE Latin1_General_CS_AS;";
            try
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    P = new Patient();
                    P.id = reader.GetInt32(0);
                    P.FirstName = reader.GetString(1);
                    P.LastName = reader.GetString(2);
                    P.Phone = reader.GetString(3);
                    P.Gender = reader.GetString(4);
                    P.Age = reader.GetInt32(5);
                    P.HeightInCm= reader.GetInt32(6);
                    P.WeightInKg = reader.GetInt32(7);
                    P.BloodGroup = reader.GetString(8);
                    P.Diseases = reader.GetString(9);
                    P.UserName= reader.GetString(10);

                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return P;
        }




        public Patient GetPatient2(String UserName)
        {
            Patient P = null;
            String Query = "select Pid,Pfname,Plname,Pcontactno,Pgender,Page,Pheight,Pweight,Pbldgrp,PcrnDis,Pusername,PPassword from PatientTbl where Pusername='" + UserName + "' ;";
            try
            {
                SqlConnection con = new SqlConnection(db.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    P = new Patient();
                    P.id = reader.GetInt32(0);
                    P.FirstName = reader.GetString(1);
                    P.LastName = reader.GetString(2);
                    P.Phone = reader.GetString(3);
                    P.Gender = reader.GetString(4);
                    P.Age = reader.GetInt32(5);
                    P.HeightInCm = reader.GetInt32(6);
                    P.WeightInKg = reader.GetInt32(7);
                    P.BloodGroup = reader.GetString(8);
                    P.Diseases = reader.GetString(9);
                    P.UserName = reader.GetString(10);

                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return P;
        }
    }
}
