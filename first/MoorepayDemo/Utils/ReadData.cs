using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MoorepayDemo.Utils
{
    class ReadData
    {
        public String GetData(string strNode, String fileName)
        {
            string strDataFilePath = @"C:\MoorepayDemo\MoorepayDemo\MoorepayDemo\Resources\" + fileName;

            XmlTextReader reader = new XmlTextReader(strDataFilePath);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            XmlNode parentNode = doc.SelectSingleNode("siteinfo");

            XmlNode node = parentNode.SelectSingleNode(strNode);

            String strDate = node.InnerText.Trim();

            reader.Close();
            reader.Dispose();

            return strDate;
        }
    }
}
