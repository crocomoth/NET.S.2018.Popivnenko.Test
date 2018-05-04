﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Solution.Interface;

namespace Task4.Solution.Service
{
    public class MedianCalculator : ICalculator
    {
        public double CalculateAverage(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();
            int n = sortedValues.Count;
            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
