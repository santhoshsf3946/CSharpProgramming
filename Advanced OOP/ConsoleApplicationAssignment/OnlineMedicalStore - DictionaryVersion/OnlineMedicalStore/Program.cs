using System;
namespace OnlineMedicalStore;

public class Program
{
    public static Dictionary<string, User> userList = new Dictionary<string, User>();
    public static Dictionary<string, Medicine> medicineList = new Dictionary<string, Medicine>();
    public static Dictionary<string, Order> orderList = new Dictionary<string, Order>();

    static User currentUser = null;

    public static void Main(string[] args)
    {
        Console.WriteLine("\n================= Online Medical Store =================");

        Files.CreateFiles();
        Files.ReadFiles();


        ShowMainMenu();

        
        Files.WriteFiles();
    }

    public static void ShowMainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\nMain Menu\n---------");
            Console.WriteLine("\t1. User Registration\n\t2. User Login\n\t3. Order History\n\t4. Exit");
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
                    UserLogin();
                    break;
                }
                case 3:
                {
                    ShowOrderHistory();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("\nExitting...\n");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInavlid Choice");
                    break;
                }
            }
        } while (choice != 4);
    }

    public static void ShowSubMenu()
    {
        char choice;
        do
        {
            Console.WriteLine($"\nSub Menu\t\tUser: {currentUser.UserName}\n---------");
            Console.WriteLine("\ta. Show Medicine List\n\tb. Purchase Medicine\n\tc. Cancel Purchase\n\td. Show Purchase History\n\te. Recharge\n\tf. Show Balance\n\tg. Logout");
            Console.Write("Enter your choice: ");

            choice = Console.ReadLine().Trim().ToLower()[0];

            switch (choice)
            {
                case 'a':
                {
                    ShowMedicineList();
                    break;
                }
                case 'b':
                {
                    PurchaseMedicine();
                    break;
                }
                case 'c':
                {
                    CancelPurchase();
                    break;
                }
                case 'd':
                {
                    ShowPurchaseHistory();
                    break;
                }
                case 'e':
                {
                    currentUser.Recharge();
                    break;
                }
                case 'f':
                {
                    currentUser.ShowBalance();
                    break;
                }
                case 'g':
                {
                    Console.WriteLine("\nLogged out successfully !");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInavlid Choice");
                    break;
                }
            }
        } while (choice != 'g');
    }

    public static void UserRegistration()
    {
        Console.WriteLine("\nUser Registration\n-----------------");

        Console.Write("\tEnter your Name: ");
        string name = Console.ReadLine();

        Console.Write("\tEnter your Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("\tEnter your City: ");
        string city = Console.ReadLine();

        Console.Write("\tEnter your Phone number: ");
        long phone = long.Parse(Console.ReadLine());

        Console.Write("\tEnter your Wallet initial balance: ");
        double balance = double.Parse(Console.ReadLine());

        User newUser = new User(name, age, city, phone, balance);

        userList.Add(newUser.UserID, newUser);

        Console.WriteLine($"\nUser Registered successfully ! Your ID is: {newUser.UserID}\n");
    }

    public static void UserLogin()
    {
        Console.Write("\nEnter your User ID to login: ");
        string userID = Console.ReadLine().Trim().ToUpper();

        // foreach removed by using using contains key
        if (userList.ContainsKey(userID))
        {
            currentUser = userList[userID];
        }
    
        if (currentUser != null)
        {
            Console.WriteLine($"\nLogged in successfully !");
            ShowSubMenu();
        }
        else
        {
            Console.WriteLine("\nInavlid User ID");
        }
    }

    public static void ShowMedicineList()
    {
        Console.WriteLine("\nMedicine List\n-------------");
        MedicineDetails();
    }

    public static void PurchaseMedicine()
    {
        Console.WriteLine("\nPurchase Medicine\n-----------------");
        Medicine selectedMedicine = null;

        MedicineDetails();

        Console.Write("\nEnter the ID of the Medicine you want to purchase: ");
        string medicineID = Console.ReadLine().Trim().ToUpper();

        
        if (medicineList.ContainsKey(medicineID))
        {
            selectedMedicine = medicineList[medicineID];
        }
    

        if (selectedMedicine != null)
        {
            if (selectedMedicine.DateOfExpiry >= DateTime.Now)
            {
                Console.Write($"\nEnter how many {selectedMedicine.MedicineName}s you need: ");
                int medicineCount = int.Parse(Console.ReadLine());

                if (medicineCount <= selectedMedicine.AvailableCount)
                {
                    double totalPrice = selectedMedicine.Price * medicineCount;

                    if (currentUser.Balance >= totalPrice)
                    {
                        Order newOrder = new Order(currentUser.UserID, selectedMedicine.MedicineID, medicineCount, totalPrice, DateTime.Now, Status.Purchased);
                        orderList.Add(newOrder.OrderID, newOrder);
                        selectedMedicine.AvailableCount -= medicineCount;
                        currentUser.Balance -= totalPrice;
                        Console.WriteLine("\nMedicine purchased successfully");
                    }
                }
                else
                {
                    Console.WriteLine("\nMedicine not available");
                }
            }
            else
            {
                Console.WriteLine("\nMedicine was expired");
            }
        }
        else
        {
            Console.WriteLine("\nInvalid Medicine ID");
        }
    }

    public static void CancelPurchase()
    {
        Console.WriteLine("\nCancel Purchase\n---------------\n");

        bool orderFound = false;

        foreach (KeyValuePair<string, Order> order in orderList)
        {
            if (order.Value.UserID == currentUser.UserID && order.Value.OrderStatus == Status.Purchased)
            {
                orderFound = true;
            }
        }

        if (orderFound)
        {
            Console.WriteLine($"\t{"Order ID", -13}{"User ID", -12}{"Medicine ID", -16}{"Medicine Count", -19}{"Total Price", -16}{"Order Date", -17}{"Order Status", -16}");
            Console.WriteLine($"\t{"--------", -13}{"-------", -12}{"-----------", -16}{"--------------", -19}{"-----------", -16}{"----------", -17}{"------------", -16}");

            foreach (KeyValuePair<string, Order> order in orderList)
            {
                if (order.Value.UserID == currentUser.UserID && order.Value.OrderStatus == Status.Purchased)
                {
                    Console.WriteLine($"\t{order.Value.OrderID, -13}{order.Value.UserID, -12}{order.Value.MedicineID, -16}{((byte)order.Value.MedicineCount), 14}\t{order.Value.TotalPrice, 15}{order.Value.OrderDate.ToString("dd/MM/yyyy"), 15}{order.Value.OrderStatus, 16}");
                }
            }

            Console.Write("\nEnter Order ID you want to cancel: ");
            string orderID = Console.ReadLine().Trim().ToUpper();
            
            bool found = false;
            if (orderList.ContainsKey(orderID))
            {
                if (currentUser.UserID == orderList[orderID].UserID && orderList[orderID].OrderStatus == Status.Purchased)
                {
                    if (orderID == orderList[orderID].OrderID && currentUser.UserID == orderList[orderID].UserID && orderList[orderID].OrderStatus == Status.Purchased)
                    {
                        if (medicineList.ContainsKey(orderList[orderID].MedicineID))
                        {
                            medicineList[orderList[orderID].MedicineID].AvailableCount += orderList[orderID].MedicineCount;
                        }
                        currentUser.Balance += orderList[orderID].TotalPrice;
                        orderList[orderID].OrderStatus = Status.Cancelled;
                        found = true;
                        Console.WriteLine($"\n{orderID} was cancelled successfully !");
                    }
                }
            } 
            if (!found)
            {
                Console.WriteLine("\nInvalid Order ID");
            }
        }
        else
        {
            Console.WriteLine("\tNo Order history found");
        }
    }

    public static void ShowPurchaseHistory()
    {
        Console.WriteLine("\nPurchase History\n----------------\n");

        bool orderFound = false;

        foreach (KeyValuePair<string, Order> order in orderList)
        {
            if (order.Value.UserID == currentUser.UserID)
            {
                orderFound = true;
            }
        }
        if (orderFound)
        {
            Console.WriteLine($"\t{"Order ID", -13}{"User ID", -12}{"Medicine ID", -16}{"Medicine Count", -19}{"Total Price", -16}{"Order Date", -17}{"Order Status", -16}");
            Console.WriteLine($"\t{"--------", -13}{"-------", -12}{"-----------", -16}{"--------------", -19}{"-----------", -16}{"----------", -17}{"------------", -16}");

            foreach (KeyValuePair<string, Order> order in orderList)
            {
                if (order.Value.UserID == currentUser.UserID)
                {
                    Console.WriteLine($"\t{order.Value.OrderID, -13}{order.Value.UserID, -12}{order.Value.MedicineID, -16}{((byte)order.Value.MedicineCount), 14}\t{order.Value.TotalPrice, 15}{order.Value.OrderDate.ToString("dd/MM/yyyy"), 15}{order.Value.OrderStatus, 16}");
                }
            }
        }
        else
        {
            Console.WriteLine("\tNo Order history found");
        }
    }

    public static void ShowOrderHistory()
    {
        Console.WriteLine("\nOrder History\n-------------\n");

        bool orderFound = false;

        foreach (KeyValuePair<string, Order> order in orderList)
        {
            orderFound = true;
        }
        if (orderFound)
        {
            Console.WriteLine($"\t{"Order ID", -13}{"User ID", -12}{"Medicine ID", -16}{"Medicine Count", -19}{"Total Price", -16}{"Order Date", -17}{"Order Status", -16}");
            Console.WriteLine($"\t{"--------", -13}{"-------", -12}{"-----------", -16}{"--------------", -19}{"-----------", -16}{"----------", -17}{"------------", -16}");

            foreach (KeyValuePair<string, Order> order in orderList)
            {
                Console.WriteLine($"\t{order.Value.OrderID, -13}{order.Value.UserID, -12}{order.Value.MedicineID, -16}{((byte)order.Value.MedicineCount), 14}\t{order.Value.TotalPrice, 15}{order.Value.OrderDate.ToString("dd/MM/yyyy"), 15}{order.Value.OrderStatus, 16}");
            }
        }
        else
        {
            Console.WriteLine("\tNo Order history found");
        }
    }

    public static void MedicineDetails()
    {
        Console.WriteLine("\n\tMedicine Id\tMedicine Name\tAvailable Count\t   Price\tDate of Expiry\n\t-----------\t-------------\t---------------\t   -----\t--------------");

        foreach (KeyValuePair<string, Medicine> medicine in medicineList)
        {
            Console.WriteLine($"\t{medicine.Value.MedicineID}\t\t{medicine.Value.MedicineName, -10}\t{medicine.Value.AvailableCount, 14}\t   {medicine.Value.Price, 5}\t{medicine.Value.DateOfExpiry.ToString("dd/MM/yyyy")}");
        }
    }
}
