using System;

namespace OnlineGroceryStoreApplication
{
    public delegate void EventManager();
    public static class Operations
    {
        public static event EventManager eventlink = null;

        public static void Subscribe()
        {
            eventlink += new EventManager(Files.Create);
            eventlink += new EventManager(Files.ReadFiles);
            eventlink += new EventManager(MainMenu);
            eventlink += new EventManager(Files.WriteToFiles);
        }

        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }

        public static List<CustomerDetails> customersList = new List<CustomerDetails>();
        public static List<ProductDetails> productsList = new List<ProductDetails>();
        public static List<BookingDetails> bookingsList = new List<BookingDetails>();
        public static List<OrderDetails> ordersList = new List<OrderDetails>();


        static CustomerDetails currentLoggedInCustomer = null;

        public static void MainMenu()
        {

            string option = "yes";
            do
            {
                int choice;
                Console.WriteLine("\n\t1. Customer Registration\n\t2. Customer Login\n\t3. Exit");
                Console.Write("Select your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        CustomerRegistration();
                        break;
                    }
                    case 2:
                    {
                        CustomerLogin();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("\nExitting Main Menu...\n");
                        option = "no";
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\nInvalid Input");

                        break;
                    }
                }
            } while (option == "yes");
        }

        public static void CustomerRegistration()
        {
            Console.WriteLine("\nCustomer Registration");
            
            Console.Write("\n\tEnter Name:  ");
            string name = Console.ReadLine();

            Console.Write("\tEnter Father Name: ");
            string fatherName = Console.ReadLine();

            Console.Write("\tEnter Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.Write("\tEnter Mobile Number: ");
            long mobile = long.Parse(Console.ReadLine());

            Console.Write("\tEnter Date of Birth ( dd/MM/yyyy ): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("\tEnter Mail ID: ");
            string mail = Console.ReadLine();

            CustomerDetails newCustomer = new CustomerDetails(name, fatherName, gender, mobile, dob, mail);

            customersList.Add(newCustomer);

            Console.WriteLine($"\nCustomer registered successfully !  Customer ID: {newCustomer.CustomerID}");
        }

        public static void CustomerLogin()
        {
            Console.WriteLine("\nCustomer Login");

            Console.Write("\nEnter your Customer ID: ");
            string loginID = Console.ReadLine().Trim().ToUpper();

            bool found = false;

            foreach (CustomerDetails customer in customersList)
            {
                if (customer.CustomerID == loginID)
                {
                    currentLoggedInCustomer = customer;
                    found = true;
                    Console.WriteLine("\nLogged In successfully !");
                    SubMenu();
                }
            }

            if (!found)
            {
                Console.WriteLine("\nInvalid Customer ID");
            }
        }

        public static void SubMenu()
        {
            string option = "yes";
            do
            {
                Console.WriteLine("\n\ta. Show Customer Details\n\tb. Show Product Details\n\tc. Wallet Recharge\n\td. Take Order\n\te. Modify Order Quantity\n\tf. Cancel Order\n\tg. Exit");
                Console.Write("Select one of the choices: ");
                char choice = Console.ReadLine().Trim().ToLower()[0];

                switch (choice)
                {
                    case 'a':
                    {
                        currentLoggedInCustomer.ShowCustomerDetails();
                        break;
                    }
                    case 'b':
                    {
                        ShowProductDetails();
                        break;
                    }
                    case 'c':
                    {
                        currentLoggedInCustomer.WalletRecharge();
                        break;
                    }
                    case 'd':
                    {
                        TakeOrder();
                        break;
                    }
                    case 'e':
                    {
                        ModifyOrderQuantity();
                        break;
                    }
                    case 'f':
                    {
                        CancelOrder();
                        break;
                    }
                    case 'g':
                    {
                        Console.WriteLine("g");
                        option = "no";
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\nInvalid Input");
                        break;
                    }
                }
            } while (option == "yes");   
        }

        public static void ShowProductDetails()
        {
            Console.WriteLine("Product Details List");
            Console.WriteLine("\n\tProduct ID\tProduct Name\tQuantity Available\tPricePerQuantity");
            Console.WriteLine("\t----------\t------------\t------------------\t----------------");

            foreach (ProductDetails product in productsList)
            {
                product.ShowProductDetails();
            }
        }

        public static void TakeOrder()
        {
            /*  Create a booking Object
                Do While
                    Show product details list
                    select a product and check for product
                    Get the quantity and compare with availabilty
                    Calculate price and compare with customer wallet
                    Take order and create object and add in local order list */

            BookingDetails currentBooking = new BookingDetails(currentLoggedInCustomer.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
            List<OrderDetails> tempOrderList = new List<OrderDetails>();
            ProductDetails selectedProduct = null;
            double totalOrderPrice = 0;

            string choice;
            do
            {
                ShowProductDetails();

                Console.Write("\nSelect a Product from the above list by Product ID: ");
                string productID = Console.ReadLine().Trim().ToUpper();

                foreach (ProductDetails product in productsList)
                {
                    if (productID == product.ProductID)
                    {
                        selectedProduct = product;
                    }
                }

                if (selectedProduct != null)
                {
                    Console.Write("\nEnter the quantity of the product: ");
                    int enteredProductQuantity = int.Parse(Console.ReadLine());

                    if (enteredProductQuantity > 0 && enteredProductQuantity < selectedProduct.QuantityAvailable)
                    {
                        totalOrderPrice += selectedProduct.PricePerQuantity * enteredProductQuantity;

                        if (totalOrderPrice <= currentLoggedInCustomer.WalletBalance)
                        {
                            OrderDetails newOrder = new OrderDetails(currentBooking.BookingID, selectedProduct.ProductID, enteredProductQuantity, selectedProduct.PricePerQuantity * enteredProductQuantity);
                            tempOrderList.Add(newOrder);
                            selectedProduct.QuantityAvailable -= enteredProductQuantity;
                            Console.WriteLine("\nProduct added to the Cart successfully");
                        }
                        else
                        {
                            Console.WriteLine("\nInsufficient Wallet balance");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nProduct Quantity not available");
                    }
                }
                else
                {
                    Console.WriteLine("\nProduct ID not found");
                }

                Console.Write("\nDo you want to add another Product in Cart: ");
                choice = Console.ReadLine().Trim().ToLower();
            } while (choice == "yes");

            totalOrderPrice = 0;

            foreach (OrderDetails order in tempOrderList)
            {
                totalOrderPrice += order.PriceOfOrder;
            }

            Console.Write("\nDo you want to proceed: ");
            
            choice = Console.ReadLine().Trim().ToLower();

            if (choice == "yes")
            {
                while (totalOrderPrice > currentLoggedInCustomer.WalletBalance)
                {
                    Console.WriteLine($"\nInsufficient Wallet Balance. Rs. {totalOrderPrice - currentLoggedInCustomer.WalletBalance} needed");
                    currentLoggedInCustomer.WalletRecharge();
                }
                
                currentLoggedInCustomer.WalletBalance -= totalOrderPrice;
                currentBooking.BookingStatus = BookingStatus.Booked;
                currentBooking.TotalPrice = totalOrderPrice;
                bookingsList.Add(currentBooking);
                ordersList.AddRange(tempOrderList);

                Console.WriteLine($"\nOrders Booked successfully ! your Booking ID is: {currentBooking.BookingID}");
            }
            else
            {
                foreach (OrderDetails order in tempOrderList)
                {
                    foreach (ProductDetails product in productsList)
                    {
                        if (order.ProductID == product.ProductID)
                        {
                            product.QuantityAvailable += order.PurchaseCount;
                            Console.WriteLine("\nCart deleted successfully");
                        }
                    }
                }
            }
        }

        public static void ModifyOrderQuantity()
        {
            Console.WriteLine("Modify Order method called");
        }

        public static void CancelOrder()
        {
            Console.WriteLine("Cancel Order method called");
        }

        public static void AddDefaultData()
        {
            // Customer Details Data
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", Gender.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com");
            customer1.WalletBalance += 10000;
            customersList.Add(customer1);
            
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com");
            customer2.WalletBalance += 15000;
            customersList.Add(customer2);

            // Product Details Data
            productsList.Add(new ProductDetails("Sugar", 20, 40));
            productsList.Add(new ProductDetails("Rice", 100, 50));
            productsList.Add(new ProductDetails("Milk", 10, 40));
            productsList.Add(new ProductDetails("Coffee", 10, 10));
            productsList.Add(new ProductDetails("Tea", 10, 10));
            productsList.Add(new ProductDetails("Masala Powder", 10, 20));
            productsList.Add(new ProductDetails("Salt", 10, 10));
            productsList.Add(new ProductDetails("Turmeric Powder", 10, 25));
            productsList.Add(new ProductDetails("Chilli Powder", 10, 20));
            productsList.Add(new ProductDetails("Groundnut Oil", 10, 140));

            // Booking Details Data
            bookingsList.Add(new BookingDetails("CID3001", 220, new DateTime(2022, 7, 26), BookingStatus.Booked));
            bookingsList.Add(new BookingDetails("CID3002", 400, new DateTime(2022, 7, 26), BookingStatus.Booked));
            bookingsList.Add(new BookingDetails("CID3001", 280, new DateTime(2022, 7, 26), BookingStatus.Cancelled));
            bookingsList.Add(new BookingDetails("CID3002", 0, new DateTime(2022, 7, 26), BookingStatus.Initiated));

            // Order Details Data
            ordersList.Add(new OrderDetails("BID3001","PID101",2,80));
            ordersList.Add(new OrderDetails("BID3001","PID102",2,100));
            ordersList.Add(new OrderDetails("BID3001","PID103",1,40));
            ordersList.Add(new OrderDetails("BID3002","PID101",1,40));
            ordersList.Add(new OrderDetails("BID3002","PID102",4,200));
            ordersList.Add(new OrderDetails("BID3002","PID110",1,140));
            ordersList.Add(new OrderDetails("BID3002","PID109",1,20));
            ordersList.Add(new OrderDetails("BID3003","PID102",2,100));
            ordersList.Add(new OrderDetails("BID3003","PID108",4,100));
            ordersList.Add(new OrderDetails("BID3003","PID101",2,80));
        }   
    }
}
