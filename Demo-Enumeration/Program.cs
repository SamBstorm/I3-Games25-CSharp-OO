using Demo_Enumeration.Models;

namespace Demo_Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trafficlight feu1 = new Trafficlight() {
                currentColor = Enums.TrafficlightColors.vert
            };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Actuellement le feu est {feu1.currentColor}.");
                feu1.ChangeColor(); 
            }
        }
    }
}
