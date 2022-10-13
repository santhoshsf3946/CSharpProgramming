using System;
using System.IO;
namespace ReadWriteTxtFile;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating folder if already not exists
        // if (!Directory.Exists("TestFolder"))
        // {
        //     Directory.CreateDirectory("TestFolder");
        //     Console.WriteLine("\nFolder created successfully");
        // }
        // else
        // {
        //     Console.WriteLine("Folder already exists");
        // }

        // // Creating file if already not exists
        // if (!File.Exists("TestFolder/Test.txt"))
        // {
        //     File.Create("TestFolder/Test.txt");
        //     Console.WriteLine("\nFile created successfully");
        // }
        // else
        // {
        //     Console.WriteLine("\nFile aready exists");
        // }

        Console.Write("\n\t1. Read File Infor\n\t2. Write File Info\nEnter your choice: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            {
                string line;
                StreamReader sr = null;

                try
                {
                    // Pass the file path and file name to the SreamReader constructor
                    sr = new StreamReader("TestFolder/Test.txt");

                    // Read the first line of text
                    line = sr.ReadLine();

                    Console.WriteLine();
                    while(line != null)
                    {
                        // write the line to the console
                        Console.WriteLine(line);

                        // Read the next line
                        line = sr.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\nException: {e.Message}");
                }
                finally
                {
                    if (sr != null)
                    {
                        Console.WriteLine($"\nExecuting finally block.\n");
                        sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw = null;
                try
                {
                    // Read all the lines from the old file
                    string[] old = File.ReadAllLines("TestFolder/Test.txt");

                    // Pass the file path and file name to the StreamWriter constructor to open the file for writing
                    sw = new StreamWriter("TestFolder/Test.txt");

                    Console.WriteLine("\nEnter new content to be placed in file: ");

                    string info = Console.ReadLine();

                    string old1 = "";

                    foreach (var text in old)
                    {
                        old1 = old1 + "\n" + text;  // Append old text
                    }

                    old1 = old1 + "\n" + info;  // Append our input text
                    sw.WriteLine(old1);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nException: " + e.Message);
                }
                finally 
                {
                    // Close the file
                    if (sw != null)
                    {
                        Console.WriteLine($"\nExecuting finally block.\n");
                        sw.Close();
                    }
                }
                break;
            }
            default:
            {
                break;
            }
        }
    }
}
