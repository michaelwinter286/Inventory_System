using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Inventory
{
    public class InvDictionary
    {

        public static void Inv()

        {
            //Console.WriteLine("Here is your complete Inventory. (Press any key to return to Main Menu.)\n");

                Dictionary<string, string> MyStuff = new Dictionary<string, string>();
                MyStuff.Add("Diesel", "15(gal)");
                MyStuff.Add("Hay", "96(bales)");
                MyStuff.Add("Salt Lick", "6(blocks)");


            foreach(KeyValuePair<string, string> InvItem in MyStuff)
            {
                Console.WriteLine("{0} - {1}", InvItem.Key, InvItem.Value);
            }

        }
        
        public static void AddInv()
        {

            Console.WriteLine("What is the Item you would like to add to the Inventory?");
            Console.ReadLine();
            Console.WriteLine("How much do you have? (format = Amount (unit of measure) 15 (gal)");
            Console.ReadLine();
            // need to setup user input to add to MyStuff dictionary from main menu option "1"
        }

        public static void EditInv()
        {
            Console.WriteLine("What item would you like to update?\n");
            InvDictionary.Inv();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("What is the Inventory Amount?");
            Console.ReadLine();
            // still need to setup user input to edit data in MyStuff dictionary
        }
    }       
        
}

        
        
        
    

