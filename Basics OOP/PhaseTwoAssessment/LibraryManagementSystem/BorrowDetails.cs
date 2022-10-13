using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public enum Status { Default, Assigned, Returned }
    public class BorrowDetails
    {
        private static int s_borrowID = 300;

        public string BorrowID { get; set; }

        public string BookID { get; set; }

        public string RegistrationID { get; set; }

        public DateTime BorrowedDate { get; set; }

        public Status Status { get; set; }

        public BorrowDetails(string registerationID, string bookID, DateTime date, Status status)
        {
            RegistrationID = registerationID;
            BorrowedDate = date;
            Status = status;
            s_borrowID++;
            BookID = bookID;
            s_borrowID++;
            BorrowID = $"LB{s_borrowID}";
        }
    }
}