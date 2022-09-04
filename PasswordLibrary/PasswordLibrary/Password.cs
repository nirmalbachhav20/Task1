using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PasswordLibrary
{
    public class Password
    {

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

       public Password(string pass)
        {
            Pass = pass;
        }

        private static readonly Regex regex = new Regex("[^A-Za-z0-9]");


        private Boolean IsLength()
        {
            if(pass.Length >=6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private Boolean IsSpecialCharacter()
        {
            if(regex.IsMatch(pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private Boolean IsUpperCase()
        {
            if (char.IsUpper(pass, 0))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }









        private Boolean IsDigit()
        {
            bool isNumber = int.TryParse(pass, out int digit);
            if(regex.IsMatch(pass)|| isNumber)
            {
                return true ;
            }
            else
            {
                return false ;
            }
        }



        public Boolean IsPasswordValidate()
        {
            if(IsLength()==true && IsDigit()== true && IsSpecialCharacter()==true && IsUpperCase()==true)
            {
                return true;
            }
            else
            {
                throw new WeakPassword("Password Not match with Conditon. Please Enter New Password");
            }
        }

       
    }
}
