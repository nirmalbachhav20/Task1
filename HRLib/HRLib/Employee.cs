using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        public string TypeEmployee { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private int empno;

        public int EmpNO
        {
            get { return empno; }
            set { empno = value; }
        }

        private static int count;

        public static int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public Employee()
        {
            EmpNO = Count;
            Count++;
        }
       
        static Employee()  
        {
            count = 1000;
        }

        public Employee(string name, string address) :this()
        {
            Name = name;
            Address = address;
        }
        public abstract double CalculateSalary();

        public override string ToString()
        {
            return string.Format($"Name : {name} Address : {address}");
        }


       
       



    }

   
}



        
    

