using System;

namespace OnlineGroceryStoreApplication
{
    public class OrderDetails
    {
        private static int s_orderID = 100;

        public string OrderID { get; }

        public string BookingID { get; set; }

        public string ProductID { get; set; }

        public int PurchaseCount { get; set; }

        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingID, string productID, int purchaseCount, double priceOfOrder) 
        {
            OrderID = $"OID{++s_orderID}";
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }

        public OrderDetails(string data) 
        {
            string[] values = data.Split(',');
            s_orderID = int.Parse(values[0].Remove(0, 3));
            OrderID = values[0];
            BookingID = values[1];
            ProductID = values[2];
            PurchaseCount = int.Parse(values[3]);
            PriceOfOrder = double.Parse(values[4]);
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine($"\t{OrderID}\t\t{BookingID}\t\t{ProductID}\t\t{PurchaseCount, 13}\t\t{PriceOfOrder, 5}");
        }
    }
}
