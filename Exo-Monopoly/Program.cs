using Exo_Monopoly.Enums;
using Exo_Monopoly.Models;

namespace Exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Joueur, veuillez indiquer votre nom :");
            string userName = Console.ReadLine();

            Console.WriteLine("Veuillez choisir un pion :");
            string[] pionNames = Enum.GetNames<Pions>();
            //Pions[] pions = Enum.GetValues<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t- {pionName}");
            }
            Console.WriteLine("Quel pion choisissez-vous?");
            string userInput = Console.ReadLine();
            Pions choice = Enum.Parse<Pions>(userInput);
             
                Joueur j1 = new Joueur
                (
                     userName,
                     choice
                );
             

            Console.WriteLine($"Le joueur {j1.Nom} avec le pion {j1.Pion} se trouve à la case {j1.Position}.");
            bool isDouble = j1.Avancer();
            if (isDouble)
            {
                Console.WriteLine("Super! Un double!");
            }
            Console.WriteLine($"Le joueur {j1.Nom} avec le pion {j1.Pion} se trouve à la case {j1.Position}.");

            CasePropriete[] cases = 
            {
                new CasePropriete("Patio", Couleurs.BleuCiel, 20),
                new CasePropriete("Accueil", Couleurs.BleuCiel, 23),
                new CasePropriete("Bureau Sonia", Couleurs.Marron, 26),
                new CasePropriete("Bureau Nicole", Couleurs.Marron, 26),
                new CasePropriete("Bureau Laure", Couleurs.Marron, 30)
            };

            Jeu monopoly = new Jeu(cases);

            Console.WriteLine($"Votre plateau compte {monopoly.Plateau.Length} cases.");

        }
    }
}
