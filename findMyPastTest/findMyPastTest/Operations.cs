using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMyPastTest
{
    public static class Operations
    {
        public static double multiplyNumbers(int number1, int number2)
        {
           double result = number1*number2;
            return Math.Round(result);
        }
    }
}
