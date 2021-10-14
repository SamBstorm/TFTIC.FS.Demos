using System;

namespace Demo.HeritageBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal() { Species = "Fish", Name = "Fishstick", MembersCount = 0 };
            Animal c = new Cat() { Species = "Feline", FurColor = "White", MembersCount = 4, HaveClaws = true, Name = "Felix" };

            a.Scream();
            c.Scream();
        }
    }
}
