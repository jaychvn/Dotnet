using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            //Console.WriteLine(" myInt: {0}", myInt); 
            myInt = 50_00_000;
            Console.WriteLine(" myInt: {0}", myInt);
            Console.WriteLine("Hello World!");
            var vehicle = new Vehicle("Toyota", "Auris", 2012);
            Console.WriteLine($"My Vehicle: {vehicle}");
        }
    }

    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Make} {Model} {Year}";
        }
    }
}
