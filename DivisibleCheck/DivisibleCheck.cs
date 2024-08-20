using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleCheck
{
    public class DivisibleCheck
    {
        public static bool Checking(int input)
        {
            int divideBy100 = input / 100;
            int divideBy10 = divideBy100 % 10;
            return divideBy10 == 7;
        } 
    }
}
