using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter a sign +, -, *, /, or ^ : ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter second a number: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            decimal total = 0m;

            switch (sign)
            {
                case '+':
                    total = AddNumbers(number1, number2);
                    break;
                case '-':
                    total = SubNumbers(number1, number2);
                    break;
                case '*':
                    total = MultiNumbers(number1, number2);
                    break;
                case '/':
                    total = DivNumbers(number1, number2);
                    break;
                case '^':
                    total = PowNumbers(number1, number2);
                    break;

            }

            Console.WriteLine(number1 + " " + sign + " " + number2 + " = " + total);
        }

        static decimal AddNumbers(decimal one, decimal two)
        {
            decimal totalAddition = one + two;
            return totalAddition;
        }


        static decimal SubNumbers(decimal one, decimal two)
        {
            decimal totalSubtraction = one - two;
            return totalSubtraction;
        }

        static decimal MultiNumbers(decimal one, decimal two)
        {
            decimal totalMultiplication = one * two;
            return totalMultiplication;
        }

        static decimal DivNumbers(decimal one, decimal two)
        {
            decimal totalDivision = one / two;
            return totalDivision;
        }

        static decimal PowNumbers(decimal one, decimal two)
        {
            decimal totalPow = one ^ two;
            return totalPow;
        }

    }
}





