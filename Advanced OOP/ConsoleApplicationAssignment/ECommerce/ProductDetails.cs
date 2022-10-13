using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class ProductDetails
    {
        private static int s_productID = 100;

        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public double ShippingDuration { get; set; }
        
        public ProductDetails(string productName, double price, int stock, double shippingDuration)
        {
            s_productID++;
            ProductID = $"PID{s_productID}";
            ProductName = productName;
            Price = price;
            Stock = stock;
            ShippingDuration = shippingDuration;
        }

        public ProductDetails(string data)
        {
            string[] values = data.Split(',');
            s_productID = int.Parse(values[0].Remove(0, 3));
            ProductID = values[0];
            ProductName = values[1];
            Price = double.Parse(values[2]);
            Stock = int.Parse(values[3]);
            ShippingDuration = double.Parse(values[4]);
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}   Product Name: {ProductName}   Available Stock: {Stock}   Price per quantity: {Price}   Shipping Duration: {ShippingDuration}");
        }
    }
}
