using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbanq.Algorithms
{

    public class ElementsOccurMoreThanOnce
    {
        // This is a solution which would be preffered by most C# developers.
        // Since it uses Linq, an integral part of C# development.
        // It is, however, not the most performant with all the allocation.
        public IEnumerable<T> ElementsThatOccurMoreThanOnce_UsingLinq<T>(IEnumerable<T> array)
        {
            return array.GroupBy(x => x).Where(y => y.Count() > 1).SelectMany(y => y);
        }

        // HashSet solution for this task
        // Returns elements in the order in which they appear more than once.
        public IEnumerable<T> ElementsThatOccurMoreThanOnce_UsingHashSet<T>(IEnumerable<T> array)
        {
            HashSet<T> hashset = new();
            HashSet<T> returnable = new();

            foreach (var element in array)
            {
                if (!hashset.Add(element))
                {
                    returnable.Add(element);
                }
            }

            return returnable;
        }
    }
}
