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
            exit = exit.ToLower();
            
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
//StreamReader sr = new StreamReader("inventory.csv");
//string? data = sr.ReadLine();

//while (data != null)
//{

//    Console.WriteLine(data);
//    data = sr.ReadLine();

//}

//Console.ReadKey(true);
//sr.Close();
//Menu();
//                    }
//                    catch (FileNotFoundException ex)
//{
//    Console.WriteLine("Your Inventory is currently empty. Please add items to view current Inventory. Thank You!\n\n" + "Error:" + ex);

//    StreamWriter sw = new StreamWriter("ErrorLog.txt", true);
//    DateTime errorDate = DateTime.Now;

//    sw.WriteLine(errorDate + "\n" + ex + "\n");
//    sw.WriteLine();
//    sw.Flush();
//    sw.Close();
//    Thread.Sleep(3000);
//    Menu();