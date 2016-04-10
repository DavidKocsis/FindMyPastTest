using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMyPastTest
{
    public class GetPrimes
    {
        public List<double> GetNumbersBelowSquareRoot(int number)
        {
            var squareroot = Math.Sqrt(number);
            int count = 2;
            var numbers = new List<double>{2};
            
            while (count <Math.Round(squareroot))
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
                if (number != numberToTest)
                {
                    var result = numberToTest/number;
                    if (result % 1 == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public List<int> GetPrimeNumbers(int input)
        {
            var primeNumbers = new List<int>();
            int numberTocheck = 2;

            while (primeNumbers.Count() < input)
            {
                if (IsNumberPrime(numberTocheck))
                {
                    primeNumbers.Add(numberTocheck);
                }
                numberTocheck++;
            }

            return primeNumbers;
        }
    }
}
