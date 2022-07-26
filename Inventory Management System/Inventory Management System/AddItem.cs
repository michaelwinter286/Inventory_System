using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class AddItem
    {
        public static void Add()
        {

            string? item;
            string? amount;
            string? back;

            StreamWriter sw = new StreamWriter("inventory.csv", true);

            //do //still need to setup "null" value catch and throw exception message. Send Exception message to another file "Error Log"
            {
                Console.Clear();
                Console.Write("What would you like to add to your Inventory?\n");
                item = Console.ReadLine();

                if (string.IsNullOrEmpty(item))
                {
                    Console.WriteLine("Please input an item.");
                    StreamWriter em = new StreamWriter("ErrorLog.txt", true);
                    DateTime errorDate = DateTime.Now;

                    em.WriteLine(errorDate + "\n" + "Invalid (null) item" + "\n");
                    em.WriteLine();
                    em.Flush();
                    em.Close();
                    sw.Close();
                    Console.Beep();
                    Thread.Sleep(2000);
                    Add();

                }

                else
                {
                    Console.WriteLine();
                    Console.Write("What is the starting amount for the new item? (Please add unit of measure to amount.)\n");
                    Console.WriteLine();
                    amount = Console.ReadLine();

                    if (string.IsNullOrEmpty(amount))
                    {
                        Console.WriteLine("Inventory amounts cannot be blank. Please try adding again.");
                        StreamWriter em = new StreamWriter("ErrorLog.txt", true);
                        DateTime errorDate = DateTime.Now;

                        em.WriteLine(errorDate + "\n" + "Invalid Amount (null)" + "\n");
                        em.WriteLine();
                        em.Flush();
                        em.Close();
                        sw.Close();
                        Console.Beep();
                        Thread.Sleep(2000);
                        Add();

                    }

                    else
                    sw.WriteLine(item + "," + amount);
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more items? (Y/N)");
                    back = Console.ReadLine();
                    back = back?.ToLower();

                    if (back == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("You have successfully added " + amount + " of " + item + " to the inventory.");
                        sw.Flush();
                        sw.Close();
                        Thread.Sleep(2000);
                        Add();
                    }

                    else if (back == "n")
                    {
                        Console.WriteLine("You have successfully added " + amount + " of " + item + " to the inventory.");
                        sw.Flush();
                        sw.Close();
                        Thread.Sleep(2000);
                        MainMenu.Menu();
                    }

                    else if (string.IsNullOrEmpty(item))
                    {
                        Console.Beep(); // Thanks Dave!!
                        Console.WriteLine("Please try again!");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.Beep(); // Thanks Dave!!
                        Console.WriteLine("Please try again!");
                        Thread.Sleep(2000);
                    }
                }


            }
                        
            sw.Flush();
            sw.Close();
         
        }
    }
}
        
        
        
