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
 *  that it will be useful, but WITHOUT ANY WARRANTY; without even the implied  *                                                *
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.             *
 * See the GNU General Public License for more details.                         *         *
 *                                                                              *
 * You should have received a copy of the GNU General Public License            *
 * along with  My Holiday planning coursework app.                              *
 * If not, see <http://www.gnu.org/licenses/>.                                  *
 *                                                                              *
 *******************************************************************************/

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
            try
            {
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


            catch (FileNotFoundException e)
            {

                throw new FileNotFoundException(@"[data now found, please reinstall]",e);
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