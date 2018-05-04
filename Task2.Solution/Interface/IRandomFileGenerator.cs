using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution.Interface
{
    public interface IRandomFileGenerator
    {
        void GenerateFiles(int filesCount, int contentLength);

        string WorkingDirectory { get; set; }

        string FileExtension { get;}
    }
}
