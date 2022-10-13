using System;
namespace Question1;

public class Program
{
    public static void Main(string[] args)
    {
        RegisterPerson registerPerson = new RegisterPerson("Santhosh", MaritalStatus.Single, new DateTime(2000, 8, 21), 98234798, "santhosh@mail.com", "Iruthayaraj", "Silvia karolin", "Rameswaram", 0);
        registerPerson.ShowInfo();
    }
}
