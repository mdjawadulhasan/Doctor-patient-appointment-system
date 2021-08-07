using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Entity
{
    public class Person
    {
        public string FirstName { get; set; }

        public int id { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public int HeightInCm { get; set; }
        public int WeightInKg { get; set; }

        public string Gender { get; set; }

        public string BloodGroup { get; set; }

        public string Phone { get; set; }

        

        //public enum PersonTypeEnum { Patient = 1, Doctor, Admin }
        public int PersonType { get; set; }

        public Address address;
        public Person()
        {

        }
        public Person(Address address)
        {
            this.address = address;
        }
        public Person(string firstName, string lastName, string phone, string BloodGroup, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.BloodGroup = BloodGroup;
            this.address = address;
        }

        public Person(string firstName, string lastName,int id, string phone, string UserName, string Password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.id = id;
            this.Phone = phone;
            this.UserName = UserName;
            this.Password = Password;
        }
        public Person(string firstName, string lastName, string password, string userName, int age, int heightInCm, int weightInKg, string gender, string bloodGroup, string phone)
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
          
        }





    }
}
