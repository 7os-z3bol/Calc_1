using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result =0;
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("please Enter the  first Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of Operation Would you like To Do!!");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1)
            {
                result = num1 + num2;  
            }
            else if (choice == 2)
            {
                result = num1 - num2;
            }
            else if (choice == 3)
            {
                result = num1 * num2;
            }
            else if (choice == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return;
                }
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Choice, Please enter corect Choice");
            }
            Console.WriteLine("The result is: " + result);

            Console.ReadKey();

        }
    }
}
