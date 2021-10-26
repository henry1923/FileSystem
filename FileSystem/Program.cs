using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter Directory name:");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);
            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exist");
                Console.WriteLine("Would you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter the file name:");
                    string userFile = Console.ReadLine() + ".txt";
                    string userFileFullPath = $@"{newDirectoryFullPath}\{userFile}";
                    File.Create(userFileFullPath);
                }

            }
                else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
            }
                
            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
