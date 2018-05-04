using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test6.Solution.Interface;

namespace Test6.Solution
{
    public class SequenceGenerator<T> : ISequenceGenerator<T>
    {
        private Functor<T> functor;

        public SequenceGenerator()
        {
            
        }

        public List<T> GenerateSequence(int num, T firstElem,T second , Func<T, T, T> nextElemDelegate)
        {
            functor = new Functor<T>(firstElem,second, nextElemDelegate);

            var list = new List<T>(functor.Take(num));

            return list;
        }
    }
}
