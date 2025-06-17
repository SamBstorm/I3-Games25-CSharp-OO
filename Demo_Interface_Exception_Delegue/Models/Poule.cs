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
    internal class Poule : Personnage
    {
        public Poule(string nom):base(nom)
        {
            
        }
    }
}