using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HeritageBase
{
    public class Cat : Animal
    {
        public string FurColor { get; set; }
        public bool HaveClaws { get; set; }

        public override void Scream()
        {
            base.Scream();
            Console.WriteLine("Meow! Meow!");
        }
    }
}
