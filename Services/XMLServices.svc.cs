using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;
using System.IO;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class XMLServices : IXMLServices
    {
        public string verification(string xmlUrl, string xsdUrl)
        {
            //Set up XML Document and Schema
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", xsdUrl);
            XmlReader rd = XmlReader.Create(xmlUrl);
            XDocument doc = XDocument.Load(rd);

            //Attempt validation
            try
            {
                doc.Validate(schema, ValidationEventHandler);
            }
            catch (Exception e)
            {
                //Return error message if validation fails
                return "Error found: " + e.Message;
            }
            //return normally if validation succeeds
            return "No Error";
        }

        public string XPathSearch(string xmlUrl, string path)
        {
            //XML doc setup
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlUrl);

            //XML node to search for
            XmlNode node = doc.DocumentElement.SelectSingleNode(path);

            string children = "";

            foreach(XmlNode child in node.ChildNodes)
            {
                children += child.Name;
            }

            return children;
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            //Event callback function - throws an error if validation fails.
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error)
                    throw new Exception(e.Message);
            }
        }
    }
}
