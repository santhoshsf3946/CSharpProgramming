using System;
using System.Collections.Generic;
namespace LibraryManagementSystem;

public class Program
{
    static List<UserDetails> userList = new List<UserDetails>();
    static List<BookDetails> bookList = new List<BookDetails>();
    static List<BorrowDetails> borrowList = new List<BorrowDetails>();

    static UserDetails currentUser = null;

    public static void Main(string[] args)
    {
        SetUserDetailsSampleData();
        SetBookDetailsSampleData();
        SetBorrowDetailsSampleData();

        MainMenu();
    }

    public static void MainMenu()
    {
        
        int choice;
        do
        {
            Console.WriteLine("\n\t1. User Registration\n\t2. User Login\n\t3. Exit");
            Console.Write("Select one of the above choices: ");
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
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
        } while (choice != 3);
    }

    public static void UserRegistration()
    {
        Console.Write("\n Enter your Name: ");
        string name = Console.ReadLine();

        Console.Write(" Enter your Gender: ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

        Console.Write(" Enter your Department: ");
        Department department = Enum.Parse<Department>(Console.ReadLine(), true);

        Console.Write(" Enter your Mibile Number: ");
        long mobileNumber = long.Parse(Console.ReadLine());

        Console.Write(" Enter your Mail ID: ");
        string mailID = Console.ReadLine();

        Console.Write("Enter initial wallet balance: ");
        double balance = double.Parse(Console.ReadLine());

        UserDetails newUser = new UserDetails(name, gender,department,mobileNumber, mailID, balance);

        userList.Add(newUser);

        Console.WriteLine($"\nUser registered successfully! Your user ID is: {newUser.RegisterationID}");
    }

    public static void Login()
    {
        Console.Write("\nEnter your User ID: ");
        string userID = Console.ReadLine().Trim().ToUpper();

        foreach (var user in userList)
        {
            if (userID == user.RegisterationID)
            {
                currentUser = user;
            }
        }

        if (currentUser != null)
        {
            Console.WriteLine($"\nLogged in successfull\t Welcome {currentUser.UserName}");
            SubMenu();
        }
        else
        {
            Console.WriteLine("\nLogin failed! Invalid user ID");
        }
    }

    public static void SubMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n\t1. Borrow Book\n\t2. Show Borrowed History\n\t3. Return Books\n\t4. Show Wallet Balance\n\t5. Logout");
            Console.Write("Select one of the above choices: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    BorrowBook();
                    break;
                }
                case 2:
                {
                    ShowBorrowedHistory();
                    break;
                }
                case 3:
                {
                    returnBooks();
                    break;
                }
                case 4:
                {
                    currentUser.ShowWalletBalance();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("\nLogged out successfully");
                    break;
                }
                default:
                {
                    Console.WriteLine("\nInvalid Input");
                    break;
                }
            }
        } while (choice != 5);
    }

    public static void BorrowBook()
    {
        int borrowCount = 0;
        foreach (var borrow in borrowList)
        {
            if (currentUser.RegisterationID == borrow.RegistrationID && borrow.Status == Status.Assigned)
            {
                borrowCount++;
            }
        }
        if (borrowCount < 3)
        {
            Console.WriteLine("\n\tBook ID\t\tBook Name\tAuthor Name\t\tBook Count\n");
            foreach (var book in bookList)
            {
                Console.WriteLine($"\t{book.BookID}\t\t{book.BookName}\t\t{book.AuthorName}\t\t\t{book.BookCount}");
            }

            Console.Write("\nEnter Book ID to borrow: ");
            string bookID = Console.ReadLine().Trim().ToUpper();

            BookDetails selectedBook = null;

            foreach (var book in bookList)
            {
                if (bookID == book.BookID)
                {
                    selectedBook = book;
                }
            }

            if (selectedBook != null)
            {
                if (selectedBook.BookCount > 0)
                {
                    BorrowDetails newBorrow = new BorrowDetails(currentUser.RegisterationID, selectedBook.BookID, DateTime.Now, Status.Assigned);
                    borrowList.Add(newBorrow);
                    selectedBook.BookCount--;
                    Console.WriteLine("\nBook borrowed successfully!");
                }
                else
                {
                    Console.Write("\nBooks are not available. \n\nThe Book will be available on: ");
                    foreach (var borrow in borrowList)
                    {
                        if (bookID == borrow.BookID)
                        {
                            Console.Write(borrow.BorrowedDate.AddDays(15).ToShortDateString());
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nBook not found");
            }
        }
        else
        {
            Console.WriteLine("\nYou can only take maximum of 3 books at a time");
        }
    }

    public static void ShowBorrowedHistory()
    {
        Console.WriteLine("\n\tBorrow ID\t\tBook ID\t\tRegistration ID\t\tBorrowed Date\t\tStatus");
        foreach (var borrow in borrowList)
        {
            if (borrow.RegistrationID == currentUser.RegisterationID)
            {
                Console.WriteLine($"\t{borrow.BorrowID}\t\t\t{borrow.BookID}\t\t{borrow.RegistrationID}\t\t\t{borrow.BorrowedDate.ToShortDateString()}\t\t{borrow.Status}");
            }
        }
    }

    public static void returnBooks()
    {
        ShowBorrowedHistory();
        Console.Write("\nEneter the borrow ID to return the book you borrowed: ");
        string borrowID = Console.ReadLine().Trim().ToUpper();

        foreach (var borrow in borrowList)
        {
            if (borrowID == borrow.BorrowID && borrow.Status == Status.Assigned)
            {
                BookDetails selectedBook = null;
                foreach (var book in bookList)
                {
                    if (borrow.BookID == book.BookID)
                    {
                        selectedBook = book;
                    }
                }
                Console.Write($"\nReturn Date of the \"{selectedBook.BookName}\" book is: {borrow.BorrowedDate.AddDays(15).ToShortDateString()}");
                if (borrow.BorrowedDate.AddDays(15) < DateTime.Now)
                {
                    TimeSpan afterDueDate = DateTime.Now - borrow.BorrowedDate.AddDays(15);

                    Console.WriteLine($"\nYou have crossed {afterDueDate.Days} days afet your date. So you have pay Rs. {afterDueDate.Days} fine.");

                    Console.Write("\nDo you want to pay the fine amount and return the book: ");
                    string choice = Console.ReadLine().Trim().ToLower();

                    if (choice == "yes")
                    {
                        borrow.Status = Status.Returned;
                        selectedBook.BookCount++;
                        currentUser.WalletBalance -= afterDueDate.Days;
                        Console.WriteLine("\nYou returned the book successfully!");
                    }
                }
                else
                {
                    Console.Write("\nThe due date isn't over, do you want to return your book ( yes/no ): ");
                    string choice = Console.ReadLine().Trim().ToLower();
                    if (choice == "yes")
                    {
                        borrow.Status = Status.Returned;
                        selectedBook.BookCount++;
                        Console.WriteLine("\nYou returned the book successfully!");
                    }
                }
            }
        }
    }

    public static void SetUserDetailsSampleData()
    {
        userList.Add(new UserDetails("Ravichandran", Gender.Male, Department.EEE, 9938388333, "ravi@gmail.com", 5000));
        userList.Add(new UserDetails("Priyadharshini", Gender.Female, Department.CSE, 9944444455, "priya@gmail.com", 5000));
    }

    public static void SetBookDetailsSampleData()
    {
        bookList.Add(new BookDetails("C#", "Author1", 3, 100));
        bookList.Add(new BookDetails("HTML", "Author2", 5, 200));
        bookList.Add(new BookDetails("CSS", "Author1", 3, 300));
        bookList.Add(new BookDetails("JS", "Author1", 3, 400));
        bookList.Add(new BookDetails("TS", "Author1", 2, 500));
    }

    public static void SetBorrowDetailsSampleData()
    {
        borrowList.Add(new BorrowDetails("SF3001" ,"BID101", new DateTime(2022, 4, 10), Status.Assigned));
        borrowList.Add(new BorrowDetails("SF3001" ,"BID103", new DateTime(2022, 4, 12), Status.Returned));
        borrowList.Add(new BorrowDetails("SF3001" ,"BID104", new DateTime(2022, 4, 15), Status.Assigned));
        borrowList.Add(new BorrowDetails("SF3002" ,"BID102", new DateTime(2022, 4, 11), Status.Returned));
        borrowList.Add(new BorrowDetails("SF3002" ,"BID105", new DateTime(2022, 4, 15), Status.Assigned));
    }
}
