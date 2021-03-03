using System;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars("BMW", "I8", 25000);
            Cars car2 = new Cars("Dacia", "Logan", 12500);
            Cars car3 = new Cars("Audi", "A7", 40000);
            Console.WriteLine($" {car1.Brand}, {car1.Model}, {car1.Price}");
            Console.WriteLine($" {car2.Brand}, {car2.Model}, {car2.Price}");
            Console.WriteLine($" {car3.Brand}, {car3.Model}, {car3.Price}");
            Console.WriteLine(car1.StartCar());
            Console.WriteLine("\n");

            ElectricCars ecar1 = new ElectricCars("Tesla", "Model X", 50000, 432);
            Console.WriteLine($" {ecar1.Brand}, {ecar1.Model}, {ecar1.Price}, {ecar1.Range}");
            Console.WriteLine(ecar1.StartCar());
            Console.WriteLine("\n");

            Street str1 = new Street("Florilor", 55, "707317");
            Street str2 = new Street("Zorilor", 2, "700347");
            Street str3 = new Street("Ilie Oana", 107, "123456");

            Building b1 = new Building("Palatul culturii", str1, 1989);
            Console.WriteLine(b1.ToString());
            Console.WriteLine("\n");

            School s1 = new School("Grigore Moisil", str3, 1997, 300);
            Console.WriteLine(s1.ToString());

        }
    }
}
