using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
           
            double total = 0;
            double average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i=0; i< numbers.Length; i++)
            {
                total += numbers[i];
            }

            average = total / numbers.Length;
            Console.WriteLine("The numbers average is: " + average);

        }
    }
}
