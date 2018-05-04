using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution.Interface
{
    public interface IFuncCalculator
    {
        double CalculateAverageByFunction(List<double> values, Func<List<double>, double> func);
    }
}
