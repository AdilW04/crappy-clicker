using System;
using System.IO;
namespace console_cookie_clicker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back");
            game mainGame = new game();
            mainGame.Start();
        }
    }
}
