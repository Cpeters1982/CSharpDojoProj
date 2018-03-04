using System;

namespace csharp_test
{
    class Program
    {
        static void Main(string[] args){
            // int [] numArray = new int[5];
            // int [] numArray2 = {1,2,3,4,6};
            // Console.WriteLine(numArray2[2]);
            // //  In C#, array values can be redefined once the array has an initial set of values.
            // int[] arr = {1, 2, 3, 4, 6};
            // Console.WriteLine("The first number of the array is " + arr[0]);
            // arr[0] = 8;
            // Console.WriteLine("The first number of the array is now " + arr[0]);
            // string[] myCars = new string[4] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // // The 'length' property tells us how many values are in the array (4 in this example)
            // // We can use this to determine where the loop ends: length-1 us the index of the last value.
            // for (int idx = 0; idx < myCars.Length; idx++){
            //     Console.WriteLine("I own a {0}", myCars[idx]);

            // 
            // // C# Also has  a loop called a foreach. A foreach loopjudt needs a variable that holds each indexed
            // // value of the array temporarily and will loop through all of them from there.
            // string[] myCars = new string[4] {"Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 350zx"};
            // foreach (string car in myCars){
            //     Console.WriteLine("I own a {0}", car);
            // }
            // // In certain instances you may need to hold an array inside an array you have already initialized. 
            // // You must create this array with this in mind and specify not only the number of inner arrays but also
            // // the size of each of these inner arrays. This is valled a multidimensional arry because it builds 
            // //  out a grid of sorts based on the various indexes.
            // // Although these are good to know, they don't show up in code that often.

            // // Multidimensional array declaration
            // // This example contains three arrays -- each of these is length 2 -- all initialized to zeroes.
            int [,] array2D = new int[3,2];
            // // // This is equivalent to:
            // // // int [,] array2D = new int[3,2] { {0,0}, {0,0}, [0.0]};
            // // // THis example has two large rows that each contain 3 arrays -- and each of those arrays is length 4.
            int[,,] array3D = new int[2,3,4]{
                 { {45,1,16,17}, {4,47,21,68}, {21,28,32,76} },
                 { {11,0,85,42}, {9,10,14,96}, {66,99,33,14} }
            };
            // // Directly accessing a multidimensional array
            Console.WriteLine(array2D[0,1]);// prints 0
            System.Console.WriteLine(array3D[1,0,3]);// prints 42

            // Multidimensional arrays are quickly and neatly defined, but they do pose one important requirement. 
            // They require that they are perfectly rectangular, with all inner arrays having the same length. What 
            // if we need to vary the lengths of inner arrays? This leads to a third way of creating arrays called a 
            // jagged array. Though initialized and accessed differently, jagged arrays set out to accomplish the same 
            // task of holding arrays within array except without the need for uniform inner array sizes.

            
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