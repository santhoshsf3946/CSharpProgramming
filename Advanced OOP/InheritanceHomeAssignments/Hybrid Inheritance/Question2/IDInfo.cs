using System;

namespace Question2
{
    public class IDInfo : PersonalInfo
    {
        public long VoterID { get; set; }
        
        public long AadharID { get; set; }
        
        public string PANNumber { get; set; }
        
        public IDInfo(string name, Gender gender, DateTime dOB, long mobile, string mail, long voterID, long aadharID, string pANNumber) : base(name, gender, dOB, mobile, mail)
        {
            VoterID = voterID;
            AadharID = aadharID;
            PANNumber = pANNumber;
        }
    }
}