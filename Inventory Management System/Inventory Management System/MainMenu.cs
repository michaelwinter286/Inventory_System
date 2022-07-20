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
                Say("2", "Update Existing Inventory (currenlty Under Development)");                
                Say("3", "Remove Item from Inventory");                
                Say("4", "View All Current Inventory");
                Say("5", "View Error Log");
                Say("6", "Quit");
                
                Console.WriteLine();
                string option = Console.ReadLine();

                if (option == "1")
                {
                    {
                        string item;
                        string amount;
                        string back;

                        StreamWriter sw = new StreamWriter("inventory.csv", true);

                        do //still need to setup "null" value catch and throw exception message. Send Exception message to another file "Error Log"
                        {
                            Console.Clear();
                            Console.Write("What would you like to add to your Inventory?\n");
                            item = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("What is the starting amount for the new item? (Please add unit of measure to amount.)\n");
                            Console.WriteLine();
                            amount = Console.ReadLine();

                            sw.WriteLine(item + "," + amount);
                            Console.WriteLine();
                            Console.WriteLine("Would you like to add more items? (Y/N)");
                            back = Console.ReadLine();
                            back = back.ToLower();

                            if (back == "y")
                            {
                                Console.Clear();
                                Console.Write("What would you like to add to your Inventory?\n");
                                item = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("What is the starting amount for the new item?\n");
                                amount = Console.ReadLine();

                                sw.WriteLine(item + "," + amount);

                                Console.WriteLine("Would you like to add more items? (Y/N)\n");
                                back = Console.ReadLine();
                                back = back.ToLower();
                            }

                            else if (back == "n")
                            {
                                Console.WriteLine("You have successfully added " + amount + "of" + item + " to the inventory.");
                                sw.Flush();
                                sw.Close();
                                Thread.Sleep(4000);
                                MainMenu.Menu();
                            }

                            else
                            {
                                Console.Beep(1000, 1000); // Thanks Dave!!
                                Console.WriteLine("Please try again!");
                                Thread.Sleep(2000);
                            }

                        }

                        while (back == null);
                        {
                            Console.WriteLine("Please try again Blank Entry");
                            sw.Flush();
                            sw.Close();
                            Thread.Sleep(4000);
                            MainMenu.Menu();
                        }



                    }

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
                    Console.WriteLine();

                    try
                    {
                        StreamReader sr = new StreamReader("inventory.csv");
                        string? data = sr.ReadLine();

                        while (data != null)
                        {

                            Console.WriteLine(data);
                            data = sr.ReadLine();

                        }

                        Console.ReadKey(true);
                        sr.Close();
                        Menu();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine("Your Inventory is currently empty. Please add items to view current Inventory. Thank You!\n\n" + "Error:" + ex);

                        StreamWriter sw = new StreamWriter("ErrorLog.txt", true);
                        DateTime errorDate = DateTime.Now;

                        sw.WriteLine(errorDate + "\n" + ex + "\n");
                        sw.WriteLine();
                        sw.Flush();
                        sw.Close();
                        Thread.Sleep(3000);
                        Menu();
                    }

                }
                else if (option == "5")
                {
                    
                    try
                    {
                        Console.Clear();
                        Console.Write("Here are your Errors thus far.\n\n");
                        StreamReader sr = new StreamReader("ErrorLog.txt");
                        string? error = sr.ReadLine();

                        while (error != null)
                        {
                            Console.WriteLine(error);
                            error = sr.ReadLine();

                        }

                        Console.ReadKey(true);
                        sr.Close();
                        Menu();
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.Clear();
                        WriteLogo();
                        Console.WriteLine("\n\n\n So.. Currently you have not had any errors to log. Congrats! But unfortunitly you have just created one! HAHA! Please run Error Log again to view.Press any key to return to Main Menu.\n\n" + "Error:" + ex);

                        StreamWriter sw = new StreamWriter("ErrorLog.txt", true);
                        DateTime errorDate = DateTime.Now;

                        sw.WriteLine(errorDate + "\n" + ex + "\n");
                        sw.Flush();
                        sw.Close();
                        Console.ReadKey();
                        Menu();
                    }
                }
                else if (option == "6")
                { 
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
