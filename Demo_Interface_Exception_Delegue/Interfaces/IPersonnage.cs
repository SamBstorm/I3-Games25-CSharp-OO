using Demo_Interface_Exception_Delegue.Enums;
using Demo_Interface_Exception_Delegue.Stuctures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface_Exception_Delegue.Interfaces
{
    /// <summary>
    /// Définit les actions et propriétés obligatoire d'une poule
    /// </summary>
    internal interface IPersonnage
    {
        //Propriétés
        string Nom { get; }
        //Méthodes
        Position Avancer(int distance, DIRECTION direction);
    }
}
