using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// <see cref="TheatreDetails"></see> Class Hold all the details of the Theatres
    /// </summary>
    public class TheatreDetails
    {   
        /// <summary>
        /// Static field used to increment the unique part of the <see cref="TheatreID"></see> property
        /// </summary>
        private static int s_theatreID = 300;

        /// <summary>
        /// Property <see cref="TheatreID"></see> holds the Theatre ID of the <see cref="TheatreDetails"></see> Object
        /// </summary>
        public string TheatreID { get; }
        
        /// <summary>
        /// Property <see cref="TheatreName"></see> holds the Theatre Name of the <see cref="TheatreDetails"></see> Object
        /// </summary>
        public string TheatreName { get; set; }
        
        /// <summary>
        /// Property <see cref="TheatreLocation"></see> holds the Theatre Location of the <see cref="TheatreDetails"></see> Object
        /// </summary>
        public string TheatreLocation { get; set; }
        
        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="TheatreDetails"></see> Class is created
        /// </summary>
        /// <param name="theatreName">Initializes <see cref="TheatreName"></see> Property</param>
        /// <param name="theatreLocation">Initializes <see cref="TheatreLocation"></see> Property</param>
        public TheatreDetails(string theatreName, string theatreLocation) 
        {
            TheatreID = $"TID{++s_theatreID}";
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;
        }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="TheatreDetails"></see> Class is created
        /// </summary>
        /// <param name="data">Gets a string of all the data in the file</param>
        public TheatreDetails(string data)
        {
            string[] values = data.Split(',');
            s_theatreID = int.Parse(values[0].Remove(0, 3));
            TheatreID = values[0];
            TheatreName = values[1];
            TheatreLocation = values[2];
        }
    }
}
