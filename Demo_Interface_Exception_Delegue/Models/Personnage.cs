using Demo_Interface_Exception_Delegue.Enums;
using Demo_Interface_Exception_Delegue.Exceptions;
using Demo_Interface_Exception_Delegue.Interfaces;
using Demo_Interface_Exception_Delegue.Stuctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface_Exception_Delegue.Models
{
    public abstract class Personnage :IPersonnage
    {/// <summary>
     /// Emplacement actuel de la Personnage
     /// </summary>
        private Position _emplacement;

        /// <summary>
        /// ReadOnly oblige d'utiliser le constructeur pour lui donner une valeur
        /// </summary>
        private readonly string _nom;

        /// <summary>
        /// Propriété Nom héritée de l'interface
        /// </summary>
        public string Nom
        {
            get
            {
                return _nom;
            }
        }
        /// <summary>
        /// Constructeur permettant de nommer du personnage
        /// </summary>
        /// <param name="nomDuPerso">Devine ?</param>
        public Personnage(string nomDuPerso)
        {
            _nom = nomDuPerso;
            _emplacement = new Position();
            _emplacement.x = 0;
            _emplacement.y = 0;
        }

        /// <summary>
        /// Fonction permettant de faire avancer la poule sur le plateau
        /// </summary>
        /// <param name="distance">Nombre de case de déplacement</param>
        /// <param name="direction">Direction du déplacement</param>
        /// <returns>L'emplacement de la poule sur le plateau sous la forme d'un tuple (x, y)</returns>
        /// <exception cref="DirectionException">Si la direction n'est pas correcte</exception>
        public Position Avancer(int distance, DIRECTION direction)
        {
            switch (direction)
            {
                case DIRECTION.Avant:
                    _emplacement.x += distance;
                    break;
                case DIRECTION.Arriere:
                    _emplacement.x -= distance;
                    break;
                case DIRECTION.Haut:
                    _emplacement.y -= distance;
                    break;
                case DIRECTION.Bas:
                    _emplacement.y += distance;
                    break;
                default:
                    /*C'est une erreur */
                    throw new DirectionException();
            }
            return _emplacement;
        }
    }
}

