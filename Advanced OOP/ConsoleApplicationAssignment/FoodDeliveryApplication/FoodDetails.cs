using System;

namespace FoodDeliveryApplication
{
    public class FoodDetails
    {
        private static int s_foodID = 100;
        public string FoodID { get; set; }

        public string FoodName { get; set; }

        public double PricePerQuantity { get; set; }
        
        public FoodDetails(string foodName, double pricePerQuantity) 
        {
            FoodID = $"FID{++s_foodID}";
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
        }

        public FoodDetails(string data) 
        {
            string[] values = data.Split(',');
            s_foodID = int.Parse(values[0].Remove(0, 3));
            FoodID = values[0];
            FoodName = values[1];
            PricePerQuantity = double.Parse(values[2]);
        }
    }
}