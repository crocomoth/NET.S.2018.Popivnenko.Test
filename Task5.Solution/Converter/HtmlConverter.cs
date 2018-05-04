using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Solution.DocParts;
using Task5.Solution.Interface;

namespace Task5.Solution.Converter
{
    public class HtmlConverter : IConverter
    {
        public string Convert(DocumentPart documentPart)
        {
            switch (documentPart.PartType)
            {
                case "bold":
                    return ConvertBold(documentPart.Text);
                case "hyper":
                    HyperLink link = (HyperLink) documentPart;
                    return ConvertHyper(documentPart.Text, link.Url);
                case "plain":
                    return ConvertPlain(documentPart.Text);
                default:
                    return String.Empty;
            }
        }

        private string ConvertBold(string data)
        {
            return "<b>" + data + "</b>";
        }

        private string ConvertHyper(string data, string url)
        {
            return "<a href=\"" + url + "\">" + data + "</a>";
        }

        private string ConvertPlain(string data)
        {
            return data;
        }
    }
}
