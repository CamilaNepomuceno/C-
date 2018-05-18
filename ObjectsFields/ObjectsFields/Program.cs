using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsFields
{
    public class Cars
    {
        public string make = "";
        public string model = "";
        public int price = 0;
        public string transmission = "";
        public bool sold = false;

        public static int CarsForSale = 0;

        public void AddDetailsOfCars(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;

            this.sold = false;

            CarsForSale++;                    
        }

        public void DisplayCars()
        {
            Console.WriteLine("Make: {0} \nModel {1}\nPrice: £{2:N0}.", make, model, price);  
            if (sold)
            {
                Console.WriteLine("This car has been sold.");
            }
            else
            {
                Console.WriteLine("This car is available to buy.");
            }
            Console.WriteLine();
        }
        public void SellCars(int price)
        {
            this.sold = true;
            this.price = price;

            CarsForSale--;

            Console.WriteLine("The car {0} has been sold.", this.make);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cars.CarsForSale = 0;


           
            Cars car1 = new Cars();
            car1.AddDetailsOfCars("Aston Martin", "One-77", 1113657);
            /*car2.make = "Aston Martin";
            car2.model = "One-77";
            car2.price = 1113657; */

           

            Cars car2 = new Cars();
            car2.AddDetailsOfCars("Bugatti", "Chiron", 2998000);
          /*car2.make = "Bugatti";
            car2.model = "Chiron";
            car2.price = 2998000; */

            

            Cars car3 = new Cars();
            car3.AddDetailsOfCars("Lamborghini", "Veneno", 2800000);
          /*car3.make = "Lamborghini";
            car3.model = "Veneno";
            car3.price = 2800000; */

           

            Console.WriteLine("These are the details of the cars in the shop at the moment: ");
            Console.WriteLine();
            car1.DisplayCars();
            car2.DisplayCars();
            car3.DisplayCars();
            /*
            Console.WriteLine(car1.make + "\nModel: " + car1.model + "\nPrice: " + car1.price);
            Console.WriteLine();
            Console.WriteLine(car2.make + "\nModel: " + car2.model + "\nPrice: " + car2.price);
            Console.WriteLine();
            Console.WriteLine(car3.make + "\nModel: " + car3.model + "\nPrice: " + car3.price);
            */
            Console.WriteLine();
            Console.WriteLine("The total number of cars for sale is: " + Cars.CarsForSale);
            Console.WriteLine();
            car1.SellCars(1113657);

            Console.WriteLine();
            Console.WriteLine("The total number of cars for sale is: " + Cars.CarsForSale);
            Console.WriteLine();

        }
    }
}
