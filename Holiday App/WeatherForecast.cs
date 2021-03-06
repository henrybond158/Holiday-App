﻿/********************************************************************************
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
using System.Diagnostics;
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
  
    public partial class WeatherForecast : Form
    {

        public WeatherForecast(string startDate, string endDate, string dest) //the constructor takes the new data
        {
        
            
            Process.Start("http://www.bbc.co.uk/weather/" + workOut(dest)); // starts the default browser 

           
            
        }


        private string workOut(string dest) // class works out the the number of the city for the bbc weather website
        {

            switch (dest)
            {
                case "Edinburgh":
                    return "2650225";
                case "Budapest":
                    return "3054643";
                case "Gatwick":
                    return "6296598";
                case "The Hague":
                    return "2747373";
                case "Glasgow":
                    return "2648579";
                        
                default:
                        return null;
                    

            }
        }
    }
}
