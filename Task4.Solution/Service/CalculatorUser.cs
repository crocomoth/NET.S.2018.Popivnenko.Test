using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Solution.Interface;

namespace Task4.Solution.Service
{
    public class CalculatorUser
    {
        private Dictionary<string, ICalculator> dictionary;

        public CalculatorUser()
        {
            this.dictionary = new Dictionary<string, ICalculator>();
        }

        public void AddCalculator(ICalculator calculator)
        {
            dictionary.Add(calculator.ToString(),calculator);
        }

        public double GetAverage(List<double> list, string caclType)
        {
            var calculator = dictionary.First((x) => x.Key.Equals(caclType));

            return calculator.Value.CalculateAverage(list);
        }
    }
}
