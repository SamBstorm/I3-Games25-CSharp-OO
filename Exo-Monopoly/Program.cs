using Exo_Monopoly.Enums;

namespace Exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez choisir un pion :");
            string[] pionNames = Enum.GetNames<Pions>();
            //Pions[] pions = Enum.GetValues<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t- {pionName}");
            }
            Console.WriteLine("Quel pion choisissez-vous?");
            string userInput = Console.ReadLine();
            Pions choice = Enum.Parse<Pions>(userInput);


        }
    }
}
