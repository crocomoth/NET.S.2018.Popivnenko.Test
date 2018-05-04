using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.Interface;

namespace Task5.Solution.DocParts
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text)
        {
            this.PartType = this.ToString();
            this.Text = text;
        }

        public override string ToString()
        {
            return "bold";
        }
    }
}
