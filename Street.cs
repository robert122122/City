using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Street
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Zipcode { get; set; }

        public Street(string name, int number, string zipcode)
        {
            Name = name;
            Number = number;
            Zipcode = zipcode;
        }
    }
}
