using Exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal class Jeu
    {
        private List<Joueur> _joueurs;
        private List<Case> _plateau;

        public Joueur[] Joueurs
        {
            get
            {
                return _joueurs?.ToArray();
            }
            /*private set
            {
                _joueurs = new List<Joueur>(value);
            }*/
        }
        public Case[] Plateau
        {
            get
            {
                return _plateau.ToArray();
            }
        }

        public Case this[int numeroCase]
        {
            get
            {
                numeroCase %= _plateau.Count;
                return _plateau[numeroCase];
            }
        }

        public Joueur? this[Pions pion]
        {
            get
            {
                foreach (Joueur j in _joueurs)
                {
                    if (j.Pion == pion) return j;
                }
                return null;
            }
        }

        public Jeu(Case[] casesPlateau)
        {
            //_plateau = [.. casesPlateau]; //Initialise une list à partir d'un array
            _plateau = new List<Case>(casesPlateau);
            _joueurs = new List<Joueur>();
        }

        public void AjouterJoueur(string nom, Pions pion)
        {
            foreach (Joueur j in _joueurs)
            {
                if(j.Pion == pion)
                {
                    Console.WriteLine($"Le pion {pion} est déjà pris.");
                    return;
                }
            }
            _joueurs.Add(new Joueur(nom, pion));
        }
    }
}
