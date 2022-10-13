using System;

namespace OnlineMovieTicketBooking
{

    /// <summary>
    /// <see cref="UserDetails"></see> Class inherited from <see cref="PersonalDetails"></see> Class and <see cref="IWallet"></see> Interface. Holds all the user Details of the application
    /// </summary>
    public class UserDetails : PersonalDetails, IWallet
    {

        /// <summary>
        /// Static field used to increment the unique part of the <see cref="UserID"></see> property
        /// </summary>
        private static int s_userID = 1000;


        /// <summary>
        /// Property <see cref="UserID"></see> holds the User ID of the <see cref="UserDetails"></see> Object
        /// </summary>
        public string UserID { get; }

        /// <summary>
        /// Property <see cref="WalletBalance"></see> holds the Wallet Balance of the <see cref="UserDetails"></see> Objects
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="UserDetails"></see> Class is created
        /// </summary>
        /// <param name="name">Passes value to the <see cref="PersonalDetails.Name"></see> Property of the Super Class <see cref="PersonalDetails"></see></param>
        /// <param name="age">Passes value to the <see cref="PersonalDetails.Age"></see> Property of the Super Class <see cref="PersonalDetails"></see></param>
        /// <param name="phoneNumber">Passes value to the <see cref="PersonalDetails.PhoneNumber"></see> Property of the Super Class <see cref="PersonalDetails"></see></param>
        /// <returns></returns>
        public UserDetails(string name, int age, long phoneNumber) : base(name, age, phoneNumber)
        {
            UserID = $"UID{++s_userID}";
        }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="UserDetails"></see> Class is created
        /// </summary>
        /// <param name="data">Gets a string of all the data in the file</param>
        public UserDetails(string data)
        {
            string[] values = data.Split(',');
            s_userID = int.Parse(values[0].Remove(0, 3));
            UserID = values[0];
            Name = values[1];
            Age = int.Parse(values[2]);
            PhoneNumber = long.Parse(values[3]);
            WalletBalance = double.Parse(values[4]);
        }

        public void RechargeWallet(double amount)
        {
            WalletBalance += amount;
        }        
    }
}
