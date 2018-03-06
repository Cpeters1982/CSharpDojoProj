using System;
using System.Collections.Generic;

namespace csharp_fun
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> bikes = new List<string>();
        bikes.Add("Kawasaki");
        bikes.Add("Triumph");
        bikes.Add("BMW");
        bikes.Add("Moto Guzzi");
        bikes.Add("Harley-Davidson");
        bikes.Add("Suzuki");
        // Accessing a generic list value is the same as you would an array
        System.Console.WriteLine(bikes[2]); // prints "BMW"
        System.Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);
        }
    }
}
