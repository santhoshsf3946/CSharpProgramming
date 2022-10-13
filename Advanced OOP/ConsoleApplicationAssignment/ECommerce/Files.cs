using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
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

            if (!File.Exists("SaveFiles/CustomerDetails.csv"))
            {
                Console.WriteLine("\nCreating CustomerDetails.csv file\n");
                File.Create("SaveFiles/CustomerDetails.csv");
            }

            if (!File.Exists("SaveFiles/ProductDetails.csv"))
            {
                Console.WriteLine("\nCreating ProductDetails.csv file\n");
                File.Create("SaveFiles/ProductDetails.csv");
            }

            if (!File.Exists("SaveFiles/OrderDetails.csv"))
            {
                Console.WriteLine("\nCreating OrderDetails.csv file\n");
                File.Create("SaveFiles/OrderDetails.csv");
            }
        }

        public static void ReadFiles()
        {
            string[] customers = File.ReadAllLines("SaveFiles/CustomerDetails.csv");

            foreach (string data in customers)
            {
                Program.customerList.Add(new CustomerDetails(data));
            }

            string[] products = File.ReadAllLines("SaveFiles/ProductDetails.csv");

            foreach (string data in products)
            {
                Program.productList.Add(new ProductDetails(data));
            }

            string[] orders = File.ReadAllLines("SaveFiles/OrderDetails.csv");

            foreach (string data in orders)
            {
                Program.orderList.Add(new OrderDetails(data));
            }
        }

        public static void WriteToFiles()
        {
            string[] customerDetailsList = new string[Program.customerList.Count];

            for (int i = 0; i < Program.customerList.Count; i++)
            {
                customerDetailsList[i] = Program.customerList[i].CustomerID +  "," + Program.customerList[i].Name +  "," + Program.customerList[i].City +  "," +  Program.customerList[i].Mobile +  "," + Program.customerList[i].WalletBalance +  "," + Program.customerList[i].Mail;
            }

            File.WriteAllLines("SaveFiles/CustomerDetails.csv", customerDetailsList);

            
            string[] productDetailsList = new string[Program.productList.Count];

            for (int i = 0; i < Program.productList.Count; i++)
            {
                productDetailsList[i] = Program.productList[i].ProductID + "," + Program.productList[i].ProductName + "," + Program.productList[i].Price + "," + Program.productList[i].Stock + "," + Program.productList[i].ShippingDuration;
            }

            File.WriteAllLines("SaveFiles/ProductDetails.csv", productDetailsList);

            
            string[] orderDetailsList = new string[Program.orderList.Count];

            for (int i = 0; i < Program.orderList.Count; i++)
            {
                orderDetailsList[i] = Program.orderList[i].OrderID + "," + Program.orderList[i].CustomerID + "," + Program.orderList[i].ProductID + "," + Program.orderList[i].TotalPrice + "," + Program.orderList[i].PurchaseDate.ToShortDateString() + "," + Program.orderList[i].Quantity + "," + Program.orderList[i].OrderStatus;
            }

            File.WriteAllLines("SaveFiles/OrderDetails.csv", orderDetailsList);
        }
    }
}
