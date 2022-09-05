using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double hra = 0, conv = 0, pf = 0, netSalary;

            if (Basic >= 30000)
            {
                hra = Basic * 0.3;
                conv = Basic * 0.2;
                pf = Basic * 0.3;
                netSalary = basic + hra + conv - pf;
            }
            else if (Basic >= 20000)
            {
                hra = Basic * 0.2;
                conv = Basic * 0.2;
                pf = Basic* 0.2;
                netSalary = basic + hra + conv - pf;

            }
            else
            {
                hra = Basic * 0.1;
                conv = Basic * 0.1;
                pf = Basic * 0.1;
                netSalary = basic + hra + conv - pf;
            }
          
            return netSalary;

        }


        private double basic;

        public double Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        private string desgination;

        public string Desgination
        {
            get { return desgination; }
            set { desgination = value; }
        }

        public string EmpNO { get; set; }

        public ConfirmEmployee()
        {
            Basic = 30000;
            Desgination = "Software Engineer";
        }


        public ConfirmEmployee(string name,  string address, double basic, string desgination) : base(name, address)
        {
            Basic = basic;
            Desgination = desgination;

        }

      

        public override string ToString()
        {
            return base.ToString() + $", Basic : {basic} Desgination : {desgination}";
        }

       
    }

       
    }




