using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
       
        private int noofdays;

        public int NoOfDays
        {
            get { return noofdays; }
            set { noofdays = value; }
        }


        private double rateperday;

        public double RatePerDay
        {
            get { return rateperday; }
            set { rateperday = value; }
        }

        public string EmpNo { get; set; }

        public Trainee()
        {
            NoOfDays = 30;
            RatePerDay = 1000;
        }


        public Trainee(string name, string address,int num,double amount):base(name,address)
        {
            NoOfDays = num;
            RatePerDay = amount;
            
        }

        

        public override string ToString()
        {
            return String.Format($", Number of Day : {NoOfDays}, Rate Per Day : {RatePerDay}");
        }
        public override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }
    }
}
