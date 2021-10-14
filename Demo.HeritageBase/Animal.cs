using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HeritageBase
{
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int MembersCount { get; set; }

        public virtual void Scream() {
            Console.WriteLine($"Agrou, agrou, I'm a {Species}, my name is {Name}, and I've {MembersCount} members.");
        }
    }
}
