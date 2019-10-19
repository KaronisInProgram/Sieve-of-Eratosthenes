using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveOfEratosthenes
{
    internal class Sieve
    {
        #region Private Fields

        private const int smallestPrimeNumber = 2;
        private int maxNumber = smallestPrimeNumber;

        #endregion Private Fields

        #region Public Methods

        public List<int> Calculate()
        {
            List<int> result = new List<int>();

            if (maxNumber < smallestPrimeNumber)
            {
                return result;
            }

            // Fill List till max Number
            for (int i = smallestPrimeNumber; i <= maxNumber; i++)
            {
                result.Add(i);
            }

            // Calculate Root so we can remove all Non-Primes in the List
            var squarRoot = (int)Math.Round(Math.Sqrt(maxNumber), 0, MidpointRounding.ToPositiveInfinity);

            for (int i = smallestPrimeNumber; i <= squarRoot; i++)
            {
                result = result.Where((number) => number == i || (number % i) != 0).ToList();
            }

            return result;
        }

        public Sieve SetMaxnumber(int maxNumber)
        {
            this.maxNumber = maxNumber;
            return this;
        }

        #endregion Public Methods
    }
}