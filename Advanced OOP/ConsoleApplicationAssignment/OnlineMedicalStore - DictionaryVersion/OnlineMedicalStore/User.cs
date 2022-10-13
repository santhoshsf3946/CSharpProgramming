using System;
namespace OnlineMedicalStore;

public class User
{
    private static int s_userID = 1000;

    public string UserID { get; }

    public string UserName { get; set; }

    public int Age { get; set; }

    public string City { get; set; }

    public long PhoneNumber { get; set; }

    public double Balance { get; set; }

    public User(string userName, int age, string city, long phoneNumber, double balance)
    {
        UserID = $"UID{++s_userID}";
        UserName = userName;
        Age = age;
        City = city;
        PhoneNumber = phoneNumber;
        Balance = balance;
    }

    public User(string data)
    {
        string[] values = data.Split(',');
        s_userID = int.Parse(values[0].Remove(0, 3));
        UserID = values[0];
        UserName = values[1];
        Age = int.Parse(values[2]);
        City = values[3];
        PhoneNumber = long.Parse(values[4]);
        Balance = double.Parse(values[5]);
    }

    public void ShowBalance()
    {
        Console.WriteLine($"\nYour current wallet balance is: {Balance}");
    }

    public void Recharge()
    {
        ShowBalance();
        Console.Write("\nEnter amount to recharge: ");

        Balance += double.Parse(Console.ReadLine());
        Console.WriteLine("Wallet recharged successfully !");

        ShowBalance();
    }
}
