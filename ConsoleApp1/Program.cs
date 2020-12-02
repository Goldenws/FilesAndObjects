using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            WriteShoppingList();
        }

        public static void WriteShoppingList()
        {
            List<string> shoppingList = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter item: ");
                string item = Console.ReadLine();
                Console.WriteLine("enter price: ");
                string price = Console.ReadLine();

                string line = $"{item}/{price}";
                shoppingList.Add(line); //add a line to the shoppingList list

            }

            string filePath = @"C:\Users\Roland Strod\Samples";
            string fileName = @"shoppingList.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), shoppingList);

        }
    }
}
