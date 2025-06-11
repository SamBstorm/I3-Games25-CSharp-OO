using Exo_Monopoly.Enums;
using Exo_Monopoly.Models;

namespace Exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CasePropriete[] cases =
            {
                new CasePropriete("Patio", Couleurs.Marron, 20),
                new CasePropriete("Accueil", Couleurs.Marron, 23),
                new CasePropriete("Ascenceur Gauche", Couleurs.BleuCiel, 26),
                new CasePropriete("Ascenceur Droit", Couleurs.BleuCiel, 26),
                new CasePropriete("Toilette RDC", Couleurs.BleuCiel, 30),
                new CasePropriete("Couloir 4ième étage", Couleurs.Violet, 32),
                new CasePropriete("Couloir 5ième étage", Couleurs.Violet, 32),
                new CasePropriete("Toilette 5ième étage", Couleurs.Violet, 38),
                new CasePropriete("Classe des WAD", Couleurs.Orange, 42),
                new CasePropriete("Classe des WEB", Couleurs.Orange, 42),
                new CasePropriete("Classe des Games", Couleurs.Orange, 48),
                new CasePropriete("Bureau Sonia", Couleurs.Bleu, 56),
                new CasePropriete("Bureau Nicole", Couleurs.Bleu, 56),
                new CasePropriete("Bureau Laure", Couleurs.Bleu, 60)
            };

            Jeu monopoly = new Jeu(cases);

            Console.WriteLine($"Votre plateau compte {monopoly.Plateau.Length} cases.");

            int nbJoueurs;
            do Console.WriteLine("Combien joueurs jouent ? (entre 2 et 6)");
            while (!int.TryParse(Console.ReadLine(), out nbJoueurs) || nbJoueurs < 2 || nbJoueurs > 6);

            do
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

                monopoly.AjouterJoueur(userName, choice);
            } while (monopoly.Joueurs.Length < nbJoueurs);

            int tourJoueur = 0;
            while (tourJoueur < 40)
            {
                Joueur joueurCourrant = monopoly.Joueurs[tourJoueur % monopoly.Joueurs.Length];
                CasePropriete caseCourrante = monopoly[joueurCourrant.Position];

                //Traitement du tour
                Console.WriteLine($"Le joueur {joueurCourrant.Nom} avec le pion {joueurCourrant.Pion} se trouve à la case {caseCourrante.Nom}.");
                bool isDouble = joueurCourrant.Avancer();
                caseCourrante = monopoly[joueurCourrant.Position];
                while (isDouble)
                {
                    Console.WriteLine("Super! Un double!");
                    Console.WriteLine($"Le joueur {joueurCourrant.Nom} avec le pion {joueurCourrant.Pion} se trouve à la case {caseCourrante.Nom}.");
                    isDouble = joueurCourrant.Avancer();
                    caseCourrante = monopoly[joueurCourrant.Position];
                }
                Console.WriteLine($"Le joueur {joueurCourrant.Nom} avec le pion {joueurCourrant.Pion} se trouve à la case {caseCourrante.Nom}.");

                //Fin traitement

                tourJoueur++;
            }




        }
    }
}
