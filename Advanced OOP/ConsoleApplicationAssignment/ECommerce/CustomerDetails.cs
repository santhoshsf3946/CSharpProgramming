using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class CustomerDetails
    {
        private static int s_customerID = 1000;

        public string CustomerID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public long Mobile { get; set; }

        public double WalletBalance { get; set; }

        public string Mail { get; set; }

        public CustomerDetails(string name, string city, long mobile, double walletBalance, string mail)
        {
            s_customerID++;
            CustomerID = $"CID{s_customerID}";
            Name = name;
            City = city;
            Mobile = mobile;
            WalletBalance = walletBalance;
            Mail = mail;
        }

        public CustomerDetails(string data)
        {
            string[] values = data.Split(',');
            s_customerID = int.Parse(values[0].Remove(0, 3));
            CustomerID = values[0];
            Name = values[1];
            City = values[2];
            Mobile = long.Parse(values[3]);
            WalletBalance = double.Parse(values[4]);
            Mail = values[5];
        }

        public void WalletRecharge(double amount)
        {
            if (0 < amount)
            {
                WalletBalance += amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }
    }
}