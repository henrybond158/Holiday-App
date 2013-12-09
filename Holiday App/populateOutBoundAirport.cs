using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace Holiday_App
{
    class populateOutBoundAirport
    {

        public string[] initLists()
        {
            string[] returnString = null;
            XElement element = XElement.Load("XMLFile1.xml");
            Console.WriteLine(element.Value);
            using (XmlReader reader = XmlReader.Create("XMLFile1.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Airports":

                                break;
                            case "AllAirport":
                                string attribute = reader["airports"];
                                if (attribute != null)
                                {

                                }
                                if (reader.Read())
                                {

                                    string returnStringUnp = reader.Value.Trim();
                                    returnString = returnStringUnp.Split(',');
                                    return returnString;
                                }
                                Console.WriteLine();
                                break;
                            default:

                                break;
                        }



                    }


                }
                return null;
            }

        }

        public string[] updateLists(string selected)
        {
            string[] returnString = null;
            XElement element = XElement.Load("XMLFile1.xml");
            Console.WriteLine(element.Value);
            using (XmlReader reader = XmlReader.Create("XMLFile1.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {

                        if (selected == reader.Name)
                        {
                            string attribute = reader["airports"];
                            if (attribute != null)
                            {

                            }
                            if (reader.Read())
                            {

                                string returnStringUnp = reader.Value.Trim();
                                returnString = returnStringUnp.Split(',');
                                return returnString;
                            }
                            
                        }


                    }
                    
                }

               
            }
            return null;
        }
    }
}