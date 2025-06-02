using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static.Models
{
    internal static class ConsoleRainbow
    {
        public static void Write(string texte)
        {
            int i = 0;
            foreach (char c in texte)
            {
                Console.ForegroundColor = (ConsoleColor)(i % 16);
                Console.BackgroundColor = (ConsoleColor)(15-(i % 16));
                Console.Write(c);
                i++;
                Console.ResetColor();
            }
        }

        public static void WriteLine(string texte) { 
            Write(texte);
            Console.WriteLine();
        }
    }
}
