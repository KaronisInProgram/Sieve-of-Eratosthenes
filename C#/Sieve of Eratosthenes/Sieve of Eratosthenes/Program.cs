using System;
using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    internal static class Program
    {
        #region Private Methods

        public static void Main()
        {
            List<int> startNumbers = new List<int>()
            {
                2, 5, 10, 247, 500, 1029
            };

            var sieve = new Sieve();

            foreach (var start in startNumbers)
            {
                Console.WriteLine($"Begin of Output (Max Number { start })");
                Console.WriteLine(string.Join(", ", sieve.SetMaxnumber(start).Calculate()));
                Console.WriteLine($"End of Output{ Environment.NewLine}");
            }
        }

        #endregion Private Methods
    }
}