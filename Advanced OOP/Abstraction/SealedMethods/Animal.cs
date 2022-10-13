using System;
namespace SealedMethods;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Sound");
    }
}
