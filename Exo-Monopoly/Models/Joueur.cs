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
        public string nom;
        public Pions pion;
        public int position = 0;

        public bool Avancer()
        {
            De.valeurMin = 1;
            De.valeurMax = 6;
            int[] resultDe = De.Lancer(2);
            position += resultDe[0] + resultDe[1];
            return resultDe[0] == resultDe[1];
        }
    }
}
