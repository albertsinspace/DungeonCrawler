using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dungeon Crawler");
            Console.WriteLine();
            Console.WriteLine("1. Play");
            Console.WriteLine("2. How to play");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter choice from menu: ");
            var userMenuChoice = Console.ReadLine();

            if (userMenuChoice == "1")
            {
                return;
            }

            else if (userMenuChoice == "2")
            {
                return;
            }

            else if (userMenuChoice == "3")
            {
                return;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect input, please choose from the menu");
            }
        }
    }
}
