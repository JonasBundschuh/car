using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Car> list = new List<Car>();   
            list.Add(new Car(1337, "BMW", "i8", "BMW", "White", 500, false, false, false, true));
            
            foreach (Car c in list)
            {

                Console.WriteLine("Would you like to start? (y/n)");
                string userStart = Console.ReadLine();

                if(userStart == "y")
                {
                    Console.Clear();
                    c.PrintCar();
                    c.LackierenStart();
                    Console.Clear();
                    c.PrintCar();
                    c.SpeedSTart();
                    c.SpeedSTart();
                    c.BemsenStart();
                    
                }
                else if(userStart == "n")
                {
                    Console.WriteLine("Good Bye");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("not a valid option!");
                }

           
               
            }

            Console.ReadLine();
        }
    }
}
