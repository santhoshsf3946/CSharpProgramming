using System;

namespace FoodDeliveryApplication;

public delegate void EventManager();

public static class Operations
{
    public static event EventManager eventlink = null;

    public static void Subscribe()
    {
        eventlink += new EventManager(Files.Create);
        eventlink += new EventManager(Files.ReadFiles);
        eventlink += new EventManager(ShowMainMenu);
        eventlink += new EventManager(Files.WriteToFiles);
    }

    public static void StartEvent()
    {
        Subscribe();
        eventlink();
    }

    public static List<CustomerDetails> customerDetailsList = new List<CustomerDetails>();
    public static List<FoodDetails> foodDetailsList = new List<FoodDetails>();
    public static List<BookingDetails> bookingDetailsList = new List<BookingDetails>();
    public static List<OrderDetails> orderDetailsList = new List<OrderDetails>();

    static CustomerDetails currentCustomer = null;

    public static void ShowMainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\nMain Menu\n---------");
            Console.WriteLine("\t1. Customer Registration\n\t2. Customer Login\n\t3. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("\nExitting...\n");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Choice");
                    break;
                }
            }
        } while (choice != 3);
    }

    public static void ShowSubMenu()
    {
        string choice;
        do
        {
            Console.WriteLine($"\nSub Menu\tWelcome {currentCustomer.Name}\n--------");
            Console.WriteLine("    i. Show Food Item\n   ii. Order Food\n  iii. Cancel Booking\n   iv. Order History\n    v. Recharge Wallet\n   vi. Logout");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine().Trim().ToLower();

            switch (choice)
            {
                case "i":
                {
                    ShowFoodItemDetails();
                    break;
                }
                case "ii":
                {
                    OrderFood();
                    break;
                }
                case "iii":
                {
                    CancelBooking();
                    break;
                }
                case "iv":
                {
                    ShowOrderHistory();
                    break;
                }
                case "v":
                {
                    currentCustomer.WalletRecharge();
                    break;
                }
                case "vi":
                {
                    Console.WriteLine("\nLogged Out successfully");
                    break;
                }
                default:
                {
                    break;
                }
            }
        } while (choice != "vi");
    }

    public static void UserRegistration()
    {
        Console.WriteLine("\nUser Registration\n-----------------");

        Console.Write("\tEnter your Name: ");
        string name = Console.ReadLine();

        Console.Write("\tEnter your Father Name: ");
        string fatherName = Console.ReadLine();

        Console.Write("\tEnter your Gender: ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

        Console.Write("\tEnter your Mobile Number: ");
        long mobile = long.Parse(Console.ReadLine());

        Console.Write("\tEnter your Date of Birth ( dd/MM/yyyy ): ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("\tEnter your Mail ID: ");
        string mailID = Console.ReadLine();

        Console.Write("\tEnter your Location: ");
        string location = Console.ReadLine();

        Console.Write("\tEnter your wallet initial amount: ");
        double amount = double.Parse(Console.ReadLine());

        CustomerDetails newCustomer = new CustomerDetails(name, fatherName, gender, mobile, dob, mailID, location, amount);

        customerDetailsList.Add(newCustomer);

        Console.WriteLine($"\nCustomer Registered successfully !  Your Customer ID: {newCustomer.CustomerID}");
    }

    public static void Login()
    {
        Console.Write("\nEnter your Customer ID for login: ");
        string customerID = Console.ReadLine().Trim().ToUpper();

        foreach (CustomerDetails customer in customerDetailsList)
        {
            if (customerID == customer.CustomerID)
            {
                currentCustomer = customer;
            }
        }

        if (currentCustomer != null)
        {
            Console.WriteLine("\nLogged In successfully !");
            ShowSubMenu();
        }
        else
        {
            Console.WriteLine("\nCustomer ID not found");
        }
    }

    public static void ShowFoodItemDetails()
    {
        Console.WriteLine("\nFood List\n---------");
        Console.WriteLine("\tFood ID\t\tFoodName\t\tPricePerQuantity");

        foreach (FoodDetails food in foodDetailsList)
        {
            Console.WriteLine($"\t{food.FoodID}\t\t{food.FoodName, -20}\t{food.PricePerQuantity}");
        }
    }

    public static void OrderFood()
    {
        bool isOrderCreated = false;
        List<OrderDetails> orderDetailsLocalList = new List<OrderDetails>();
        BookingDetails currentBooking = null;
        double totalOrderPrice = 0;

        Console.Write("\nDo you want to purchase food: ");
        string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "yes")
        {
            FoodDetails slelectedFood = null;
            currentBooking = new BookingDetails(currentCustomer.CustomerID, 0, DateTime.Now, BoookingStatus.Initiated);
            
            while (choice == "yes")
            {
                ShowFoodItemDetails();

                Console.Write("Select a food item by typing its Food ID: ");
                string foodID = Console.ReadLine().Trim().ToUpper();

                foreach (FoodDetails food in foodDetailsList)
                {
                    if (food.FoodID == foodID)
                    {
                        slelectedFood = food;
                    }
                }

                if (slelectedFood != null)
                {
                    Console.Write("\nEnter quantity of the food: ");
                    int quantity = int.Parse(Console.ReadLine());

                    if (quantity > 0)
                    {
                        double orderPrice = slelectedFood.PricePerQuantity * quantity;
                        totalOrderPrice += orderPrice;

                        if (totalOrderPrice <= currentCustomer.WalletBalance)
                        {
                            OrderDetails newOrder = new OrderDetails(currentBooking.BookingID, slelectedFood.FoodID, quantity, orderPrice);
                            currentBooking.TotalPrice += orderPrice;
                            orderDetailsLocalList.Add(newOrder);
                            Console.WriteLine("\nOrder created successfully");
                            isOrderCreated = true;
                        }
                        else
                        {
                            Console.WriteLine("\nInsufficient Balance");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEnter a valid quantity");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Food ID");
                }
                Console.Write("\nDo you want to purchase more food: ");
                choice = Console.ReadLine().Trim().ToLower();
            }
        }
        if (isOrderCreated)
        {
            Console.Write("\nDo you want to confirm the bookings: ");
            string option = Console.ReadLine().Trim().ToLower();

            if (option == "yes")
            {
                currentBooking.BookingStatus = BoookingStatus.Booked;
                currentCustomer.WalletBalance -= totalOrderPrice;
                bookingDetailsList.Add(currentBooking);
                orderDetailsList.AddRange(orderDetailsLocalList);
                Console.WriteLine("\nOrders booked successfully !");
            }
            else
            {
                Console.WriteLine("\nYour orders are cancelled");
            }
        }
        else
        {
            Console.WriteLine("\nNo orders placed");
        }
    }


    public static void CancelBooking()
    {
        bool found = false;
        foreach (BookingDetails booking in bookingDetailsList)
        {
            if (booking.CustomerID == currentCustomer.CustomerID && booking.BookingStatus == BoookingStatus.Booked)
            {
                booking.ShowBookingDetails();
                found = true;
            }
        }

        if (found)
        {
            Console.Write("\nSelect a Booking ID to cancel booking order: ");
            string bookingID = Console.ReadLine().Trim().ToUpper();

            BookingDetails currentBooking = null;
            foreach (BookingDetails booking in bookingDetailsList)
            {
                if (booking.CustomerID == currentCustomer.CustomerID && booking.BookingStatus == BoookingStatus.Booked && bookingID == booking.BookingID)
                {
                    currentBooking = booking;
                }
            }

            if (currentBooking != null)
            {
                currentBooking.BookingStatus = BoookingStatus.Cancelled;
                currentCustomer.WalletBalance += currentBooking.TotalPrice;
                Console.WriteLine("\nBooking cancelled successfully");
            }
            else
            {
                Console.WriteLine("\nNo active bookings found");
            }
        }
        else
        {
            Console.WriteLine("\nNo active bookings found");
        }
    }

    public static void ShowOrderHistory()
    {
        Console.WriteLine("\tOrder ID\tBooking ID\tFood ID\t  Purchase Count\tPrice of Order");
        foreach (BookingDetails booking in bookingDetailsList)
        {
            if (currentCustomer.CustomerID == booking.CustomerID)
            {
                foreach (OrderDetails order in orderDetailsList)
                {
                    if (booking.BookingID == order.BookingID)
                    {
                        order.ShowOrderDetails();
                    }
                }
            } 
        }
    }
}

