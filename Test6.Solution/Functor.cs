using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class Functor<T>
    {
        private T currentElem;
        private Func<T, T, T> getNextElem;
        private T previousElem;

        public Functor(T currentElem,T previous, Func<T, T, T> getNextElem)
        {
            this.currentElem = currentElem;
            previousElem = previous;
            this.getNextElem = getNextElem ?? throw new ArgumentNullException(nameof(getNextElem));
        }

        public IEnumerable<T> Take(int count)
        {
            var sequence = Generate(previousElem,currentElem, getNextElem).Take(count);

            return sequence;
        }

        private IEnumerable<T> Generate(T previous,T current, Func<T, T, T> next)
        {
            
            yield return current;
            yield return previous;

            T temp;
            while (true)
            {
                temp = previous;
                previous = next(current,previous);
                current = temp;

                yield return previous;
            }
        }
    }
}
