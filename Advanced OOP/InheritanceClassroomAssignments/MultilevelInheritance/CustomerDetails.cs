using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_customerID = 1000;

        public string CustomerID { get; set; }

        public double Balance { get; set; }

        public CustomerDetails(string aadhaarID, string name, string fatherName, Gender gender, long phone) : base(aadhaarID, name, fatherName, gender, phone)
        {
            s_customerID++;
            CustomerID = $"CID{s_customerID}";
        }

        public void Recharge()
        {
            Console.Write("\n\nEnter amount to recharge: ");
            Balance += double.Parse(Console.ReadLine());
        }

        public void ShowCustomerDetails()
        {
            Console.WriteLine($"\n  Customer ID: {CustomerID}");
            ShowDetails();
            Console.WriteLine($"  Balance: Rs. {Balance}\n");
        }
    }
}
