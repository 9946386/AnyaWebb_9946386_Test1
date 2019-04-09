using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("This program can give you the result of base^exponent.");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Enter the value of the base: ");
            double num1 = double.Parse(Console.ReadLine()); //adding a variable to the value entered/making the value a double
            Console.Write("Enter the value of the exponent: ");
            int num2 = int.Parse(Console.ReadLine()); //adding a variable to the value entered/making the value an int
            
            Console.WriteLine("{0}^{1}={2}",num1,num2,num1*num1*(++num2));//Should display the base ^ the exponent and the result (which I can't figure out)
            Console.ReadLine();
            //I tried so many different ways but couldn't figure out how to find the value.
         
        }
       
        
    }
}
