using Demo_VirtualOverride.Models;

namespace Demo_VirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animal opossum = new WalkingAnimal("Ellie");
            Console.WriteLine(opossum);
            opossum.SeDeplacer();

            Animal clown = new SwimmingAnimal("Némo");
            Console.WriteLine(clown);
            clown.SeDeplacer();

            Animal serpent = new Animal("Kaha");
            Console.WriteLine(serpent);
            serpent.SeDeplacer();*/

            List<Animal> zoo = new List<Animal>()
            {
                new WalkingAnimal("Ellie"),
                new SwimmingAnimal("Némo"),
                new Animal("Kaha")
            };

            foreach (Animal a in zoo)
            {
                Console.WriteLine(a);
                a.SeDeplacer();
            }

            /*Dans la cas de la dissimulation (new)
            foreach (Animal a in zoo)
            {
                Console.WriteLine(a);
                if (a is SwimmingAnimal swA) swA.SeDeplacer();
                else if (a is WalkingAnimal waA) waA.SeDeplacer();
                else a.SeDeplacer();
            }*/
        }
    }
}
