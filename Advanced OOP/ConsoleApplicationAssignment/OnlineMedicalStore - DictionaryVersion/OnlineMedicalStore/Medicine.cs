using System;
namespace OnlineMedicalStore;

public class Medicine
{
    private static int s_medicineID = 100;
    
    public string MedicineID { get; set; }

    public string MedicineName { get; set; }

    public int AvailableCount { get; set; }

    public double Price { get; set; }

    public DateTime DateOfExpiry { get; set; }

    public Medicine(string medicineName, int availableCount, double price, DateTime dateOfExpiry)
    {
        MedicineID = $"MD{++s_medicineID}";
        MedicineName = medicineName;
        AvailableCount = availableCount;
        Price = price;
        DateOfExpiry = dateOfExpiry;
    }

    public Medicine(string data)
    {
        string[] values = data.Split(',');
        s_medicineID = int.Parse(values[0].Remove(0,2));
        MedicineID = values[0];
        MedicineName = values[1];
        AvailableCount = int.Parse(values[2]);
        Price = double.Parse(values[3]);
        DateOfExpiry = DateTime.ParseExact(values[4], "dd/MM/yyyy", null);
    }
}
