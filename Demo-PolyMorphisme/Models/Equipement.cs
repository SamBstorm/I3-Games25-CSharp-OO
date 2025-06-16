using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PolyMorphisme.Models
{
    internal class Equipement : InventaireItem
    {
        public int BonusDef { get; private set; }
        public int BonusAtk { get; private set; }
        public Equipement(string nom, int prix, int bonusDef, int bonusAtk) : base(nom, prix)
        {
            BonusDef = bonusDef;
            BonusAtk = bonusAtk;
        }
    }
}
