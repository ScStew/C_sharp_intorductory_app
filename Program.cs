﻿using System;

namespace C__intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string name = "Mike";
            Console.WriteLine($"{message} {name}");


            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));


            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d} | remainder: {e}");


            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");


            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");


            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            Console.WriteLine($"The range of double is {dmin} to {dmax}");


            decimal decmin = decimal.MinValue;
            decimal decmax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {decmin} to {decmax}");

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }
    }
}
