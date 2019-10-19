using System;
using System.Collections.ObjectModel;

namespace SieveOfEratosthenes
{
    internal static class Program
    {
        #region Private Methods

        public static void Main()
        {
            var sieve = new Sieve();

            ReadOnlyCollection<int> result;

            result = sieve.SetMaxnumber(2).Calculate();
            Console.WriteLine(string.Join(", ", result));
            result = sieve.SetMaxnumber(9).Calculate();
            Console.WriteLine(string.Join(", ", result));
            result = sieve.SetMaxnumber(10).Calculate();
            Console.WriteLine(string.Join(", ", result));
            result = sieve.SetMaxnumber(100).Calculate();
            Console.WriteLine(string.Join(", ", result));

            Console.ReadKey();
        }

        #endregion Private Methods
    }
}