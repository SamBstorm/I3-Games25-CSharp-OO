using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static.Models
{
    internal class Formation
    {
        public static string centre;
        public string nom;

        public List<string> eleves;

        public void Decrire()
        {
            Console.WriteLine($"La formation est dénommée {nom}, et voici des élèves :");
            foreach (string eleve in eleves)
            {
                Console.WriteLine($"\t- {eleve}");
            }
        }

        public static void Description()
        {
            Console.WriteLine($"Regroupe l'ensemble des formations de {centre}.");
        } 
    }
}
