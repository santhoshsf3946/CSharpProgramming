using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatDone = "";
            double hoursWorked, totalTime;

            List<TimeSheetEntry> entryList = new List<TimeSheetEntry>();

            string choice;
            
            do
            {
                TimeSheetEntry entry = new TimeSheetEntry();

                Console.Write("Enter where you worked: ");
                whatDone = Console.ReadLine();

                Console.Write("How long did you do it for: ");
                hoursWorked = double.Parse(Console.ReadLine());
                
                entry.HoursWorked = hoursWorked;
                entry.WorkDone = whatDone;
                entryList.Add(entry);
                
                Console.Write("Do you want to enter more time: ");
                choice = Console.ReadLine().Trim().ToLower();
                
            } while (choice == "yes");

            totalTime = 0;
            for (int i = 0; i < entryList.Count; i++)
            {
                if (entryList[i].WorkDone.ToLower().Contains("acme"))
                {
                    totalTime += entryList[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalTime * 150 + " for the hours worked.");
            
            totalTime = 0;

            for (int j = 0; j < entryList.Count; j++)
            {
                if (entryList[j].WorkDone.ToLower().Contains("abc"))
                {
                    totalTime += entryList[j].HoursWorked;
                }
            }

            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalTime * 125 + " for the hours worked.");

            totalTime = 0;

            for (int k = 0; k < entryList.Count; k++)
            {
                totalTime += entryList[k].HoursWorked;
            }

            if (totalTime > 40)
            {
                Console.WriteLine("You will get paid $" + (400 + (totalTime - 40) * 15) +  " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + totalTime * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}
