using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HeritageBase2
{
    class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }

        public virtual void SePresenter()
        {
            Console.WriteLine($"Je m'appelle {Nom} {Prenom}, je suis né en {DateNaiss.Year}.");
        } 
    }
}
