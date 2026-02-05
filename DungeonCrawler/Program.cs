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
            List<string> weaponList = new List<string> {"sword", "gun", "crossbow", "bow", "magic"};

            foreach (string weaponItem in weaponList)
            {
                Console.WriteLine(weaponItem);
            }
        }
    }
}
