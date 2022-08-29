using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInfoLib;

namespace PersonDataTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person("Nirmal", "Bachhav", "NB@gmail.com", Convert.ToDateTime("26/09/1997"));

            Console.WriteLine(person1);


            Console.WriteLine("Is person is Adult " + person1.IsAdult());






            Console.ReadLine();

        }
    }
}
