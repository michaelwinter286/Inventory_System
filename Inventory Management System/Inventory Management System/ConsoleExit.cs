using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class ConsoleExit
    {
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to exit? (Y/N)");
            Console.WriteLine();

                string exit = Console.ReadLine();
                    if (exit == "n")
                    {
                        MainMenu.Menu();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }



        }

        
        
        
                               
    }
}
