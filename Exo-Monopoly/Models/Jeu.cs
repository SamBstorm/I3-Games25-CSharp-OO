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
        private List<CasePropriete> _plateau;

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
        public CasePropriete[] Plateau
        {
            get
            {
                return _plateau.ToArray();
            }
        }

        public CasePropriete this[int numeroCase]
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

        public Jeu(CasePropriete[] casesPlateau)
        {
            _plateau = new List<CasePropriete>(casesPlateau);
            _joueurs = new List<Joueur>();
        }
    }
}
