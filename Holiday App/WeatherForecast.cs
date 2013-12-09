using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Holiday_App
{
    public static class DocumentExtensions
    {
        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();
            using (var xmlReader = xDocument.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }
            return xmlDocument;
        }

        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }
    }
    public partial class WeatherForecast : Form
    {

        public WeatherForecast(string startDate, string endDate, string dest)
        {
            InitializeComponent();
            parseData(dest,startDate);
            
        }



        private void parseData(string dest,string date)
        {
            

           // DateTime firstDateDT = Convert.ToDateTime(firstFixedString[1]);
           // DateTime.ParseExact(firstFixedString, "yy/MM/dd", CultureInfo.InvariantCulture);


            HTTPIO gwc = new HTTPIO();
            
            XDocument XMLDoc = gwc.getWeatherForecastXML(dest);
            XmlDocument xml = XMLDoc.ToXmlDocument();
            

            IEnumerable att = (IEnumerable)XMLDoc.XPathEvaluate("/weatherdata/forecast/time/@from");
            Console.WriteLine(att.Cast<XAttribute>().FirstOrDefault());
            
            string str = att.Cast<XAttribute>().FirstOrDefault().ToString();
            string[] returnedString = fixDateString(str, date);
            
            if (returnedString[0] == returnedString[1])
            {
                string nodeString = "/weatherdata/forecast/time/[@from='" + returnedString[0] + "']";
                XmlNodeList xnl = xml.SelectNodes(nodeString);

            }


           richTextBox1.Text = XMLDoc.ToString();

           /* IEnumerable att = (IEnumerable)XMLDoc.XPathEvaluate("/current/weather/@value");
            Console.WriteLine(att.Cast<XAttribute>().FirstOrDefault());
            string str = att.Cast<XAttribute>().FirstOrDefault().ToString();
               
                */
        }
        private string[] fixDateString (string firstString, string secondString)
        {

            string[] firstDateSplit = (secondString.Split(':'));
            string firstDateFixer = firstDateSplit[2];
            string[] firstFixedString = firstDateFixer.Split(' ');
            string[] resultsNonXML = firstString.Split('"');
            string[] results = firstString.Split('T');

            firstString = results[0];
            string[] test = firstString.Split('"');
            test[1] = test[1].Replace('-', '/');
            string[] arrayDate = test[1].Split('/');


            string[] fixedArrayDate = new string[3];
            fixedArrayDate[0] = arrayDate[2];
            fixedArrayDate[1] = arrayDate[1];
            fixedArrayDate[2] = arrayDate[0];
            string secondFixedString = (fixedArrayDate[0] + "/" + fixedArrayDate[1] + "/" + fixedArrayDate[2]);
            string[] returnString = { secondFixedString, firstFixedString[1] };
            


            return returnString;
        }
       



    }
   
}
