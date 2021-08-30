using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cebola;

Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Oi!, eu sou o Cebolinha.. \nE vou lepetir tudo que você Escleve aqui: ");
Console.ResetColor();
            Cebola = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.DarkBlue;

            string textocbl = Cebola.Replace("r" , "l").Replace("R" , "L");
            Console.WriteLine(""); 
            Console.WriteLine($" {textocbl}");
Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
Console.ResetColor();
            
        }
    }
}



