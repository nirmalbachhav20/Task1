using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingLibrary;

namespace ICICIApp
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Bank bank = new Bank();
            //Console.WriteLine(bank);

            //bank.AccHolderName = "Nirmal";
            ////bank.Balance = 30000;

            //Console.WriteLine(bank);

            //bank.Deposite(20000);
            //Console.WriteLine("-----After Deposite \n " + bank);

            //bank.Withdraw(5000);
            //Console.WriteLine("------After Withdrwal \n " + bank);


            //Console.WriteLine("-----------------------");

            //Bank bank1 = new Bank( "Rahul", 20000 );    
            //Console.WriteLine(bank1);


            //Console.WriteLine("-----------------------");

            //Bank bank2 = new Bank("Shubham", 10000);
            //Console.WriteLine(bank2);
            

            Savings savings = new Savings();
            Console.WriteLine(savings);
            try
            {
                savings.Withdraw(10000);
                Console.WriteLine(savings);
            }
            catch (BalanceException ex)
            {

                Console.WriteLine( ex.Message );
            }

            double interset = savings.CalculateInterest();
            Console.WriteLine("Total interest Amount : ");

            Console.WriteLine("--------------------------");
            Savings savings1 = new Savings("don", 1500, true);
            Console.WriteLine(savings1);
            

            Console.ReadLine();
            
        }
        

        

    }
}
