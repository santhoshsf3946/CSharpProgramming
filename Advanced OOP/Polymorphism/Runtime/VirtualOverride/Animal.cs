using System;
namespace VirtualOverride;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Sound");
    }
}
