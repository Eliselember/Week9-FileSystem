using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name:");
            string userDirectory = Console.ReadLine();

            string newDirectoryfullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryfullPath);

            bool directoryExists = Directory.Exists(newDirectoryfullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} already exists in {rootDirectory}");

            }
            else
            {
                Directory.CreateDirectory(newDirectoryfullPath);
                Console.WriteLine($"Directory {userDirectory} has been created");
            }

            Directory.CreateDirectory(newDirectoryfullPath);

        }
    }
}
