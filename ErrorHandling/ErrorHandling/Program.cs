using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Camila", "John", "Mary" };
            string any = "";
           
            try
            {
                any = students[3];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("There is not this many students");
            }
            
            Console.ReadLine();
        }
    }
}
