using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            string newbook = "";
            string removeBook = "";
            string findBook = "";
            string bookToFind = "";


            List<string> bookCollection = new List<string>() { "SNOW WHITE", "CINDERELLA", "RAPUNZEL" };

            do
            {

                Console.WriteLine("We have a interesting Book collection, if you want to add one press Y, to remove a book press R, to sort press S, if you are looking for a particular book press L or to exit press X");
                choice = (Console.ReadLine()).ToUpper();

                if (choice == "Y")
                {
                    Console.WriteLine("Write the book title here: ");
                    newbook = (Console.ReadLine().ToUpper());
                    bookCollection.Add(newbook);

                }
                else if (choice == "R")
                {
                    Console.WriteLine("Write the book title you want to remove: ");
                    removeBook = (Console.ReadLine().ToUpper());
                    bookCollection.Remove(removeBook);
                    Console.WriteLine("The book " + removeBook + " was removed.");

                }
                else if (choice == "S")
                {
                    bookCollection.Sort();
                    foreach (string book in bookCollection)
                    {
                        Console.WriteLine(book);
                    }
                }
                else if (choice == "L")
                {
                    Console.WriteLine("Which book are you looking for");
                    findBook = (Console.ReadLine());
                    bool isAvailable = false;
                    isAvailable = bookCollection.Any(b => b.Equals(bookToFind, StringComparison.OrdinalIgnoreCase));
                    if (isAvailable)
                    {
                    Console.WriteLine(bookToFind + "is in the list. :) ");
                    }
                    else
                    {
                        Console.WriteLine(bookToFind + "it is not in the list. :(");
                    };


                }
                else if (choice == "X")
                {
                    Console.WriteLine("This is the currently collection:  ");
                    foreach (string book in bookCollection)
                    {
                        Console.WriteLine(book);
                    }
                }
            } while (choice != "X");
        }
    }
}
