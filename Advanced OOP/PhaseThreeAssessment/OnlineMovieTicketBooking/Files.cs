using System;
using System.IO;

namespace OnlineMovieTicketBooking
{
    public class Files
    {
        public static void CreateFiles()
        {
            if (!Directory.Exists("SaveFiles"))
            {
                Directory.CreateDirectory("SaveFiles");
                Console.WriteLine("\nSaveFiles Directory created successfully");
            }

            if (!File.Exists("SaveFiles/UserDetails.csv"))
            {
                File.Create("SaveFiles/UserDetails.csv");
                Console.WriteLine("\nUserDetails.csv File created successfully");
            }

            if (!File.Exists("SaveFiles/BookingDetails.csv"))
            {
                File.Create("SaveFiles/BookingDetails.csv");
                Console.WriteLine("\nBookingDetails.csv File created successfully");
            }

            if (!File.Exists("SaveFiles/TheatreDetails.csv"))
            {
                File.Create("SaveFiles/TheatreDetails.csv");
                Console.WriteLine("\nTheatreDetails.csv File created successfully");
            }

            if (!File.Exists("SaveFiles/MovieDetails.csv"))
            {
                File.Create("SaveFiles/MovieDetails.csv");
                Console.WriteLine("\nMovieDetails.csv File created successfully");
            }

            if (!File.Exists("SaveFiles/ScreeningDetails.csv"))
            {
                File.Create("SaveFiles/ScreeningDetails.csv");
                Console.WriteLine("\nScreeningDetails.csv File created successfully");
            }
        }

        public static void ReadFiles()
        {
            string[] userDetailsArray = File.ReadAllLines("SaveFiles/UserDetails.csv");

            foreach (string user in userDetailsArray)
            {
                Operations.userList.Add(new UserDetails(user));
            }

            string[] bookingDetailsArray = File.ReadAllLines("SaveFiles/BookingDetails.csv");

            foreach (string booking in bookingDetailsArray)
            {
                Operations.bookingList.Add(new BookingDetails(booking));
            }

            string[] theatreDetailsArray = File.ReadAllLines("SaveFiles/TheatreDetails.csv");

            foreach (string theatre in theatreDetailsArray)
            {
                Operations.theatreList.Add(new TheatreDetails(theatre));
            }

            string[] movieDetailsArray = File.ReadAllLines("SaveFiles/MovieDetails.csv");

            foreach (string movie in movieDetailsArray)
            {
                Operations.movieList.Add(new MovieDetails(movie));
            }

            string[] screeningDetailsArray = File.ReadAllLines("SaveFiles/ScreeningDetails.csv");

            foreach (string screening in screeningDetailsArray)
            {
                Operations.screeningList.Add(new ScreeningDetails(screening));
            }
        }

        public static void WriteFiles()
        {
            string[] userDetailsArray = new string[Operations.userList.Count];

            for (int i = 0; i < Operations.userList.Count; i++)
            {
                userDetailsArray[i] = Operations.userList[i].UserID + "," + Operations.userList[i].Name + "," + Operations.userList[i].Age + "," + Operations.userList[i].PhoneNumber + "," + Operations.userList[i].WalletBalance;
            }

            File.WriteAllLines("SaveFiles/UserDetails.csv", userDetailsArray);

            string[] bookingDetailsArray = new string[Operations.bookingList.Count];

            for (int i = 0; i < Operations.bookingList.Count; i++)
            {
                bookingDetailsArray[i] = Operations.bookingList[i].BookingID + "," + Operations.bookingList[i].UserID + "," + Operations.bookingList[i].MovieID + "," + Operations.bookingList[i].TheatreID + "," + Operations.bookingList[i].SeatCount + "," + Operations.bookingList[i].TotalAmount + "," + Operations.bookingList[i].BookingStatus;
            }

            File.WriteAllLines("SaveFiles/BookingDetails.csv", bookingDetailsArray);

            string[] theatreDetailsArray = new string[Operations.theatreList.Count];

            for (int i = 0; i < Operations.theatreList.Count; i++)
            {
                theatreDetailsArray[i] = Operations.theatreList[i].TheatreID + "," + Operations.theatreList[i].TheatreName + "," + Operations.theatreList[i].TheatreLocation;
            }

            File.WriteAllLines("SaveFiles/TheatreDetails.csv", theatreDetailsArray);

            string[] movieDetailsArray = new string[Operations.movieList.Count];

            for (int i = 0; i < Operations.movieList.Count; i++)
            {
                movieDetailsArray[i] = Operations.movieList[i].MovieID + "," + Operations.movieList[i].MovieName + "," + Operations.movieList[i].Language;
            }

            File.WriteAllLines("SaveFiles/MovieDetails.csv", movieDetailsArray);

            string[] screeningDetailsArray = new string[Operations.screeningList.Count];

            for (int i = 0; i < Operations.screeningList.Count; i++)
            {
                screeningDetailsArray[i] = Operations.screeningList[i].MovieID + "," + Operations.screeningList[i].TheatreID + "," + Operations.screeningList[i].TicketPrice + "," + Operations.screeningList[i].NoOfSeatsAvailable;
            }

            File.WriteAllLines("SaveFiles/ScreeningDetails.csv", screeningDetailsArray);
        }
    }
}
