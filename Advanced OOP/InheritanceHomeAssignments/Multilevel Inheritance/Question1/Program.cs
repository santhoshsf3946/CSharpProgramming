using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        HSCDetails studentHSC = new HSCDetails(942428374, "Santhosh", "Iruthayaraj", 28347932904, "santhosh@mail.com", new DateTime(2000, 8, 21), Gender.Male, "12th", "Biology", 2018, 8912379837292387, 98, 89, 95);

        studentHSC.ShowInfo();
    }
}
