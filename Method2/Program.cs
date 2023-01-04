using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number if needed: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is : {0} ", number1 + number2);
            Console.ReadLine();

        }
    }
}
