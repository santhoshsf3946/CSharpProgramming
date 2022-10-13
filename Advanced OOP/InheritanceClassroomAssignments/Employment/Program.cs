using System;
namespace Employment;

public class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails personalDetails = new PersonalDetails("Santhosh", "Iruthayaraj", Gender.Male, 9789429543);

        personalDetails.ShowDetails();
    }
}
