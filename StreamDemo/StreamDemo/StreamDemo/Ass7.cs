/*
 Write Switch case code to perform following operations on directory:
a. Create Directory
b. If Directory Exist Delete Directory
c. Display all files in Directory
d. Display all Subdirectories in Directory
 */
using System;
using System.IO;

class Ass7
{
    static void Main()
    {
        Console.Write("Enter the directory path: ");
        string directoryPath = Console.ReadLine();

        Console.Write("Enter the operation to perform (1-4): ");
        Console.WriteLine("1. Create Directory");
        Console.WriteLine("2. Delete Directory (if exists)");
        Console.WriteLine("3. Display all files in Directory");
        Console.WriteLine("4. Display all Subdirectories in Directory");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Create directory
                try
                {
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine("Directory created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating directory: {0}", ex.Message);
                }
                break;

            case 2:
                // Delete directory
                try
                {
                    if (Directory.Exists(directoryPath))
                    {
                        Directory.Delete(directoryPath, true); // Delete recursively
                        Console.WriteLine("Directory deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Directory does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting directory: {0}", ex.Message);
                }
                break;

            case 3:
                // Display all files in directory
                try
                {
                    if (Directory.Exists(directoryPath))
                    {
                        string[] files = Directory.GetFiles(directoryPath);
                        Console.WriteLine("Files in the directory:");
                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Directory does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error listing files: {0}", ex.Message);
                }
                break;

            case 4:
                // Display all subdirectories in directory
                try
                {
                    if (Directory.Exists(directoryPath))
                    {
                        string[] subdirectories = Directory.GetDirectories(directoryPath);
                        Console.WriteLine("Subdirectories in the directory:");
                        foreach (string subdirectory in subdirectories)
                        {
                            Console.WriteLine(subdirectory);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Directory does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error listing subdirectories: {0}", ex.Message);
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadLine(); // Pause to see output
    }
}

