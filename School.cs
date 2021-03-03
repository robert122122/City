using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class School : Building
    {

        public int Capacity { get; set; }

        public School(string name, Street buildingAddress, int year, int capacity) : base(name, buildingAddress, year)
        {
            Capacity = capacity;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
