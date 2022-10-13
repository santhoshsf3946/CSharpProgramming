using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses;
public class TCS : AbstractBase
{
    // Abstract property definition

    public override string Name { get{ return name; } set{ name = value; } }

    // Abstract Method definition

    public override void Salary(int dates)
    {
        Console.WriteLine("\n================ TCS Employee Salary ================");
        Display();
        Amount = dates * 300.0;
        Console.WriteLine($"\nSalary: {Amount}\n");
    }
}
