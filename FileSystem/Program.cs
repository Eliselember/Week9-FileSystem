using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userDirectory = "wishList";

            string newDirectoryfullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryfullPath);

            Directory.CreateDirectory(newDirectoryfullPath);

        }
    }
}
