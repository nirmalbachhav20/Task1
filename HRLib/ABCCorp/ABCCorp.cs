using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace ABCCorp
{
    internal class ABCCorp
    {
        static void Main(string[] args)
        {

            

          
          
          






            ConfirmEmployee confirmEmployee = new ConfirmEmployee( "Nirmal", "street 205",15000, "trainee");
            Console.WriteLine(confirmEmployee);





            ConfirmEmployee confirmEmployeee1 = new ConfirmEmployee();
            Console.WriteLine(confirmEmployeee1);





            Trainee trainee = new Trainee( "Nirmal", "pune30", 30,1000 );
            Console.WriteLine(trainee);





            Console.WriteLine(trainee.CalculateSalary());





            Console.WriteLine(confirmEmployeee1.CalculateSalary());


            Console.ReadLine();


        }

    }
}
