using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public static class Files
    {
        public static void Create()
        {
            if (!Directory.Exists("SaveFiles"))
            {
                Console.WriteLine("\nCreating SaveFiles folder...\n");
                Directory.CreateDirectory("SaveFiles");
            }

            if (!File.Exists("SaveFiles/Beneficiary.csv"))
            {
                Console.WriteLine("\nCreating Beneficiary.csv file\n");
                File.Create("SaveFiles/Beneficiary.csv");
            }

            if (!File.Exists("SaveFiles/Vaccine.csv"))
            {
                Console.WriteLine("\nCreating Vaccine.csv file\n");
                File.Create("SaveFiles/Vaccine.csv");
            }

            if (!File.Exists("SaveFiles/Vaccination.csv"))
            {
                Console.WriteLine("\nCreating Vaccination.csv file\n");
                File.Create("SaveFiles/Vaccination.csv");
            }
        }

        public static void ReadFiles()
        {
            string[] beneficiaries = File.ReadAllLines("SaveFiles/Beneficiary.csv");

            foreach (string data in beneficiaries)
            {
                Program.beneficiaryList.Add(new Beneficiary(data));
            }

            string[] vaccines = File.ReadAllLines("SaveFiles/Vaccine.csv");

            foreach (string data in vaccines)
            {
                Program.vaccineList.Add(new Vaccine(data));
            }

            string[] vaccinations = File.ReadAllLines("SaveFiles/Vaccination.csv");

            foreach (string data in vaccinations)
            {
                Program.vaccinationList.Add(new Vaccination(data));
            }
        }

        public static void WriteToFiles()
        {
            string[] beneficiaryList = new string[Program.beneficiaryList.Count];

            for (int i = 0; i < Program.beneficiaryList.Count; i++)
            {
                beneficiaryList[i] = Program.beneficiaryList[i].RegisterNumber +  "," + Program.beneficiaryList[i].Name +  "," + Program.beneficiaryList[i].Gender +  "," +  Program.beneficiaryList[i].Mobile +  "," + Program.beneficiaryList[i].City +  "," + Program.beneficiaryList[i].Age;
            }

            File.WriteAllLines("SaveFiles/Beneficiary.csv", beneficiaryList);

            
            string[] vaccineList = new string[Program.vaccineList.Count];

            for (int i = 0; i < Program.vaccineList.Count; i++)
            {
                vaccineList[i] = Program.vaccineList[i].VaccineID + "," + Program.vaccineList[i].VaccineName + "," + Program.vaccineList[i].NoOfDoseAvailable;
            }

            File.WriteAllLines("SaveFiles/Vaccine.csv", vaccineList);

            
            string[] vaccinationList = new string[Program.vaccinationList.Count];

            for (int i = 0; i < Program.vaccinationList.Count; i++)
            {
                vaccinationList[i] = Program.vaccinationList[i].VaccinationID + "," + Program.vaccinationList[i].RegisterNumber + "," + Program.vaccinationList[i].VaccineID + "," + Program.vaccinationList[i].DoseNumber + "," + Program.vaccinationList[i].VaccinatedDate.ToShortDateString();
            }

            File.WriteAllLines("SaveFiles/Vaccination.csv", vaccinationList);
        }
    }
}
