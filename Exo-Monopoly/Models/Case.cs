using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal abstract class Case
    {
        private List<Joueur> _visiteurs;

        public string Nom { get; private set; }


        public Joueur[] Visiteurs
        {
            get
            {
                return _visiteurs.ToArray();
            }
        }
        public Case(string nom)
        {
            Nom = nom;
            _visiteurs = new List<Joueur>();
        }

        public void AjouterVisiteur (Joueur visiteur) {
            if (_visiteurs.Contains(visiteur)) return;  //Message d'exception
            _visiteurs.Add(visiteur);
        }
        public void RetirerVisiteur (Joueur visiteur) {
            if( !_visiteurs.Remove(visiteur)) return;  //Message d'exception
        }

        public abstract void Activer(Joueur visiteur);

    }
}
