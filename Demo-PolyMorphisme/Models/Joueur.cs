using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PolyMorphisme.Models
{
    internal class Joueur
    {
        private List<InventaireItem> _inventaire;

        public InventaireItem[] Inventaire
        {
            get
            {
                return _inventaire.ToArray();
            }
        }
        public int Solde { get; set; }

        public Equipement MainGauche { get; private set; }
        public Equipement MainDroite { get; private set; }
        public Joueur()
        {
            Solde = 1000;
            _inventaire = new List<InventaireItem>();
        }

        public void Loot(InventaireItem objet)
        {
            _inventaire.Add(objet);
        }

        public bool JeterObjet(InventaireItem objet)
        {
            return _inventaire.Remove(objet);
        }

        public void Equiper(Equipement equipement, bool mainGauche)
        {
            if (mainGauche)
                MainGauche = equipement;
            else
                MainDroite = equipement;
        }
    }
}
