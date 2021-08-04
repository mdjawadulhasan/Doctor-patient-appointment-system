using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Entity
{
   public class Doctor :Person
    {
        public string Degree { get; set; }
        public string Department { get; set; }
        public string Chammber { get; set; }
        public string visiting_days { get; set; }
        public string Visitng_Hours { get; set; }
        public string Appoinment_CallNo { get; set; }


        public Doctor  ()
        {

        }

        public Doctor(string firstName, string lastName,int id, string phone, string UserName, string Password, string Degree, string Department, string Chammber, string visiting_days, string Visitng_Hours, string Appoinment_CallNo):base(firstName,lastName, id,phone,  UserName, Password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
            this.Phone = phone;
            this.UserName = UserName;
            this.Password = Password;
            this.Degree = Degree;
            this.Department = Department;
            this.Chammber = Chammber;
            this.visiting_days = visiting_days;
            this.Visitng_Hours = Visitng_Hours;
            this.Appoinment_CallNo = Appoinment_CallNo;

        }

    }
}



