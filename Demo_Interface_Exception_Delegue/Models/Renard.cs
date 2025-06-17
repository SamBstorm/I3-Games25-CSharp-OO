using Demo_Interface_Exception_Delegue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface_Exception_Delegue.Models
{
    public class Renard: Personnage
    {
        public delegate void DCrie(string lecri);//Prototype de la fonction qui pourrait être appelée par le délégué
        public event DCrie ECrie;
        public Renard(string nom):base(nom)
        {
            
        }

        private void Glapit()
        {
            ECrie("AAAAAAAAAAAAAAAAAhJIpJIpYOOOOOOU");
        }

        public void VoitLapoule()
        {
            Glapit();
        }
    }
}
