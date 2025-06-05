using Exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal class Joueur
    {
        public string Nom { get;  set; }
        public Pions Pion{ get; set; }

        private int _solde = 0;

        private  int _position = 0;

        public int Position
        {
             get { return _position; }
             private set { _position = value; }
        }
       
        public int Solde
        {
            
            get
            {
                return _solde;
            }

            private set
            {
                if (value < 0)
                {
                    _solde = 0;
                    Console.WriteLine("Ceci sera remplacé plus tard par une EXCEPTION");
                }
                else
                {
                    _solde = value;
                }
            }
        }
        /// <summary>
        /// Méthode permettant d'effectuer un déplacement à l'interieur des zones prédéfinies par le jeux cité
        /// </summary>
        /// <returns>true si douvle</returns>
        public bool Avancer()
        {
            De.ValeurMin = 1;
            De.ValeurMax = 6;
            int[] resultDe = De.Lancer(2);
            Position += resultDe[0] + resultDe[1];
            return resultDe[0] == resultDe[1];
        }
    }
}
