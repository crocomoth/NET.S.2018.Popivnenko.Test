using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.Interface;

namespace Task5.Solution.DocParts
{
    public class HyperLink : DocumentPart
    {
        public string Url { get; set; }

        public HyperLink(string text, string url)
        {
            this.PartType = this.ToString();
            this.Text = text;
            this.Url = url;
        }

        public override string ToString()
        {
            return "hyper";
        }
    }
}
