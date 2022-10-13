using System;
namespace Question2;

public class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee permanentEmployee = new PermanentEmployee("EID1001", "Team Leader", 500, 5);

        permanentEmployee.ShowSalary();

        TemporaryEmployee temporaryEmployee = new TemporaryEmployee("EID2001", "Programmer", 500, 5);

        temporaryEmployee.ShowSalary();
    }
}
