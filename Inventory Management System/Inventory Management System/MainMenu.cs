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
                Logos.TitleLogo();
                Console.WriteLine("Please choose from one of the following options.(Make selection and press 'ENTER')");
                Console.WriteLine();
                Say("1", "Add New Inventory");                
                Say("2", "Update Existing Inventory (WIP)");  // to be added once SQL database is up and running              
                Say("3", "Remove Item from Inventory (WIP)");   // to be added once SQL database is up and running                
                Say("4", "View All Current Inventory");
                Say("5", "View Error Log");
                Say("6", "Quit");
                
                Console.WriteLine();
                string option = Console.ReadLine();

                if (option == "1")
                {
                    AddItem.Add();
                }

                else if (option == "2")
                {
                    Console.Clear();
                    Logos.EditLogo();
                    Console.WriteLine("\n\n Press any key to return to Main Menu.");
                    Console.ReadKey();
                    Menu();
                }

                else if (option == "3")
                {
                    Console.Clear();
                    Logos.EditLogo();
                    Console.WriteLine("\n\n Press any key to return to Main Menu.");
                    Console.ReadKey();
                    Menu();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Here is your complete Inventory. (Press any key to return to Main Menu.)\n");
                    Console.WriteLine();

                    try
                    {
                        string[] readInv = File.ReadAllLines("inventory.csv");

                        var invItem = new List<string>();
                        var invAmount = new List<string>();

                        for (int i = 0; i < readInv.Length; i++)
                        {

                            string[] rowData = readInv[i].Split(',');
                            invItem.Add(rowData[0]);
                            invAmount.Add(rowData[1]);
                               
                            Console.WriteLine(invItem[i] + " - " + invAmount[i]);
                        }
                        Console.ReadKey(true);
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
                        Logos.TitleLogo();
                        Console.WriteLine("\n\n\n So.. Currently you have not had any errors to log. Congrats! But unfortunitly you have just created one! HAHA! Please run Error Log again to view. Press any key to return to Main Menu.\n\n" + "Error:" + ex);

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
    }
}
