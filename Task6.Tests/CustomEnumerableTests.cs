using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;
using Test6.Solution.Interface;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            ISequenceGenerator<int> generator = new SequenceGenerator<int>();

            var list = generator.GenerateSequence(10, 1, 1, (x, y) => x + y);

            int[] actual = list.ToArray();

            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            CollectionAssert.AreEqual(expected,actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            ISequenceGenerator<int> generator = new SequenceGenerator<int>();

            var list = generator.GenerateSequence(10, 1, 2, (x, y) => 6 * y - 8 * x);

            int[] actual = list.ToArray();

            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            CollectionAssert.AreEqual(expected,actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            ISequenceGenerator<double> sequenceGenerator = new SequenceGenerator<double>();

            var list = sequenceGenerator.GenerateSequence(10, 1, 2, ((d, d1) => d1 + d / d1));

            var actual = list.ToArray();

            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i],actual[i],0.000001);
            }
        }
    }
}
