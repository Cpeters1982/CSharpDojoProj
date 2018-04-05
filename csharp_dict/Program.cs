using System;
using System.Collections.Generic;

namespace csharp_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string,string> profile = new Dictionary<string,string>();
            // profile.Add("Name", "Speros");
            // profile.Add("Language", "PHP");
            // profile.Add("Location", "Greece");
            // // System.Console.WriteLine("Instructor Profile");
            // // System.Console.WriteLine("Name - " + profile["Name"]);
            // // System.Console.WriteLine("From - " + profile["Location"]);
            // // System.Console.WriteLine("Favorite Language - " + profile["Language"]);
            // foreach (KeyValuePair<string,string> entry in profile){
            //     System.Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            // // We can also use type inference, but only when the variable type can be easily deduced... In other words, sparingly.
            // // an example of the above code using type inference
            // foreach (var entry in profile){
            // System.Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            // int[] thisArray = new int[10];
            // for (int i = 0; 1 <= 10; i++){
            //     thisArray[i] = i;
            //     System.Console.WriteLine(i);
            // }
            // string[] nameArray = new string[4];
            // nameArray[0] = "Tim";
            // nameArray[1] = "Martin";
            // nameArray[2] = "Nikki";
            // nameArray[3] = "Sara";
            // foreach (string name in nameArray){
            //     System.Console.WriteLine(name);
            List<string> bikes = new List<string>();
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("harley Davidson");
            bikes.Add("Suzuki");
            // System.Console.WriteLine(bikes[2]);
            // System.Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);
            System.Console.WriteLine("The current manufacturers we have seen are:");
            // for(var idx = 0; idx < bikes.Count; idx++){
            //     System.Console.WriteLine("-" + bikes[idx]);
            // }
            bikes.Insert(2, "Yamaha");
            // for(var idx = 0; idx < bikes.Count; idx++){
            //     System.Console.WriteLine("-" + bikes[idx]);
            // }
            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0);
            System.Console.WriteLine("List of non-Japanese manufacturers:");
            foreach (string manu in bikes){
                System.Console.WriteLine("-" + manu);
            }

        }
    }
}

