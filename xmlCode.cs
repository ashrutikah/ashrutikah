using System;
using System.Xml;
using System.Text;

namespace ConsoleApplication1
{
    class UserProgramCode 
    {
        public static string getnodeByName(string xmlString)
        {
             
            //string xmlString = "<Names> <Name> <FirstName>John</FirstName><LastName>Smith</LastName></Name><Name><FirstName>James</FirstName> <LastName>White</LastName></Name></Names>";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            XmlNodeList xNodeList= xmlDoc.ChildNodes[0].ChildNodes;
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode xNode in xNodeList)
            {
                foreach (XmlNode xNode1 in xNode.ChildNodes)
                {
                    sb.Append(xNode1.InnerXml + " ");
                }
                
            }

            return sb.ToString();
        }

        //public static void Main()
        //{
        //    string xmlString = Console.ReadLine();
        //    Console.WriteLine(getnodeByName(xmlString));
        //}
    }
    
}
