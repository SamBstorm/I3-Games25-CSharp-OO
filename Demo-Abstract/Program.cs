using Demo_Abstract.Models;

namespace Demo_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> pnj = new List<Animal>()
            {
                new Chien("Rouky"),
                new Pigeon("Bob"),
                new Poule("Ginger"),
                new Mesange("Le piaf")
            };

            Console.Write("En me promenant, j'ai entendu ");
            pnj[new Random().Next(pnj.Count)].Crier();
        }
    }
}
