using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public enum OrderStatus { Default, Ordered, Cancelled }
    public class OrderDetails
    {
        private static int s_orderID = 1000;

        public string OrderID { get; set; }

        public string CustomerID { get; set; }

        public string ProductID { get; set; }
        
        public double TotalPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string customerID, string productID, double  totalPrice, DateTime purchaseDate, int quantity, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID = $"OID{s_orderID}";
            CustomerID = customerID;
            ProductID = productID;
            TotalPrice = totalPrice;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            OrderStatus = orderStatus;
        }

        public OrderDetails(string data)
        {
            string[] values = data.Split(',');
            s_orderID = int.Parse(values[0].Remove(0, 3));
            OrderID = values[0];
            CustomerID = values[1];
            ProductID = values[2];
            TotalPrice = double.Parse(values[3]);
            PurchaseDate = DateTime.Parse(values[4]);
            Quantity = int.Parse(values[5]);
            OrderStatus = Enum.Parse<OrderStatus>(values[6]);
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine($"   Order ID: {OrderID}   Customer ID: {CustomerID}   Product ID: {ProductID}   Total Price: {TotalPrice}   Purchase Date: {PurchaseDate.ToString("dd/MM/yyyy")}   Quantity Purchased: {Quantity}   Order Status: {OrderStatus.ToString()}");
        }
    }
}
