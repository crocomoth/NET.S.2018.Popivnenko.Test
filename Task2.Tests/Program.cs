using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution.Interface;
using Task2.Solution.Service;

namespace Task2.Tests
{
    public static class Program
    {
        public static void Main()
        {
            IRandomFileGenerator bytesGenerator = new RandomBytesFileGenerator(".");
            bytesGenerator.GenerateFiles(1,100);

            IRandomFileGenerator charsGenerator = new RandomCharsFileGenerator(".");
            charsGenerator.GenerateFiles(1,100);

            Console.WriteLine("files where created");
            Console.ReadLine();
        }
    }
}
