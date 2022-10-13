using System;
using System.IO;

namespace OnlineMedicalStore;

public static class Files
{
    public static void CreateFiles()
    {
        if (!Directory.Exists("SaveFiles"))
        {
            Directory.CreateDirectory("SaveFiles");
            Console.WriteLine("SaveFiles directory created successfully !");
        }
        if (!File.Exists("SaveFiles/User.csv"))
        {
            File.Create("SaveFiles/User.csv");
            Console.WriteLine("User.csv file created successfully !");
        }
        if (!File.Exists("SaveFiles/Medicine.csv"))
        {
            File.Create("SaveFiles/Medicine.csv");
            Console.WriteLine("Medicine.csv file created successfully !");
        }
        if (!File.Exists("SaveFiles/Order.csv"))
        {
            File.Create("SaveFiles/Order.csv");
            Console.WriteLine("Order.csv file created successfully !");
        }
    }

    public static void ReadFiles()
    {
        string[] users = File.ReadAllLines("SaveFiles/User.csv");
        foreach (string user in users)
        {
            Program.userList.Add(new User(user));
        }

        string[] medicines = File.ReadAllLines("SaveFiles/Medicine.csv");
        foreach (string medicine in medicines)
        {
            Program.medicineList.Add(new Medicine(medicine));
        }

        string[] orders = File.ReadAllLines("SaveFiles/Order.csv");
        foreach (string order in orders)
        {
            Program.orderList.Add(new Order(order));
        }
    }

    public static void WriteFiles()
    {
        string[] users = new string[Program.userList.Count];
        for (int i = 0; i < users.Length; i++)
        {
            users[i] = Program.userList[i].UserID + "," + Program.userList[i].UserName + "," + Program.userList[i].Age + "," + Program.userList[i].City + "," + Program.userList[i].PhoneNumber + "," + Program.userList[i].Balance;
        }
        File.WriteAllLines("SaveFiles/User.csv", users);

        string[] medicines = new string[Program.medicineList.Count];
        for (int i = 0; i < medicines.Length; i++)
        {
            medicines[i] = Program.medicineList[i].MedicineID + "," + Program.medicineList[i].MedicineName + "," + Program.medicineList[i].AvailableCount + "," + Program.medicineList[i].Price + "," + Program.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
        }
        File.WriteAllLines("SaveFiles/Medicine.csv", medicines);

        string[] orders = new string[Program.orderList.Count];
        for (int i = 0; i < orders.Length; i++)
        {
            orders[i] = Program.orderList[i].OrderID + "," + Program.orderList[i].UserID + "," + Program.orderList[i].MedicineID + "," + Program.orderList[i].MedicineCount + "," + Program.orderList[i].TotalPrice + "," + Program.orderList[i].OrderDate.ToString("dd/MM/yyyy") + "," + Program.orderList[i].OrderStatus;
        }
        File.WriteAllLines("SaveFiles/Order.csv", orders);
    }
}
