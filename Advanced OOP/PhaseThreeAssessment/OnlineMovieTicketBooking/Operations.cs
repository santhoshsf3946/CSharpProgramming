using System;

namespace OnlineMovieTicketBooking
{
    public delegate void EventManager();

    public static class Operations
    {
        public static event EventManager evenlink = null;

        public static void Subscribe()
        {
            // evenlink += new EventManager(SetDefaultData);
            evenlink += new EventManager(Files.CreateFiles);
            evenlink += new EventManager(Files.ReadFiles);
            evenlink += new EventManager(MainMenu);
            evenlink += new EventManager(Files.WriteFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            evenlink();
        }

        // Lists
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<TheatreDetails> theatreList = new List<TheatreDetails>();
        public static List<MovieDetails> movieList = new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList = new List<ScreeningDetails>();

        // Current Logged in User
        static UserDetails currentUser = null;


        public static void MainMenu()
        {
            char choice;
            do
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("\n\t1. User Registration\n\t2. User Login\n\t3. Exit");
                Console.Write("Select one of the above choices: ");

                choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case '1':
                    {
                        UserRegistration();
                        break;
                    }
                    case '2':
                    {
                        Login();
                        break;
                    }
                    case '3':
                    {
                        Console.WriteLine("\nExitting Application...\n");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\nInvalid Choice");
                        break;
                    }
                }
            } while (choice != '3');
        }

