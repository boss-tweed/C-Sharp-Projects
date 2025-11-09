using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class ThreeMethods
    {
        ///<summary>
        ///Takes integer, creates a math op and returns answer as an integer
        ///</summary>
        public int MethodOne(int value)
        {
            return value + 10;
        }

        ///<summary>
        ///2nd mthod of the same name takes decimal, creates a 
        ///different math op and returns answer as an integer
        ///</summary>
        public int MethodOne(decimal value)
        {
            return Convert.ToInt32(value * 20);
        }

        ///<summary>
        ///3rd method of same name takes string, converts to integer, 
        ///does math op and returns an integer
        ///</summary>
        public int MethodOne(string value)
        {
            int stringToInt = Convert.ToInt32(value);
            return stringToInt - 75;
        }
    }
}
