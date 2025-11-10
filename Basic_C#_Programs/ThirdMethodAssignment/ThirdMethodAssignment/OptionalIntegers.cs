using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdMethodAssignment
{
    internal class OptionalIntegers
    {
        ///<summary>
        ///Method that takes two integers as parameters, one optional, then does math op and returns
        ///result as integer
        ///</summary>
        public int OptionalIntMethod(int val1, int val2 = 0)
        {
            int result = val1 + val2;
            return result;
        }
    }
}
