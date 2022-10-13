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
            User userObject = new User(user);
            Program.userList.Add(userObject.UserID, userObject);
        }

        string[] medicines = File.ReadAllLines("SaveFiles/Medicine.csv");
        foreach (string medicine in medicines)
        {
            Medicine medicineObject = new Medicine(medicine);
            Program.medicineList.Add(medicineObject.MedicineID, medicineObject);
        }

        string[] orders = File.ReadAllLines("SaveFiles/Order.csv");
        foreach (string order in orders)
        {
            Order orderObject = new Order(order);
            Program.orderList.Add(orderObject.OrderID, orderObject);
        }
    }

    public static void WriteFiles()
    {
        int i = 0;

        string[] users = new string[Program.userList.Count];
        foreach (KeyValuePair<string, User> user in Program.userList)
        {
            users[i] = user.Key + "," + user.Value.UserName + "," + user.Value.Age + "," + user.Value.City + "," + user.Value.PhoneNumber + "," + user.Value.Balance;
            i++;
        }
        File.WriteAllLines("SaveFiles/User.csv", users);

        i = 0;

        string[] medicines = new string[Program.medicineList.Count];
        foreach (KeyValuePair<string, Medicine> medicine in Program.medicineList)
        {
            medicines[i] = medicine.Key + "," + medicine.Value.MedicineName + "," + medicine.Value.AvailableCount + "," + medicine.Value.Price + "," + medicine.Value.DateOfExpiry.ToString("dd/MM/yyyy");
            i++;
        }
        File.WriteAllLines("SaveFiles/Medicine.csv", medicines);

        i = 0;

        string[] orders = new string[Program.orderList.Count];

        foreach (KeyValuePair<string, Order> order in Program.orderList)
        {
            orders[i] = order.Key + "," + order.Value.UserID + "," + order.Value.MedicineID + "," + order.Value.MedicineCount + "," + order.Value.TotalPrice + "," + order.Value.OrderDate.ToString("dd/MM/yyyy") + "," + order.Value.OrderStatus;
            i++;
        }
        File.WriteAllLines("SaveFiles/Order.csv", orders);
    }
}
