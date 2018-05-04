using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution.Interface
{
    public interface ISequenceGenerator<T>
    {
        List<T> GenerateSequence(int num, T firstElem,T second, Func<T,T, T> nextElemDelegate);
    }
}
