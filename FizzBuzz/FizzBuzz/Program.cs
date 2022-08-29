using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

           

            // Loop for 100 times
            for (int i = 1; i <= n; i++)
            {

                
                if (i % 3 == 0)
                    Console.WriteLine("Fizz" + " ");

                else if (i % 5 == 0)
                    Console.WriteLine("Buzz" + " ");

                else if (i % 9 == 0)
                    Console.WriteLine("FizzBuzz" + " ");

                // Print the numbers
                else
                    Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
    }
}
