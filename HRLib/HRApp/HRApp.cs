using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRApp
{
    public class HRApp
    {
 

        static void Main(string[] args)
        {


            string choice, number;



            #region Generic List <T>
            List<ConfirmEmployee> employeeList = new List<ConfirmEmployee>();
            employeeList.Add(new ConfirmEmployee { Name = "Nirmal", Address = "Street 108", TypeEmployee = "Trainee", Basic = 21000, Desgination = "Sofware Developer" });
            employeeList.Add(new ConfirmEmployee { Name = "Praful", Address = "Pune", TypeEmployee = "Developer", Basic = 25000, Desgination = "Tester" });
            //employeeList.Add(new ConfirmEmployee { Name = "Rakesh", Address = "Mumbai", TypeEmployee = ".Net Developer", Basic = 30000, Desgination = "Tester" });
            //employeeList.Add(new ConfirmEmployee { Name = "Chandrakant", Address = "Pune", TypeEmployee = "Java Developer", Basic = 20000, Desgination = "Tester" });

            List<Trainee> traineeList = new List<Trainee>();
            traineeList.Add(new Trainee { Name = "Shubham", Address = "Nashik", TypeEmployee = "Trainee" });
            traineeList.Add(new Trainee { Name = "Rohit", Address = "Chennai", TypeEmployee = "Trainee" });







            do
            {



                int number2 = 0;
                Console.WriteLine("1. Display All Employees");
                Console.WriteLine("2. Display Employee which you want");
                Console.WriteLine();
                Console.WriteLine("Enter your Choice");
                int result = int.Parse(Console.ReadLine());



                if (result == 1)
                {
                    foreach (ConfirmEmployee emplo in employeeList)
                    {
                        Console.WriteLine(emplo);
                    }
                    foreach (Trainee emplo in traineeList)
                    {
                        Console.WriteLine(emplo);
                    }
                }
                else if (result == 2)
                {
                    Console.WriteLine("Enter a Employee Number which you want : ");
                    number = Console.ReadLine();



                    foreach (ConfirmEmployee emplo in employeeList)
                    {
                        if (emplo.EmpNO== number)
                        {
                            Console.WriteLine(emplo);
                            number2++;
                            break;
                        }
                    }




                    foreach (Trainee emplo1 in traineeList)
                    {
                        if (emplo1.EmpNo == number)
                        {
                            Console.WriteLine(emplo1);
                            number2++;
                            break;
                        }
                    }



                    if (number2 == 0)
                    {
                        Console.WriteLine("Employe Not Found");
                    }
                }



                Console.WriteLine();
                Console.WriteLine("Do you Want to Continue Press 'y' or 'n' :");
                choice = Console.ReadLine();



            } while (choice == "y");

            #endregion








            Console.ReadLine();


        }
    }
}
