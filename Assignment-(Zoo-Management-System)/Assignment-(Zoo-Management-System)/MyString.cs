using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Zoo_Management_System_
{
    class MyString
    {
        public static string FirstLetterToUpper(string s)
        {
            if (s == null)
                throw new Exception();

            return s.First().ToString().ToUpper() + s.Substring(1);
        }
    }
}
