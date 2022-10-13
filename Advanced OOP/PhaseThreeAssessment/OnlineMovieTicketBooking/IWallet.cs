using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// <see cref="IWallet"></see> Interface forces to implements Wallet functionality for a user
    /// </summary>
    public interface IWallet
    {
        /// <summary>
        /// Declaration of the Wallet Balance property
        /// </summary>
        double WalletBalance { get; }

        /// <summary>
        /// Declaration of the Recharge Wallet Method
        /// </summary>
        void RechargeWallet(double amount);
    }
}
