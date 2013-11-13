using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Holiday_App
{
    class populateOutBoundAirport
    {

        public string[] initLists()
        {

            string line1 = "";

            using (StreamReader fileReader = new StreamReader("airportList.txt"))
            {
                line1 = fileReader.ReadLine();

            }
            string[] airports = line1.Split(',');
            
            return airports;
        }

        public string []updateLists(string selected)
        {
            int counter = 0;
            string[] airportList = new string[16];
            string line;

            using (StreamReader fileReader = new StreamReader("airportList.txt"))
            {
               while ((line = fileReader.ReadLine()) !=null)
               {
                   airportList[counter] = line;
                   counter++;
                   

               }
               fileReader.Close();
                counter = 0;
                string output = "";
               foreach (string str in airportList)
               {
                   int index = str.IndexOf(":");

                   if (index > 0)
                        output = str.Substring(0, index);
                   if (str == selected)
                   {
                       
                      
                       string[] airportsOutBound = output.Split(',');
                       return airportsOutBound;

                   }

                   else
                   {

                        counter++;

                   }

               }
           
            }


            return null;
        }

    }
}
