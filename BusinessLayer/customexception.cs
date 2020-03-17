using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class customexception:Exception
    {
        public customexception(string s):base(s)
        {

        }
    }
}
