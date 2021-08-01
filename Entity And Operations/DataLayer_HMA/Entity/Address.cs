using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_HMA.Entity
{
    public class Address
    {
        public string City, Area;

        public Address()
        {

        }

        public Address(string city, string area)
        {
            City = city;
            Area = area;
        }
    }
}
