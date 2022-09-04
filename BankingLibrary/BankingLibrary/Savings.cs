using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class Savings : Bank, IInterest
    {
        private bool isSalAcc;

        public bool IsSalAcc
        {
            get { return isSalAcc; }
            set { isSalAcc = value; }
        }

        public Savings()
        {
            IsSalAcc = false;
        }

        public Savings(string name, double amount, bool isSalAcc) : base(name, amount)

        {
            IsSalAcc = isSalAcc;
        }
        public override string ToString()
        {
            return base.ToString() + $"IsSalAccount : {IsSalAcc}";
        }

        public override void Withdraw(double amount)
        {
            if (IsSalAcc == true)
            {

                    
                if ((Balance - amount) >= 1000)
                {
                    Balance -= amount;
                }

                else
                {
                    throw new BalanceException("Insufficient Balance");

                }
            }
            else
            {
                throw new BalanceException("Insufficient Balance");

            }

        }

        public double CalculateInterest()
        {
            return Balance * 0.1;
        }
    }   
       }
    

