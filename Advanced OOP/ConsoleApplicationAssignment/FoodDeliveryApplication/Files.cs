using System;
using System.IO;

namespace FoodDeliveryApplication
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

            if (!File.Exists("SaveFiles/FoodDetails.csv"))
            {
                Console.WriteLine("\nCreating FoodDetails.csv file\n");
                File.Create("SaveFiles/FoodDetails.csv");
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
                Operations.customerDetailsList.Add(new CustomerDetails(data));
            }

            string[] foods = File.ReadAllLines("SaveFiles/FoodDetails.csv");

            foreach (string data in foods)
            {
                Operations.foodDetailsList.Add(new FoodDetails(data));
            }

            string[] bookings = File.ReadAllLines("SaveFiles/BookingDetails.csv");

            foreach (string data in bookings)
            {
                Operations.bookingDetailsList.Add(new BookingDetails(data));
            }

            string[] orders = File.ReadAllLines("SaveFiles/OrderDetails.csv");

            foreach (string data in orders)
            {
                Operations.orderDetailsList.Add(new OrderDetails(data));
            }
        }

        public static void WriteToFiles()
        {
            string[] customerDetailsArray = new string[Operations.customerDetailsList.Count];

            for (int i = 0; i < Operations.customerDetailsList.Count; i++)
            {
                customerDetailsArray[i] = Operations.customerDetailsList[i].CustomerID +  "," + Operations.customerDetailsList[i].Name +  "," + Operations.customerDetailsList[i].FatherName +  "," +  Operations.customerDetailsList[i].Gender +  "," + Operations.customerDetailsList[i].Mobile +  "," + Operations.customerDetailsList[i].DOB.ToString("dd/MM/yyyy") + "," + Operations.customerDetailsList[i].MailID + "," + Operations.customerDetailsList[i].Location + "," + Operations.customerDetailsList[i].WalletBalance;
            }

            File.WriteAllLines("SaveFiles/CustomerDetails.csv", customerDetailsArray);

            
            string[] foodDetailsArray = new string[Operations.foodDetailsList.Count];

            for (int i = 0; i < Operations.foodDetailsList.Count; i++)
            {
                foodDetailsArray[i] = Operations.foodDetailsList[i].FoodID + "," + Operations.foodDetailsList[i].FoodName + "," + Operations.foodDetailsList[i].PricePerQuantity;
            }

            File.WriteAllLines("SaveFiles/FoodDetails.csv", foodDetailsArray);

            
            string[] bookingDetailsArray = new string[Operations.bookingDetailsList.Count];

            for (int i = 0; i < Operations.bookingDetailsList.Count; i++)
            {
                bookingDetailsArray[i] = Operations.bookingDetailsList[i].BookingID + "," + Operations.bookingDetailsList[i].CustomerID + "," + Operations.bookingDetailsList[i].TotalPrice + "," + Operations.bookingDetailsList[i].DateOfBooking.ToString("dd/MM/yyyy") + "," + Operations.bookingDetailsList[i].BookingStatus;
            }

            File.WriteAllLines("SaveFiles/BookingDetails.csv", bookingDetailsArray);

            string[] orderDetailsArray = new string[Operations.orderDetailsList.Count];

            for (int i = 0; i < Operations.orderDetailsList.Count; i++)
            {
                orderDetailsArray[i] = Operations.orderDetailsList[i].OrderID + "," + Operations.orderDetailsList[i].BookingID + "," + Operations.orderDetailsList[i].FoodID + "," + Operations.orderDetailsList[i].PurchaseCount + "," + Operations.orderDetailsList[i].PriceOfOrder;
            }

            File.WriteAllLines("SaveFiles/OrderDetails.csv", orderDetailsArray);
        }
    }
}
