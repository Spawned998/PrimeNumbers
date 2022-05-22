using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatesMathLibrary
{
    public static class PrimeNumbers
    {

        public static bool CheckIfPrime(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }


        public static List<int> GetAllPrimeNumbers(int maxValue = int.MaxValue)
        {
            List<int> output = new List<int>();

            for (int i = 1; i < maxValue; i++)
            {
                if (PrimeNumbers.CheckIfPrime(i))
                {
                    output.Add(i);
                }
            }

            return output;
        }

        public static List<int> GetAllPrimeFactors(List<int> factorialList)
        {
            List<int> output = new List<int>();

            foreach (int item in factorialList)
            {
                if (CheckIfPrime(item) == true)
                {
                    output.Add(item);
                }
            }

            return output;
        }


        public static int GetLargestFactorial(List<int> primeFactorials)
        {
            int output = primeFactorials.Max();

            return output;
        }


        public static List<int> GetAllFactors(int number)
        {
            List<int> output = new List<int>();

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    output.Add(i);
                }
            }

            return output;
        }

    }
}
