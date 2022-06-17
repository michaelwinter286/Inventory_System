using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Inventory
{
    class MainMenu
    {
        public static void Menu()
        {
            for (; ; )
            {
                Console.Clear();
                WriteLogo();
                Console.WriteLine("Please choose one of the following options.");
                Say("1", "Add New Inventory");                
                Say("2", "Update Existing Inventory");                
                Say("3", "Remove Item from Inventory");                
                Say("4", "View All Current Inventory");                
                Say("5", "Quit");
                
                string option = Console.ReadLine();
                if (option == "1")
                {
                    // go to add new inventory
                }
                else if (option == "2")
                {
                    // go to update existing inventory
                }
                else if (option == "3")
                {
                    // go to Remove Item from Inventory (this item is to delete a record)
                }
                else if (option == "4")
                {
                    // go to view all current inventory
                }
                else if (option == "5")
                {
                    // exit program save JSON file
                }
                else
                {
                    Console.WriteLine("Error, Please select a valid option!");
                    Thread.Sleep(2000);
                }
            }
        }

                

        public static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix, Color.LimeGreen);
            Console.Write("] " + message);
            Console.WriteLine();
        }

        public static void WriteLogo()
        {
            string logo = @"
  _________                     .__                 ___________                             .___   _____    _________
 /   _____/____    _____ ______ |  |   ____ ___.__. \_   _____/____ _______  _____   ______ |   | /     \  /   _____/
 \_____  \\__  \  /     \\____ \|  | _/ __ <   |  |  |    __) \__  \\_  __ \/     \ /  ___/ |   |/  \ /  \ \_____  \ 
 /        \/ __ \|  Y Y  \  |_> >  |_\  ___/\___  |  |     \   / __ \|  | \/  Y Y  \\___ \  |   /    Y    \/        \
/_______  (____  /__|_|  /   __/|____/\___  > ____|  \___  /  (____  /__|  |__|_|  /____  > |___\____|__  /_______  /
        \/     \/      \/|__|             \/\/           \/        \/            \/     \/              \/        \/ 
";
       
            Console.WriteLine(logo, Color.LimeGreen);
        }
    }
}
