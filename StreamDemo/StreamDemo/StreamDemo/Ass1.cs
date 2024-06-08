/*
Try Following :
 Accept the name of the file/Filepath from the user through console and display the 
1. complete text of the file on console.
2. display the same text line by line using line numbers.
 */

using System;
using System.IO;

class Ass1
{
    static void Main1(string[] args)
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();


        DisplayCompleteText(filePath);

        Console.ReadLine();
    }

    static void DisplayCompleteText(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("Complete Text of the File:");
            Console.WriteLine(content);
        }
        catch(Exception ex) 
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }
    static void DisplayText(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }

        }
        catch (Exception ex) 
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");

        }
    }
}
