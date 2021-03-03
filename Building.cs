using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Building
    {
        public string Name { get; set; }
        public Street BuildingAddress { get; set; }
        public int Year { get; set; }

        public Building(string name, Street buildingAddress, int year)
        {
            Name = name;
            BuildingAddress = buildingAddress;
            Year = year;
        }
        
        public override string ToString()
        {
            return this.Name + " , " + BuildingAddress.Name + " , " + BuildingAddress.Number + " , " + this.Year;
        }
    }
}
