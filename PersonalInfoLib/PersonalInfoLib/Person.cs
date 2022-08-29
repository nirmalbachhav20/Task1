using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfoLib
{
    public class Person
    {
        private string firstname; // camel case


        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }


        }

        private string lastname; // camel case


        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }


        private string email; // camel case


        public string Email
        {
            get { return email; }
            set { email = value; }
        }




        private DateTime birthdate; // camel case


        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public bool IsAdult()
        {
            int age = DateTime.Now.Year - birthdate.Year;

            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        


    public Person(string _firstname, string _lastname, string _email, DateTime _birthdate)
        {
            this.FirstName = _firstname;
            this.LastName = _lastname;
            this.Email = _email;
            this.BirthDate = _birthdate;
        }
        public override string ToString()
        {
            return String.Format($"firstname : {FirstName} lastname : {LastName} email : {Email} birthdate : {BirthDate}");
        }


    }
}
