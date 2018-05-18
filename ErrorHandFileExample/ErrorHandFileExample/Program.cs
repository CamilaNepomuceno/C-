using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\student\Desktop\CamilaC\mydataC.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("and the program continues ... ");

        }
    }
}
