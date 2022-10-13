using System;

namespace VaccinationDrive
{
    public class Vaccination
    {
        private static int s_vaccinationID = 1000;

        public string VaccinationID { get; set; }

        public string RegisterNumber { get; set; }

        public string VaccineID { get; set; }

        public int DoseNumber { get; set; }

        public DateTime VaccinatedDate { get; set; }

        public Vaccination(string registerNumber, string vaccineID, int doseNumber, DateTime vaccinatedDate)
        {
            s_vaccinationID++;
            VaccinationID = $"VID{s_vaccinationID}";
            RegisterNumber = registerNumber;
            VaccineID = vaccineID;
            DoseNumber = doseNumber;
            VaccinatedDate = vaccinatedDate;
        }

        public Vaccination(string data)
        {
            string[] values = data.Split(',');
            s_vaccinationID = int.Parse(values[0].Remove(0, 3));
            VaccinationID = values[0];
            RegisterNumber = values[1];
            VaccineID = values[2];
            DoseNumber = int.Parse(values[3]);
            VaccinatedDate = DateTime.Parse(values[4]);
        }

        public void ShowVaccinationDetails()
        {
            Console.WriteLine($"  Vaccination ID: {VaccinationID}  Register Number: {RegisterNumber}  Vaccine ID: {VaccineID}  Dose Number: {DoseNumber}  Vaccinated Date: {VaccinatedDate.ToString("dd/MM/yyyy")}");
        }
    }
}
