using System;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace ServiceCore
{
    public class Core
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static string ConvertXmlToJson(string xml, bool noIndent = false)
        {
            var doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);
            }
            catch (Exception)
            {
                return "Bad Xml format";
            }
            // Remove possible attributes before serializing
            var allNodes = doc.SelectNodes(".//*");
            if (allNodes != null)
            {
                foreach (XmlElement el in allNodes)
                {
                    el.Attributes.RemoveAll();
                }
            }
            return JsonConvert.SerializeXmlNode(doc, noIndent ? Formatting.None : Formatting.Indented);
        }
    }
}
