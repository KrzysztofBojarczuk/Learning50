using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            double mph;
            double kph;

            Console.WriteLine("KPH     MPH");
            Console.WriteLine("-----------");

            for (kph = 60; kph <= 130; kph = kph + 10)
            {
                mph = kph * 0.6214;

                Console.WriteLine($"{kph}  {Math.Round(mph, 3)}");
            }
        }
    }
}
