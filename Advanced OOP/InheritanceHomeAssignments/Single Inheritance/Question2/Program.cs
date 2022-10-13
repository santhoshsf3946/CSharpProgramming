using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n============== Single Inheritance ==============\n");

        AccountInfo account = new AccountInfo("Santhosh", "Iruthayaraj", 9789429543, "santhosh@mail.com", new DateTime(2000, 8, 21), Gender.Male, "Chetpet", "HDFC3815", 21129.40);

        account.ShowInfo();
    }
}
