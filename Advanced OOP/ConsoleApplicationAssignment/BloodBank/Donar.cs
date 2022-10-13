using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public enum BloodGroup { Default, A_Positive, A_Negative, B_Positive, B_Negative, O_Positive, O_Negative, AB_Positive, AB_Negative }
    public class Donar
    {
        private static int s_donarID = 1000;

        public string DonarID { get; set; }
        
        public string DonarName { get; set; }

        public long Mobile { get; set; }

        public BloodGroup BloodGroup { get; set; }

        public int Age { get; set; }

        public DateTime LastDonationDate { get; set; }

        public Donar(string name, long mobile, BloodGroup bloodGroup, int age, DateTime lastDonationDate)
        {
            DonarName = name;
            Mobile = mobile;
            BloodGroup = bloodGroup;
            Age = age;
            LastDonationDate = lastDonationDate;
            s_donarID++;
            DonarID = $"D{s_donarID}";
        }
        
        public List<Donation> GetDonationDetails(List<Donation> donationList)
        {
            List<Donation> newList = new List<Donation>();
            foreach (var donation in donationList)
            {
                if (DonarID == donation.DonarID)
                {
                    newList.Add(donation);
                }
            }
            return newList;
        }

        public DateTime ShowEligiblityDate()
        {
            return LastDonationDate.AddDays(56);
        }
    }
}
