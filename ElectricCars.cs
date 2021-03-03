using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class ElectricCars : Cars
    {

        public int Range { get; set; }

        public ElectricCars(string brand, string model, double price, int range) : base(brand, model, price)
        {
            Range = range;
        }

        public override string StartCar()
        {
            return "Car: " + this.Brand + " | " + this.Model + " | " + this.Price + " is starting the electric engine";
        }

    }
}
