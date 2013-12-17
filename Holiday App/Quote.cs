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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Threading;

namespace Holiday_App
{
    public partial class Quote : Form
    {

        bool isFinnished = false;
        double distance;
        double price;
        int numberOfPassangers;
        public Quote(string holidayType, string testString, string inputAirport, string DestAirport)
        {
            InitializeComponent();

            callClass(holidayType);
            lblResults.Text = testString;
            numberOfPassangers = int.Parse(testString);
            Thread t = new Thread(() => getPrice(inputAirport, DestAirport));
            t.Start();
       
            
        }
        private void callClass(string holType)
        {


            switch (holType)
            {

                case "Just Flights":
                    HolidayTypeClasses.JustFlights holiday = new HolidayTypeClasses.JustFlights(numberOfPassangers,false);
                    break;
                case "Relax":
                    MessageBox.Show("relax");
                    break;
                case "Adventure":
                    MessageBox.Show("Adventure");
                    break;
                case "Cultural":
                    MessageBox.Show("Cultraul");
                    break;

                default:
                    MessageBox.Show("something went wrong");
                    break;
                // Just Flights
                //Relax
                //Cultural
                //Adventure
            }

        }
        private void Quote_Load(object sender, EventArgs e)
        {

        }
       

        private void getPrice(string inputAirport, string destAirport)
        {
            HTTPIO httpIO = new HTTPIO();

            distance = httpIO.getDistance(inputAirport, destAirport);
            distance = distance * 0.001;
            
            if (distance == 0)
            {

                MessageBox.Show("Something went wrong");

            }
            else if (distance > 0 && distance < 99)
            {
                MessageBox.Show("between 0 and 99");
                price = distance / 2;


            }
            else if (distance > 100 && distance < 500)
            {

                MessageBox.Show("Between 100 and 500");
                price = distance / 10;

            }
            else if (distance > 500 && distance < 750)
            {

                MessageBox.Show("between 500 & 750");
                price = distance / 9;

            }
            else if (distance > 750 && distance < 1250)
            {

                MessageBox.Show("between 750 & 1250");
                price = distance / 3;
            }
            else if (distance > 1250)
            {
                price = distance / 5;


            }
            

           
            isFinnished = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isFinnished == true)
            {

                lblBasePrice.Text = ("£" + (price * numberOfPassangers).ToString() );
                timer1.Enabled = false;

            }
        }

        
    }
}