        public static void SubMenu()
        {
            char choice;
            do
            {
                Console.WriteLine($"\nSub Menu\t\tWelcome {currentUser.Name}");
                Console.WriteLine("\n\ta. Ticket Booking\n\tb. Ticket Cancellation\n\tc. Booking History\n\td. Wallet Recharge\n\te. Logout");
                Console.Write("Select one of the above choices: ");

                choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case 'a':
                    {
                        TicketBooking();
                        break;
                    }
                    case 'b':
                    {
                        TicketCancellation();
                        break;
                    }
                    case 'c':
                    {
                        BookingHistory();
                        break;
                    }
                    case 'd':
                    {
                        RechargeWallet();
                        break;
                    }
                    case 'e':
                    {
                        Console.WriteLine("\nLogged out sucessfully\n");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\nInvalid Choice");
                        break;
                    }
                }
            } while (choice != 'e');
        }

        public static void UserRegistration()
        {
            Console.WriteLine("\nUser Registration");

            Console.Write("\n\tEnter you Name: ");
            string name = Console.ReadLine();

            int age;
            bool correct = false;
            do
            {
                Console.Write("\tEnter your Age: ");
                correct = int.TryParse(Console.ReadLine(), out age);
                if (!correct)
                {
                    Console.WriteLine("\n\tInvalid Age");
                }
            } while (!correct);

            long phone;
            correct = false;
            do
            {
                Console.Write("\tEnter Phone Number: ");
                correct = long.TryParse(Console.ReadLine(), out phone);
                if (!correct)
                {
                    Console.WriteLine("\n\tInvalid Phone Number");
                }
            } while (!correct);

            UserDetails newUser = new UserDetails(name, age, phone);

            Console.WriteLine($"\nUser registered successfully ! Your User ID is: {newUser.UserID}");

            userList.Add(newUser);
        }

        public static void Login()
        {
            Console.WriteLine("\nLogin");

            Console.Write("\nEnter your User ID for loging: ");

            string loginUserID = Console.ReadLine().Trim().ToUpper();

            foreach (UserDetails user in userList)
            {
                if (loginUserID == user.UserID)
                {
                    currentUser = user;
                    break;
                }
            }

            if (currentUser != null)
            {
                Console.WriteLine("\nLogged in successfully !");
                SubMenu();
            }
            else
            {
                Console.WriteLine("\nUser ID not found");
            }
        }

        public static void TicketBooking()
        {
            TheatreDetails selectedTheatre = null;
            ScreeningDetails selectedScreening = null;

            Console.WriteLine("\nTicket Booking");

            Console.WriteLine("\nTheatre List");
            Console.WriteLine($"\n\tTheatre ID\t{"Theatre Name", -20}\tTheatre Location");
            foreach (TheatreDetails theatre in theatreList)
            {
                Console.WriteLine($"\t{theatre.TheatreID, -15}\t{theatre.TheatreName, -20}\t{theatre.TheatreLocation}");
            }

            Console.Write("\nSelect one of the above theatre by Theatre ID: ");
            string theatreID = Console.ReadLine().Trim().ToUpper();

            foreach (TheatreDetails theatre in theatreList)
            {
                if (theatreID == theatre.TheatreID)
                {
                    selectedTheatre = theatre;
                }
            }

            if (selectedTheatre != null)
            {
                Console.WriteLine("\nMovies List");
                Console.WriteLine("\tMovie ID\tMovie Name\t\tMovie Language");
                foreach (ScreeningDetails screening in screeningList)
                {
                    if (selectedTheatre.TheatreID == screening.TheatreID)
                    {
                        foreach (MovieDetails movie in movieList)
                        {
                            if (movie.MovieID == screening.MovieID)
                            {
                                Console.WriteLine($"\t{movie.MovieID}\t\t{movie.MovieName, -20}\t{movie.Language}");
                            }
                        }
                    }
                }

                Console.Write("\nSelect one of the above movie by Movie ID: ");
                string movieID = Console.ReadLine().Trim().ToUpper();

                foreach (ScreeningDetails screening in screeningList)
                {
                    if (selectedTheatre.TheatreID == screening.TheatreID)
                    {
                        if (movieID == screening.MovieID)
                        {
                            selectedScreening = screening;
                        }
                    }
                }

                if (selectedScreening != null)
                {
                    int requiredSeatCount;
                    bool correct = false;
                    do
                    {
                        Console.Write("\nEnter how many seats you want to book: ");
                        correct = int.TryParse(Console.ReadLine(), out requiredSeatCount);
                        if (!correct || 1 > requiredSeatCount)
                        {
                            Console.WriteLine("\n\tInvalid Seat Count");
                        }
                    } while ((!correct) || 1 > requiredSeatCount);

                    if (requiredSeatCount <= selectedScreening.NoOfSeatsAvailable)
                    {
                        double totalAmount = (requiredSeatCount * selectedScreening.TicketPrice) + (requiredSeatCount * selectedScreening.TicketPrice * 0.18);
                        
                        if (totalAmount <= currentUser.WalletBalance)
                        {
                            currentUser.WalletBalance -= totalAmount;
                            selectedScreening.NoOfSeatsAvailable -= requiredSeatCount;
                            BookingDetails booking = new BookingDetails(currentUser.UserID, selectedScreening.MovieID, selectedTheatre.TheatreID, requiredSeatCount, totalAmount, BookingStatus.Booked);
                            bookingList.Add(booking);
                            Console.WriteLine($"\nBooking successfull !  Your Booking ID is: {booking.BookingID}");
                        }
                        else
                        {
                            Console.WriteLine("\nInsufficient Wallet Balance. Please recharge your wallet");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nRequired Seat count not available.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Movie ID");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Theatre ID");
            }
        }

        public static void TicketCancellation()
        {
            BookingDetails selectedBooking = null;
            bool bookingFound = false;
            Console.WriteLine("\nTicket Cancellation");
            Console.WriteLine("\nBooking list");
            foreach (BookingDetails booking in bookingList)
            {
                if (booking.UserID == currentUser.UserID && booking.BookingStatus == BookingStatus.Booked)
                {
                    bookingFound = true;
                    break;
                }
            }
            if (bookingFound)
            {
                Console.WriteLine("\n\tBooking ID\tUser ID\t\tMovie ID\tTheatre ID\tSeat Count\tTotal Amount\tBooking Status");
                foreach (BookingDetails booking in bookingList)
                {
                    if (booking.UserID == currentUser.UserID && booking.BookingStatus == BookingStatus.Booked)
                    {
                        Console.WriteLine($"\t{booking.BookingID}\t\t{booking.UserID}\t\t{booking.MovieID}\t\t{booking.TheatreID}\t\t{booking.SeatCount}\t\t{booking.TotalAmount}\t\t{booking.BookingStatus}");
                    }
                }

                Console.Write("\nEnter Bookinng ID of which booking you want to cancel: ");
                string bookingID = Console.ReadLine().Trim().ToUpper();

                foreach (BookingDetails booking in bookingList)
                {
                    if (booking.UserID == currentUser.UserID && booking.BookingStatus == BookingStatus.Booked && bookingID == booking.BookingID)
                    {
                        selectedBooking = booking;
                    }
                }

                if (selectedBooking != null)
                {
                    foreach (ScreeningDetails screening in screeningList)
                    {
                        if (screening.MovieID == selectedBooking.MovieID && screening.TheatreID == selectedBooking.TheatreID)
                        {
                            screening.NoOfSeatsAvailable += selectedBooking.SeatCount;
                            currentUser.WalletBalance += selectedBooking.TotalAmount - 20;
                            selectedBooking.BookingStatus = BookingStatus.Cancelled;
                            Console.WriteLine("\nTicket cancelled sucessfully");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Booking ID");
                }
            }
            else
            {
                Console.WriteLine("\n\tNo booking history found in booked status");
            }
            
        }

        public static void BookingHistory()
        {
            bool bookingFound = false;
            Console.WriteLine("\nBooking History");

            foreach (BookingDetails booking in bookingList)
            {
                if (booking.UserID == currentUser.UserID)
                {
                    bookingFound = true;
                    break;
                }
            }
            if (bookingFound)
            {
                Console.WriteLine("\n\tBooking ID\tUser ID\t\tMovie ID\tTheatre ID\tSeat Count\tTotal Amount\tBooking Status");
                foreach (BookingDetails booking in bookingList)
                {
                    if (booking.UserID == currentUser.UserID)
                    {
                        Console.WriteLine($"\t{booking.BookingID}\t\t{booking.UserID}\t\t{booking.MovieID}\t\t{booking.TheatreID}\t\t{booking.SeatCount}\t\t{booking.TotalAmount}\t\t{booking.BookingStatus}");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\tNo booking history found");
            }
        }

        public static void RechargeWallet()
        {
            Console.WriteLine("\nRecharge Wallet");

            
            double amount;
            bool correct = false;
            do
            {
                Console.Write("\nEnter the amount you want to recharge: ");
                correct = double.TryParse(Console.ReadLine(), out amount);
                if (!correct || amount <= 0)
                {
                    Console.WriteLine("\n\tInvalid Amount");
                }
            } while (!correct || amount <= 0);

            currentUser.RechargeWallet(amount);

            Console.WriteLine("\nWallet Recharged successfully !");
        }

        public static void SetDefaultData()
        {
            // Default User Details
            userList.Add(new UserDetails("Ravichandran", 30, 8599488003) { WalletBalance = 1000 });
            userList.Add(new UserDetails("Baskaran", 30, 9857747327) { WalletBalance = 2000 });

            // Default Theatre Details
            theatreList.Add(new TheatreDetails("Inox", "Anna Nagar"));
            theatreList.Add(new TheatreDetails("Ega Theatre", "Chetpet"));
            theatreList.Add(new TheatreDetails("Kamala", "Vadapalani"));

            // Default Movie Details
            movieList.Add(new MovieDetails("Bagubali 2", "Telugu"));
            movieList.Add(new MovieDetails("Ponniyin Selvan", "Tamil"));
            movieList.Add(new MovieDetails("Cobra", "Tamil"));
            movieList.Add(new MovieDetails("Vikram", "Hindi (Dubbed)"));
            movieList.Add(new MovieDetails("Vikram", "Tamil"));
            movieList.Add(new MovieDetails("Beast", "English"));

            // Default Screening Details
            screeningList.Add(new ScreeningDetails("MID501", "TID301", 200, 5));
            screeningList.Add(new ScreeningDetails("MID502", "TID301", 300, 2));
            screeningList.Add(new ScreeningDetails("MID506", "TID301", 50,	1));
            screeningList.Add(new ScreeningDetails("MID501", "TID302", 400, 11));
            screeningList.Add(new ScreeningDetails("MID502", "TID302", 300, 20));
            screeningList.Add(new ScreeningDetails("MID504", "TID302", 500, 2));
            screeningList.Add(new ScreeningDetails("MID505", "TID303", 100, 11));
            screeningList.Add(new ScreeningDetails("MID502", "TID303", 200, 20));
            screeningList.Add(new ScreeningDetails("MID504", "TID303", 350, 2));

            // Default Booking Details
            bookingList.Add(new BookingDetails("UID1001", "MID501", "TID301", 1, 200, BookingStatus.Booked));
            bookingList.Add(new BookingDetails("UID1001", "MID504", "TID302", 1, 400, BookingStatus.Booked));
            bookingList.Add(new BookingDetails("UID1002", "MID505", "TID302", 1, 300, BookingStatus.Booked));
        }
    }
}
