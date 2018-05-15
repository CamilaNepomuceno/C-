using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNumber = 13;
            int numberEntered = 0;
            do
            {
                Console.WriteLine("Guess The Number I am thinking ");
                Console.Write("Choose the number: ");

                numberEntered = Convert.ToInt32(Console.ReadLine());
                if (numberEntered == myNumber)
                {
                    Console.WriteLine("You guessed right!!!");
                }
                else if (numberEntered < myNumber)
                {
                    Console.WriteLine("Try a bigger number!! ");
                }
                else
                {
                    Console.WriteLine("Try a smaller number!! ");
                } 
            } while (numberEntered != myNumber);
        } 
        
    }
}


