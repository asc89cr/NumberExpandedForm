using System;
using System.Collections.Generic;
using System.Numerics;

namespace NumberExpandedForm
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = ExpandedForm(91234567891234);
        }

        public static string ExpandedForm(long num)
        {
            BigInteger factor = 1;
            long acumulator = num;
            List<BigInteger> digits = new List<BigInteger>();

            for (long i = 0; i < num.ToString().Length; i++)
            {
                if (acumulator % 10 * factor != 0)
                {
                    digits.Add(acumulator % 10 * factor);
                    acumulator = acumulator / 10;
                    factor = factor * 10;
                }
                else
                {
                    acumulator = acumulator / 10;
                    factor = factor * 10;
                }
                    
            }

            digits.Reverse();

            return String.Join(" + ", digits);
        }
    }
}
