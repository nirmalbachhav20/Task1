using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{

    public abstract class Bank
    {

        #region
        public Bank() 
        {
            Balance = 1000;
            count++;
            AccNo = count;

        }
        #endregion


        #region Static

        private static int count;
        
        public static int Count
        {
            get { return count; }
            private set { count = value; }
        }
        #endregion

        #region parameterzied Constructor
        public Bank(string name, double amount) :this()
        {
            AccHolderName = name;
            Balance = amount;   
        }
        #endregion

        #region property
        private int accno; // camel case


        public int AccNo
        {
            get { return accno; }
            set { accno = value; }


        }

        private string accholdername;


        public string AccHolderName
        {
            get { return accholdername; }
            set { accholdername = value; }
        }

        private double balance;

        //mixed Access Specifier
        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }

        }

        public void Deposite(double amount)
        {
            Balance += amount;
        }

        //public virtual void Withdraw(double amount)
        //{

        //    balance -= amount;
        //}
        #endregion

        //Abstract

        public abstract void Withdraw(Double amount);





        public override string ToString()
        {
            return String.Format($"AccNo : {accno} AccHolderName : {accholdername} Balance : {balance}");
        }

        
    }





}



