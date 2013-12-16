using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;


namespace Holiday_App
{
    class HTTPIO
    {
        static string HTTPRequest(string location)
        {

            return null;
        }


        public string getWeatherJSON(string location)
        {
            string str = "";
            try
            {
                
                HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + location + "&mode=xml");
                HttpWebResponse response = (HttpWebResponse)httpReq.GetResponse();
                Stream readStream = response.GetResponseStream();
                StreamReader streamreader = new StreamReader(readStream, Encoding.UTF8);
                string responseString = streamreader.ReadToEnd();
             

                XDocument XMLDoc = XDocument.Parse(responseString);


                IEnumerable att = (IEnumerable)XMLDoc.XPathEvaluate("/current/weather/@value");
                Console.WriteLine(att.Cast<XAttribute>().FirstOrDefault());
                str = att.Cast<XAttribute>().FirstOrDefault().ToString();
               
                
                string[] results = str.Split('"');

                return results[1];
            }
            catch (System.Net.WebException e)
            {

                return e.ToString();

            }
            //string responseWeather = returnIcon(responseString);



        }

        public double getDistance(string start, string end)
        {

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + start + "&destinations=" + end + "&sensor=false");
            HttpWebResponse response = (HttpWebResponse)httpReq.GetResponse();
            Stream readStream = response.GetResponseStream();
            StreamReader streamreader = new StreamReader(readStream, Encoding.UTF8);
            string responseString = streamreader.ReadToEnd();
            XDocument XMLDoc = XDocument.Parse(responseString);
            XElement distElement = XMLDoc.Descendants("distance").FirstOrDefault();
            XElement textElement = distElement.Descendants("value").FirstOrDefault();
            double distance = double.Parse(textElement.Value.ToString());
            return distance;
        }

    }
}
