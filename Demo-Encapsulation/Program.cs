using Demo_Encapsulation.Models;

namespace Demo_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login monLogin = new Login();

            monLogin.email = "samuel.legrain@bstorm.be";
            monLogin.ChangePassword("Test1234=\r");

            Console.WriteLine("Veuillez introduire votre email :");
            string email = Console.ReadLine();
            Console.WriteLine("Veuillez introduire votre mot de passe:");
            ConsoleKeyInfo keyInfo;
            string password = "";
            do
            {
                keyInfo = Console.ReadKey(true);
                password += keyInfo.KeyChar;
                Console.Write("*");
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            Console.WriteLine();

            bool isConnected = monLogin.CheckUser(email, password);

            if (isConnected)
            {
                Console.WriteLine("Bienvenue!");
            }
            else
            {
                Console.WriteLine("Compte bloqué!");
            }
        }
    }
}
