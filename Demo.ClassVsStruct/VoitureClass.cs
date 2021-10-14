using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ClassVsStruct
{
    public class VoitureClass
    {
        private int _nbRoues = 4;

        public int NbRoues
        {
            get { return _nbRoues; }
            set {
                if (value > 0) _nbRoues = value;
                else _nbRoues = 0;
            }
        }

        //Au lieu d'utiliser un champs et une propriété,
        //qui cette dernière n'apporte aucun contrôle sur les données
        //Alors on préférera une auto-propriété :
        #region Sans Auto-propriété
        //private Colors _couleur;

        //public Colors Couleur { 
        //    get { return _couleur; } 
        //    set { _couleur = value; } 
        //}
        #endregion
        #region Avec Auto-propriété
        public Colors Couleur { get; set; } 
        #endregion

        string PlaqueId;

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


        //Si nous voulons effectuer une copie d'une class, 
        //il nous faux créer une nouvelle instance de celle-ci
        //comme le fait notre méthode Clone()
        public VoitureClass Clone()
        {
            VoitureClass clone = new VoitureClass();
            clone.NbRoues = NbRoues;
            clone.Couleur = Couleur;
            clone.PlaqueId = PlaqueId;
            return clone;
        }
    }
}
