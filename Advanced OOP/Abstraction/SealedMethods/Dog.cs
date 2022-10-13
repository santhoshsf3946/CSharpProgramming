using System;
namespace SealedMethods;

public class Dog : Animal
{
    // Using new keyword to seal method
    public new void MakeSound()
    {
        Console.WriteLine("Dog Sound");
    }
}
