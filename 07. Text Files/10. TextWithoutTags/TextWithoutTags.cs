/* Write a program that extracts from given XML file all the text without the tags.
   Example:
   <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
   <interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student> */

using System;
using System.IO;
using System.Threading;
using System.Xml;

class TextWithoutTags
{
    static void Main()
    {
        XmlDocument xmlFile = new XmlDocument();
        xmlFile.Load("../../Input.xml");
        XmlElement root = xmlFile.DocumentElement;

        StreamWriter writer = new StreamWriter("../../Output.txt");
        using (writer)
        {
            foreach (XmlNode text in root.ChildNodes)
            {
                writer.WriteLine(text.InnerText);
            }
        }

        //Simulating Loading Phase
        Console.Write("Processing");
        for (int i = 0; i < 21; i++)
        {
            Console.Write(".");
            Thread.Sleep(150);
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("DONE!");
    }
}
