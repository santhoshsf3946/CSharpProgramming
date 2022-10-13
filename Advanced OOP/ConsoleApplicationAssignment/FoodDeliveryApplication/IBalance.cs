using System;

namespace FoodDeliveryApplication
{
    public interface IBalance
    {
        public double WalletBalance { get; set; }

        public void WalletRecharge();
    }
}