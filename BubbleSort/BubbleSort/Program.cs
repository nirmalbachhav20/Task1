using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 12, 11, 6, 2, 1, 25 };
            int a;



            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        a = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = a;
                    }
                }
            }



            foreach (int b in num)
            {
                Console.Write(b + " ");
            }



            Console.ReadLine();



        }
    }
    }
    
