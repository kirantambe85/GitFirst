using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MoorepayDemo.Utils
{
    public class Browsers
    {
        public String SelectBrowser(String browserToSelect, String fileName)
        {
            //string startupPath = System.IO.Directory.GetCurrentDirectory();
            //string frameWorkPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(startupPath)));
            //string configDir = Path.Combine(frameWorkPath + "\\Ingenta.Framework\\Browser\\" + fileName);

            //string configDir = @"C:\MoorepayDemo\MoorepayDemo\MoorepayDemo\Resources\" + fileName;
            string configDir = @"MoorepayDemo\Resources\" + fileName;

            // This is to load the config.xml file
            XmlTextReader reader = new XmlTextReader(configDir);
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            // Move the control to 'Configuration' node.
            XmlNode parentNode = doc.SelectSingleNode("browsers");

            // get the list of 'Project' node.
            XmlNode browser = parentNode.SelectSingleNode(browserToSelect);

            String selectedBrowser = browser.InnerText.Trim();

            reader.Close();
            reader.Dispose();
            return selectedBrowser;
        }
    }
}
