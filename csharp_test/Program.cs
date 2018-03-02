using System;

namespace csharp_test
{
    class Program
    {
        static void Main(string[] args){
            int [] numArray = new int[5];
            int [] numArray2 = {1,2,3,4,6};
            Console.WriteLine(numArray2[2]);
            
        }
    }
}   
            // Console.WriteLine("Hello World!");
            
            // int rings = 5;
            // if (rings >= 5)
            // {
            //     Console.WriteLine("Welcome to the party!");
            // }
            // else if (rings > 2)
            // {
            //     Console.WriteLine("Decent... but {0} rings aren't enough", rings);
            // }
            // else
            // {
            //     Console.WriteLine(value: "Go win some more rings");
            // }
            // const string name = "Kobe";
            // if (rings >= 5 && name == "Kobe")
            // {
            //     Console.WriteLine("Welcome to the party {0}, congratulations on your {1} rings!", name, rings);
            // }
            // int numOfAllStarAppearances = 17;
            // if (rings >= 5 || numOfAllStarAppearances > 3)
            // {
            //     Console.WriteLine("Welcome, you are truly a legend!");
            // }
            // bool crazy = true;
            // if (!crazy)
            // {
            //     Console.WriteLine("Let's Party!");
            // }
            // else
            // {
            //     Console.WriteLine("Sorry, you're not allowed in.");
            // }
            // -------------------------------------------------------------- //
            // // Two different ways to do loops
            // for (int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // 
            // ------------------------------------------------------------- //
            // For and while loops in C#
            // for (int i = 1; i > 6; i = i + 1)
            // {
            //     Console.WriteLine(i);
            // }
            // 
            // ------------------------------------------------------------- //
            // Random in C# is provided by the System namespace
            // Random rand = new Random();
            // for(int val = 0; val < 10; val++)
            // {
            //     Console.WriteLine(rand.Next(2,8));
            // } 
            // for(int i = 1; i < 255; i++){
            //     Console.WriteLine(i);
            // }
            // for(int i = 1; i <= 100; i++){
            //     if((i % 3 == 0) || (i % 5 == 0)){
            //         if((i % 15 == 0)){
            //             continue;
            //         }
            //         Console.WriteLine(i);
            //     }
            // }
              // for(int i = 1; i < 255; i++){
            //     Console.WriteLine(i);
            // }
            // for(int i = 1; i <= 100; i++){
            //     if((i % 3 == 0) || (i % 5 == 0)){
            //         if((i % 15 == 0)){
            //             continue;
            //         }
            //         Console.WriteLine(i);
            //     }
            // }
            
            // for (int i = 1; i <= 100; i++){
            //     if ((i % 15 == 0)){
            //         System.Console.WriteLine("FizzBuzz");
            //     } else if ((i % 3 == 0)){
            //         System.Console.WriteLine("Fizz");
            //     } else if ((i % 5 == 0)){
            //         System.Console.WriteLine("Buzz");
            //     } else {
            //         System.Console.WriteLine(i);
            //     }
            // }