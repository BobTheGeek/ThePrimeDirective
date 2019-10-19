using System;
using System.Collections.Generic;

namespace ThePrimeDirective
{
    class Program
    {
        static List<int> listOfPrimes = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Let's Get This Party Started:");

            int n = 0;                  // ==== number to test for primality
            int target = 10001;         // ==== target position in the prime list
            bool makeItStop = false;    // ==== switch to stop when we reach our target

            while (!makeItStop) {
                if (isPrime(n))
                    listOfPrimes.Add(n);

                // ==== test if our array length has met our target
                if (listOfPrimes.Count == target)
                    makeItStop = true;
                else
                    n++;
            }

            Console.WriteLine("The answer is: " + n);
            Console.ReadLine();
        }

        // ==== Using "Simple methods" algorithm from https://en.wikipedia.org/wiki/Primality_test
        public static Boolean isPrime(Int64 n)
        {
            // ==== Not interested if the number is 0, 1, or a negative.
            if (n <= 3)
                return n > 1;
            // ==== Not interested if it is divisible by 2 or 3.
            else if ((n % 2 == 0) || (n % 3 == 0))
                return false;

            // ==== Check every odd number not divisible by 3 until its larger than the square root of n.
            int i = 5;
            while (i * i <= n)
            {
                if ((n % i == 0) || (n % (i + 2) == 0))
                    return false;
                i = (i + 6);
            }

            // ==== If you made it here, you are prime.
            return true;
        }
    }
}
