using System;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Title = "Program";           
            MainMenu.WriteLogo();
            Console.WriteLine();
            Console.WriteLine("What can we help with today? (Press any Key to continue.)");
            Console.ReadKey(true);
            MainMenu.Menu();
        }
    }
}
    
