using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            
            for ( int i= 0; i < sevenDwarves.Length; i++)
            {
                string name = sevenDwarves[i];
                Console.WriteLine("Here is your dinner: " +name);
            }
            foreach (string dwarvesNames in sevenDwarves)
            {
                Console.WriteLine("Here is your drink: " + dwarvesNames);
            }

            string meal = "";

            foreach (string dwarvesNames in sevenDwarves)
            {
                Console.WriteLine( dwarvesNames + " what would you like to eat? ");
                meal = (Console.ReadLine().ToLower());
                Console.WriteLine("Here is your " + meal + " " + dwarvesNames + "! Enjoy :)");
                
            }
        }
    }
}
