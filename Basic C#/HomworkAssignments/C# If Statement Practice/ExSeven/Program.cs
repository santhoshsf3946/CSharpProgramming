using System;
namespace ExSeven;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("============== Electricity Borad ==============\n");

        Console.Write("Enter customer ID: ");
        int customerId = int.Parse(Console.ReadLine());

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();
        
        Console.Write("Enter the amount of Units Consumed: ");
        double unit = double.Parse(Console.ReadLine());

        double chargePerUnit, amount, surcharge, totalAmount;

        if (unit < 100) 
        {
            chargePerUnit = 1;
        }
        else if (unit < 200)
        {
            chargePerUnit = 1.2;
        }
        else if (unit < 400)
        {
            chargePerUnit = 1.5;
        }
        else if (unit < 600)
        {
            chargePerUnit = 1.8;
        }
        else
        {
            chargePerUnit = 2;
        }

        amount = chargePerUnit == 1 ? 100 : unit * chargePerUnit;
        surcharge = amount > 400 ? amount * 0.15 : 0;
        totalAmount = amount + surcharge;

        Console.WriteLine("\nElectricity Bill");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Customer IDNO: {customerId}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Unit Consumed: {unit}");
        Console.WriteLine($"Amount Charges @Rs. {chargePerUnit} per Unit: {amount}");
        Console.WriteLine($"Surcharge Amount: {surcharge}");
        Console.WriteLine($"Net Amount paid by the Customer: {totalAmount}");
    }
}
