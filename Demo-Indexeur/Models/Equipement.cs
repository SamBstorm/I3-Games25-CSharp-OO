using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur.Models
{
    internal class Equipement
    {
        public string Nom { get; set; }
        public string Couleur { get; set; }
        public int Puissance { get; set; }
        /// <summary>
        /// Additionner les puissances
        /// </summary>
        /// <param name="e1">Mon premier équipement</param>
        /// <param name="e2">Mon second équipement</param>
        /// <returns>la somme des puissances</returns>
        public static int operator + (Equipement e1, Equipement e2)
        {
            return e1.Puissance + e2.Puissance;
        }
        public static int operator + (int puissance , Equipement e1)
        {
            return puissance + e1.Puissance;
        }
    }
}
