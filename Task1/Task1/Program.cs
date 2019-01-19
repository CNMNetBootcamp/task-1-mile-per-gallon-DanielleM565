using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            Single milesDriven = 0;
            Single gallonsUsed = 0;
            double rate = 0.0;

            //input
            do
            {
                Console.WriteLine("How many miles were driven?");

            } while (!Single.TryParse(Console.ReadLine(), out milesDriven));

            do
            {
                Console.WriteLine("How many Gallons dud your car need to refill the tank after " + milesDriven + " were driven?");
            } while (!Single.TryParse(Console.ReadLine(), out gallonsUsed));

            //process
            rate = milesDriven / gallonsUsed;

            //output
            Console.WriteLine("Your car's average miles per gallon is " + rate + " mpg");
            Console.ReadLine();
        }
    }
}
