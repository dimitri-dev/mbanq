using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    // (Eg: a = 5, b = 5; result: a = 5, b = 3)
    // Task description leaves a big question mark.
    // Hopefully that's an error on your part, and you originally meant it as (a = 3, b = 5) => (a = 5, b = 3)
    public class ReplaceTwoVariables
    {
        // Classic "dumb" way to go about it.
        // This code may cause an overflow for a large value and it will produce wrong results at that point.
        public void SwapNumbersUnsafe(ref ulong a, ref ulong b)
        {
            if (a == b) // Try to short circuit to avoid unnecessary calculations
                return;

            a += b;
            b = a - b;
        }

        // This violates the task description (usage of additional variable) but it is actually safe.
        // Also, preferred way to handle swaps - due to readability.
        public void SwapNumbersSafe(ref ulong a, ref ulong b)
        {
            if (a == b) // Try to short circuit to avoid unnecessary calculations
                return;

            ulong temp = a;
            a = b;
            b = temp;
        }

        // This does not violate the task description from an above-eye view - but Interlocked uses a temp value internally.
        // So technically not a task description violation from my end? :thinking:
        public void SwapNumbersInterlocked(ref ulong a, ref ulong b)
        {
            b = Interlocked.Exchange(ref a, b);
        }

        // Swapping with tuple deconstruction
        public void SwapNumbersDeconstruction(ref ulong a, ref ulong b)
        {
            (a, b) = (b, a);
        }
    }
}
