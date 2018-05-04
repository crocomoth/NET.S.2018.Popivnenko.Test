using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Solution.Interface;

namespace Task4.Solution.Service
{
    public class MeanCalculator : ICalculator
    {
        public double CalculateAverage(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
