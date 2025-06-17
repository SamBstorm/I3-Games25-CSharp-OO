using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface_Exception_Delegue.Exceptions
{
    public  class DirectionException : Exception
    {
        public DirectionException() : base("La direction n'est pas permise")
        { }
         
    }

    public class RenardException: Exception
    {
        public RenardException():base("Le renard a mangé la poule")
        {
            
        }
    }
}
