using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using findMyPastTest;

namespace UnitTests
{
    public class Tests
    {
        private GetPrimes getPrimes = new GetPrimes();

        [Test]
        public void GetNumbersBelowSquareRootTest()
        {
            int inputNumber = 25;
            var result = getPrimes.GetNumbersBelowSquareRoot(inputNumber);
            Assert.AreEqual(result.Count(),5);
        }

        [Test]
        public void GetNumbersBelowSquareRootTestWhenSquareRootIsNotWholeNumber()
        {
            int inputNumber = 37;
            var result = getPrimes.GetNumbersBelowSquareRoot(inputNumber);
            Assert.AreEqual(result.Count(), 6);
        }

        [Test]
        public void CheckNumberIsPrimeReturnsFalseWhenNumberIsNotPrime()
        {
            int numberToTest = 25;
            var result = getPrimes.IsNumberPrime(numberToTest);
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckNumberIsPrimeReturnsFalseWhenNumberIsPrime()
        {
            int numberToTest = 37;
            var result = getPrimes.IsNumberPrime(numberToTest);
            Assert.IsFalse(result);
        }

    }
}
