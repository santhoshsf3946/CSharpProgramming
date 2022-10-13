using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Donation
    {
        private static int s_donationID = 1000;

        public string DonationID { get; set; }

        public string DonarID { get; set; }

        public DateTime DonationDate { get; set; }

        public double Weight { get; set; }

        public double BloodPressure { get; set; }

        public double HemoglobinCount { get; set; }

        public Donation(string donarID, DateTime donationDate, double weight, double bloodPressure, double hemoGlobinCount)
        {
            DonarID = donarID;
            DonationDate = donationDate;
            Weight = weight;
            BloodPressure = bloodPressure;
            HemoglobinCount = hemoGlobinCount;
            s_donationID++;
            DonationID = $"DH{s_donationID}";
        }

        public void ShowDonationDetails()
        {
            Console.WriteLine($"  Donation ID: {DonationID}  Donar ID: {DonarID}  Donation Date: {DonationDate}  Weight: {Weight}  Blood Pressure: {BloodPressure}  Hemoglobin Count: {HemoglobinCount}");
        }
    }
}
