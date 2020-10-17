using System;

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
        }
    }
}
