using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1, "Jorge", "Medel", "Joker", "1245kiol", "amedel.zen@gmail.com");
            
            Console.WriteLine("Final Project!");
            Console.ReadKey();
        }
    }
}