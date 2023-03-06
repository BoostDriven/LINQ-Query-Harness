using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using SampleSupport;
using System.IO;
using System.Windows.Forms;

namespace SampleQueries
{
    [Title("101+ Linq To Xml Query Samlpes")]
    [Prefix("XLinq")]
    class LinqToXmlSamples : SampleHarness
    {
        public string dataPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\Data\"));

        [Category("Load")]
        [Title("Load document from file")]
        [Description("Load an XML document from file")]
        public void XLinq1()
        {
            XDocument doc = XDocument.Load(dataPath + "bib.xml");
            Console.WriteLine(doc);
        }

        [Category("Load")]
        [Title("Load document from string")]
        [Description("Load document from string")]
        public void XLinq2()
        {
            string xml = "<book price='100' isbn='1002310'>" +
                            "<title>XClarity Samples</title>" +
                            "<author>Matt</author>" +
                         "</book>";

            XDocument doc = XDocument.Parse(xml);
            Console.WriteLine(doc);
        }

        [Category("Load")]
        [Title("Load document from XmlReader")]
        [Description("Load an XML document from XmlReader")]
        public void XLinq3()
        {
            XmlReader reader = XmlReader.Create(dataPath + "bib.xml");
            XDocument doc = XDocument.Load(reader);
            Console.WriteLine(doc);
        }

        [Category("Load")]
        [Title("Element from XmlReader - 1")]
        [Description("Construct XElement from XmlReader positioned on an element")]
        public void XLinq4()
        {
            XmlReader reader = XmlReader.Create(dataPath + "nw_customers.xml");
            reader.Read(); // move to root
            reader.Read(); // move to first customer
            XElement c = (XElement)XNode.ReadFrom(reader);
            Console.WriteLine(c);
        }

        [Category("Load")]
        [Title("Element from XmlReader - 2")]
        [Description("Read XElement content from XmlReader")]
        public void XLinq5()
        {

        }
    }
}
