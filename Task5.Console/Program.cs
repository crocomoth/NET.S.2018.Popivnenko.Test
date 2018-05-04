using Task5.Solution.Converter;
using Task5.Solution.DocParts;
using Task5.Solution.Interface;

namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5.Solution;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText("Some plain text"),
                    new HyperLink("google.com","https://www.google.by/"),
                    new BoldText("Some bold text")
                };

            Document document = new Document(parts);

            IConverter converter = new HtmlConverter();

            Console.WriteLine(document.ConvertToType(converter));

            Console.ReadLine();
        }
    }
}
