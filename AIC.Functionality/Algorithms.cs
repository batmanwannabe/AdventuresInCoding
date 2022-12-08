using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Functionality
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int i, fact;
            Console.WriteLine("Enter the Number");
            fact = n;
            for (i = n - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;

        }

        public static string BuildFormattedString(List<string> items)
        {
            string joined = String.Join(", ", items.ToArray(), 0, items.Count - 1) + ", and " + items.Last() + "!";

            return joined;
        }
    }
}
