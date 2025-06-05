using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal static class De
    {
        private static int _valeurMin = 1;
        private static int _valeurMax = 6;
        public static Random rng = new Random();
        
        public static int ValeurMin 
        {
            get { return _valeurMin; }
            set 
            {
                if (value > 0)
                {
                    _valeurMin = value;
                    if (value >= ValeurMax) { ValeurMax= value + 1; }
                }
            } 
        }
        public static int ValeurMax
        {
            get
            {
                return _valeurMax;
            }

            set
            {
                if(value > 1)
                { _valeurMax = value;
                  if(value<=ValeurMin) ValeurMin=value-1;
                }
            }
        }

       
        public static int[] Lancer(int nbDes)
        {
            int[] results = new int[nbDes];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = rng.Next(_valeurMin, ValeurMax+1);
            }
            return results;
        }
    }
}
