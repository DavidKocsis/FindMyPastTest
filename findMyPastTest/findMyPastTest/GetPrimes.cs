using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMyPastTest
{
    public class GetPrimes
    {
        public List<int> GetNumbersBelowSquareRoot(int number)
        {
            var squareroot = Math.Sqrt(number);
            int count = 1;
            var numbers = new List<int>();
            
            while (count <= squareroot)
            {
                numbers.Add(count);
                count++;
            }

            return numbers;
        }

        public bool IsNumberPrime(int numberToTest)
        {
            var numbers = GetNumbersBelowSquareRoot(numberToTest);
            foreach (var number in numbers)
            {
                var result = numberToTest/number;
                if (result%1 == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
