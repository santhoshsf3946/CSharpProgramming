using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// <see cref="ScreeningDetails"></see> Class Hold all the details of the Screenings
    /// </summary>   
    public class ScreeningDetails
    {
        /// <summary>
        /// Property <see cref="MovieID"></see> holds the Movie ID of the <see cref="ScreeningDetails"></see> Object
        /// </summary>
        public string MovieID { get; set; }
        
        /// <summary>
        /// Property <see cref="TheatreID"></see> holds the Theatre ID of the <see cref="ScreeningDetails"></see> Object
        /// </summary>
        public string TheatreID { get; set; }
        
        /// <summary>
        /// Property <see cref="NoOfSeatsAvailable"></see> holds the Number of Seats Available of the <see cref="ScreeningDetails"></see> Object
        /// </summary>
        public int NoOfSeatsAvailable { get; set; }
        
        /// <summary>
        /// Property <see cref="TicketPrice"></see> holds the Ticket Price of the <see cref="ScreeningDetails"></see> Object
        /// </summary>
        public double TicketPrice { get; set; }
        
        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="ScreeningDetails"></see> Class is created
        /// </summary>
        /// <param name="movieID">Initializes <see cref="MovieID"></see> Property</param>
        /// <param name="theatreID">Initializes <see cref="TheatreID"></see> Property</param>
        /// <param name="ticketPrice">Initializes <see cref="MovieID"></see> Property</param>
        /// <param name="noOfSeatsAvailable">Initializes <see cref="NoOfSeatsAvailable"></see> Property</param>
        public ScreeningDetails(string movieID, string theatreID, double ticketPrice, int noOfSeatsAvailable)
        {
            MovieID = movieID;
            TheatreID = theatreID;
            NoOfSeatsAvailable = noOfSeatsAvailable;
            TicketPrice = ticketPrice;
        }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="ScreeningDetails"></see> Class is created
        /// </summary>
        /// <param name="data">Gets a string of all the data in the file</param>
        public ScreeningDetails(string data)
        {
            string[] values = data.Split(',');
            MovieID = values[0];
            TheatreID = values[1];
            TicketPrice = double.Parse(values[2]);
            NoOfSeatsAvailable = int.Parse(values[3]);
        }
    }
}
