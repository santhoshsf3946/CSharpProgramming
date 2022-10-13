using System;

namespace VaccinationDrive
{
    public class Vaccine
    {
        private static int s_vaccineID = 100;

        public string VaccineID { get; set; }

        public string VaccineName { get; set; }

        public int NoOfDoseAvailable { get; set; }

        public Vaccine(string vaccineName, int noOfDoseAvailable)
        {
            s_vaccineID++;
            VaccineID = $"CID{s_vaccineID}";
            VaccineName = vaccineName;
            NoOfDoseAvailable = noOfDoseAvailable;
        }

        public Vaccine(string data)
        {
            string[] values = data.Split(',');
            s_vaccineID = int.Parse(values[0].Remove(0, 3));
            VaccineID = values[0];
            VaccineName = values[1];
            NoOfDoseAvailable = int.Parse(values[2]);
        }

        public void ShowVaccineDetails()
        {
            Console.WriteLine($"  Vaccine ID: {VaccineID}  Vaccine Name: {VaccineName}  Available Vaccines: {NoOfDoseAvailable}");
        }
    }
}
