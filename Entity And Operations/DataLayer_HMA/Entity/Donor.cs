using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Entity
{
    public class Donor : Person
    {
        public Donor()
        {

        }
        public Donor(string firstName, string lastName, string phone, string BloodGroup, Address address) : base(firstName, lastName, phone, BloodGroup, address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.BloodGroup = BloodGroup;
            this.address = address;
        }
        public Donor(Address address)
        {
            this.address = address;
        }

    }
}
