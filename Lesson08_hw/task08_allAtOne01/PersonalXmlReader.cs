using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace task08_allAtOne01
{
    public class PersonalXmlReader
    {
        public static string ReadNodeText(int taskNum, string nodeName)
        {
            XmlDocument xmlDocument = new();
            try
            {
                xmlDocument.Load("..\\..\\..\\lesson8tasks.xml");
                XmlElement? xRoot = xmlDocument.DocumentElement;
                XmlNode? taskNode = xRoot?.SelectSingleNode($"task[@number='{taskNum}']").SelectSingleNode(nodeName);
                if (taskNode is not null)
                {
                    return taskNode.InnerText;
                    //Console.WriteLine(taskNode.InnerText);
                }
                else return "  file not found";
            }
            catch 
            {
                try
                {
                    xmlDocument.Load("lesson8tasks.xml");
                    XmlElement? xRoot = xmlDocument.DocumentElement;
                    XmlNode? taskNode = xRoot?.SelectSingleNode($"task[@number='{taskNum}']").SelectSingleNode(nodeName);
                    if (taskNode is not null)
                    {
                        return taskNode.InnerText;
                        //Console.WriteLine(taskNode.InnerText);
                    }
                    else return "  file not found";
                }
                catch { return "  file not found"; }
            }
            
        }
    }
}
