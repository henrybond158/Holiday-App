using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Holiday_App
{
    class getWeatherClass
    {


        public void getWeatherJSON(string location)
        {


            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + location);
            HttpWebResponse response = (HttpWebResponse)httpReq.GetResponse();
            Stream readStream = response.GetResponseStream();
            StreamReader streamreader = new StreamReader(readStream, Encoding.UTF8);
            string responseString = streamreader.ReadToEnd();

            


        }
    }
}
