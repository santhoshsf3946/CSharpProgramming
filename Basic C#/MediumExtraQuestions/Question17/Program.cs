using System;
namespace Question17;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===================== Hospital =====================\n");

        Console.Write("Enter the period to which make calculations: ");
        int period = int.Parse(Console.ReadLine());

        int[] patients = new int[period];
        for (int i = 0; i < period; i++)
        {
            Console.Write($"Enter day {i + 1} patients: ");
            patients[i] = int.Parse(Console.ReadLine());
        }

        int doctorCount = 7;

        int treatedPatients = 0;
        int untreatedPatients = 0;

        foreach (var patientCount in patients)
        {
            if (patientCount > doctorCount)
            {
                treatedPatients += doctorCount;
                untreatedPatients += patientCount - doctorCount;
                doctorCount++;
            }
            else
            {
                treatedPatients += patientCount;
            }
        }
        
        Console.WriteLine($"\n  Treated Patients: {treatedPatients}\n  Untreated Patients: {untreatedPatients}\n");
    }
}
