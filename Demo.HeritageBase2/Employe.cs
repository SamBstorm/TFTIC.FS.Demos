using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HeritageBase2
{
    class Employe : Personne
    {
        public string Fonction { get; set; }
        public string NomEntreprise { get; set; }

        public override void SePresenter()
        {
            base.SePresenter();
            Console.WriteLine($"Je travaille pour {NomEntreprise}, en tant que {Fonction}.");
        }
    }
}
