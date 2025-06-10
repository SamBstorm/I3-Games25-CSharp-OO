using Exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    internal class CasePropriete
    {
        #region Variables et propriétés
        //Nom(string) – Lecture seule
        public string Nom { get; private set; }
        //Couleur(Couleurs) – Lecture seule
        public Couleurs Couleur { get; }

        //Prix(int) – Lecture seule
        private int _prix;
        public int Prix
        {
            get
            {
                return _prix;
            }

            private set
            {
                if(value>0) _prix = value;
            }
        }

        //EstHypotequee(bool) – Lecture seule
        private bool _estHypotequee;
        public bool EstHypotequee
        {
            get
            {
                return _estHypotequee;
            }
        }

        //Proprietaire(Joueur) – Lecture seule
        private Joueur? _proprietaire;

        public Joueur? Proprietaire
        {
            get
            {
                return _proprietaire;
            }

            set
            {
                _proprietaire = value;
            }
        } 
        #endregion

        public CasePropriete(string nom, Couleurs couleur, int prix)
        {
            Nom = nom;
            Couleur = couleur;
            Prix=prix;
            _estHypotequee = false;
            Proprietaire= null;
        }

        public void Acheter(Joueur acheteur)
        { 
           //if(acheteur.Payer(Prix))
           // {
           //     Proprietaire=acheteur;
           // }        
           //1 l'acheteur a-t-il des thunes ?
           if(acheteur != null && acheteur.Solde>=Prix &&  Proprietaire is null) //Samuel va râler :p
            {
                //2- Le joueur doit payer!!!!! Je diminue le solde du joueur
                //2.1 - Comme Payer ne me renvoie rien, je dois vérifier si le solde a bien été diminué du Prix de la propriété! Remarque : un booléen serait plus approprié pour la function Payer mais notre analyste ne veut pas :(
                int SoldeFinal = acheteur.Solde-Prix;                
                acheteur.Payer(Prix);
                //3- le joueur devient le proprio
                if(SoldeFinal == acheteur.Solde)
                {
                    Proprietaire = acheteur;
                }
            }
        }
    }
}
