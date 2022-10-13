using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class Puppy : Dog
    {
        // Using override keyword to override the method
        public override void MakeSound()
        {
            Console.WriteLine("Puppy Sound");
        }
    }
}
