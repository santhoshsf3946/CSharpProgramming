using System;
using System.IO;

namespace FilesAndFolders;

public class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\SanthoshIruthayaraj\OneDrive - Syncfusion\Desktop\MyFolder";

        string folderPath = path + "/Santhosh";
        string filePath = path + "/newFile.txt";

        if (!Directory.Exists(folderPath))
        {
            Console.WriteLine("\nFolder not found creating folder\n");
            Directory.CreateDirectory(folderPath);
        }
        else
        {  
            Console.WriteLine("\nDirectory found\n");
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("\nFile not found creating file\n");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine("\nFile found\n");
        }

        Console.Write("\n\t1. Create Folder\n\t2. Create File\n\t3. Delete Folder\n\t4. Delete File\nEnter your choice: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            {
                Console.Write("\nEnter folder name you want create: ");
                string name1 = Console.ReadLine();
                string newPath = path+"\\"+name1;
                
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    Console.WriteLine("Directory already exists");
                }
                break;
            }
            case 2:
            {
                Console.Write("\nEnter file name you want create: ");
                string name1 = Console.ReadLine();
                Console.Write("\nEnter file extension you want to create: ");
                string name2 = Console.ReadLine();

                string newPath = path + "\\" + name1 + "." + name2;
                if (!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    Console.WriteLine("\nFile already exists");
                }
                break;
            }
            case 3:
            {
                foreach (var name in Directory.GetDirectories(path))  // Its like a file manager
                {
                    Console.WriteLine($"\t{name}");
                }

                Console.Write("\nSelect folder you want delete: ");
                string newPath = path + "\\" + Console.ReadLine();

                try
                {
                    Directory.Delete(newPath);
                    Console.WriteLine("\nFolder Deleted\n");
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("\n" + e.Message);   
                }
                break;
            }
            case 4:
            {
                foreach (var name in Directory.GetFiles(path))
                {
                    Console.WriteLine($"\t{name}");
                }

                Console.Write("\nSelect file you want to deleted: ");
                string name1 = Console.ReadLine();

                Console.Write("\nEnter file extension you want to delete: ");
                string name2 = Console.ReadLine();

                string newPath = path + "\\" + name1 + "." + name2;
                try
                {
                    if (File.Exists(newPath))
                    {
                        File.Delete(newPath);
                        Console.WriteLine("\nFile Deleted");
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                }
                break;
            }
            default:
            {
                Console.WriteLine("\nInvalid Input\n");
                break;
            }
        }
    }
}
