using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PolyMorphisme.Models
{
    internal class Coffre
    {
        public InventaireItem Contenu { get; private set; }

        public Coffre(InventaireItem contenu)
        {
            Contenu = contenu;
        }

        public Coffre(InventaireItem[] contenus)
        {
            Random RNG = new Random();
            Contenu = contenus[RNG.Next(contenus.Length)];
        }

        public void ViderCoffre()
        {
            Contenu = null;
        }
    }
}
