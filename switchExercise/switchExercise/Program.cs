using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is the of the candidates who stood for Presidency of the USA in 2016: ");
            Console.WriteLine("Hillary Clinton, Bernie Sanders, Donald Trump, Jeb Bush");
            Console.WriteLine("Who do you think won?");
            string president = (Console.ReadLine()).ToLower();
            string reply = "";
            

            switch (president)
            {
                case "hillary clinton":
                    reply = "She was nominate by Democrats by unfortunately she did not won ";
                    break;
                case "bernie sanders":
                    reply = "He dropped out and endorssed Hillary CLinton";
                    break;
                case "donald trump":
                    reply = "He was nominate by Republicans and unfortunately he did won ";
                    break;
                case "jeb bush":
                    reply = "He dropped out and endorssed Donald Trump ";
                    break;
                default:
                    reply = "This candidate was not on the list!!";
                    break;
            }
            Console.WriteLine(reply);
            
        }
    }
}
