using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Inventory
{
    internal class ConsoleExit
    {
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to EXIT? (Y/N)");
            Console.WriteLine();

            string exit = Console.ReadLine();
            
            if (exit == "y")
            {
                Environment.Exit(0);
            }
            else
            {
                MainMenu.Menu();
            }
        }

    }

}
