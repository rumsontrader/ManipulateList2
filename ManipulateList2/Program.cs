using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateList2
{
    class Program
    {
        static void Main(string[] args)
        {
            var groceries = new List<string>();

            string itemInList;
            string input;
            string output;
            string inputWithPrefixRemoved;
            string prefix;

            Console.WriteLine("Grocery List: To add an item type + item");
            Console.WriteLine("To remove an item type - item");
            Console.WriteLine("To clear the list type --");
            Console.WriteLine("To exit hit enter");


            while (true)
            {
                Console.WriteLine("Please add, remove, or clear ");
                input = Console.ReadLine();
                if (input == "" || input == "exit")
                {
                    System.Environment.Exit(0);
                }
                inputWithPrefixRemoved = input.Substring(2);
                prefix = input.Substring(0, 2);

                switch (prefix)
                {
                    case "+ ":
                        groceries.Add(inputWithPrefixRemoved);
                        break;

                    case "- ":
                        groceries.Remove(inputWithPrefixRemoved);
                        break;
                    case "--":
                        groceries.Clear();
                        break;
                    //default:
                        //System.Application.Exit();
                }
                Console.WriteLine($"Your list now contains:");

                for (int i = 0; i < groceries.Count; i++)
                {                    
                    Console.Write($"{groceries[i]} , ");
                }
                Console.WriteLine();
                Console.Out.NewLine = "\r\n\r\n";
                }

        }
    }
}
