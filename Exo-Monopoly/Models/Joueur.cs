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
        private List<CasePropriete> _proprietes;
       
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
        public List<CasePropriete> Proprietes
        {
            get { return _proprietes; }
            private set { _proprietes = value; }
        }

         
        //Nom, Pion par des paramètres; Solde à 1500, Position à 0 et initialiser une liste vide pour Proprietes.
        public Joueur(string nom, Pions pion)
        {
            Nom = nom;
            Pion = pion;
            Solde = 1500;
            Position = 0;
            Proprietes = new List<CasePropriete>();
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
        public void Payer(int prix)
        {
            if (Solde >= prix && prix >0)
            {
                Solde -= prix;
            }
        }

        //void EtrePaye (int montant) – Permet d’ajouter un montant au Solde du Joueur
        public void EtrePaye(int montant)
        {
            //1 - vérifier que le montant en paramètre est positif
            if(montant>0)
            {
                //2- Ajouter le montant au Solde
                Solde += montant;
            }

        }

        //void AjouterPropriete (propriete casePropriete) – Permet d’ajouter la propriété dans la liste Proprietes seulement si celle-ci a comme propriétaire le joueur
        public void AjouterPropriete(CasePropriete? propriete)
        {
            //1- Vérifier que la propriété appartient au joueur courant
            if(propriete != null && propriete.Proprietaire==this)
            {
                //2- Ajouter la propriété à la liste de propriété de notre joueur 
                Proprietes.Add(propriete);
            }
            else
            {
                Console.WriteLine("Je balance un erreur expliquant ce qui se passe!");
            }

        }

        public static Joueur operator + (Joueur left, int right)
        {
            left.EtrePaye(right);
            return left;
        }

        //public static List<CasePropriete> operator +(Joueur left, CasePropriete right)
        //{
        //    right.Activer(left);
        //    left.AjouterPropriete(right);
        //    return left.Proprietes;
        //} 
    }
}
