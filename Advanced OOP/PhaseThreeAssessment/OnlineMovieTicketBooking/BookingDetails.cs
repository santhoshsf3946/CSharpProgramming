using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// <see cref="BookingDetails"></see> Class Hold all the details of the bookings
    /// </summary>
    public enum BookingStatus { Default, Booked, Cancelled }

    public class BookingDetails
    {

        /// <summary>
        /// Static field used to increment the unique part of the <see cref="BookingID"></see> property
        /// </summary>
        private static int s_bookingID = 7000;

        /// <summary>
        /// Property <see cref="BookingID"></see> holds the Booking ID of the <see cref="BookingDetails"></see> Object
        /// </summary>
        public string BookingID { get; }

        /// <summary>
        /// Property <see cref="UserID"></see> holds the User ID of the <see cref="BookingDetails"></see> Object
        /// </summary>
        public string UserID { get; set; }
        
        /// <summary>
        /// Property <see cref="MovieID"></see> holds the Movie ID of the <see cref="BookingDetails"></see> Object
        /// </summary>
        public string MovieID { get; set; }

        /// <summary>
        /// Property <see cref="TheatreID"></see> holds the Theatre ID of the <see cref="BookingDetails"></see> Object
        /// </summary>
        public string TheatreID { get; set; }

        /// <summary>
        /// Property <see cref="SeatCount"></see> holds the Seat Count of the <see cref="BookingDetails"></see> Object
        /// </summary>
        public int SeatCount { get; set; }

        /// <summary>
        /// Property <see cref="TotalAmount"></see> holds the Total Amount of the <see cref="BookingDetails"></see> Object
        /// </summary>
        public double TotalAmount { get; set; }

        /// <summary>
        /// Property <see cref="BookingStatus"></see> is an Enum which holds one of the values of Booked, Cancelled
        /// </summary>
        public BookingStatus BookingStatus { get; set; }


        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="BookingDetails"></see> Class is created
        /// </summary>
        /// <param name="userID">Initializes <see cref="UserID"></see> Property</param>
        /// <param name="movieID">Initializes <see cref="MovieID"></see> Property</param>
        /// <param name="theatreID">Initializes <see cref="TheatreID"></see> Property</param>
        /// <param name="seatCount">Initializes <see cref="SeatCount"></see> Property</param>
        /// <param name="totalAmount">Initializes <see cref="TotalAmount"></see> Property</param>
        /// <param name="bookingStatus">Initializes <see cref="BookingStatus"></see> Property</param>
        public BookingDetails(string userID, string movieID, string theatreID, int seatCount, double totalAmount, BookingStatus bookingStatus) 
        {
            BookingID = $"BID{++s_bookingID}";
            UserID = userID;
            MovieID = movieID;
            TheatreID = theatreID;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;
        }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="BookingDetails"></see> Class is created
        /// </summary>
        /// <param name="data">Gets a string of all the data in the file</param>
        public BookingDetails(string data)
        {
            string[] values = data.Split(',');
            s_bookingID = int.Parse(values[0].Remove(0, 3));
            BookingID = values[0];
            UserID = values[1];
            MovieID = values[2];
            TheatreID = values[3];
            SeatCount = int.Parse(values[4]);
            TotalAmount = double.Parse(values[5]);
            BookingStatus = Enum.Parse<BookingStatus>(values[6], true);
        }
    }
}
