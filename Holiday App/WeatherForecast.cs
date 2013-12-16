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

        public WeatherForecast(string startDate, string endDate, string dest)
        {
            InitializeComponent();
            
            Process.Start("http://www.bbc.co.uk/weather/" + workOut(dest));

           
            
        }


        private string workOut(string dest)
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
