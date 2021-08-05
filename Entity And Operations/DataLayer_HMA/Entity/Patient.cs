using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Entity
{
    public class Patient : Person
    {
        public string Diseases;
        public Patient()
        {

        }

        public Patient(string firstName, string lastName, string password, string userName, int age, double heightInCm, double weightInKg, string gender, string bloodGroup, string phone,string Diseases) :base( firstName,  lastName,  password,  userName,  age,  heightInCm,  weightInKg,  gender,  bloodGroup, phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            UserName = userName;
            Age = age;
            HeightInCm = heightInCm;
            WeightInKg = weightInKg;
            Gender = gender;
            BloodGroup = bloodGroup;
            Phone = phone;
            this.Diseases = Diseases;

        }
    }
}
