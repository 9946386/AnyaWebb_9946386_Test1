using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("This program will give the sum total of 5 prices");
            Console.WriteLine("------------------------------------------------");

            for (double i = 1; i <= 5; i++)//Statement 1 = where it starts, statement 2 = where it finishes, statement 3 = increment counter.
            {
                Console.Write("Please enter the price of item {0}: ",i);//i so that the item number increased each time
                double price = double.Parse(Console.ReadLine());//Giving the users input a variable and using double because it will be a decimal number.
                               
            }
            Console.WriteLine("The sum of those numbers is: $? ");//I couldn't remember how to add all of the prices together.
            Console.ReadLine();
                    
        }
    }
}
