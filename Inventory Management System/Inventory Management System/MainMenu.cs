using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
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
                Console.WriteLine();
                Say("1", "Add New Inventory");                
                Say("2", "Update Existing Inventory");                
                Say("3", "Remove Item from Inventory");                
                Say("4", "View All Current Inventory");                
                Say("5", "Quit");
                
                Console.WriteLine();
                string option = Console.ReadLine();

                if (option == "1")
                {
                    {
                        string item;
                        string amount;
                        string back;

                        StreamWriter sw = new StreamWriter("inventory.csv", true);

                        do
                        {
                            Console.Clear();
                            Console.Write("What would you like to add to your Inventory?\n");
                            item = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("What is the starting amount for the new item?\n");
                            amount = Console.ReadLine();

                            sw.WriteLine(item + "," + amount);

                            Console.WriteLine("Would you like to add more items?");
                            back = Console.ReadLine();
                            back = back.ToLower();

                            if (back == "yes")
                            {
                                Console.Clear();
                                Console.Write("What would you like to add to your Inventory?\n");
                                item = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("What is the starting amount for the new item?\n");
                                amount = Console.ReadLine();

                                sw.WriteLine(item + "," + amount);

                                Console.WriteLine("Would you like to add more items?");
                                back = Console.ReadLine();
                                back = back.ToLower();
                            }
                            else if (back == "no")
                            {
                                sw.Flush();
                                sw.Close();
                                MainMenu.Menu();
                            }

                            else
                            {
                                Console.WriteLine("Please try again!");
                            }

                        } while (back != "no");
                        sw.Flush();
                        sw.Close();

                        
                        
                        
                        }

                        //Console.WriteLine("What Item would you like to add to the Inventory?"); 
                        //string ItemName = Console.ReadLine();
                        //Console.WriteLine("How much of the item do you have?");
                        //string ItemAmt = Console.ReadLine();

                    }
                
                else if (option == "2")
                {
                    Console.Clear();
                    //Console.WriteLine("What item would you like to update?\n");
                    //InvDictionary.EditInv();
                    // go to update existing inventory/update dictionary/file
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("What item would you like to remove from the Inventory?");
                    Console.ReadLine();// go to Remove Item from Inventory (this item is to delete a record) from dictionary
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Here is your complete Inventory. (Press any key to return to Main Menu.)\n");
                    //InvDictionary.Inv();
                    Console.ReadKey(true);
                    MainMenu.Menu();
                }
                else if (option == "5")
                { // exit program save file
                    ConsoleExit.Exit();
                }
                else
                {
                    Console.WriteLine("Error! Please select a valid option!");
                    Console.Beep(1000, 1000); // Thanks Dave!!
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
