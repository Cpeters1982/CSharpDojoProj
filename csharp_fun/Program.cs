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
        // // Accessing a generic list value is the same as you would an array
        // System.Console.WriteLine(bikes[2]); // prints "BMW"
        // System.Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);
        System.Console.WriteLine("The current manufacturers we have seen are:");
        for (var idx = 0; idx < bikes.Count; idx++){
            System.Console.WriteLine("-" + bikes[idx]);
        }
        bikes.Insert(2, "Yamaha");
        bikes.Remove("Suzuki");
        bikes.Remove("Yamaha");
        bikes.RemoveAt(0);
        System.Console.WriteLine("List of Non-Japanese Manufacturers:");
        foreach (string manu in bikes){
            System.Console.WriteLine("-" + manu);
        }
        }
    }
}
