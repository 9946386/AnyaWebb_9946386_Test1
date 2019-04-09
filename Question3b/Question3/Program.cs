using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Can you solve the following algebraic expression?");
            Console.WriteLine("-------------------2(x-3)+x=12-------------------");
            Console.WriteLine("-------------------------------------------------");
            int x = 6;//x = my answer to the question

            Console.Write("Enter your guess at the value of x: ");
            int guess = int.Parse(Console.ReadLine());

            if(x == guess)//if my answer is the same as their answer it will run this code
            {
                Console.WriteLine("You are correct");
            }

            else//if they got a different answer (anything else) it will run this code
            {
                Console.WriteLine("Sorry, that is not correct");
            }
            Console.ReadLine();
                                 
        }
    }
}
