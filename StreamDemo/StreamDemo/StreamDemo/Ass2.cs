using System;
using System.IO;

class Program
{
    static void Main2()
    {
        string filePath = "userData.txt"; // Default file name

        // Accept lines of data from the user
        Console.WriteLine("Enter lines of data. Type 'quit' to exit.");
        string userInput;

        using var writer = new StreamWriter(filePath); // Using declaration
        do
        {
            userInput = Console.ReadLine();
            if (userInput.ToLower() != "quit")
            {
                writer.WriteLine(userInput);
            }
        } while (userInput.ToLower() != "quit");

        // Display options to the user
        Console.WriteLine("\nOptions:");
        Console.WriteLine("1. Create File and Write Data");
        Console.WriteLine("2. Override Data in Existing File");
        Console.WriteLine("3. Append Data in Existing File");
        Console.WriteLine("4. Display Data with Line Numbers");
        Console.WriteLine("5. Display Data without Line Numbers");
        Console.WriteLine("6. Display Number of Characters for Longest Line");
        Console.Write("Enter your choice (1-6): ");

        // Switch expression for concise choice handling
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                SaveDataToFile(filePath, FileMode.Create);
                break;
            case 2:
                SaveDataToFile(filePath, FileMode.Truncate);
                break;
            case 3:
                SaveDataToFile(filePath, FileMode.Append);
                break;
            case 4:
                DisplayDataWithoutLineNumbers(filePath);
                break;
            case 5:
                DisplayDataWithoutLineNumbers(filePath);
                break;
            case 6:
                DisplayLongestLine(filePath);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadLine(); // Pause to see the output
    }

    static void SaveDataToFile(string filePath, FileMode fileMode)
    {
        // Read data from the console
        Console.WriteLine("Enter data to save into the file:");
        string newData = Console.ReadLine();

        // Save data to the file using the specified FileMode
        using (var writer = new StreamWriter(filePath, fileMode)) // Using declaration
        {
            writer.WriteLine(newData);
        }

        Console.WriteLine("Data saved successfully.");
    }


    static void DisplayDataWithoutLineNumbers(string filePath)
    {
        // Read data from the file
        string[] lines = File.ReadAllLines(filePath);

        // Display data without line numbers
        Console.WriteLine("Data without Line Numbers:");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void DisplayLongestLine(string filePath)
    {
        // Read data from the file
        string[] lines = File.ReadAllLines(filePath);

        // Find the longest line and its length
        int maxLength = 0;
        string longestLine = "";
        foreach (var line in lines)
        {
            if (line.Length > maxLength)
            {
                maxLength = line.Length;
                longestLine = line;
            }
        }

        // Display the longest line and its length
        Console.WriteLine($"Longest Line: {longestLine}");
        Console.WriteLine($"Length of Longest Line: {maxLength} characters");
    }
}

    // ... (other methods remain unchanged)
