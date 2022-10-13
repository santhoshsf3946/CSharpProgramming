using System;
namespace OnlineMedicalStore;

public enum Status { Default, Purchased, Cancelled }

public class Order
{
    private static int s_orderID = 2000;

    public string OrderID { get; set; }

    public string UserID { get; set; }

    public string MedicineID { get; set; }

    public int MedicineCount { get; set; }

    public double TotalPrice { get; set; }

    public DateTime OrderDate { get; set; }

    public Status OrderStatus { get; set; }

    public Order(string userID, string medicineID, int medicineCount, double totalPrice, DateTime orderDate, Status orderStatus)
    {
        OrderID = $"OID{++s_orderID}";
        UserID = userID;
        MedicineID = medicineID;
        MedicineCount = medicineCount;
        TotalPrice = totalPrice;
        OrderDate = orderDate;
        OrderStatus = orderStatus;
    }

    public Order(string data)
    {
        string[] values = data.Split(',');
        s_orderID = int.Parse(values[0].Remove(0, 3));
        OrderID = values[0];
        UserID = values[1];
        MedicineID = values[2];
        MedicineCount = int.Parse(values[3]);
        TotalPrice = double.Parse(values[4]);
        OrderDate = DateTime.ParseExact(values[5], "dd/MM/yyyy", null);
        OrderStatus = Enum.Parse<Status>(values[6]);
    }
}
