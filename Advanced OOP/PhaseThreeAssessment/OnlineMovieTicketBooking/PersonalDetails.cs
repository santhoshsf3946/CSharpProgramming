using System;

/// <summary>
/// Namspace which contains all the files needed for Online Movie Ticket Booking Application
/// </summary>
namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// <see cref="PersonalDetails"></see> Class Hold all the Personal details of the Users. Inherited by <see cref="UserDetails"></see> Class
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Property <see cref="Name"></see> holds the Name of the <see cref="PersonalDetails"></see> Object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property <see cref="Age"></see> holds the Age of the <see cref="PersonalDetails"></see> Object
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Property <see cref="PhoneNumber"></see> holds the Phone Number of the <see cref="PersonalDetails"></see> Object
        /// </summary>
        public long PhoneNumber { get; set; }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="PersonalDetails"></see> Class is created
        /// </summary>
        /// <param name="name">Initializes <see cref="Name"></see> Property</param>
        /// <param name="age">Initializes <see cref="Age"></see> Property</param>
        /// <param name="phoneNumber">Initializes <see cref="PhoneNumber"></see> Property</param>
        public PersonalDetails(string name, int age, long phoneNumber) 
        {
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Default constructor, When this class inherited by another class it helps to directly initializes its property
        /// </summary>
        public PersonalDetails()
        {
            
        }
    }
}
