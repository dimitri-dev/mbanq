using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbanq.Algorithms
{
    public class Factorial
    {
        // "Primitive" way of calculating factorials...
        public ulong CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Negative factorials are not handled.");
            }

            if (number == 0)
            {
                return 1; // 0! = 1
            }

            ulong limit = (ulong)number;
            ulong factorial = 1;
            for (ulong i = 2; i <= limit; ++i)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Detailed maths: https://sites.google.com/site/examath/research/factorials
        public ulong CalculateFactorialShortcut(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Negative factorials are not handled.");
            }

            if (number == 0)
            {
                return 1; // 0! = 1
            }

            ulong n = (ulong)number;
            ulong sum = n;
            ulong factorial = n;

            for (ulong i = n - 2; i > 1; i -= 2)
            {
                sum += (sum + i);
                factorial *= sum;
            }

            if (n % 2 == 1)
                factorial *= n / 2 + 1;

            return factorial;
        }
    }
}
