using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileReadWrite;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //5th:update cdata node value
            string strPath = "C:\\GIT\\CsharpJavaLearning\\ConsoleApp1\\ConsoleApp1\\XmlSample.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strPath);

            //changing value of first child
            doc.DocumentElement.SelectSingleNode("//entities").FirstChild.Value = "Blue";

            //changing value of second child from Black to white/white to Black
            string p = doc.DocumentElement.SelectSingleNode("//entities").ChildNodes.Item(1).Value;
            if(p == "Black")
            {
                doc.DocumentElement.SelectSingleNode("//entities").ChildNodes.Item(1).Value = "White";
            }
            else if (p == "White")
            {
                doc.DocumentElement.SelectSingleNode("//entities").ChildNodes.Item(1).Value = "Black";
            }
            doc.Save(strPath);

            /*
            
             //4th: Adding and updating nodes in XML
            string strPath = "C:\\GIT\\CsharpJavaLearning\\ConsoleApp1\\ConsoleApp1\\Sample.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(strPath);

            //updating existing node value
            XmlNode strNode = (XmlElement)doc.SelectSingleNode("/emails/email[2]/from");
            string s = strNode.InnerText;
            string val = "Anuja";
            strNode.InnerText = val;

            //Adding new node and value
            XmlNodeList strNodes1 = doc.SelectNodes("/emails/email[1]");
            foreach(XmlNode node in strNodes1)
            { 
                
                XmlElement ele = doc.CreateElement("subject");
                XmlElement ele2 = (XmlElement)doc.SelectSingleNode("/emails/email[1]/heading");
                node.InsertAfter(ele, ele2);
            }

            XmlNodeList strNodes2 = doc.SelectNodes("/emails/email/subject");
            foreach (XmlNode node in strNodes2)
            {
                node.InnerText = "---Adding new subject---";
            }
            doc.Save(strPath);

            */

            //3rd: Read write text file
            //FileReader.ReadFile();
            //FileReader.WriteToFile();

            //2nd: adding two values
            /*int a = 20;
            int b = 29;
            int total=a+b;
            Console.Write("Total {0}+{1} = {2}", a, b, total);
            Console.Read();
            */

            //1st: command line argument
            // Console.WriteLine("Hello...My name is Anuja Kumbhare and " + args[0] + " " +args[1]);
            // Console.Read();
        }
    }
}
