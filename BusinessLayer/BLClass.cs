using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLClass
    {
        public int Divide(string Numerator,string Denominator)
        {
            int r= 0, r1 = 0;
            bool n = int.TryParse(Numerator, out r);
            bool n1 = int.TryParse(Denominator, out r1);
            if (n && n1)
            {
                if (r1 != 0)
                    return r / r1;
                else
                    throw new DivideByZeroException("cannot divide by zero");
            }
            else
                throw new FormatException("only Numbers");
        }
        public int age(DateTime dob)
        {
            //DateTime dt = DateTime.Parse(dob);
            int age = (int)(DateTime.Now.Subtract(dob).TotalDays / 365);
            if (age > 18 && age < 60)
                return age;
            else
                throw new customexception("age should be between 18 and 60");
           
        }
    }
}
