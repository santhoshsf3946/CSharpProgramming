using System;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// <see cref="MovieDetails"></see> Class Hold all the details of the Movies
    /// </summary>
    public class MovieDetails
    {
        /// <summary>
        /// Static field used to increment the unique part of the <see cref="MovieID"></see> property
        /// </summary>
        private static int s_movieID = 500;

        /// <summary>
        /// Property <see cref="MovieID"></see> holds the Movie ID of the <see cref="MovieDetails"></see> Object
        /// </summary>
        public string MovieID { get; }
        
        /// <summary>
        /// Property <see cref="MovieName"></see> holds the Movie Name of the <see cref="MovieDetails"></see> Object
        /// </summary>
        public string MovieName { get; set; }
        
        /// <summary>
        /// Property <see cref="Language"></see> holds the Language of the <see cref="MovieDetails"></see> Object
        /// </summary>
        public string Language { get; set; }
        
        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="MovieDetails"></see> Class is created
        /// </summary>
        /// <param name="movieName">Initializes <see cref="TheatreName"></see> Property</param>
        /// <param name="language">Initializes <see cref="Language"></see> Property</param>
        public MovieDetails(string movieName, string language) 
        {
            MovieID = $"MID{++s_movieID}";
            MovieName = movieName;
            Language = language;
        }

        /// <summary>
        /// Constructor that initialize the Fields and Properties when an Object of a <see cref="MovieDetails"></see> Class is created
        /// </summary>
        /// <param name="data">Gets a string of all the data in the file</param>
        public MovieDetails(string data)
        {
            string[] values = data.Split(',');
            s_movieID = int.Parse(values[0].Remove(0, 3));
            MovieID = values[0];
            MovieName = values[1];
            Language = values[2];
        }
    }
}