using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using findMyPastTest;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            var count =int.Parse(Console.ReadLine());
            var primeNumbers = GetPrimes.GetPrimeNumbers(count);
            string primeline = "   |  ";

            foreach (var primenumber in primeNumbers)
            {
                primeline += primenumber + "  |  ";
            }

            Console.WriteLine("showing {0} prime numbers",count);
            Console.WriteLine(primeline);
            foreach (var primeNumber in primeNumbers)
            {
                string multipleLines = null;
                multipleLines += primeNumber + "  |";
                foreach (var multiplier in primeNumbers)
                {
                    multipleLines += "  " + Operations.multiplyNumbers(primeNumber, multiplier) + "  |";
                }
                Console.WriteLine(multipleLines);
            }
        }
    }
}
