using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.DocParts;
using Task5.Solution.Interface;

namespace Task5.Solution.Converter
{
    public class PlainConverter : IConverter
    {
        public string Convert(DocumentPart documentPart)
        {
            switch (documentPart.PartType)
            {
                case "bold":
                    return ConvertBold(documentPart.Text);
                case "hyper":
                    HyperLink link = (HyperLink)documentPart;
                    return ConvertHyper(documentPart.Text, link.Url);
                case "plain":
                    return ConvertPlain(documentPart.Text);
                default:
                    return String.Empty;
            }
        }

        private string ConvertBold(string data)
        {
            return "**" + data + "**";
        }

        private string ConvertHyper(string data, string url)
        {
            return data + " [" + url + "]";
        }

        private string ConvertPlain(string data)
        {
            return data;
        }
    }
}
