using System;
namespace VirtualOverride;

public class Dog : Animal
{
    // Using override keyword to override the method
    public override void MakeSound()
    {
        Console.WriteLine("Dog Sound");
    }
}
