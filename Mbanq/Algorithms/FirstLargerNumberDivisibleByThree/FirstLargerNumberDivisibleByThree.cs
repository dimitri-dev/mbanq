using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbanq.Algorithms
{
    public class FirstLargerNumberDivisibleByThree
    {
        // This is a safe solution, if number is out of bounds (i.e. too large, it will return 0)
        // Logic: If at any point "a" is MaxValue, return 0 since next inrementation will be MinValue, which isn't "larger".
        // Different solution: Use BigInteger from System.Numerics - then you are memory bound.
        public long GetsFirstLargerNumberDivisibleByThree(long a)
        {
            do
            {
                if (a == long.MaxValue)
                    return 0;

                ++a;
            } while (a % 3 != 0);

            return a;
        }
    }
}
