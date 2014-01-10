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
        // delcares the required public variables required in this class
        bool isFinnished = false;
        double distance;
        double price;
        int hotel;
        int extras;
        int numberOfPassangers;
        bool fc;
        string[] returnData = new string[6];
        string[] namesArrayString;
        public Quote(string holidayType, string numberOfPasangers, string inputAirport, string DestAirport, bool firstClass, string[] namesArray) // the constructor method for this class, taking the data required for creating a quote
        {
            namesArrayString = namesArray; // passes the array of names to the local variable
            fc = firstClass; // sends the firstclass bool to the local variable
            InitializeComponent(); // inbuilt function
            callClass(holidayType); // calls method callClass which calls the correct class for the holiday type selected
            lblResults.Text = numberOfPasangers; // this shows the number of passangers on the quote page
            numberOfPassangers = int.Parse(numberOfPasangers); // turns the string with the number in into an int
            Thread t = new Thread(() => getPrice(inputAirport, DestAirport)); // starts a new thread to start internet operations to stop the program for hanging whilst waiting for results
            t.Start(); // starts the new thread
        }
        private void callClass(string holType) // displays the appropriate data depending on which type of holiday has been selected
        {


            switch (holType) // switching statement on the holiday type string
            {

                case "Just Flights": // if just flights, the just flights class is called
                    HolidayTypeClasses.JustFlights holiday = new HolidayTypeClasses.JustFlights(numberOfPassangers,false);
                    cbHotelReq.Enabled = false; // disables the check boxes as only flights selected
                    cbOption1.Text = "Only flights selected"; // fills with appropriate text
                    cbOption1.Enabled = false;
                    cbOption2.Text = "Only flights selected";
                    cbOption2.Enabled = false;
                    cbOption3.Text = "Only flights selected";
                    cbOption3.Enabled = false;
                    cbOption4.Text = "Only flights selected";
                    cbOption4.Enabled = false;
                    cbHotelReq.Text = "Only flights selected";
                    break;
                case "Relax": // if relax holiday is selected, this executes
                    HolidayTypeClasses.Relax relaxHoliday = new HolidayTypeClasses.Relax(numberOfPassangers, false); // declares class relax and sends it constructor data
                    cbHotelReq.Text = "Hotel Required";
                    returnData = relaxHoliday.initForm(1); // calls method initForm which returns the data to fill out the quote form

                    cbOption1.Text = returnData[0]; // sets the return data to form items
                    cbOption2.Text = returnData[1];
                    cbOption3.Text = returnData[2];
                    cbOption3.Text = returnData[3];
                    cbOption4.Text = returnData[4];
                    lblHolType.Text = returnData[5];
                    break;
                case "Adventure": // same as above
                    HolidayTypeClasses.Relax adveHoliday = new HolidayTypeClasses.Relax(numberOfPassangers, false);
                    cbHotelReq.Text = "Hotel Required";
                    returnData = adveHoliday.initForm(1);
                    cbOption1.Text = returnData[0];
                    cbOption2.Text = returnData[1];
                    cbOption3.Text = returnData[2];
                    cbOption3.Text = returnData[3];
                    cbOption4.Text = returnData[4];
                    lblHolType.Text = returnData[5];
                    break;
                case "Cultural":
                    HolidayTypeClasses.Cultral cultHoliday = new HolidayTypeClasses.Cultral(numberOfPassangers, false);
                    cbHotelReq.Text = "Hotel Required";
                    returnData = cultHoliday.initForm(1);
                    cbOption1.Text = returnData[0];
                    cbOption2.Text = returnData[1];
                    cbOption3.Text = returnData[2];
                    cbOption3.Text = returnData[3];
                    cbOption4.Text = returnData[4];
                    lblHolType.Text = returnData[5];
                    break;

                default:
                    MessageBox.Show("something went wrong"); // debug message
                    break;
            }

        }
        private void Quote_Load(object sender, EventArgs e)
        {

        }


        private void getPrice(string inputAirport, string destAirport)// this is the method started by the new thread
        {
            HTTPIO httpIO = new HTTPIO();  //declares object of class HTTPIO, which is used for internet operations

            distance = httpIO.getDistance(inputAirport, destAirport); // uses class get distance to work out price from the distance
            distance = distance * 0.001; // makes the number more sensible for price calculation
            
            if (distance == 0) // if the distance was zero, something went wrong
            {

                MessageBox.Show("Something went wrong");

            }
            else if (distance > 0 && distance < 99) // calculations to make a sensible price
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
                price = distance / 10;

            }
            else if (distance > 750 && distance < 1250)
            {

                MessageBox.Show("between 750 & 1250");
                price = distance / 5;
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

        private void timer1_Tick(object sender, EventArgs e) // checks to see if http operation was completed
        {
            if (isFinnished == true)
            {
                double basePrice = Math.Round(price, 2, MidpointRounding.ToEven); // sets the price to two decimal places, EG £1.25
                lblBasePrice.Text = (basePrice * numberOfPassangers).ToString(); // sets the price returned from the HTTPIO and mulitplays it by the number of passangers
                timer1.Enabled = false; // turns the timer off
            }
        }
        private void sortData() // organises and bundles data for invoice creation 
        {
            if (cbHostel.Checked) // this creates the cost for the hotel selected
            {
                hotel = 10 * numberOfPassangers;

            }
            else if (cbLEH.Checked)
            {
                hotel = 25 * numberOfPassangers;


            }
            else if (cbMRH.Checked)
            {
                hotel = 50 * numberOfPassangers;
            }
            else if (CBHEH.Checked)
            {

                hotel = 75 * numberOfPassangers;
            }
            else
            {
                hotel = 0;
            }
            if (cbOption1.Checked) // adds cost for the extras selected
            {
                extras = extras +  (10 * numberOfPassangers);   
            }
            if (cbOption2.Checked)
            {
                extras =  extras + (20 * numberOfPassangers);
            }
            if (cbOption3.Checked) 
            {
                extras = extras+ (30 * numberOfPassangers);
            }
            if (cbOption4.Checked)
            {
                extras = extras + (40 * numberOfPassangers);
            }
            if (!cbOption1.Checked && !cbOption2.Checked && !cbOption3.Checked && !cbOption4.Checked)
            {
                extras = 0;
            }
        }
        private void btnStaffView_Click(object sender, EventArgs e) // this method creates the staffView which creatss the invoice
        {
            sortData();
            staffView frm = new staffView(double.Parse(lblBasePrice.Text), hotel, extras, fc, namesArrayString);
            frm.Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbHotelReq.Checked)
            {

                cbHostel.Enabled = false;
                cbLEH.Enabled = false;
                cbMRH.Enabled = false;
                CBHEH.Enabled = false;


            }
            else
            {


                cbHostel.Enabled = true;
                cbLEH.Enabled = true;
                cbMRH.Enabled = true;
                CBHEH.Enabled = true;


            }
        }

        private void cbHostel_CheckedChanged(object sender, EventArgs e)
        {


            if (cbHostel.Checked)
            {
                cbLEH.Enabled = false;
                cbMRH.Enabled = false;
                CBHEH.Enabled = false;
            }
            else
            {
                cbLEH.Enabled = true;
                cbMRH.Enabled = true;
                CBHEH.Enabled = true;
            }
        }

        private void cbLEH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLEH.Checked)
            {
                cbHostel.Enabled = false;
                cbMRH.Enabled = false;
                CBHEH.Enabled = false;
            }
            else
            {
                cbHostel.Enabled = true;
                cbMRH.Enabled = true;
                CBHEH.Enabled = true;
            }
        }

        private void cbMRH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMRH.Checked)
            {
                cbLEH.Enabled = false;
                cbHostel.Enabled = false;
                CBHEH.Enabled = false;
            }
            else
            {
                cbLEH.Enabled = true;
                cbHostel.Enabled = true;
                CBHEH.Enabled = true;
            }

        }

        private void CBHEH_CheckedChanged(object sender, EventArgs e)
        {
            if (CBHEH.Checked)
            {
                cbHostel.Enabled = false;
                cbLEH.Enabled = false;
                cbMRH.Enabled = false;
                cbMRH.Enabled = false;
            }
            else
            {
                cbHostel.Enabled = true;
                cbLEH.Enabled = true;
                cbMRH.Enabled = true;
                cbMRH.Enabled = true;
            }

        }
    }
}
