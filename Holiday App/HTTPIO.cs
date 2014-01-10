/********************************************************************************
 * This file is part of My Holiday planning coursework app.                     *
 *                                                                              *
 *  My Holiday planning coursework app is free software:                        *
 *  you can redistribute it and/or modify                                       *
 *  it under the terms of the GNU General Public License as published by        *
 *  the Free Software Foundation, either version 3 of the License, or           *
 *  (at your option) any later version.                                         *
 *                                                                              *
 *  My Holiday planning coursework app is distributed in the hope               *
 *  that it will be useful, but WITHOUT ANY WARRANTY; without even the implied  *                                                
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.             *
 * See the GNU General Public License for more details.                         *         
 *                                                                              *
 * You should have received a copy of the GNU General Public License            *
 * along with  My Holiday planning coursework app.                              *
 * If not, see <http://www.gnu.org/licenses/>.                                  *
 *                                                                              *
 *******************************************************************************/

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
