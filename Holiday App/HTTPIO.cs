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
        private HttpWebRequest httpReq;
        private HttpWebResponse response;
        private Stream readStream;
        private StreamReader streamreader;
        private string responseString;
        private XDocument XMLDoc;
        static string HTTPRequest(string location) // constrcutor which takes the location string
        {

            return null;
        }


        public string getWeatherJSON(string location)
        {
            string str = "";
            try
            {

                httpReq = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + location + "&mode=xml"); //  starts a web request to an api hosted by openweathermap which returns an xml document with weather data
                response = (HttpWebResponse)httpReq.GetResponse(); // recieves the response
                readStream = response.GetResponseStream(); // the stream reader reads the response
                streamreader = new StreamReader(readStream, Encoding.UTF8); // sets it to a stream reader with the UTF8 encoding
                responseString = streamreader.ReadToEnd(); // reads ther esponse to a string
             

                XMLDoc = XDocument.Parse(responseString); // parses the recieved document into an object intended for working with xml documents


                IEnumerable att = (IEnumerable)XMLDoc.XPathEvaluate("/current/weather/@icon"); // the node we are interested in
               
                Console.WriteLine(att.Cast<XAttribute>().FirstOrDefault()); // debug info
                str = att.Cast<XAttribute>().FirstOrDefault().ToString(); // sets the string str to the found node

                string[] results = str.Split('"'); // splits it by the " character to get the data we are after split up

                return results[1];
                
            }
            catch (System.Net.WebException e) // if an exception was thrown, this will execute
            {

                return e.ToString();

            }
            //string responseWeather = returnIcon(responseString);



        }

        public double getDistance(string start, string end) // this method works out the distance between two locations
        {

            httpReq = (HttpWebRequest)WebRequest.Create("http://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + start + "&destinations=" + end + "&sensor=false"); // same as above but queries google map API with the two location
            response = (HttpWebResponse)httpReq.GetResponse();
            readStream = response.GetResponseStream();
            streamreader = new StreamReader(readStream, Encoding.UTF8);
            responseString = streamreader.ReadToEnd();
            XMLDoc = XDocument.Parse(responseString);
            XElement distElement = XMLDoc.Descendants("distance").FirstOrDefault();
            XElement textElement = distElement.Descendants("value").FirstOrDefault();
            double distance = double.Parse(textElement.Value.ToString());
            return distance;
        }

    }
}
