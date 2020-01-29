using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(2)));
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

    class UnitConverter
    {
        int ratio;
        public UnitConverter (int unitRatio) {
            ratio = unitRatio;
        }

        public int Convert (int unit) {
            return unit* ratio;
        }
    }
}
