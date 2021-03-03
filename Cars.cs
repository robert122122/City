using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Cars(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public virtual string StartCar()
        {
            return "Car: " + this.Brand + " | " + this.Model + " | " + this.Price + " is starting the engine";
        }

    }
}
