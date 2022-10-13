using System;
using System.Collections.Generic;
namespace ECommerce;

public class Program
{
    public static List<CustomerDetails> customerList = new List<CustomerDetails>();
    public static List<ProductDetails> productList = new List<ProductDetails>();
    public static List<OrderDetails> orderList = new List<OrderDetails>();

    static CustomerDetails currentCustomer = null;

    public static void Main(string[] args)
    {
        Console.WriteLine("====================== E Commerce Application ======================");

        Files.Create();
        Files.ReadFiles();

        // SetCustomerDetailsSampleData();
        // SetProductDetailsSampleData();
        // SetOrderDetailsSampleData();

        MainMenu();

        Files.WriteToFiles();
    }

    public static void MainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n\t1. Customer Registration \n\t2. Login and Purchase \n\t3. Exit");
            Console.Write("Select one of the above choices: ");
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
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exitting...");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
        } while (choice != 3);       
    }

    public static void CustomerRegistration()
    {
        Console.Write("\nEnter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        long phone = long.Parse(Console.ReadLine());

        Console.Write("Enter Mail ID: ");
        string mail = Console.ReadLine();

        Console.Write("Enter wallet initial balance: ");
        double initialAmount = double.Parse(Console.ReadLine());

        CustomerDetails newCustomer = new CustomerDetails(name, city, phone, initialAmount, mail);

        customerList.Add(newCustomer);

        Console.WriteLine($"Customer added successfully and Customer ID: {newCustomer.CustomerID}");
    }

    public static void Login()
    {
        Console.Write("\nEnter your Customer ID: ");
        string customerID = Console.ReadLine().Trim().ToUpper();

        foreach (var customer in customerList)
        {
            if (customer.CustomerID == customerID)
            {
                currentCustomer = customer;
                Console.WriteLine($"\nLogin Successfull !\tWelcome {currentCustomer.Name}");
                ShowSubMenu();
            }
        }

        if (currentCustomer == null)
        {
            Console.WriteLine("Invalid Customer ID");
        }
    }

    public static void ShowSubMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n\ta. Purchase \n\tb. Order History \n\tc. Cancel Order \n\td. Wallet Balance \n\te. Logout");
            Console.Write("Select one of the above choices: ");
            choice = char.Parse(Console.ReadLine().Trim().ToLower());

            switch (choice)
            {
                case 'a':
                {
                    Purchase();
                    break;
                }
                case 'b':
                {
                    OrderHistrory();
                    break;
                }
                case 'c':
                {
                    CancelOrder();
                    break;
                }
                case 'd':
                {
                    WalletBalance();
                    break;
                }
                case 'e':
                {
                    Console.WriteLine("Logged out successfully");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
        } while (choice != 'e');
    }

    public static void Purchase()
    {
        Console.WriteLine();
        foreach (var product in productList)
        {
            product.ShowProductDetails();
        }

        Console.Write("\nSelect a product using product ID: ");
        string productID = Console.ReadLine().ToUpper();

        ProductDetails foundProduct = null;
        foreach (var product in productList)
        {
            if (productID == product.ProductID)
            {
                foundProduct = product;
            }
        }

        double totalPrice;

        if (foundProduct == null)
        {
            Console.WriteLine("\nEnter a valid Product ID");
        }
        else
        {
            Console.Write("Enter quantity of the item: ");
            int quantity = int.Parse(Console.ReadLine());

            if (quantity <= foundProduct.Stock)
            {
                totalPrice = quantity * foundProduct.Price + 50;
                if (totalPrice > currentCustomer.WalletBalance)
                {
                    Console.WriteLine("\nInsufficient Wallet Balance. Please recharge your wallet");
                }
                else
                {
                    currentCustomer.WalletBalance -= totalPrice;
                    foundProduct.Stock -= quantity;
                    OrderDetails order = new OrderDetails(currentCustomer.CustomerID, foundProduct.ProductID, totalPrice, DateTime.Now, quantity, OrderStatus.Ordered);
                    orderList.Add(order);
                    Console.WriteLine($"Order placed successfully. Your order will be delivered on {order.PurchaseDate.AddDays(foundProduct.ShippingDuration).ToString("dd/MM/yyyy")}");
                }
            }
            else
            {
                Console.WriteLine("Required Stock is not available");
            }
        }
    }

    public static void OrderHistrory()
    {
        Console.WriteLine();
        bool found = false;
        foreach (var order in orderList)
        {
            if (currentCustomer.CustomerID == order.CustomerID)
            {
                order.ShowOrderDetails();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No order history found");
        }
    }

    public static void CancelOrder()
    {
        OrderHistrory();

        Console.Write("\nSelect an Order to be cancelled by the Order ID: ");
        string orderID = Console.ReadLine().Trim().ToUpper();
        
        OrderDetails selectedOrder = null;
        foreach (var order in orderList)
        {
            if (order.OrderID == orderID)
            {
                selectedOrder = order;
            }
        }
        if (selectedOrder != null)
        {
            foreach (var currentProduct in productList)
            {
                if (selectedOrder.ProductID == currentProduct.ProductID)
                {
                    currentProduct.Stock += selectedOrder.Quantity;
                    currentCustomer.WalletBalance += selectedOrder.TotalPrice;
                    selectedOrder.OrderStatus = OrderStatus.Cancelled;
                    Console.WriteLine("Order cancelled successfully");
                }
            }
        }
        else
        {
            Console.WriteLine("Order not found");
        }
    }

    public static void WalletBalance()
    {
        Console.WriteLine($"\nbalance available in your wallet: {currentCustomer.WalletBalance}");

        Console.Write("Do you want to recharge your wallet: ");
        string choice = Console.ReadLine().ToLower();
        if (choice == "yes")
        {
            Console.Write("\nEnter the amount to be added in the wallet: ");
            currentCustomer.WalletRecharge(double.Parse(Console.ReadLine()));
        }
    }

    public static void SetCustomerDetailsSampleData()
    {
        customerList.Add(new CustomerDetails("Ravi", "Chennai", 9885858588, 50000, "ravi@mail.com"));
        customerList.Add(new CustomerDetails("Baskaran", "Chennai", 9888475757, 60000, "baskaran@mail.com"));
    }

    public static void SetProductDetailsSampleData()
    {
        productList.Add(new ProductDetails("Mobile", 10000, 10, 3));
        productList.Add(new ProductDetails("Tablet", 15000, 5, 2));
        productList.Add(new ProductDetails("Camera", 20000, 3, 4));
        productList.Add(new ProductDetails("iPhone", 50000, 5, 6));
        productList.Add(new ProductDetails("Laptop", 40000, 3, 3));
    }

    public static void SetOrderDetailsSampleData()
    {
        orderList.Add(new OrderDetails("CID1001", "PID101", 20000, DateTime.Now, 2, OrderStatus.Ordered));
        orderList.Add(new OrderDetails("CID1001", "PID102", 40000, DateTime.Now, 2, OrderStatus.Ordered));
    }
}
