using System;

namespace Demo.HeritageBase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne() { 
                Nom = "Legrain",
                Prenom = "Samuel",
                DateNaiss = new DateTime(1987, 9, 27)
            };

            Employe e = new Employe()
            {
                Nom = "Baudoux",
                Prenom = "Loïc",
                DateNaiss = new DateTime(1987, 9, 27),
                Fonction="Developpeur",
                NomEntreprise = "BrainStorm"
            };


            Responsable r = new Responsable()
            {
                Nom = "Morre",
                Prenom = "Thierry",
                DateNaiss = new DateTime(1987, 9, 27),
                Fonction = "Developpeur",
                NomEntreprise = "BrainStorm",
                EmployesSurveilles = new System.Collections.Generic.List<Employe>() { e }
            };
            p.SePresenter();
            e.SePresenter();
            r.SePresenter();
        }
    }
}
