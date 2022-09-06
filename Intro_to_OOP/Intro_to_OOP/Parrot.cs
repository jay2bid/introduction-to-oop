using System;
namespace Intro_to_OOP
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Arggggh my name is {Name} and I'm a jack sparrows {Color} parrot.");
        }

        
    }
}

