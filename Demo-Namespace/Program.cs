using Demo_Namespace.Inventaire;

namespace Demo_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item objetInventaire = new Item();
            objetInventaire.nom = "Pépite";
            objetInventaire.value = 5000;
            Console.WriteLine($"Dans mon sac, j'ai une {objetInventaire.nom} de {objetInventaire.value} Pokédollars !");
        }
    }
}