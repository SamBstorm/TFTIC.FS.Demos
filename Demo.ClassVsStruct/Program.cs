using System;

namespace Demo.ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STRUCTURE\n\n");
            VoitureStruct vs = new VoitureStruct();
            vs.couleur = Colors.blanche;
            vs.nbRoues = 4;
            vs.plaqueId = "1-ABC-123";
            Console.WriteLine($"Structure : {vs.couleur}, {vs.nbRoues} roues, {vs.plaqueId}");
            VoitureStruct copyOfVs = vs;
            Console.WriteLine($"Copie : {copyOfVs.couleur}, {copyOfVs.nbRoues} roues, {copyOfVs.plaqueId}");

            Console.WriteLine("Accident sur Structure ! ");
            vs.nbRoues--;
            Console.WriteLine($"Structure : {vs.couleur}, {vs.nbRoues} roues, {vs.plaqueId}");
            Console.WriteLine($"Copie : {copyOfVs.couleur}, {copyOfVs.nbRoues} roues, {copyOfVs.plaqueId}");

            Console.WriteLine("\nCLASS\n\n");

            VoitureClass vc = new VoitureClass();
            vc.Couleur = Colors.bleu;
            vc.NbRoues = -4;
            vc.PlaqueId = "1-XYZ-999";
            Console.WriteLine($"Class : {vc.Couleur},  {vc.NbRoues}  roues, {vc.PlaqueId}");
            VoitureClass aliasOfVc = vc;
            Console.WriteLine($"Alias : {aliasOfVc.Couleur},  {aliasOfVc.NbRoues}  roues, {aliasOfVc.PlaqueId}");

            Console.WriteLine("Accident sur Class!!!");
            vc.NbRoues--;
            Console.WriteLine($"Class : {vc.Couleur},  {vc.NbRoues}  roues, {vc.PlaqueId}");
            Console.WriteLine($"Alias : {aliasOfVc.Couleur},  {aliasOfVc.NbRoues}  roues, {aliasOfVc.PlaqueId}");

            Console.WriteLine("Une structure affectée génère une copie de cette structure");
            Console.WriteLine("Une class affectée génère une copie de l'adresse mémoire de la class, générant un alias");
        }
    }
}
