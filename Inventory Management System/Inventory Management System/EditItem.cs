using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventory
{
    internal class EditItem
    {
        public static void itemEdit()
        {
            //string[] readInv = File.ReadAllLines("inventory.csv");

            //var invItem = new List<string>();
            //var invAmount = new List<string>();

            //for (int i = 0; i < readInv.Length; i++)
            //{
            //    string[] rowData = readInv[i].Split(',');
            //    invItem.Add(rowData[0]);
            //    invAmount.Add(rowData[1]);

            //    Console.WriteLine(invItem[i] + " - " + invAmount[i]);
            //}

            //try
            //{
            //    Console.WriteLine("What item needs to be updated?");
            //    string item = Console.ReadLine();

            //    if (string.IsNullOrEmpty(item))
            //    {
            //        Console.WriteLine("Please input an item.");
            //        StreamWriter em = new StreamWriter("ErrorLog.txt", true);
            //        DateTime errorDate = DateTime.Now;

            //        em.WriteLine(errorDate + "\n" + "Invalid (null) item update." + "\n");
            //        em.WriteLine();
            //        em.Flush();
            //        em.Close();
            //        Console.Beep();
            //        Thread.Sleep(3000);
            //    }
            //    else
            //    {
            //        string[] editInv = File.AppendAllTextAsync("inventory.csv");

            //        var editItem = new List<string>();
            //        var editAmount = new List<string>();

            //        for (int i = 0; i < readInv.Length; i++)
            //        {
            //            string[] rowData = editInv[i].Split(',');
            //            editItem.Append(rowData[0]);
            //            editAmount.Append(rowData[1]);

            //            Console.WriteLine(editItem[i] + " - " + editAmount[i]);
            //        }
            //    }

            //    StreamWriter w = File.AppendAllLines("inventory.csv");



            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Your Inventory is currently empty. Please add items to view current Inventory. Thank You!\n\n" + "Error:" + ex);

            //    StreamWriter sw = new StreamWriter("ErrorLog.txt", true);
            //    DateTime errorDate = DateTime.Now;

            //    sw.WriteLine(errorDate + "\n" + ex + "\n");
            //    sw.WriteLine();
            //    sw.Flush();
            //    sw.Close();
            //    Thread.Sleep(3000);
            //    MainMenu.Menu();
            }
    }
}
