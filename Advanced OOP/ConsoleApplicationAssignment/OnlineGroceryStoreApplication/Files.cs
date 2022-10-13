using System;
using System.IO;

namespace OnlineGroceryStoreApplication
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

            if (!File.Exists("SaveFiles/BookingDetails.csv"))
            {
                Console.WriteLine("\nCreating BookingDetails.csv file\n");
                File.Create("SaveFiles/BookingDetails.csv");
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
                Operations.customersList.Add(new CustomerDetails(data));
            }

            string[] products = File.ReadAllLines("SaveFiles/ProductDetails.csv");

            foreach (string data in products)
            {
                Operations.productsList.Add(new ProductDetails(data));
            }

            string[] bookings = File.ReadAllLines("SaveFiles/BookingDetails.csv");

            foreach (string data in bookings)
            {
                Operations.bookingsList.Add(new BookingDetails(data));
            }

            string[] orders = File.ReadAllLines("SaveFiles/OrderDetails.csv");

            foreach (string data in orders)
            {
                Operations.ordersList.Add(new OrderDetails(data));
            }
        }

        public static void WriteToFiles()
        {
            string[] customerDetailsArray = new string[Operations.customersList.Count];

            for (int i = 0; i < Operations.customersList.Count; i++)
            {
                customerDetailsArray[i] = Operations.customersList[i].CustomerID +  "," + Operations.customersList[i].Name +  "," + Operations.customersList[i].FatherName +  "," +  Operations.customersList[i].Gender +  "," + Operations.customersList[i].Mobile +  "," + Operations.customersList[i].DOB.ToString("dd/MM/yyyy") + "," + Operations.customersList[i].MailID + "," + Operations.customersList[i].WalletBalance;
            }

            File.WriteAllLines("SaveFiles/CustomerDetails.csv", customerDetailsArray);

            
            string[] productDetailsArray = new string[Operations.productsList.Count];

            for (int i = 0; i < Operations.productsList.Count; i++)
            {
                productDetailsArray[i] = Operations.productsList[i].ProductID + "," + Operations.productsList[i].ProductName + "," + Operations.productsList[i].QuantityAvailable + "," + Operations.productsList[i].PricePerQuantity;
            }

            File.WriteAllLines("SaveFiles/ProductDetails.csv", productDetailsArray);

            
            string[] bookingDetailsArray = new string[Operations.bookingsList.Count];

            for (int i = 0; i < Operations.bookingsList.Count; i++)
            {
                bookingDetailsArray[i] = Operations.bookingsList[i].BookingID + "," + Operations.bookingsList[i].CustomerID + "," + Operations.bookingsList[i].TotalPrice + "," + Operations.bookingsList[i].DateOfBooking.ToString("dd/MM/yyyy") + "," + Operations.bookingsList[i].BookingStatus;
            }

            File.WriteAllLines("SaveFiles/BookingDetails.csv", bookingDetailsArray);

            string[] orderDetailsArray = new string[Operations.ordersList.Count];

            for (int i = 0; i < Operations.ordersList.Count; i++)
            {
                orderDetailsArray[i] = Operations.ordersList[i].OrderID + "," + Operations.ordersList[i].BookingID + "," + Operations.ordersList[i].ProductID + "," + Operations.ordersList[i].PurchaseCount + "," + Operations.ordersList[i].PriceOfOrder;
            }

            File.WriteAllLines("SaveFiles/OrderDetails.csv", orderDetailsArray);
        }
    }
}
