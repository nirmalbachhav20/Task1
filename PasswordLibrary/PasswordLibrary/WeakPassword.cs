using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLibrary
{
    public class WeakPassword : Exception
    {
        public WeakPassword(string value) : base (value)
        {

        }

    }
}
