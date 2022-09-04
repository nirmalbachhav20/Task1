using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordLibrary;

namespace PassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Password : ");
            string value  = Console.ReadLine(); 

            Password password = new Password(value);
            Console.WriteLine(password);

            try
            {
                bool res = password.IsPasswordValidate();
                Console.WriteLine(res);
            }
            catch(WeakPassword ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Password Not match with Conditon. Please Enter New Password");
            }
            
            Console.ReadLine();
        }
    }
}
