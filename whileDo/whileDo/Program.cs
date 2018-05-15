using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1 = "candle";

            Console.WriteLine("...... Time for riddles ......");
            Console.WriteLine(" I’m tall when I’m young and I’m short when I’m old. What am I?");
            string firstTry = (Console.ReadLine()).ToLower();
            int nTry = 0;
            while (firstTry != answer1 && nTry < 3)
            {
                Console.WriteLine("Try again!! ");
                nTry ++;
                firstTry = (Console.ReadLine()).ToLower();

            }
            Console.WriteLine("You guessed right!!!");

            string answer2 = "teapot";
            string secondTry = "";
            int nTry2 = 0;
            do
                {
                    Console.WriteLine(" What starts with the letter “t”, is filled with “t” and ends in “t”? ");
                    secondTry = (Console.ReadLine()).ToLower();
                
                    if (secondTry == answer2)
                    {
                        Console.WriteLine("You are right!");
                        
                }
                    else if (secondTry != answer2)
                    {
                        Console.WriteLine("Try again!");
                        
                }   nTry2++;
                    
                } while (secondTry != answer2 && nTry2 < 3);
            }
        }
}

