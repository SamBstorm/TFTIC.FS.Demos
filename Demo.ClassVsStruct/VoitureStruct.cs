using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ClassVsStruct
{
    struct VoitureStruct
    {
        public int nbRoues;
        public Colors couleur;
        public string plaqueId;

        public void Rouler()
        {
            Console.WriteLine("Vroum, vroum!");
        }
        public void Klaxoner()
        {
            Console.WriteLine("Tut, tut!");
        }
        public void Freiner()
        {
            Console.WriteLine("SCCCCRRRRREEEEEEEWWWWWWW!");
        }
    }
}
