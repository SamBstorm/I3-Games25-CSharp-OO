using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal static class De
    {
        public static int valeurMin = 1;
        public static int valeurMax = 6;
        public static Random rng = new Random();

        public static int[] Lancer(int nbDes)
        {
            int[] results = new int[nbDes];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = rng.Next(valeurMin, valeurMax+1);
            }
            return results;
        }
    }
}
