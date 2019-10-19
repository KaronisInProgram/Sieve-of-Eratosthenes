using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SieveOfEratosthenes
{
    internal class Sieve
    {
        #region Private Fields

        private readonly int startNumber = 2;
        private int maxNumber = 2;

        #endregion Private Fields

        #region Public Methods

        public ReadOnlyCollection<int> Calculate()
        {
            IList<int> result = new List<int>();

            // Fill List till max Number
            for (int i = startNumber; i <= maxNumber; i++)
            {
                result.Add(i);
            }

            var squarRoot = Convert.ToInt32(Math.Sqrt(maxNumber));

            for (int i = startNumber; i < squarRoot; i++)
            {
                result = result.Where((number) => (number % i) != 0).ToList();
            }

            return new ReadOnlyCollection<int>(result);
        }

        public Sieve SetMaxnumber(int maxNumber)
        {
            this.maxNumber = maxNumber;
            return this;
        }

        #endregion Public Methods
    }
}